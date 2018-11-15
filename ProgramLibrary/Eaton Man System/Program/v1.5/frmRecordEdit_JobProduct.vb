Public Class frmRecordEdit_JobProduct
    'Dim job_id As Integer 'FK - Automatically generated
    'Dim product_id As Integer 'FK - Automatically generated
    'Dim quantity As Integer 'Combobox

    Private Sub frmRecordEdit_JobProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate_job_listbox()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        FileOpen(1, "JobProduct.dat", OpenMode.Random, , , Len(job_product_record))
        Dim lof_product_component As Integer = LOF(1) / Len(job_product_record)
        'Dim product_id As Integer 'FK 'Automatically generated
        'Dim component_id As Integer 'FK 'Automatically generated
        'Dim quantity As Integer ' Combo box
        job_product_record.job_id = TextBox1.Text
        job_product_record.product_id = TextBox2.Text
        job_product_record.quantity = TextBox3.Text
        FilePut(1, job_product_record, lof_product_component + 1)
        FileClose(1)
    End Sub
    Private Sub populate_job_listbox()
        Dim i As Integer
        FileOpen(1, "JobProduct.dat", OpenMode.Random, , , Len(job_product_record))
        lstJobProduct.Items.Clear()
        lstJobProduct.Items.Add(" JOB PRODUCT RECORD REPORT ")
        lstJobProduct.Items.Add("===========================================================")
        lstJobProduct.Items.Add(" Job    Product")
        lstJobProduct.Items.Add("  ID    ID            Quantity")
        lstJobProduct.Items.Add("===========================================================")
        If LOF(1) / Len(job_product_record) = 0 Then
            lstJobProduct.Items.Add("")
            lstJobProduct.Items.Add("No Records")
        Else
            For i = 1 To LOF(1) / Len(job_product_record)
                FileGet(1, job_product_record, i)
                lstJobProduct.Items.Add("  " & job_product_record.job_id & "   " & job_product_record.product_id & "  " & job_product_record.quantity)
            Next i
        End If
        FileClose(1)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim o As Integer
        Dim filenum = FreeFile()
        FileOpen(filenum, "JobProduct.dat", OpenMode.Random, , , Len(job_product_record))
        '
        Dim filenum_temp = FreeFile()
        FileOpen(filenum_temp, "JobProduct_temp.dat", OpenMode.Random, , , Len(job_product_record))
        '
        Dim lof_job_product_record_temp As Integer = 1
        '
        Dim search_parameter() As String = {TextBox1.Text, TextBox2.Text, TextBox3.Text}
        If LOF(filenum) / Len(job_product_record) = 0 Then
        Else
            For o = 1 To LOF(filenum) / Len(job_product_record)
                FileGet(filenum, job_product_record, o)
                If job_product_record.product_id = search_parameter(0) And job_product_record.product_id = search_parameter(1) And job_product_record.quantity = search_parameter(2) Then
                    TextBox1.Text = "Record"
                    TextBox2.Text = "Removal"
                    TextBox3.Text = "Complete"
                Else
                    FilePut(filenum_temp, job_product_record, lof_job_product_record_temp)
                End If
                lof_job_product_record_temp += 1
            Next o
        End If
        FileClose(filenum)
        FileClose(filenum_temp)
        My.Computer.FileSystem.DeleteFile(CurDir() & "\JobProduct.dat")
        My.Computer.FileSystem.RenameFile(CurDir() & "\JobProduct_temp.dat", "ProductComponent.dat")
    End Sub
End Class