Imports System.HttpStyleUriParser
Imports System.IO
Imports System.Net.Http
Imports System.Net


Public Class EasyButlerDI
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DownloadFile()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pHelp As New ProcessStartInfo
        pHelp.FileName = "C:\Launcher\Downloads\EasyButler.exe"
        pHelp.Arguments = "/SILENT /ALLUSERS /NOCANCEL /DIR=""C:\Launcher\Apps\Easy-Butler"" "
        pHelp.UseShellExecute = True
        pHelp.WindowStyle = ProcessWindowStyle.Normal
        Dim proc As Process = Process.Start(pHelp)
    End Sub

    Public Sub DownloadFile()
        Using client = New WebClient()
            client.DownloadFile(New Uri("https://github.com/TheCrafters001/Easy-Butler/releases/latest/download/EasyButler.exe"), "C:\Launcher\Downloads\EasyButler.exe")
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pHelp As New ProcessStartInfo
        pHelp.FileName = "C:\Launcher\Apps\Easy-Butler\unins000.exe"
        pHelp.Arguments = "/SILENT"
        pHelp.UseShellExecute = True
        pHelp.WindowStyle = ProcessWindowStyle.Normal
        Dim proc As Process = Process.Start(pHelp)
    End Sub
End Class