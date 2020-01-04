Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.DefInstallLocation
        If My.Settings.DefSilentInstall = True Then
            CheckBox1.Checked = True
        ElseIf My.Settings.DefSilentInstall = False Then
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.DefInstallLocation = TextBox1.Text
        If CheckBox1.Checked = True Then
            My.Settings.DefSilentInstall = True
        ElseIf CheckBox1.Checked = False Then
            My.Settings.DefSilentInstall = False
        End If
        My.Settings.Save()
        MessageBox.Show("Some settings require a restart to apply. Click OK, or the X, to restart the app.", "Restart Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Application.Restart()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result_dialog As DialogResult = MessageBox.Show("Are you sure you want to cancel? Any unsaved changes will be discarded.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If result_dialog = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class