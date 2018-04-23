Namespace SetSelection
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("a", New Object() { (DirectCast(1R, Object))})
            Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("b", New Object() { (DirectCast(2R, Object))})
            Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("c", New Object() { (DirectCast(3R, Object))})
            Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("d", New Object() { (DirectCast(2.3R, Object))})
            Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("e", New Object() { (DirectCast(0.5R, Object))})
            Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("f", New Object() { (DirectCast(7R, Object))})
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.btnSeriesPoint = New System.Windows.Forms.Button()
            Me.btnAxis = New System.Windows.Forms.Button()
            Me.btnDiagram = New System.Windows.Forms.Button()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            Me.chartControl1.Location = New System.Drawing.Point(0, 59)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.SelectionMode = DevExpress.XtraCharts.ElementSelectionMode.Single
            Me.chartControl1.SeriesSelectionMode = DevExpress.XtraCharts.SeriesSelectionMode.Point
            series1.Name = "Series 2"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6})
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
            Me.chartControl1.Size = New System.Drawing.Size(814, 495)
            Me.chartControl1.TabIndex = 0
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.btnSeriesPoint)
            Me.panel1.Controls.Add(Me.btnAxis)
            Me.panel1.Controls.Add(Me.btnDiagram)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(814, 59)
            Me.panel1.TabIndex = 1
            ' 
            ' btnSeriesPoint
            ' 
            Me.btnSeriesPoint.Location = New System.Drawing.Point(261, 12)
            Me.btnSeriesPoint.Name = "btnSeriesPoint"
            Me.btnSeriesPoint.Size = New System.Drawing.Size(130, 33)
            Me.btnSeriesPoint.TabIndex = 0
            Me.btnSeriesPoint.Text = "Select Series Point"
            Me.btnSeriesPoint.UseVisualStyleBackColor = True
            ' 
            ' btnAxis
            ' 
            Me.btnAxis.Location = New System.Drawing.Point(137, 12)
            Me.btnAxis.Name = "btnAxis"
            Me.btnAxis.Size = New System.Drawing.Size(100, 33)
            Me.btnAxis.TabIndex = 0
            Me.btnAxis.Text = "Select Axis"
            Me.btnAxis.UseVisualStyleBackColor = True
            ' 
            ' btnDiagram
            ' 
            Me.btnDiagram.Location = New System.Drawing.Point(12, 12)
            Me.btnDiagram.Name = "btnDiagram"
            Me.btnDiagram.Size = New System.Drawing.Size(100, 33)
            Me.btnDiagram.TabIndex = 0
            Me.btnDiagram.Text = "Select Diagram"
            Me.btnDiagram.UseVisualStyleBackColor = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(814, 554)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.panel1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private chartControl1 As DevExpress.XtraCharts.ChartControl
        Private panel1 As System.Windows.Forms.Panel
        Private WithEvents btnAxis As System.Windows.Forms.Button
        Private WithEvents btnDiagram As System.Windows.Forms.Button
        Private WithEvents btnSeriesPoint As System.Windows.Forms.Button
    End Class
End Namespace

