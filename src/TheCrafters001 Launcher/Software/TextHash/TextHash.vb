Public Class TextHash
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pHelp As New ProcessStartInfo
        pHelp.FileName = "TextHash.exe"
        pHelp.Arguments = ""
        pHelp.UseShellExecute = True
        pHelp.WindowStyle = ProcessWindowStyle.Normal
        Dim proc As Process = Process.Start(pHelp)
        Me.Close()
        Software.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class