Public Class frmFrequencyReports
    Dim list_reportContents As New List(Of String)
    Private Sub frmFrequencyReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updatefromlist()
    End Sub

    Private Sub checkMostComp_CheckedChanged(sender As Object, e As EventArgs) Handles checkMostComp.CheckedChanged
        If checkMostComp.Checked Then
            list_reportContents.Add("Most Common Component")
        Else
            list_reportContents.Remove("Most Common Component")
        End If
        updatefromlist()
    End Sub

    Private Sub checkMostProd_CheckedChanged(sender As Object, e As EventArgs) Handles checkMostProd.CheckedChanged
        If checkMostProd.Checked Then
            list_reportContents.Add("Most Common Product")
        Else
            list_reportContents.Remove("Most Common Product")
        End If
        updatefromlist()
    End Sub

    Private Sub checkMostJob_CheckedChanged(sender As Object, e As EventArgs) Handles checkMostJob.CheckedChanged
        If checkMostJob.Checked Then
            list_reportContents.Add("Most Common Job")
        Else
            list_reportContents.Remove("Most Common Job")
        End If
        updatefromlist()
    End Sub

    Private Sub checkCompOutput_CheckedChanged(sender As Object, e As EventArgs) Handles checkCompOutput.CheckedChanged
        If checkCompOutput.Checked Then
            list_reportContents.Add("View All Components")
        Else
            list_reportContents.Remove("View All Components")
        End If
        updatefromlist()
    End Sub

    Private Sub checkProdOutput_CheckedChanged(sender As Object, e As EventArgs) Handles checkProdOutput.CheckedChanged
        If checkProdOutput.Checked Then
            list_reportContents.Add("View All Products")
        Else
            list_reportContents.Remove("View All Products")
        End If
        updatefromlist()
    End Sub

    Private Sub checkLocationOutput_CheckedChanged(sender As Object, e As EventArgs) Handles checkLocationOutput.CheckedChanged
        If checkLocationOutput.Checked Then
            list_reportContents.Add("View All Locations")
        Else
            list_reportContents.Remove("View All Locations")
        End If
        updatefromlist()
    End Sub

    Private Sub checkJobOutput_CheckedChanged(sender As Object, e As EventArgs) Handles checkJobOutput.CheckedChanged
        If checkJobOutput.Checked Then
            list_reportContents.Add("View All Jobs")
        Else
            list_reportContents.Remove("View All Jobs")
        End If
        updatefromlist()
    End Sub

    Private Sub check_comp_production_CheckedChanged(sender As Object, e As EventArgs) Handles check_comp_production.CheckedChanged
        If check_comp_production.Checked Then
            list_reportContents.Add("Component - Production Report")
        Else
            list_reportContents.Remove("Component - Production Report")
        End If
        updatefromlist()
    End Sub

    Private Sub check_prod_production_CheckedChanged(sender As Object, e As EventArgs) Handles check_prod_production.CheckedChanged
        If check_prod_production.Checked Then
            list_reportContents.Add("Product - Production Report")
        Else
            list_reportContents.Remove("Product - Production Report")
        End If
        updatefromlist()
    End Sub

    Private Sub checkTotalProd_CheckedChanged(sender As Object, e As EventArgs) Handles checkTotalProd.CheckedChanged
        If checkTotalProd.Checked Then
            list_reportContents.Add("Total Products")
        Else
            list_reportContents.Remove("Total Products")
        End If
        updatefromlist()
    End Sub

    Private Sub check_totalComponents_CheckedChanged(sender As Object, e As EventArgs) Handles check_totalComponents.CheckedChanged
        If check_totalComponents.Checked Then
            list_reportContents.Add("Total Components")
        Else
            list_reportContents.Remove("Total Components")
        End If
        updatefromlist()
    End Sub

    Sub updatefromlist()
        Dim comp_total As Integer
        Dim prod_total As Integer
        Dim comp_counter As New Dictionary(Of Integer, Integer)
        Dim prod_counter As New Dictionary(Of Integer, Integer)
        Dim biggest_jobID As New Integer
        Dim biggest_jobCount As New Integer
        preview.Items.Clear()
        preview.Items.Add("______________________________________________________")
        preview.Items.Add("")
        preview.Items.Add("            Eaton Manafacturing Utility              ")
        preview.Items.Add("                   Complex Report                ")
        preview.Items.Add("                 " & Now)
        preview.Items.Add(System.Environment.UserName.PadLeft(Math.Ceiling(35 - (Len(System.Environment.UserName) / 2))))
        preview.Items.Add("")
        preview.Items.Add("======================================================")
        preview.Items.Add(" Contents:")
        preview.Items.Add("======================================================")
        For i = 0 To list_reportContents.Count - 1
            preview.Items.Add(" " & (i + 1).ToString("D2") & "     " & list_reportContents(i))
        Next
        If list_reportContents.Count = 0 Then
            preview.Items.Add("  #     Select An Item To Produce A Report")
        End If
        preview.Items.Add("======================================================")
        preview.Items.Add("")
        preview.Items.Add("______________________________________________________")
        For i = 0 To list_reportContents.Count - 1
            Select Case list_reportContents(i)
                Case "Total Components"
                    FileOpen(2, "ComponentCreationLog.dat", OpenMode.Random, , , Len(component_trend_record))
                    If LOF(2) / Len(component_trend_record) = 0 Then
                    Else
                        For h = 1 To LOF(2) / Len(component_trend_record)
                            FileGet(2, component_trend_record, h)
                            comp_total += component_trend_record.Quantity
                        Next
                    End If
                    FileClose(2)
                    preview.Items.Add(" " & (i + 1).ToString("D2") & "     " & list_reportContents(i))
                    preview.Items.Add("______________________________________________________")
                    preview.Items.Add("     Total Components Produced = " & comp_total)
                    preview.Items.Add("______________________________________________________")
                Case "Total Products"
                    FileOpen(2, "productCreationLog.dat", OpenMode.Random, , , Len(product_trend_record))
                    If LOF(2) / Len(product_trend_record) = 0 Then
                    Else
                        For h = 1 To LOF(2) / Len(product_trend_record)
                            FileGet(2, product_trend_record, h)
                            prod_total += product_trend_record.Quantity
                        Next
                    End If
                    FileClose(2)
                    preview.Items.Add(" " & (i + 1).ToString("D2") & "     " & list_reportContents(i))
                    preview.Items.Add("______________________________________________________")
                    preview.Items.Add("     Total products Produced = " & prod_total)
                    preview.Items.Add("______________________________________________________")
                Case "Product - Production Report"
                    preview.Items.Add(" " & (i + 1).ToString("D2") & "     " & list_reportContents(i))
                    preview.Items.Add("______________________________________________________")
                    preview.Items.Add("     ID    Date Of Production    Quantity")
                    preview.Items.Add("     --    ------------------    --------")
                    FileOpen(1, "ProductCreationLog.dat", OpenMode.Random, , , Len(product_trend_record))
                    If LOF(1) / Len(product_trend_record) = 0 Then
                    Else
                        For p = 1 To LOF(1) / Len(product_trend_record)
                            FileGet(1, product_trend_record, p)
                            preview.Items.Add("     " & product_trend_record.ID.ToString("D3") & "   " & product_trend_record.dateOutput & "   " & product_trend_record.Quantity.ToString("D3"))
                        Next
                    End If
                    FileClose(1)
                    preview.Items.Add("______________________________________________________")
                Case "Component - Production Report"
                    preview.Items.Add(" " & (i + 1).ToString("D2") & "     " & list_reportContents(i))
                    preview.Items.Add("______________________________________________________")
                    preview.Items.Add("     ID    Date Of Production    Quantity")
                    preview.Items.Add("     --    ------------------    --------")
                    FileOpen(1, "componentCreationLog.dat", OpenMode.Random, , , Len(component_trend_record))
                    If LOF(1) / Len(component_trend_record) = 0 Then
                    Else
                        For p = 1 To LOF(1) / Len(component_trend_record)
                            FileGet(1, component_trend_record, p)
                            preview.Items.Add("     " & component_trend_record.ID.ToString("D3") & "   " & component_trend_record.dateOutput & "   " & component_trend_record.Quantity.ToString("D3"))
                        Next
                    End If
                    FileClose(1)
                    preview.Items.Add("______________________________________________________")
                Case "View All Jobs"
                    preview.Items.Add(" " & (i + 1).ToString("D2") & "     " & list_reportContents(i))
                    preview.Items.Add("______________________________________________________")
                    FileOpen(2, "Jobs.dat", OpenMode.Random, , , Len(job_record))
                    If LOF(2) / Len(job_record) = 0 Then
                    Else
                        For h = 1 To LOF(2) / Len(job_record)
                            FileGet(2, job_record, h)
                            preview.Items.Add(" Job ID: " & job_record.job_id)
                            preview.Items.Add("     Name:         " & job_record.job_name)
                            preview.Items.Add("     Date Created: " & job_record.job_date_created)
                            preview.Items.Add("     Username:     " & job_record.job_username)
                            preview.Items.Add("     Pinned:       " & job_record.job_pinned)
                            preview.Items.Add("     Count:        " & job_record.job_count)
                        Next
                    End If
                    FileClose(2)
                    preview.Items.Add("______________________________________________________")
                Case "View All Locations"
                    preview.Items.Add(" " & (i + 1).ToString("D2") & "     " & list_reportContents(i))
                    preview.Items.Add("______________________________________________________")
                    FileOpen(2, "Locations.dat", OpenMode.Random, , , Len(location_record))
                    If LOF(2) / Len(location_record) = 0 Then
                    Else
                        For h = 1 To LOF(2) / Len(location_record)
                            FileGet(2, location_record, h)
                            preview.Items.Add("Location ID: " & location_record.location_id)
                            preview.Items.Add("     Name:         " & location_record.location_desc.TrimEnd)
                        Next
                    End If
                    FileClose(2)
                    preview.Items.Add("______________________________________________________")
                Case "View All Products"
                    preview.Items.Add(" " & (i + 1).ToString("D2") & "     " & list_reportContents(i))
                    preview.Items.Add("______________________________________________________")
                    FileOpen(2, "products.dat", OpenMode.Random, , , Len(product_record))
                    If LOF(2) / Len(product_record) = 0 Then
                    Else
                        For h = 1 To LOF(2) / Len(product_record)
                            FileGet(2, product_record, h)
                            preview.Items.Add(" Product ID: " & product_record.product_id)
                            preview.Items.Add("         Code:         " & product_record.product_code)
                            preview.Items.Add("         Description:  " & product_record.product_desc)
                        Next
                    End If
                    FileClose(2)
                    preview.Items.Add("______________________________________________________")
                Case "View All Components"
                    preview.Items.Add(" " & (i + 1).ToString("D2") & "     " & list_reportContents(i))
                    preview.Items.Add("______________________________________________________")
                    FileOpen(2, "components.dat", OpenMode.Random, , , Len(component_record))
                    If LOF(2) / Len(component_record) = 0 Then
                    Else
                        For h = 1 To LOF(2) / Len(component_record)
                            FileGet(2, component_record, h)
                            preview.Items.Add(" Component ID: " & component_record.component_id)
                            preview.Items.Add("        Code:         " & component_record.component_code)
                            preview.Items.Add("        Description:  " & component_record.component_desc)
                        Next
                    End If
                    FileClose(2)
                    preview.Items.Add("______________________________________________________")
                Case "Most Common Job"
                    preview.Items.Add(" " & (i + 1).ToString("D2") & "     " & list_reportContents(i))
                    preview.Items.Add("______________________________________________________")
                    FileOpen(2, "Jobs.dat", OpenMode.Random, , , Len(job_record))
                    If LOF(2) / Len(job_record) = 0 Then
                    Else
                        For h = 1 To LOF(2) / Len(job_record)
                            FileGet(2, job_record, h)
                            If job_record.job_count > biggest_jobCount Then
                                biggest_jobID = job_record.job_id
                                biggest_jobCount = job_record.job_count
                            End If
                        Next
                    End If
                    FileClose(2)
                    Try
                        job_record = getJobRecord(biggest_jobID)
                        preview.Items.Add(StrConv(job_record.job_name.TrimEnd, VbStrConv.ProperCase) & " has the largest count with a value of " & job_record.job_count & ".")
                        preview.Items.Add(" Job ID: " & job_record.job_id)
                        preview.Items.Add("         Name:         " & job_record.job_name)
                        preview.Items.Add("         Date Created: " & job_record.job_date_created)
                        preview.Items.Add("         Username:     " & job_record.job_username)
                        preview.Items.Add("         Pinned:       " & job_record.job_pinned)
                        preview.Items.Add("         Count:        " & job_record.job_count)
                        preview.Items.Add("______________________________________________________")
                    Catch ex As Exception
                        preview.Items.Add("Currently no jobs have been created.")
                        preview.Items.Add("______________________________________________________")
                    End Try

                Case "Most Common Product"
                    preview.Items.Add(" " & (i + 1).ToString("D2") & "     " & list_reportContents(i))
                    preview.Items.Add("______________________________________________________")
                    FileOpen(1, "ProductCreationLog.dat", OpenMode.Random, , , Len(product_trend_record))
                    If LOF(1) / Len(product_trend_record) = 0 Then
                    Else
                        For p = 1 To LOF(1) / Len(product_trend_record)
                            FileGet(1, product_trend_record, p)
                            If prod_counter.ContainsKey(product_trend_record.ID) Then
                                prod_counter.Item(product_trend_record.ID) += product_trend_record.Quantity
                            Else
                                prod_counter.Add(product_trend_record.ID, product_trend_record.Quantity)
                            End If
                        Next
                    End If
                    FileClose(1)
                    Dim sorted = From pair In prod_counter Order By pair.Value
                    Dim sortedDictionary = sorted.ToDictionary(Function(p) p.Key, Function(p) p.Value)
                    product_record = getProductRecord(sortedDictionary.Keys.Last())
                    preview.Items.Add(" ID #" & product_record.product_id & " has a production value of " & sortedDictionary.Values.Last() & ".")
                    preview.Items.Add(" Product ID: " & product_record.product_id)
                    preview.Items.Add("       Code:         " & product_record.product_code.TrimEnd)
                    preview.Items.Add("       Description:  " & product_record.product_desc.TrimEnd)
                    preview.Items.Add("______________________________________________________")
                Case "Most Common Component"
                    preview.Items.Add(" " & (i + 1).ToString("D2") & "     " & list_reportContents(i))
                    preview.Items.Add("______________________________________________________")
                    FileOpen(1, "ComponentCreationLog.dat", OpenMode.Random, , , Len(component_trend_record))
                    If LOF(1) / Len(component_trend_record) = 0 Then
                    Else
                        For p = 1 To LOF(1) / Len(component_trend_record)
                            FileGet(1, component_trend_record, p)
                            If comp_counter.ContainsKey(component_trend_record.ID) Then
                                comp_counter.Item(component_trend_record.ID) += component_trend_record.Quantity
                            Else
                                comp_counter.Add(component_trend_record.ID, component_trend_record.Quantity)
                            End If
                        Next
                    End If
                    FileClose(1)
                    Dim sorted = From pair In comp_counter Order By pair.Value
                    Dim sortedDictionary = sorted.ToDictionary(Function(p) p.Key, Function(p) p.Value)
                    component_record = getComponentRecord(sortedDictionary.Keys.Last())
                    preview.Items.Add(" ID #" & component_record.component_id & " has a production value of " & sortedDictionary.Values.Last() & ".")
                    preview.Items.Add(" Component ID: " & component_record.component_id)
                    preview.Items.Add("      Code:         " & component_record.component_code.TrimEnd)
                    preview.Items.Add("      Description:  " & component_record.component_desc.TrimEnd)
                    preview.Items.Add("______________________________________________________")
                Case "Job Product Relationships"
                    preview.Items.Add(" " & (i + 1).ToString("D2") & "     " & list_reportContents(i))
                    FileOpen(1, "JobProduct.dat", OpenMode.Random, , , Len(job_product_record))
                    For n = 1 To (LOF(1) / Len(job_product_record))
                        FileGet(1, job_product_record, n)
                        preview.Items.Add("______________________________________________________")
                        job_record = getJobRecord(job_product_record.job_id)
                        product_record = getProductRecord(job_product_record.product_id)
                        preview.Items.Add(" Job Name: " & job_record.job_name)
                        preview.Items.Add("      Product Description:  " & product_record.product_desc.TrimEnd)
                        preview.Items.Add("      Product Code:         " & product_record.product_code.TrimEnd)
                        preview.Items.Add("      Product ID:           " & product_record.product_id)
                        preview.Items.Add("      Quantity:             " & job_product_record.quantity)
                        preview.Items.Add("      Creation Count:       " & job_record.job_count)
                        preview.Items.Add("      Date Created:         " & job_record.job_date_created)
                        preview.Items.Add("      User:                 " & job_record.job_username)
                        preview.Items.Add("      Pinned:               " & job_record.job_pinned)
                    Next
                    FileClose(1)
                    preview.Items.Add("______________________________________________________")
                Case "Component Location Relationships"
                    preview.Items.Add(" " & (i + 1).ToString("D2") & "     " & list_reportContents(i))
                    FileOpen(1, "ComponentLocation.dat", OpenMode.Random, , , Len(component_location_record))
                    For n = 1 To (LOF(1) / Len(component_location_record))
                        FileGet(1, component_location_record, n)
                        preview.Items.Add("______________________________________________________")
                        component_record = getComponentRecord(component_location_record.component_id)
                        location_record = getLocationRecord(component_location_record.location_id)
                        preview.Items.Add(" Component Description: " & component_record.component_desc.TrimEnd)
                        preview.Items.Add("      Component Code:       " & component_record.component_code.TrimEnd)
                        preview.Items.Add("      Component ID:         " & component_record.component_id)
                        preview.Items.Add("      Location ID:          " & location_record.location_id)
                        preview.Items.Add("      Location Description: " & location_record.location_desc)
                    Next
                    FileClose(1)
                    preview.Items.Add("______________________________________________________")
                Case "Product Component Relationships"
                    preview.Items.Add(" " & (i + 1).ToString("D2") & "     " & list_reportContents(i))
                    FileOpen(1, "ProductComponent.dat", OpenMode.Random, , , Len(product_component_record))
                    For n = 1 To (LOF(1) / Len(product_component_record))
                        FileGet(1, product_component_record, n)
                        preview.Items.Add("______________________________________________________")
                        component_record = getComponentRecord(product_component_record.component_id)
                        product_record = getProductRecord(product_component_record.product_id)
                        preview.Items.Add(" Product Description: " & product_record.product_desc.TrimEnd)
                        preview.Items.Add("      Product Code:          " & product_record.product_code.TrimEnd)
                        preview.Items.Add("      Product ID:            " & product_record.product_id)
                        preview.Items.Add("      Component Description: " & component_record.component_desc.TrimEnd)
                        preview.Items.Add("      Component Code:        " & component_record.component_code.TrimEnd)
                        preview.Items.Add("      Component ID:          " & component_record.component_id)
                    Next
                    FileClose(1)
                    preview.Items.Add("______________________________________________________")
            End Select
        Next

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If checkFootnoteprompt.Checked Then
            Dim input_footnote As String = InputBox("Please Enter A String To Append To The Document:")
            If input_footnote.Length <> 0 Then
                input_footnote = input_footnote.PadLeft(Math.Ceiling(30 - (Len(input_footnote) / 2)))
                preview.Items.Add("======================================================")
                preview.Items.Add(input_footnote)
                preview.Items.Add("======================================================")
            End If
        End If
        saveFile.Filter = "Text Files Only|*.txt"
        If saveFile.ShowDialog() = DialogResult.OK Then
            Dim sb As New System.Text.StringBuilder()
            For Each o As Object In preview.Items
                sb.AppendLine(o)
            Next
            System.IO.File.WriteAllText(saveFile.FileName, sb.ToString())
            If vbYes = MsgBox("Would You Like To View The Report After Saving?", vbYesNo, "Open:") Then
                If System.IO.File.Exists(saveFile.FileName) = True Then
                    Process.Start(saveFile.FileName)
                Else
                    MsgBox("File Does Not Exist")
                End If
            Else
            End If
            preview.Items.Clear()
        End If
        checkCompOutput.Checked = False
        checkJobOutput.Checked = False
        checkProdOutput.Checked = False
        checkLocationOutput.Checked = False
        checkMostComp.Checked = False
        checkMostProd.Checked = False
        checkMostJob.Checked = False
        checkTotalProd.Checked = False
        check_totalComponents.Checked = False
        check_prod_production.Checked = False
        check_comp_production.Checked = False
        checkFootnoteprompt.Checked = False
    End Sub

    Private Sub checkJobProduct_CheckedChanged(sender As Object, e As EventArgs) Handles checkJobProduct.CheckedChanged
        If checkJobProduct.Checked Then
            list_reportContents.Add("Job Product Relationships")
        Else
            list_reportContents.Remove("Job Product Relationships")
        End If
        updatefromlist()
    End Sub

    Private Sub checkProductComponent_CheckedChanged(sender As Object, e As EventArgs) Handles checkProductComponent.CheckedChanged
        If checkProductComponent.Checked Then
            list_reportContents.Add("Product Component Relationships")
        Else
            list_reportContents.Remove("Product Component Relationships")
        End If
        updatefromlist()
    End Sub

    Private Sub checkCompLoca_CheckedChanged(sender As Object, e As EventArgs) Handles checkCompLoca.CheckedChanged
        If checkCompLoca.Checked Then
            list_reportContents.Add("Component Location Relationships")
        Else
            list_reportContents.Remove("Component Location Relationships")
        End If
        updatefromlist()
    End Sub
End Class