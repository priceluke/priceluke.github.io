<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_importFromExcel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_importFromExcel))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProductProgress = New System.Windows.Forms.Label()
        Me.ComponentProgress = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LocationProgress = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ProductComponentProgress = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComponentLocationProgress = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ProductsMax = New System.Windows.Forms.Label()
        Me.ComponentsMax = New System.Windows.Forms.Label()
        Me.LocationsMax = New System.Windows.Forms.Label()
        Me.ProductComponentsMax = New System.Windows.Forms.Label()
        Me.ComponentLocationMax = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.footer_label = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 120)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(695, 23)
        Me.ProgressBar1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(695, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Progress"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 14)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Products:"
        '
        'ProductProgress
        '
        Me.ProductProgress.AutoSize = True
        Me.ProductProgress.Location = New System.Drawing.Point(85, 2)
        Me.ProductProgress.Name = "ProductProgress"
        Me.ProductProgress.Size = New System.Drawing.Size(14, 14)
        Me.ProductProgress.TabIndex = 6
        Me.ProductProgress.Text = "0"
        '
        'ComponentProgress
        '
        Me.ComponentProgress.AutoSize = True
        Me.ComponentProgress.Location = New System.Drawing.Point(324, 2)
        Me.ComponentProgress.Name = "ComponentProgress"
        Me.ComponentProgress.Size = New System.Drawing.Size(14, 14)
        Me.ComponentProgress.TabIndex = 8
        Me.ComponentProgress.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(229, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 14)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Components:"
        '
        'LocationProgress
        '
        Me.LocationProgress.AutoSize = True
        Me.LocationProgress.Location = New System.Drawing.Point(562, 2)
        Me.LocationProgress.Name = "LocationProgress"
        Me.LocationProgress.Size = New System.Drawing.Size(14, 14)
        Me.LocationProgress.TabIndex = 10
        Me.LocationProgress.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(473, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 14)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Locations:"
        '
        'ProductComponentProgress
        '
        Me.ProductComponentProgress.AutoSize = True
        Me.ProductComponentProgress.Location = New System.Drawing.Point(170, 50)
        Me.ProductComponentProgress.Name = "ProductComponentProgress"
        Me.ProductComponentProgress.Size = New System.Drawing.Size(14, 14)
        Me.ProductComponentProgress.TabIndex = 12
        Me.ProductComponentProgress.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(85, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 28)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Product Component:"
        '
        'ComponentLocationProgress
        '
        Me.ComponentLocationProgress.AutoSize = True
        Me.ComponentLocationProgress.Location = New System.Drawing.Point(473, 50)
        Me.ComponentLocationProgress.Name = "ComponentLocationProgress"
        Me.ComponentLocationProgress.Size = New System.Drawing.Size(14, 14)
        Me.ComponentLocationProgress.TabIndex = 14
        Me.ComponentLocationProgress.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(376, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 28)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Component Location:"
        '
        'ProductsMax
        '
        Me.ProductsMax.AutoSize = True
        Me.ProductsMax.Location = New System.Drawing.Point(170, 2)
        Me.ProductsMax.Name = "ProductsMax"
        Me.ProductsMax.Size = New System.Drawing.Size(21, 14)
        Me.ProductsMax.TabIndex = 15
        Me.ProductsMax.Text = "/-"
        '
        'ComponentsMax
        '
        Me.ComponentsMax.AutoSize = True
        Me.ComponentsMax.Location = New System.Drawing.Point(376, 2)
        Me.ComponentsMax.Name = "ComponentsMax"
        Me.ComponentsMax.Size = New System.Drawing.Size(21, 14)
        Me.ComponentsMax.TabIndex = 16
        Me.ComponentsMax.Text = "/-"
        '
        'LocationsMax
        '
        Me.LocationsMax.AutoSize = True
        Me.LocationsMax.Location = New System.Drawing.Point(618, 2)
        Me.LocationsMax.Name = "LocationsMax"
        Me.LocationsMax.Size = New System.Drawing.Size(21, 14)
        Me.LocationsMax.TabIndex = 17
        Me.LocationsMax.Text = "/-"
        '
        'ProductComponentsMax
        '
        Me.ProductComponentsMax.AutoSize = True
        Me.ProductComponentsMax.Location = New System.Drawing.Point(229, 50)
        Me.ProductComponentsMax.Name = "ProductComponentsMax"
        Me.ProductComponentsMax.Size = New System.Drawing.Size(21, 14)
        Me.ProductComponentsMax.TabIndex = 18
        Me.ProductComponentsMax.Text = "/-"
        '
        'ComponentLocationMax
        '
        Me.ComponentLocationMax.AutoSize = True
        Me.ComponentLocationMax.Location = New System.Drawing.Point(562, 50)
        Me.ComponentLocationMax.Name = "ComponentLocationMax"
        Me.ComponentLocationMax.Size = New System.Drawing.Size(21, 14)
        Me.ComponentLocationMax.TabIndex = 19
        Me.ComponentLocationMax.Text = "/-"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter Workbook Location:"
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
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 2)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(701, 296)
        Me.TableLayoutPanel1.TabIndex = 20
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(695, 25)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(350, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(342, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
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
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.ProductComponentProgress, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.ProductComponentsMax, 3, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 5, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.ComponentLocationProgress, 6, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.ComponentLocationMax, 7, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 149)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(695, 99)
        Me.TableLayoutPanel3.TabIndex = 5
        '
        'footer_label
        '
        Me.footer_label.AutoSize = True
        Me.footer_label.Dock = System.Windows.Forms.DockStyle.Fill
        Me.footer_label.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.footer_label.ForeColor = System.Drawing.SystemColors.ControlText
        Me.footer_label.Location = New System.Drawing.Point(4, 251)
        Me.footer_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.footer_label.Name = "footer_label"
        Me.footer_label.Size = New System.Drawing.Size(693, 45)
        Me.footer_label.TabIndex = 6
        Me.footer_label.Text = "Luke Price - A2 Computing"
        Me.footer_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(284, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 47)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Import From Excel Spreadsheet"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_importFromExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 296)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_importFromExcel"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Import From Excel"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ProductProgress As Label
    Friend WithEvents ComponentProgress As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LocationProgress As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ProductComponentProgress As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ComponentLocationProgress As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ProductsMax As Label
    Friend WithEvents ComponentsMax As Label
    Friend WithEvents LocationsMax As Label
    Friend WithEvents ProductComponentsMax As Label
    Friend WithEvents ComponentLocationMax As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents footer_label As Label
    Friend WithEvents Button1 As Button
End Class
