namespace IRF_Project_Gieda_Bianka_FYZINS
{
    partial class Diagram
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.DiagramChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.DiagramChart)).BeginInit();
            this.SuspendLayout();
            // 
            // DiagramChart
            // 
            chartArea1.Name = "ChartArea1";
            this.DiagramChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.DiagramChart.Legends.Add(legend1);
            this.DiagramChart.Location = new System.Drawing.Point(78, 47);
            this.DiagramChart.Name = "DiagramChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.DiagramChart.Series.Add(series1);
            this.DiagramChart.Size = new System.Drawing.Size(532, 352);
            this.DiagramChart.TabIndex = 0;
            this.DiagramChart.Text = "chart1";
            // 
            // Diagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.DiagramChart);
            this.Name = "Diagram";
            this.Text = "Diagram";
            this.Load += new System.EventHandler(this.Diagram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DiagramChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart DiagramChart;
    }
}