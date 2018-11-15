Public Class PrintLabels
    Private Sub PrintComponentLabels_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintComponentLabels.PrintPage
        Dim bm As New Bitmap(Me.Labels.Width, Me.Labels.Height)
        Labels.DrawToBitmap(bm, New Rectangle(0, 0, Me.Labels.Width, Me.Labels.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub PrintLabels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Labels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Labels.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Labels.RowHeadersVisible = False
        Labels.Columns.Clear()
        Formatting()
        For Each Col As DataGridViewColumn In frmMenu.Print_Components.Columns
            Labels.Columns.Add(DirectCast(Col.Clone, DataGridViewColumn))
        Next
        For rowIndex As Integer = 0 To (frmMenu.Print_Components.Rows.Count - 1)
            Labels.Rows.Add(frmMenu.Print_Components.Rows(rowIndex).Cells.Cast(Of DataGridViewCell).Select(Function(c) c.Value).ToArray)
        Next
    End Sub
    Sub Formatting()
        Labels.Font = New Font("Courier New", 28, FontStyle.Regular)
        'Labels.Dock = DockStyle.Fill
        Labels.GridColor = Color.Navy
        Labels.CellBorderStyle = DataGridViewCellBorderStyle.None
        Labels.BackgroundColor = Color.LightGray
        Labels.DefaultCellStyle.SelectionBackColor = Color.Black
        Labels.DefaultCellStyle.SelectionForeColor = Color.White
        Labels.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Labels.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Labels.AllowUserToResizeColumns = False
        Labels.RowsDefaultCellStyle.BackColor = Color.LightSteelBlue
        Labels.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        Labels.ClearSelection()
        PrintComponentLabels.Print()
    End Sub
End Class