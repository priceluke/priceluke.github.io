﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.checkMostComp = New System.Windows.Forms.CheckBox()
        Me.checkMostProd = New System.Windows.Forms.CheckBox()
        Me.checkCompOutput = New System.Windows.Forms.CheckBox()
        Me.checkMostJob = New System.Windows.Forms.CheckBox()
        Me.checkLocationOutput = New System.Windows.Forms.CheckBox()
        Me.checkProdOutput = New System.Windows.Forms.CheckBox()
        Me.checkJobOutput = New System.Windows.Forms.CheckBox()
        Me.check_comp_production = New System.Windows.Forms.CheckBox()
        Me.check_prod_production = New System.Windows.Forms.CheckBox()
        Me.checkTotalProd = New System.Windows.Forms.CheckBox()
        Me.check_totalComponents = New System.Windows.Forms.CheckBox()
        Me.preview = New System.Windows.Forms.ListBox()
        Me.btnSave = New System.Windows.Forms.Button()
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(573, 428)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 29)
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
        Me.Label2.Size = New System.Drawing.Size(380, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Preview"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Location = New System.Drawing.Point(3, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(181, 393)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
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
        'preview
        '
        Me.preview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.preview.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.preview.FormattingEnabled = True
        Me.preview.ItemHeight = 14
        Me.preview.Location = New System.Drawing.Point(190, 32)
        Me.preview.Name = "preview"
        Me.preview.Size = New System.Drawing.Size(380, 393)
        Me.preview.TabIndex = 11
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(26, 358)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(127, 26)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmFrequencyReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 428)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmFrequencyReports"
        Me.Text = "frmFrequencyReports"
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
End Class
