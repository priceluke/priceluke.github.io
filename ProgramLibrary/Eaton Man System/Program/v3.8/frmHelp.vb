Imports System.IO
Public Class frmHelp
    Private Sub frmHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TopMost = True
        RichTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ''
        Dim list As New List(Of String)
        ' Open file.txt with the Using statement.
        Using r As StreamReader = New StreamReader("HelpFiles/HelpTitles.txt")
            ' Store contents in this String.
            Dim line As String
            ' Read first line.
            line = r.ReadLine
            ' Loop over each line in file, While list is Not Nothing.
            Do While (Not line Is Nothing)
                ' Add this line to list.
                list.Add(line)
                ' Display to console.
                ' Read in the next line.
                line = r.ReadLine
            Loop
        End Using
        ComboBox1.DataSource = list
        ''
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        RichTextBox1.Clear()
        Using r As StreamReader = New StreamReader("HelpFiles/" & ComboBox1.SelectedIndex + 1 & ".txt")
            ' Store contents in this String.
            Dim line As String
            ' Read first line.
            line = r.ReadLine
            ' Loop over each line in file, While list is Not Nothing.
            Do While (Not line Is Nothing)
                ' Add this line to list.
                RichTextBox1.Text &= line & vbNewLine
                ' Display to console.
                ' Read in the next line.
                line = r.ReadLine
            Loop
        End Using
    End Sub
End Class