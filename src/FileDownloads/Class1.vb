Imports System.HttpStyleUriParser
Imports System.IO
Imports System.Net.Http
Imports System.Net


Public Class Class1

    Public Shared Sub DownloadFile(ByVal Exe_URL As String, ByVal Exe_Output As String)
        If (Not System.IO.Directory.Exists("C:\Launcher")) Then
            System.IO.Directory.CreateDirectory("C:\Launcher")
        End If
        If (Not System.IO.Directory.Exists("C:\Launcher\Downloads")) Then
            System.IO.Directory.CreateDirectory("C:\Launcher\Downloads")
        End If
        Using client = New WebClient()
            client.DownloadFile(New Uri(Exe_URL), "C:\Launcher\Downloads\" & Exe_Output & ".exe")
        End Using
    End Sub

    Public Shared Sub DownloadFileMSI(ByVal MSI_URL As String, ByVal MSI_Output As String)
        If (Not System.IO.Directory.Exists("C:\Launcher")) Then
            System.IO.Directory.CreateDirectory("C:\Launcher")
        End If
        If (Not System.IO.Directory.Exists("C:\Launcher\Downloads")) Then
            System.IO.Directory.CreateDirectory("C:\Launcher\Downloads")
        End If
        Using client = New WebClient()
            client.DownloadFile(New Uri(MSI_URL), "C:\Launcher\Downloads\" & MSI_Output & ".msi")
        End Using
    End Sub

    Public Shared Sub Install(ByVal FileName As String, ByVal Extention As String, ByVal Arguments As String)
        Dim Installer_Run As New ProcessStartInfo
        Installer_Run.FileName = "C:\Launcher\Downloads\" & FileName & "." & Extention
        Installer_Run.Arguments = Arguments
        Installer_Run.UseShellExecute = True
        Installer_Run.WindowStyle = ProcessWindowStyle.Normal
        Dim proc As Process = Process.Start(Installer_Run)
    End Sub

    Public Shared Sub Uninstall(ByVal CanBeUninstalled As Boolean, ByVal ProgramName As String, ByVal UninstallEXE As String, ByVal UninstallArguments As String)
        Dim Uninstaller_Run As New ProcessStartInfo
        If CanBeUninstalled = True Then
            Uninstaller_Run.FileName = "C:\Launcher\Apps\" & ProgramName & UninstallEXE & ".exe"
            Uninstaller_Run.Arguments = UninstallArguments
            Uninstaller_Run.UseShellExecute = True
            Uninstaller_Run.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(Uninstaller_Run)
        ElseIf CanBeUninstalled = False Then
            Dim box = New UninstallFailed()
            box.Show()
            box.Text = ProgramName & " Failed to uninstall."
            box.Label1.Text = ProgramName & " cannot be uninstalled. It has to be uninstalled manually."
        End If
    End Sub
End Class
