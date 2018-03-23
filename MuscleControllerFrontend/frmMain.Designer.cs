namespace MuscleControllerFrontend
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(400D, 300D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnTrig = new System.Windows.Forms.Button();
            this.TxtTest = new System.Windows.Forms.TextBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.tmrStart = new System.Windows.Forms.Timer(this.components);
            this.Cht1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnStop = new System.Windows.Forms.Button();
            this.tmrUpdateChart = new System.Windows.Forms.Timer(this.components);
            this.Cht2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GrpCursor = new System.Windows.Forms.GroupBox();
            this.ChkApply = new System.Windows.Forms.CheckBox();
            this.ChtSim = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TxtXYNow = new System.Windows.Forms.TextBox();
            this.TxtXYBasis = new System.Windows.Forms.TextBox();
            this.BtnXYReset = new System.Windows.Forms.Button();
            this.BtnSetY = new System.Windows.Forms.Button();
            this.BtnSetX = new System.Windows.Forms.Button();
            this.tmrUpdateCursor = new System.Windows.Forms.Timer(this.components);
            this.Cht3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnTestInterop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Cht1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cht2)).BeginInit();
            this.GrpCursor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChtSim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cht3)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtPort
            // 
            this.TxtPort.Location = new System.Drawing.Point(12, 14);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(44, 21);
            this.TxtPort.TabIndex = 0;
            this.TxtPort.Text = "COM4";
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(62, 14);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(75, 23);
            this.BtnOpen.TabIndex = 1;
            this.BtnOpen.Text = "Open";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Enabled = false;
            this.BtnClose.Location = new System.Drawing.Point(143, 14);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnTrig
            // 
            this.BtnTrig.Enabled = false;
            this.BtnTrig.Location = new System.Drawing.Point(224, 14);
            this.BtnTrig.Name = "BtnTrig";
            this.BtnTrig.Size = new System.Drawing.Size(75, 23);
            this.BtnTrig.TabIndex = 3;
            this.BtnTrig.Text = "Trigger";
            this.BtnTrig.UseVisualStyleBackColor = true;
            this.BtnTrig.Click += new System.EventHandler(this.BtnTrig_Click);
            // 
            // TxtTest
            // 
            this.TxtTest.Location = new System.Drawing.Point(12, 41);
            this.TxtTest.Name = "TxtTest";
            this.TxtTest.Size = new System.Drawing.Size(287, 21);
            this.TxtTest.TabIndex = 4;
            // 
            // BtnStart
            // 
            this.BtnStart.Enabled = false;
            this.BtnStart.Location = new System.Drawing.Point(12, 69);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 5;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // tmrStart
            // 
            this.tmrStart.Interval = 500;
            this.tmrStart.Tick += new System.EventHandler(this.TmrStart_Tick);
            // 
            // Cht1
            // 
            chartArea5.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea5.AxisX.IsLabelAutoFit = false;
            chartArea5.AxisX.LabelStyle.Enabled = false;
            chartArea5.AxisY.IsLabelAutoFit = false;
            chartArea5.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            chartArea5.AxisY.Maximum = 30000D;
            chartArea5.AxisY.Minimum = -30000D;
            chartArea5.Name = "ChartArea1";
            this.Cht1.ChartAreas.Add(chartArea5);
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.Cht1.Legends.Add(legend5);
            this.Cht1.Location = new System.Drawing.Point(12, 98);
            this.Cht1.Name = "Cht1";
            series12.BorderWidth = 2;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series12.Color = System.Drawing.Color.Firebrick;
            series12.IsVisibleInLegend = false;
            series12.IsXValueIndexed = true;
            series12.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series12.Legend = "Legend1";
            series12.Name = "AcX";
            series12.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series12.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series13.BorderWidth = 2;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series13.Color = System.Drawing.Color.LimeGreen;
            series13.IsVisibleInLegend = false;
            series13.IsXValueIndexed = true;
            series13.Legend = "Legend1";
            series13.Name = "AcY";
            series14.BorderWidth = 2;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series14.Color = System.Drawing.Color.RoyalBlue;
            series14.IsVisibleInLegend = false;
            series14.IsXValueIndexed = true;
            series14.Legend = "Legend1";
            series14.Name = "AcZ";
            this.Cht1.Series.Add(series12);
            this.Cht1.Series.Add(series13);
            this.Cht1.Series.Add(series14);
            this.Cht1.Size = new System.Drawing.Size(287, 91);
            this.Cht1.TabIndex = 6;
            this.Cht1.Text = "chart1";
            title4.Name = "Title1";
            title4.Text = "Accelerometer";
            this.Cht1.Titles.Add(title4);
            // 
            // BtnStop
            // 
            this.BtnStop.Enabled = false;
            this.BtnStop.Location = new System.Drawing.Point(93, 69);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(75, 23);
            this.BtnStop.TabIndex = 7;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // tmrUpdateChart
            // 
            this.tmrUpdateChart.Interval = 10;
            this.tmrUpdateChart.Tick += new System.EventHandler(this.TmrUpdateChart_Tick);
            // 
            // Cht2
            // 
            chartArea6.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea6.AxisX.IsLabelAutoFit = false;
            chartArea6.AxisX.LabelStyle.Enabled = false;
            chartArea6.AxisY.IsLabelAutoFit = false;
            chartArea6.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            chartArea6.AxisY.Maximum = 30000D;
            chartArea6.AxisY.Minimum = -30000D;
            chartArea6.Name = "ChartArea1";
            this.Cht2.ChartAreas.Add(chartArea6);
            legend6.Enabled = false;
            legend6.Name = "Legend1";
            this.Cht2.Legends.Add(legend6);
            this.Cht2.Location = new System.Drawing.Point(12, 195);
            this.Cht2.Name = "Cht2";
            series15.BorderWidth = 2;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series15.Color = System.Drawing.Color.Firebrick;
            series15.IsVisibleInLegend = false;
            series15.IsXValueIndexed = true;
            series15.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series15.Legend = "Legend1";
            series15.Name = "GyX";
            series15.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series15.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series16.BorderWidth = 2;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series16.Color = System.Drawing.Color.LimeGreen;
            series16.IsVisibleInLegend = false;
            series16.IsXValueIndexed = true;
            series16.Legend = "Legend1";
            series16.Name = "GyY";
            series17.BorderWidth = 2;
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series17.Color = System.Drawing.Color.RoyalBlue;
            series17.IsVisibleInLegend = false;
            series17.IsXValueIndexed = true;
            series17.Legend = "Legend1";
            series17.Name = "GyZ";
            this.Cht2.Series.Add(series15);
            this.Cht2.Series.Add(series16);
            this.Cht2.Series.Add(series17);
            this.Cht2.Size = new System.Drawing.Size(287, 91);
            this.Cht2.TabIndex = 9;
            this.Cht2.Text = "chart1";
            title5.Name = "Title1";
            title5.Text = "Gyroscope (not used)";
            this.Cht2.Titles.Add(title5);
            // 
            // GrpCursor
            // 
            this.GrpCursor.Controls.Add(this.ChkApply);
            this.GrpCursor.Controls.Add(this.ChtSim);
            this.GrpCursor.Controls.Add(this.TxtXYNow);
            this.GrpCursor.Controls.Add(this.TxtXYBasis);
            this.GrpCursor.Controls.Add(this.BtnXYReset);
            this.GrpCursor.Controls.Add(this.BtnSetY);
            this.GrpCursor.Controls.Add(this.BtnSetX);
            this.GrpCursor.Enabled = false;
            this.GrpCursor.Location = new System.Drawing.Point(315, 14);
            this.GrpCursor.Name = "GrpCursor";
            this.GrpCursor.Size = new System.Drawing.Size(251, 330);
            this.GrpCursor.TabIndex = 11;
            this.GrpCursor.TabStop = false;
            this.GrpCursor.Text = "Cursor Movement";
            // 
            // ChkApply
            // 
            this.ChkApply.AutoSize = true;
            this.ChkApply.Location = new System.Drawing.Point(7, 305);
            this.ChkApply.Name = "ChkApply";
            this.ChkApply.Size = new System.Drawing.Size(54, 16);
            this.ChkApply.TabIndex = 19;
            this.ChkApply.Text = "Apply";
            this.ChkApply.UseVisualStyleBackColor = true;
            this.ChkApply.CheckedChanged += new System.EventHandler(this.ChkApply_CheckedChanged);
            // 
            // ChtSim
            // 
            chartArea7.AxisX.IsLabelAutoFit = false;
            chartArea7.AxisX.IsStartedFromZero = false;
            chartArea7.AxisX.MajorGrid.Enabled = false;
            chartArea7.AxisX.MajorTickMark.Enabled = false;
            chartArea7.AxisX.Maximum = 800D;
            chartArea7.AxisX.Minimum = 0D;
            chartArea7.AxisY.IsLabelAutoFit = false;
            chartArea7.AxisY.IsReversed = true;
            chartArea7.AxisY.IsStartedFromZero = false;
            chartArea7.AxisY.MajorGrid.Enabled = false;
            chartArea7.AxisY.MajorTickMark.Enabled = false;
            chartArea7.AxisY.Maximum = 600D;
            chartArea7.AxisY.Minimum = 0D;
            chartArea7.BorderColor = System.Drawing.Color.Transparent;
            chartArea7.Name = "ChartArea1";
            this.ChtSim.ChartAreas.Add(chartArea7);
            legend7.Enabled = false;
            legend7.Name = "Legend1";
            this.ChtSim.Legends.Add(legend7);
            this.ChtSim.Location = new System.Drawing.Point(6, 127);
            this.ChtSim.Name = "ChtSim";
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series18.Legend = "Legend1";
            series18.MarkerColor = System.Drawing.Color.Red;
            series18.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series18.Name = "Cursor";
            series18.Points.Add(dataPoint2);
            this.ChtSim.Series.Add(series18);
            this.ChtSim.Size = new System.Drawing.Size(239, 171);
            this.ChtSim.TabIndex = 18;
            this.ChtSim.Text = "chart1";
            // 
            // TxtXYNow
            // 
            this.TxtXYNow.Location = new System.Drawing.Point(6, 100);
            this.TxtXYNow.Name = "TxtXYNow";
            this.TxtXYNow.Size = new System.Drawing.Size(239, 21);
            this.TxtXYNow.TabIndex = 17;
            // 
            // TxtXYBasis
            // 
            this.TxtXYBasis.Location = new System.Drawing.Point(6, 49);
            this.TxtXYBasis.Multiline = true;
            this.TxtXYBasis.Name = "TxtXYBasis";
            this.TxtXYBasis.Size = new System.Drawing.Size(239, 45);
            this.TxtXYBasis.TabIndex = 16;
            // 
            // BtnXYReset
            // 
            this.BtnXYReset.Location = new System.Drawing.Point(170, 20);
            this.BtnXYReset.Name = "BtnXYReset";
            this.BtnXYReset.Size = new System.Drawing.Size(75, 23);
            this.BtnXYReset.TabIndex = 14;
            this.BtnXYReset.Text = "Reset";
            this.BtnXYReset.UseVisualStyleBackColor = true;
            this.BtnXYReset.Click += new System.EventHandler(this.BtnXYReset_Click);
            // 
            // BtnSetY
            // 
            this.BtnSetY.Location = new System.Drawing.Point(88, 20);
            this.BtnSetY.Name = "BtnSetY";
            this.BtnSetY.Size = new System.Drawing.Size(75, 23);
            this.BtnSetY.TabIndex = 13;
            this.BtnSetY.Text = "Set Ybase";
            this.BtnSetY.UseVisualStyleBackColor = true;
            this.BtnSetY.Click += new System.EventHandler(this.BtnSetY_Click);
            // 
            // BtnSetX
            // 
            this.BtnSetX.Location = new System.Drawing.Point(6, 20);
            this.BtnSetX.Name = "BtnSetX";
            this.BtnSetX.Size = new System.Drawing.Size(75, 23);
            this.BtnSetX.TabIndex = 12;
            this.BtnSetX.Text = "Set Xbase";
            this.BtnSetX.UseVisualStyleBackColor = true;
            this.BtnSetX.Click += new System.EventHandler(this.BtnSetX_Click);
            // 
            // tmrUpdateCursor
            // 
            this.tmrUpdateCursor.Interval = 30;
            this.tmrUpdateCursor.Tick += new System.EventHandler(this.TmrUpdateCursor_Tick);
            // 
            // Cht3
            // 
            chartArea8.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea8.AxisX.IsLabelAutoFit = false;
            chartArea8.AxisX.LabelStyle.Enabled = false;
            chartArea8.AxisY.IsLabelAutoFit = false;
            chartArea8.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            chartArea8.AxisY.Maximum = 30000D;
            chartArea8.AxisY.Minimum = -30000D;
            chartArea8.Name = "ChartArea1";
            this.Cht3.ChartAreas.Add(chartArea8);
            legend8.Enabled = false;
            legend8.Name = "Legend1";
            this.Cht3.Legends.Add(legend8);
            this.Cht3.Location = new System.Drawing.Point(12, 292);
            this.Cht3.Name = "Cht3";
            series19.BorderWidth = 2;
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series19.Color = System.Drawing.Color.DodgerBlue;
            series19.IsVisibleInLegend = false;
            series19.IsXValueIndexed = true;
            series19.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series19.Legend = "Legend1";
            series19.Name = "Ch1";
            series19.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series19.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series20.BorderWidth = 2;
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series20.Color = System.Drawing.Color.Gold;
            series20.IsVisibleInLegend = false;
            series20.IsXValueIndexed = true;
            series20.Legend = "Legend1";
            series20.Name = "Ch2";
            series21.BorderWidth = 2;
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series21.Color = System.Drawing.Color.SpringGreen;
            series21.IsVisibleInLegend = false;
            series21.IsXValueIndexed = true;
            series21.Legend = "Legend1";
            series21.Name = "Ch3";
            series22.BorderWidth = 2;
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series22.Color = System.Drawing.Color.OrangeRed;
            series22.IsVisibleInLegend = false;
            series22.IsXValueIndexed = true;
            series22.Legend = "Legend1";
            series22.Name = "Ch4";
            this.Cht3.Series.Add(series19);
            this.Cht3.Series.Add(series20);
            this.Cht3.Series.Add(series21);
            this.Cht3.Series.Add(series22);
            this.Cht3.Size = new System.Drawing.Size(287, 91);
            this.Cht3.TabIndex = 12;
            title6.Name = "Title1";
            title6.Text = "EMG Envelope (WIP)";
            this.Cht3.Titles.Add(title6);
            // 
            // BtnTestInterop
            // 
            this.BtnTestInterop.Location = new System.Drawing.Point(315, 351);
            this.BtnTestInterop.Name = "BtnTestInterop";
            this.BtnTestInterop.Size = new System.Drawing.Size(75, 23);
            this.BtnTestInterop.TabIndex = 13;
            this.BtnTestInterop.Text = "Hello";
            this.BtnTestInterop.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 395);
            this.Controls.Add(this.BtnTestInterop);
            this.Controls.Add(this.Cht3);
            this.Controls.Add(this.GrpCursor);
            this.Controls.Add(this.Cht2);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.Cht1);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.TxtTest);
            this.Controls.Add(this.BtnTrig);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnOpen);
            this.Controls.Add(this.TxtPort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "MuscleController Frontend";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cht1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cht2)).EndInit();
            this.GrpCursor.ResumeLayout(false);
            this.GrpCursor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChtSim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cht3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPort;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnTrig;
        private System.Windows.Forms.TextBox TxtTest;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Timer tmrStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart Cht1;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Timer tmrUpdateChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart Cht2;
        private System.Windows.Forms.GroupBox GrpCursor;
        private System.Windows.Forms.Button BtnSetX;
        private System.Windows.Forms.Button BtnXYReset;
        private System.Windows.Forms.Button BtnSetY;
        private System.Windows.Forms.TextBox TxtXYNow;
        private System.Windows.Forms.TextBox TxtXYBasis;
        private System.Windows.Forms.Timer tmrUpdateCursor;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChtSim;
        private System.Windows.Forms.DataVisualization.Charting.Chart Cht3;
        private System.Windows.Forms.CheckBox ChkApply;
        private System.Windows.Forms.Button BtnTestInterop;
    }
}

