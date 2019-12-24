Imports System.HttpStyleUriParser
Imports System.IO
Imports System.Net.Http
Imports FileDownloads
Imports FileDownloads.Class1
Imports System.Net

Public Class VLCDI
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FileDownloads.Class1.DownloadFile("https://get.videolan.org/vlc/3.0.8/win64/vlc-3.0.8-win64.exe", "VLC_Install")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FileDownloads.Class1.Install("VLC_Install", "exe", "")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FileDownloads.Class1.Uninstall(False, "VLC Media Player", "unins000", "")
    End Sub
End Class