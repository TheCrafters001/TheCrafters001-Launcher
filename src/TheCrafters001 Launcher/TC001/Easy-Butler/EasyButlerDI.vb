Imports System.HttpStyleUriParser
Imports System.IO
Imports System.Net.Http
Imports FileDownloads
Imports FileDownloads.Class1
Imports System.Net


Public Class EasyButlerDI
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FileDownloads.Class1.DownloadFile("https://github.com/TheCrafters001/Easy-Butler/releases/latest/download/EasyButler.exe", "EasyButler")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FileDownloads.Class1.Install("EasyButler", "exe", "/SILENT /DIR=""C:\Launcher\Apps\Easy Butler""")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FileDownloads.Class1.Uninstall(True, "Easy Butler", "unins000", "/SILENT")
    End Sub
End Class