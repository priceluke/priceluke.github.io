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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductionTrend))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.timeframe = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.year = New System.Windows.Forms.RadioButton()
        Me.quater = New System.Windows.Forms.RadioButton()
        Me.month = New System.Windows.Forms.RadioButton()
        Me.week = New System.Windows.Forms.RadioButton()
        Me.day = New System.Windows.Forms.RadioButton()
        Me.hour = New System.Windows.Forms.RadioButton()
        Me.display = New System.Windows.Forms.GroupBox()
        Me.trendItem = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.product = New System.Windows.Forms.RadioButton()
        Me.component = New System.Windows.Forms.RadioButton()
        Me.TrendChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.trendcordinate = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
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
        Me.TableLayoutPanel1.Controls.Add(Me.trendcordinate, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.35398!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.64602!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(764, 604)
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
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(758, 112)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'timeframe
        '
        Me.timeframe.Controls.Add(Me.Label2)
        Me.timeframe.Controls.Add(Me.year)
        Me.timeframe.Controls.Add(Me.quater)
        Me.timeframe.Controls.Add(Me.month)
        Me.timeframe.Controls.Add(Me.week)
        Me.timeframe.Controls.Add(Me.day)
        Me.timeframe.Controls.Add(Me.hour)
        Me.timeframe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.timeframe.Location = New System.Drawing.Point(382, 3)
        Me.timeframe.Name = "timeframe"
        Me.timeframe.Size = New System.Drawing.Size(373, 106)
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
        'year
        '
        Me.year.AutoSize = True
        Me.year.Checked = True
        Me.year.Location = New System.Drawing.Point(265, 71)
        Me.year.Name = "year"
        Me.year.Size = New System.Drawing.Size(47, 17)
        Me.year.TabIndex = 10
        Me.year.TabStop = True
        Me.year.Text = "Year"
        Me.year.UseVisualStyleBackColor = True
        '
        'quater
        '
        Me.quater.AutoSize = True
        Me.quater.Location = New System.Drawing.Point(140, 71)
        Me.quater.Name = "quater"
        Me.quater.Size = New System.Drawing.Size(57, 17)
        Me.quater.TabIndex = 9
        Me.quater.Text = "Quater"
        Me.quater.UseVisualStyleBackColor = True
        '
        'month
        '
        Me.month.AutoSize = True
        Me.month.Location = New System.Drawing.Point(22, 71)
        Me.month.Name = "month"
        Me.month.Size = New System.Drawing.Size(55, 17)
        Me.month.TabIndex = 8
        Me.month.Text = "Month"
        Me.month.UseVisualStyleBackColor = True
        '
        'week
        '
        Me.week.AutoSize = True
        Me.week.Location = New System.Drawing.Point(265, 39)
        Me.week.Name = "week"
        Me.week.Size = New System.Drawing.Size(54, 17)
        Me.week.TabIndex = 7
        Me.week.Text = "Week"
        Me.week.UseVisualStyleBackColor = True
        '
        'day
        '
        Me.day.AutoSize = True
        Me.day.Location = New System.Drawing.Point(140, 39)
        Me.day.Name = "day"
        Me.day.Size = New System.Drawing.Size(44, 17)
        Me.day.TabIndex = 6
        Me.day.Text = "Day"
        Me.day.UseVisualStyleBackColor = True
        '
        'hour
        '
        Me.hour.AutoSize = True
        Me.hour.Cursor = System.Windows.Forms.Cursors.Default
        Me.hour.Location = New System.Drawing.Point(22, 39)
        Me.hour.Name = "hour"
        Me.hour.Size = New System.Drawing.Size(48, 17)
        Me.hour.TabIndex = 5
        Me.hour.Text = "Hour"
        Me.hour.UseVisualStyleBackColor = True
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
        Me.display.Size = New System.Drawing.Size(373, 106)
        Me.display.TabIndex = 0
        Me.display.TabStop = False
        '
        'trendItem
        '
        Me.trendItem.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.trendItem.FormattingEnabled = True
        Me.trendItem.Location = New System.Drawing.Point(3, 82)
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
        ChartArea1.Name = "ChartArea1"
        Me.TrendChart.ChartAreas.Add(ChartArea1)
        Me.TrendChart.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Legend1.Title = "Trend Report"
        Me.TrendChart.Legends.Add(Legend1)
        Me.TrendChart.Location = New System.Drawing.Point(3, 121)
        Me.TrendChart.Name = "TrendChart"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.Name = "Trend"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series2.Legend = "Legend1"
        Series2.Name = "TrendPoints"
        Me.TrendChart.Series.Add(Series1)
        Me.TrendChart.Series.Add(Series2)
        Me.TrendChart.Size = New System.Drawing.Size(758, 459)
        Me.TrendChart.TabIndex = 2
        Me.TrendChart.Text = "ProductionTrend"
        '
        'trendcordinate
        '
        Me.trendcordinate.AutoSize = True
        Me.trendcordinate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.trendcordinate.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trendcordinate.Location = New System.Drawing.Point(3, 583)
        Me.trendcordinate.Name = "trendcordinate"
        Me.trendcordinate.Size = New System.Drawing.Size(758, 21)
        Me.trendcordinate.TabIndex = 3
        Me.trendcordinate.Text = "Select a coordinate to see more:"
        '
        'ToolTip1
        '
        '
        'frmProductionTrend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 604)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProductionTrend"
        Me.Text = "Production Trends"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
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
    Friend WithEvents year As RadioButton
    Friend WithEvents quater As RadioButton
    Friend WithEvents month As RadioButton
    Friend WithEvents week As RadioButton
    Friend WithEvents day As RadioButton
    Friend WithEvents hour As RadioButton
    Friend WithEvents display As GroupBox
    Friend WithEvents trendItem As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents product As RadioButton
    Friend WithEvents component As RadioButton
    Friend WithEvents TrendChart As DataVisualization.Charting.Chart
    Friend WithEvents trendcordinate As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
