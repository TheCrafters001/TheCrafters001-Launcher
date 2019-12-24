Imports System.HttpStyleUriParser
Imports System.IO
Imports System.Net.Http
Imports FileDownloads
Imports FileDownloads.Class1
Imports System.Net

Public Class VisualStudioCodeDI
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FileDownloads.Class1.DownloadFile("https://az764295.vo.msecnd.net/stable/8795a9889db74563ddd43eb0a897a2384129a619/VSCodeUserSetup-x64-1.40.1.exe", "VSCode")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FileDownloads.Class1.Install("VSCode", "exe", "/SILENT /DIR=""C:\Launcher\Apps\Visual Studio Code"" /NORESTART")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FileDownloads.Class1.Uninstall(True, "Visual Studio Code", "unins000", "/SILENT")
    End Sub
End Class