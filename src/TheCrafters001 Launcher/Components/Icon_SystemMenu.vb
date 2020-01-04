Public Class Icon_SystemMenu
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Icon_SystemMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(0)
    End Sub

    Private Sub OpenLauncherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenLauncherToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub EasyButlerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EasyButlerToolStripMenuItem.Click
        Easy_Butler.Show()
    End Sub

    Private Sub WebBrowserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebBrowserToolStripMenuItem.Click
        Web_Browser.Show()
    End Sub

    Private Sub FlashPlayer2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlashPlayer2ToolStripMenuItem.Click
        FlashPlayer2.Show()
    End Sub

    Private Sub VLCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VLCToolStripMenuItem.Click
        VLC.Show()
    End Sub

    Private Sub VisualStudio2019ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualStudio2019ToolStripMenuItem.Click
        VisualStudio.Show()
    End Sub

    Private Sub VisualStudioCodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualStudioCodeToolStripMenuItem.Click
        VisualStudioCode.Show()
    End Sub

    Private Sub VSDCVideoEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VSDCVideoEditorToolStripMenuItem.Click
        VSDCVidEdit.Show()
    End Sub

    Private Sub TextHashToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextHashToolStripMenuItem.Click
        TextHash.Show()
    End Sub

    Private Sub SuperTextAdventureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuperTextAdventureToolStripMenuItem.Click
        STA.Show()
    End Sub

    Private Sub SteamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SteamToolStripMenuItem.Click
        Steam.Show()
    End Sub
End Class