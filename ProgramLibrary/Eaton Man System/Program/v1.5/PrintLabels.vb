Public Class PrintLabels
    Private Sub PrintComponentLabels_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintComponentLabels.PrintPage
        Dim bm As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bm, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintComponentLabels.Print()
    End Sub

    Private Sub PrintLabels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Columns.Clear()
        For Each Col As DataGridViewColumn In frmMenu.Print_Components.Columns
            DataGridView1.Columns.Add(DirectCast(Col.Clone, DataGridViewColumn))
        Next
        For rowIndex As Integer = 0 To (frmMenu.Print_Components.Rows.Count - 1)
            DataGridView1.Rows.Add(frmMenu.Print_Components.Rows(rowIndex).Cells.Cast(Of DataGridViewCell).Select(Function(c) c.Value).ToArray)
        Next
    End Sub
End Class