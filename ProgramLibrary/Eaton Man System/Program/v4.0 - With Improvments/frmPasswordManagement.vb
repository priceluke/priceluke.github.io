Imports System.IO
Public Class frmPasswordManagement
    Dim current_pass_config As New password
    Private Sub frmPasswordManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileOpen(1, "PasswordData.dat", OpenMode.Random, , , Len(password_record))
        If LOF(1) / Len(password_record) = 0 Then
            clear_password()
        Else
            FileGet(1, password_record, 1)
            current_pass_config = password_record
        End If
        FileClose(1)
        populate_from_password_config()
    End Sub
    Function ValidPassword(myPassword As String) As Boolean
        If myPassword.Length <= 8 Or myPassword.Length >= 26 Then Return False
        If Not myPassword.Any(Function(c) Char.IsDigit(c)) Then Return False
        If Not myPassword.Any(Function(c) Char.IsLower(c)) Then Return False
        If Not myPassword.Any(Function(c) Char.IsUpper(c)) Then Return False
        Return True
    End Function

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox1.PasswordChar = "•"
        Else
            TextBox1.PasswordChar = ""

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox3.Checked Then

            If ValidPassword(TextBox1.Text) Then
                current_pass_config.active = True
                If CheckBox2.Checked Then
                    current_pass_config.password = SimpleCrypt(TextBox1.Text)
                    current_pass_config.encrypted = True
                Else
                    current_pass_config.password = TextBox1.Text
                    current_pass_config.encrypted = False
                End If
                FileOpen(1, "PasswordData.dat", OpenMode.Random, , , Len(password_record))
                FilePut(1, current_pass_config, 1)
                FileClose(1)
                Label1.Text = "Password Has Been Updated - " & Now
            Else
                Label1.Text = "Password Requires: 8<x<=26 chars, one upper case, lower case and a digit."
            End If
        Else
            Button2.PerformClick
        End If
        populate_from_password_config()
    End Sub
    Sub populate_from_password_config()
        If current_pass_config.active = True Then
            CheckBox1.Checked = True
            If current_pass_config.encrypted = True Then
                CheckBox2.Checked = True
                TextBox1.Text = SimpleCrypt(current_pass_config.password.TrimEnd)
            Else
                TextBox1.Text = current_pass_config.password.TrimEnd
            End If
        End If
        ListView1.Items.Clear()
        Dim NewEntry = ListView1.Items.Add(current_pass_config.active)
        NewEntry.SubItems.Add(current_pass_config.encrypted)
        NewEntry.SubItems.Add(current_pass_config.password)
    End Sub

    Sub clear_password()
        current_pass_config.active = False
        current_pass_config.encrypted = False
        current_pass_config.password = String.Empty
        FilePut(1, current_pass_config, 1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FileOpen(1, "PasswordData.dat", OpenMode.Random, , , Len(password_record))
        clear_password()
        FileClose(1)
        Label1.Text = "Password Has Been Cleared - " & Now
        populate_from_password_config()
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox1.Checked Then
            TextBox1.Enabled = True
            TextBox1.ReadOnly = False
        Else
            TextBox1.Enabled = False
            TextBox1.ReadOnly = True
        End If
    End Sub

    Private Sub frmPasswordManagement_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Label1.Text.Contains("Updated") Then
            Process.Start("Eaton Manafacturing System.exe")
            End
        End If
    End Sub
End Class