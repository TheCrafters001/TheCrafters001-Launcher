Public Class VisualStudioCode
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://code.visualstudio.com/")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        VisualStudioCodeDI.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pHelp As New ProcessStartInfo
        pHelp.FileName = "C:\Launcher\Apps\VSCode\Code.exe"
        pHelp.Arguments = ""
        pHelp.UseShellExecute = True
        pHelp.WindowStyle = ProcessWindowStyle.Normal
        Dim proc As Process = Process.Start(pHelp)
        Application.Exit()
    End Sub
End Class