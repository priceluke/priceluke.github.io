<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PredictionUI
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PredictionUI))
        Me.tmrCalculate = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLog = New System.Windows.Forms.Timer(Me.components)
        Me.PredictionWindowOutput = New System.Windows.Forms.ListBox()
        Me.LogList = New System.Windows.Forms.ListBox()
        Me.PredictionWindowCalculation = New System.Windows.Forms.RichTextBox()
        Me.CurrentStateWindow = New System.Windows.Forms.RichTextBox()
        Me.IFrameWebUI = New System.Windows.Forms.WebBrowser()
        Me.EnableLoggingCheckbox = New System.Windows.Forms.CheckBox()
        Me.ActOnCalculationCheckbox = New System.Windows.Forms.CheckBox()
        Me.PredictCheckbox = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tmrWebUIResize = New System.Windows.Forms.Timer(Me.components)
        Me.AnalyticsWindow = New System.Windows.Forms.RichTextBox()
        Me.timesetLog = New System.Windows.Forms.RichTextBox()
        Me.timeSetVal = New System.Windows.Forms.RichTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrCalculate
        '
        Me.tmrCalculate.Enabled = True
        Me.tmrCalculate.Interval = 6000
        '
        'tmrLog
        '
        Me.tmrLog.Enabled = True
        Me.tmrLog.Interval = 500
        '
        'PredictionWindowOutput
        '
        Me.PredictionWindowOutput.BackColor = System.Drawing.Color.Black
        Me.PredictionWindowOutput.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PredictionWindowOutput.ForeColor = System.Drawing.Color.Lime
        Me.PredictionWindowOutput.FormattingEnabled = True
        Me.PredictionWindowOutput.ItemHeight = 15
        Me.PredictionWindowOutput.Items.AddRange(New Object() {"Prediction Window"})
        Me.PredictionWindowOutput.Location = New System.Drawing.Point(3, 6)
        Me.PredictionWindowOutput.Name = "PredictionWindowOutput"
        Me.PredictionWindowOutput.Size = New System.Drawing.Size(476, 94)
        Me.PredictionWindowOutput.TabIndex = 7
        '
        'LogList
        '
        Me.LogList.BackColor = System.Drawing.Color.Black
        Me.LogList.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogList.ForeColor = System.Drawing.Color.Lime
        Me.LogList.FormattingEnabled = True
        Me.LogList.ItemHeight = 15
        Me.LogList.Location = New System.Drawing.Point(3, 117)
        Me.LogList.Name = "LogList"
        Me.LogList.Size = New System.Drawing.Size(476, 319)
        Me.LogList.TabIndex = 8
        '
        'PredictionWindowCalculation
        '
        Me.PredictionWindowCalculation.BackColor = System.Drawing.Color.Black
        Me.PredictionWindowCalculation.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PredictionWindowCalculation.ForeColor = System.Drawing.Color.Lime
        Me.PredictionWindowCalculation.Location = New System.Drawing.Point(496, 117)
        Me.PredictionWindowCalculation.Name = "PredictionWindowCalculation"
        Me.PredictionWindowCalculation.Size = New System.Drawing.Size(465, 319)
        Me.PredictionWindowCalculation.TabIndex = 10
        Me.PredictionWindowCalculation.Text = "Verbose Prediction Calculation"
        '
        'CurrentStateWindow
        '
        Me.CurrentStateWindow.BackColor = System.Drawing.Color.Black
        Me.CurrentStateWindow.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentStateWindow.ForeColor = System.Drawing.Color.Lime
        Me.CurrentStateWindow.Location = New System.Drawing.Point(3, 450)
        Me.CurrentStateWindow.Name = "CurrentStateWindow"
        Me.CurrentStateWindow.Size = New System.Drawing.Size(476, 135)
        Me.CurrentStateWindow.TabIndex = 12
        Me.CurrentStateWindow.Text = ""
        '
        'IFrameWebUI
        '
        Me.IFrameWebUI.Location = New System.Drawing.Point(496, 450)
        Me.IFrameWebUI.MinimumSize = New System.Drawing.Size(23, 23)
        Me.IFrameWebUI.Name = "IFrameWebUI"
        Me.IFrameWebUI.ScrollBarsEnabled = False
        Me.IFrameWebUI.Size = New System.Drawing.Size(465, 135)
        Me.IFrameWebUI.TabIndex = 11
        Me.IFrameWebUI.Url = New System.Uri("http://82.21.53.213/homeautomation", System.UriKind.Absolute)
        '
        'EnableLoggingCheckbox
        '
        Me.EnableLoggingCheckbox.AutoSize = True
        Me.EnableLoggingCheckbox.Checked = True
        Me.EnableLoggingCheckbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EnableLoggingCheckbox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnableLoggingCheckbox.ForeColor = System.Drawing.Color.Lime
        Me.EnableLoggingCheckbox.Location = New System.Drawing.Point(505, 16)
        Me.EnableLoggingCheckbox.Name = "EnableLoggingCheckbox"
        Me.EnableLoggingCheckbox.Size = New System.Drawing.Size(147, 20)
        Me.EnableLoggingCheckbox.TabIndex = 13
        Me.EnableLoggingCheckbox.Text = "Enable Logging?"
        Me.EnableLoggingCheckbox.UseVisualStyleBackColor = True
        '
        'ActOnCalculationCheckbox
        '
        Me.ActOnCalculationCheckbox.AutoSize = True
        Me.ActOnCalculationCheckbox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActOnCalculationCheckbox.ForeColor = System.Drawing.Color.Lime
        Me.ActOnCalculationCheckbox.Location = New System.Drawing.Point(505, 68)
        Me.ActOnCalculationCheckbox.Name = "ActOnCalculationCheckbox"
        Me.ActOnCalculationCheckbox.Size = New System.Drawing.Size(166, 19)
        Me.ActOnCalculationCheckbox.TabIndex = 14
        Me.ActOnCalculationCheckbox.Text = "Act on calculations?"
        Me.ActOnCalculationCheckbox.UseVisualStyleBackColor = True
        '
        'PredictCheckbox
        '
        Me.PredictCheckbox.AutoSize = True
        Me.PredictCheckbox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PredictCheckbox.ForeColor = System.Drawing.Color.Lime
        Me.PredictCheckbox.Location = New System.Drawing.Point(505, 42)
        Me.PredictCheckbox.Name = "PredictCheckbox"
        Me.PredictCheckbox.Size = New System.Drawing.Size(83, 20)
        Me.PredictCheckbox.TabIndex = 15
        Me.PredictCheckbox.Text = "Predict"
        Me.PredictCheckbox.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(496, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(465, 94)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'tmrWebUIResize
        '
        Me.tmrWebUIResize.Enabled = True
        Me.tmrWebUIResize.Interval = 1000
        '
        'AnalyticsWindow
        '
        Me.AnalyticsWindow.BackColor = System.Drawing.Color.Black
        Me.AnalyticsWindow.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalyticsWindow.ForeColor = System.Drawing.Color.Lime
        Me.AnalyticsWindow.Location = New System.Drawing.Point(704, 6)
        Me.AnalyticsWindow.Name = "AnalyticsWindow"
        Me.AnalyticsWindow.Size = New System.Drawing.Size(257, 94)
        Me.AnalyticsWindow.TabIndex = 17
        Me.AnalyticsWindow.Text = "Analytics:"
        '
        'timesetLog
        '
        Me.timesetLog.BackColor = System.Drawing.Color.Black
        Me.timesetLog.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timesetLog.ForeColor = System.Drawing.Color.Lime
        Me.timesetLog.Location = New System.Drawing.Point(977, 6)
        Me.timesetLog.Name = "timesetLog"
        Me.timesetLog.Size = New System.Drawing.Size(268, 430)
        Me.timesetLog.TabIndex = 18
        Me.timesetLog.Text = ""
        '
        'timeSetVal
        '
        Me.timeSetVal.BackColor = System.Drawing.Color.Black
        Me.timeSetVal.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeSetVal.ForeColor = System.Drawing.Color.Lime
        Me.timeSetVal.Location = New System.Drawing.Point(977, 450)
        Me.timeSetVal.Name = "timeSetVal"
        Me.timeSetVal.Size = New System.Drawing.Size(268, 135)
        Me.timeSetVal.TabIndex = 19
        Me.timeSetVal.Text = ""
        '
        'PredictionUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1252, 588)
        Me.Controls.Add(Me.timeSetVal)
        Me.Controls.Add(Me.timesetLog)
        Me.Controls.Add(Me.AnalyticsWindow)
        Me.Controls.Add(Me.EnableLoggingCheckbox)
        Me.Controls.Add(Me.ActOnCalculationCheckbox)
        Me.Controls.Add(Me.PredictCheckbox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PredictionWindowOutput)
        Me.Controls.Add(Me.LogList)
        Me.Controls.Add(Me.PredictionWindowCalculation)
        Me.Controls.Add(Me.CurrentStateWindow)
        Me.Controls.Add(Me.IFrameWebUI)
        Me.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PredictionUI"
        Me.Text = "Home Automation - Complex Prediction Model"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrCalculate As Timer
    Friend WithEvents tmrLog As Timer
    Friend WithEvents PredictionWindowOutput As ListBox
    Friend WithEvents LogList As ListBox
    Friend WithEvents PredictionWindowCalculation As RichTextBox
    Friend WithEvents CurrentStateWindow As RichTextBox
    Friend WithEvents IFrameWebUI As WebBrowser
    Friend WithEvents EnableLoggingCheckbox As CheckBox
    Friend WithEvents ActOnCalculationCheckbox As CheckBox
    Friend WithEvents PredictCheckbox As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tmrWebUIResize As Timer
    Friend WithEvents AnalyticsWindow As RichTextBox
    Friend WithEvents timesetLog As RichTextBox
    Friend WithEvents timeSetVal As RichTextBox
End Class
