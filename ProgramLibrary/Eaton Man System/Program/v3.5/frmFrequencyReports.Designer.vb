<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFrequencyReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFrequencyReports))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.preview = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.checkFootnoteprompt = New System.Windows.Forms.CheckBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.check_totalComponents = New System.Windows.Forms.CheckBox()
        Me.checkTotalProd = New System.Windows.Forms.CheckBox()
        Me.check_prod_production = New System.Windows.Forms.CheckBox()
        Me.check_comp_production = New System.Windows.Forms.CheckBox()
        Me.checkJobOutput = New System.Windows.Forms.CheckBox()
        Me.checkLocationOutput = New System.Windows.Forms.CheckBox()
        Me.checkProdOutput = New System.Windows.Forms.CheckBox()
        Me.checkCompOutput = New System.Windows.Forms.CheckBox()
        Me.checkMostJob = New System.Windows.Forms.CheckBox()
        Me.checkMostProd = New System.Windows.Forms.CheckBox()
        Me.checkMostComp = New System.Windows.Forms.CheckBox()
        Me.saveFile = New System.Windows.Forms.SaveFileDialog()
        Me.checkJobProduct = New System.Windows.Forms.CheckBox()
        Me.checkProductComponent = New System.Windows.Forms.CheckBox()
        Me.checkCompLoca = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.80977!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.19022!))
        Me.TableLayoutPanel1.Controls.Add(Me.preview, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.775701!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.2243!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(573, 508)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'preview
        '
        Me.preview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.preview.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.preview.FormattingEnabled = True
        Me.preview.ItemHeight = 14
        Me.preview.Location = New System.Drawing.Point(190, 37)
        Me.preview.Name = "preview"
        Me.preview.Size = New System.Drawing.Size(380, 468)
        Me.preview.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Report Setup:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(190, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(380, 34)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Preview"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.checkCompLoca)
        Me.GroupBox1.Controls.Add(Me.checkProductComponent)
        Me.GroupBox1.Controls.Add(Me.checkJobProduct)
        Me.GroupBox1.Controls.Add(Me.checkFootnoteprompt)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.check_totalComponents)
        Me.GroupBox1.Controls.Add(Me.checkTotalProd)
        Me.GroupBox1.Controls.Add(Me.check_prod_production)
        Me.GroupBox1.Controls.Add(Me.check_comp_production)
        Me.GroupBox1.Controls.Add(Me.checkJobOutput)
        Me.GroupBox1.Controls.Add(Me.checkLocationOutput)
        Me.GroupBox1.Controls.Add(Me.checkProdOutput)
        Me.GroupBox1.Controls.Add(Me.checkCompOutput)
        Me.GroupBox1.Controls.Add(Me.checkMostJob)
        Me.GroupBox1.Controls.Add(Me.checkMostProd)
        Me.GroupBox1.Controls.Add(Me.checkMostComp)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(181, 468)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'checkFootnoteprompt
        '
        Me.checkFootnoteprompt.AutoSize = True
        Me.checkFootnoteprompt.Location = New System.Drawing.Point(4, 410)
        Me.checkFootnoteprompt.Name = "checkFootnoteprompt"
        Me.checkFootnoteprompt.Size = New System.Drawing.Size(92, 17)
        Me.checkFootnoteprompt.TabIndex = 12
        Me.checkFootnoteprompt.Text = "Footer Prompt"
        Me.checkFootnoteprompt.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(26, 433)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(127, 26)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'check_totalComponents
        '
        Me.check_totalComponents.AutoSize = True
        Me.check_totalComponents.Location = New System.Drawing.Point(4, 311)
        Me.check_totalComponents.Name = "check_totalComponents"
        Me.check_totalComponents.Size = New System.Drawing.Size(142, 17)
        Me.check_totalComponents.TabIndex = 10
        Me.check_totalComponents.Text = "Total Components Made"
        Me.check_totalComponents.UseVisualStyleBackColor = True
        '
        'checkTotalProd
        '
        Me.checkTotalProd.AutoSize = True
        Me.checkTotalProd.Location = New System.Drawing.Point(3, 282)
        Me.checkTotalProd.Name = "checkTotalProd"
        Me.checkTotalProd.Size = New System.Drawing.Size(125, 17)
        Me.checkTotalProd.TabIndex = 9
        Me.checkTotalProd.Text = "Total Products Made"
        Me.checkTotalProd.UseVisualStyleBackColor = True
        '
        'check_prod_production
        '
        Me.check_prod_production.AutoSize = True
        Me.check_prod_production.Location = New System.Drawing.Point(3, 256)
        Me.check_prod_production.Name = "check_prod_production"
        Me.check_prod_production.Size = New System.Drawing.Size(158, 17)
        Me.check_prod_production.TabIndex = 8
        Me.check_prod_production.Text = "Production Report - Product"
        Me.check_prod_production.UseVisualStyleBackColor = True
        '
        'check_comp_production
        '
        Me.check_comp_production.AutoSize = True
        Me.check_comp_production.Location = New System.Drawing.Point(3, 226)
        Me.check_comp_production.Name = "check_comp_production"
        Me.check_comp_production.Size = New System.Drawing.Size(175, 17)
        Me.check_comp_production.TabIndex = 7
        Me.check_comp_production.Text = "Production Report - Component"
        Me.check_comp_production.UseVisualStyleBackColor = True
        '
        'checkJobOutput
        '
        Me.checkJobOutput.AutoSize = True
        Me.checkJobOutput.Location = New System.Drawing.Point(3, 199)
        Me.checkJobOutput.Name = "checkJobOutput"
        Me.checkJobOutput.Size = New System.Drawing.Size(62, 17)
        Me.checkJobOutput.TabIndex = 6
        Me.checkJobOutput.Text = "All Jobs"
        Me.checkJobOutput.UseVisualStyleBackColor = True
        '
        'checkLocationOutput
        '
        Me.checkLocationOutput.AutoSize = True
        Me.checkLocationOutput.Location = New System.Drawing.Point(3, 170)
        Me.checkLocationOutput.Name = "checkLocationOutput"
        Me.checkLocationOutput.Size = New System.Drawing.Size(86, 17)
        Me.checkLocationOutput.TabIndex = 5
        Me.checkLocationOutput.Text = "All Locations"
        Me.checkLocationOutput.UseVisualStyleBackColor = True
        '
        'checkProdOutput
        '
        Me.checkProdOutput.AutoSize = True
        Me.checkProdOutput.Location = New System.Drawing.Point(3, 138)
        Me.checkProdOutput.Name = "checkProdOutput"
        Me.checkProdOutput.Size = New System.Drawing.Size(82, 17)
        Me.checkProdOutput.TabIndex = 4
        Me.checkProdOutput.Text = "All Products"
        Me.checkProdOutput.UseVisualStyleBackColor = True
        '
        'checkCompOutput
        '
        Me.checkCompOutput.AutoSize = True
        Me.checkCompOutput.Location = New System.Drawing.Point(3, 107)
        Me.checkCompOutput.Name = "checkCompOutput"
        Me.checkCompOutput.Size = New System.Drawing.Size(99, 17)
        Me.checkCompOutput.TabIndex = 3
        Me.checkCompOutput.Text = "All Components"
        Me.checkCompOutput.UseVisualStyleBackColor = True
        '
        'checkMostJob
        '
        Me.checkMostJob.AutoSize = True
        Me.checkMostJob.Location = New System.Drawing.Point(3, 76)
        Me.checkMostJob.Name = "checkMostJob"
        Me.checkMostJob.Size = New System.Drawing.Size(113, 17)
        Me.checkMostJob.TabIndex = 2
        Me.checkMostJob.Text = "Most Common Job"
        Me.checkMostJob.UseVisualStyleBackColor = True
        '
        'checkMostProd
        '
        Me.checkMostProd.AutoSize = True
        Me.checkMostProd.Location = New System.Drawing.Point(3, 45)
        Me.checkMostProd.Name = "checkMostProd"
        Me.checkMostProd.Size = New System.Drawing.Size(133, 17)
        Me.checkMostProd.TabIndex = 1
        Me.checkMostProd.Text = "Most Common Product"
        Me.checkMostProd.UseVisualStyleBackColor = True
        '
        'checkMostComp
        '
        Me.checkMostComp.AutoSize = True
        Me.checkMostComp.Location = New System.Drawing.Point(3, 16)
        Me.checkMostComp.Name = "checkMostComp"
        Me.checkMostComp.Size = New System.Drawing.Size(150, 17)
        Me.checkMostComp.TabIndex = 0
        Me.checkMostComp.Text = "Most Common Component"
        Me.checkMostComp.UseVisualStyleBackColor = True
        '
        'saveFile
        '
        Me.saveFile.Title = "Select Save Location"
        '
        'checkJobProduct
        '
        Me.checkJobProduct.AutoSize = True
        Me.checkJobProduct.Location = New System.Drawing.Point(3, 339)
        Me.checkJobProduct.Name = "checkJobProduct"
        Me.checkJobProduct.Size = New System.Drawing.Size(149, 17)
        Me.checkJobProduct.TabIndex = 13
        Me.checkJobProduct.Text = "Job Product Relationships"
        Me.checkJobProduct.UseVisualStyleBackColor = True
        '
        'checkProductComponent
        '
        Me.checkProductComponent.AutoSize = True
        Me.checkProductComponent.Location = New System.Drawing.Point(3, 365)
        Me.checkProductComponent.Name = "checkProductComponent"
        Me.checkProductComponent.Size = New System.Drawing.Size(186, 17)
        Me.checkProductComponent.TabIndex = 14
        Me.checkProductComponent.Text = "Product Component Relationships"
        Me.checkProductComponent.UseVisualStyleBackColor = True
        '
        'checkCompLoca
        '
        Me.checkCompLoca.AutoSize = True
        Me.checkCompLoca.Location = New System.Drawing.Point(3, 389)
        Me.checkCompLoca.Name = "checkCompLoca"
        Me.checkCompLoca.Size = New System.Drawing.Size(190, 17)
        Me.checkCompLoca.TabIndex = 15
        Me.checkCompLoca.Text = "Component Location Relationships"
        Me.checkCompLoca.UseVisualStyleBackColor = True
        '
        'frmFrequencyReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 508)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFrequencyReports"
        Me.Text = "Frequency Reports"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents checkLocationOutput As CheckBox
    Friend WithEvents checkProdOutput As CheckBox
    Friend WithEvents checkCompOutput As CheckBox
    Friend WithEvents checkMostJob As CheckBox
    Friend WithEvents checkMostProd As CheckBox
    Friend WithEvents checkMostComp As CheckBox
    Friend WithEvents check_prod_production As CheckBox
    Friend WithEvents check_comp_production As CheckBox
    Friend WithEvents checkJobOutput As CheckBox
    Friend WithEvents preview As ListBox
    Friend WithEvents btnSave As Button
    Friend WithEvents check_totalComponents As CheckBox
    Friend WithEvents checkTotalProd As CheckBox
    Friend WithEvents saveFile As SaveFileDialog
    Friend WithEvents checkFootnoteprompt As CheckBox
    Friend WithEvents checkCompLoca As CheckBox
    Friend WithEvents checkProductComponent As CheckBox
    Friend WithEvents checkJobProduct As CheckBox
End Class
