Imports System.ComponentModel
Imports System.Threading
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frm_importFromExcel

    Public finished_work As Boolean = True
    Public importing As Boolean = True
    Public format_datetime As String = "{0,2}:{1,2}:{2,2}:{3,4}"
    Public StopWatch As New Stopwatch()
    Dim app As New Excel.Application
    Dim worksheet_products, worksheet_components, worksheet_product_components, worksheet_locations, worksheet_component_locations As Excel.Worksheet
    Dim workbook As Excel.Workbook
    Public num_products, num_components, num_productcomponents, num_locations, num_componentlocations, total_records As Integer
    Dim excellocation As String

    Dim table_products As Hashtable = New Hashtable
    Dim table_components As Hashtable = New Hashtable
    Dim table_locations As Hashtable = New Hashtable

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim result As Integer = MessageBox.Show("Warning: Executing This Action Will Result In All Current Records Being Formatted." & vbNewLine & "Would You Like To Continue?", "", MessageBoxButtons.YesNo)
        excellocation = TextBox1.Text
        If result = DialogResult.Yes Then
            frmMenu.remove_files()
            Try
                workbook = app.Workbooks.Open(excellocation)
                workbook.Save()
                workbook.Close()
            Catch ec As Exception
                MsgBox("File does not exist. Closing" & vbNewLine & ec.ToString)
                Me.Close()
            End Try
            StopWatch.Start()
            import()

            Try
            Catch ex As Exception
                MsgBox("Error Importing." & vbNewLine & ex.ToString)
                StopWatch.Stop()
            End Try
        Else
            Me.Hide()
            frmMenu.Focus()
        End If
    End Sub

    Private Sub frm_importFromExcel_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    End Sub
    Public Sub import()
        workbook = app.Workbooks.Open(excellocation)
        worksheet_products = workbook.Worksheets("Products")
        worksheet_components = workbook.Worksheets("Components")
        worksheet_product_components = workbook.Worksheets("ProductComponent")
        worksheet_component_locations = workbook.Worksheets("ComponentLocation")
        worksheet_locations = workbook.Worksheets("Locations")
        num_products = worksheet_products.UsedRange.Rows.Count
        ProductsMax.Text = "/" & num_products
        num_components = worksheet_components.UsedRange.Rows.Count
        ComponentsMax.Text = "/" & num_components
        num_productcomponents = worksheet_product_components.UsedRange.Rows.Count
        num_locations = worksheet_locations.UsedRange.Rows.Count
        LocationsMax.Text = "/" & num_locations
        ProductComponentsMax.Text = "/" & num_productcomponents
        num_componentlocations = worksheet_component_locations.UsedRange.Rows.Count
        ComponentLocationMax.Text = "/" & num_componentlocations
        ProgressBar1.Maximum = num_products + num_components + num_locations + num_productcomponents + num_componentlocations
        total_records = (num_products + num_components + num_locations + num_productcomponents + num_componentlocations)
        Total.Text = "/" & total_records


        FileOpen(1, "Products.dat", OpenMode.Random, , , Len(product_record))
        For a = 2 To num_products
            AddProduct(a)
            progress("Products")
        Next
        FileClose(1)
        '
        FileOpen(1, "Locations.dat", OpenMode.Random, , , Len(location_record))
        For a = 2 To num_locations
            AddLocation(a)
            progress("Locations")
        Next
        FileClose(1)
        '
        FileOpen(1, "Components.dat", OpenMode.Random, , , Len(component_record))
        For a = 2 To num_components
            AddComponent(a)
            progress("Components")
        Next
        FileClose(1)
        '
        FileOpen(1, "Products.dat", OpenMode.Random, , , Len(product_record))
        hashtable_products()
        FileClose(1)
        FileOpen(1, "Components.dat", OpenMode.Random, , , Len(component_record))
        hashtable_components()
        FileClose(1)
        FileOpen(1, "Locations.dat", OpenMode.Random, , , Len(location_record))
        hashtable_locations()
        FileClose(1)
        '
        FileOpen(1, "ProductComponent.dat", OpenMode.Random, , , Len(product_component_record))
        For a = 2 To num_productcomponents
            AddProductComponent(a)
            progress("ProductComponent")
        Next
        FileClose(1)
        '
        FileOpen(1, "ComponentLocation.dat", OpenMode.Random, , , Len(component_location_record))
        For a = 2 To num_componentlocations
            AddComponentLocation(a)
            progress("ComponentLocation")
        Next
        FileClose(1)
        '
        '
        importing = False
        lblRemaining.Text = 0
        Percentage.Text = FormatPercent(1, 1)
        ProgressBar1.Value = ProgressBar1.Maximum
        frmCleanFiles.Show()
        frmCleanFiles.btnCleanFiles.PerformClick()
    End Sub

    Private Sub btnSelectWB_Click(sender As Object, e As EventArgs) Handles btnSelectWB.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = CurDir()
        fd.Filter = "Excel Workbook Files|*.xlsx"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            TextBox1.Text = strFileName
        End If
    End Sub

    Sub progress(ByVal value As String)
        '
        Dim percentage_through As Decimal
        Dim elapsed_mili As Long = StopWatch.Elapsed.TotalMilliseconds
        Dim elapsed_structure As TimeSpan = TimeSpan.FromMilliseconds(elapsed_mili)
        Static Generator As System.Random = New System.Random()
        Dim projected_time As Long
        Try
            percentage_through = Math.Round(((ProgressTotal.Text / total_records) * 100), 10)
            projected_time = (elapsed_mili / ProgressTotal.Text) * (total_records - ProgressTotal.Text)
        Catch ex As Exception
            percentage_through = 0.0000001
        End Try
        Dim time_remaining_calculation As Decimal = Math.Round(projected_time, 10)
        If Generator.Next(1, 50) = 1 Then
            remainingtime = Math.Round(time_remaining_calculation, 0)
        End If
        Dim remaining_structure As TimeSpan = TimeSpan.FromMilliseconds(remainingtime)
        Dim mili_temp As String

        If Len(elapsed_structure.Milliseconds.ToString) >= 2 Then
            mili_temp = elapsed_structure.Milliseconds.ToString.Substring(0, 2)
        Else
            mili_temp = elapsed_structure.Milliseconds.ToString
        End If
        elapsed_pass = elapsed_structure.Hours & ":" & elapsed_structure.Minutes & ":" & elapsed_structure.Seconds & ":" & mili_temp
        mili_temp = remaining_structure.Milliseconds.ToString.PadRight(10 - Len(remaining_structure.Milliseconds.ToString))
        remaining_pass = remaining_structure.Hours & ":" & remaining_structure.Minutes & ":" & remaining_structure.Seconds & ":" & mili_temp.Substring(0, 2)
        '
        If ProgressBar1.Maximum <> ProgressBar1.Value Then
            ProgressBar1.Value += 1
        End If

        Select Case value
            Case "Products"
                ProductProgress.Text += 1
            Case "Components"
                ComponentProgress.Text += 1
            Case "ComponentLocation"
                ComponentLocationProgress.Text += 1
            Case "ProductComponent"
                ProductComponentProgress.Text += 1
            Case "Locations"
                LocationProgress.Text += 1
        End Select
        Percentage.Text = FormatPercent(ProgressTotal.Text / (num_products + num_components + num_locations + num_productcomponents + num_componentlocations), 1)
        ProgressTotal.Text += 1
        lblElapsed.Text = elapsed_pass
        lblRemaining.Text = remaining_pass
    End Sub

    Sub AddProduct(ByVal a As Integer)
        Dim lof_product As Integer = LOF(1) / Len(product_record)
        product_record.product_id = lof_product + 1
        product_record.product_desc = worksheet_products.Cells(a, 2).Value
        product_record.product_code = worksheet_products.Cells(a, 1).Value
        If product_record.product_code <> String.Empty Or product_record.product_desc <> String.Empty Or product_record.product_id <> 0 Then
            FilePut(1, product_record, lof_product + 1)
        End If
    End Sub

    Private Sub frm_importFromExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub AddLocation(ByVal a As Integer)
        Dim lof_product As Integer = LOF(1) / Len(location_record)
        location_record.location_id = lof_product + 1
        location_record.location_desc = worksheet_locations.Cells(a, 1).Value
        If location_record.location_desc <> String.Empty Or location_record.location_id <> 0 Then
            FilePut(1, location_record, lof_product + 1)
        End If
    End Sub

    Sub AddComponent(ByVal a As Integer)
        Dim lof_component As Integer = LOF(1) / Len(component_record)
        component_record.component_id = lof_component + 1
        Try
            If String.IsNullOrEmpty(worksheet_components.Cells(a, 2).Value) Then
                component_record.component_desc = "#VALUE"
            Else
                component_record.component_desc = worksheet_components.Cells(a, 2).Value

            End If
        Catch
            MsgBox(a)
        End Try
        component_record.component_code = worksheet_components.Cells(a, 1).Value
        If component_record.component_code <> String.Empty Or component_record.component_desc <> String.Empty Or component_record.component_id <> 0 Then
            FilePut(1, component_record, lof_component + 1)
        End If
    End Sub
    Sub AddProductComponent(ByVal a As Integer)
        '
        Dim lof_product_component As Integer = LOF(1) / Len(product_component_record)
        Dim sought_productid As Integer = table_products(worksheet_product_components.Cells(a, 1).Value)
        Dim sought_componentid As Integer = table_components(worksheet_product_components.Cells(a, 2).Value)
        Dim quantity As Integer = worksheet_product_components.Cells(a, 3).Value
        product_component_record.product_id = sought_productid
        product_component_record.component_id = sought_componentid
        product_component_record.quantity = quantity
        If product_component_record.product_id <> 0 Or product_component_record.component_id <> 0 Or product_component_record.quantity <> 0 Then
            FilePut(1, product_component_record, lof_product_component + 1)
        End If
        '

    End Sub
    Sub hashtable_products()
        If LOF(1) / Len(job_record) = 0 Then
        Else
            For i = 1 To LOF(1) / Len(product_record)
                FileGet(1, product_record, i)
                If table_products.ContainsKey(product_record.product_code.TrimEnd(" ")) Then
                Else
                    table_products.Add(product_record.product_code.TrimEnd(" "), product_record.product_id)
                End If
            Next i
        End If
    End Sub
    Sub hashtable_components()
        If LOF(1) / Len(job_record) = 0 Then
        Else
            For i = 1 To LOF(1) / Len(component_record)
                FileGet(1, component_record, i)
                If table_components.ContainsKey(component_record.component_code.TrimEnd(" ")) Then
                ElseIf component_record.component_id = 0 Then
                Else
                    table_components.Add(component_record.component_code.TrimEnd(" "), component_record.component_id)
                End If
            Next i
        End If
    End Sub


    Sub hashtable_locations()
        If LOF(1) / Len(location_record) = 0 Then
        Else
            For i = 1 To LOF(1) / Len(location_record)
                FileGet(1, location_record, i)
                If table_locations.ContainsKey(location_record.location_desc.TrimEnd(" ")) Then
                Else
                    table_locations.Add(location_record.location_desc.TrimEnd(" "), location_record.location_id)
                End If
            Next i
        End If
    End Sub

    Sub AddComponentLocation(ByVal a As Integer)
        Dim sought_locationtid As Integer
        Dim sought_componentid As Integer
        Dim lof_component_location As Integer = LOF(1) / Len(component_location_record)
        Try
            sought_locationtid = table_locations(worksheet_component_locations.Cells(a, 2).Value)
        Catch
            sought_locationtid = -1
        End Try
        Try
            sought_componentid = table_components(worksheet_component_locations.Cells(a, 1).Value)
        Catch
            sought_componentid = -1
        End Try
        Dim quantity As Integer = worksheet_component_locations.Cells(a, 3).Value
        component_location_record.location_id = sought_locationtid
        component_location_record.component_id = sought_componentid
        component_location_record.stock_count = quantity 'This Can Be Changed In Future : worksheet_component_locations.Cells(a, 3).Value
        If component_location_record.location_id <> 0 Or component_location_record.component_id <> 0 Or CStr(component_location_record.location_id) <> String.Empty Or CStr(component_location_record.component_id) <> String.Empty Then
            FilePut(1, component_location_record, lof_component_location + 1)
        End If
        '
    End Sub

    Private Sub frm_importFromExcel_HelpButtonClicked(sender As Object, e As CancelEventArgs) Handles Me.HelpButtonClicked
        frmHelp.Show()
        frmHelp.ComboBox1.SelectedIndex = (3)
        'Process.Start("EXCEL.EXE", CurDir() & "\import_template.xlsx")
    End Sub

    Private Sub frm_importFromExcel_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Try
            workbook.Save()
            workbook.Close()
        Catch
        End Try
        Try
            app.Quit()
        Catch ex As Exception
        End Try
        clean_files()
        Process.Start("cmd", "/c taskkill /f /im excel.exe")
        frmMenu.update_menu()
    End Sub
End Class
