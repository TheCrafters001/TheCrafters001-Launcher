Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FolderBrowserDialog1.Description = "Please select where the program is installed."
        FolderBrowserDialog1.ShowNewFolderButton = False

        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath.ToString
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Please Select A Folder", "Uninstaller", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf TextBox1.Text = FolderBrowserDialog1.SelectedPath Then
            Dim Uninstall As New ProcessStartInfo
            Uninstall.FileName = TextBox1.Text & "\unins000.exe"
            Uninstall.Arguments = "/SILENT"
            Uninstall.UseShellExecute = True
            Uninstall.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(Uninstall)
            Me.Close()
        Else
            MessageBox.Show("Your Selected path does not match the path in the text box, or vice versa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
