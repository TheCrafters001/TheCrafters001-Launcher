Imports AutoUpdaterDotNET

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Update_Check()
    End Sub

    Public Sub Update_Check()
        AutoUpdater.OpenDownloadPage = True
        AutoUpdater.Start("http://www.thecrafters001.ga/Launcher.xml")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Software.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        TC001.Show()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        AboutBox1.Show()
    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        Software.Show()
    End Sub

    Private Sub MetroTile4_Click(sender As Object, e As EventArgs) Handles MetroTile4.Click
        TC001.Show()
    End Sub

    Private Sub MetroTile3_Click(sender As Object, e As EventArgs) Handles MetroTile3.Click
        Misc.Show()
    End Sub

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        Games.Show()
    End Sub
End Class
