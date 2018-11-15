Imports System.ComponentModel
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frm_importFromExcel
    Dim app As New Excel.Application
    Dim worksheet_products, worksheet_components, worksheet_product_components, worksheet_locations, worksheet_component_locations As Excel.Worksheet
    Dim workbook As Excel.Workbook
    Public num_products, num_components, num_productcomponents, num_locations, num_componentlocations As Integer
    Dim excellocation As String
    Dim table_products As Hashtable = New Hashtable
    Dim table_components As Hashtable = New Hashtable
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
        Try
            workbook.Save()
            workbook.Close()
        Catch
        End Try
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
        hashtable_products()
        hashtable_components()
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
        If product_record.product_code <> String.Empty Then
            FilePut(1, product_record, lof_product + 1)
        End If
        FileClose(1)
    End Sub
    Sub AddComponent(ByVal a As Integer)
        FileOpen(1, "Components.dat", OpenMode.Random, , , Len(component_record))
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
        Console.WriteLine(component_record.ToString)
        If component_record.component_code <> String.Empty Then
            FilePut(1, component_record, lof_component + 1)
        End If
        FileClose(1)
    End Sub
    Sub AddProductComponent(ByVal a As Integer)
        '
        FileOpen(1, "ProductComponent.dat", OpenMode.Random, , , Len(product_component_record))
        Dim lof_product_component As Integer = LOF(1) / Len(product_component_record)
        Dim sought_productid As Integer = table_products(worksheet_product_components.Cells(a, 1).Value)
        Dim sought_componentid As Integer = table_components(worksheet_product_components.Cells(a, 2).Value)
        Dim quantity As Integer = worksheet_product_components.Cells(a, 3).Value
        product_component_record.product_id = sought_productid
        product_component_record.component_id = sought_componentid
        product_component_record.quantity = quantity
        FilePut(1, product_component_record, lof_product_component + 1)
        FileClose(1)

        '

    End Sub
    Sub hashtable_products()
        FileOpen(1, "Products.dat", OpenMode.Random, , , Len(product_record))
        If LOF(1) / Len(job_record) = 0 Then
        Else
            For i = 1 To LOF(1) / Len(product_record)
                FileGet(1, product_record, i)
                If table_products.ContainsKey(product_record.product_code.TrimEnd(" ")) Then
                Else
                    table_products.Add(product_record.product_code.TrimEnd(" "), product_record.product_id)
                    Console.WriteLine(i & " : Added: " & product_record.product_code.TrimEnd(" ") & " : " & product_record.product_id)
                End If
            Next i
        End If
        FileClose(1)
    End Sub
    Sub hashtable_components()
        FileOpen(1, "Components.dat", OpenMode.Random, , , Len(component_record))
        If LOF(1) / Len(job_record) = 0 Then
        Else
            For i = 1 To LOF(1) / Len(component_record)
                FileGet(1, component_record, i)
                If table_components.ContainsKey(component_record.component_code.TrimEnd(" ")) Then
                Else
                    table_components.Add(component_record.component_code.TrimEnd(" "), component_record.component_id)
                    Console.WriteLine("Added: " & component_record.component_code.TrimEnd(" ") & " : " & component_record.component_id)
                End If
            Next i
        End If
        FileClose(1)
    End Sub

End Class
