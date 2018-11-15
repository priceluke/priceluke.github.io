Imports System.ComponentModel
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frm_importFromExcel
    Dim app As New Excel.Application
    Dim worksheet_products, worksheet_components, worksheet_product_components, worksheet_locations, worksheet_component_locations As Excel.Worksheet
    Dim workbook As Excel.Workbook
    Public num_products, num_components, num_productcomponents, num_locations, num_componentlocations As Integer
    Dim excellocation As String
    Private Sub frm_importFromExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = CurDir() & "\Values.xlsx"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As Integer = MessageBox.Show("Warning: Executing This Action Will Result In All Current Records Being Formatted." & vbNewLine & "Would You Like To Continue?", "", MessageBoxButtons.YesNo)
        excellocation = TextBox1.Text
        If result = DialogResult.Yes Then
            Try
                workbook = app.Workbooks.Open(excellocation)
                frmMenu.remove_files()
                workbook.Save()
                workbook.Close()
                import()
            Catch ec As Exception
                MsgBox("File does not exist. Closing" & vbNewLine & ec.ToString)
                Me.Close()
            End Try
        Else
            Me.Hide()
            frmMenu.Focus()
        End If
    End Sub

    Private Sub frm_importFromExcel_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        workbook.Save()
        workbook.Close()
        app.Quit()
    End Sub
    Sub import()
        workbook = app.Workbooks.Open(excellocation)
        worksheet_products = workbook.Worksheets("Products")
        worksheet_components = workbook.Worksheets("Components")
        worksheet_product_components = workbook.Worksheets("ProductComponent")
        worksheet_component_locations = workbook.Worksheets("ComponentLocation")
        num_products = worksheet_products.UsedRange.Rows.Count
        ProductsMax.Text = "/" & num_products
        num_components = worksheet_components.UsedRange.Rows.Count
        ComponentsMax.Text = "/" & num_components
        num_productcomponents = worksheet_product_components.UsedRange.Rows.Count
        ProductComponentsMax.Text = "/" & num_productcomponents
        num_componentlocations = worksheet_component_locations.UsedRange.Rows.Count
        ComponentLocationMax.Text = "/" & num_componentlocations
        ProgressBar1.Maximum = num_products + num_components + num_locations + num_productcomponents + num_componentlocations
        '
        For a = 1 To num_products
            AddProduct(a)
            progress("Products")
        Next
        '
        For a = 1 To num_components
            AddComponent(a)
            progress("Components")
        Next
        '
        '
        For a = 1 To num_productcomponents
            AddProductComponent(a)
            progress("ProductComponent")
        Next
        '
        '
    End Sub
    Sub progress(ByVal value As String)
        ProgressBar1.Value += 1
        Select Case value
            Case "Products"
                ProductProgress.Text += 1
            Case "Components"
                ComponentProgress.Text += 1
            Case "ComponentLocation"
                ComponentLocationProgress.Text += 1
            Case "ProductComponent"
                ProductComponentProgress.Text += 1
        End Select
    End Sub
    Sub AddProduct(ByVal a As Integer)
        FileOpen(1, "Products.dat", OpenMode.Random, , , Len(product_record))
        Dim lof_product As Integer = LOF(1) / Len(product_record)
        product_record.product_id = lof_product + 1
        product_record.product_desc = worksheet_products.Cells(a, 2).Value
        product_record.product_code = worksheet_products.Cells(a, 1).Value
        Console.WriteLine(product_record.ToString)
        FilePut(1, product_record, lof_product + 1)
        FileClose(1)
    End Sub
    Sub AddComponent(ByVal a As Integer)
        FileOpen(1, "Components.dat", OpenMode.Random, , , Len(component_record))
        Dim lof_component As Integer = LOF(1) / Len(component_record)
        component_record.component_id = lof_component + 1
        component_record.component_desc = worksheet_components.Cells(a, 2).Value
        component_record.component_code = worksheet_components.Cells(a, 1).Value
        Console.WriteLine(component_record.ToString)
        FilePut(1, component_record, lof_component + 1)
        FileClose(1)
    End Sub
    Sub AddProductComponent(ByVal a As Integer)
        FileOpen(1, "ComponentLocation.dat", OpenMode.Random, , , Len(product_component_record))
        Dim lof_product_component As Integer = LOF(1) / Len(product_component_record)
        '
        FileOpen(2, "Products.dat", OpenMode.Random, , , Len(product_record))
        If LOF(2) / Len(job_record) = 0 Then
        Else
            For i = 1 To LOF(1) / Len(product_record)
                FileGet(2, product_record, i)
                If product_record.product_code.TrimEnd(" ") = worksheet_product_components.Cells(a, 1).Value Then
                    product_component_record.product_id = product_record.product_id
                    Exit For
                End If
            Next i
        End If
        FileClose(2)
        '
        FileOpen(3, "Components.dat", OpenMode.Random, , , Len(component_record))
        If LOF(3) / Len(component_record) = 0 Then
        Else
            For i = 1 To LOF(3) / Len(component_record)
                FileGet(3, component_record, i)
                If component_record.component_code.TrimEnd(" ") = worksheet_product_components.Cells(a, 2).Value Then
                    product_component_record.component_id = component_record.component_id
                    Exit For
                End If
            Next i
        End If
        FileClose(3)
        '
        Console.WriteLine(product_component_record.ToString)
        FilePut(1, product_component_record, lof_product_component + 1)
        FileClose(1)
    End Sub
End Class

'dim app as new excel.application
'dim worksheet as excel.worksheet
'dim workbook as excel.workbook
'dim i, currentrecord as integer
'dim excellocation as string
'Structure DiverStructure
'    <VBFixedString(4)> Dim productid As Short
'    <VBFixedString(28)> Public Description As String
'    <VBFixedString(8)> Public price As Decimal
'    <VBFixedString(8)> Dim quantity As Short
'    <VBFixedString(18)> Dim recorderlevel As String
'End Structure
'Private Sub AddFromExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'    If Form1.TextBox1.Text = "" Then
'        excellocation = CurDir() & "/add.xlsx"
'    Else
'        excellocation = Form1.TextBox1.Text
'    End If
'Try
'workbook = APP.Workbooks.Open(excellocation)
'worksheet = workbook.Worksheets("sheet1")
'i = worksheet.UsedRange.Rows.Count
'Label10.Text = i.ToString
'currentrecord = 1
'Catch
'MsgBox("File does not exist; Closing")
'Me.Close()
'End Try
'End Sub

'workbook.Save()
'workbook.Close()
'APP.Quit()