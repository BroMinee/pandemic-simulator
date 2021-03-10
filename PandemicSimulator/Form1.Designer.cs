
namespace PandemicSimulator
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea19 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend19 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series55 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series56 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series57 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea20 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend20 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series58 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series59 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series60 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.nbHumanTxt = new System.Windows.Forms.Label();
            this.CasesNbre = new System.Windows.Forms.Label();
            this.EndingMsg = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.HygieneLevelCursor = new System.Windows.Forms.TrackBar();
            this.HygieneTxt = new System.Windows.Forms.Label();
            this.SocialDistanceTxt = new System.Windows.Forms.Label();
            this.SocialDistanceCursor = new System.Windows.Forms.TrackBar();
            this.TravellingRateTxt = new System.Windows.Forms.Label();
            this.TravellingRateCursor = new System.Windows.Forms.TrackBar();
            this.CheckBoxChangeValue = new System.Windows.Forms.CheckBox();
            this.LocationComboList = new System.Windows.Forms.ComboBox();
            this.SpecificGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SusceptibleCases = new System.Windows.Forms.Label();
            this.RemovedCases = new System.Windows.Forms.Label();
            this.speedVitesseCursor = new System.Windows.Forms.TrackBar();
            this.speedVitesseTxt = new System.Windows.Forms.Label();
            this.SpecificRemovedNbre = new System.Windows.Forms.Label();
            this.SpecificSusceptibleCases = new System.Windows.Forms.Label();
            this.SpecificCasesNbre = new System.Windows.Forms.Label();
            this.placeInfoTxt = new System.Windows.Forms.Label();
            this.CustomVirus = new System.Windows.Forms.CheckBox();
            this.MaxLifeTimeCursor = new System.Windows.Forms.TrackBar();
            this.MaxLifetimeTxt = new System.Windows.Forms.Label();
            this.InfectionRangeCursor = new System.Windows.Forms.TrackBar();
            this.InfectionRateTxt = new System.Windows.Forms.Label();
            this.TransmissionRateTxt = new System.Windows.Forms.Label();
            this.TransmissionRateCursor = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HygieneLevelCursor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SocialDistanceCursor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TravellingRateCursor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpecificGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedVitesseCursor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxLifeTimeCursor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfectionRangeCursor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransmissionRateCursor)).BeginInit();
            this.SuspendLayout();
            // 
            // mainChart
            // 
            chartArea19.AxisX.Minimum = 0D;
            chartArea19.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea19);
            legend19.Name = "Legend1";
            this.mainChart.Legends.Add(legend19);
            this.mainChart.Location = new System.Drawing.Point(9, 99);
            this.mainChart.Margin = new System.Windows.Forms.Padding(0);
            this.mainChart.Name = "mainChart";
            this.mainChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.mainChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(103)))), ((int)(((byte)(83))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(97)))), ((int)(((byte)(107))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))))};
            series55.ChartArea = "ChartArea1";
            series55.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea100;
            series55.Legend = "Legend1";
            series55.Name = "INFECTIOUS";
            series55.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series55.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series56.ChartArea = "ChartArea1";
            series56.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea100;
            series56.Legend = "Legend1";
            series56.Name = "SUSCEPTIBLE";
            series56.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series56.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series57.ChartArea = "ChartArea1";
            series57.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea100;
            series57.Legend = "Legend1";
            series57.Name = "REMOVED";
            series57.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series57.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            this.mainChart.Series.Add(series55);
            this.mainChart.Series.Add(series56);
            this.mainChart.Series.Add(series57);
            this.mainChart.Size = new System.Drawing.Size(1150, 348);
            this.mainChart.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.ticks_event);
            // 
            // nbHumanTxt
            // 
            this.nbHumanTxt.AutoSize = true;
            this.nbHumanTxt.Location = new System.Drawing.Point(971, 179);
            this.nbHumanTxt.Name = "nbHumanTxt";
            this.nbHumanTxt.Size = new System.Drawing.Size(102, 13);
            this.nbHumanTxt.TabIndex = 1;
            this.nbHumanTxt.Text = "Number of Human : ";
            // 
            // CasesNbre
            // 
            this.CasesNbre.AutoSize = true;
            this.CasesNbre.Location = new System.Drawing.Point(971, 243);
            this.CasesNbre.Name = "CasesNbre";
            this.CasesNbre.Size = new System.Drawing.Size(127, 13);
            this.CasesNbre.TabIndex = 2;
            this.CasesNbre.Text = "Actual number of cases : ";
            // 
            // EndingMsg
            // 
            this.EndingMsg.AutoSize = true;
            this.EndingMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.EndingMsg.Location = new System.Drawing.Point(717, 12);
            this.EndingMsg.Name = "EndingMsg";
            this.EndingMsg.Size = new System.Drawing.Size(0, 20);
            this.EndingMsg.TabIndex = 3;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(543, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(636, 12);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // HygieneLevelCursor
            // 
            this.HygieneLevelCursor.Enabled = false;
            this.HygieneLevelCursor.LargeChange = 50;
            this.HygieneLevelCursor.Location = new System.Drawing.Point(1177, 115);
            this.HygieneLevelCursor.Maximum = 99;
            this.HygieneLevelCursor.Name = "HygieneLevelCursor";
            this.HygieneLevelCursor.Size = new System.Drawing.Size(330, 45);
            this.HygieneLevelCursor.SmallChange = 20;
            this.HygieneLevelCursor.TabIndex = 10;
            this.HygieneLevelCursor.Scroll += new System.EventHandler(this.HygieneLevelCursor_Scroll);
            // 
            // HygieneTxt
            // 
            this.HygieneTxt.AutoSize = true;
            this.HygieneTxt.Location = new System.Drawing.Point(1174, 99);
            this.HygieneTxt.Name = "HygieneTxt";
            this.HygieneTxt.Size = new System.Drawing.Size(84, 13);
            this.HygieneTxt.TabIndex = 12;
            this.HygieneTxt.Text = "Hygiene Level : ";
            // 
            // SocialDistanceTxt
            // 
            this.SocialDistanceTxt.AutoSize = true;
            this.SocialDistanceTxt.Location = new System.Drawing.Point(1174, 163);
            this.SocialDistanceTxt.Name = "SocialDistanceTxt";
            this.SocialDistanceTxt.Size = new System.Drawing.Size(90, 13);
            this.SocialDistanceTxt.TabIndex = 13;
            this.SocialDistanceTxt.Text = "Social Distance : ";
            // 
            // SocialDistanceCursor
            // 
            this.SocialDistanceCursor.Enabled = false;
            this.SocialDistanceCursor.LargeChange = 50;
            this.SocialDistanceCursor.Location = new System.Drawing.Point(1177, 179);
            this.SocialDistanceCursor.Maximum = 99;
            this.SocialDistanceCursor.Name = "SocialDistanceCursor";
            this.SocialDistanceCursor.Size = new System.Drawing.Size(330, 45);
            this.SocialDistanceCursor.SmallChange = 20;
            this.SocialDistanceCursor.TabIndex = 14;
            this.SocialDistanceCursor.Scroll += new System.EventHandler(this.SocialDistanceCursor_Scroll);
            // 
            // TravellingRateTxt
            // 
            this.TravellingRateTxt.AutoSize = true;
            this.TravellingRateTxt.Location = new System.Drawing.Point(1174, 227);
            this.TravellingRateTxt.Name = "TravellingRateTxt";
            this.TravellingRateTxt.Size = new System.Drawing.Size(88, 13);
            this.TravellingRateTxt.TabIndex = 15;
            this.TravellingRateTxt.Text = "Travelling Rate : ";
            // 
            // TravellingRateCursor
            // 
            this.TravellingRateCursor.Enabled = false;
            this.TravellingRateCursor.LargeChange = 50;
            this.TravellingRateCursor.Location = new System.Drawing.Point(1177, 243);
            this.TravellingRateCursor.Maximum = 99;
            this.TravellingRateCursor.Name = "TravellingRateCursor";
            this.TravellingRateCursor.Size = new System.Drawing.Size(330, 45);
            this.TravellingRateCursor.SmallChange = 20;
            this.TravellingRateCursor.TabIndex = 16;
            this.TravellingRateCursor.Scroll += new System.EventHandler(this.TravellingRateCursor_Scroll);
            // 
            // CheckBoxChangeValue
            // 
            this.CheckBoxChangeValue.AutoSize = true;
            this.CheckBoxChangeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.CheckBoxChangeValue.Location = new System.Drawing.Point(1177, 75);
            this.CheckBoxChangeValue.Name = "CheckBoxChangeValue";
            this.CheckBoxChangeValue.Size = new System.Drawing.Size(207, 21);
            this.CheckBoxChangeValue.TabIndex = 18;
            this.CheckBoxChangeValue.Text = "Use custom value for human";
            this.CheckBoxChangeValue.UseVisualStyleBackColor = true;
            this.CheckBoxChangeValue.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LocationComboList
            // 
            this.LocationComboList.FormattingEnabled = true;
            this.LocationComboList.Location = new System.Drawing.Point(694, 467);
            this.LocationComboList.Name = "LocationComboList";
            this.LocationComboList.Size = new System.Drawing.Size(121, 21);
            this.LocationComboList.TabIndex = 19;
            this.LocationComboList.SelectionChangeCommitted += new System.EventHandler(this.ComboListIndexChanged);
            // 
            // SpecificGraph
            // 
            chartArea20.AxisX.Minimum = 0D;
            chartArea20.Name = "ChartArea1";
            this.SpecificGraph.ChartAreas.Add(chartArea20);
            legend20.Name = "Legend1";
            this.SpecificGraph.Legends.Add(legend20);
            this.SpecificGraph.Location = new System.Drawing.Point(9, 491);
            this.SpecificGraph.Margin = new System.Windows.Forms.Padding(0);
            this.SpecificGraph.Name = "SpecificGraph";
            this.SpecificGraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.SpecificGraph.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(103)))), ((int)(((byte)(83))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(97)))), ((int)(((byte)(107))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))))};
            series58.ChartArea = "ChartArea1";
            series58.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea100;
            series58.Legend = "Legend1";
            series58.Name = "INFECTIOUS";
            series58.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series58.YValuesPerPoint = 6;
            series58.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series59.ChartArea = "ChartArea1";
            series59.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea100;
            series59.Legend = "Legend1";
            series59.Name = "SUSCEPTIBLE";
            series59.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series59.YValuesPerPoint = 6;
            series59.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series60.ChartArea = "ChartArea1";
            series60.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea100;
            series60.Legend = "Legend1";
            series60.Name = "REMOVED";
            series60.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series60.YValuesPerPoint = 6;
            series60.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            this.SpecificGraph.Series.Add(series58);
            this.SpecificGraph.Series.Add(series59);
            this.SpecificGraph.Series.Add(series60);
            this.SpecificGraph.Size = new System.Drawing.Size(1150, 348);
            this.SpecificGraph.TabIndex = 20;
            this.SpecificGraph.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(513, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "Overall View";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(503, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 31);
            this.label2.TabIndex = 22;
            this.label2.Text = "Specific View";
            // 
            // SusceptibleCases
            // 
            this.SusceptibleCases.AutoSize = true;
            this.SusceptibleCases.Location = new System.Drawing.Point(971, 211);
            this.SusceptibleCases.Name = "SusceptibleCases";
            this.SusceptibleCases.Size = new System.Drawing.Size(152, 13);
            this.SusceptibleCases.TabIndex = 23;
            this.SusceptibleCases.Text = "Actual number of susceptible : ";
            // 
            // RemovedCases
            // 
            this.RemovedCases.AutoSize = true;
            this.RemovedCases.Location = new System.Drawing.Point(971, 275);
            this.RemovedCases.Name = "RemovedCases";
            this.RemovedCases.Size = new System.Drawing.Size(140, 13);
            this.RemovedCases.TabIndex = 24;
            this.RemovedCases.Text = "Actual number of removed : ";
            // 
            // speedVitesseCursor
            // 
            this.speedVitesseCursor.LargeChange = 50;
            this.speedVitesseCursor.Location = new System.Drawing.Point(1169, 705);
            this.speedVitesseCursor.Maximum = 500;
            this.speedVitesseCursor.Minimum = 10;
            this.speedVitesseCursor.Name = "speedVitesseCursor";
            this.speedVitesseCursor.Size = new System.Drawing.Size(330, 45);
            this.speedVitesseCursor.SmallChange = 20;
            this.speedVitesseCursor.TabIndex = 25;
            this.speedVitesseCursor.Value = 100;
            this.speedVitesseCursor.Scroll += new System.EventHandler(this.speedVitesseCursor_Scroll);
            // 
            // speedVitesseTxt
            // 
            this.speedVitesseTxt.AutoSize = true;
            this.speedVitesseTxt.Location = new System.Drawing.Point(1174, 689);
            this.speedVitesseTxt.Name = "speedVitesseTxt";
            this.speedVitesseTxt.Size = new System.Drawing.Size(180, 13);
            this.speedVitesseTxt.TabIndex = 26;
            this.speedVitesseTxt.Text = "Time between each update : 100 ms";
            // 
            // SpecificRemovedNbre
            // 
            this.SpecificRemovedNbre.AutoSize = true;
            this.SpecificRemovedNbre.Location = new System.Drawing.Point(971, 689);
            this.SpecificRemovedNbre.Name = "SpecificRemovedNbre";
            this.SpecificRemovedNbre.Size = new System.Drawing.Size(109, 13);
            this.SpecificRemovedNbre.TabIndex = 30;
            this.SpecificRemovedNbre.Text = "Number of removed : ";
            // 
            // SpecificSusceptibleCases
            // 
            this.SpecificSusceptibleCases.AutoSize = true;
            this.SpecificSusceptibleCases.Location = new System.Drawing.Point(971, 625);
            this.SpecificSusceptibleCases.Name = "SpecificSusceptibleCases";
            this.SpecificSusceptibleCases.Size = new System.Drawing.Size(121, 13);
            this.SpecificSusceptibleCases.TabIndex = 29;
            this.SpecificSusceptibleCases.Text = "Number of susceptible : ";
            // 
            // SpecificCasesNbre
            // 
            this.SpecificCasesNbre.AutoSize = true;
            this.SpecificCasesNbre.Location = new System.Drawing.Point(971, 657);
            this.SpecificCasesNbre.Name = "SpecificCasesNbre";
            this.SpecificCasesNbre.Size = new System.Drawing.Size(96, 13);
            this.SpecificCasesNbre.TabIndex = 28;
            this.SpecificCasesNbre.Text = "Number of cases : ";
            // 
            // placeInfoTxt
            // 
            this.placeInfoTxt.AutoSize = true;
            this.placeInfoTxt.Location = new System.Drawing.Point(971, 587);
            this.placeInfoTxt.Name = "placeInfoTxt";
            this.placeInfoTxt.Size = new System.Drawing.Size(31, 13);
            this.placeInfoTxt.TabIndex = 31;
            this.placeInfoTxt.Text = "Info :";
            // 
            // CustomVirus
            // 
            this.CustomVirus.AutoSize = true;
            this.CustomVirus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.CustomVirus.Location = new System.Drawing.Point(1177, 370);
            this.CustomVirus.Name = "CustomVirus";
            this.CustomVirus.Size = new System.Drawing.Size(194, 21);
            this.CustomVirus.TabIndex = 38;
            this.CustomVirus.Text = "Use custom value for virus";
            this.CustomVirus.UseVisualStyleBackColor = true;
            this.CustomVirus.CheckedChanged += new System.EventHandler(this.CustomVirus_CheckedChanged);
            // 
            // MaxLifeTimeCursor
            // 
            this.MaxLifeTimeCursor.Enabled = false;
            this.MaxLifeTimeCursor.LargeChange = 25;
            this.MaxLifeTimeCursor.Location = new System.Drawing.Point(1177, 538);
            this.MaxLifeTimeCursor.Maximum = 50;
            this.MaxLifeTimeCursor.Name = "MaxLifeTimeCursor";
            this.MaxLifeTimeCursor.Size = new System.Drawing.Size(330, 45);
            this.MaxLifeTimeCursor.SmallChange = 20;
            this.MaxLifeTimeCursor.TabIndex = 37;
            this.MaxLifeTimeCursor.Scroll += new System.EventHandler(this.MaxLifeTimeCursor_Scroll);
            // 
            // MaxLifetimeTxt
            // 
            this.MaxLifetimeTxt.AutoSize = true;
            this.MaxLifetimeTxt.Location = new System.Drawing.Point(1174, 522);
            this.MaxLifetimeTxt.Name = "MaxLifetimeTxt";
            this.MaxLifetimeTxt.Size = new System.Drawing.Size(87, 13);
            this.MaxLifetimeTxt.TabIndex = 36;
            this.MaxLifetimeTxt.Text = "Max Lifetime : 14";
            // 
            // InfectionRangeCursor
            // 
            this.InfectionRangeCursor.Enabled = false;
            this.InfectionRangeCursor.LargeChange = 50;
            this.InfectionRangeCursor.Location = new System.Drawing.Point(1177, 474);
            this.InfectionRangeCursor.Maximum = 20;
            this.InfectionRangeCursor.Minimum = 1;
            this.InfectionRangeCursor.Name = "InfectionRangeCursor";
            this.InfectionRangeCursor.Size = new System.Drawing.Size(330, 45);
            this.InfectionRangeCursor.SmallChange = 20;
            this.InfectionRangeCursor.TabIndex = 35;
            this.InfectionRangeCursor.Value = 1;
            this.InfectionRangeCursor.Scroll += new System.EventHandler(this.InfectionRangeCursor_Scroll);
            // 
            // InfectionRateTxt
            // 
            this.InfectionRateTxt.AutoSize = true;
            this.InfectionRateTxt.Location = new System.Drawing.Point(1174, 458);
            this.InfectionRateTxt.Name = "InfectionRateTxt";
            this.InfectionRateTxt.Size = new System.Drawing.Size(89, 13);
            this.InfectionRateTxt.TabIndex = 34;
            this.InfectionRateTxt.Text = "Infection Rate : 3";
            // 
            // TransmissionRateTxt
            // 
            this.TransmissionRateTxt.AutoSize = true;
            this.TransmissionRateTxt.Location = new System.Drawing.Point(1174, 394);
            this.TransmissionRateTxt.Name = "TransmissionRateTxt";
            this.TransmissionRateTxt.Size = new System.Drawing.Size(118, 13);
            this.TransmissionRateTxt.TabIndex = 33;
            this.TransmissionRateTxt.Text = "Transmission Rate : 0.6";
            // 
            // TransmissionRateCursor
            // 
            this.TransmissionRateCursor.Enabled = false;
            this.TransmissionRateCursor.LargeChange = 50;
            this.TransmissionRateCursor.Location = new System.Drawing.Point(1177, 410);
            this.TransmissionRateCursor.Maximum = 99;
            this.TransmissionRateCursor.Name = "TransmissionRateCursor";
            this.TransmissionRateCursor.Size = new System.Drawing.Size(330, 45);
            this.TransmissionRateCursor.SmallChange = 20;
            this.TransmissionRateCursor.TabIndex = 32;
            this.TransmissionRateCursor.Scroll += new System.EventHandler(this.TransmissionRateCursor_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 848);
            this.Controls.Add(this.CustomVirus);
            this.Controls.Add(this.MaxLifeTimeCursor);
            this.Controls.Add(this.MaxLifetimeTxt);
            this.Controls.Add(this.InfectionRangeCursor);
            this.Controls.Add(this.InfectionRateTxt);
            this.Controls.Add(this.TransmissionRateTxt);
            this.Controls.Add(this.TransmissionRateCursor);
            this.Controls.Add(this.placeInfoTxt);
            this.Controls.Add(this.SpecificRemovedNbre);
            this.Controls.Add(this.SpecificSusceptibleCases);
            this.Controls.Add(this.SpecificCasesNbre);
            this.Controls.Add(this.speedVitesseTxt);
            this.Controls.Add(this.speedVitesseCursor);
            this.Controls.Add(this.RemovedCases);
            this.Controls.Add(this.SusceptibleCases);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpecificGraph);
            this.Controls.Add(this.LocationComboList);
            this.Controls.Add(this.CheckBoxChangeValue);
            this.Controls.Add(this.TravellingRateCursor);
            this.Controls.Add(this.TravellingRateTxt);
            this.Controls.Add(this.SocialDistanceCursor);
            this.Controls.Add(this.SocialDistanceTxt);
            this.Controls.Add(this.HygieneTxt);
            this.Controls.Add(this.HygieneLevelCursor);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.EndingMsg);
            this.Controls.Add(this.CasesNbre);
            this.Controls.Add(this.nbHumanTxt);
            this.Controls.Add(this.mainChart);
            this.Name = "Form1";
            this.Text = "Pandemic Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HygieneLevelCursor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SocialDistanceCursor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TravellingRateCursor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpecificGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedVitesseCursor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxLifeTimeCursor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfectionRangeCursor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransmissionRateCursor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label nbHumanTxt;
        private System.Windows.Forms.Label CasesNbre;
        private System.Windows.Forms.Label EndingMsg;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label HygieneTxt;
        private System.Windows.Forms.Label SocialDistanceTxt;
        private System.Windows.Forms.TrackBar SocialDistanceCursor;
        private System.Windows.Forms.Label TravellingRateTxt;
        private System.Windows.Forms.TrackBar TravellingRateCursor;
        private System.Windows.Forms.CheckBox CheckBoxChangeValue;
        public System.Windows.Forms.TrackBar HygieneLevelCursor;
        private System.Windows.Forms.ComboBox LocationComboList;
        private System.Windows.Forms.DataVisualization.Charting.Chart SpecificGraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SusceptibleCases;
        private System.Windows.Forms.Label RemovedCases;
        private System.Windows.Forms.TrackBar speedVitesseCursor;
        private System.Windows.Forms.Label speedVitesseTxt;
        private System.Windows.Forms.Label SpecificRemovedNbre;
        private System.Windows.Forms.Label SpecificCasesNbre;
        private System.Windows.Forms.Label SpecificSusceptibleCases;
        private System.Windows.Forms.Label placeInfoTxt;
        private System.Windows.Forms.CheckBox CustomVirus;
        private System.Windows.Forms.TrackBar MaxLifeTimeCursor;
        private System.Windows.Forms.Label MaxLifetimeTxt;
        private System.Windows.Forms.TrackBar InfectionRangeCursor;
        private System.Windows.Forms.Label InfectionRateTxt;
        private System.Windows.Forms.Label TransmissionRateTxt;
        public System.Windows.Forms.TrackBar TransmissionRateCursor;
    }
}

