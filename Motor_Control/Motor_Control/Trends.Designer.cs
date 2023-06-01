namespace Motor_Control
{
    partial class Trends
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.ChartLevel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TrendTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ChartLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TREND FOR SYSTEM";
            // 
            // ChartLevel
            // 
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.ScaleBreakStyle.MaxNumberOfBreaks = 1;
            chartArea1.AxisX.ScaleView.Zoomable = false;
            chartArea1.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.CursorX.AutoScroll = false;
            chartArea1.Name = "ChartArea1";
            this.ChartLevel.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartLevel.Legends.Add(legend1);
            this.ChartLevel.Location = new System.Drawing.Point(12, 56);
            this.ChartLevel.Name = "ChartLevel";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "Level";
            series1.Name = "ChartLevel";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.ChartLevel.Series.Add(series1);
            this.ChartLevel.Size = new System.Drawing.Size(764, 321);
            this.ChartLevel.TabIndex = 1;
            this.ChartLevel.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.Red;
            title1.Name = "Title1";
            title1.Text = "Biểu đồ mực nước";
            this.ChartLevel.Titles.Add(title1);
            // 
            // TrendTimer
            // 
            this.TrendTimer.Enabled = true;
            this.TrendTimer.Interval = 1000;
            this.TrendTimer.Tick += new System.EventHandler(this.TrendTimer_Tick);
            // 
            // Trends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChartLevel);
            this.Controls.Add(this.label1);
            this.Name = "Trends";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ChartLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartLevel;
        private System.Windows.Forms.Timer TrendTimer;
    }
}