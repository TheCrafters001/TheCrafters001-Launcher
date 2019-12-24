Imports FileDownloads
Public Class UninstallFailed
    Private Sub UninstallFailed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "OK"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class