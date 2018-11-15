Public Class frmRecordEdit_Location
    Private Sub frmRecordEdit_Job_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate_job_listbox()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FileOpen(1, "Locations.dat", OpenMode.Random, , , Len(location_record))
        Dim lof_location As Integer = LOF(1) / Len(location_record)
        location_record.location_id = lof_location + 1
        location_record.location_desc = TextBox1.Text
        FilePut(1, location_record, lof_location + 1)
        FileClose(1)
    End Sub
    Private Sub populate_job_listbox()
        Dim i As Integer
        FileOpen(1, "Locations.dat", OpenMode.Random, , , Len(location_record))
        lstLocations.Items.Clear()
        lstLocations.Items.Add(" PRODUCT RECORD REPORT ")
        lstLocations.Items.Add("===============================")
        lstLocations.Items.Add("  ID  Description   Ass Location")
        lstLocations.Items.Add("===============================")
        If LOF(1) / Len(location_record) = 0 Then
            lstLocations.Items.Add("")
            lstLocations.Items.Add("No Records")
        Else
            For i = 1 To LOF(1) / Len(location_record)
                FileGet(1, location_record, i)
                lstLocations.Items.Add("  " & location_record.location_id & "   " & location_record.location_desc)
            Next i
        End If
        FileClose(1)
    End Sub
End Class