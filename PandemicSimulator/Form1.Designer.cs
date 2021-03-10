
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HygieneLevelCursor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SocialDistanceCursor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TravellingRateCursor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpecificGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedVitesseCursor)).BeginInit();
            this.SuspendLayout();
            // 
            // mainChart
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.mainChart.Legends.Add(legend1);
            this.mainChart.Location = new System.Drawing.Point(9, 99);
            this.mainChart.Margin = new System.Windows.Forms.Padding(0);
            this.mainChart.Name = "mainChart";
            this.mainChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.mainChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(103)))), ((int)(((byte)(83))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(97)))), ((int)(((byte)(107))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))))};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea100;
            series1.Legend = "Legend1";
            series1.Name = "INFECTIOUS";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea100;
            series2.Legend = "Legend1";
            series2.Name = "SUSCEPTIBLE";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea100;
            series3.Legend = "Legend1";
            series3.Name = "REMOVED";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            this.mainChart.Series.Add(series1);
            this.mainChart.Series.Add(series2);
            this.mainChart.Series.Add(series3);
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
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.SpecificGraph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.SpecificGraph.Legends.Add(legend2);
            this.SpecificGraph.Location = new System.Drawing.Point(9, 491);
            this.SpecificGraph.Margin = new System.Windows.Forms.Padding(0);
            this.SpecificGraph.Name = "SpecificGraph";
            this.SpecificGraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.SpecificGraph.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(103)))), ((int)(((byte)(83))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(97)))), ((int)(((byte)(107))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))))};
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea100;
            series4.Legend = "Legend1";
            series4.Name = "INFECTIOUS";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series4.YValuesPerPoint = 6;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea100;
            series5.Legend = "Legend1";
            series5.Name = "SUSCEPTIBLE";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series5.YValuesPerPoint = 6;
            series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea100;
            series6.Legend = "Legend1";
            series6.Name = "REMOVED";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series6.YValuesPerPoint = 6;
            series6.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            this.SpecificGraph.Series.Add(series4);
            this.SpecificGraph.Series.Add(series5);
            this.SpecificGraph.Series.Add(series6);
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
            this.speedVitesseCursor.Location = new System.Drawing.Point(1171, 502);
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
            this.speedVitesseTxt.Location = new System.Drawing.Point(1176, 486);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 848);
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
    }
}

