Imports AutoUpdaterDotNET

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Update_Check()
    End Sub

    Public Sub Update_Check()
        AutoUpdater.OpenDownloadPage = True
        AutoUpdater.Start("http://www.thecrafters001.ga/Launcher.xml")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AboutBox1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Software.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TC001.Show()
    End Sub
End Class
