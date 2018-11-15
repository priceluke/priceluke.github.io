Imports System.IO
Imports System.Drawing.Text

Public Class frmPrintLabels
    Private Sub PrintLabels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvFormatting()
        txtName.Text = "EMU-CR_" & DateTime.Now.TimeOfDay.Hours & "_" & DateTime.Now.DayOfYear
        txtLocation.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\"
        For Each c As KnownColor In [Enum].GetValues(GetType(KnownColor))
            cmbFontColour.Items.Add([Enum].GetName(GetType(KnownColor), c))
            cmbBackgroundColour.Items.Add([Enum].GetName(GetType(KnownColor), c))
        Next
        Dim InstalledFonts As New InstalledFontCollection
        ' Gets the array of FontFamily objects associated with this FontCollection.
        Dim fontfamilies() As FontFamily = InstalledFonts.Families()

        '   Populates font combobox with the font name

        For Each fontFamily As FontFamily In fontfamilies
            cmbFontFamily.Items.Add(fontFamily.Name)
        Next
        cmbFontFamily.Text = cmbFontFamily.Items(0)
    End Sub


    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        Me.Close()
        frmMenu.Focus()
    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbExtension.SelectedIndexChanged
        txtLocation.ReadOnly = False
        txtName.ReadOnly = False
        cmbBackgroundColour.Enabled = True
        cmbColumns.Enabled = True
        cmbExtension.Enabled = True
        cmbFontColour.Enabled = True
        cmbFontFamily.Enabled = True
        cmbFontSize.Enabled = True
        If cmbExtension.SelectedItem.ToString = "Print" Then
            txtName.ReadOnly = True
            txtLocation.ReadOnly = True
        ElseIf cmbExtension.SelectedItem.ToString = "Word" Or cmbExtension.SelectedItem.ToString = "PDF" Then
            cmbColumns.Enabled = False
            cmbFontColour.Enabled = False
            cmbBackgroundColour.Enabled = False
        ElseIf cmbExtension.SelectedItem.ToString = "Text" Then
            cmbFontColour.Enabled = False
            cmbFontFamily.Enabled = False
            cmbFontSize.Enabled = False
            cmbColumns.Enabled = False
            cmbBackgroundColour.Enabled = False
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If Directory.Exists(txtLocation.Text) Then 'check location
            txtName.Text = System.Text.RegularExpressions.Regex.Replace(txtName.Text, "[^a-zA-Z0-9]", "-") ' check name
            MsgBox(print_label_location(cmbColumns.Text, cmbBackgroundColour.Text, cmbFontColour.Text, cmbFontFamily.Text, cmbFontSize.Text, txtLocation.Text, txtName.Text, cmbExtension.Text))
        Else
            MsgBox("This File Location Combination Is Not Valid.")
        End If
    End Sub
End Class