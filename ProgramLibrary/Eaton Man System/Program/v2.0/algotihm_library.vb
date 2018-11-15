Imports System.IO
Imports Word = Microsoft.Office.Interop.Word
Imports Excel = Microsoft.Office.Interop.Excel
Module algotihm_library
    Public Function FilenameIsOK(ByVal fileName As String) As Boolean
        Dim file As String = Path.GetFileName(fileName)
        Dim directory As String = Path.GetDirectoryName(fileName)
        Return Not (file.Intersect(Path.GetInvalidFileNameChars()).Any() OrElse directory.Intersect(Path.GetInvalidPathChars()).Any())
    End Function

    Public Sub MergeSort(ByVal ar() As Integer)
        DoMergeSort(ar, 0, ar.Length - 1)
    End Sub

    Private Sub DoMergeSort(ByVal ar() As Integer, ByVal low As Integer, ByVal high As Integer)
        If low >= high Then Return
        Dim length As Integer = high - low + 1
        Dim middle As Integer = Math.Floor((low + high) / 2)
        DoMergeSort(ar, low, middle)
        DoMergeSort(ar, middle + 1, high)
        Dim temp(ar.Length - 1) As Integer
        For i As Integer = 0 To length - 1
            temp(i) = ar(low + i)
        Next
        Dim m1 As Integer = 0
        Dim m2 As Integer = middle - low + 1
        For i As Integer = 0 To length - 1
            If m2 <= high - low Then
                If m1 <= middle - low Then
                    If temp(m1) > temp(m2) Then
                        ar(i + low) = temp(m2)
                        m2 += 1
                    Else
                        ar(i + low) = temp(m1)
                        m1 += 1
                    End If
                Else
                    ar(i + low) = temp(m2)
                    m2 += 1
                End If
            Else
                ar(i + low) = temp(m1)
                m1 += 1
            End If
        Next
    End Sub

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
        Dim oPic As Word.InlineShape
        oPic = wd.InlineShapes.AddPicture(FileName:="E:\Coursework\Program\v2.0\bin\Debug\Sources\EATON_logo.jpg", LinkToFile:=False, SaveWithDocument:=True)
        oPic.Height = 10
        oPic.Width = 10
        Dim rng As Word.Range = wd.Range(0, 0)
        rng.InsertBefore("Eaton Manufacturing Utility: Component Output")
        rng.InsertParagraphAfter()
        rng.Font.Name = "Verdana"
        rng.Font.Size = 16
        rng.InsertParagraphAfter()
        rng.InsertParagraphAfter()
        rng.SetRange(rng.End, rng.End)

        ' Add the table.
        wd.Tables.Add(
    Range:=rng,
    NumRows:=1, NumColumns:=3)
        Dim tbl As Word.Table = wd.Tables(1)
        tbl.Range.Font.Size = 8
        tbl.Range.Font.Name = "Verdana"
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
        xlWorkBook.SaveAs(FileLocation, Excel.XlFileFormat.xlWorkbookNormal, misvalue, misvalue, misvalue, misvalue, Excel.XlSaveAsAccessMode.xlExclusive, misvalue, misvalue, misvalue, misvalue, misvalue)
        xlWorkBook.Close(True, misvalue, misvalue)
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
End Module
