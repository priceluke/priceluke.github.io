Public Class frmRecordEdit_ProductComponent
    Private Sub frmRecordEdit_Job_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate_job_listbox()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FileOpen(1, "ProductComponent.dat", OpenMode.Random, , , Len(product_component_record))
        Dim lof_product_component As Integer = LOF(1) / Len(product_component_record)
        'Dim product_id As Integer 'FK 'Automatically generated
        'Dim component_id As Integer 'FK 'Automatically generated
        'Dim quantity As Integer ' Combo box
        product_component_record.product_id = TextBox1.Text
        product_component_record.component_id = TextBox2.Text
        product_component_record.quantity = TextBox3.Text
        FilePut(1, product_component_record, lof_product_component + 1)
        FileClose(1)
    End Sub
    Private Sub populate_job_listbox()
        Dim i As Integer
        FileOpen(1, "ProductComponent.dat", OpenMode.Random, , , Len(product_component_record))
        lstJobs.Items.Clear()
        lstJobs.Items.Add(" JOB RECORD REPORT ")
        lstJobs.Items.Add("===========================================================")
        lstJobs.Items.Add(" Job  Job               Job")
        lstJobs.Items.Add("  ID  Name              Date             Pinned? Username")
        lstJobs.Items.Add("===========================================================")
        If LOF(1) / Len(product_component_record) = 0 Then
            lstJobs.Items.Add("")
            lstJobs.Items.Add("No Records")
        Else
            For i = 1 To LOF(1) / Len(product_component_record)
                FileGet(1, product_component_record, i)
                lstJobs.Items.Add("  " & product_component_record.product_id & "   " & product_component_record.component_id & "  " & product_component_record.quantity)
            Next i
        End If
        FileClose(1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim o As Integer
        Dim filenum = FreeFile()
        FileOpen(filenum, "ProductComponent.dat", OpenMode.Random, , , Len(product_component_record))
        '
        Dim filenum_temp = FreeFile()
        FileOpen(filenum_temp, "ProductComponent_temp.dat", OpenMode.Random, , , Len(product_component_record))
        '
        Dim lof_product_component_temp As Integer = 0
        '
        Dim search_parameter() As String = {TextBox1.Text, TextBox2.Text, TextBox3.Text}
        If LOF(filenum) / Len(product_component_record) = 0 Then
        Else
            For o = 1 To LOF(filenum) / Len(product_component_record)
                FileGet(filenum, product_component_record, o)
                If product_component_record.product_id = search_parameter(0) And product_component_record.component_id = search_parameter(1) And product_component_record.quantity = search_parameter(2) Then
                    TextBox1.Text = "Record"
                    TextBox2.Text = "Removal"
                    TextBox3.Text = "Complete"
                Else
                    FilePut(filenum_temp, product_component_record, lof_product_component_temp)
                End If
                lof_product_component_temp += 1
            Next o
        End If
        FileClose(filenum)
        FileClose(filenum_temp)
        My.Computer.FileSystem.DeleteFile(CurDir() & "\ProductComponent.dat")
        My.Computer.FileSystem.RenameFile(CurDir() & "\ProductComponent_temp.dat", "ProductComponent.dat")
    End Sub
End Class