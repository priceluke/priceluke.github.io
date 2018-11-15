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
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 154)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(397, 23)
        Me.ProgressBar1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(138, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 54)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Import From Excel Spreadsheet"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(150, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(259, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter Workbook Location:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(177, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Progress"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Products:"
        '
        'ProductProgress
        '
        Me.ProductProgress.AutoSize = True
        Me.ProductProgress.Location = New System.Drawing.Point(61, 194)
        Me.ProductProgress.Name = "ProductProgress"
        Me.ProductProgress.Size = New System.Drawing.Size(13, 13)
        Me.ProductProgress.TabIndex = 6
        Me.ProductProgress.Text = "0"
        '
        'ComponentProgress
        '
        Me.ComponentProgress.AutoSize = True
        Me.ComponentProgress.Location = New System.Drawing.Point(198, 193)
        Me.ComponentProgress.Name = "ComponentProgress"
        Me.ComponentProgress.Size = New System.Drawing.Size(13, 13)
        Me.ComponentProgress.TabIndex = 8
        Me.ComponentProgress.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(128, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Components:"
        '
        'LocationProgress
        '
        Me.LocationProgress.AutoSize = True
        Me.LocationProgress.Location = New System.Drawing.Point(346, 194)
        Me.LocationProgress.Name = "LocationProgress"
        Me.LocationProgress.Size = New System.Drawing.Size(13, 13)
        Me.LocationProgress.TabIndex = 10
        Me.LocationProgress.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(290, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Locations:"
        '
        'ProductComponentProgress
        '
        Me.ProductComponentProgress.AutoSize = True
        Me.ProductComponentProgress.Location = New System.Drawing.Point(134, 248)
        Me.ProductComponentProgress.Name = "ProductComponentProgress"
        Me.ProductComponentProgress.Size = New System.Drawing.Size(13, 13)
        Me.ProductComponentProgress.TabIndex = 12
        Me.ProductComponentProgress.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Product Component:"
        '
        'ComponentLocationProgress
        '
        Me.ComponentLocationProgress.AutoSize = True
        Me.ComponentLocationProgress.Location = New System.Drawing.Point(328, 248)
        Me.ComponentLocationProgress.Name = "ComponentLocationProgress"
        Me.ComponentLocationProgress.Size = New System.Drawing.Size(13, 13)
        Me.ComponentLocationProgress.TabIndex = 14
        Me.ComponentLocationProgress.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(219, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Component Location:"
        '
        'ProductsMax
        '
        Me.ProductsMax.AutoSize = True
        Me.ProductsMax.Location = New System.Drawing.Point(91, 193)
        Me.ProductsMax.Name = "ProductsMax"
        Me.ProductsMax.Size = New System.Drawing.Size(15, 13)
        Me.ProductsMax.TabIndex = 15
        Me.ProductsMax.Text = "/-"
        '
        'ComponentsMax
        '
        Me.ComponentsMax.AutoSize = True
        Me.ComponentsMax.Location = New System.Drawing.Point(236, 193)
        Me.ComponentsMax.Name = "ComponentsMax"
        Me.ComponentsMax.Size = New System.Drawing.Size(15, 13)
        Me.ComponentsMax.TabIndex = 16
        Me.ComponentsMax.Text = "/-"
        '
        'LocationsMax
        '
        Me.LocationsMax.AutoSize = True
        Me.LocationsMax.Location = New System.Drawing.Point(376, 195)
        Me.LocationsMax.Name = "LocationsMax"
        Me.LocationsMax.Size = New System.Drawing.Size(15, 13)
        Me.LocationsMax.TabIndex = 17
        Me.LocationsMax.Text = "/-"
        '
        'ProductComponentsMax
        '
        Me.ProductComponentsMax.AutoSize = True
        Me.ProductComponentsMax.Location = New System.Drawing.Point(167, 248)
        Me.ProductComponentsMax.Name = "ProductComponentsMax"
        Me.ProductComponentsMax.Size = New System.Drawing.Size(15, 13)
        Me.ProductComponentsMax.TabIndex = 18
        Me.ProductComponentsMax.Text = "/-"
        '
        'ComponentLocationMax
        '
        Me.ComponentLocationMax.AutoSize = True
        Me.ComponentLocationMax.Location = New System.Drawing.Point(366, 248)
        Me.ComponentLocationMax.Name = "ComponentLocationMax"
        Me.ComponentLocationMax.Size = New System.Drawing.Size(15, 13)
        Me.ComponentLocationMax.TabIndex = 19
        Me.ComponentLocationMax.Text = "/-"
        '
        'frm_importFromExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 279)
        Me.Controls.Add(Me.ComponentLocationMax)
        Me.Controls.Add(Me.ProductComponentsMax)
        Me.Controls.Add(Me.LocationsMax)
        Me.Controls.Add(Me.ComponentsMax)
        Me.Controls.Add(Me.ProductsMax)
        Me.Controls.Add(Me.ComponentLocationProgress)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ProductComponentProgress)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LocationProgress)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComponentProgress)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ProductProgress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_importFromExcel"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "frm_importFromExcel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
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
End Class
