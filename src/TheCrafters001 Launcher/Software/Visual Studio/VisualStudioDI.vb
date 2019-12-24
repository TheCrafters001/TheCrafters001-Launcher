Imports System.HttpStyleUriParser
Imports System.IO
Imports System.Net.Http
Imports FileDownloads
Imports FileDownloads.Class1
Imports System.Net

Public Class VisualStudioDI
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FileDownloads.Class1.DownloadFile("https://download.visualstudio.microsoft.com/download/pr/5446351f-19f5-4b09-98c6-a4bfacc732d7/588befb41c980ff377c56ac952693bcfc8dbcec5a1fb0da59ce17dad0ebb9e73/vs_Community.exe", "vs_Community")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FileDownloads.Class1.Install("vs__Community", "exe", "--installPath ""C:\Launcher\Apps\Visual Studio 2019"" -p")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FileDownloads.Class1.Uninstall(True, "Visual Studio 2019", "..\..\Downloads\vs__Community", "--installPath ""C:\Launcher\Apps\Visual Studio 2019"" uninstall")
    End Sub
End Class