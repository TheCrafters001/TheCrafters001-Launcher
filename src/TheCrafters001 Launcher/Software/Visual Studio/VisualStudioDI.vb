Imports System.HttpStyleUriParser
Imports System.IO
Imports System.Net.Http
Imports System.Net

Public Class VisualStudioDI
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DownloadFile()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pHelp As New ProcessStartInfo
        pHelp.FileName = "C:\Launcher\Downloads\visualstudio_installer.exe"
        pHelp.Arguments = "--installPath ""C:\Launcher\Apps\Visual Studio 2019"" -p"
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
            client.DownloadFile(New Uri("https://download.visualstudio.microsoft.com/download/pr/5446351f-19f5-4b09-98c6-a4bfacc732d7/588befb41c980ff377c56ac952693bcfc8dbcec5a1fb0da59ce17dad0ebb9e73/vs_Community.exe"), "C:\Launcher\Downloads\visualstudio_installer.exe")
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pHelp As New ProcessStartInfo
        pHelp.FileName = "C:\Launcher\Downloads\visualstudio_installer.exe"
        pHelp.Arguments = "--installPath ""C:\Launcher\Apps\Visual Studio 2019"" uninstall"
        pHelp.UseShellExecute = True
        pHelp.WindowStyle = ProcessWindowStyle.Normal
        Dim proc As Process = Process.Start(pHelp)
    End Sub
End Class