﻿Public Class DeltaGreenI
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pHelp As New ProcessStartInfo
        pHelp.FileName = "Installer_DeltaGreen.msi"
        pHelp.Arguments = "/i"
        pHelp.UseShellExecute = True
        pHelp.WindowStyle = ProcessWindowStyle.Normal
        Dim proc As Process = Process.Start(pHelp)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pHelp As New ProcessStartInfo
        pHelp.FileName = "Installer_DeltaGreen.msi"
        pHelp.Arguments = "/x"
        pHelp.UseShellExecute = True
        pHelp.WindowStyle = ProcessWindowStyle.Normal
        Dim proc As Process = Process.Start(pHelp)
    End Sub
End Class