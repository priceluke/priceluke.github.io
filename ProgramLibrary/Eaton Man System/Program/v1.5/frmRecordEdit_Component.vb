Public Class frmRecordEdit_Component
    Private Sub frmRecordEdit_Job_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate_job_listbox()
    End Sub
    Private Sub populate_job_listbox()
        Dim i As Integer
        FileOpen(1, "Components.dat", OpenMode.Random, , , Len(component_record))
        lstComponents.Items.Clear()
        lstComponents.Items.Add(" PRODUCT RECORD REPORT ")
        lstComponents.Items.Add("===============================")
        lstComponents.Items.Add("  ID  Description   Ass Location")
        lstComponents.Items.Add("===============================")
        If LOF(1) / Len(location_record) = 0 Then
            lstComponents.Items.Add("")
            lstComponents.Items.Add("No Records")
        Else
            For i = 1 To LOF(1) / Len(component_record)
                FileGet(1, component_record, i)
                lstComponents.Items.Add("  " & component_record.component_id & "   " & component_record.component_desc)
            Next i
        End If
        FileClose(1)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FileOpen(1, "Components.dat", OpenMode.Random, , , Len(component_record))
        Dim lof_component As Integer = LOF(1) / Len(component_record)
        component_record.component_id = lof_component + 1
        component_record.component_desc = TextBox1.Text
        FilePut(1, component_record, lof_component + 1)
        FileClose(1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class