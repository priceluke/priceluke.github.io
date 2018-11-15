Public Class frmRecordEditor
    Public current_structure As String = "Products"
    Private Sub frmRecordEditor_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        resize_listboxes()
    End Sub

    Private Sub frmRecordEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        format_buttons()
        resize_listboxes()
        populate_all()
    End Sub

    Private Sub RecordTabs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RecordTabs.SelectedIndexChanged
        Select Case RecordTabs.SelectedTab.Text
            Case "Products"
                current_structure = "Products"
            Case "Components"
                current_structure = "Components"
            Case "ComponentLocations"
                current_structure = "ComponentLocations"
            Case "Locations"
                current_structure = "Locations"
            Case "ProductComponents"
                current_structure = "ProductComponents"
            Case "Jobs"
                current_structure = "Jobs"
        End Select
    End Sub

    Sub resizesub(ByVal listname As Object)
        For t = 0 To listname.Columns.Count - 1
            listname.Columns(t).Width = (listname.Width / listname.Columns.Count)
        Next
    End Sub
    Sub resize_listboxes()
        resizesub(lv_CompLocation)
        resizesub(lv_components)
        resizesub(lv_locations)
        resizesub(lv_ProductComponents)
        resizesub(lv_products)
        resizesub(lv_jobs)
    End Sub

    Private Sub lv_products_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_products.SelectedIndexChanged
        Dim search As Boolean = True
        Try
            Console.Write(lv_products.SelectedItems(0).Text)
        Catch ex As Exception
            search = False
        End Try
        If search Then
            Dim product_found As product = (getProductRecord(lv_products.SelectedItems(0).Text))
            txtProductID.Text = product_found.product_id
            txtProductDesc.Text = product_found.product_desc
            txtProductCode.Text = product_found.product_code
        End If
    End Sub

    Private Sub lv_components_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_components.SelectedIndexChanged
        Dim search As Boolean = True
        Try
            Console.Write(lv_components.SelectedItems(0).Text)
        Catch ex As Exception
            search = False
        End Try
        If search Then
            Dim component_found As component = (getComponentRecord(lv_components.SelectedItems(0).Text))
            txtComponentID.Text = component_found.component_id
            txtComponentDescription.Text = component_found.component_desc
            txtComponentCode.Text = component_found.component_code
        End If
    End Sub

    Private Sub lv_locations_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_locations.SelectedIndexChanged
        Dim search As Boolean = True
        Try
            Console.Write(lv_locations.SelectedItems(0).Text)
        Catch ex As Exception
            search = False
        End Try
        If search Then
            Dim location_found As location = (getLocationRecord(lv_locations.SelectedItems(0).Text))
            txtLocationID.Text = location_found.location_id
            txtLocationDescription.Text = location_found.location_desc
        End If
    End Sub
    Sub format_buttons()
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''
        btn_update.Cursor = Cursors.Hand
        btn_update.FlatStyle = FlatStyle.Flat
        With btn_update.FlatAppearance
            .BorderColor = Color.Red
            .BorderSize = 0
            .MouseDownBackColor = Color.LightSkyBlue
            .MouseOverBackColor = Color.LightGray
        End With
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        With Button1.FlatAppearance
            .BorderColor = Color.Red
            .BorderSize = 0
            .MouseDownBackColor = Color.LightSkyBlue
            .MouseOverBackColor = Color.LightGray
        End With
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Button2.Cursor = Cursors.Hand
        Button2.FlatStyle = FlatStyle.Flat
        With Button2.FlatAppearance
            .BorderColor = Color.Red
            .BorderSize = 0
            .MouseDownBackColor = Color.LightSkyBlue
            .MouseOverBackColor = Color.LightGray
        End With
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Button3.Cursor = Cursors.Hand
        Button3.FlatStyle = FlatStyle.Flat
        With Button3.FlatAppearance
            .BorderColor = Color.Red
            .BorderSize = 0
            .MouseDownBackColor = Color.LightSkyBlue
            .MouseOverBackColor = Color.LightGray
        End With
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''
    End Sub
    Private Sub lv_jobs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_jobs.SelectedIndexChanged
        Dim search As Boolean = True
        Try
            Console.Write(lv_jobs.SelectedItems(0).Text)
        Catch ex As Exception
            search = False
        End Try
        If search Then
            Dim job_found As job = (getJobRecord(lv_jobs.SelectedItems(0).Text))
            txtJobID.Text = job_found.job_id
            txtJobName.Text = job_found.job_name
            txtJobPinned.Text = job_found.job_pinned
            txtJobCount.Text = job_found.job_count
        End If
    End Sub

    Private Sub lv_ProductComponents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_ProductComponents.SelectedIndexChanged
        Dim search As Boolean = True
        Try
            Console.Write(lv_ProductComponents.SelectedItems(0).Text)
        Catch ex As Exception
            search = False
        End Try
        If search Then
            Dim product_component_found As product_component = getProductComponentRecord((lv_ProductComponents.SelectedItems(0).Text.TrimEnd(" ")), lv_ProductComponents.SelectedItems(0).SubItems(1).Text.TrimEnd(" "))
            Dim product_found As product = getProductRecord(product_component_found.product_id)
            Dim component_found As component = getComponentRecord(product_component_found.component_id)
            txtProductID.Text = product_found.product_id
            txtProductDesc.Text = product_found.product_desc
            txtProductCode.Text = product_found.product_code
            txtComponentID.Text = component_found.component_id
            txtComponentDescription.Text = component_found.component_desc
            txtComponentCode.Text = component_found.component_code
        End If
    End Sub

    Private Sub lv_CompLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_CompLocation.SelectedIndexChanged
        Dim search As Boolean = True
        Try
            Console.Write(lv_CompLocation.SelectedItems(0).Text)
        Catch ex As Exception
            search = False
        End Try
        If search Then
            Dim component_location_found As component_location = getComponentLocationRecord((lv_CompLocation.SelectedItems(0).Text.TrimEnd(" ")), lv_CompLocation.SelectedItems(0).SubItems(1).Text.TrimEnd(" "))
            Dim location_found As location = getLocationRecord(component_location_found.location_id)
            Dim component_found As component = getComponentRecord(component_location_found.component_id)
            txtLocationID.Text = location_found.location_id
            txtLocationDescription.Text = location_found.location_desc
            txtComponentID.Text = component_found.component_id
            txtComponentDescription.Text = component_found.component_desc
            txtComponentCode.Text = component_found.component_code
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim list_test = lv_products.Items.Insert(2, "4")
        'list_test.SubItems.Add("noot")
        'list_test.SubItems.Add("notot")
        'MsgBox(getInsersionIndexProduct("Products.dat", 2))
    End Sub
End Class

