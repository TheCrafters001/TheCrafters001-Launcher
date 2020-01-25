Imports AutoUpdaterDotNET

Public Class About
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label4.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        AutoUpdater.ShowSkipButton = False
        AutoUpdater.ShowRemindLaterButton = True
        AutoUpdater.ReportErrors = True
        AutoUpdater.RunUpdateAsAdmin = True
        AutoUpdater.LetUserSelectRemindLater = True
        AutoUpdater.RemindLaterTimeSpan = RemindLaterFormat.Hours
        AutoUpdater.RemindLaterAt = 1
        AutoUpdater.UpdateFormSize = New System.Drawing.Size(554, 489)
        AutoUpdater.Start("http://api.thecrafters001.ga/updates/Launcher.xml")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) 
        Process.Start("https://docs.google.com/forms/d/e/1FAIpQLSddcxPtWk4EOm2mZnoC0PcoPytBb2DoD66TDTrT1pHPaTDu7A/viewform?usp=sf_link")
    End Sub
End Class