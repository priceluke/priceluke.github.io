Public Class frmProductionLogDebugging
    Private Sub frmProductionLogDebugging_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm:ss"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FileOpen(1, "ComponentCreationLog.dat", OpenMode.Random, , , Len(component_trend_record))
        component_trend_record.ID = InputBox("id")
        component_trend_record.dateOutput = DateTimePicker1.Value
        component_trend_record.Quantity = 5
        Dim lengthoffile As Integer = (LOF(1) / Len(component_trend_record) + 1)
        FilePut(1, component_trend_record, lengthoffile)
        FileClose(1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FileOpen(1, "productCreationLog.dat", OpenMode.Random, , , Len(product_trend_record))
        product_trend_record.ID = InputBox("id")
        product_trend_record.dateOutput = DateTimePicker1.Value
        product_trend_record.Quantity = 5
        Dim lengthoffile As Integer = (LOF(1) / Len(product_trend_record) + 1)
        FilePut(1, product_trend_record, lengthoffile)
        FileClose(1)
    End Sub
End Class