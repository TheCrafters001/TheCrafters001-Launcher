Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Change {0} to the version number
        Me.Text = String.Format("TheCrafters001 Launcher! V {0}", My.Application.Info.Version.ToString)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        About.Show()
    End Sub
End Class
