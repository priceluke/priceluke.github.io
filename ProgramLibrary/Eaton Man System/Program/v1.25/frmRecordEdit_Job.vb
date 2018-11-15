Public Class frmRecordEdit_Job
    'Public Structure job
    '    'Dim time As DateTime = DateTime.Now
    '    'Dim format As String = "MMM ddd d HH:mm yyyy"
    '    Dim job_id As Integer 'PK
    '    <VBFixedString(24)> Dim job_username As String
    '    <VBFixedString(20)> Dim job_date_created As String
    '    <VBFixedString(24)> Dim job_name As String
    '    Dim job_pinned As Boolean
    '    Dim job_count As Integer
    'End Structure
    Private Sub frmRecordEdit_Job_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate_job_listbox()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FileOpen(1, "Jobs.dat", OpenMode.Random, , , Len(job_record))
        Dim lof_job As Integer = LOF(1) / Len(job_record)
        job_record.job_id = lof_job + 1
        job_record.job_name = TextBox1.Text
        Dim current_time As DateTime = DateTime.Now
        Dim format_CT As String = "M d HH:mm yy"
        job_record.job_date_created = current_time.ToString(format_CT)
        job_record.job_count = 0
        job_record.job_pinned = CheckBox1.Checked
        job_record.job_username = Environment.UserName
        MsgBox(job_record.job_username)
        MsgBox(lof_job)
        FilePut(1, job_record, lof_job + 1)
        FileClose(1)
    End Sub
    Private Sub populate_job_listbox()
        Dim i As Integer
        FileOpen(1, "Jobs.dat", OpenMode.Random, , , Len(job_record))
        lstJobs.Items.Clear()
        lstJobs.Items.Add(" JOB RECORD REPORT ")
        lstJobs.Items.Add("===========================================================")
        lstJobs.Items.Add(" Job  Job               Job")
        lstJobs.Items.Add("  ID  Name              Date             Pinned? Username")
        lstJobs.Items.Add("===========================================================")
        If LOF(1) / Len(job_record) = 0 Then
            lstJobs.Items.Add("")
            lstJobs.Items.Add("No Records")
        Else
            For i = 1 To LOF(1) / Len(job_record)
                FileGet(1, job_record, i)
                lstJobs.Items.Add("  " & job_record.job_id & "   " & job_record.job_name & "  " & job_record.job_date_created & "  " & job_record.job_pinned & "   " & job_record.job_username)
            Next i
        End If
        FileClose(1)
    End Sub
End Class