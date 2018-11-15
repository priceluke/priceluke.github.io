Imports System.IO
Imports Word = Microsoft.Office.Interop.Word
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Text
Imports System.Runtime.InteropServices

Module algotihm_library
    Public user_config As user_settings
    Public Sub loadsettings()
        FileOpen(1, "UserSettings.dat", OpenMode.Random, , , Len(current_settings))
        FileGet(1, current_settings, 1)
        user_config.display_help_recordeditor = current_settings.display_help_recordeditor
        user_config.first_time = current_settings.first_time
        FileClose(1)
    End Sub
    Public remaining_pass As String
    Public importing As Boolean = True
    Public elapsed_pass As String
    Public elapsedtime As Long
    Public remainingtime As Long
    Public totaltime As Long
    Public Function FilenameIsOK(ByVal fileName As String) As Boolean
        Dim file As String = Path.GetFileName(fileName)
        Dim directory As String = Path.GetDirectoryName(fileName)
        Return Not (file.Intersect(Path.GetInvalidFileNameChars()).Any() OrElse directory.Intersect(Path.GetInvalidPathChars()).Any())
    End Function

    Public Sub MergeSort_Xby3(ByVal ar(,) As String)
        DoMergeSort_Xby3(ar, 0, (ar.Length / 3) - 1)
    End Sub


    Private Sub DoMergeSort_Xby3(ByVal ar(,) As String, ByVal low As Integer, ByVal high As Integer)
        If low >= high Then Return
        Dim length As Integer = high - low + 1
        Dim middle As Integer = Math.Floor((low + high) / 2)
        DoMergeSort_Xby3(ar, low, middle)
        DoMergeSort_Xby3(ar, middle + 1, high)
        Dim temp((ar.Length / 3) - 1, 2) As String
        For i As Integer = 0 To length - 1
            temp(i, 0) = ar(low + i, 0)
            temp(i, 1) = ar(low + i, 1)
            temp(i, 2) = ar(low + i, 2)
        Next
        Dim m1 As Integer = 0
        Dim m2 As Integer = middle - low + 1
        For i As Integer = 0 To length - 1
            If m2 <= high - low Then
                If m1 <= middle - low Then
                    If CInt(temp(m1, 0)) > CInt(temp(m2, 0)) Then
                        ar(i + low, 0) = temp(m2, 0)
                        ar(i + low, 1) = temp(m2, 1)
                        ar(i + low, 2) = temp(m2, 2)
                        m2 += 1
                    Else
                        ar(i + low, 0) = temp(m1, 0)
                        ar(i + low, 1) = temp(m1, 1)
                        ar(i + low, 2) = temp(m1, 2)
                        m1 += 1
                    End If
                Else
                    ar(i + low, 0) = temp(m2, 0)
                    ar(i + low, 1) = temp(m2, 1)
                    ar(i + low, 2) = temp(m2, 2)
                    m2 += 1
                End If
            Else
                ar(i + low, 0) = temp(m1, 0)
                ar(i + low, 1) = temp(m1, 1)
                ar(i + low, 2) = temp(m1, 2)
                m1 += 1
            End If
        Next
    End Sub

    Public Function getProductRecord(ByVal searchValue As String)
        searchValue.TrimEnd(" ")
        FileOpen(7, "Products.dat", OpenMode.Random, , , Len(product_record))
        Dim temp_record_compare As Integer = LOF(7) / Len(product_record)
        Dim low As Integer
        low = 0
        Dim high As Integer
        high = temp_record_compare
        Dim i As Integer = 1
        Do While low <= high
            i = Math.Ceiling((low + high) / 2)
            FileGet(7, product_record, i)
            If searchValue = product_record.product_id Then
                FileClose(7)
                Return product_record
                Exit Do
            ElseIf searchValue < product_record.product_id Then
                high = (i - 1)
            Else
                low = (i + 1)
            End If
        Loop
        FileClose(7)
        MsgBox("Error: This Record Could Not Be Found.")
        Return product_record
    End Function

    Public Function getComponentRecord(ByVal searchValue As String)
        FileOpen(7, "Components.dat", OpenMode.Random, , , Len(component_record))
        Dim temp_record_compare As Integer = LOF(7) / Len(component_record)
        Dim low As Integer
        low = 0
        Dim high As Integer
        high = temp_record_compare
        Dim i As Integer = 1
        Do While low <= high
            i = Math.Ceiling((low + high) / 2)
            FileGet(7, component_record, i)
            If searchValue = component_record.component_id Then
                FileClose(7)
                Return component_record
                Exit Do
            ElseIf searchValue < component_record.component_id Then
                high = (i - 1)
            Else
                low = (i + 1)
            End If
        Loop
        FileClose(7)
        MsgBox("Error: This Record Could Not Be Found.")
        Return component_record
    End Function

    Public Function GetComponentValue(ByVal attribute As String, ByVal value As String)
        FileOpen(7, "Components.dat", OpenMode.Random, , , Len(component_record))
        Dim LOF_comp As Integer = LOF(7) / Len(component_record)
        For p = 1 To LOF_comp
            FileGet(7, component_record, p)
            Select Case attribute
                Case "CODE"
                    If component_record.component_code = value Then
                        Exit For
                    End If
                Case "ID"
                    If component_record.component_id = value Then
                        Exit For
                    End If
                Case "DESC"
                    If component_record.component_desc = value Then
                        Exit For
                    End If
            End Select
        Next
        FileClose(7)
        Return component_record
    End Function


    Public Function getLocationRecord(ByVal searchValue As String)
        FileOpen(7, "Locations.dat", OpenMode.Random, , , Len(location_record))
        Dim temp_record_compare As Integer = LOF(7) / Len(location_record)
        Dim low As Integer
        low = 0
        Dim high As Integer
        high = temp_record_compare
        Dim i As Integer = 1
        Do While low <= high
            i = Math.Ceiling((low + high) / 2)
            FileGet(7, location_record, i)
            If searchValue = location_record.location_id Then
                FileClose(7)
                Return location_record
                Exit Do
            ElseIf searchValue < location_record.location_id Then
                high = (i - 1)
            Else
                low = (i + 1)
            End If
        Loop
        FileClose(7)
        MsgBox("Error: This Record Could Not Be Found.")
        Return location_record
    End Function

    Public Function getJobRecord(ByVal searchValue As String)
        FileOpen(7, "Jobs.dat", OpenMode.Random, , , Len(job_record))
        Dim temp_record_compare As Integer = LOF(7) / Len(job_record)
        Dim low As Integer
        low = 0
        Dim high As Integer
        high = temp_record_compare
        Dim i As Integer = 1
        Do While low <= high
            i = Math.Ceiling((low + high) / 2)
            FileGet(7, job_record, i)
            If searchValue = job_record.job_id Then
                FileClose(7)
                Return job_record
                Exit Do
            ElseIf searchValue < job_record.job_id Then
                high = (i - 1)
            Else
                low = (i + 1)
            End If
        Loop
        FileClose(7)
        MsgBox("Error: This Record Could Not Be Found.")
        Return job_record
    End Function

    Public Function getProductComponentRecord(ByVal searchValueProduct As String, ByVal searchValueComp As String)
        FileOpen(7, "ProductComponent.dat", OpenMode.Random, , , Len(product_component_record))
        Dim temp_record_compare As Integer = LOF(7) / Len(product_component_record)
        Dim low As Integer
        low = 0
        Dim high As Integer
        high = temp_record_compare
        Dim i As Integer = 1
        Do While low <= high
            i = Math.Ceiling((low + high) / 2)
            FileGet(7, product_component_record, i)
            If searchValueProduct = product_component_record.product_id Then
                FileClose(7)
                Exit Do
            ElseIf searchValueProduct < product_component_record.product_id Then
                high = (i - 1)
            Else
                low = (i + 1)
            End If
        Loop
        Dim x As Integer = i
        FileClose(7)
        FileOpen(7, "ProductComponent.dat", OpenMode.Random, , , Len(product_component_record))
        For x = i To 1 Step -1
            FileGet(7, product_component_record, x)
            If product_component_record.product_id <> CInt(searchValueProduct.TrimEnd(" ")) Then
                Exit For
            End If
        Next
        x += 1
        FileClose(7)
        FileOpen(7, "ProductComponent.dat", OpenMode.Random, , , Len(product_component_record))
        'first instance of product in loop
        For m = x To temp_record_compare
            FileGet(7, product_component_record, m)
            If product_component_record.product_id = CInt(searchValueProduct) And product_component_record.component_id = CInt(searchValueComp) Then
                FileClose(7)
                Return product_component_record
            End If
        Next
        MsgBox("Error: This Record Could Not Be Found.")
        FileClose(7)
        Return product_component_record
    End Function

    Public Function getComponentLocationRecord(ByVal searchValueComp As String, ByVal searchValueLocation As String)
        FileOpen(7, "ComponentLocation.dat", OpenMode.Random, , , Len(component_location_record))
        Dim temp_record_compare As Integer = LOF(7) / Len(component_location_record)
        Dim low As Integer
        low = 0
        Dim high As Integer
        high = temp_record_compare
        Dim i As Integer = 1
        Do While low <= high
            i = Math.Ceiling((low + high) / 2)
            FileGet(7, component_location_record, i)
            If searchValueComp = component_location_record.component_id Then
                FileClose(7)
                Exit Do
            ElseIf searchValueComp < component_location_record.component_id Then
                high = (i - 1)
            Else
                low = (i + 1)
            End If
        Loop
        Dim x As Integer = i
        FileClose(7)
        FileOpen(7, "ComponentLocation.dat", OpenMode.Random, , , Len(component_location_record))
        For x = i To 1 Step -1
            FileGet(7, component_location_record, x)
            If component_location_record.component_id <> CInt(searchValueComp.TrimEnd(" ")) Then
                Exit For
            End If
        Next
        x += 1
        FileClose(7)
        FileOpen(7, "ComponentLocation.dat", OpenMode.Random, , , Len(component_location_record))
        'first instance of product in loop
        For m = x To temp_record_compare
            FileGet(7, component_location_record, m)
            If component_location_record.component_id = CInt(searchValueComp) And component_location_record.location_id = CInt(searchValueLocation) Then
                FileClose(7)
                Return component_location_record
            End If
        Next
        MsgBox("Error: This Record Could Not Be Found.")
        FileClose(7)
        Return component_location_record
    End Function

    Public Function getLocationFromComp(ByVal compID As Integer)
        FileOpen(7, "ComponentLocation.dat", OpenMode.Random, , , Len(component_location_record))
        Dim temp_record_compare As Integer = LOF(7) / Len(component_location_record)
        Dim low As Integer
        low = 0
        Dim high As Integer
        high = temp_record_compare
        Dim i As Integer = 1
        Do While low <= high
            i = Math.Ceiling((low + high) / 2)
            FileGet(7, component_location_record, i)
            If compID = component_location_record.component_id Then
                FileClose(7)
                Exit Do
            ElseIf compID < component_location_record.component_id Then
                high = (i - 1)
            Else
                low = (i + 1)
            End If
        Loop
        FileClose(7)
        Dim return_location As location = GetLocationValue("ID", component_location_record.location_id)
        Return return_location.location_desc
    End Function

    Public Function GetLocationValue(ByVal attribute As String, ByVal value As String)
        FileOpen(7, "Locations.dat", OpenMode.Random, , , Len(location_record))
        Dim LOF_comp As Integer = LOF(7) / Len(location_record)
        For p = 1 To LOF_comp
            FileGet(7, location_record, p)
            Select Case attribute
                Case "ID"
                    If location_record.location_id = value Then
                        Exit For
                    End If
                Case "DESC"
                    If location_record.location_desc = value Then
                        Exit For
                    End If
            End Select
        Next
        FileClose(7)
        Return location_record
    End Function

    Public Sub dgvFormatting()
        frmPrintLabels.dgvLabels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        frmPrintLabels.dgvLabels.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        frmPrintLabels.dgvLabels.RowHeadersVisible = False
        frmPrintLabels.dgvLabels.Font = New Font("Courier New", 8, FontStyle.Regular)
        frmPrintLabels.dgvLabels.GridColor = Color.Navy
        frmPrintLabels.dgvLabels.CellBorderStyle = DataGridViewCellBorderStyle.None
        frmPrintLabels.dgvLabels.BackgroundColor = Color.LightGray
        frmPrintLabels.dgvLabels.DefaultCellStyle.SelectionBackColor = Color.Black
        frmPrintLabels.dgvLabels.DefaultCellStyle.SelectionForeColor = Color.White
        frmPrintLabels.dgvLabels.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        frmPrintLabels.dgvLabels.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        frmPrintLabels.dgvLabels.AllowUserToResizeColumns = False
        frmPrintLabels.dgvLabels.RowsDefaultCellStyle.BackColor = Color.LightSteelBlue
        frmPrintLabels.dgvLabels.AlternatingRowsDefaultCellStyle.BackColor = Color.White

    End Sub

    Public Function ConvMilli(ByVal milliseconds As Long)
        Dim conv_time_structure As New conv_time
        '1 ms = 0.001 sec
        ' Dim time_structure As TimeSpan = TimeSpan.FromMilliseconds(milliseconds) inbuilt :(
        conv_time_structure.hours = Math.Floor(milliseconds / 3600000)
        milliseconds -= (conv_time_structure.hours * 3600000)
        conv_time_structure.minutes = Math.Floor(milliseconds / 60000)
        milliseconds -= (conv_time_structure.minutes * 60000)
        conv_time_structure.seconds = Math.Floor(milliseconds / 1000)
        milliseconds -= (conv_time_structure.minutes * 1000)
        conv_time_structure.milliseconds = milliseconds
        Return conv_time_structure
    End Function
    Public Sub populate_all()
        frmRecordEditor.lv_components.Items.Clear()
        frmRecordEditor.lv_products.Items.Clear()
        frmRecordEditor.lv_ProductComponents.Items.Clear()
        frmRecordEditor.lv_CompLocation.Items.Clear()
        frmRecordEditor.lv_jobs.Items.Clear()
        populate("Components")
        populate("Products")
        populate("ComponentLocations")
        populate("Locations")
        populate("ProductComponents")
        populate("Jobs")
    End Sub
    Public Sub populate(ByVal file As String)
        Dim len_ofFile, i As Integer
        len_ofFile = 0
        i = 0
        Dim insert_point As Integer = 0
        Dim listview_populate As ListViewItem
        Select Case file

            Case "Components"
                FileOpen(1, "Components.dat", OpenMode.Random, , , Len(component_record))
                len_ofFile = LOF(1) / Len(component_record)
                For i = 1 To len_ofFile
                    FileGet(1, component_record, i)
                    listview_populate = frmRecordEditor.lv_components.Items.Add(component_record.component_id)
                    listview_populate.SubItems.Add(component_record.component_desc)
                    listview_populate.SubItems.Add(component_record.component_code)
                Next
            Case "ComponentLocations"
                FileOpen(1, "ComponentLocation.dat", OpenMode.Random, , , Len(component_location_record))
                len_ofFile = LOF(1) / Len(component_location_record)
                Dim twoD_complocations(len_ofFile - 1, 2) As String
                For i = 1 To len_ofFile
                    FileGet(1, component_location_record, i)
                    twoD_complocations(i - 1, 0) = component_location_record.component_id
                    twoD_complocations(i - 1, 1) = component_location_record.location_id
                    twoD_complocations(i - 1, 2) = component_location_record.stock_count
                Next
                MergeSort_Xby3(twoD_complocations)
                For o = 0 To (twoD_complocations.Length / 3) - 1
                    listview_populate = frmRecordEditor.lv_CompLocation.Items.Add(twoD_complocations(o, 0))
                    listview_populate.SubItems.Add(twoD_complocations(o, 1))
                Next
            Case "Locations"
                FileOpen(1, "Locations.dat", OpenMode.Random, , , Len(location_record))
                len_ofFile = LOF(1) / Len(location_record)
                For i = 1 To len_ofFile
                    FileGet(1, location_record, i)
                    listview_populate = frmRecordEditor.lv_locations.Items.Add(location_record.location_id)
                    listview_populate.SubItems.Add(location_record.location_desc)
                Next
            Case "ProductComponents"
                FileOpen(1, "ProductComponent.dat", OpenMode.Random, , , Len(product_component_record))
                len_ofFile = LOF(1) / Len(product_component_record)
                Dim twoD_ProdComp(len_ofFile - 1, 2) As String
                For i = 1 To len_ofFile
                    FileGet(1, product_component_record, i)
                    twoD_ProdComp(i - 1, 0) = product_component_record.product_id
                    twoD_ProdComp(i - 1, 1) = product_component_record.component_id
                    twoD_ProdComp(i - 1, 2) = product_component_record.quantity
                Next
                MergeSort_Xby3(twoD_ProdComp)
                For o = 0 To (twoD_ProdComp.Length / 3) - 1
                    listview_populate = frmRecordEditor.lv_ProductComponents.Items.Add(twoD_ProdComp(o, 0))
                    listview_populate.SubItems.Add(twoD_ProdComp(o, 1))
                    listview_populate.SubItems.Add(twoD_ProdComp(o, 2))
                Next
            Case "Jobs"
                FileOpen(1, "Jobs.dat", OpenMode.Random, , , Len(job_record))
                len_ofFile = LOF(1) / Len(job_record)
                For i = 1 To len_ofFile
                    FileGet(1, job_record, i)
                    listview_populate = frmRecordEditor.lv_jobs.Items.Add(job_record.job_id)
                    listview_populate.SubItems.Add(job_record.job_username)
                    listview_populate.SubItems.Add(job_record.job_date_created)
                    listview_populate.SubItems.Add(job_record.job_name)
                    listview_populate.SubItems.Add(job_record.job_pinned)
                    listview_populate.SubItems.Add(job_record.job_count)
                Next
            Case "Products"
                FileOpen(1, "Products.dat", OpenMode.Random, , , Len(product_record))
                len_ofFile = LOF(1) / Len(product_record)
                For i = 1 To len_ofFile
                    FileGet(1, product_record, i)
                    listview_populate = frmRecordEditor.lv_products.Items.Add(product_record.product_id)
                    listview_populate.SubItems.Add(product_record.product_desc)
                    listview_populate.SubItems.Add(product_record.product_code)
                Next
        End Select
        FileClose(1)
    End Sub

    ''' <summary>
    ''' By Passing Settings This Sub Will Format Labels And Print To Given Destination
    ''' </summary>
    ''' <param name="labels">Amount Of Columns</param>
    ''' <param name="bcolour">Background Colour.</param>
    ''' <param name="fgcolour">Font Colour</param>
    ''' <param name="fontfamily">Font Family</param>
    ''' <param name="fontsize">Font Size</param>
    ''' <param name="destinationLocation">Destination Location</param>
    ''' <param name="destinationName">Destination Name</param>
    ''' <param name="destinationExtension">Destination Extension</param>
    ''' <remarks>Luke Price - 2017</remarks>
    Public Function print_label_location(ByVal labels, ByVal bcolour, ByVal fgcolour, ByVal fontfamily, ByVal fontsize, ByVal destinationLocation, ByVal destinationName, ByVal destinationExtension)
        Dim FileLocation As String = String.Empty
        Select Case destinationExtension
            Case "PDF"
                FileLocation = destinationLocation & destinationName & ".docx"
            Case "Word"
                FileLocation = destinationLocation & destinationName & ".docx"
            Case "Excel"
                FileLocation = destinationLocation & destinationName & ".xls"
            Case "Text"
                FileLocation = destinationLocation & destinationName & ".txt"
        End Select
        If FilenameIsOK(FileLocation) Then
            Select Case destinationExtension
                Case "PDF"
                    print_PDF(labels, bcolour, fgcolour, fontfamily, fontsize, FileLocation)
                    Return "Printing Succsessful."
                Case "Word"
                    print_Word(labels, bcolour, fgcolour, fontfamily, fontsize, FileLocation)
                    Return "Printing Succsessful."
                Case "Excel"
                    print_Excel(labels, bcolour, fgcolour, fontfamily, fontsize, FileLocation)
                    Return "Printing Succsessful."
                Case "Text"
                    print_text(FileLocation)
            End Select
        Else
            Return "This File Location Combination Is Not Valid."
        End If
        Return "Error"
    End Function

    Public Sub print_text(ByVal FileLocation)
        Dim format As String = "{0,-40} {1,-8} {2,-26}"
        FileOpen(5, FileLocation, OpenMode.Output)
        PrintLine(5, String.Format(format, "Description", "Quantity", "Code"))
        PrintLine(5, "__________________________________________________________________________")
        For Each row As DataGridViewRow In frmPrintLabels.dgvLabels.Rows
            If Not row.IsNewRow Then
                PrintLine(5, String.Format(format, row.Cells(1).Value.ToString, row.Cells(2).Value.ToString, row.Cells(3).Value.ToString))
            End If
        Next
        FileClose(5)
    End Sub
    Public Sub print_Word(ByVal labels, ByVal bcolour, ByVal fgcolour, ByVal fontfamily, ByVal fontsize, ByVal FileLocation)
        Dim wa As Microsoft.Office.Interop.Word.Application
        Dim wd As New Microsoft.Office.Interop.Word.Document
        wa = CreateObject("Word.Application")
        wa.Visible = False
        Dim PIctureLocation As String = CurDir() & "\Sources\EATON_logo.jpg"
        Dim range_logo As Word.Range = wd.Range(0, 0)
        range_logo.InlineShapes.AddPicture(PIctureLocation)
        Dim rng As Word.Range = wd.Range(1, 2)
        rng.InsertBefore(vbNewLine & "Eaton Manufacturing Utility: Component Output")
        rng.InsertParagraphAfter()
        rng.Font.Name = fontfamily
        rng.Font.Size = fontsize
        rng.InsertParagraphAfter()
        rng.InsertParagraphAfter()

        rng.SetRange(rng.End, rng.End)

        ' Add the table.
        wd.Tables.Add(
    Range:=rng,
    NumRows:=1, NumColumns:=4)
        Dim tbl As Word.Table = wd.Tables(1)
        tbl.Range.Font.Size = fontsize
        tbl.Range.Font.Name = fontfamily
        tbl.Style = "Table Grid 8"
        tbl.ApplyStyleFirstColumn = False
        tbl.ApplyStyleLastColumn = False
        tbl.ApplyStyleLastRow = False

        ' Insert header text and format the columns.


        Dim rngCell As Word.Range
        rngCell = tbl.Cell(1, 2).Range
        rngCell.Text = "Quantity"
        rngCell.ParagraphFormat.Alignment =
    Word.WdParagraphAlignment.wdAlignParagraphRight

        rngCell = tbl.Cell(1, 1).Range
        rngCell.Text = "Description"
        rngCell.ParagraphFormat.Alignment =
    Word.WdParagraphAlignment.wdAlignParagraphRight

        rngCell = tbl.Cell(1, 3).Range
        rngCell.Text = "Code"
        rngCell.ParagraphFormat.Alignment =
    Word.WdParagraphAlignment.wdAlignParagraphRight

        rngCell = tbl.Cell(1, 4).Range
        rngCell.Text = "Location"
        rngCell.ParagraphFormat.Alignment =
    Word.WdParagraphAlignment.wdAlignParagraphRight
        Dim table_ref As Word.Table = wd.Tables(1)
        ' Start with row 2.
        Dim i As Integer = 2
        frmPrintLabels.dgvLabels.Sort(frmPrintLabels.dgvLabels.Columns("Quantity"), System.ComponentModel.ListSortDirection.Descending)
        For Each row As DataGridViewRow In frmPrintLabels.dgvLabels.Rows
            If Not row.IsNewRow Then
                table_ref.Rows.Add()
                table_ref.Cell(i, 1).Range.Text = row.Cells(1).Value.ToString
                table_ref.Cell(i, 2).Range.Text = row.Cells(2).Value.ToString
                table_ref.Cell(i, 3).Range.Text = row.Cells(3).Value.ToString
                table_ref.Cell(i, 4).Range.Text = row.Cells(4).Value.ToString
                i += 1
            End If
        Next
        wd.SaveAs(FileLocation)
        wd.Close()
        wa.Quit()
    End Sub

    Public Sub print_PDF(ByVal labels, ByVal bcolour, ByVal fgcolour, ByVal fontfamily, ByVal fontsize, ByVal FileLocation)
        print_Word(labels, bcolour, fgcolour, fontfamily, fontsize, FileLocation)
        'Load Document
        Dim wordApplication As New Microsoft.Office.Interop.Word.Application
        Dim wordDocument As Microsoft.Office.Interop.Word.Document = Nothing
        Dim outputFilename As String

        Try
            wordDocument = wordApplication.Documents.Open(FileLocation)
            outputFilename = System.IO.Path.ChangeExtension(FileLocation, "pdf")

            If Not wordDocument Is Nothing Then
                wordDocument.ExportAsFixedFormat(outputFilename, Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF, True, Microsoft.Office.Interop.Word.WdExportOptimizeFor.wdExportOptimizeForOnScreen, Microsoft.Office.Interop.Word.WdExportRange.wdExportAllDocument, 0, 0, Microsoft.Office.Interop.Word.WdExportItem.wdExportDocumentContent, True, True, Microsoft.Office.Interop.Word.WdExportCreateBookmarks.wdExportCreateNoBookmarks, True, True, False)
            End If
        Catch ex As Exception
            FileOpen(3, "Debug\Debug.txt", OpenMode.Output)
            PrintLine(3, ex.ToString)
            FileClose(3)
        Finally
            If Not wordDocument Is Nothing Then
                wordDocument.Close(False)
                wordDocument = Nothing
            End If

            If Not wordApplication Is Nothing Then
                wordApplication.Quit()
                wordApplication = Nothing
            End If
            File.Delete(FileLocation)
        End Try
    End Sub


    Public Sub print_Excel(ByVal labels, ByVal bcolour, ByVal fgcolour, ByVal fontfamily, ByVal fontsize, ByVal FileLocation)
        Dim xlApp As Excel.Application = New Microsoft.Office.Interop.Excel.Application()
        If xlApp Is Nothing Then
            MessageBox.Show("Excel is not properly installed.")
        End If
        Dim xlWorkBook As Excel.Workbook
        Dim misValue As Object = System.Reflection.Missing.Value

        Dim foregroundcolor As System.Drawing.Color = Color.FromName(fgcolour)
        Dim backgroundcolor As System.Drawing.Color = Color.FromName(bcolour)
        xlWorkBook = xlApp.Workbooks.Add()
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet = xlApp.Worksheets.Add()
        xlWorkSheet.Name = "Components Required"
        Dim range_x As String = getAlphPos(labels)
        Dim range_y As Integer = Math.Ceiling(frmPrintLabels.dgvLabels.Rows.Count / labels)
        With xlWorkSheet.Range("A1", range_x & range_y)
            .ColumnWidth = 120
            .RowHeight = 120
            .Font.Color = System.Drawing.ColorTranslator.ToOle(foregroundcolor)
            .Interior.Color = System.Drawing.ColorTranslator.ToOle(backgroundcolor)
            .Font.Size = fontsize
            .Font.Name = fontfamily
            .VerticalAlignment = Excel.Constants.xlCenter
            .HorizontalAlignment = Excel.Constants.xlCenter
            .ShrinkToFit = True
        End With
        Dim x As Integer = 1
        Dim y As Integer = 1
        For Each row As DataGridViewRow In frmPrintLabels.dgvLabels.Rows
            If Not row.IsNewRow Then
                If x <= labels Then
                Else
                    y += 1
                    x = 1
                End If
                xlWorkSheet.Cells(y, x) = row.Cells(1).Value.ToString & vbNewLine & row.Cells(2).Value.ToString & vbNewLine & row.Cells(3).Value.ToString
                x += 1
            End If
        Next
        xlApp.Application.DisplayAlerts = False
        xlApp.Sheets("Sheet1").Delete
        xlWorkBook.SaveAs(FileLocation, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
        xlWorkBook.Close(True, misValue, misValue)
        xlApp.Quit()

        releaseObject(xlWorkSheet)
        releaseObject(xlWorkBook)
        releaseObject(xlApp)

        MessageBox.Show("Excel file created , you can find the file here:" & vbNewLine & FileLocation)
        Process.Start(FileLocation)
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
            FileOpen(3, "Debug\Debug.txt", OpenMode.Output)
            PrintLine(3, ex.ToString)
            FileClose(3)
        Finally
            GC.Collect()
        End Try
    End Sub

    Public Function getAlphPos(ByVal num As Integer)
        If num > 0 AndAlso num < 27 Then
            Dim c As Char
            c = Convert.ToChar(num + 64)
            Return c
        Else
            Return ""
        End If
    End Function
    Sub allowaccess(ByVal allow As String)

        Select Case allow
            Case "Products"
                frmRecordEditor.txtProductDesc.Enabled = True
                frmRecordEditor.txtProductCode.Enabled = True
            Case "Components"
                frmRecordEditor.txtComponentDescription.Enabled = True
                frmRecordEditor.txtComponentCode.Enabled = True
            Case "ComponentLocations"
                frmRecordEditor.txtLocationID.Enabled = True
                frmRecordEditor.txtComponentID.Enabled = True
            Case "Locations"
                frmRecordEditor.txtLocationDescription.Enabled = True
            Case "ProductComponents"
                frmRecordEditor.txtProductID.Enabled = True
                frmRecordEditor.txtComponentID.Enabled = True
            Case "Jobs"
                frmRecordEditor.txtJobName.Enabled = True
                frmRecordEditor.txtJobPinned.Enabled = True
                frmRecordEditor.txtJobCount.Enabled = True
        End Select
    End Sub
    Public Function checkProductRecord(ByVal searchValue As String)
        FileOpen(7, "Products.dat", OpenMode.Random, , , Len(product_record))
        Dim temp_record_compare As Integer = LOF(7) / Len(product_record)
        Dim low As Integer
        low = 0
        Dim high As Integer
        high = temp_record_compare
        Dim i As Integer = 1
        Do While low <= high
            i = Math.Ceiling((low + high) / 2)
            FileGet(7, product_record, i)
            If searchValue = product_record.product_id Then
                FileClose(7)
                Return True
                Exit Do
            ElseIf searchValue < product_record.product_id Then
                high = (i - 1)
            Else
                low = (i + 1)
            End If
        Loop
        FileClose(7)
        Return False
    End Function

    Public Function checkComponentRecord(ByVal searchValue As String)
        FileOpen(7, "Components.dat", OpenMode.Random, , , Len(component_record))
        Dim temp_record_compare As Integer = LOF(7) / Len(component_record)
        Dim low As Integer
        low = 0
        Dim high As Integer
        high = temp_record_compare
        Dim i As Integer = 1
        Do While low <= high
            i = Math.Ceiling((low + high) / 2)
            FileGet(7, component_record, i)
            If searchValue = component_record.component_id Then
                FileClose(7)
                Return True
                Exit Do
            ElseIf searchValue < component_record.component_id Then
                high = (i - 1)
            Else
                low = (i + 1)
            End If
        Loop
        FileClose(7)
        Return False
    End Function
    Public Function checkLocationRecord(ByVal searchValue As String)
        FileOpen(7, "Locations.dat", OpenMode.Random, , , Len(location_record))
        Dim temp_record_compare As Integer = LOF(7) / Len(location_record)
        Dim low As Integer
        low = 0
        Dim high As Integer
        high = temp_record_compare
        Dim i As Integer = 1
        Do While low <= high
            i = Math.Ceiling((low + high) / 2)
            FileGet(7, location_record, i)
            If searchValue = location_record.location_id Then
                FileClose(7)
                Return True
                Exit Do
            ElseIf searchValue < location_record.location_id Then
                high = (i - 1)
            Else
                low = (i + 1)
            End If
        Loop
        FileClose(7)
        MsgBox("Error: This Record Could Not Be Found.")
        Return False
    End Function
    Public Function checkComponentLocationRecord(ByVal searchValueComp As String, ByVal searchValueLocation As String)
        FileOpen(7, "ComponentLocation.dat", OpenMode.Random, , , Len(component_location_record))
        Dim temp_record_compare As Integer = LOF(7) / Len(component_location_record)
        Dim low As Integer
        low = 0
        Dim high As Integer
        high = temp_record_compare
        Dim i As Integer = 1
        Do While low <= high
            i = Math.Ceiling((low + high) / 2)
            FileGet(7, component_location_record, i)
            If searchValueComp = component_location_record.component_id Then
                FileClose(7)
                Exit Do
            ElseIf searchValueComp < component_location_record.component_id Then
                high = (i - 1)
            Else
                low = (i + 1)
            End If
        Loop
        Dim x As Integer = i
        FileClose(7)
        FileOpen(7, "ComponentLocation.dat", OpenMode.Random, , , Len(component_location_record))
        For x = i To 1 Step -1
            FileGet(7, component_location_record, x)
            If component_location_record.component_id <> CInt(searchValueComp.TrimEnd(" ")) Then
                Exit For
            End If
        Next
        x += 1
        FileClose(7)
        FileOpen(7, "ComponentLocation.dat", OpenMode.Random, , , Len(component_location_record))
        'first instance of product in loop
        For m = x To temp_record_compare
            FileGet(7, component_location_record, m)
            If component_location_record.component_id = CInt(searchValueComp) And component_location_record.location_id = CInt(searchValueLocation) Then
                FileClose(7)
                Return True
            End If
        Next
        MsgBox("Error: This Record Could Not Be Found.")
        FileClose(7)
        Return False
    End Function
    Public Function checkProductComponentRecord(ByVal searchValueProduct As String, ByVal searchValueComp As String)
        FileOpen(7, "ProductComponent.dat", OpenMode.Random, , , Len(product_component_record))
        Dim temp_record_compare As Integer = LOF(7) / Len(product_component_record)
        Dim low As Integer
        low = 0
        Dim high As Integer
        high = temp_record_compare
        Dim i As Integer = 1
        Do While low <= high
            i = Math.Ceiling((low + high) / 2)
            FileGet(7, product_component_record, i)
            If searchValueProduct = product_component_record.product_id Then
                FileClose(7)
                Exit Do
            ElseIf searchValueProduct < product_component_record.product_id Then
                high = (i - 1)
            Else
                low = (i + 1)
            End If
        Loop
        Dim x As Integer = i
        FileClose(7)
        FileOpen(7, "ProductComponent.dat", OpenMode.Random, , , Len(product_component_record))
        For x = i To 1 Step -1
            FileGet(7, product_component_record, x)
            If product_component_record.product_id <> CInt(searchValueProduct.TrimEnd(" ")) Then
                Exit For
            End If
        Next
        x += 1
        FileClose(7)
        FileOpen(7, "ProductComponent.dat", OpenMode.Random, , , Len(product_component_record))
        'first instance of product in loop
        For m = x To temp_record_compare
            FileGet(7, product_component_record, m)
            If product_component_record.product_id = CInt(searchValueProduct) And product_component_record.component_id = CInt(searchValueComp) Then
                FileClose(7)
                Return True
            End If
        Next
        MsgBox("Error: This Record Could Not Be Found.")
        FileClose(7)
        Return False
    End Function
    Public Function getProductComponentRecordNumber(ByVal searchValueProduct As String, ByVal searchValueComp As String)
        FileOpen(7, "ProductComponent.dat", OpenMode.Random, , , Len(product_component_record))
        Dim temp_record_compare As Integer = LOF(7) / Len(product_component_record)
        Dim low As Integer
        low = 0
        Dim high As Integer
        high = temp_record_compare
        Dim i As Integer = 1
        Do While low <= high
            i = Math.Ceiling((low + high) / 2)
            FileGet(7, product_component_record, i)
            If searchValueProduct = product_component_record.product_id Then
                FileClose(7)
                Exit Do
            ElseIf searchValueProduct < product_component_record.product_id Then
                high = (i - 1)
            Else
                low = (i + 1)
            End If
        Loop
        Dim x As Integer = i
        FileClose(7)
        FileOpen(7, "ProductComponent.dat", OpenMode.Random, , , Len(product_component_record))
        For x = i To 1 Step -1
            FileGet(7, product_component_record, x)
            If product_component_record.product_id <> CInt(searchValueProduct.TrimEnd(" ")) Then
                Exit For
            End If
        Next
        x += 1
        FileClose(7)
        FileOpen(7, "ProductComponent.dat", OpenMode.Random, , , Len(product_component_record))
        'first instance of product in loop
        For m = x To temp_record_compare
            FileGet(7, product_component_record, m)
            If product_component_record.product_id = CInt(searchValueProduct) And product_component_record.component_id = CInt(searchValueComp) Then
                FileClose(7)
                Return m
            End If
        Next
        MsgBox("Error: This Record Could Not Be Found.")
        FileClose(7)
        Return -1
    End Function
    Public Function getComponentLocationRecordNumber(ByVal searchValueComp As String, ByVal searchValueLocation As String)
        FileOpen(7, "ComponentLocation.dat", OpenMode.Random, , , Len(component_location_record))
        Dim temp_record_compare As Integer = LOF(7) / Len(component_location_record)
        Dim low As Integer
        low = 0
        Dim high As Integer
        high = temp_record_compare
        Dim i As Integer = 1
        Do While low <= high
            i = Math.Ceiling((low + high) / 2)
            FileGet(7, component_location_record, i)
            If searchValueComp = component_location_record.component_id Then
                FileClose(7)
                Exit Do
            ElseIf searchValueComp < component_location_record.component_id Then
                high = (i - 1)
            Else
                low = (i + 1)
            End If
        Loop
        Dim x As Integer = i
        FileClose(7)
        FileOpen(7, "ComponentLocation.dat", OpenMode.Random, , , Len(component_location_record))
        For x = i To 1 Step -1
            FileGet(7, component_location_record, x)
            If component_location_record.component_id <> CInt(searchValueComp.TrimEnd(" ")) Then
                Exit For
            End If
        Next
        x += 1
        FileClose(7)
        FileOpen(7, "ComponentLocation.dat", OpenMode.Random, , , Len(component_location_record))
        'first instance of product in loop
        For m = x To temp_record_compare
            FileGet(7, component_location_record, m)
            If component_location_record.component_id = CInt(searchValueComp) And component_location_record.location_id = CInt(searchValueLocation) Then
                FileClose(7)
                Return m
            End If
        Next
        MsgBox("Error: This Record Could Not Be Found.")
        FileClose(7)
        Return -1
    End Function

    Sub clean_files()
        clean_file("Components")
        clean_file("Products")
        clean_file("ComponentLocations")
        clean_file("Locations")
        clean_file("ProductComponents")
        clean_file("Jobs")
    End Sub

    Sub clean_file(ByVal file As String)
        frmCleanFiles.lstCleanFiles.Items.Add("File Cleaning: " & file)
        Select Case file
            Case "Products"
                FileOpen(4, "Products.dat", OpenMode.Random, , , Len(product_record))
                Dim i As Integer
                Dim NumOfNewRecords As Integer
                Dim TempFilePath As String = "\Temp.dat"
                FileOpen(9, TempFilePath, OpenMode.Random, , , Len(product_record))
                NumOfNewRecords = 1
                For i = 1 To (LOF(4) / Len(product_record))
                    FileGet(4, product_record, i)
                    If Trim(product_record.product_id) <= 0 Or Trim(product_record.product_code) = String.Empty Or Trim(product_record.product_code) = String.Empty Then
                        frmCleanFiles.lstCleanFiles.Items.Add(" File Record Cleaned: " & i)
                    Else
                        FilePut(9, product_record, NumOfNewRecords)
                        NumOfNewRecords += 1
                    End If
                Next i
                FileClose(4)
                FileClose(9)
                Kill("Products.dat")
                FileCopy(TempFilePath, "Products.dat")
                Kill(TempFilePath)
            Case "Components"
                FileOpen(4, "components.dat", OpenMode.Random, , , Len(component_record))
                Dim i As Integer
                Dim NumOfNewRecords As Integer
                Dim TempFilePath As String = "\Temp.dat"
                FileOpen(9, TempFilePath, OpenMode.Random, , , Len(component_record))
                NumOfNewRecords = 1
                For i = 1 To (LOF(4) / Len(component_record))
                    FileGet(4, component_record, i)
                    If Trim(component_record.component_id) <= 0 Or Trim(component_record.component_code) = String.Empty Or Trim(component_record.component_code) = String.Empty Then
                        frmCleanFiles.lstCleanFiles.Items.Add(" File Record Cleaned: " & i)
                    Else
                        FilePut(9, component_record, NumOfNewRecords)
                        NumOfNewRecords += 1
                    End If
                Next i
                FileClose(4)
                FileClose(9)
                Kill("components.dat")
                FileCopy(TempFilePath, "components.dat")
                Kill(TempFilePath)
            Case "ComponentLocations"
                FileOpen(4, "ComponentLocation.dat", OpenMode.Random, , , Len(component_location_record))
                Dim i As Integer
                Dim NumOfNewRecords As Integer
                Dim TempFilePath As String = "\Temp.dat"
                FileOpen(9, TempFilePath, OpenMode.Random, , , Len(component_location_record))
                NumOfNewRecords = 1
                For i = 1 To (LOF(4) / Len(component_location_record))
                    FileGet(4, component_location_record, i)
                    If Trim(component_location_record.component_id) <= 0 Or Trim(component_location_record.location_id) <= 0 Then
                        frmCleanFiles.lstCleanFiles.Items.Add(" File Record Cleaned: " & i)
                    Else
                        FilePut(9, component_location_record, NumOfNewRecords)
                        NumOfNewRecords += 1
                    End If
                Next i
                FileClose(4)
                FileClose(9)
                Kill("ComponentLocation.dat")
                FileCopy(TempFilePath, "ComponentLocation.dat")
                Kill(TempFilePath)
            Case "Locations"
                FileOpen(4, "Locations.dat", OpenMode.Random, , , Len(location_record))
                Dim i As Integer
                Dim NumOfNewRecords As Integer
                Dim TempFilePath As String = "\Temp.dat"
                FileOpen(9, TempFilePath, OpenMode.Random, , , Len(location_record))
                NumOfNewRecords = 1
                For i = 1 To (LOF(4) / Len(location_record))
                    FileGet(4, location_record, i)
                    If Trim(location_record.location_id) <= 0 Then
                        frmCleanFiles.lstCleanFiles.Items.Add(" File Record Cleaned: " & i)
                    Else
                        FilePut(9, location_record, NumOfNewRecords)
                        NumOfNewRecords += 1
                    End If
                Next i
                FileClose(4)
                FileClose(9)
                Kill("Locations.dat")
                FileCopy(TempFilePath, "Locations.dat")
                Kill(TempFilePath)
            Case "ProductComponents"
                FileOpen(4, "ProductComponent.dat", OpenMode.Random, , , Len(product_component_record))
                Dim i As Integer
                Dim NumOfNewRecords As Integer
                Dim TempFilePath As String = "\Temp.dat"
                FileOpen(9, TempFilePath, OpenMode.Random, , , Len(product_component_record))
                NumOfNewRecords = 1
                For i = 1 To (LOF(4) / Len(product_component_record))
                    FileGet(4, product_component_record, i)
                    If Trim(product_component_record.component_id) <= 0 Or Trim(product_component_record.product_id) <= 0 Then
                        frmCleanFiles.lstCleanFiles.Items.Add(" File Record Cleaned: " & i)
                    Else
                        FilePut(9, product_component_record, NumOfNewRecords)
                        NumOfNewRecords += 1
                    End If
                Next i
                FileClose(4)
                FileClose(9)
                Kill("ProductComponent.dat")
                FileCopy(TempFilePath, "ProductComponent.dat")
                Kill(TempFilePath)
            Case "Jobs"
                FileOpen(4, "Jobs.dat", OpenMode.Random, , , Len(job_record))
                Dim i As Integer
                Dim NumOfNewRecords As Integer
                Dim TempFilePath As String = "\Temp.dat"
                FileOpen(9, TempFilePath, OpenMode.Random, , , Len(job_record))
                NumOfNewRecords = 1
                For i = 1 To (LOF(4) / Len(job_record))
                    FileGet(4, job_record, i)
                    If Trim(job_record.job_id) < 0 Then
                        frmCleanFiles.lstCleanFiles.Items.Add(" File Record Cleaned: " & i)
                    Else
                        FilePut(9, job_record, NumOfNewRecords)
                        NumOfNewRecords += 1
                    End If
                Next i
                FileClose(4)
                FileClose(9)
                Kill("Jobs.dat")
                FileCopy(TempFilePath, "Jobs.dat")
                Kill(TempFilePath)
        End Select
    End Sub
    Sub saveToProduction(ByVal compOrProduct As String, ByVal arrayToAdd(,) As String)
        FileOpen(1, "ProductCreationLog.dat", OpenMode.Random, , , Len(product_trend_record))
        FileOpen(2, "ComponentCreationLog.dat", OpenMode.Random, , , Len(component_trend_record))
        If compOrProduct = "Component" Then
            For i = 0 To (arrayToAdd.Length / 2) - 1
                If arrayToAdd(i, 0) <> String.Empty Then
                    component_trend_record.ID = arrayToAdd(i, 0)
                    component_trend_record.dateOutput = Now.ToString(Format("dd/MM/yyyy hh:mm:ss"))
                    component_trend_record.Quantity = arrayToAdd(i, 1)
                    Dim lengthoffile As Integer = (LOF(2) / Len(component_trend_record) + 1)
                    FilePut(2, component_trend_record, lengthoffile)
                End If
            Next
        Else
            For i = 0 To (arrayToAdd.Length / 2) - 1
                If arrayToAdd(i, 0) <> String.Empty Then
                    product_trend_record.ID = arrayToAdd(i, 0)
                    product_trend_record.dateOutput = Now.ToString(Format("dd/MM/yyyy hh:mm:ss"))
                    product_trend_record.Quantity = arrayToAdd(i, 1)
                    Dim lengthoffile As Integer = (LOF(1) / Len(product_trend_record) + 1)
                    FilePut(1, product_trend_record, lengthoffile)
                End If
            Next
        End If
        FileClose(1)
        FileClose(2)
    End Sub
End Module
