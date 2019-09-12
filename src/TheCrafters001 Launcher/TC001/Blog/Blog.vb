Public Class Blog
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start("TheCrafters001 Blog.exe")
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://github.com/TheCrafters001/TheCrafters001-Launcher")
    End Sub
End Class