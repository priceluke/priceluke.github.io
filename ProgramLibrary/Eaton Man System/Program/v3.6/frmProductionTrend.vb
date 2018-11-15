Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmProductionTrend
    Dim Rand As New Random
    Public current_product_or_comp As String = "Component"
    Public current_trendID As Integer
    Dim current_trend_product As New product
    Dim current_trend_component As New component
    Public arr_compCreation(999, 2) As String
    Public arr_productCreation(999, 2) As String

    Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate_combo()
        FileOpen(1, "ProductCreationLog.dat", OpenMode.Random, , , Len(product_trend_record))
        FileOpen(2, "ComponentCreationLog.dat", OpenMode.Random, , , Len(component_trend_record))
        ReDim arr_productCreation(LOF(1) / Len(product_trend_record) - 1, 2)
        ReDim arr_compCreation(LOF(2) / Len(component_trend_record) - 1, 2)
        If LOF(1) / Len(product_trend_record) = 0 Then
        Else
            For i = 1 To LOF(1) / Len(product_trend_record)
                FileGet(1, product_trend_record, i)
                arr_productCreation(i - 1, 0) = product_trend_record.ID
                arr_productCreation(i - 1, 1) = product_trend_record.Quantity
                arr_productCreation(i - 1, 2) = DateTime.Parse(product_trend_record.dateOutput)
            Next
        End If
        If LOF(2) / Len(component_trend_record) = 0 Then
        Else
            For i = 1 To LOF(2) / Len(component_trend_record)
                FileGet(2, component_trend_record, i)
                arr_compCreation(i - 1, 0) = component_trend_record.ID
                arr_compCreation(i - 1, 1) = component_trend_record.Quantity
                arr_compCreation(i - 1, 2) = DateTime.Parse(component_trend_record.dateOutput)
            Next
        End If
        FileClose(1)
        FileClose(2)

        trendcordinate.Text = "Select a Point"
    End Sub

    Sub populate_combo()
        trendItem.Items.Clear()
        If component.Checked Then
            FileOpen(1, "Components.dat", OpenMode.Random, , , Len(component_record))
            For i = 1 To (LOF(1) / Len(component_record))
                FileGet(1, component_record, i)
                trendItem.Items.Add(component_record.component_code & " : " & component_record.component_desc)
            Next
            FileClose(1)
        Else
            FileOpen(1, "Products.dat", OpenMode.Random, , , Len(product_record))
            For i = 1 To (LOF(1) / Len(product_record))
                FileGet(1, product_record, i)
                trendItem.Items.Add(product_record.product_code & " : " & product_record.product_desc)
            Next
            FileClose(1)
        End If
        trendItem.SelectedIndex = 0
    End Sub

    Sub trendrecord_fromcombo()
        current_trendID = trendItem.SelectedIndex() + 1
        If component.Checked Then
            FileOpen(1, "Components.dat", OpenMode.Random, , , Len(component_record))
            FileGet(1, component_record, current_trendID)
            FileClose(1)
            current_trend_component = component_record
        Else
            FileOpen(1, "products.dat", OpenMode.Random, , , Len(product_record))
            FileGet(1, product_record, current_trendID)
            FileClose(1)
            current_trend_product = product_record
        End If
    End Sub

    Private Sub product_CheckedChanged(sender As Object, e As EventArgs) Handles product.CheckedChanged
        If component.Checked Then
            current_product_or_comp = "Component"
        Else
            current_product_or_comp = "Product"
        End If
        populate_combo()
    End Sub

    Private Sub trendItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles trendItem.SelectedIndexChanged
        Dim time_period As String = "Year"
        If hour.Checked Then
            time_period = "Hour"
        ElseIf day.Checked Then
            time_period = "Day"
        ElseIf week.Checked Then
            time_period = "Week"
        ElseIf month.Checked Then
            time_period = "Month"
        ElseIf quater.Checked Then
            time_period = "Quater"
        ElseIf year.Checked Then
            time_period = "Year"
        End If

        If component.Checked Then
            FileOpen(1, "Components.dat", OpenMode.Random, , , Len(component_record))
            FileGet(1, component_record, trendItem.SelectedIndex + 1)
            FileClose(1)
            trend_array(arr_compCreation, time_period, component_record.component_id, "Component")
        Else
            FileOpen(1, "Products.dat", OpenMode.Random, , , Len(product_record))
            FileGet(1, product_record, trendItem.SelectedIndex + 1)
            FileClose(1)
            trend_array(arr_productCreation, time_period, product_record.product_id, "Product")
        End If
    End Sub
    Sub doGraph()
        Dim time_period As String = "Year"
        If hour.Checked Then
            time_period = "Hour"
        ElseIf day.Checked Then
            time_period = "Day"
        ElseIf week.Checked Then
            time_period = "Week"
        ElseIf month.Checked Then
            time_period = "Month"
        ElseIf quater.Checked Then
            time_period = "Quater"
        ElseIf year.Checked Then
            time_period = "Year"
        End If

        If component.Checked Then
            FileOpen(1, "Components.dat", OpenMode.Random, , , Len(component_record))
            FileGet(1, component_record, trendItem.SelectedIndex + 1)
            FileClose(1)
            trend_array(arr_compCreation, time_period, component_record.component_id, "Component")
        Else
            FileOpen(1, "Products.dat", OpenMode.Random, , , Len(product_record))
            FileGet(1, product_record, trendItem.SelectedIndex + 1)
            FileClose(1)
            trend_array(arr_productCreation, time_period, product_record.product_id, "Product")
        End If
    End Sub
    ''' <summary>
    ''' Trends will be displayed after passing variables to this subroutine
    ''' </summary>
    ''' <param name="full_array">Pass the full array of production data to be processed.</param>
    ''' <param name="timescale">pass the state of the radio buttons</param>
    ''' <param name="id">pass the id of the item to be looked into</param>
    ''' <param name="productorcomponent">"Product" or "Component"</param>
    ''' <remarks>Luke Price - 2017</remarks>
    Sub trend_array(ByVal full_array(,) As String, ByVal timescale As String, ByVal id As Integer, ByVal productorcomponent As String)
        Dim x() As DateTime = {}
        Dim y() As Integer = {}
        Dim x_removeatrange As List(Of DateTime)
        Dim y_removeatrange As List(Of Integer)
        Dim lowerbound_x As DateTime
        For i = 0 To (full_array.Length / 3) - 1
            If full_array(i, 0) = id Then
                ReDim Preserve x(x.Length)
                Dim initial_date As String = full_array(i, 2)
                Dim expenddt As Date = Date.Parse(initial_date) ', "dd/MM/yyyy hh:mm:ss"
                x(x.Length - 1) = expenddt
                ReDim Preserve y(y.Length)
                y(y.Length - 1) = full_array(i, 1)
            End If

        Next
        TrendChart.Series(0).XValueType = DataVisualization.Charting.ChartValueType.DateTime
        TrendChart.Series("Trend").Color = Color.Red
        TrendChart.Series("Trend").BorderWidth = 3
        TrendChart.ChartAreas("ChartArea1").AxisX.Title = "Date"
        TrendChart.ChartAreas("ChartArea1").AxisY.Title = "Frequency"
        TrendChart.Series("TrendPoints").MarkerImage = Application.StartupPath & "\sources\point.png"
        Select Case timescale
            Case "Hour"
                lowerbound_x = Date.Parse(Now.AddHours(-2).ToString(Format("dd/MM/yyyy hh:mm:ss")))
            Case "Month"
                lowerbound_x = Date.Parse(Now.AddMonths(-1).ToString(Format("dd/MM/yyyy hh:mm:ss")))
            Case "Week"
                lowerbound_x = Date.Parse(Now.AddDays(-7).ToString(Format("dd/MM/yyyy hh:mm:ss")))
            Case "Year"
                lowerbound_x = Date.Parse(Now.AddYears(-1).ToString(Format("dd/MM/yyyy hh:mm:ss")))
            Case "Quater"
                lowerbound_x = Date.Parse(Now.AddMonths(-3).ToString(Format("dd/MM/yyyy hh:mm:ss")))
            Case "Day"
                lowerbound_x = Date.Parse(Now.AddDays(-2).ToString(Format("dd/MM/yyyy hh:mm:ss")))
        End Select
        x_removeatrange = x.ToList
        y_removeatrange = y.ToList
        Dim x_shortened As New List(Of DateTime)
        Dim y_shortened As New List(Of Integer)
        For q = 0 To x_removeatrange.Count - 1
            Dim result As Integer = DateTime.Compare(x_removeatrange(q), lowerbound_x)
            If result < 0 Then
            Else
                x_shortened.Add(x_removeatrange(q))
                y_shortened.Add(y_removeatrange(q))
            End If
        Next
        ReDim x(x_shortened.Count - 1)
        x = x_shortened.ToArray()
        ReDim y(y_shortened.Count - 1)
        y = y_shortened.ToArray()

        TrendChart.Series("Trend").Points.DataBindXY(x, y)
        TrendChart.Series("TrendPoints").Points.DataBindXY(x, y)
    End Sub

    Private Sub hour_CheckedChanged(sender As Object, e As EventArgs) Handles hour.CheckedChanged
        doGraph()
    End Sub

    Private Sub day_CheckedChanged(sender As Object, e As EventArgs) Handles day.CheckedChanged
        doGraph()
    End Sub

    Private Sub month_CheckedChanged(sender As Object, e As EventArgs) Handles month.CheckedChanged
        doGraph()
    End Sub

    Private Sub quater_CheckedChanged(sender As Object, e As EventArgs) Handles quater.CheckedChanged
        doGraph()
    End Sub

    Private Sub week_CheckedChanged(sender As Object, e As EventArgs) Handles week.CheckedChanged
        doGraph()
    End Sub

    Private Sub TrendChart_MouseDown(sender As Object, e As MouseEventArgs) Handles TrendChart.MouseDown

        Dim result As HitTestResult = TrendChart.HitTest(e.X, e.Y)

        If result.PointIndex >= 0 Then
            Dim dp As DataPoint = TrendChart.Series(0).Points(result.PointIndex)
            ToolTip1.SetToolTip(TrendChart, "Date:" & DateTime.FromOADate(dp.XValue) & " Quantity:" & dp.YValues(0))
            trendcordinate.Text = "Date:" & DateTime.FromOADate(dp.XValue) & " Quantity:" & dp.YValues(0)
        End If
    End Sub
End Class