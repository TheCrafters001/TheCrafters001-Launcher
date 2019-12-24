Imports System.HttpStyleUriParser
Imports System.IO
Imports System.Net.Http
Imports System.Net


Public Class FlashPlayer2DI
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DownloadFile()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pHelp As New ProcessStartInfo
        pHelp.FileName = "C:\Launcher\Downloads\FreeTube_Setup.exe"
        pHelp.Arguments = ""
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
            client.DownloadFile(New Uri("https://github.com/FreeTubeApp/FreeTube/releases/download/v0.7.2-beta/FreeTube.Setup.0.7.2.exe"), "C:\Launcher\Downloads\FreeTube_Setup.exe")
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("FreeTube must be uninstalled Manually.", "FreeTube Uninstall", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class