using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace SetSelection {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnDiagram_Click(object sender, EventArgs e) {
            // Select a diagram.
            chartControl1.SetObjectSelection(chartControl1.Diagram);
            chartControl1.Refresh();
        }

        private void btnAxis_Click(object sender, EventArgs e) {
            // Select an axis.
            chartControl1.SetObjectSelection(((XYDiagram)chartControl1.Diagram).AxisX);
            chartControl1.Refresh();
        }

        private void btnSeriesPoint_Click(object sender, EventArgs e) {
            // Select a series point.
            SeriesPoint pointToSelect = this.chartControl1.Series[0].Points[1] as SeriesPoint;
            if (pointToSelect != null) {
                this.chartControl1.SetObjectSelection(pointToSelect);
            }
            chartControl1.Refresh();
        }
    }
}
