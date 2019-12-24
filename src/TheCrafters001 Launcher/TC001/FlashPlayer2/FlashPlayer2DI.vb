Imports System.HttpStyleUriParser
Imports System.IO
Imports System.Net.Http
Imports FileDownloads
Imports FileDownloads.Class1
Imports System.Net


Public Class FlashPlayer2DI
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FileDownloads.Class1.DownloadFile("https://github.com/TheCrafters001/Flash-Player-2/releases/latest/download/FlashPlayer_Installer.exe", "FlashPlayer_Installer")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FileDownloads.Class1.Install("FlashPlayer_Installer", "exe", "/SILENT /DIR=""C:\Launcher\Apps\Flash Player 2""")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FileDownloads.Class1.Uninstall(True, "Flash Player 2", "unins000", "/SILENT")
    End Sub
End Class