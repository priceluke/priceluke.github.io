Imports System.IO

Public Class frmRecordEditor
    Public current_structure As String = "Products"
    Private Sub frmRecordEditor_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        resize_listboxes()
    End Sub
    Sub revokeaccess()
        txtProductID.Enabled = False
        txtProductDesc.Enabled = False
        txtProductCode.Enabled = False
        txtComponentID.Enabled = False
        txtComponentDescription.Enabled = False
        txtComponentCode.Enabled = False
        txtLocationID.Enabled = False
        txtLocationDescription.Enabled = False
        txtJobName.Enabled = False
        txtJobPinned.Enabled = False
        txtJobID.Enabled = False
        txtJobCount.Enabled = False
    End Sub
    Sub cleartextboxes()
        txtProductID.Text = String.Empty
        txtProductDesc.Text = String.Empty
        txtProductCode.Text = String.Empty
        txtComponentID.Text = String.Empty
        txtComponentDescription.Text = String.Empty
        txtComponentCode.Text = String.Empty
        txtLocationID.Text = String.Empty
        txtLocationDescription.Text = String.Empty
        txtJobName.Text = String.Empty
        txtJobPinned.Text = String.Empty
        txtJobID.Text = String.Empty
        txtJobCount.Text = String.Empty
    End Sub
    Private Sub frmRecordEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        format_buttons()
        resize_listboxes()
        populate_all()
        If user_config.display_help_recordeditor = True Then
            Dim result As MessageBoxButtons = MsgBox("The current user settings are set to display the help menu, would you like to see the help menu in future?", MsgBoxStyle.YesNo)
            If result = MsgBoxResult.No Then
                user_config.display_help_recordeditor = False
                File.Delete("UserSettings.dat")
                FileOpen(1, "UserSettings.dat", OpenMode.Random, , , Len(current_settings))
                current_settings.display_help_recordeditor = user_config.display_help_recordeditor
                current_settings.first_time = user_config.first_time
                FilePut(1, current_settings, 1)
                FileClose(1)
            End If
            frmHelp.Show()
        End If
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
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''
        btnConfirm.Cursor = Cursors.Hand
        btnConfirm.FlatStyle = FlatStyle.Flat
        With btnConfirm.FlatAppearance
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

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Dim result As MessageBoxButtons = MsgBox("Update Notice: When updating records please be aware that all linked table relationships will remain in tact." & vbNewLine & vbNewLine & " You are currently set to update " & current_structure & vbNewLine & vbNewLine & "Would you like to continue?", MsgBoxStyle.YesNo)
        If result = MsgBoxResult.Yes Then
            revokeaccess()
            allowaccess(current_structure)
        End If
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        cleartextboxes()
    End Sub
    Sub selection_error()
        MsgBox("Please select a " & current_structure & " to update.")

    End Sub
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Select Case current_structure
            Case "Products"
                If txtProductID.Text <> String.Empty Then
                    Dim product_before As product = getProductRecord(txtProductID.Text)
                    Dim result As MessageBoxButtons = MsgBox("The Record before update:" & vbNewLine & vbNewLine & " ID: " & product_before.product_id & vbNewLine & " Name: " & product_before.product_desc & vbNewLine & " Code: " & product_before.product_code & vbNewLine & vbNewLine & "It will be replaced with: " & vbNewLine & " ID: " & txtProductID.Text & vbNewLine & " Name: " & txtProductDesc.Text & vbNewLine & " Code: " & txtProductCode.Text & vbNewLine & vbNewLine & "Is this correct?", MsgBoxStyle.YesNo)
                    If result = MsgBoxResult.Yes Then
                        MsgBox(lv_products.SelectedIndices().ToString)
                    Else
                        MsgBox("Update Aborted.")
                    End If
                Else
                    selection_error()
                End If
            Case "Components"
                If txtComponentID.Text <> String.Empty Then

                End If
            Case "ComponentLocations"
                If txtComponentID.Text <> String.Empty And txtLocationID.Text <> String.Empty Then

                End If
            Case "Locations"
                If txtLocationID.Text <> String.Empty Then

                End If
            Case "ProductComponents"
                If txtComponentID.Text <> String.Empty And txtProductID.Text <> String.Empty Then

                End If
            Case "Jobs"
                If txtJobID.Text <> String.Empty Then

                End If
        End Select
    End Sub
End Class

