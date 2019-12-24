Public Class Icon_SystemMenu
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Icon_SystemMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(0)
    End Sub
End Class