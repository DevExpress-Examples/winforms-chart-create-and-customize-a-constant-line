Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace ConstLines
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Create an empty chart.
            Dim chartControl1 As New ChartControl()

            ' Create a bar series and add points to it.
            Dim series1 As New Series("Series 1", ViewType.Spline)
            series1.Points.Add(New SeriesPoint("A", New Double() { 10 }))
            series1.Points.Add(New SeriesPoint("B", New Double() { 2 }))
            series1.Points.Add(New SeriesPoint("C", New Double() { 17 }))
            series1.Points.Add(New SeriesPoint("D", New Double() { 4 }))
            series1.Points.Add(New SeriesPoint("E", New Double() { 17 }))
            series1.Points.Add(New SeriesPoint("F", New Double() { 10 }))
            series1.Points.Add(New SeriesPoint("G", New Double() { 15 }))

            ' Add the series to the chart.
            chartControl1.Series.Add(series1)

            ' Cast the chart's diagram to the XYDiagram type, to access its axes.
            Dim diagram As XYDiagram = TryCast(chartControl1.Diagram, XYDiagram)

            ' Create a constant line.
            Dim constantLine1 As New ConstantLine("Constant Line 1")
            diagram.AxisY.ConstantLines.Add(constantLine1)

            ' Define its axis value.
            constantLine1.AxisValue = 7

            ' Customize the behavior of the constant line.
            constantLine1.Visible = True
            constantLine1.ShowInLegend = True
            constantLine1.LegendText = "Some Threshold"
            constantLine1.ShowBehind = False

            ' Customize the constant line's title.
            constantLine1.Title.Visible = True
            constantLine1.Title.Text = "Constant Line Title"
            constantLine1.Title.TextColor = Color.Red
            constantLine1.Title.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.False
            constantLine1.Title.Font = New Font(Me.Font.FontFamily.Name, 14, FontStyle.Bold)
            constantLine1.Title.ShowBelowLine = True
            constantLine1.Title.Alignment = ConstantLineTitleAlignment.Far

            ' Customize the appearance of the constant line.
            constantLine1.Color = Color.Red
            constantLine1.LineStyle.DashStyle = DashStyle.Dash
            constantLine1.LineStyle.Thickness = 2

            ' Add the chart to the form.
            chartControl1.Dock = DockStyle.Fill
            Me.Controls.Add(chartControl1)
        End Sub

    End Class
End Namespace