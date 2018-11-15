Public Class Form1
    Private Sub Form1_ClientSizeChanged(sender As Object, e As EventArgs) Handles Me.ClientSizeChanged
        'dash_parentWrapper.Width = Me.Width - dash_manafactureWrapper.Width
        dash_parentWrapper.Height = Me.Height - 80
        footer_label.Left = (Me.Width / 2) - (footer_label.Width / 2)
        'dash_parentWrapper.Width = Me.Width - dash_manafactureWrapper.Width
        list_currentJob.Width = dash_parentWrapper.Width
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        recent_JobsListBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        pinned_JobsListBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        dash_manafactureWrapper.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        dash_jobsWrapper.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        list_currentJob.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        list_Confirmations.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        footer_label.Anchor = (System.Windows.Forms.AnchorStyles.Bottom)
        label_productAssLocation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top And System.Windows.Forms.AnchorStyles.Bottom And System.Windows.Forms.AnchorStyles.Right And System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        label_productDesc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top And System.Windows.Forms.AnchorStyles.Bottom And System.Windows.Forms.AnchorStyles.Right And System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        label_productQuantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top And System.Windows.Forms.AnchorStyles.Bottom And System.Windows.Forms.AnchorStyles.Right And System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        label_productID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top And System.Windows.Forms.AnchorStyles.Bottom And System.Windows.Forms.AnchorStyles.Right And System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        btn_addToJob.Anchor = CType((System.Windows.Forms.AnchorStyles.Top And System.Windows.Forms.AnchorStyles.Bottom And System.Windows.Forms.AnchorStyles.Right And System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dash_manafactureWrapper.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset
        btn_addToJob.Cursor = Cursors.Hand
        btn_addToJob.FlatStyle = FlatStyle.Flat
        With btn_addToJob.FlatAppearance
            .BorderColor = Color.Red
            .BorderSize = 0
            .MouseDownBackColor = Color.LightSkyBlue
            .MouseOverBackColor = Color.LightGray
        End With
        list_currentJob.BorderStyle = BorderStyle.FixedSingle
        For x = 1 To 20
            list_currentJob.Items.Add("" & CStr(x))
        Next

        list_currentJob.DrawMode = DrawMode.OwnerDrawFixed
        list_currentJob.ItemHeight += 5

        list_Confirmations.BorderStyle = BorderStyle.FixedSingle
        For x = 1 To 20
            list_Confirmations.Items.Add("" & CStr(x))
        Next

        list_Confirmations.DrawMode = DrawMode.OwnerDrawFixed
        list_Confirmations.ItemHeight += 5
    End Sub
    Private Sub list_Confirmations_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles list_Confirmations.DrawItem
        If e.Index Mod 2 = 0 Then
            e.Graphics.FillRectangle(Brushes.LightGray, e.Bounds)
        End If
        If list_Confirmations.SelectedIndex = e.Index Then
            e.Graphics.FillRectangle(Brushes.LightSkyBlue, e.Bounds)
            e.Graphics.DrawString(list_Confirmations.Items(e.Index).ToString, Me.Font, Brushes.White, 0, e.Bounds.Y + 2)
        Else
            e.Graphics.DrawString(list_Confirmations.Items(e.Index).ToString, Me.Font, Brushes.Black, 0, e.Bounds.Y + 2)
        End If
        e.Graphics.DrawRectangle(Pens.Gray, e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height)
    End Sub
    Private Sub list_currentJob_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles list_currentJob.DrawItem
        If e.Index Mod 2 = 0 Then
            e.Graphics.FillRectangle(Brushes.LightGray, e.Bounds)
        End If
        If list_currentJob.SelectedIndex = e.Index Then
            e.Graphics.FillRectangle(Brushes.LightSkyBlue, e.Bounds)
            e.Graphics.DrawString(list_currentJob.Items(e.Index).ToString, Me.Font, Brushes.White, 0, e.Bounds.Y + 2)
        Else
            e.Graphics.DrawString(list_currentJob.Items(e.Index).ToString, Me.Font, Brushes.Black, 0, e.Bounds.Y + 2)
        End If
        e.Graphics.DrawRectangle(Pens.Gray, e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height)
    End Sub

    Private Sub list_currentJob_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_currentJob.SelectedIndexChanged
        list_currentJob.Refresh()
    End Sub
End Class
