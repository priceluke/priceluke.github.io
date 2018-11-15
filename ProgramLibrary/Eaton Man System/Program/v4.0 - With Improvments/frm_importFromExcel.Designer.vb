<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_importFromExcel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_importFromExcel))
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Percentage = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblRemaining = New System.Windows.Forms.Label()
        Me.lblElapsed = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSelectWB = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProductProgress = New System.Windows.Forms.Label()
        Me.ProductsMax = New System.Windows.Forms.Label()
        Me.LocationsMax = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComponentsMax = New System.Windows.Forms.Label()
        Me.ComponentProgress = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LocationProgress = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ProductComponentProgress = New System.Windows.Forms.Label()
        Me.ProductComponentsMax = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComponentLocationProgress = New System.Windows.Forms.Label()
        Me.ComponentLocationMax = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProgressTotal = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.Label()
        Me.footer_label = New System.Windows.Forms.Label()
        Me.frmWorkbookPicker = New System.Windows.Forms.OpenFileDialog()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Button1, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Percentage, 2, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label9, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label10, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lblRemaining, 3, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.lblElapsed, 1, 1)
        Me.TableLayoutPanel4.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 70)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(695, 100)
        Me.TableLayoutPanel4.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(281, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 44)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Import From Excel Spreadsheet"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Percentage
        '
        Me.Percentage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Percentage.AutoSize = True
        Me.Percentage.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Percentage.Location = New System.Drawing.Point(333, 50)
        Me.Percentage.Name = "Percentage"
        Me.Percentage.Size = New System.Drawing.Size(28, 50)
        Me.Percentage.TabIndex = 2
        Me.Percentage.Text = "-%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(420, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 28)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Estimated Time Remaining:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(142, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 14)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Time Elapsed:"
        '
        'lblRemaining
        '
        Me.lblRemaining.AutoSize = True
        Me.lblRemaining.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemaining.Location = New System.Drawing.Point(420, 50)
        Me.lblRemaining.Name = "lblRemaining"
        Me.lblRemaining.Size = New System.Drawing.Size(14, 14)
        Me.lblRemaining.TabIndex = 6
        Me.lblRemaining.Text = "-"
        '
        'lblElapsed
        '
        Me.lblElapsed.AutoSize = True
        Me.lblElapsed.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblElapsed.Location = New System.Drawing.Point(142, 50)
        Me.lblElapsed.Name = "lblElapsed"
        Me.lblElapsed.Size = New System.Drawing.Size(14, 14)
        Me.lblElapsed.TabIndex = 5
        Me.lblElapsed.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(695, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Progress"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 189)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(695, 23)
        Me.ProgressBar1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnSelectWB, 2, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(695, 41)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBox1.Location = New System.Drawing.Point(308, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(299, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter Workbook Location:"
        '
        'btnSelectWB
        '
        Me.btnSelectWB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSelectWB.Location = New System.Drawing.Point(613, 3)
        Me.btnSelectWB.Name = "btnSelectWB"
        Me.btnSelectWB.Size = New System.Drawing.Size(79, 35)
        Me.btnSelectWB.TabIndex = 4
        Me.btnSelectWB.Text = "Select Workbook:"
        Me.btnSelectWB.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ProgressBar1, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.footer_label, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(701, 343)
        Me.TableLayoutPanel1.TabIndex = 20
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 9
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.ProductProgress, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.ProductsMax, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LocationsMax, 8, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.ComponentsMax, 5, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.ComponentProgress, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label6, 6, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LocationProgress, 7, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.ProductComponentProgress, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.ProductComponentsMax, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 3, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.ComponentLocationProgress, 4, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.ComponentLocationMax, 5, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 6, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.ProgressTotal, 7, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Total, 8, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 218)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(695, 99)
        Me.TableLayoutPanel3.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 14)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Products:"
        '
        'ProductProgress
        '
        Me.ProductProgress.AutoSize = True
        Me.ProductProgress.Location = New System.Drawing.Point(91, 0)
        Me.ProductProgress.Name = "ProductProgress"
        Me.ProductProgress.Size = New System.Drawing.Size(14, 14)
        Me.ProductProgress.TabIndex = 6
        Me.ProductProgress.Text = "0"
        '
        'ProductsMax
        '
        Me.ProductsMax.AutoSize = True
        Me.ProductsMax.Location = New System.Drawing.Point(174, 0)
        Me.ProductsMax.Name = "ProductsMax"
        Me.ProductsMax.Size = New System.Drawing.Size(21, 14)
        Me.ProductsMax.TabIndex = 15
        Me.ProductsMax.Text = "/-"
        '
        'LocationsMax
        '
        Me.LocationsMax.AutoSize = True
        Me.LocationsMax.Location = New System.Drawing.Point(610, 0)
        Me.LocationsMax.Name = "LocationsMax"
        Me.LocationsMax.Size = New System.Drawing.Size(21, 14)
        Me.LocationsMax.TabIndex = 17
        Me.LocationsMax.Text = "/-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(231, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 14)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Components:"
        '
        'ComponentsMax
        '
        Me.ComponentsMax.AutoSize = True
        Me.ComponentsMax.Location = New System.Drawing.Point(374, 0)
        Me.ComponentsMax.Name = "ComponentsMax"
        Me.ComponentsMax.Size = New System.Drawing.Size(21, 14)
        Me.ComponentsMax.TabIndex = 16
        Me.ComponentsMax.Text = "/-"
        '
        'ComponentProgress
        '
        Me.ComponentProgress.AutoSize = True
        Me.ComponentProgress.Location = New System.Drawing.Point(324, 0)
        Me.ComponentProgress.Name = "ComponentProgress"
        Me.ComponentProgress.Size = New System.Drawing.Size(14, 14)
        Me.ComponentProgress.TabIndex = 8
        Me.ComponentProgress.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(469, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 14)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Locations:"
        '
        'LocationProgress
        '
        Me.LocationProgress.AutoSize = True
        Me.LocationProgress.Location = New System.Drawing.Point(556, 0)
        Me.LocationProgress.Name = "LocationProgress"
        Me.LocationProgress.Size = New System.Drawing.Size(14, 14)
        Me.LocationProgress.TabIndex = 10
        Me.LocationProgress.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 28)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Product Component:"
        '
        'ProductComponentProgress
        '
        Me.ProductComponentProgress.AutoSize = True
        Me.ProductComponentProgress.Location = New System.Drawing.Point(91, 49)
        Me.ProductComponentProgress.Name = "ProductComponentProgress"
        Me.ProductComponentProgress.Size = New System.Drawing.Size(14, 14)
        Me.ProductComponentProgress.TabIndex = 12
        Me.ProductComponentProgress.Text = "0"
        '
        'ProductComponentsMax
        '
        Me.ProductComponentsMax.AutoSize = True
        Me.ProductComponentsMax.Location = New System.Drawing.Point(174, 49)
        Me.ProductComponentsMax.Name = "ProductComponentsMax"
        Me.ProductComponentsMax.Size = New System.Drawing.Size(21, 14)
        Me.ProductComponentsMax.TabIndex = 18
        Me.ProductComponentsMax.Text = "/-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(231, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 28)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Component Location:"
        '
        'ComponentLocationProgress
        '
        Me.ComponentLocationProgress.AutoSize = True
        Me.ComponentLocationProgress.Location = New System.Drawing.Point(324, 49)
        Me.ComponentLocationProgress.Name = "ComponentLocationProgress"
        Me.ComponentLocationProgress.Size = New System.Drawing.Size(14, 14)
        Me.ComponentLocationProgress.TabIndex = 14
        Me.ComponentLocationProgress.Text = "0"
        '
        'ComponentLocationMax
        '
        Me.ComponentLocationMax.AutoSize = True
        Me.ComponentLocationMax.Location = New System.Drawing.Point(374, 49)
        Me.ComponentLocationMax.Name = "ComponentLocationMax"
        Me.ComponentLocationMax.Size = New System.Drawing.Size(21, 14)
        Me.ComponentLocationMax.TabIndex = 19
        Me.ComponentLocationMax.Text = "/-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(469, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 14)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Total:"
        '
        'ProgressTotal
        '
        Me.ProgressTotal.AutoSize = True
        Me.ProgressTotal.Location = New System.Drawing.Point(556, 49)
        Me.ProgressTotal.Name = "ProgressTotal"
        Me.ProgressTotal.Size = New System.Drawing.Size(14, 14)
        Me.ProgressTotal.TabIndex = 21
        Me.ProgressTotal.Text = "0"
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Location = New System.Drawing.Point(610, 49)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(21, 14)
        Me.Total.TabIndex = 22
        Me.Total.Text = "/-"
        '
        'footer_label
        '
        Me.footer_label.AutoSize = True
        Me.footer_label.BackColor = System.Drawing.SystemColors.ControlLight
        Me.footer_label.Dock = System.Windows.Forms.DockStyle.Fill
        Me.footer_label.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.footer_label.ForeColor = System.Drawing.SystemColors.ControlText
        Me.footer_label.Location = New System.Drawing.Point(4, 320)
        Me.footer_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.footer_label.Name = "footer_label"
        Me.footer_label.Size = New System.Drawing.Size(693, 23)
        Me.footer_label.TabIndex = 6
        Me.footer_label.Text = "Luke Price - A2 Computing"
        Me.footer_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmWorkbookPicker
        '
        Me.frmWorkbookPicker.FileName = "OpenFileDialog1"
        '
        'frm_importFromExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 343)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_importFromExcel"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Import From Excel"
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Percentage As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblRemaining As Label
    Friend WithEvents lblElapsed As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents ProductProgress As Label
    Friend WithEvents ProductsMax As Label
    Friend WithEvents LocationsMax As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComponentsMax As Label
    Friend WithEvents ComponentProgress As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LocationProgress As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ProductComponentProgress As Label
    Friend WithEvents ProductComponentsMax As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComponentLocationProgress As Label
    Friend WithEvents ComponentLocationMax As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ProgressTotal As Label
    Friend WithEvents Total As Label
    Friend WithEvents footer_label As Label
    Friend WithEvents btnSelectWB As Button
    Friend WithEvents frmWorkbookPicker As OpenFileDialog
End Class
