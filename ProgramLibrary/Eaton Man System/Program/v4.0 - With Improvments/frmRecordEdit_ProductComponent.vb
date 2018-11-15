Public Class frmRecordEdit_ProductComponent
    Private Sub frmRecordEdit_ProductComponent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pop()
    End Sub
    Sub pop()
        Dim len_ofFile, i As Integer
        len_ofFile = 0
        i = 0
        Dim insert_point As Integer = 0
        FileOpen(1, "Components.dat", OpenMode.Random, , , Len(component_record))
        len_ofFile = LOF(1) / Len(component_record)
        For i = 1 To len_ofFile
            FileGet(1, component_record, i)
            ListBox1.Items.Add(component_record.component_desc)
        Next
        FileClose(1)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FileOpen(1, "Components.dat", OpenMode.Random, , , Len(component_record))
        component_record.component_desc = "NOOT"
        FilePut(1, component_record, 2)
        FileClose(1)
        pop()
    End Sub
End Class