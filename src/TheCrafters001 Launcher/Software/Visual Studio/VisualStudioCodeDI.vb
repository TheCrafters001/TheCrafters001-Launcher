Imports System.HttpStyleUriParser
Imports System.IO
Imports System.Net.Http
Imports System.Net

Public Class VisualStudioCodeDI
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DownloadFile()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pHelp As New ProcessStartInfo
        pHelp.FileName = "C:\Launcher\Downloads\VSCode.exe"
        pHelp.Arguments = "/SILENT /DIR=""C:\Launcher\Apps\VSCode"" /NORESTART"
        pHelp.UseShellExecute = True
        pHelp.WindowStyle = ProcessWindowStyle.Normal
        Dim proc As Process = Process.Start(pHelp)
    End Sub

    Public Sub DownloadFile()
        If (Not System.IO.Directory.Exists("C:\Launcher")) Then
            System.IO.Directory.CreateDirectory("C:\Launcher")
        End If
        If (Not System.IO.Directory.Exists("C:\Launcher\Downloads")) Then
            System.IO.Directory.CreateDirectory("C:\Launcher\Downloads")
        End If

        Using client = New WebClient()
            client.DownloadFile(New Uri("https://az764295.vo.msecnd.net/stable/8795a9889db74563ddd43eb0a897a2384129a619/VSCodeUserSetup-x64-1.40.1.exe"), "C:\Launcher\Downloads\VSCode.exe")
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pHelp As New ProcessStartInfo
        pHelp.FileName = "C:\Launcher\Apps\VSCode\unins000.exe"
        pHelp.Arguments = "/SILENT /NORESTART"
        pHelp.UseShellExecute = True
        pHelp.WindowStyle = ProcessWindowStyle.Normal
        Dim proc As Process = Process.Start(pHelp)
    End Sub
End Class