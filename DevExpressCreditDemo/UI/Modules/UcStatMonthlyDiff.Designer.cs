namespace DevExpressCreditDemo.UI.Modules
{
    partial class UcStatMonthlyDiff
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chartControlMontlyPaid = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlMontlyPaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControlMontlyPaid
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControlMontlyPaid.Diagram = xyDiagram1;
            this.chartControlMontlyPaid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControlMontlyPaid.Legend.LegendID = -1;
            this.chartControlMontlyPaid.Location = new System.Drawing.Point(0, 0);
            this.chartControlMontlyPaid.Name = "chartControlMontlyPaid";
            series1.Name = "Oczekiwano";
            series1.SeriesID = 0;
            series2.Name = "Wpłacono";
            series2.SeriesID = 1;
            this.chartControlMontlyPaid.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chartControlMontlyPaid.Size = new System.Drawing.Size(810, 607);
            this.chartControlMontlyPaid.TabIndex = 0;
            chartTitle1.Text = "Miesięczne wpłaty vs. oczekiwane";
            chartTitle1.TitleID = 0;
            this.chartControlMontlyPaid.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // UcStatMonthlyDiff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartControlMontlyPaid);
            this.Name = "UcStatMonthlyDiff";
            this.Size = new System.Drawing.Size(810, 607);
            this.Load += new System.EventHandler(this.UcStatMonthlyDiff_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlMontlyPaid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControlMontlyPaid;
    }
}
