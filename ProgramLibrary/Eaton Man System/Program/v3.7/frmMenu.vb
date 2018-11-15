Imports System.IO
Imports System.Text.RegularExpressions
Imports System.IO.Compression
Imports System.ComponentModel

Public Class frmMenu
    Private Sub Form1_ClientSizeChanged(sender As Object, e As EventArgs) Handles Me.ClientSizeChanged
        dash_parentWrapper.Height = Me.Height - 80
        footer_label.Left = (Me.Width / 2) - (footer_label.Width / 2)
        list_currentJob.Width = dash_parentWrapper.Width
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadsettings()
        HelpButton = True
        importRecords.Filter = "Zip Files|*.zip"
        refresh_from_current_job()
        button_formatting()
        btn_search_desc.PerformClick()
    End Sub
    Private Sub list_currentJob_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles list_currentJob.DrawItem
        If e.Index Mod 2 = 0 Then
            e.Graphics.FillRectangle(Brushes.LightGray, e.Bounds)
        End If
        If list_currentJob.SelectedIndex = e.Index Then
            e.Graphics.FillRectangle(Brushes.LightSkyBlue, e.Bounds)
            Try
                e.Graphics.DrawString(list_currentJob.Items(e.Index).ToString, Me.Font, Brushes.White, 0, e.Bounds.Y + 2)
            Catch
            End Try
        Else
            e.Graphics.DrawString(list_currentJob.Items(e.Index).ToString, Me.Font, Brushes.Black, 0, e.Bounds.Y + 2)
        End If
        e.Graphics.DrawRectangle(Pens.Gray, e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height)
    End Sub
    Private Sub list_currentJob_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_currentJob.SelectedIndexChanged
        list_currentJob.Refresh()
    End Sub

    Private Sub DiscardingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscardingToolStripMenuItem.Click
        If MsgBox("Are You Sure You Want To Quit? All Data From Current Job Will Be Lost.", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "Exit - Discarding") = Windows.Forms.DialogResult.Yes Then
            My.Computer.FileSystem.DeleteFile(CurDir() & "\CurrentJob.dat")
            End
        End If
    End Sub
    Private Sub SavingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SavingToolStripMenuItem.Click
        If MsgBox("Are You Sure You Want To Quit? All Data From Current Session Will Be Saved.", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "Exit - Saving") = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub
    Private Sub MyForm_Closing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show(" Are You Sure You Want To Quit?", "Exit - Menu", MessageBoxButtons.YesNoCancel) <> DialogResult.Yes Then
            e.Cancel = True
        End If
    End Sub

    Sub info_fill(e As String, x As String)
        Dim filenum = FreeFile()
        Dim search_parameter As String = x
        Dim i As Integer
        FileOpen(filenum, "Products.dat", OpenMode.Random, , , Len(product_record))
        If LOF(filenum) / Len(job_record) = 0 Then
        Else
            For i = 1 To LOF(filenum) / Len(product_record)
                FileGet(filenum, product_record, i)
                If e = "Description" Then
                    If product_record.product_desc.TrimEnd(" ") = search_parameter Then
                        combo_productID.Text = product_record.product_id
                        combo_searchByCode.Text = product_record.product_code
                    End If
                ElseIf e = "Code" Then
                    If product_record.product_code.TrimEnd(" ") = search_parameter Then
                        combo_productID.Text = product_record.product_id
                        combo_productdesc.Text = product_record.product_desc
                    End If
                Else
                    If product_record.product_id = search_parameter Then
                        combo_productdesc.SelectedItem = product_record.product_desc
                        combo_searchByCode.Text = product_record.product_code
                    End If
                End If
            Next i
        End If
        FileClose(filenum)
    End Sub

    Private Sub cooldown_Tick(sender As Object, e As EventArgs) Handles cooldown.Tick
        Enabled = False
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search_id.Click
        info_fill("ID", combo_productID.SelectedItem)
    End Sub

    Private Sub btn_search_desc_Click(sender As Object, e As EventArgs) Handles btn_search_desc.Click
        info_fill("Description", combo_productdesc.SelectedItem)
    End Sub


    Private Sub btn_addToJob_Click(sender As Object, e As EventArgs) Handles btn_addToJob.Click
        If combo_productdesc.Text <> String.Empty And combo_productID.Text <> String.Empty And combo_quantity.Text <> String.Empty And combo_searchByCode.Text <> String.Empty And combo_quantity.Text <= 150 Then
            Dim result As Integer = MessageBox.Show("Are You Sure You Would Like To Add This Item To The Job: " & vbNewLine & "ID: " & combo_productID.Text & vbNewLine & "Description: " & combo_productdesc.Text & vbNewLine & "Code: " & combo_searchByCode.Text & vbNewLine & "Quantity: " & combo_quantity.Text, "Add Product To Job - " & combo_productID.Text, MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim avalible_filenumber = FreeFile()
                FileOpen(avalible_filenumber, "CurrentJob.dat", OpenMode.Random, , , Len(current_job_record))
                Dim lof_current_job As Integer = LOF(avalible_filenumber) / Len(current_job_record)
                If lof_current_job <> 0 Then
                    FileGet(avalible_filenumber, current_job_record, lof_current_job)
                    current_job_record.item_id = current_job_record.item_id + 1
                Else
                    current_job_record.item_id = 1
                End If
                current_job_record.product_id = CInt(combo_productID.Text)
                Try
                    current_job_record.quantity = CInt(combo_quantity.Text)
                Catch ex As Exception
                    current_job_record.quantity = 1
                End Try
                FilePut(avalible_filenumber, current_job_record, lof_current_job + 1)
                FileClose(avalible_filenumber)
                refresh_from_current_job()
            Else
            End If

        Else
            MsgBox("Please ensure all Product information has been added.")
        End If

    End Sub

    Private Sub FormatAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormatAllToolStripMenuItem.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to format all records? Selecting yes will result in the loss of all data.", "Format - All", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            remove_files()
        ElseIf result = DialogResult.No Then
            MsgBox("Format Aborted.")
        End If
        refresh_from_current_job()
    End Sub

    Private Sub ResetAllProgramCacheToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetAllProgramCacheToolStripMenuItem.Click
        If MsgBox("Are You Sure You Want To Continue?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "Reset Program Cache") = Windows.Forms.DialogResult.Yes Then
            Try
                My.Computer.FileSystem.DeleteFile(CurDir() & "\CurrentJob.dat")
            Catch ex As Exception
                FileOpen(3, "Debug\Debug.txt", OpenMode.Output)
                PrintLine(3, ex.ToString)
                FileClose(3)
            End Try
            combo_productdesc.Text = ""
            combo_productID.Text = ""
            combo_quantity.Text = ""
            combo_searchByCode.Text = ""
            refresh_from_current_job()
        End If
    End Sub

    Private Sub btn_Clear_Current_Job_Click(sender As Object, e As EventArgs) Handles btn_Clear_Current_Job.Click
        Try
            My.Computer.FileSystem.DeleteFile(CurDir() & "\CurrentJob.dat")
        Catch ex As Exception
            FileOpen(3, "Debug\Debug.txt", OpenMode.Output)
            PrintLine(3, ex.ToString)
            FileClose(3)
        End Try
        refresh_from_current_job()
    End Sub

    Sub btnConfirmJob_Click(sender As Object, e As EventArgs) Handles btnConfirmJob.Click
        Dim current_jobID As Integer
        FileOpen(1, "Jobs.dat", OpenMode.Random, , , Len(job_record))
        Try
            FileGet(1, job_record, LOF(1) / Len(job_record))
            current_jobID = job_record.job_id + 1
        Catch ex As Exception
            current_jobID = 1
        End Try
        FileClose(1)
        Dim end_of_array As Integer = 0
        FileOpen(1, "Products.dat", OpenMode.Random, , , Len(product_record))
        Dim amount_of_products As Integer = (LOF(1) / Len(product_record))
        Dim productTrend(amount_of_products, 1) As String
        FileClose(1)
        FileOpen(1, "Components.dat", OpenMode.Random, , , Len(component_record))
        Dim amount_of_components As Integer = (LOF(1) / Len(component_record))
        Dim componentTrend(amount_of_components, 1) As String
        FileClose(1)

        Dim lof_job As Integer
        Dim Job_Name As String = InputBox("Enter Desired Job Name.", "Job Name:", "")
        If Job_Name = "" Then
            MessageBox.Show("You Must Enter a Job Name to Continue.")
            Exit Sub
        Else
            Dim list_job_names As New List(Of String)
            FileOpen(1, "Jobs.dat", OpenMode.Random, , , Len(job_record))
            If LOF(1) / Len(job_record) = 0 Then
            Else
                For i = 1 To LOF(1) / Len(job_record)
                    FileGet(1, job_record, i)
                    list_job_names.Add(job_record.job_name.TrimEnd(" "))
                Next i
            End If
            FileClose(1)
            ''                
            Dim listofproducts As New List(Of String)
            Dim listofproducts_Quantity As New List(Of String)
            If list_job_names.Contains(Job_Name) Then
                Dim result As Integer = MessageBox.Show("Warning: A Job Has Been Created Under This Name Before; If This Was Intentional Then Please Continue But Proceeding Will Overwrite Any Differences In Products Within The Job." & vbNewLine & "Would You Like To Continue?", "", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    Dim o As Integer
                    Dim filenum = FreeFile()
                    FileOpen(filenum, "Jobs.dat", OpenMode.Random, , , Len(job_record))
                    '
                    Dim filenum_temp = FreeFile()
                    FileOpen(filenum_temp, "Jobs_temp.dat", OpenMode.Random, , , Len(job_record))
                    '
                    Dim lof_product_component_temp As Integer = 1
                    '
                    Dim search_parameter As String = Job_Name
                    If LOF(filenum) / Len(job_record) = 0 Then
                    Else
                        For o = 1 To LOF(filenum) / Len(job_record)
                            FileGet(filenum, job_record, o)
                            If job_record.job_name.TrimEnd(" ") = search_parameter Then
                                job_record.job_count = job_record.job_count + 1
                                FilePut(filenum_temp, job_record, lof_product_component_temp)
                                current_jobID = job_record.job_id
                            Else
                                FilePut(filenum_temp, job_record, lof_product_component_temp)
                            End If
                            lof_product_component_temp += 1
                        Next o
                    End If
                    FileClose(filenum)
                    FileClose(filenum_temp)
                    My.Computer.FileSystem.DeleteFile(CurDir() & "\Jobs.dat")
                    My.Computer.FileSystem.RenameFile(CurDir() & "\Jobs_temp.dat", "Jobs.dat")
                    'job count has been incremented
                    Dim free_file_number = FreeFile()
                    FileOpen(free_file_number, "JobProduct.dat", OpenMode.Random, , , Len(job_product_record))
                    Dim free_file_number_temp = FreeFile()
                    FileOpen(free_file_number_temp, "JobProduct_temp.dat", OpenMode.Random, , , Len(job_product_record))
                    Dim lof_job_product_record_temp As Integer = 1
                    If LOF(free_file_number) / Len(job_product_record) = 0 Then
                    Else
                        For o = 1 To LOF(free_file_number) / Len(job_product_record)
                            FileGet(free_file_number, job_product_record, o)
                            If job_product_record.job_id = current_jobID Or job_product_record.job_id = 0 Then
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
                ElseIf result = DialogResult.No Then
                End If
            Else
                FileOpen(1, "Jobs.dat", OpenMode.Random, , , Len(job_record))
                lof_job = LOF(1) / Len(job_record)
                job_record.job_id = lof_job + 1
                job_record.job_name = Job_Name
                Dim current_time As DateTime = DateTime.Now
                job_record.job_date_created = DateTime.Now.ToString("dd/MM/yyyy")
                job_record.job_count = 1
                Dim result As Integer = MessageBox.Show("Would You Like To Pin This Job?", "", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    job_record.job_pinned = True
                ElseIf result = DialogResult.No Then
                    job_record.job_pinned = False
                End If
                job_record.job_username = Environment.UserName
                FilePut(1, job_record, lof_job + 1)
                FileClose(1)
                MessageBox.Show("The Job Has Been Added.")
            End If
            FileOpen(1, "Products.dat", OpenMode.Random, , , Len(product_record))
            Dim length_of_product_file As Integer = LOF(1) / Len(job_record)
            Dim running_quantity(length_of_product_file, 2) As String
            If LOF(1) / Len(product_record) = 0 Then
            Else
                For i = 1 To LOF(1) / Len(product_record)
                    FileGet(1, product_record, i)
                    running_quantity(i - 1, 0) = product_record.product_id
                    running_quantity(i - 1, 2) = product_record.product_desc
                Next i
            End If
            FileClose(1)
            Dim b As New Integer
            Dim free_file = FreeFile()
            FileOpen(free_file, "CurrentJob.dat", OpenMode.Random, , , Len(current_job_record))
            If LOF(free_file) / Len(current_job_record) = 0 Then
            Else
                For b = 1 To LOF(free_file) / Len(current_job_record)
                    FileGet(free_file, current_job_record, b)
                    Dim x As New Integer
                    For x = 0 To (running_quantity.Length / 3) - 1
                        If running_quantity(x, 0) = current_job_record.product_id Then
                            running_quantity(x, 1) += current_job_record.quantity
                            productTrend(x, 0) = current_job_record.product_id
                            productTrend(x, 1) += current_job_record.quantity
                        End If
                    Next x
                Next b
            End If
            FileClose(free_file)
            For p = 0 To (running_quantity.Length / 3) - 1
                If running_quantity(p, 1) <> "" Then
                    If running_quantity(p, 1) <> 0 Then
                        If running_quantity(p, 1) <> "0" Then
                            FileOpen(1, "JobProduct.dat", OpenMode.Random, , , Len(job_product_record))
                            Dim lof_product_component As Integer = LOF(1) / Len(job_product_record)
                            job_product_record.job_id = current_jobID
                            listofproducts.Add(running_quantity(p, 0))
                            listofproducts_Quantity.Add(running_quantity(p, 1))
                            job_product_record.product_id = running_quantity(p, 0)
                            job_product_record.quantity = running_quantity(p, 1)
                            FilePut(1, job_product_record, lof_product_component + 1)
                            FileClose(1)
                        End If
                    End If
                End If
            Next
            Try
                My.Computer.FileSystem.DeleteFile(CurDir() & "\CurrentJob.dat")
            Catch
            End Try
            Dim Component_Name_Temp As String = "Name Error"
            FileOpen(1, "ProductComponent.dat", OpenMode.Random, , , Len(product_component_record))
            If LOF(1) / Len(product_component_record) = 0 Then
            Else
                For i = 1 To LOF(1) / Len(product_component_record)
                    FileGet(1, product_component_record, i)
                    For d = 0 To listofproducts.Count - 1
                        If product_component_record.product_id = listofproducts(d) Then
                            FileOpen(4, "Components.dat", OpenMode.Random, , , Len(component_record))
                            If LOF(4) / Len(location_record) = 0 Then
                            Else
                                For j = 1 To LOF(4) / Len(component_record)
                                    FileGet(4, component_record, j)
                                    If product_component_record.component_id = component_record.component_id Then
                                        Component_Name_Temp = component_record.component_desc
                                    End If
                                Next
                            End If
                            FileClose(4)
                            Dim Record_Present As Boolean = False
                            For t = 0 To frmPrintLabels.dgvLabels.Rows.Count - 1
                                If frmPrintLabels.dgvLabels.Rows(t).Cells("ID").Value = (product_component_record.component_id) Then
                                    frmPrintLabels.dgvLabels.Rows(t).Cells("Quantity").Value += (listofproducts(d) * product_component_record.quantity)
                                    Record_Present = True
                                End If
                            Next
                            For t = 0 To (componentTrend.Length / 2) - 1
                                If componentTrend(t, 0) = (product_component_record.component_id) Then
                                    componentTrend(t, 1) = product_component_record.quantity
                                End If
                            Next
                            If Record_Present = False Then
                                Dim component_returned As component = GetComponentValue("ID", product_component_record.component_id)
                                frmPrintLabels.dgvLabels.Rows.Add(product_component_record.component_id, Component_Name_Temp.Trim(), listofproducts_Quantity(d) * product_component_record.quantity, component_returned.component_code.TrimStart.Trim(), getLocationFromComp(product_component_record.component_id))
                                componentTrend(end_of_array, 0) = product_component_record.component_id
                                componentTrend(end_of_array, 1) = product_component_record.quantity
                                end_of_array += 1
                            End If

                        End If
                    Next
                Next
            End If
            FileClose(1)

            refresh_from_current_job()

            saveToProduction("Products", productTrend)
            saveToProduction("Component", componentTrend)
            frmPrintLabels.Show()

        End If
    End Sub
    Private Sub btnRemoveFromJob_Click(sender As Object, e As EventArgs) Handles btnRemoveFromJob.Click
        If list_currentJob.GetItemText(list_currentJob.SelectedItem).Contains(": ") Then
            Dim array_selected_item() As String = Regex.Split(list_currentJob.GetItemText(list_currentJob.SelectedItem), ": ")
            Dim current_job_file = FreeFile()
            Dim RemoveMore As Boolean = True
            Dim temp_current_job_file = FreeFile() + 1
            File.Create("CurrentJob_temp.dat").Dispose()
            Dim job_LOF_temp As Integer = 1
            FileOpen(current_job_file, "CurrentJob.dat", OpenMode.Random, , , Len(current_job_record))
            FileOpen(temp_current_job_file, "CurrentJob_temp.dat", OpenMode.Random, , , Len(current_job_record))
            If LOF(current_job_file) / Len(current_job_record) = 0 Then
                My.Computer.FileSystem.DeleteFile(CurDir() & "\CurrentJob.dat")
            Else
                For i = LOF(current_job_file) / Len(current_job_record) To 1 Step -1
                    FileGet(current_job_file, current_job_record, (i))
                    If current_job_record.product_id = array_selected_item(0) Then 'TODO Product ID
                        If RemoveMore = True Then
                            RemoveMore = False
                        Else
                            FilePut(temp_current_job_file, current_job_record, job_LOF_temp)
                        End If
                    Else
                        FilePut(temp_current_job_file, current_job_record, job_LOF_temp)
                    End If
                    job_LOF_temp += 1
                Next i
            End If
            FileClose(current_job_file)
            FileClose(temp_current_job_file)
            '
            My.Computer.FileSystem.DeleteFile(CurDir() & "\CurrentJob.dat")
            My.Computer.FileSystem.RenameFile(CurDir() & "\CurrentJob_temp.dat", "CurrentJob.dat")
            refresh_from_current_job()
        Else
            MsgBox("Please select a product.")
        End If
    End Sub
    Private Sub ExportAsBackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportAsBackupToolStripMenuItem.Click
        If (Not System.IO.Directory.Exists(CurDir() & "\Temp")) Then
            System.IO.Directory.CreateDirectory(CurDir() & "\Temp")
        End If
        copy_files()
        ZipFile.CreateFromDirectory(CurDir() & "\Temp\", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\EMU-Archive_" & DateTime.Now.DayOfYear & ".zip", CompressionLevel.Optimal, False)
        Dim path As String = CurDir() & "\Temp\"
        System.IO.Directory.Delete(path, True)
        MessageBox.Show("Archive Has Been Created." & vbNewLine & " It Can Be Found On Your Desktop Under:" & vbNewLine & "'" & Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\EMU-Archive_" & DateTime.Now.DayOfYear & ".zip" & "'.", "Archive Has Been Created.", MessageBoxButtons.OK)
    End Sub
    Private Sub ImportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportToolStripMenuItem.Click
        If (importRecords.ShowDialog = Windows.Forms.DialogResult.OK) Then
            If Path.GetExtension(importRecords.FileName) = ".zip" Then
                Dim result As String = MessageBox.Show("File Selected Successfully." & vbNewLine & vbNewLine & importRecords.FileName & vbNewLine & vbNewLine & "By Pressing Okay You Are Acknowledging That Any Current Data Will Be Overwritten.", "Incorrent File Extension.", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                    MessageBox.Show("Import Aborted", "", MessageBoxButtons.OK)
                Else
                    remove_files()
                    MsgBox("Previous Files Removed.")
                    ZipFile.ExtractToDirectory(importRecords.FileName, CurDir())
                    MsgBox("New Files Added.")
                    refresh_from_current_job()
                End If
            Else
                MessageBox.Show("Please Select A Zip File.", "Incorrent File Extension.", MessageBoxButtons.OK)
                Exit Sub
            End If
        End If
    End Sub
    Private Sub SaveCurrentSessionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveCurrentSessionToolStripMenuItem.Click
        MsgBox("Session Saved.")
    End Sub

    Private Sub recent_JobsListBox_DoubleClick(sender As Object, e As EventArgs) Handles recent_JobsListBox.DoubleClick
        get_from_listbox(recent_JobsListBox.SelectedItem)
    End Sub
    Private Sub pinned_JobsListBox_DoubleClick(sender As Object, e As EventArgs) Handles pinned_JobsListBox.DoubleClick
        get_from_listbox(pinned_JobsListBox.SelectedItem)
    End Sub




    'Subs


    Sub copy_files()
        Try
            File.Copy(CurDir() & "\Jobs.dat", CurDir() & "\Temp\Jobs.dat")
        Catch
        End Try
        Try
            File.Copy(CurDir() & "\JobProduct.dat", CurDir() & "\Temp\JobProduct.dat")
        Catch
        End Try
        Try
            File.Copy(CurDir() & "\Products.dat", CurDir() & "\Temp\Products.dat")
        Catch
        End Try
        Try
            File.Copy(CurDir() & "\CurrentJob.dat", CurDir() & "\Temp\CurrentJob.dat")
        Catch
        End Try
        Try
            File.Copy(CurDir() & "\ProductComponent.dat", CurDir() & "\Temp\ProductComponent.dat")
        Catch
        End Try
        Try
            File.Copy(CurDir() & "\Components.dat", CurDir() & "\Temp\Components.dat")
        Catch
        End Try
        Try
            File.Copy(CurDir() & "\Locations.dat", CurDir() & "\Temp\Locations.dat")
        Catch
        End Try
        Try
            File.Copy(CurDir() & "\ComponentLocation.dat", CurDir() & "\Temp\ComponentLocation.dat")
        Catch
        End Try
    End Sub
    Public Sub remove_files()
        Try
            My.Computer.FileSystem.DeleteFile(CurDir() & "\Products.dat")
        Catch
        End Try
        Try
            My.Computer.FileSystem.DeleteFile(CurDir() & "\Components.dat")
        Catch
        End Try
        Try
            My.Computer.FileSystem.DeleteFile(CurDir() & "\Locations.dat")
        Catch
        End Try
        Try
            My.Computer.FileSystem.DeleteFile(CurDir() & "\Jobs.dat")
        Catch
        End Try
        Try
            My.Computer.FileSystem.DeleteFile(CurDir() & "\JobProduct.dat")
        Catch
        End Try
        Try
            My.Computer.FileSystem.DeleteFile(CurDir() & "\ComponentLocation.dat")
        Catch
        End Try
        Try
            My.Computer.FileSystem.DeleteFile(CurDir() & "\ProductComponent.dat")
        Catch
        End Try
        Try
            My.Computer.FileSystem.DeleteFile(CurDir() & "\CurrentJob.dat")
        Catch
        End Try
    End Sub

    Sub get_from_listbox(ByVal searchparemeter As String)

        Dim job_record_clicked As job
        Dim list_products_required As New List(Of String)
        Dim list_products_required_quantity As New List(Of String)
        Try
            My.Computer.FileSystem.DeleteFile(CurDir() & "\CurrentJob.dat")
        Catch
        End Try
        Dim found_job As Boolean = False
        FileOpen(1, "Jobs.dat", OpenMode.Random, , , Len(job_record))
        If LOF(1) / Len(job_record) = 0 Then
        Else
            For i = 1 To LOF(1) / Len(job_record)
                FileGet(1, job_record, i)
                Try
                    If searchparemeter.Substring(0, 25).Contains(job_record.job_name.TrimEnd(" ")) Then
                        job_record_clicked = job_record
                        found_job = True
                    End If
                Catch ex As Exception
                    MessageBox.Show("Please Select A Job Form The List.")
                    FileClose(1)
                    FileOpen(3, "Debug\Debug.txt", OpenMode.Output)
                    PrintLine(3, ex.ToString)
                    FileClose(3)
                    Exit Sub
                End Try
            Next i
            If found_job = False Then
                MessageBox.Show("Please Select A Job Form The List.")
                FileClose(1)
                Exit Sub
            End If
        End If
        FileClose(1)
        FileOpen(1, "JobProduct.dat", OpenMode.Random, , , Len(job_product_record))
        If LOF(1) / Len(job_product_record) = 0 Then
        Else
            For x = 1 To LOF(1) / Len(job_product_record)
                FileGet(1, job_product_record, x)
                If job_product_record.job_id = job_record_clicked.job_id Then
                    list_products_required.Add(job_product_record.product_id)
                    list_products_required_quantity.Add(job_product_record.quantity)
                End If
            Next
        End If
        FileClose(1)
        For u = 0 To list_products_required.Count - 1
            Dim avalible_filenumber = FreeFile()
            FileOpen(avalible_filenumber, "CurrentJob.dat", OpenMode.Random, , , Len(current_job_record))
            Dim lof_current_job As Integer = LOF(avalible_filenumber) / Len(current_job_record)
            current_job_record.item_id = lof_current_job + 1
            current_job_record.product_id = list_products_required(u)
            current_job_record.quantity = list_products_required_quantity(u)
            FilePut(avalible_filenumber, current_job_record, lof_current_job + 1)
            FileClose(avalible_filenumber)
        Next

        refresh_from_current_job()
    End Sub

    Public Sub update_menu()
        Dim listboxFormat As String = "{0,-25}{1,5}"
        recent_JobsListBox.Items.Clear()
        pinned_JobsListBox.Items.Clear()
        combo_productdesc.Items.Clear()
        combo_productID.Items.Clear()
        pinned_JobsListBox.Items.Add("   ---     PINNED JOBS     ---   ")
        pinned_JobsListBox.Items.Add("_________________________________")
        pinned_JobsListBox.Items.Add(String.Format(listboxFormat, "Job Name", "Count"))
        pinned_JobsListBox.Items.Add("_________________________________")
        Dim list_productid As New List(Of String)
        Dim list_productdesc As New List(Of String)
        Dim list_productcode As New List(Of String)
        list_productid.Clear()
        list_productcode.Clear()
        list_productdesc.Clear()
        Dim i As Integer
        Dim filenum = FreeFile()
        FileOpen(filenum, "Products.dat", OpenMode.Random, , , Len(product_record))
        If LOF(filenum) / Len(product_record) = 0 Then
        Else
            For i = 1 To LOF(filenum) / Len(product_record)
                FileGet(filenum, product_record, i)
                list_productid.Add(product_record.product_id)
                list_productdesc.Add(product_record.product_desc.TrimEnd(" "))
                list_productcode.Add(product_record.product_code.TrimEnd(" "))
            Next i
        End If
        FileClose(filenum)
        '''''''''''''''''''''''''''''''''''''''''''
        Dim n As Integer
        Dim freefile_job = FreeFile()
        FileOpen(freefile_job, "Jobs.dat", OpenMode.Random, , , Len(job_record))
        Dim file_length As Integer = LOF(freefile_job) / Len(job_record)
        Dim Job_Table(file_length, 2) As String
        Dim Job_Table_pinned(file_length, 2) As String
        Dim no_pinned_items As Boolean = True
        If LOF(freefile_job) / Len(job_record) = 0 Then
            recent_JobsListBox.Items.Add("           No Records            ")
            pinned_JobsListBox.Items.Add("           No Records            ")
        Else
            For n = 1 To LOF(freefile_job) / Len(job_record)
                FileGet(freefile_job, job_record, n)
                If job_record.job_pinned Then
                    Job_Table_pinned(n - 1, 0) = job_record.job_count
                    Job_Table_pinned(n - 1, 1) = job_record.job_id
                    Job_Table_pinned(n - 1, 2) = job_record.job_name
                    no_pinned_items = False
                End If
                Job_Table(n - 1, 0) = job_record.job_count
                Job_Table(n - 1, 1) = job_record.job_id
                Job_Table(n - 1, 2) = job_record.job_name
            Next n

            If no_pinned_items Then
                pinned_JobsListBox.Items.Add("         No Pinned Jobs          ")
            End If
        End If
        FileClose(freefile_job)
        '''''''''''''''''''''''''''''''''''''''''''
        MergeSort_Xby3(Job_Table)

        'MergeSort_Xby3(Job_Table_pinned)
        For x = 0 To (Job_Table.Length / 3) - 1
            If CInt(Job_Table(x, 1)) <> 0 Then
                recent_JobsListBox.Items.Add(String.Format(listboxFormat, Job_Table(x, 2), Job_Table(x, 0)))
            End If
        Next
        For x = 0 To (Job_Table_pinned.Length / 3) - 1
            If CInt(Job_Table(x, 1)) <> 0 Then
                pinned_JobsListBox.Items.Add(String.Format(listboxFormat, Job_Table_pinned(x, 2), Job_Table_pinned(x, 0)))
            End If
        Next

        '''''''''''''''''''''''''''''''''''''''''''
        Dim autofill_productid As New AutoCompleteStringCollection
        autofill_productid.AddRange(list_productid.ToArray)
        combo_productID.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        combo_productID.AutoCompleteSource = AutoCompleteSource.CustomSource
        combo_productID.AutoCompleteCustomSource = autofill_productid

        combo_productID.Items.AddRange(list_productid.ToArray())
        ''''''''''''''''''''''''''''''''''''''''''''
        Dim autofill_productdesc As New AutoCompleteStringCollection
        autofill_productdesc.AddRange(list_productdesc.ToArray)
        combo_productdesc.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        combo_productdesc.AutoCompleteSource = AutoCompleteSource.CustomSource
        combo_productdesc.AutoCompleteCustomSource = autofill_productdesc
        combo_productdesc.Items.AddRange(list_productdesc.ToArray())
        ''''''''''''''''''''''''''''''''''''''''''''
        combo_searchByCode.Items.Clear()
        Dim autofill_productcode As New AutoCompleteStringCollection
        autofill_productcode.AddRange(list_productcode.ToArray)
        combo_searchByCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        combo_searchByCode.AutoCompleteSource = AutoCompleteSource.CustomSource
        combo_searchByCode.AutoCompleteCustomSource = autofill_productcode
        combo_searchByCode.Items.AddRange(list_productcode.ToArray())
        ''''''''''''''''''''''''''''''''''''''''''''
        combo_quantity.Items.Clear()
        '
        Dim list_numbers(149) As String
        For q = 1 To 150
            list_numbers(q - 1) = q
        Next
        Dim autofill_quantity As New AutoCompleteStringCollection
        autofill_quantity.AddRange(list_numbers.ToArray)
        combo_quantity.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        combo_quantity.AutoCompleteSource = AutoCompleteSource.CustomSource
        combo_quantity.AutoCompleteCustomSource = autofill_quantity
        combo_quantity.Items.AddRange(list_numbers.ToArray())
        ''''''''''''''''''''''''''''''''''''''''''''''''

        Try
            combo_productID.Text = combo_productID.Items(0).ToString
        Catch
            combo_productID.Items.Add("No Records")
            combo_productID.Text = combo_productID.Items(0).ToString
        End Try
        Try
            combo_productdesc.Text = combo_productdesc.Items(0).ToString
        Catch ex As Exception
            combo_productdesc.Items.Add("No Records")
            combo_productdesc.Text = combo_productdesc.Items(0).ToString
        End Try
        Try
            combo_searchByCode.Text = combo_searchByCode.Items(0).ToString
        Catch ex As Exception
            combo_searchByCode.Items.Add("No Records")
            combo_searchByCode.Text = combo_searchByCode.Items(0).ToString
        End Try
        Dim myLBitems As New List(Of String)
        For Each item As String In recent_JobsListBox.Items
            myLBitems.Add(item)
        Next

        recent_JobsListBox.Items.Clear()
        recent_JobsListBox.Items.Add("   ---    FREQUENT JOBS    ---   ")
        recent_JobsListBox.Items.Add("_________________________________")
        recent_JobsListBox.Items.Add(String.Format(listboxFormat, "Job Name", "Count"))
        recent_JobsListBox.Items.Add("_________________________________")

        For v As Integer = myLBitems.Count - 1 To 0 Step -1
            recent_JobsListBox.Items.Add(myLBitems(v))
        Next
    End Sub
    Sub button_formatting()
        '''''''''''''''''''''''''''''''''''''''''
        recent_JobsListBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        pinned_JobsListBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        dash_manafactureWrapper.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        dash_jobsWrapper.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        list_currentJob.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        footer_label.Anchor = (System.Windows.Forms.AnchorStyles.Bottom)
        label_productAssLocation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top And System.Windows.Forms.AnchorStyles.Bottom And System.Windows.Forms.AnchorStyles.Right And System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        label_productDesc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top And System.Windows.Forms.AnchorStyles.Bottom And System.Windows.Forms.AnchorStyles.Right And System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        label_productQuantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top And System.Windows.Forms.AnchorStyles.Bottom And System.Windows.Forms.AnchorStyles.Right And System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        label_productID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top And System.Windows.Forms.AnchorStyles.Bottom And System.Windows.Forms.AnchorStyles.Right And System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        btn_addToJob.Anchor = CType((System.Windows.Forms.AnchorStyles.Top And System.Windows.Forms.AnchorStyles.Bottom And System.Windows.Forms.AnchorStyles.Right And System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        btnConfirmJob.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btn_Clear_Current_Job.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btn_search_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btn_searchbycode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btn_search_desc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btnRemoveFromJob.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dash_manafactureWrapper.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''
        btn_addToJob.Cursor = Cursors.Hand
        btn_addToJob.FlatStyle = FlatStyle.Flat
        With btn_addToJob.FlatAppearance
            .BorderColor = Color.Red
            .BorderSize = 0
            .MouseDownBackColor = Color.LightSkyBlue
            .MouseOverBackColor = Color.LightGray
        End With
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''
        btnConfirmJob.Cursor = Cursors.Hand
        btnConfirmJob.FlatStyle = FlatStyle.Flat
        With btnConfirmJob.FlatAppearance
            .BorderColor = Color.Red
            .BorderSize = 0
            .MouseDownBackColor = Color.LightSkyBlue
            .MouseOverBackColor = Color.LightGray
        End With
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''
        btn_Clear_Current_Job.Cursor = Cursors.Hand
        btn_Clear_Current_Job.FlatStyle = FlatStyle.Flat
        With btn_Clear_Current_Job.FlatAppearance
            .BorderColor = Color.Red
            .BorderSize = 0
            .MouseDownBackColor = Color.LightSkyBlue
            .MouseOverBackColor = Color.LightGray
        End With
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''
        btnRemoveFromJob.Cursor = Cursors.Hand
        btnRemoveFromJob.FlatStyle = FlatStyle.Flat
        With btnRemoveFromJob.FlatAppearance
            .BorderColor = Color.Red
            .BorderSize = 0
            .MouseDownBackColor = Color.LightSkyBlue
            .MouseOverBackColor = Color.LightGray
        End With
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''
        btn_search_desc.Cursor = Cursors.Hand
        btn_search_desc.FlatStyle = FlatStyle.Flat
        With btn_search_desc.FlatAppearance
            .BorderColor = Color.Red
            .BorderSize = 0
            .MouseDownBackColor = Color.LightSkyBlue
            .MouseOverBackColor = Color.LightGray
        End With
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''
        btn_searchbycode.Cursor = Cursors.Hand
        btn_searchbycode.FlatStyle = FlatStyle.Flat
        With btn_searchbycode.FlatAppearance
            .BorderColor = Color.Red
            .BorderSize = 0
            .MouseDownBackColor = Color.LightSkyBlue
            .MouseOverBackColor = Color.LightGray
        End With
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''
        btn_search_id.Cursor = Cursors.Hand
        btn_search_id.FlatStyle = FlatStyle.Flat
        With btn_search_id.FlatAppearance
            .BorderColor = Color.Red
            .BorderSize = 0
            .MouseDownBackColor = Color.LightSkyBlue
            .MouseOverBackColor = Color.LightGray
        End With
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''
        list_currentJob.BorderStyle = BorderStyle.FixedSingle
        list_currentJob.DrawMode = DrawMode.OwnerDrawFixed
        list_currentJob.ItemHeight += 5
        '''''''''''''''''''''''''''''''''''''''''''
    End Sub
    Private Sub OpenHelpMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenHelpMenuToolStripMenuItem.Click
        frmHelp.Show()
    End Sub
    Sub refresh_from_current_job()
        list_currentJob.Items.Clear()
        list_currentJob.Items.Add("===========================================================")
        Dim i As New Integer
        FileOpen(1, "Products.dat", OpenMode.Random, , , Len(product_record))
        Dim length_of_product_file As Integer = LOF(1) / Len(job_record)
        Dim running_quantity(length_of_product_file, 3) As String
        If LOF(1) / Len(product_record) = 0 Then
        Else
            For i = 1 To LOF(1) / Len(product_record)
                FileGet(1, product_record, i)
                running_quantity(i - 1, 0) = product_record.product_id
                running_quantity(i - 1, 2) = product_record.product_desc
                running_quantity(i - 1, 3) = product_record.product_code
            Next i
        End If
        FileClose(1)
        Dim b As New Integer
        Dim free_file = FreeFile()
        FileOpen(free_file, "CurrentJob.dat", OpenMode.Random, , , Len(current_job_record))
        If LOF(free_file) / Len(current_job_record) = 0 Then
            list_currentJob.Items.Add("No Records")
        Else
            For b = 1 To LOF(free_file) / Len(current_job_record)
                FileGet(free_file, current_job_record, b)
                Dim x As New Integer
                For x = 0 To (running_quantity.Length / 4) - 1
                    If running_quantity(x, 0) = current_job_record.product_id Then
                        running_quantity(x, 1) += current_job_record.quantity
                    End If
                Next x
            Next b
        End If
        FileClose(free_file)
        For m = 0 To (running_quantity.Length / 4) - 1
            If running_quantity(m, 1) = String.Empty Or running_quantity(m, 0) = 0 Or running_quantity(m, 2) = String.Empty Then
            Else
                list_currentJob.Items.Add(running_quantity(m, 0) & ": " & running_quantity(m, 2).TrimEnd(" ") & ": " & running_quantity(m, 1) & ": " & running_quantity(m, 3))
                Dim filenum = FreeFile()
                Dim components_required As New List(Of String)
                Dim components_required_quantity As New List(Of String)
                Dim search_parameter As String = running_quantity(m, 0)
                FileOpen(filenum, "ProductComponent.dat", OpenMode.Random, , , Len(product_component_record))
                If LOF(filenum) / Len(product_component_record) = 0 Then
                Else
                    Dim no_components As Boolean = True
                    For i = 1 To LOF(filenum) / Len(product_component_record)
                        FileGet(filenum, product_component_record, i)
                        If product_component_record.product_id = search_parameter Then
                            components_required.Add(product_component_record.component_id)
                            no_components = False
                        End If
                    Next i
                    If no_components Then
                        list_currentJob.Items.Add("       This Product Has No Components")
                    End If
                End If
                FileClose(filenum)
                ''''''''''''''''''''
                Dim component_filenum = FreeFile()
                For x = 1 To components_required.Count
                    Dim component_search_parameter As String = components_required(x - 1)
                    Dim k As Integer
                    FileOpen(component_filenum, "Components.dat", OpenMode.Random, , , Len(component_record))
                    If LOF(component_filenum) / Len(component_record) = 0 Then
                    Else
                        For k = 1 To LOF(component_filenum) / Len(component_record)
                            FileGet(component_filenum, component_record, k)
                            If component_record.component_id = component_search_parameter Then
                                list_currentJob.Items.Add("       " & component_record.component_desc)
                            End If
                        Next k

                    End If
                    FileClose(component_filenum)
                Next x
                '''''''''''''''''''
            End If
            list_currentJob.Items.Add("===========================================================")
        Next m
        Dim duplicates As Boolean = True
        Dim problem As Boolean = False
        While duplicates
            For r = 0 To list_currentJob.Items.Count - 2
                Try
                    problem = False
                    If list_currentJob.Items.Item(r) = list_currentJob.Items.Item(r + 1) Then
                        list_currentJob.Items.RemoveAt(r + 1)
                        problem = True
                        Exit For
                    End If
                Catch
                    duplicates = False
                End Try
            Next
            If problem = False Then
                duplicates = False
            End If
        End While
        update_menu()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_searchbycode.Click
        info_fill("Code", combo_searchByCode.SelectedItem)
    End Sub

    Private Sub ImportFromExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportFromExcelToolStripMenuItem.Click
        frm_importFromExcel.Show()
    End Sub

    Private Sub AddAllProductsToJobToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAllProductsToJobToolStripMenuItem.Click
        Dim avalible_filenumber_2 = FreeFile()
        FileOpen(avalible_filenumber_2, "Products.dat", OpenMode.Random, , , Len(product_record))
        Dim lof_product_file As Integer = LOF(avalible_filenumber_2) / Len(product_record)
        Dim avalible_filenumber = FreeFile()
        FileOpen(avalible_filenumber, "CurrentJob.dat", OpenMode.Random, , , Len(current_job_record))
        For t = 1 To lof_product_file
            FileGet(avalible_filenumber_2, product_record, t)
            Dim lof_current_job As Integer = LOF(avalible_filenumber) / Len(current_job_record)
            If lof_current_job <> 0 Then
                FileGet(avalible_filenumber, current_job_record, lof_current_job)
                current_job_record.item_id = current_job_record.item_id + 1
            Else
                current_job_record.item_id = 1
            End If
            current_job_record.product_id = product_record.product_id
            current_job_record.quantity = 2
            FilePut(avalible_filenumber, current_job_record, lof_current_job + 1)
        Next
        FileClose(avalible_filenumber)
        FileClose(avalible_filenumber_2)
        refresh_from_current_job()
    End Sub

    Private Sub MoreHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoreHelpToolStripMenuItem.Click
        Dim webAddress As String = "mailto:administrator@eyetinary.co.uk?body=Hi,%20I%27m%20Having%20Some%20Trouble%20With%20...&subject=" & DateTime.Now.Date & "%20-%20Help%20Request:"
        Process.Start(webAddress)
    End Sub

    Private Sub RecordEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecordEditorToolStripMenuItem.Click
        frmRecordEditor.Show()
    End Sub

    Private Sub frmMenu_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub

    Private Sub OpenArrayTestToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmRecordEdit_ProductComponent.Show()
    End Sub

    Private Sub CleanFilesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CleanFilesToolStripMenuItem1.Click
        frmCleanFiles.Show()
    End Sub

    Private Sub OpenReportMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenReportMenuToolStripMenuItem.Click
        frmProductionTrend.Show()
    End Sub

    Private Sub ProductionLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductionLogToolStripMenuItem.Click
        frmProductionLog.Show()
    End Sub

    Private Sub CustomReportGeneratorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomReportGeneratorToolStripMenuItem.Click
        frmFrequencyReports.Show()
    End Sub

    Private Sub ResetSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetSettingsToolStripMenuItem.Click
        File.Delete("UserSettings.dat")
        FileOpen(1, "UserSettings.dat", OpenMode.Random, , , Len(current_settings))
        user_config.display_help_recordeditor = True
        user_config.first_time = True
        FilePut(1, user_config, 1)
        FileClose(1)
    End Sub
End Class


