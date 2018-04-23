Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace SetSelection
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub btnDiagram_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDiagram.Click
            ' Select a diagram.
            chartControl1.SetObjectSelection(chartControl1.Diagram)
            chartControl1.Refresh()
        End Sub

        Private Sub btnAxis_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAxis.Click
            ' Select an axis.
            chartControl1.SetObjectSelection(CType(chartControl1.Diagram, XYDiagram).AxisX)
            chartControl1.Refresh()
        End Sub

        Private Sub btnSeriesPoint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSeriesPoint.Click
            ' Select a series point.
            Dim pointToSelect As SeriesPoint = TryCast(Me.chartControl1.Series(0).Points(1), SeriesPoint)
            If pointToSelect IsNot Nothing Then
                Me.chartControl1.SetObjectSelection(pointToSelect)
            End If
            chartControl1.Refresh()
        End Sub
    End Class
End Namespace
