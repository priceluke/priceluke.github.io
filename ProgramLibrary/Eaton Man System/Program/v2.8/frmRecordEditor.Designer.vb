<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecordEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecordEditor))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.RecordTabs = New System.Windows.Forms.TabControl()
        Me.ProductTab = New System.Windows.Forms.TabPage()
        Me.lv_products = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.list_Products = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ProductName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ProductCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ProductComponentTab = New System.Windows.Forms.TabPage()
        Me.lv_ProductComponents = New System.Windows.Forms.ListView()
        Me.Product_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Comp_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ComponentsTab = New System.Windows.Forms.TabPage()
        Me.lv_components = New System.Windows.Forms.ListView()
        Me.Component_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Component_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Component_Code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LocationsTab = New System.Windows.Forms.TabPage()
        Me.lv_locations = New System.Windows.Forms.ListView()
        Me.Loc_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Location_Desc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ComponentLocationsTab = New System.Windows.Forms.TabPage()
        Me.lv_CompLocation = New System.Windows.Forms.ListView()
        Me.Compon_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Locat_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.JobsTab = New System.Windows.Forms.TabPage()
        Me.lv_jobs = New System.Windows.Forms.ListView()
        Me.Job_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.JobName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Job_Username = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DateCreated = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.JobPinned = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.JobCount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.txtJobPinned = New System.Windows.Forms.TextBox()
        Me.txtComponentDescription = New System.Windows.Forms.TextBox()
        Me.txtProductDesc = New System.Windows.Forms.TextBox()
        Me.txtLocationDescription = New System.Windows.Forms.TextBox()
        Me.txtJobName = New System.Windows.Forms.TextBox()
        Me.txtComponentCode = New System.Windows.Forms.TextBox()
        Me.txtProductCode = New System.Windows.Forms.TextBox()
        Me.txtLocationID = New System.Windows.Forms.TextBox()
        Me.txtJobID = New System.Windows.Forms.TextBox()
        Me.txtComponentID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.txtJobCount = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveSelectedRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComponentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JobToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductComponentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComponentLocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescriptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComponentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IDToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescriptionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CodeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IDToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescriptionToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.JobsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IDToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.RecordTabs.SuspendLayout()
        Me.ProductTab.SuspendLayout()
        Me.ProductComponentTab.SuspendLayout()
        Me.ComponentsTab.SuspendLayout()
        Me.LocationsTab.SuspendLayout()
        Me.ComponentLocationsTab.SuspendLayout()
        Me.JobsTab.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.RecordTabs, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1174, 402)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'RecordTabs
        '
        Me.RecordTabs.Controls.Add(Me.ProductTab)
        Me.RecordTabs.Controls.Add(Me.ProductComponentTab)
        Me.RecordTabs.Controls.Add(Me.ComponentsTab)
        Me.RecordTabs.Controls.Add(Me.LocationsTab)
        Me.RecordTabs.Controls.Add(Me.ComponentLocationsTab)
        Me.RecordTabs.Controls.Add(Me.JobsTab)
        Me.RecordTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RecordTabs.Location = New System.Drawing.Point(3, 205)
        Me.RecordTabs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RecordTabs.Name = "RecordTabs"
        Me.RecordTabs.SelectedIndex = 0
        Me.RecordTabs.Size = New System.Drawing.Size(1168, 193)
        Me.RecordTabs.TabIndex = 0
        '
        'ProductTab
        '
        Me.ProductTab.Controls.Add(Me.lv_products)
        Me.ProductTab.Controls.Add(Me.list_Products)
        Me.ProductTab.Location = New System.Drawing.Point(4, 23)
        Me.ProductTab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ProductTab.Name = "ProductTab"
        Me.ProductTab.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ProductTab.Size = New System.Drawing.Size(1160, 166)
        Me.ProductTab.TabIndex = 0
        Me.ProductTab.Text = "Products"
        Me.ProductTab.UseVisualStyleBackColor = True
        '
        'lv_products
        '
        Me.lv_products.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lv_products.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_products.FullRowSelect = True
        Me.lv_products.GridLines = True
        Me.lv_products.Location = New System.Drawing.Point(3, 4)
        Me.lv_products.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lv_products.Name = "lv_products"
        Me.lv_products.Size = New System.Drawing.Size(1154, 158)
        Me.lv_products.TabIndex = 9
        Me.lv_products.UseCompatibleStateImageBehavior = False
        Me.lv_products.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 33
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Product Name"
        Me.ColumnHeader2.Width = 204
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Product Code"
        Me.ColumnHeader3.Width = 207
        '
        'list_Products
        '
        Me.list_Products.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.ProductName, Me.ProductCode})
        Me.list_Products.Dock = System.Windows.Forms.DockStyle.Fill
        Me.list_Products.Location = New System.Drawing.Point(3, 4)
        Me.list_Products.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.list_Products.Name = "list_Products"
        Me.list_Products.Size = New System.Drawing.Size(1154, 158)
        Me.list_Products.TabIndex = 0
        Me.list_Products.UseCompatibleStateImageBehavior = False
        Me.list_Products.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 33
        '
        'ProductName
        '
        Me.ProductName.Text = "ProductName"
        Me.ProductName.Width = 33
        '
        'ProductCode
        '
        Me.ProductCode.Text = "Product Code"
        Me.ProductCode.Width = 33
        '
        'ProductComponentTab
        '
        Me.ProductComponentTab.Controls.Add(Me.lv_ProductComponents)
        Me.ProductComponentTab.Location = New System.Drawing.Point(4, 23)
        Me.ProductComponentTab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ProductComponentTab.Name = "ProductComponentTab"
        Me.ProductComponentTab.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ProductComponentTab.Size = New System.Drawing.Size(1160, 166)
        Me.ProductComponentTab.TabIndex = 1
        Me.ProductComponentTab.Text = "ProductComponents"
        Me.ProductComponentTab.UseVisualStyleBackColor = True
        '
        'lv_ProductComponents
        '
        Me.lv_ProductComponents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Product_ID, Me.Comp_ID, Me.Quantity})
        Me.lv_ProductComponents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_ProductComponents.FullRowSelect = True
        Me.lv_ProductComponents.GridLines = True
        Me.lv_ProductComponents.Location = New System.Drawing.Point(3, 4)
        Me.lv_ProductComponents.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lv_ProductComponents.Name = "lv_ProductComponents"
        Me.lv_ProductComponents.Size = New System.Drawing.Size(1154, 158)
        Me.lv_ProductComponents.TabIndex = 10
        Me.lv_ProductComponents.UseCompatibleStateImageBehavior = False
        Me.lv_ProductComponents.View = System.Windows.Forms.View.Details
        '
        'Product_ID
        '
        Me.Product_ID.Text = "Product ID"
        Me.Product_ID.Width = 87
        '
        'Comp_ID
        '
        Me.Comp_ID.Text = "Comp ID"
        Me.Comp_ID.Width = 161
        '
        'Quantity
        '
        Me.Quantity.Text = "Quantity"
        Me.Quantity.Width = 33
        '
        'ComponentsTab
        '
        Me.ComponentsTab.Controls.Add(Me.lv_components)
        Me.ComponentsTab.Location = New System.Drawing.Point(4, 23)
        Me.ComponentsTab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComponentsTab.Name = "ComponentsTab"
        Me.ComponentsTab.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComponentsTab.Size = New System.Drawing.Size(1160, 166)
        Me.ComponentsTab.TabIndex = 2
        Me.ComponentsTab.Text = "Components"
        Me.ComponentsTab.UseVisualStyleBackColor = True
        '
        'lv_components
        '
        Me.lv_components.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Component_ID, Me.Component_Name, Me.Component_Code})
        Me.lv_components.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_components.FullRowSelect = True
        Me.lv_components.GridLines = True
        Me.lv_components.Location = New System.Drawing.Point(3, 4)
        Me.lv_components.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lv_components.Name = "lv_components"
        Me.lv_components.Size = New System.Drawing.Size(1154, 158)
        Me.lv_components.TabIndex = 10
        Me.lv_components.UseCompatibleStateImageBehavior = False
        Me.lv_components.View = System.Windows.Forms.View.Details
        '
        'Component_ID
        '
        Me.Component_ID.Text = "ID"
        Me.Component_ID.Width = 33
        '
        'Component_Name
        '
        Me.Component_Name.Text = "Component Name"
        Me.Component_Name.Width = 121
        '
        'Component_Code
        '
        Me.Component_Code.Text = "Component_Code"
        Me.Component_Code.Width = 108
        '
        'LocationsTab
        '
        Me.LocationsTab.Controls.Add(Me.lv_locations)
        Me.LocationsTab.Location = New System.Drawing.Point(4, 23)
        Me.LocationsTab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LocationsTab.Name = "LocationsTab"
        Me.LocationsTab.Size = New System.Drawing.Size(1160, 166)
        Me.LocationsTab.TabIndex = 3
        Me.LocationsTab.Text = "Locations"
        Me.LocationsTab.UseVisualStyleBackColor = True
        '
        'lv_locations
        '
        Me.lv_locations.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Loc_ID, Me.Location_Desc})
        Me.lv_locations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_locations.FullRowSelect = True
        Me.lv_locations.GridLines = True
        Me.lv_locations.Location = New System.Drawing.Point(0, 0)
        Me.lv_locations.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lv_locations.Name = "lv_locations"
        Me.lv_locations.Size = New System.Drawing.Size(1160, 166)
        Me.lv_locations.TabIndex = 10
        Me.lv_locations.UseCompatibleStateImageBehavior = False
        Me.lv_locations.View = System.Windows.Forms.View.Details
        '
        'Loc_ID
        '
        Me.Loc_ID.Text = "ID"
        Me.Loc_ID.Width = 33
        '
        'Location_Desc
        '
        Me.Location_Desc.Text = "ProductName"
        Me.Location_Desc.Width = 33
        '
        'ComponentLocationsTab
        '
        Me.ComponentLocationsTab.Controls.Add(Me.lv_CompLocation)
        Me.ComponentLocationsTab.Location = New System.Drawing.Point(4, 23)
        Me.ComponentLocationsTab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComponentLocationsTab.Name = "ComponentLocationsTab"
        Me.ComponentLocationsTab.Size = New System.Drawing.Size(1160, 166)
        Me.ComponentLocationsTab.TabIndex = 4
        Me.ComponentLocationsTab.Text = "ComponentLocations"
        Me.ComponentLocationsTab.UseVisualStyleBackColor = True
        '
        'lv_CompLocation
        '
        Me.lv_CompLocation.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Compon_ID, Me.Locat_ID})
        Me.lv_CompLocation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_CompLocation.FullRowSelect = True
        Me.lv_CompLocation.GridLines = True
        Me.lv_CompLocation.Location = New System.Drawing.Point(0, 0)
        Me.lv_CompLocation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lv_CompLocation.Name = "lv_CompLocation"
        Me.lv_CompLocation.Size = New System.Drawing.Size(1160, 166)
        Me.lv_CompLocation.TabIndex = 10
        Me.lv_CompLocation.UseCompatibleStateImageBehavior = False
        Me.lv_CompLocation.View = System.Windows.Forms.View.Details
        '
        'Compon_ID
        '
        Me.Compon_ID.Text = "Component ID"
        Me.Compon_ID.Width = 33
        '
        'Locat_ID
        '
        Me.Locat_ID.Text = "Location ID"
        Me.Locat_ID.Width = 33
        '
        'JobsTab
        '
        Me.JobsTab.Controls.Add(Me.lv_jobs)
        Me.JobsTab.Location = New System.Drawing.Point(4, 23)
        Me.JobsTab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.JobsTab.Name = "JobsTab"
        Me.JobsTab.Size = New System.Drawing.Size(1160, 166)
        Me.JobsTab.TabIndex = 5
        Me.JobsTab.Text = "Jobs"
        Me.JobsTab.UseVisualStyleBackColor = True
        '
        'lv_jobs
        '
        Me.lv_jobs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Job_ID, Me.JobName, Me.Job_Username, Me.DateCreated, Me.JobPinned, Me.JobCount})
        Me.lv_jobs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_jobs.FullRowSelect = True
        Me.lv_jobs.GridLines = True
        Me.lv_jobs.Location = New System.Drawing.Point(0, 0)
        Me.lv_jobs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lv_jobs.Name = "lv_jobs"
        Me.lv_jobs.Size = New System.Drawing.Size(1160, 166)
        Me.lv_jobs.TabIndex = 10
        Me.lv_jobs.UseCompatibleStateImageBehavior = False
        Me.lv_jobs.View = System.Windows.Forms.View.Details
        '
        'Job_ID
        '
        Me.Job_ID.Text = "ID"
        Me.Job_ID.Width = 33
        '
        'JobName
        '
        Me.JobName.DisplayIndex = 3
        Me.JobName.Text = "Job Name"
        '
        'Job_Username
        '
        Me.Job_Username.DisplayIndex = 1
        Me.Job_Username.Text = "Username"
        Me.Job_Username.Width = 74
        '
        'DateCreated
        '
        Me.DateCreated.DisplayIndex = 2
        Me.DateCreated.Text = "Date Created"
        Me.DateCreated.Width = 87
        '
        'JobPinned
        '
        Me.JobPinned.Text = "Pinned"
        '
        'JobCount
        '
        Me.JobCount.Text = "Count"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 8
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnConfirm, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.txtJobPinned, 5, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtComponentDescription, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtProductDesc, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtLocationDescription, 7, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtJobName, 5, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtComponentCode, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtProductCode, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtLocationID, 7, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtJobID, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtComponentID, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 4, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 6, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 6, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 4, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.txtProductID, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtJobCount, 5, 3)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 4)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1168, 193)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'btnConfirm
        '
        Me.btnConfirm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnConfirm.Location = New System.Drawing.Point(3, 148)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(140, 41)
        Me.btnConfirm.TabIndex = 30
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'txtJobPinned
        '
        Me.txtJobPinned.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtJobPinned.Enabled = False
        Me.txtJobPinned.Location = New System.Drawing.Point(733, 100)
        Me.txtJobPinned.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtJobPinned.Name = "txtJobPinned"
        Me.txtJobPinned.Size = New System.Drawing.Size(140, 20)
        Me.txtJobPinned.TabIndex = 28
        '
        'txtComponentDescription
        '
        Me.txtComponentDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtComponentDescription.Enabled = False
        Me.txtComponentDescription.Location = New System.Drawing.Point(441, 100)
        Me.txtComponentDescription.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtComponentDescription.Name = "txtComponentDescription"
        Me.txtComponentDescription.Size = New System.Drawing.Size(140, 20)
        Me.txtComponentDescription.TabIndex = 27
        '
        'txtProductDesc
        '
        Me.txtProductDesc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtProductDesc.Enabled = False
        Me.txtProductDesc.Location = New System.Drawing.Point(149, 100)
        Me.txtProductDesc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtProductDesc.Name = "txtProductDesc"
        Me.txtProductDesc.Size = New System.Drawing.Size(140, 20)
        Me.txtProductDesc.TabIndex = 26
        '
        'txtLocationDescription
        '
        Me.txtLocationDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLocationDescription.Enabled = False
        Me.txtLocationDescription.Location = New System.Drawing.Point(1025, 52)
        Me.txtLocationDescription.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLocationDescription.Name = "txtLocationDescription"
        Me.txtLocationDescription.Size = New System.Drawing.Size(140, 20)
        Me.txtLocationDescription.TabIndex = 25
        '
        'txtJobName
        '
        Me.txtJobName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtJobName.Enabled = False
        Me.txtJobName.Location = New System.Drawing.Point(733, 52)
        Me.txtJobName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtJobName.Name = "txtJobName"
        Me.txtJobName.Size = New System.Drawing.Size(140, 20)
        Me.txtJobName.TabIndex = 24
        '
        'txtComponentCode
        '
        Me.txtComponentCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtComponentCode.Enabled = False
        Me.txtComponentCode.Location = New System.Drawing.Point(441, 52)
        Me.txtComponentCode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtComponentCode.Name = "txtComponentCode"
        Me.txtComponentCode.Size = New System.Drawing.Size(140, 20)
        Me.txtComponentCode.TabIndex = 23
        '
        'txtProductCode
        '
        Me.txtProductCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtProductCode.Enabled = False
        Me.txtProductCode.Location = New System.Drawing.Point(149, 52)
        Me.txtProductCode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.Size = New System.Drawing.Size(140, 20)
        Me.txtProductCode.TabIndex = 22
        '
        'txtLocationID
        '
        Me.txtLocationID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLocationID.Enabled = False
        Me.txtLocationID.Location = New System.Drawing.Point(1025, 4)
        Me.txtLocationID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLocationID.Name = "txtLocationID"
        Me.txtLocationID.Size = New System.Drawing.Size(140, 20)
        Me.txtLocationID.TabIndex = 21
        '
        'txtJobID
        '
        Me.txtJobID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtJobID.Enabled = False
        Me.txtJobID.Location = New System.Drawing.Point(733, 4)
        Me.txtJobID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtJobID.Name = "txtJobID"
        Me.txtJobID.Size = New System.Drawing.Size(140, 20)
        Me.txtJobID.TabIndex = 20
        '
        'txtComponentID
        '
        Me.txtComponentID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtComponentID.Enabled = False
        Me.txtComponentID.Location = New System.Drawing.Point(441, 4)
        Me.txtComponentID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtComponentID.Name = "txtComponentID"
        Me.txtComponentID.Size = New System.Drawing.Size(140, 20)
        Me.txtComponentID.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Product Code:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Product Description:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(295, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 28)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Component Description:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(295, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 14)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Component Code:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(295, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 14)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Component ID:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(587, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 14)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Job ID:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(587, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 14)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Job Pinned:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(587, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 14)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Job Name:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(879, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 14)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Location ID:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(879, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 28)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Location Description:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(587, 144)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 14)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Job Count:"
        '
        'txtProductID
        '
        Me.txtProductID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtProductID.Enabled = False
        Me.txtProductID.Location = New System.Drawing.Point(149, 4)
        Me.txtProductID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(140, 20)
        Me.txtProductID.TabIndex = 18
        '
        'txtJobCount
        '
        Me.txtJobCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtJobCount.Enabled = False
        Me.txtJobCount.Location = New System.Drawing.Point(733, 148)
        Me.txtJobCount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtJobCount.Name = "txtJobCount"
        Me.txtJobCount.Size = New System.Drawing.Size(140, 20)
        Me.txtJobCount.TabIndex = 29
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveToolStripMenuItem, Me.AddToolStripMenuItem, Me.SearchToolStripMenuItem, Me.UpdateToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1174, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveSelectedRecordToolStripMenuItem})
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(61, 18)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'RemoveSelectedRecordToolStripMenuItem
        '
        Me.RemoveSelectedRecordToolStripMenuItem.Name = "RemoveSelectedRecordToolStripMenuItem"
        Me.RemoveSelectedRecordToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.RemoveSelectedRecordToolStripMenuItem.Text = "Remove Selected Record"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductToolStripMenuItem, Me.ComponentToolStripMenuItem, Me.LocationToolStripMenuItem, Me.JobToolStripMenuItem, Me.ProductComponentToolStripMenuItem, Me.ComponentLocationToolStripMenuItem})
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(40, 18)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'ProductToolStripMenuItem
        '
        Me.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
        Me.ProductToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ProductToolStripMenuItem.Text = "Product"
        '
        'ComponentToolStripMenuItem
        '
        Me.ComponentToolStripMenuItem.Name = "ComponentToolStripMenuItem"
        Me.ComponentToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ComponentToolStripMenuItem.Text = "Component"
        '
        'LocationToolStripMenuItem
        '
        Me.LocationToolStripMenuItem.Name = "LocationToolStripMenuItem"
        Me.LocationToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.LocationToolStripMenuItem.Text = "Location"
        '
        'JobToolStripMenuItem
        '
        Me.JobToolStripMenuItem.Name = "JobToolStripMenuItem"
        Me.JobToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.JobToolStripMenuItem.Text = "Job"
        '
        'ProductComponentToolStripMenuItem
        '
        Me.ProductComponentToolStripMenuItem.Name = "ProductComponentToolStripMenuItem"
        Me.ProductComponentToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ProductComponentToolStripMenuItem.Text = "ProductComponent"
        '
        'ComponentLocationToolStripMenuItem
        '
        Me.ComponentLocationToolStripMenuItem.Name = "ComponentLocationToolStripMenuItem"
        Me.ComponentLocationToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ComponentLocationToolStripMenuItem.Text = "ComponentLocation"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductsToolStripMenuItem, Me.ComponentsToolStripMenuItem, Me.LocationsToolStripMenuItem, Me.JobsToolStripMenuItem})
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(61, 18)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IDToolStripMenuItem, Me.DescriptionToolStripMenuItem, Me.CodeToolStripMenuItem})
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ProductsToolStripMenuItem.Text = "Products"
        '
        'IDToolStripMenuItem
        '
        Me.IDToolStripMenuItem.Name = "IDToolStripMenuItem"
        Me.IDToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.IDToolStripMenuItem.Text = "ID"
        '
        'DescriptionToolStripMenuItem
        '
        Me.DescriptionToolStripMenuItem.Name = "DescriptionToolStripMenuItem"
        Me.DescriptionToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.DescriptionToolStripMenuItem.Text = "Description"
        '
        'CodeToolStripMenuItem
        '
        Me.CodeToolStripMenuItem.Name = "CodeToolStripMenuItem"
        Me.CodeToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CodeToolStripMenuItem.Text = "Code"
        '
        'ComponentsToolStripMenuItem
        '
        Me.ComponentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IDToolStripMenuItem1, Me.DescriptionToolStripMenuItem1, Me.CodeToolStripMenuItem1})
        Me.ComponentsToolStripMenuItem.Name = "ComponentsToolStripMenuItem"
        Me.ComponentsToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ComponentsToolStripMenuItem.Text = "Components"
        '
        'IDToolStripMenuItem1
        '
        Me.IDToolStripMenuItem1.Name = "IDToolStripMenuItem1"
        Me.IDToolStripMenuItem1.Size = New System.Drawing.Size(151, 22)
        Me.IDToolStripMenuItem1.Text = "ID"
        '
        'DescriptionToolStripMenuItem1
        '
        Me.DescriptionToolStripMenuItem1.Name = "DescriptionToolStripMenuItem1"
        Me.DescriptionToolStripMenuItem1.Size = New System.Drawing.Size(151, 22)
        Me.DescriptionToolStripMenuItem1.Text = "Description"
        '
        'CodeToolStripMenuItem1
        '
        Me.CodeToolStripMenuItem1.Name = "CodeToolStripMenuItem1"
        Me.CodeToolStripMenuItem1.Size = New System.Drawing.Size(151, 22)
        Me.CodeToolStripMenuItem1.Text = "Code"
        '
        'LocationsToolStripMenuItem
        '
        Me.LocationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IDToolStripMenuItem2, Me.DescriptionToolStripMenuItem2})
        Me.LocationsToolStripMenuItem.Name = "LocationsToolStripMenuItem"
        Me.LocationsToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.LocationsToolStripMenuItem.Text = "Locations"
        '
        'IDToolStripMenuItem2
        '
        Me.IDToolStripMenuItem2.Name = "IDToolStripMenuItem2"
        Me.IDToolStripMenuItem2.Size = New System.Drawing.Size(151, 22)
        Me.IDToolStripMenuItem2.Text = "ID"
        '
        'DescriptionToolStripMenuItem2
        '
        Me.DescriptionToolStripMenuItem2.Name = "DescriptionToolStripMenuItem2"
        Me.DescriptionToolStripMenuItem2.Size = New System.Drawing.Size(151, 22)
        Me.DescriptionToolStripMenuItem2.Text = "Description"
        '
        'JobsToolStripMenuItem
        '
        Me.JobsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IDToolStripMenuItem3, Me.NameToolStripMenuItem})
        Me.JobsToolStripMenuItem.Name = "JobsToolStripMenuItem"
        Me.JobsToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.JobsToolStripMenuItem.Text = "Jobs"
        '
        'IDToolStripMenuItem3
        '
        Me.IDToolStripMenuItem3.Name = "IDToolStripMenuItem3"
        Me.IDToolStripMenuItem3.Size = New System.Drawing.Size(102, 22)
        Me.IDToolStripMenuItem3.Text = "ID"
        '
        'NameToolStripMenuItem
        '
        Me.NameToolStripMenuItem.Name = "NameToolStripMenuItem"
        Me.NameToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.NameToolStripMenuItem.Text = "Name"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(61, 18)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'frmRecordEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1174, 426)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmRecordEditor"
        Me.Text = "Record Editor: View"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.RecordTabs.ResumeLayout(False)
        Me.ProductTab.ResumeLayout(False)
        Me.ProductComponentTab.ResumeLayout(False)
        Me.ComponentsTab.ResumeLayout(False)
        Me.LocationsTab.ResumeLayout(False)
        Me.ComponentLocationsTab.ResumeLayout(False)
        Me.JobsTab.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents RecordTabs As TabControl
    Friend WithEvents ProductTab As TabPage
    Friend WithEvents ProductComponentTab As TabPage
    Friend WithEvents ComponentsTab As TabPage
    Friend WithEvents LocationsTab As TabPage
    Friend WithEvents ComponentLocationsTab As TabPage
    Friend WithEvents JobsTab As TabPage
    Friend WithEvents lv_products As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents list_Products As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents ProductName As ColumnHeader
    Friend WithEvents ProductCode As ColumnHeader
    Friend WithEvents lv_ProductComponents As ListView
    Friend WithEvents Product_ID As ColumnHeader
    Friend WithEvents Comp_ID As ColumnHeader
    Friend WithEvents Quantity As ColumnHeader
    Friend WithEvents lv_components As ListView
    Friend WithEvents Component_ID As ColumnHeader
    Friend WithEvents Component_Name As ColumnHeader
    Friend WithEvents Component_Code As ColumnHeader
    Friend WithEvents lv_locations As ListView
    Friend WithEvents Loc_ID As ColumnHeader
    Friend WithEvents Location_Desc As ColumnHeader
    Friend WithEvents lv_CompLocation As ListView
    Friend WithEvents Compon_ID As ColumnHeader
    Friend WithEvents Locat_ID As ColumnHeader
    Friend WithEvents lv_jobs As ListView
    Friend WithEvents Job_ID As ColumnHeader
    Friend WithEvents Job_Username As ColumnHeader
    Friend WithEvents DateCreated As ColumnHeader
    Friend WithEvents JobName As ColumnHeader
    Friend WithEvents JobPinned As ColumnHeader
    Friend WithEvents JobCount As ColumnHeader
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnConfirm As Button
    Friend WithEvents txtJobPinned As TextBox
    Friend WithEvents txtComponentDescription As TextBox
    Friend WithEvents txtProductDesc As TextBox
    Friend WithEvents txtLocationDescription As TextBox
    Friend WithEvents txtJobName As TextBox
    Friend WithEvents txtComponentCode As TextBox
    Friend WithEvents txtProductCode As TextBox
    Friend WithEvents txtLocationID As TextBox
    Friend WithEvents txtJobID As TextBox
    Friend WithEvents txtComponentID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents txtJobCount As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveSelectedRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComponentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LocationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JobToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductComponentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComponentLocationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DescriptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComponentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IDToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DescriptionToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CodeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LocationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IDToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents DescriptionToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents JobsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IDToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents NameToolStripMenuItem As ToolStripMenuItem
End Class
