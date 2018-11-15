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
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtComponentID = New System.Windows.Forms.TextBox()
        Me.txtJobID = New System.Windows.Forms.TextBox()
        Me.txtLocationID = New System.Windows.Forms.TextBox()
        Me.txtProductCode = New System.Windows.Forms.TextBox()
        Me.txtComponentCode = New System.Windows.Forms.TextBox()
        Me.txtJobName = New System.Windows.Forms.TextBox()
        Me.txtLocationDescription = New System.Windows.Forms.TextBox()
        Me.txtProductDesc = New System.Windows.Forms.TextBox()
        Me.txtComponentDescription = New System.Windows.Forms.TextBox()
        Me.txtJobPinned = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtJobCount = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1006, 371)
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
        Me.RecordTabs.Location = New System.Drawing.Point(3, 188)
        Me.RecordTabs.Name = "RecordTabs"
        Me.RecordTabs.SelectedIndex = 0
        Me.RecordTabs.Size = New System.Drawing.Size(1000, 180)
        Me.RecordTabs.TabIndex = 0
        '
        'ProductTab
        '
        Me.ProductTab.Controls.Add(Me.lv_products)
        Me.ProductTab.Controls.Add(Me.list_Products)
        Me.ProductTab.Location = New System.Drawing.Point(4, 22)
        Me.ProductTab.Name = "ProductTab"
        Me.ProductTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ProductTab.Size = New System.Drawing.Size(992, 166)
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
        Me.lv_products.Location = New System.Drawing.Point(3, 3)
        Me.lv_products.Name = "lv_products"
        Me.lv_products.Size = New System.Drawing.Size(986, 160)
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
        Me.ColumnHeader2.Text = "ProductName"
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
        Me.list_Products.Location = New System.Drawing.Point(3, 3)
        Me.list_Products.Name = "list_Products"
        Me.list_Products.Size = New System.Drawing.Size(986, 160)
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
        Me.ProductComponentTab.Location = New System.Drawing.Point(4, 22)
        Me.ProductComponentTab.Name = "ProductComponentTab"
        Me.ProductComponentTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ProductComponentTab.Size = New System.Drawing.Size(992, 154)
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
        Me.lv_ProductComponents.Location = New System.Drawing.Point(3, 3)
        Me.lv_ProductComponents.Name = "lv_ProductComponents"
        Me.lv_ProductComponents.Size = New System.Drawing.Size(986, 148)
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
        Me.ComponentsTab.Location = New System.Drawing.Point(4, 22)
        Me.ComponentsTab.Name = "ComponentsTab"
        Me.ComponentsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ComponentsTab.Size = New System.Drawing.Size(992, 166)
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
        Me.lv_components.Location = New System.Drawing.Point(3, 3)
        Me.lv_components.Name = "lv_components"
        Me.lv_components.Size = New System.Drawing.Size(986, 160)
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
        Me.LocationsTab.Location = New System.Drawing.Point(4, 22)
        Me.LocationsTab.Name = "LocationsTab"
        Me.LocationsTab.Size = New System.Drawing.Size(992, 166)
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
        Me.lv_locations.Name = "lv_locations"
        Me.lv_locations.Size = New System.Drawing.Size(992, 166)
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
        Me.ComponentLocationsTab.Location = New System.Drawing.Point(4, 22)
        Me.ComponentLocationsTab.Name = "ComponentLocationsTab"
        Me.ComponentLocationsTab.Size = New System.Drawing.Size(992, 166)
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
        Me.lv_CompLocation.Name = "lv_CompLocation"
        Me.lv_CompLocation.Size = New System.Drawing.Size(992, 166)
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
        Me.JobsTab.Location = New System.Drawing.Point(4, 22)
        Me.JobsTab.Name = "JobsTab"
        Me.JobsTab.Size = New System.Drawing.Size(992, 166)
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
        Me.lv_jobs.Name = "lv_jobs"
        Me.lv_jobs.Size = New System.Drawing.Size(992, 166)
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
        'txtProductID
        '
        Me.txtProductID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtProductID.Enabled = False
        Me.txtProductID.Location = New System.Drawing.Point(128, 3)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(119, 20)
        Me.txtProductID.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(503, 132)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Job Count:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(753, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Location Description:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(753, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Location ID:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(503, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Job Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(503, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Job Pinned:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(503, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Job ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(253, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Component ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(253, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Component Code:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(253, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 26)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Component Description:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Product Description:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Product Code:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product ID:"
        '
        'txtComponentID
        '
        Me.txtComponentID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtComponentID.Enabled = False
        Me.txtComponentID.Location = New System.Drawing.Point(378, 3)
        Me.txtComponentID.Name = "txtComponentID"
        Me.txtComponentID.Size = New System.Drawing.Size(119, 20)
        Me.txtComponentID.TabIndex = 19
        '
        'txtJobID
        '
        Me.txtJobID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtJobID.Enabled = False
        Me.txtJobID.Location = New System.Drawing.Point(628, 3)
        Me.txtJobID.Name = "txtJobID"
        Me.txtJobID.Size = New System.Drawing.Size(119, 20)
        Me.txtJobID.TabIndex = 20
        '
        'txtLocationID
        '
        Me.txtLocationID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLocationID.Enabled = False
        Me.txtLocationID.Location = New System.Drawing.Point(878, 3)
        Me.txtLocationID.Name = "txtLocationID"
        Me.txtLocationID.Size = New System.Drawing.Size(119, 20)
        Me.txtLocationID.TabIndex = 21
        '
        'txtProductCode
        '
        Me.txtProductCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtProductCode.Enabled = False
        Me.txtProductCode.Location = New System.Drawing.Point(128, 47)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.Size = New System.Drawing.Size(119, 20)
        Me.txtProductCode.TabIndex = 22
        '
        'txtComponentCode
        '
        Me.txtComponentCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtComponentCode.Enabled = False
        Me.txtComponentCode.Location = New System.Drawing.Point(378, 47)
        Me.txtComponentCode.Name = "txtComponentCode"
        Me.txtComponentCode.Size = New System.Drawing.Size(119, 20)
        Me.txtComponentCode.TabIndex = 23
        '
        'txtJobName
        '
        Me.txtJobName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtJobName.Enabled = False
        Me.txtJobName.Location = New System.Drawing.Point(628, 47)
        Me.txtJobName.Name = "txtJobName"
        Me.txtJobName.Size = New System.Drawing.Size(119, 20)
        Me.txtJobName.TabIndex = 24
        '
        'txtLocationDescription
        '
        Me.txtLocationDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLocationDescription.Enabled = False
        Me.txtLocationDescription.Location = New System.Drawing.Point(878, 47)
        Me.txtLocationDescription.Name = "txtLocationDescription"
        Me.txtLocationDescription.Size = New System.Drawing.Size(119, 20)
        Me.txtLocationDescription.TabIndex = 25
        '
        'txtProductDesc
        '
        Me.txtProductDesc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtProductDesc.Enabled = False
        Me.txtProductDesc.Location = New System.Drawing.Point(128, 91)
        Me.txtProductDesc.Name = "txtProductDesc"
        Me.txtProductDesc.Size = New System.Drawing.Size(119, 20)
        Me.txtProductDesc.TabIndex = 26
        '
        'txtComponentDescription
        '
        Me.txtComponentDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtComponentDescription.Enabled = False
        Me.txtComponentDescription.Location = New System.Drawing.Point(378, 91)
        Me.txtComponentDescription.Name = "txtComponentDescription"
        Me.txtComponentDescription.Size = New System.Drawing.Size(119, 20)
        Me.txtComponentDescription.TabIndex = 27
        '
        'txtJobPinned
        '
        Me.txtJobPinned.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtJobPinned.Enabled = False
        Me.txtJobPinned.Location = New System.Drawing.Point(628, 91)
        Me.txtJobPinned.Name = "txtJobPinned"
        Me.txtJobPinned.Size = New System.Drawing.Size(119, 20)
        Me.txtJobPinned.TabIndex = 28
        '
        'btnConfirm
        '
        Me.btnConfirm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnConfirm.Location = New System.Drawing.Point(3, 135)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(119, 41)
        Me.btnConfirm.TabIndex = 30
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
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
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1000, 179)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'txtJobCount
        '
        Me.txtJobCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtJobCount.Enabled = False
        Me.txtJobCount.Location = New System.Drawing.Point(628, 135)
        Me.txtJobCount.Name = "txtJobCount"
        Me.txtJobCount.Size = New System.Drawing.Size(119, 20)
        Me.txtJobCount.TabIndex = 29
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveToolStripMenuItem, Me.AddToolStripMenuItem, Me.SearchToolStripMenuItem, Me.UpdateToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1006, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'frmRecordEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 395)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
End Class
