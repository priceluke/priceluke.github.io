Imports System.ComponentModel

Public Class PredictionUI
    Structure log
        Dim log_date As DateTime
        <VBFixedString(7)> Dim state_change As String
    End Structure
    Public log_entry As New log
    Public prediction As New DateTime
    Public current_state As String = "OFF"
    Dim total_time As Integer
    Dim on_time As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PredictionWindowOutput.HorizontalScrollbar = True
        FileOpen(1, "LogFile.dat", OpenMode.Random, , , Len(log_entry))
        populate()
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://82.21.53.213/homeautomation/lights")
        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim sourcecode As String = sr.ReadToEnd()
        If sourcecode = "true" Then
            CurrentStateWindow.Text = ("Current State: ON")
            current_state = "ON"
        Else
            CurrentStateWindow.Text = ("Current State: OFF")
            current_state = "OFF"
        End If
    End Sub
    Sub populate()
        LogList.Items.Clear()
        For i = 1 To LOF(1) / Len(log_entry)
            FileGet(1, log_entry, i)
            LogList.Items.Add(log_entry.log_date & " : " & log_entry.state_change)
        Next
    End Sub

    Private Sub tmrLog_Tick(sender As Object, e As EventArgs) Handles tmrLog.Tick
        analytics()
        set_time()
        If EnableLoggingCheckbox.Checked Then
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://82.21.53.213/homeautomation/lights")
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
            Dim sourcecode As String = sr.ReadToEnd()
            Dim new_state_boolean As String = sourcecode
            Dim next_record As Integer = (LOF(1) / Len(log_entry)) + 1
            If new_state_boolean.ToLower = "true" Then
                CurrentStateWindow.Text = ("Current State: ON")
                If current_state = "ON" Then
                Else
                    current_state = "ON"
                    log_entry.log_date = Now
                    log_entry.state_change = "OFFTOON"
                    FilePut(1, log_entry, next_record)
                End If
            Else
                CurrentStateWindow.Text = ("Current State: OFF")
                If current_state = "ON" Then
                    current_state = "OFF"
                    log_entry.log_date = Now
                    log_entry.state_change = "ONTOOFF"
                    FilePut(1, log_entry, next_record)
                Else
                End If
            End If
            populate()
            LogList.TopIndex = LogList.Items.Count - 1
        End If

        If ActOnCalculationCheckbox.Checked And Now = prediction Then
            IFrameWebUI.Document.All("buttt").InvokeMember("click")
        End If
        If LogList.Items.Count = 0 Then
            PredictCheckbox.Enabled = False
        Else
            PredictCheckbox.Enabled = True
        End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FileClose(1)
    End Sub

    Private Sub tmrCalculate_Tick(sender As Object, e As EventArgs) Handles tmrCalculate.Tick
        If PredictCheckbox.Checked Then
            PredictionWindowOutput.Items.Clear()
            PredictionWindowCalculation.Text = String.Empty
            IFrameWebUI.Refresh()
            PredictionWindowOutput.Items.Add("Based on the current model")
            PredictionWindowOutput.Items.Add("The next prediction will be at: ")
            Dim predicted_date As DateTime = get_prediction()
            Dim time_until_prediction As TimeSpan = predicted_date - Now.AddDays(-1)
            PredictionWindowOutput.Items.Add(predicted_date)

            PredictionWindowOutput.Items.Add("And it will persist for " & Math.Round(on_time / 60, 2) & " minutes.")
            PredictionWindowOutput.Items.Add("Which is in " & time_until_prediction.Hours & " Hour(s), " & time_until_prediction.Minutes & " Minute(s) and " & time_until_prediction.Seconds & " Second(s).")
        End If
    End Sub
    Function get_prediction()
        Dim amount_of_records As Integer = LOF(1) / Len(log_entry)
        Dim array_times(amount_of_records, 1) As String
        total_time = 0
        Dim avg_ontimes As New List(Of Integer)
        Dim previous_time As New DateTime
        Dim cluster_0to4 As New List(Of DateTime)
        Dim cluster_4to8 As New List(Of DateTime)
        Dim cluster_8to12 As New List(Of DateTime)
        Dim cluster_12to16 As New List(Of DateTime)
        Dim cluster_16to20 As New List(Of DateTime)
        Dim cluster_20to24 As New List(Of DateTime)
        For i = 1 To amount_of_records
            FileGet(1, log_entry, i)

            If log_entry.state_change = "OFFTOON" Then
                If DateTime.Parse(log_entry.log_date.ToLongTimeString) < DateTime.Parse("#04:00:00#") Then
                    Console.WriteLine(log_entry.log_date.ToString("hh:mm:ss") & "Is b4 4am")
                    cluster_0to4.Add(log_entry.log_date.ToString("hh:mm:ss"))
                ElseIf DateTime.Parse(log_entry.log_date.ToLongTimeString) < DateTime.Parse("#08:00:00#") Then
                    Console.WriteLine(log_entry.log_date.ToString("hh:mm:ss") & "Is b4 8am")
                    cluster_4to8.Add(log_entry.log_date.ToString("hh:mm:ss"))
                ElseIf DateTime.Parse(log_entry.log_date.ToLongTimeString) < DateTime.Parse("#12:00:00#") Then
                    Console.WriteLine(log_entry.log_date.ToString("hh:mm:ss") & "Is b4 12am")
                    cluster_8to12.Add(log_entry.log_date.ToString("hh:mm:ss"))
                ElseIf DateTime.Parse(log_entry.log_date.ToLongTimeString) < DateTime.Parse("#16:00:00#") Then
                    Console.WriteLine(log_entry.log_date.ToString("hh:mm:ss") & "Is b4 4pm")
                    If DateTime.Parse(log_entry.log_date.ToLongTimeString).Hour = 12 Then
                        cluster_12to16.Add(log_entry.log_date.ToString("00:mm:ss"))
                    Else
                        cluster_12to16.Add(log_entry.log_date.ToString("hh:mm:ss"))
                    End If
                ElseIf DateTime.Parse(log_entry.log_date.ToLongTimeString) < DateTime.Parse("#20:00:00#") Then
                    Console.WriteLine(log_entry.log_date.ToString("hh:mm:ss") & "Is b4 8pm")
                    cluster_16to20.Add(log_entry.log_date.ToString("hh:mm:ss"))
                ElseIf DateTime.Parse(log_entry.log_date.ToLongTimeString) < DateTime.Parse("#23:59:59#") Then
                    Console.WriteLine(log_entry.log_date.ToString("hh:mm:ss") & "Is b4 12pm")
                    cluster_20to24.Add(log_entry.log_date.ToString("hh:mm:ss"))
                End If
                previous_time = log_entry.log_date
            Else
                Try
                    Dim secondsDiff As Integer = DateDiff(DateInterval.Second, previous_time, log_entry.log_date)
                    avg_ontimes.Add(secondsDiff)
                Catch ex As Exception
                    'first time set
                End Try

            End If
        Next
        For h = 0 To avg_ontimes.Count - 1
            total_time += avg_ontimes(h)
        Next

        Dim cluster_line As String = String.Empty
        Dim cluster_0to4_ticks(cluster_0to4.Count - 1) As Long
        Dim cluster_4to8_ticks(cluster_4to8.Count - 1) As Long
        Dim cluster_8to12_ticks(cluster_8to12.Count - 1) As Long
        Dim cluster_12to16_ticks(cluster_12to16.Count - 1) As Long
        Dim cluster_16to20_ticks(cluster_16to20.Count - 1) As Long
        Dim cluster_20to24_ticks(cluster_20to24.Count - 1) As Long
        For i = 0 To cluster_0to4.Count - 1
            cluster_line &= cluster_0to4(i) & "     "
            cluster_0to4_ticks(i) = Date.Parse(cluster_0to4(i)).Ticks / 1000
        Next

        Dim a As Date
        Try
            a = New Date(Math.Floor(cluster_0to4_ticks.Average) * 1000)
        Catch ex As Exception
        End Try

        cluster_line = String.Empty
        For i = 0 To cluster_4to8.Count - 1
            cluster_line &= cluster_4to8(i) & "     "
            cluster_4to8_ticks(i) = Date.Parse(cluster_4to8(i)).Ticks / 1000
        Next
        Dim b As Date
        Try
            b = New Date(Math.Floor(cluster_4to8_ticks.Average) * 1000)
        Catch
            b = New Date(0)
        End Try

        cluster_line = String.Empty
        For i = 0 To cluster_8to12.Count - 1
            cluster_line &= cluster_8to12(i) & "      "
            cluster_8to12_ticks(i) = Date.Parse(cluster_8to12(i)).Ticks / 1000
        Next
        Dim c As Date
        Try
            c = New Date(Math.Floor(cluster_8to12_ticks.Average) * 1000)
        Catch
            c = New Date(0)
        End Try

        cluster_line = String.Empty
        For i = 0 To cluster_12to16.Count - 1
            cluster_line &= cluster_12to16(i) & "     "
            cluster_12to16_ticks(i) = Date.Parse(cluster_12to16(i)).Ticks / 1000
        Next
        Dim d As Date
        Try
            d = New Date(Math.Floor(cluster_12to16_ticks.Average) * 1000)
            If d.Hour = "00" Then
                Dim ts As New TimeSpan(12, d.Minute, d.Second)
                d = d.Date + ts
            End If
        Catch
            d = New Date(0)
        End Try


        cluster_line = String.Empty
        For i = 0 To cluster_16to20.Count - 1
            cluster_line &= cluster_16to20(i) & "     "
            cluster_16to20_ticks(i) = Date.Parse(cluster_16to20(i)).Ticks / 1000
        Next
        Dim f As Date
        Try
            f = New Date(Math.Floor(cluster_16to20_ticks.Average) * 1000)
        Catch
            f = New Date(0)
        End Try

        cluster_line = String.Empty
        For i = 0 To cluster_20to24.Count - 1
            cluster_line &= cluster_20to24(i) & "     "
            cluster_20to24_ticks(i) = Date.Parse(cluster_20to24(i)).Ticks / 1000
        Next
        Dim g As Date
        Try
            g = New Date(Math.Floor(cluster_20to24_ticks.Average) * 1000)
            PredictionWindowCalculation.Text &= vbNewLine & (cluster_line & "Ticks: " & cluster_20to24_ticks.Average * 1000 & " Guessed Time: " & g)
        Catch
            g = New Date(0)
        End Try
        cluster_line = String.Empty
        PredictionWindowCalculation.Text &= ("The current average on time = " & Math.Round(total_time / avg_ontimes.Count) & " second(s).")
        PredictionWindowCalculation.Text &= vbNewLine & ("0 to 4 entries:   " & Math.Round((cluster_0to4.Count / avg_ontimes.Count) * 100) & "%")
        PredictionWindowCalculation.Text &= vbNewLine & ("4 to 8 entries:   " & Math.Round((cluster_4to8.Count / avg_ontimes.Count) * 100) & "%")
        PredictionWindowCalculation.Text &= vbNewLine & ("8 to 12 entries:  " & Math.Round((cluster_8to12.Count / avg_ontimes.Count) * 100) & "%")
        PredictionWindowCalculation.Text &= vbNewLine & ("12 to 16 entries: " & Math.Round((cluster_12to16.Count / avg_ontimes.Count) * 100) & "%")
        PredictionWindowCalculation.Text &= vbNewLine & ("16 to 20 entries: " & Math.Round((cluster_16to20.Count / avg_ontimes.Count) * 100) & "%")
        PredictionWindowCalculation.Text &= vbNewLine & ("20 to 24 entries: " & Math.Round((cluster_20to24.Count / avg_ontimes.Count) * 100) & "%")
        PredictionWindowCalculation.Text &= vbNewLine & ("Total entries =   " & avg_ontimes.Count)
        PredictionWindowCalculation.Text &= vbNewLine & ("Total time = " & total_time)
        on_time = total_time / avg_ontimes.Count
        If Now.Hour < 4 Then
            If Math.Round((cluster_0to4.Count / avg_ontimes.Count) * 100) > 30 And Now < a Then
                prediction = a
            ElseIf Math.Round((cluster_4to8.Count / avg_ontimes.Count) * 100) > 30 Then
                prediction = b
            ElseIf Math.Round((cluster_8to12.Count / avg_ontimes.Count) * 100) > 30 Then
                prediction = c
            ElseIf Math.Round((cluster_12to16.Count / avg_ontimes.Count) * 100) > 30 Then
                prediction = d
            ElseIf Math.Round((cluster_16to20.Count / avg_ontimes.Count) * 100) > 30 Then
                prediction = f
            ElseIf Math.Round((cluster_20to24.Count / avg_ontimes.Count) * 100) > 30 Then
                prediction = g
            Else
                no_prediction_error()
            End If
        ElseIf Now.Hour < 8 Then
            If Math.Round((cluster_4to8.Count / avg_ontimes.Count) * 100) > 30 And Now < b Then
                prediction = b
            ElseIf Math.Round((cluster_8to12.Count / avg_ontimes.Count) * 100) > 30 Then
                prediction = c
            ElseIf Math.Round((cluster_12to16.Count / avg_ontimes.Count) * 100) > 30 Then
                prediction = d
            ElseIf Math.Round((cluster_16to20.Count / avg_ontimes.Count) * 100) > 30 Then
                prediction = f
            ElseIf Math.Round((cluster_20to24.Count / avg_ontimes.Count) * 100) > 30 Then
                prediction = g
            ElseIf Math.Round((cluster_0to4.Count / avg_ontimes.Count) * 100) > 30 Then
                prediction = a
            Else
                no_prediction_error()
            End If
        ElseIf Now.Hour < 12 Then
            If Math.Round((cluster_8to12.Count / avg_ontimes.Count) * 100) > 30 And Now < c Then
                prediction = c
            ElseIf Math.Round((cluster_12to16.Count / avg_ontimes.Count) * 100) > 30 Then
                prediction = d
            ElseIf Math.Round((cluster_16to20.Count / avg_ontimes.Count) * 100) > 30 Then
                prediction = f
            ElseIf Math.Round((cluster_20to24.Count / avg_ontimes.Count) * 100) > 30 Then
                prediction = g
            ElseIf Math.Round((cluster_0to4.Count / avg_ontimes.Count) * 100) > 30 Then
                prediction = a
            ElseIf Math.Round((cluster_4to8.Count / avg_ontimes.Count) * 100) > 30 Then
                prediction = b
            Else
                no_prediction_error()
            End If
        ElseIf Now.Hour < 16 Then
            If Now.Hour = 12 Then
                If Math.Round((cluster_12to16.Count / avg_ontimes.Count) * 100) > 30 Then
                    prediction = d
                ElseIf Math.Round((cluster_16to20.Count / avg_ontimes.Count) * 100) > 30 Then
                    prediction = f
                ElseIf Math.Round((cluster_20to24.Count / avg_ontimes.Count) * 100) > 30 Then
                    prediction = g
                ElseIf Math.Round((cluster_0to4.Count / avg_ontimes.Count) * 100) > 30 Then
                    prediction = a
                ElseIf Math.Round((cluster_4to8.Count / avg_ontimes.Count) * 100) > 30 Then
                    prediction = b
                ElseIf Math.Round((cluster_8to12.Count / avg_ontimes.Count) * 100) > 30 Then
                    prediction = c
                Else
                    no_prediction_error()
                End If
            Else
                If Math.Round((cluster_12to16.Count / avg_ontimes.Count) * 100) > 30 And Now < d Then
                    prediction = d
                ElseIf Math.Round((cluster_16to20.Count / avg_ontimes.Count) * 100) > 30 Then
                    prediction = f
                ElseIf Math.Round((cluster_20to24.Count / avg_ontimes.Count) * 100) > 30 Then
                    prediction = g
                ElseIf Math.Round((cluster_0to4.Count / avg_ontimes.Count) * 100) > 30 Then
                    prediction = a
                ElseIf Math.Round((cluster_4to8.Count / avg_ontimes.Count) * 100) > 30 Then
                    prediction = b
                ElseIf Math.Round((cluster_8to12.Count / avg_ontimes.Count) * 100) > 30 Then
                    prediction = c
                Else
                    no_prediction_error()
                End If
            End If

        ElseIf Now.Hour < 16 Then
            If Math.Round((cluster_16to20.Count / avg_ontimes.Count) * 100) > 30 And Now < f Then
                prediction = f
            ElseIf Math.Round((cluster_20to24.Count / avg_ontimes.Count) * 100) > 30 Then
                prediction = g
            ElseIf Math.Round((cluster_0to4.Count / avg_ontimes.Count) * 100) > 30 Then
                prediction = a
            ElseIf Math.Round((cluster_4to8.Count / avg_ontimes.Count) * 100) > 30 Then
                prediction = b
            ElseIf Math.Round((cluster_8to12.Count / avg_ontimes.Count) * 100) > 30 Then
                prediction = c
            ElseIf Math.Round((cluster_12to16.Count / avg_ontimes.Count) * 100) > 30 Then
                prediction = d
            Else
                no_prediction_error()
            End If
        ElseIf Now.Hour < 20 Then
            If Math.Round((cluster_20to24.Count / avg_ontimes.Count) * 100) > 30 And Now < f Then
                prediction = g
            ElseIf Math.Round((cluster_0to4.Count / avg_ontimes.Count) * 100) > 30 Then
                prediction = a
            ElseIf Math.Round((cluster_4to8.Count / avg_ontimes.Count) * 100) > 30 Then
                prediction = b
            ElseIf Math.Round((cluster_8to12.Count / avg_ontimes.Count) * 100) > 30 Then
                prediction = c
            ElseIf Math.Round((cluster_12to16.Count / avg_ontimes.Count) * 100) > 30 Then
                prediction = d
            ElseIf Math.Round((cluster_16to20.Count / avg_ontimes.Count) * 100) > 30 Then
                prediction = f
            Else
                no_prediction_error()
            End If
        Else
            no_prediction_error()
        End If
        Return prediction
    End Function

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles PredictCheckbox.CheckedChanged
        If PredictCheckbox.Checked = False Then
            PredictionWindowOutput.Items.Clear()
            PredictionWindowOutput.Items.Add("Prediction Window")
            PredictionWindowCalculation.Text = "Verbose Prediction Calculation"
        End If
    End Sub

    Private Sub tmrWebUIResize_Tick(sender As Object, e As EventArgs) Handles tmrWebUIResize.Tick
        tmrWebUIResize.Enabled = False
        IFrameWebUI.Focus()
        SendKeys.SendWait("^-")
        SendKeys.SendWait("^-")
        SendKeys.SendWait("^-")
    End Sub
    Sub analytics()
        AnalyticsWindow.Text = "Analytics:"
        AnalyticsWindow.AppendText(vbNewLine & LOF(1) / Len(log_entry) & " Entries.")
        AnalyticsWindow.AppendText(vbNewLine & Math.Ceiling(LOF(1) / Len(log_entry) / 2) & " On Presses.")
    End Sub
    Sub no_prediction_error()
        PredictionWindowCalculation.Text &= vbNewLine & ("    No Valid Prediction")
    End Sub

    Sub set_time()
        Dim request1 As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://82.21.53.213/homeautomation/lights")
        Dim response1 As System.Net.HttpWebResponse = request1.GetResponse()
        Dim sr1 As System.IO.StreamReader = New System.IO.StreamReader(response1.GetResponseStream())
        Dim sourcecode1 As String = sr1.ReadToEnd()
        Dim new_state_boolean1 As String = sourcecode1
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://82.21.53.213/homeautomation/mydata.txt")
        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim sourcecode As String = sr.ReadToEnd()
        timeSetVal.Text = "Set Times: " & vbNewLine & sourcecode
        Dim parts As String() = sourcecode.Split(vbLf)
        Dim turn_on As DateTime = parts(0)
        Dim turn_off As DateTime = parts(1)
        timeSetVal.Text &= "Current Time: " & Now.ToShortTimeString
        Try
            If Now.ToShortTimeString = turn_on Then
                If new_state_boolean1 = "false" Then
                    IFrameWebUI.Document.All("buttt").InvokeMember("click")
                    timesetLog.Text &= "As per preset value, the light was set from off to on at " & Now & vbNewLine
                End If
            End If
            If Now.ToShortTimeString = turn_off Then
                If new_state_boolean1 = "true" Then
                    IFrameWebUI.Document.All("buttt").InvokeMember("click")
                    timesetLog.Text &= "As per preset value, the light was set from on to off at " & Now & vbNewLine
                End If
            End If
        Catch ex As Exception
            MsgBox("Please Login")
        End Try
    End Sub
End Class

