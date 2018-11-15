<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionTrend
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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductionTrend))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.timeframe = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.display = New System.Windows.Forms.GroupBox()
        Me.trendItem = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.product = New System.Windows.Forms.RadioButton()
        Me.component = New System.Windows.Forms.RadioButton()
        Me.TrendChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.timeframe.SuspendLayout()
        Me.display.SuspendLayout()
        CType(Me.TrendChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TrendChart, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.35398!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.64602!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(764, 559)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.timeframe, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.display, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.05967!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(758, 107)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'timeframe
        '
        Me.timeframe.Controls.Add(Me.Label2)
        Me.timeframe.Controls.Add(Me.RadioButton6)
        Me.timeframe.Controls.Add(Me.RadioButton5)
        Me.timeframe.Controls.Add(Me.RadioButton4)
        Me.timeframe.Controls.Add(Me.RadioButton3)
        Me.timeframe.Controls.Add(Me.RadioButton2)
        Me.timeframe.Controls.Add(Me.RadioButton1)
        Me.timeframe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.timeframe.Location = New System.Drawing.Point(382, 3)
        Me.timeframe.Name = "timeframe"
        Me.timeframe.Size = New System.Drawing.Size(373, 101)
        Me.timeframe.TabIndex = 1
        Me.timeframe.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Production By:"
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(265, 71)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(47, 17)
        Me.RadioButton6.TabIndex = 10
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Year"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(140, 71)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(57, 17)
        Me.RadioButton5.TabIndex = 9
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Quater"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(22, 71)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(55, 17)
        Me.RadioButton4.TabIndex = 8
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Month"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(265, 39)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(54, 17)
        Me.RadioButton3.TabIndex = 7
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Week"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(140, 39)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(44, 17)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Day"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(22, 39)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Hour"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'display
        '
        Me.display.Controls.Add(Me.trendItem)
        Me.display.Controls.Add(Me.Label1)
        Me.display.Controls.Add(Me.product)
        Me.display.Controls.Add(Me.component)
        Me.display.Dock = System.Windows.Forms.DockStyle.Fill
        Me.display.Location = New System.Drawing.Point(3, 3)
        Me.display.Name = "display"
        Me.display.Size = New System.Drawing.Size(373, 101)
        Me.display.TabIndex = 0
        Me.display.TabStop = False
        '
        'trendItem
        '
        Me.trendItem.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.trendItem.FormattingEnabled = True
        Me.trendItem.Location = New System.Drawing.Point(3, 77)
        Me.trendItem.Name = "trendItem"
        Me.trendItem.Size = New System.Drawing.Size(367, 21)
        Me.trendItem.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select Item Type:"
        '
        'product
        '
        Me.product.AutoSize = True
        Me.product.Location = New System.Drawing.Point(248, 37)
        Me.product.Name = "product"
        Me.product.Size = New System.Drawing.Size(62, 17)
        Me.product.TabIndex = 1
        Me.product.TabStop = True
        Me.product.Text = "Product"
        Me.product.UseVisualStyleBackColor = True
        '
        'component
        '
        Me.component.AutoSize = True
        Me.component.Location = New System.Drawing.Point(25, 37)
        Me.component.Name = "component"
        Me.component.Size = New System.Drawing.Size(79, 17)
        Me.component.TabIndex = 0
        Me.component.TabStop = True
        Me.component.Text = "Component"
        Me.component.UseVisualStyleBackColor = True
        '
        'TrendChart
        '
        ChartArea3.Name = "ChartArea1"
        Me.TrendChart.ChartAreas.Add(ChartArea3)
        Me.TrendChart.Dock = System.Windows.Forms.DockStyle.Fill
        Legend3.Name = "Legend1"
        Legend3.Title = "Trend Report"
        Me.TrendChart.Legends.Add(Legend3)
        Me.TrendChart.Location = New System.Drawing.Point(3, 116)
        Me.TrendChart.Name = "TrendChart"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series3.Legend = "Legend1"
        Series3.Name = "Trend"
        Me.TrendChart.Series.Add(Series3)
        Me.TrendChart.Size = New System.Drawing.Size(758, 440)
        Me.TrendChart.TabIndex = 2
        Me.TrendChart.Text = "ProductionTrend"
        '
        'frmProductionTrend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 559)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProductionTrend"
        Me.Text = "Production Trends"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.timeframe.ResumeLayout(False)
        Me.timeframe.PerformLayout()
        Me.display.ResumeLayout(False)
        Me.display.PerformLayout()
        CType(Me.TrendChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents timeframe As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents display As GroupBox
    Friend WithEvents trendItem As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents product As RadioButton
    Friend WithEvents component As RadioButton
    Friend WithEvents TrendChart As DataVisualization.Charting.Chart
End Class
