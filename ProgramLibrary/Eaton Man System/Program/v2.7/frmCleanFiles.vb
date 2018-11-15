Imports System.ComponentModel

Public Class frmCleanFiles
    Private Sub btnCleanFiles_Click(sender As Object, e As EventArgs) Handles btnCleanFiles.Click
        lstCleanFiles.Items.Clear()
        clean_files()
    End Sub

    Private Sub frmCleanFiles_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmMenu.update_menu()
    End Sub
End Class