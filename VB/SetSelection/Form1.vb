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
			If Not Me.btnDiagram.IsHandleCreated Then Return

			' Select a diagram.
			chartControl1.SetObjectSelection(chartControl1.Diagram)
		End Sub

		Private Sub btnAxis_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAxis.Click
			If Not Me.btnAxis.IsHandleCreated Then Return

			' Select an axis.
			chartControl1.SetObjectSelection(CType(chartControl1.Diagram, XYDiagram).AxisX)
		End Sub

		Private Sub btnSeriesPoint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSeriesPoint.Click
			If Not Me.btnSeriesPoint.IsHandleCreated Then Return

			' Select a series point.
			Dim pointToSelect As SeriesPoint = TryCast(Me.chartControl1.Series(0).Points(1), SeriesPoint)
			If pointToSelect IsNot Nothing Then
				Me.chartControl1.SetObjectSelection(pointToSelect)
			End If
		End Sub
	End Class
End Namespace
