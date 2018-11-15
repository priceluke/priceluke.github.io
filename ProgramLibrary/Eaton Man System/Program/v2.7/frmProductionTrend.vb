Public Class frmProductionTrend
    Dim Rand As New Random
    Public current_product_or_comp As String = "Component"
    Public current_trendID As Integer
    Dim current_trend_product As New product
    Dim current_trend_component As New component
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TrendChart.Series(0).XValueType = DataVisualization.Charting.ChartValueType.DateTime
        Dim xvalue1 As New System.DateTime(2000, 11, 21)
        Dim xvalue2 As New System.DateTime(2006, 11, 2)
        Dim xvalue3 As New System.DateTime(2008, 1, 30)
        component.Checked = True
        TrendChart.Series("Trend").Color = Color.Red
        Dim x() As Integer = {xvalue1.ToOADate(), xvalue2.ToOADate(), xvalue3.ToOADate()}
        Dim y() As Integer = {1, 5, 7}
        TrendChart.ChartAreas("ChartArea1").AxisX.Title = "Date"
        TrendChart.ChartAreas("ChartArea1").AxisY.Title = "Frequency"
        TrendChart.Series("Trend").Points.DataBindXY(x, y)
        populate_combo()
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
End Class