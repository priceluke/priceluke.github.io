Public Class frmRecordEdit_Product
    Private Sub frmRecordEdit_Job_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate_job_listbox()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FileOpen(1, "Products.dat", OpenMode.Random, , , Len(product_record))
        Dim lof_product As Integer = LOF(1) / Len(product_record)
        product_record.product_id = lof_product + 1
        product_record.product_desc = TextBox1.Text
        product_record.product_ass_location = TextBox2.Text
        FilePut(1, product_record, lof_product + 1)
        FileClose(1)
    End Sub
    Private Sub populate_job_listbox()
        Dim i As Integer
        FileOpen(1, "Products.dat", OpenMode.Random, , , Len(product_record))
        lstProducts.Items.Clear()
        lstProducts.Items.Add(" PRODUCT RECORD REPORT ")
        lstProducts.Items.Add("===============================")
        lstProducts.Items.Add("  ID  Description   Ass Location")
        lstProducts.Items.Add("===============================")
        If LOF(1) / Len(job_record) = 0 Then
            lstProducts.Items.Add("")
            lstProducts.Items.Add("No Records")
        Else
            For i = 1 To LOF(1) / Len(product_record)
                FileGet(1, product_record, i)
                lstProducts.Items.Add("  " & product_record.product_id & "   " & product_record.product_desc & "  " & product_record.product_ass_location)
            Next i
        End If
        FileClose(1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class