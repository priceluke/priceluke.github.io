Imports System.ComponentModel
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
        btnConfirm.Enabled = False
        Select Case RecordTabs.SelectedTab.Text
            Case "Products"
                current_structure = "Products"
                btnConfirm.Enabled = True
            Case "Components"
                current_structure = "Components"
                btnConfirm.Enabled = True
            Case "ComponentLocations"
                current_structure = "ComponentLocations"
            Case "Locations"
                current_structure = "Locations"
                btnConfirm.Enabled = True
            Case "ProductComponents"
                current_structure = "ProductComponents"
            Case "Jobs"
                current_structure = "Jobs"
        End Select
    End Sub

    Sub resizesub(ByVal listname As Object)
        For t = 0 To listname.Columns.Count - 1
            listname.Columns(t).Width = (listname.Width / listname.Columns.Count) - 7
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
            txtProductDesc.Text = product_found.product_desc.TrimEnd
            txtProductCode.Text = product_found.product_code.TrimEnd
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
            txtComponentDescription.Text = component_found.component_desc.TrimEnd
            txtComponentCode.Text = component_found.component_code.TrimEnd
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
            txtLocationDescription.Text = location_found.location_desc.TrimEnd
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
            txtJobName.Text = job_found.job_name.TrimEnd
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
            txtProductDesc.Text = product_found.product_desc.TrimEnd
            txtProductCode.Text = product_found.product_code.TrimEnd
            txtComponentID.Text = component_found.component_id
            txtComponentDescription.Text = component_found.component_desc.TrimEnd
            txtComponentCode.Text = component_found.component_code.TrimEnd
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
            txtLocationDescription.Text = location_found.location_desc.TrimEnd
            txtComponentID.Text = component_found.component_id
            txtComponentDescription.Text = component_found.component_desc.TrimEnd
            txtComponentCode.Text = component_found.component_code.TrimEnd
        End If
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        If current_structure <> "ComponentLocations" And current_structure <> "ProductComponents" Then
            Dim result As MessageBoxButtons = MsgBox("Update Notice: When updating records please be aware that all linked table relationships will remain in tact." & vbNewLine & vbNewLine & " You are currently set to update " & current_structure & vbNewLine & vbNewLine & "Would you like to continue?", MsgBoxStyle.YesNo)
            If result = MsgBoxResult.Yes Then
                revokeaccess()
                allowaccess(current_structure)
            End If
        Else
            MsgBox("To allow editing of " & current_structure & " would cause intermediate table relationships to break down. For the sake of data integrity please remove and add links rather than updating.")
            revokeaccess()
        End If

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
                    Dim product_new As product
                    Dim record_update_NEW As Integer = 0
                    Dim valid_input As Boolean = True
                    If result = MsgBoxResult.Yes Then
                        Try
                            If txtProductDesc.Text.Count > 45 And txtProductCode.Text.Count > 26 Then
                                MsgBox("Please Enter A Valid Input:" & vbNewLine & vbNewLine & "The description is limited to 45 charecters and the code is limited to 26.")
                            Else
                                record_update_NEW = CInt(lv_products.SelectedIndices(0).ToString) + 1
                                product_new.product_id = product_before.product_id
                                product_new.product_desc = txtProductDesc.Text
                                product_new.product_code = txtProductCode.Text
                                FileOpen(1, "Products.dat", OpenMode.Random, , , Len(product_record))
                                FilePut(1, product_new, record_update_NEW)
                                FileClose(1)
                                MsgBox("Update Successful.")

                            End If
                        Catch
                            MsgBox("Error Updating")
                        End Try
                    Else
                        MsgBox("Update Aborted.")
                    End If
                Else
                    selection_error()
                End If
            Case "Components"
                If txtComponentID.Text <> String.Empty Then
                    Dim component_before As component = getComponentRecord(txtComponentID.Text)
                    Dim result As MessageBoxButtons = MsgBox("The Record before update:" & vbNewLine & vbNewLine & " ID: " & component_before.component_id & vbNewLine & " Name: " & component_before.component_desc & vbNewLine & " Code: " & component_before.component_code & vbNewLine & vbNewLine & "It will be replaced with: " & vbNewLine & " ID: " & txtComponentID.Text & vbNewLine & " Name: " & txtComponentDescription.Text & vbNewLine & " Code: " & txtComponentCode.Text & vbNewLine & vbNewLine & "Is this correct?", MsgBoxStyle.YesNo)
                    Dim component_new As component
                    Dim record_update_NEW As Integer = 0
                    Dim valid_input As Boolean = True
                    If result = MsgBoxResult.Yes Then
                        Try
                            If txtComponentDescription.Text.Count > 45 And txtComponentCode.Text.Count > 26 Then
                                MsgBox("Please Enter A Valid Input:" & vbNewLine & vbNewLine & "The description is limited to 45 charecters and the code is limited to 26.")
                            Else
                                record_update_NEW = CInt(lv_components.SelectedIndices(0).ToString) + 1
                                component_new.component_id = component_before.component_id
                                component_new.component_desc = txtComponentDescription.Text
                                component_new.component_code = txtComponentCode.Text
                                FileOpen(1, "Components.dat", OpenMode.Random, , , Len(component_record))
                                FilePut(1, component_new, record_update_NEW)
                                FileClose(1)
                                MsgBox("Update Successful.")

                            End If
                        Catch
                            MsgBox("Error Updating")
                        End Try
                    Else
                        MsgBox("Update Aborted.")
                    End If
                Else
                    selection_error()
                End If
            Case "ComponentLocations"
                MsgBox("To allow editing of " & current_structure & " would cause intermediate table relationships to break down. For the sake of data integrity please remove and add links rather than updating.")
            Case "Locations"
                If txtLocationID.Text <> String.Empty Then
                    Dim location_before As location = getLocationRecord(txtLocationID.Text)
                    Dim result As MessageBoxButtons = MsgBox("The Record before update:" & vbNewLine & vbNewLine & " ID: " & location_before.location_id & vbNewLine & " Name: " & location_before.location_desc & vbNewLine & vbNewLine & vbNewLine & "It will be replaced with: " & vbNewLine & " ID: " & txtLocationID.Text & vbNewLine & " Name: " & txtLocationDescription.Text & vbNewLine & vbNewLine & "Is this correct?", MsgBoxStyle.YesNo)
                    Dim location_new As location
                    Dim record_update_NEW As Integer = 0
                    Dim valid_input As Boolean = True
                    If result = MsgBoxResult.Yes Then
                        Try
                            If txtLocationDescription.Text.Count > 26 Then
                                MsgBox("Please Enter A Valid Input:" & vbNewLine & vbNewLine & "The description is limited to 26 charecters.")
                            Else
                                record_update_NEW = CInt(lv_locations.SelectedIndices(0).ToString) + 1
                                location_new.location_id = location_before.location_id
                                location_new.location_desc = txtLocationDescription.Text
                                FileOpen(1, "Locations.dat", OpenMode.Random, , , Len(location_record))
                                FilePut(1, location_new, record_update_NEW)
                                FileClose(1)
                                MsgBox("Update Successful.")

                            End If
                        Catch
                            MsgBox("Error Updating")
                        End Try
                    Else
                        MsgBox("Update Aborted.")
                    End If
                Else
                    selection_error()
                End If
            Case "ProductComponents"
                MsgBox("To allow editing of " & current_structure & " would cause intermediate table relationships to break down. For the sake of data integrity please remove and add links rather than updating.")
            Case "Jobs"
                MsgBox("To allow editing of " & current_structure & " would cause intermediate table relationships to break down. For the sake of data integrity please remove and add links rather than updating.")
        End Select
        populate_all()
    End Sub

    Private Sub IDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IDToolStripMenuItem.Click
        Dim search_parameter = InputBox("Please enter an ID to search by:", "Search Product ID", "1")
        Try
            Dim returned_product As product = getProductRecord(search_parameter)
            txtProductID.Text = returned_product.product_id
            txtProductDesc.Text = returned_product.product_desc.TrimEnd
            txtProductCode.Text = returned_product.product_code.TrimEnd
        Catch
            MsgBox("A record containing the value '" & search_parameter & "' could not be found.")
        End Try
    End Sub

    Private Sub IDToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IDToolStripMenuItem1.Click
        Dim search_parameter = InputBox("Please enter an ID to search by:", "Search Component ID", "1")
        Try
            Dim returned_component As component = getComponentRecord(search_parameter)
            txtComponentID.Text = returned_component.component_id
            txtComponentDescription.Text = returned_component.component_desc.TrimEnd
            txtComponentCode.Text = returned_component.component_code.TrimEnd
        Catch
            MsgBox("A record containing the value '" & search_parameter & "' could not be found.")
        End Try
    End Sub

    Private Sub IDToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles IDToolStripMenuItem2.Click
        Dim search_parameter = InputBox("Please enter an ID to search by:", "Search Location ID", "1")
        Try
            Dim returned_location As location = getLocationRecord(search_parameter)
            txtLocationID.Text = returned_location.location_id
            txtLocationDescription.Text = returned_location.location_desc
        Catch
            MsgBox("A record containing the value '" & search_parameter & "' could not be found.")
        End Try
    End Sub

    Private Sub IDToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles IDToolStripMenuItem3.Click
        Dim search_parameter = InputBox("Please enter an ID to search by:", "Search Job ID", "1")
        Try
            Dim returned_job As job = getJobRecord(search_parameter)
            txtJobID.Text = returned_job.job_id
            txtJobName.Text = returned_job.job_name.TrimEnd
            txtJobPinned.Text = returned_job.job_pinned
            txtJobCount.Text = returned_job.job_count
        Catch
            MsgBox("A record containing the value '" & search_parameter & "' could not be found.")
        End Try
    End Sub

    Private Sub DescriptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescriptionToolStripMenuItem.Click
        FileOpen(1, "Products.dat", OpenMode.Random, , , Len(product_record))
        Dim search_param As String = InputBox("Please enter an description to search by:", "Search Product Description", "#VALUE")
        If LOF(1) / Len(product_record) = 0 Then
        Else
            For i = 1 To LOF(1) / Len(product_record)
                FileGet(1, product_record, i)
                If product_record.product_desc.TrimEnd(" ") = search_param Then
                    txtProductCode.Text = product_record.product_code.TrimEnd
                    txtProductID.Text = product_record.product_id
                    txtProductDesc.Text = product_record.product_desc.TrimEnd
                    FileClose(1)
                    Exit Sub
                End If
            Next i
        End If
        FileClose(1)
        MsgBox(search_param & " has not been found in any records.")
    End Sub

    Private Sub CodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CodeToolStripMenuItem.Click
        FileOpen(1, "Products.dat", OpenMode.Random, , , Len(product_record))
        Dim search_param As String = InputBox("Please enter an code to search by:", "Search Product Code", "#VALUE")
        If LOF(1) / Len(product_record) = 0 Then
        Else
            For i = 1 To LOF(1) / Len(product_record)
                FileGet(1, product_record, i)
                If product_record.product_code.TrimEnd(" ") = search_param Then
                    txtProductCode.Text = product_record.product_code.TrimEnd
                    txtProductID.Text = product_record.product_id
                    txtProductDesc.Text = product_record.product_desc.TrimEnd
                    FileClose(1)
                    Exit Sub
                End If
            Next i
        End If
        FileClose(1)
        MsgBox(search_param & " has not been found in any records.")
    End Sub

    Private Sub DescriptionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DescriptionToolStripMenuItem1.Click
        FileOpen(1, "Components.dat", OpenMode.Random, , , Len(component_record))
        Dim search_param As String = InputBox("Please enter an description to search by:", "Search Component Description", "#VALUE")
        If LOF(1) / Len(component_record) = 0 Then
        Else
            For i = 1 To LOF(1) / Len(component_record)
                FileGet(1, component_record, i)
                If component_record.component_desc.TrimEnd(" ") = search_param Then
                    txtComponentCode.Text = component_record.component_code.TrimEnd
                    txtComponentID.Text = component_record.component_id
                    txtComponentDescription.Text = component_record.component_desc.TrimEnd
                    FileClose(1)
                    Exit Sub
                End If
            Next i
        End If
        FileClose(1)
        MsgBox(search_param & " has not been found in any records.")
    End Sub

    Private Sub CodeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CodeToolStripMenuItem1.Click
        FileOpen(1, "Components.dat", OpenMode.Random, , , Len(component_record))
        Dim search_param As String = InputBox("Please enter an description to search by:", "Search Component Description", "#VALUE")
        If LOF(1) / Len(component_record) = 0 Then
        Else
            For i = 1 To LOF(1) / Len(component_record)
                FileGet(1, component_record, i)
                If component_record.component_code.TrimEnd(" ") = search_param Then
                    txtComponentCode.Text = component_record.component_code.TrimEnd
                    txtComponentID.Text = component_record.component_id
                    txtComponentDescription.Text = component_record.component_desc.TrimEnd
                    FileClose(1)
                    Exit Sub
                End If
            Next i
        End If
        FileClose(1)
        MsgBox(search_param & " has not been found in any records.")
    End Sub

    Private Sub DescriptionToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DescriptionToolStripMenuItem2.Click
        FileOpen(1, "Locations.dat", OpenMode.Random, , , Len(location_record))
        Dim search_param As String = InputBox("Please enter an description to search by:", "Search Location Description", "#VALUE")
        If LOF(1) / Len(location_record) = 0 Then
        Else
            For i = 1 To LOF(1) / Len(location_record)
                FileGet(1, location_record, i)
                If location_record.location_desc.TrimEnd(" ") = search_param Then
                    txtLocationDescription.Text = location_record.location_desc.TrimEnd
                    txtLocationID.Text = location_record.location_id
                    FileClose(1)
                    Exit Sub
                End If
            Next i
        End If
        FileClose(1)
        MsgBox(search_param & " has not been found in any records.")
    End Sub

    Private Sub NameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NameToolStripMenuItem.Click
        FileOpen(1, "Jobs.dat", OpenMode.Random, , , Len(job_record))
        Dim search_param As String = InputBox("Please enter an name to search by:", "Search Job Name", "#VALUE")
        If LOF(1) / Len(job_record) = 0 Then
        Else
            For i = 1 To LOF(1) / Len(job_record)
                FileGet(1, job_record, i)
                If job_record.job_name.TrimEnd(" ") = search_param Then
                    txtJobName.Text = job_record.job_name.TrimEnd
                    txtJobCount.Text = job_record.job_count
                    txtJobPinned.Text = job_record.job_pinned
                    txtJobID.Text = job_record.job_id
                    FileClose(1)
                    Exit Sub
                End If
            Next i
        End If
        FileClose(1)
        MsgBox(search_param & " has not been found in any records.")
    End Sub

    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductToolStripMenuItem.Click
        FileOpen(1, "Products.dat", OpenMode.Random, , , Len(product_record))
        Dim product_name_param As String = InputBox("Please Enter A Product Description:", "Product:", "#VALUE")
        Dim product_id_param As New Integer
        Dim product_code_param As String = InputBox("Please Enter A Product Code:", "Product:", "#VALUE")
        If product_code_param.Length <= 26 And product_name_param.Length <= 40 Then
            Try
                FileGet(1, product_record, LOF(1) / Len(product_record))
            Catch ex As Exception
                product_record.product_id = 0
            End Try
            product_id_param = product_record.product_id + 1
            Dim result As MessageBoxButtons = MsgBox("The New Record Will Have The Following Data: " & vbNewLine & vbNewLine & "ID: " & product_id_param & vbNewLine & "Name: " & product_name_param & vbNewLine & "Code: " & product_code_param & vbNewLine & vbNewLine & "Is this correct?", MsgBoxStyle.YesNo)
            If result = MsgBoxResult.Yes Then
                Dim new_product As New product
                new_product.product_id = product_id_param
                new_product.product_code = product_code_param
                new_product.product_desc = product_name_param
                Try
                    FilePut(1, new_product)
                    MsgBox("Record Added.")
                Catch ex As Exception
                    MsgBox("Record Update Failed.")
                End Try
            End If
        Else
            MsgBox("The Input Was Not Valid.")
        End If
        FileClose(1)
        populate_all()
    End Sub

    Private Sub ComponentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComponentToolStripMenuItem.Click
        FileOpen(1, "Components.dat", OpenMode.Random, , , Len(component_record))
        Dim component_name_param As String = InputBox("Please Enter A component Description:", "component:", "#VALUE")
        Dim component_id_param As New Integer
        Dim component_code_param As String = InputBox("Please Enter A component Code:", "component:", "#VALUE")
        If component_code_param.Length <= 26 And component_name_param.Length <= 40 Then
            Try
                FileGet(1, component_record, LOF(1) / Len(component_record))
            Catch ex As Exception
                component_record.component_id = 0
            End Try
            component_id_param = component_record.component_id + 1
            Dim result As MessageBoxButtons = MsgBox("The New Record Will Have The Following Data: " & vbNewLine & vbNewLine & "ID: " & component_id_param & vbNewLine & "Name: " & component_name_param & vbNewLine & "Code: " & component_code_param & vbNewLine & vbNewLine & "Is this correct?", MsgBoxStyle.YesNo)
            If result = MsgBoxResult.Yes Then
                Dim new_component As New component
                new_component.component_id = component_id_param
                new_component.component_code = component_code_param
                new_component.component_desc = component_name_param
                Try
                    FilePut(1, new_component)
                    MsgBox("Record Added.")
                Catch ex As Exception
                    MsgBox("Record Update Failed.")
                End Try
            End If
        Else
            MsgBox("The Input Was Not Valid.")
        End If
        FileClose(1)
        populate_all()
    End Sub

    Private Sub LocationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocationToolStripMenuItem.Click
        FileOpen(1, "Locations.dat", OpenMode.Random, , , Len(location_record))
        Dim location_name_param As String = InputBox("Please Enter A location Description:", "location:", "#VALUE")
        Dim location_id_param As New Integer
        If location_name_param.Length <= 26 Then
            Try
                FileGet(1, location_record, LOF(1) / Len(location_record))
            Catch ex As Exception
                location_record.location_id = 0
            End Try
            location_id_param = location_record.location_id + 1
            Dim result As MessageBoxButtons = MsgBox("The New Record Will Have The Following Data: " & vbNewLine & vbNewLine & "ID: " & location_id_param & vbNewLine & "Name: " & location_name_param & vbNewLine & vbNewLine & "Is this correct?", MsgBoxStyle.YesNo)
            If result = MsgBoxResult.Yes Then
                Dim new_location As New location
                new_location.location_id = location_id_param
                new_location.location_desc = location_name_param
                Try
                    FilePut(1, new_location)
                    MsgBox("Record Added.")
                Catch ex As Exception
                    MsgBox("Record Update Failed.")
                End Try
            End If
        Else
            MsgBox("The Input Was Not Valid.")
        End If
        FileClose(1)
        populate_all()
    End Sub

    Private Sub JobToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JobToolStripMenuItem.Click
        FileOpen(1, "jobs.dat", OpenMode.Random, , , Len(job_record))
        Dim job_name_param As String = InputBox("Please Enter A job Description:", "job:", "#VALUE")
        Dim job_pinned_param As String = InputBox("Is this job pinned? [True/False]:", "job:", "#VALUE")
        Dim job_count_param As String = InputBox("Please Enter Job Count:", "job:", "#VALUE")
        Dim job_id_param As New Integer
        If job_name_param.Length <= 26 And IsNumeric(job_count_param) Then
            If job_pinned_param = "True" Or job_pinned_param = "False" Then
                Try
                    FileGet(1, job_record, LOF(1) / Len(job_record))
                    job_id_param = job_record.job_id + 1
                Catch ex As Exception
                    job_id_param = 1
                End Try
                Dim result As MessageBoxButtons = MsgBox("The New Record Will Have The Following Data: " & vbNewLine & vbNewLine & "ID: " & job_id_param & vbNewLine & "Name: " & job_name_param & vbNewLine & "Pinned: " & job_pinned_param & vbNewLine & "Count: " & job_count_param & vbNewLine & vbNewLine & "Is this correct?", MsgBoxStyle.YesNo)
                If result = MsgBoxResult.Yes Then
                    Dim new_job As New job
                    new_job.job_id = job_id_param
                    new_job.job_name = job_name_param
                    new_job.job_pinned = job_pinned_param
                    Dim current_time As DateTime = DateTime.Now
                    new_job.job_date_created = DateTime.Now.ToString("dd/MM/yyyy")
                    new_job.job_username = Environment.UserName
                    new_job.job_count = job_count_param
                    Try
                        FilePut(1, new_job)
                        MsgBox("Record Added.")
                    Catch ex As Exception
                        MsgBox("Record Update Failed.")
                    End Try
                End If
            Else
                MsgBox("The Input Was Not Valid.")
            End If
        Else
            MsgBox("The Input Was Not Valid.")
        End If
        FileClose(1)
        populate_all()
    End Sub

    Private Sub ProductComponentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductComponentToolStripMenuItem.Click
        FileOpen(1, "ProductComponent.dat", OpenMode.Random, , , Len(product_component_record))
        Dim component_id_param As String = InputBox("Please Enter A component ID:", "Product Component:", "#VALUE")
        Dim product_id_param As String = InputBox("Please Enter A Product ID:", "Product Component::", "#VALUE")
        Dim comp_product_count_param As String = InputBox("Please Enter A production quantity:", "Product Component::", "#VALUE")
        If IsNumeric(component_id_param) And IsNumeric(product_id_param) And IsNumeric(comp_product_count_param) Then
            Try
                FileGet(1, product_component_record, LOF(1) / Len(product_component_record))
            Catch ex As Exception

            End Try
            Dim result As MessageBoxButtons = MsgBox("The New Record Will Have The Following Data: " & vbNewLine & vbNewLine & "Component ID: " & component_id_param & vbNewLine & "Product ID: " & product_id_param & vbNewLine & "Quantity: " & comp_product_count_param & vbNewLine & vbNewLine & "Is this correct?", MsgBoxStyle.YesNo)
            If result = MsgBoxResult.Yes Then
                Dim new_component As New product_component
                new_component.component_id = component_id_param
                new_component.product_id = product_id_param
                new_component.quantity = comp_product_count_param
                FileClose(1)
                If checkComponentRecord(component_id_param) And checkProductRecord(product_id_param) And checkProductComponentRecord(product_id_param, component_id_param) = False Then
                    FileOpen(1, "ProductComponent.dat", OpenMode.Random, , , Len(product_component_record))
                    FilePut(1, new_component)
                    MsgBox("Record Added.")
                Else
                    MsgBox("Either one or more of the entered IDs don't exist in the database or this record already exists.")
                End If
            End If
        Else
            MsgBox("The Input Was Not Valid.")
        End If
        FileClose(1)

        populate_all()
    End Sub

    Private Sub ComponentLocationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComponentLocationToolStripMenuItem.Click
        FileOpen(1, "ComponentLocation.dat", OpenMode.Random, , , Len(component_location_record))
        Dim component_id_param As String = InputBox("Please Enter A component ID:", "Component Location:", "#VALUE")
        Dim location_id_param As String = InputBox("Please Enter A location ID:", "Component Location:", "#VALUE")
        If IsNumeric(component_id_param) And IsNumeric(location_id_param) Then
            Try
                FileGet(1, component_location_record, LOF(1) / Len(component_location_record))
            Catch ex As Exception
                'first entry
            End Try
            Dim result As MessageBoxButtons = MsgBox("The New Record Will Have The Following Data: " & vbNewLine & vbNewLine & "Component ID: " & component_id_param & vbNewLine & "Location ID: " & location_id_param & vbNewLine & vbNewLine & "Is this correct?", MsgBoxStyle.YesNo)
            If result = MsgBoxResult.Yes Then
                Dim new_component As New component_location
                new_component.component_id = component_id_param
                new_component.location_id = location_id_param
                FileClose(1)

                If checkComponentRecord(component_id_param) And checkLocationRecord(location_id_param) And checkComponentLocationRecord(component_id_param, location_id_param) = False Then
                    FileOpen(1, "ComponentLocation.dat", OpenMode.Random, , , Len(component_location_record))
                    FilePut(1, new_component)
                    MsgBox("Record Added.")
                Else
                    MsgBox("Either one or more of the entered IDs don't exist in the database or this record already exists.")
                End If
            End If
        Else
            MsgBox("The Input Was Not Valid.")
        End If
        FileClose(1)
        FileClose(7)
        populate_all()
    End Sub

    Private Sub RemoveSelectedRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveSelectedRecordToolStripMenuItem.Click
        Select Case current_structure
            Case "Products"
                If txtProductID.Text <> String.Empty Then
                    Dim product_before As product = getProductRecord(txtProductID.Text)
                    Dim result As MessageBoxButtons = MsgBox("The Record before update:" & vbNewLine & vbNewLine & " ID: " & product_before.product_id & vbNewLine & " Name: " & product_before.product_desc & vbNewLine & " Code: " & product_before.product_code & vbNewLine & vbNewLine & "It will be removed. " & vbNewLine & vbNewLine & "Is this correct?", MsgBoxStyle.YesNo)
                    Dim product_new As product
                    Dim record_update_NEW As Integer = 0
                    Dim valid_input As Boolean = True
                    If result = MsgBoxResult.Yes Then
                        Try
                            record_update_NEW = CInt(lv_products.SelectedIndices(0).ToString) + 1
                            product_new.product_id = -1
                            product_new.product_desc = -1
                            product_new.product_code = -1
                            FileOpen(1, "Products.dat", OpenMode.Random, , , Len(product_record))
                            FilePut(1, product_new, record_update_NEW)
                            FileClose(1)
                            MsgBox("Update Successful.")
                            Dim free_file_number = FreeFile()
                            FileOpen(free_file_number, "JobProduct.dat", OpenMode.Random, , , Len(job_product_record))
                            Dim free_file_number_temp = FreeFile()
                            FileOpen(free_file_number_temp, "JobProduct_temp.dat", OpenMode.Random, , , Len(job_product_record))
                            Dim lof_job_product_record_temp As Integer = 1
                            If LOF(free_file_number) / Len(job_product_record) = 0 Then
                            Else
                                For o = 1 To LOF(free_file_number) / Len(job_product_record)
                                    FileGet(free_file_number, job_product_record, o)
                                    If job_product_record.product_id = txtProductID.Text Or job_product_record.job_id = 0 Then
                                    Else
                                        FilePut(free_file_number_temp, job_product_record, lof_job_product_record_temp)
                                    End If
                                    lof_job_product_record_temp += 1
                                Next o
                            End If
                            FileClose(free_file_number)
                            FileClose(free_file_number_temp)
                            My.Computer.FileSystem.DeleteFile(CurDir() & "\JobProduct.dat")
                            My.Computer.FileSystem.RenameFile(CurDir() & "\JobProduct_temp.dat", "JobProduct.dat")
                            MessageBox.Show("Job Information Successfully Updated.", "", MessageBoxButtons.OK)
                        Catch
                            MsgBox("Error Updating")
                        End Try

                    Else
                        MsgBox("Update Aborted.")
                    End If
                Else
                    selection_error()
                End If
                clean_file("Products")

            Case "Components"
                If txtComponentID.Text <> String.Empty Then
                    Dim component_before As component = getComponentRecord(txtComponentID.Text)
                    Dim result As MessageBoxButtons = MsgBox("The Record before update:" & vbNewLine & vbNewLine & " ID: " & component_before.component_id & vbNewLine & " Name: " & component_before.component_desc & vbNewLine & " Code: " & component_before.component_code & vbNewLine & vbNewLine & "It will be removed. " & vbNewLine & vbNewLine & "Is this correct?", MsgBoxStyle.YesNo)
                    Dim component_new As component
                    Dim record_update_NEW As Integer = 0
                    Dim valid_input As Boolean = True
                    If result = MsgBoxResult.Yes Then
                        Try
                            record_update_NEW = CInt(lv_components.SelectedIndices(0).ToString) + 1
                            component_new.component_id = -1
                            component_new.component_desc = -1
                            component_new.component_code = -1
                            FileOpen(1, "Components.dat", OpenMode.Random, , , Len(component_record))
                            FilePut(1, component_new, record_update_NEW)
                            FileClose(1)
                            MsgBox("Update Successful.")

                        Catch
                            MsgBox("Error Updating")
                        End Try
                    Else
                        MsgBox("Update Aborted.")
                    End If
                Else
                    selection_error()
                End If
                clean_file("Components")

            Case "ComponentLocations"
                If txtLocationID.Text <> String.Empty Or txtComponentID.Text <> String.Empty Then
                    Dim component_location_before As component_location = getProductComponentRecord(txtProductID.Text, txtComponentID.Text)
                    Dim result As MessageBoxButtons = MsgBox("The Record before update:" & vbNewLine & vbNewLine & " Location ID: " & component_location_before.location_id & vbNewLine & " Component ID: " & component_location_before.component_id & vbNewLine & vbNewLine & "It will be removed. " & vbNewLine & vbNewLine & "Is this correct?", MsgBoxStyle.YesNo)
                    Dim product_component_new As component_location
                    Dim record_update_NEW As Integer = 0
                    Dim valid_input As Boolean = True
                    If result = MsgBoxResult.Yes Then
                        Try
                            record_update_NEW = getComponentLocationRecordNumber(component_location_before.component_id, component_location_before.location_id)
                            product_component_new.location_id = -1
                            product_component_new.component_id = -1
                            FileOpen(1, "ComponentLocation.dat", OpenMode.Random, , , Len(component_location_record))
                            FilePut(1, product_component_new, record_update_NEW)
                            FileClose(1)
                            MsgBox("Update Successful.")

                        Catch
                            MsgBox("Error Updating")
                        End Try
                    Else
                        MsgBox("Update Aborted.")
                    End If
                Else
                    selection_error()
                End If
                clean_file("ComponentLocations")

            Case "Locations"
                If txtLocationID.Text <> String.Empty Then
                    Dim location_before As location = getLocationRecord(txtLocationID.Text)
                    Dim result As MessageBoxButtons = MsgBox("The Record before update:" & vbNewLine & vbNewLine & " ID: " & location_before.location_id & vbNewLine & " Name: " & location_before.location_desc & vbNewLine & vbNewLine & "It will be removed. " & vbNewLine & vbNewLine & "Is this correct?", MsgBoxStyle.YesNo)
                    Dim location_new As location
                    Dim record_update_NEW As Integer = 0
                    Dim valid_input As Boolean = True
                    If result = MsgBoxResult.Yes Then
                        Try
                            record_update_NEW = CInt(lv_locations.SelectedIndices(0).ToString) + 1
                            location_new.location_id = -1
                            location_new.location_desc = -1
                            FileOpen(1, "Locations.dat", OpenMode.Random, , , Len(location_record))
                            FilePut(1, location_new, record_update_NEW)
                            FileClose(1)
                            MsgBox("Update Successful.")

                        Catch
                            MsgBox("Error Updating")
                        End Try
                    Else
                        MsgBox("Update Aborted.")
                    End If
                Else
                    selection_error()
                End If
                clean_file("Locations")

            Case "ProductComponents"
                If txtProductID.Text <> String.Empty Or txtComponentID.Text <> String.Empty Then
                    Dim product_component_before As product_component = getProductComponentRecord(txtProductID.Text, txtComponentID.Text)
                    Dim result As MessageBoxButtons = MsgBox("The Record before update:" & vbNewLine & vbNewLine & " Product ID: " & product_component_before.product_id & vbNewLine & " Component ID: " & product_component_before.component_id & vbNewLine & " Quantity: " & product_component_before.quantity & vbNewLine & vbNewLine & "It will be removed. " & vbNewLine & vbNewLine & "Is this correct?", MsgBoxStyle.YesNo)
                    Dim product_component_new As product_component
                    Dim record_update_NEW As Integer = 0
                    Dim valid_input As Boolean = True
                    If result = MsgBoxResult.Yes Then
                        Try
                            record_update_NEW = getProductComponentRecordNumber(product_component_before.product_id, product_component_before.component_id)
                            product_component_new.product_id = -1
                            product_component_new.component_id = -1
                            product_component_new.quantity = -1
                            FileOpen(1, "ProductComponent.dat", OpenMode.Random, , , Len(product_component_record))
                            FilePut(1, product_component_new, record_update_NEW)
                            FileClose(1)
                            MsgBox("Update Successful.")

                        Catch
                            MsgBox("Error Updating")
                        End Try
                    Else
                        MsgBox("Update Aborted.")
                    End If
                Else
                    selection_error()
                End If
                clean_file("ProductComponents")

            Case "Jobs"
                If txtJobID.Text <> String.Empty Then
                    Dim job_before As job = getJobRecord(txtJobID.Text)
                    Dim result As MessageBoxButtons = MsgBox("The Record before update:" & vbNewLine & vbNewLine & " ID: " & job_before.job_id & vbNewLine & " Name: " & job_before.job_name & vbNewLine & vbNewLine & "It will be removed. " & vbNewLine & vbNewLine & "Is this correct?", MsgBoxStyle.YesNo)
                    Dim job_new As job
                    Dim record_update_NEW As Integer = 0
                    Dim valid_input As Boolean = True
                    If result = MsgBoxResult.Yes Then
                        Try
                            record_update_NEW = CInt(lv_jobs.SelectedIndices(0).ToString) + 1
                            job_new.job_id = -1
                            job_new.job_count = -1
                            job_new.job_date_created = -1
                            job_new.job_name = -1
                            job_new.job_pinned = -1
                            job_new.job_username = -1
                            FileOpen(1, "jobs.dat", OpenMode.Random, , , Len(job_record))
                            FilePut(1, job_new, record_update_NEW)
                            FileClose(1)
                            MsgBox("Update Successful.")
                            Dim free_file_number = FreeFile()
                            FileOpen(free_file_number, "JobProduct.dat", OpenMode.Random, , , Len(job_product_record))
                            Dim free_file_number_temp = FreeFile()
                            FileOpen(free_file_number_temp, "JobProduct_temp.dat", OpenMode.Random, , , Len(job_product_record))
                            Dim lof_job_product_record_temp As Integer = 1
                            If LOF(free_file_number) / Len(job_product_record) = 0 Then
                            Else
                                For o = 1 To LOF(free_file_number) / Len(job_product_record)
                                    FileGet(free_file_number, job_product_record, o)
                                    If job_product_record.product_id = txtJobID.Text Or job_product_record.job_id = 0 Then
                                    Else
                                        FilePut(free_file_number_temp, job_product_record, lof_job_product_record_temp)
                                    End If
                                    lof_job_product_record_temp += 1
                                Next o
                            End If
                            FileClose(free_file_number)
                            FileClose(free_file_number_temp)
                            My.Computer.FileSystem.DeleteFile(CurDir() & "\JobProduct.dat")
                            My.Computer.FileSystem.RenameFile(CurDir() & "\JobProduct_temp.dat", "JobProduct.dat")
                            My.Computer.FileSystem.DeleteFile(CurDir() & "\CurrentJob.dat")
                            MessageBox.Show("Job Information Successfully Updated.", "", MessageBoxButtons.OK)
                        Catch
                            MsgBox("Error Updating")
                        End Try
                    Else
                        MsgBox("Update Aborted.")
                    End If
                Else
                    selection_error()
                End If
                clean_file("Jobs")

        End Select
        populate_all()
        frmCleanFiles.Show()
    End Sub

    Private Sub frmRecordEditor_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmMenu.update_menu()
    End Sub
End Class

