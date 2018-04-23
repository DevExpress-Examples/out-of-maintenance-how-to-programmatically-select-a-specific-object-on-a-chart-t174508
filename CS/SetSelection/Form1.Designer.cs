namespace SetSelection {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint("a", new object[] {
            ((object)(1D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint2 = new DevExpress.XtraCharts.SeriesPoint("b", new object[] {
            ((object)(2D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint3 = new DevExpress.XtraCharts.SeriesPoint("c", new object[] {
            ((object)(3D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint4 = new DevExpress.XtraCharts.SeriesPoint("d", new object[] {
            ((object)(2.3D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint5 = new DevExpress.XtraCharts.SeriesPoint("e", new object[] {
            ((object)(0.5D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint6 = new DevExpress.XtraCharts.SeriesPoint("f", new object[] {
            ((object)(7D))});
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSeriesPoint = new System.Windows.Forms.Button();
            this.btnAxis = new System.Windows.Forms.Button();
            this.btnDiagram = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Location = new System.Drawing.Point(0, 59);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SelectionMode = DevExpress.XtraCharts.ElementSelectionMode.Single;
            this.chartControl1.SeriesSelectionMode = DevExpress.XtraCharts.SeriesSelectionMode.Point;
            series1.Name = "Series 2";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1,
            seriesPoint2,
            seriesPoint3,
            seriesPoint4,
            seriesPoint5,
            seriesPoint6});
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(814, 495);
            this.chartControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSeriesPoint);
            this.panel1.Controls.Add(this.btnAxis);
            this.panel1.Controls.Add(this.btnDiagram);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 59);
            this.panel1.TabIndex = 1;
            // 
            // btnSeriesPoint
            // 
            this.btnSeriesPoint.Location = new System.Drawing.Point(261, 12);
            this.btnSeriesPoint.Name = "btnSeriesPoint";
            this.btnSeriesPoint.Size = new System.Drawing.Size(130, 33);
            this.btnSeriesPoint.TabIndex = 0;
            this.btnSeriesPoint.Text = "Select Series Point";
            this.btnSeriesPoint.UseVisualStyleBackColor = true;
            this.btnSeriesPoint.Click += new System.EventHandler(this.btnSeriesPoint_Click);
            // 
            // btnAxis
            // 
            this.btnAxis.Location = new System.Drawing.Point(137, 12);
            this.btnAxis.Name = "btnAxis";
            this.btnAxis.Size = new System.Drawing.Size(100, 33);
            this.btnAxis.TabIndex = 0;
            this.btnAxis.Text = "Select Axis";
            this.btnAxis.UseVisualStyleBackColor = true;
            this.btnAxis.Click += new System.EventHandler(this.btnAxis_Click);
            // 
            // btnDiagram
            // 
            this.btnDiagram.Location = new System.Drawing.Point(12, 12);
            this.btnDiagram.Name = "btnDiagram";
            this.btnDiagram.Size = new System.Drawing.Size(100, 33);
            this.btnDiagram.TabIndex = 0;
            this.btnDiagram.Text = "Select Diagram";
            this.btnDiagram.UseVisualStyleBackColor = true;
            this.btnDiagram.Click += new System.EventHandler(this.btnDiagram_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 554);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAxis;
        private System.Windows.Forms.Button btnDiagram;
        private System.Windows.Forms.Button btnSeriesPoint;
    }
}

