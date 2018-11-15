Imports System.Net
Module Module1
    Sub Main()
        Dim remoteUri As String = "http://82.19.253.90/eatonmanufacturingsystem/"
        Dim newVersion As String = New System.Net.WebClient().DownloadString("http://82.19.253.90/eatonmanufacturingsystem/update.html")
        Dim fileName As String = newVersion & ".exe"
        Dim myStringWebResource As String = Nothing
        Dim myWebClient As New WebClient()
        myStringWebResource = remoteUri + fileName
        Console.WriteLine("Downloading File ""{0}"" from ""{1}"" ......." + ControlChars.Cr + ControlChars.Cr, fileName, myStringWebResource)
        Try
            myWebClient.DownloadFile(myStringWebResource, fileName)
            Console.WriteLine("Successfully Downloaded file ""{0}"" from ""{1}""", fileName, myStringWebResource)
            Console.WriteLine(("Downloaded file saved in the following file system folder:" + ControlChars.Cr + ControlChars.Tab + CurDir()))
        Catch ex As Exception
            Console.WriteLine("Server Offline, Please Update At A Later Date.")
        End Try
        Try
            Console.WriteLine("Deleting Previous Version.")
            My.Computer.FileSystem.DeleteFile("Eaton Manafacturing System.exe")
            Console.WriteLine("Adding New Version.")
            My.Computer.FileSystem.RenameFile(newVersion & ".exe", "Eaton Manafacturing System.exe")
            Console.WriteLine("Update Complete.")
        Catch ex As Exception
            Console.WriteLine("Error replacing file. " & ex.ToString)
        End Try
        Process.Start("Eaton Manafacturing System.exe")
        End
    End Sub
End Module
