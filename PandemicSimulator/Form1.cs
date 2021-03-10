using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PandemicSimulator;

namespace PandemicSimulator
{
    public partial class Form1 : Form
    {

        public static string graphFilename = "graph.dot";
        public static int numberOfHumans = 10000;

        public static Random rng;

        public static List<List<List<int>>> graphValue = new List<List<List<int>>>(); // contient les listes de Nodes qui contiennent les listes des differents Etat qui contiennent les valeurs day,x
        /*
         * Vue d'ensemble
             * Piece 1 (1er liste)
             *      Etat "Susceptibe" (2eme liste)
             *          value1 (3eme liste)
             *          value2
             *      Etat "INFECTIOUS" 
             *          value
             *      Etat "REMOVED"
             *          value
             * Piece 2
             *      Etat "Susceptibe"
             *          value
             *      Etat "INFECTIOUS"
             *          value
             *      Etat "REMOVED"
             *          value
             *  etc etc
             */

        int infectiousCount = 1;
        int currentday = 0;

        public Location hogwarts; 
        Graph graph;

        /*
         * SUSCEPTIBLE
            INFECTIOUS
            REMOVED
         */
        public Form1()
        {
            InitializeComponent();
            rng = new Random();
        }

        private void ticks_event(object sender, EventArgs e)
        {
            
            if (infectiousCount == 0)
            {
                timer.Enabled = false;
                startButton.Text = "Start";
                EndingMsg.Text = " pandemic managed after : " + (currentday -1) + " days.";
            }
            else
            {

                // === Update data
                infectiousCount = PandemicSimulator.UpdatePandemic(hogwarts);

                int susceptible = 0;
                int removed = 0;
                foreach (Node node in graph.GetNodes())
                {

                    susceptible += node.GetSIRCount(Human.SIR.SUSCEPTIBLE);
                    removed += node.GetSIRCount(Human.SIR.REMOVED);
                }
                

                // === Update Text
                CasesNbre.Text = "Actual number of cases : " + infectiousCount;
                SusceptibleCases.Text = "Actual number of sucpetible : " + susceptible;
                RemovedCases.Text = "Actual number of removed : " + removed;

                //== Update Graph
                UpdateGraph(currentday);
                currentday++;
            }
            
        }
        
        private void UpdateGraph(int currentDay)
        {
            double totalSusceptible = 0;
            double totalInfectious = 0;
            double totalRemoved = 0;

            // get all the nodes DOT format along the way

            List<Node> AllNodes = graph.GetNodes();

            for (int i = 0; i < AllNodes.Count;i++)
            {
                Node node = AllNodes[i];

                int susceptible = node.GetSIRCount(Human.SIR.SUSCEPTIBLE);
                int infectious = node.GetSIRCount(Human.SIR.INFECTIOUS);
                int removed = node.GetSIRCount(Human.SIR.REMOVED);

                if (LocationComboList.SelectedIndex != -1 && node == (Node)LocationComboList.SelectedItem)
                {
                    SpecificGraph.Series["SUSCEPTIBLE"].Points.AddXY(currentDay, susceptible);
                    SpecificGraph.Series["INFECTIOUS"].Points.AddXY(currentDay, infectious);
                    SpecificGraph.Series["REMOVED"].Points.AddXY(currentDay, removed);


                    SpecificSusceptibleCases.Text = "Number of susceptible : " + susceptible;
                    SpecificCasesNbre.Text = "Number of cases : " + infectious;
                    SpecificRemovedNbre.Text = "Number of removed : " + removed;
                      
                }
                
                // Save Data
                graphValue[i][0].Add(susceptible);
                graphValue[i][1].Add(infectious);
                graphValue[i][2].Add(removed);
                

                totalSusceptible += susceptible;
                totalInfectious += infectious;
                totalRemoved += removed;
            }
            mainChart.Series["SUSCEPTIBLE"].Points.AddXY(currentDay, totalSusceptible);
            mainChart.Series["INFECTIOUS"].Points.AddXY(currentDay, totalInfectious);
            mainChart.Series["REMOVED"].Points.AddXY(currentDay, totalRemoved);

            
        }

        private void StartFunction()
        {
            if (CheckBoxChangeValue.Checked == true)
            {
                Human.GLOBAL_HYGIENE = HygieneLevelCursor.Value / 100f;
                Human.GLOBAL_SOCIAL_DISTANCE = SocialDistanceCursor.Value / 100f;
                Human.GLOBAL_TRAVELLING_RATE = TravellingRateCursor.Value / 100f;
            }
            


            graph = Graph.FromFile("../../../Ressources/" + graphFilename);
            if (graph == null)
            {
                throw new Exception("Failed to create graph: wrong format");
            }

            hogwarts = new Location(graph, numberOfHumans, !CheckBoxChangeValue.Checked);

            if(CustomVirus.Checked == true)
            {
                PandemicSimulator.GLOBAL_TRANSMISSIONRATE = TransmissionRateCursor.Value / 100f;
                PandemicSimulator.GLOBAL_INFECTIONRANGE = InfectionRangeCursor.Value;
                PandemicSimulator.GLOBAL_MAXLIFETIME = MaxLifeTimeCursor.Value;
            }
            else
            { // utilise les valeurs du covid
                PandemicSimulator.GLOBAL_TRANSMISSIONRATE = 0.6;
                PandemicSimulator.GLOBAL_INFECTIONRANGE = 3;
                PandemicSimulator.GLOBAL_MAXLIFETIME = 14;
            }

            PandemicSimulator.InitializePandemic(hogwarts);


            // === reset les textes
            infectiousCount = 1;
            currentday = 0;
            nbHumanTxt.Text = "Number of Humans : " +  numberOfHumans;
            EndingMsg.Text = "";

            mainChart.Titles.Clear();
            mainChart.Titles.Add(graph.GetName());


            // === Add a la combo list
            LocationComboList.Items.Clear();
            LocationComboList.SelectedIndex = -1;
            LocationComboList.Text = "";
            LocationComboList.Items.AddRange( graph.GetNodes().ToArray());

            // == Ajout la liste des nodes pour les coordonnees
            

            foreach (var nodes in graph.GetNodes()) // Ajout dans l'ordre de GetNodes (qui reste contant tout le long du programme)
            {
                graphValue.Add(new List<List<int>>()); // Position1
            }

            for(int position = 0; position < graphValue.Count; position++)
            {
                graphValue[position].Add(new List<int>()); // etat1
                graphValue[position].Add(new List<int>()); // etat2
                graphValue[position].Add(new List<int>()); // etat3
            }
            

        }

        private void startButton_Click(object sender, EventArgs e)
        { 
            if(startButton.Text == "Start")
            {
                StartFunction();
                timer.Enabled = true;
                startButton.Text = "Pause";
            }
            else if (startButton.Text == "Pause")
            {
                timer.Enabled = false;
                startButton.Text = "Start";
            }
            
        }

        private void ClearGraph(System.Windows.Forms.DataVisualization.Charting.Chart graph)
        {
            foreach (var series in graph.Series)
            {
                series.Points.Clear();
            }
            
        }

        private void resetButton_Click(object sender, EventArgs e)
        {

            ClearGraph(mainChart);
            ClearGraph(SpecificGraph);


            

            mainChart.Titles.Clear();
            SpecificGraph.Titles.Clear();

            graphValue.Clear();
            StartFunction();

        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (CheckBoxChangeValue.Checked == true)
            {
                HygieneLevelCursor.Enabled = true;
                HygieneTxt.Text = "Hygiene Level : " + HygieneLevelCursor.Value / 100f;
                


                SocialDistanceCursor.Enabled = true;
                SocialDistanceTxt.Text = "Social Distance : " + SocialDistanceCursor.Value / 100f;
               


                TravellingRateCursor.Enabled = true;
                TravellingRateTxt.Text = "Travelling Rate : " + TravellingRateCursor.Value / 100f;
            }

            else
            {

                HygieneLevelCursor.Enabled = false;
                SocialDistanceCursor.Enabled = false;
                TravellingRateCursor.Enabled = false;
            }
        }

        private void HygieneLevelCursor_Scroll(object sender, EventArgs e)
        {
            HygieneTxt.Text = "Hygiene Level : " + HygieneLevelCursor.Value / 100f;
        }

        private void SocialDistanceCursor_Scroll(object sender, EventArgs e)
        {
            SocialDistanceTxt.Text = "Social Distance : " + SocialDistanceCursor.Value / 100f;
            
        }

        private void TravellingRateCursor_Scroll(object sender, EventArgs e)
        {
            TravellingRateTxt.Text = "Travelling Rate : " + TravellingRateCursor.Value / 100f;
        }

        private void speedVitesseCursor_Scroll(object sender, EventArgs e)
        {
            speedVitesseTxt.Text = "Time between each update : " + speedVitesseCursor.Value + " ms";
            timer.Interval = speedVitesseCursor.Value;

        }

        private void ComboListIndexChanged(object sender, EventArgs e)
        {
            ClearGraph(SpecificGraph);

            for (int etat = 0; etat < graphValue[LocationComboList.SelectedIndex].Count; etat++)
            {
                for (int day = 0; day < graphValue[LocationComboList.SelectedIndex][etat].Count; day++)
                {
                    if (etat == 0)
                    { //Suceptible
                        SpecificGraph.Series["SUSCEPTIBLE"].Points.AddXY(day, graphValue[LocationComboList.SelectedIndex][etat][day]);

                    }
                    else if (etat == 1)
                    {//INFECTIOUS
                        SpecificGraph.Series["INFECTIOUS"].Points.AddXY(day, graphValue[LocationComboList.SelectedIndex][etat][day]);

                    }
                    else if (etat == 2)
                    {// removed
                        SpecificGraph.Series["REMOVED"].Points.AddXY(day, graphValue[LocationComboList.SelectedIndex][etat][day]);
                    }
                }
            }
            SpecificGraph.Titles.Clear();
            SpecificGraph.Titles.Add(LocationComboList.SelectedItem.ToString());

            // == update des texts
            placeInfoTxt.Text = LocationComboList.SelectedItem.ToString() + "'s info :";

            foreach(var node in graph.GetNodes())
            {
                if(node == (Node)LocationComboList.SelectedItem)
                {
                    int susceptible = node.GetSIRCount(Human.SIR.SUSCEPTIBLE);
                    int infectious = node.GetSIRCount(Human.SIR.INFECTIOUS);
                    int removed = node.GetSIRCount(Human.SIR.REMOVED);

                    SpecificSusceptibleCases.Text = "Number of susceptible : " + susceptible;
                    SpecificCasesNbre.Text = "Number of cases : " + infectious;
                    SpecificRemovedNbre.Text = "Number of removed : " + removed;
                }
                
            }
            

        }

        private void TransmissionRateCursor_Scroll(object sender, EventArgs e)
        {
            TransmissionRateTxt.Text = "Transmission Rate : " + TransmissionRateCursor.Value / 100f;
        }

        private void InfectionRangeCursor_Scroll(object sender, EventArgs e)
        {
            InfectionRateTxt.Text = "Infection Rate : " + InfectionRangeCursor.Value;
        }

        private void MaxLifeTimeCursor_Scroll(object sender, EventArgs e)
        {//between 0 and 50
            MaxLifetimeTxt.Text = "Max Lifetime : " + MaxLifeTimeCursor.Value; 
        }

        private void CustomVirus_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomVirus.Checked == true)
            {
                



                TransmissionRateCursor.Enabled = true;
                TransmissionRateTxt.Text = "Transmission Rate : " + TransmissionRateCursor.Value / 100f;

                InfectionRangeCursor.Enabled = true;
                InfectionRateTxt.Text = "Infection Rate : " + InfectionRangeCursor.Value;



                MaxLifeTimeCursor.Enabled = true;
                MaxLifetimeTxt.Text = "Max Lifetime : " + MaxLifeTimeCursor.Value;
            }

            else
            {

                TransmissionRateCursor.Enabled = false;
                InfectionRangeCursor.Enabled = false;
                MaxLifeTimeCursor.Enabled = false;
            }
        }
    }
}
