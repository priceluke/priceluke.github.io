Public Class frmProductionLog
    Private Sub frmProductionLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileOpen(1, "ProductCreationLog.dat", OpenMode.Random, , , Len(product_trend_record))
        FileOpen(2, "ComponentCreationLog.dat", OpenMode.Random, , , Len(component_trend_record))
        Dim listview_populate As ListViewItem
        If LOF(1) / Len(product_trend_record) = 0 Then
        Else
            For i = 1 To LOF(1) / Len(product_trend_record)
                FileGet(1, product_trend_record, i)
                listview_populate = ListView1.Items.Add(product_trend_record.ID)
                listview_populate.SubItems.Add(product_trend_record.Quantity)
                listview_populate.SubItems.Add(product_trend_record.dateOutput)
            Next
        End If
        If LOF(2) / Len(component_trend_record) = 0 Then
        Else
            For i = 1 To LOF(2) / Len(component_trend_record)
                FileGet(2, component_trend_record, i)
                listview_populate = ListView2.Items.Add(component_trend_record.ID)
                listview_populate.SubItems.Add(component_trend_record.Quantity)
                listview_populate.SubItems.Add(component_trend_record.dateOutput)
            Next
        End If
        FileClose(1)
        FileClose(2)
    End Sub

    Private Sub frmProductionLog_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        For t = 0 To ListView1.Columns.Count - 1
            ListView1.Columns(t).Width = (ListView1.Width / ListView1.Columns.Count) - 7
        Next
        For t = 0 To ListView2.Columns.Count - 1
            ListView2.Columns(t).Width = (ListView2.Width / ListView2.Columns.Count) - 7
        Next
    End Sub
End Class