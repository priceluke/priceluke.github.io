Public Class frmProductionLog
    Private Sub frmProductionLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim list_ofproducts As New List(Of String)
        Dim list_ofcomponents As New List(Of String)
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
                For x = 1 To product_trend_record.Quantity
                    list_ofproducts.Add(product_trend_record.ID)
                Next
            Next
        End If
        If LOF(2) / Len(component_trend_record) = 0 Then
        Else
            For i = 1 To LOF(2) / Len(component_trend_record)
                FileGet(2, component_trend_record, i)
                listview_populate = ListView2.Items.Add(component_trend_record.ID)
                listview_populate.SubItems.Add(component_trend_record.Quantity)
                listview_populate.SubItems.Add(component_trend_record.dateOutput)
                For x = 1 To component_trend_record.Quantity
                    list_ofcomponents.Add(component_trend_record.ID)
                Next
            Next
        End If
        FileClose(1)
        FileClose(2)
        Dim foundMost_product As String = list_ofproducts.Cast(Of String).GroupBy(Function(x) x).OrderByDescending(Function(y) y.Count).First.Key
        Dim prod_most As product = getProductRecord(foundMost_product)
        Label7.Text = prod_most.product_desc.Trim & "  -  " & prod_most.product_id
        Dim foundMost_component As String = list_ofcomponents.Cast(Of String).GroupBy(Function(x) x).OrderByDescending(Function(y) y.Count).First.Key
        Dim comp_most As component = getComponentRecord(foundMost_component)
        Label8.Text = comp_most.component_desc.Trim & "  -  " & comp_most.component_id
    End Sub

    Private Sub frmProductionLog_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        For t = 0 To ListView1.Columns.Count - 1
            ListView1.Columns(t).Width = (ListView1.Width / ListView1.Columns.Count) - 7
        Next
        For t = 0 To ListView2.Columns.Count - 1
            ListView2.Columns(t).Width = (ListView2.Width / ListView2.Columns.Count) - 7
        Next
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Dim search_parameter = ListView1.SelectedItems(0).Text
        Try
            Dim returned_product As product = getProductRecord(search_parameter)
            frmRecordEditor.txtProductID.Text = returned_product.product_id
            frmRecordEditor.txtProductDesc.Text = returned_product.product_desc
            frmRecordEditor.txtProductCode.Text = returned_product.product_code
        Catch
            MsgBox("A record containing the value '" & search_parameter & "' could not be found.")
        End Try
        frmRecordEditor.Show()
    End Sub

    Private Sub ListView2_DoubleClick(sender As Object, e As EventArgs) Handles ListView2.DoubleClick
        Dim search_parameter = ListView2.SelectedItems(0).Text
        Try
            Dim returned_component As component = getComponentRecord(search_parameter)
            frmRecordEditor.txtComponentID.Text = returned_component.component_id
            frmRecordEditor.txtComponentDescription.Text = returned_component.component_desc
            frmRecordEditor.txtComponentCode.Text = returned_component.component_code
        Catch
            MsgBox("A record containing the value '" & search_parameter & "' could not be found.")
        End Try
        frmRecordEditor.Show()

    End Sub
End Class