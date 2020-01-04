<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Icon_SystemMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Icon_SystemMenu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenLauncherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SoftwareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TheCrafters001ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EasyButlerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebBrowserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VLCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualStudioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualStudio2019ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualStudioCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VSDCVideoEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextHashToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuperTextAdventureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SteamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlashPlayer2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "This window should remain hidden. It contains the NotifyIcon code."
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipText = "I am now running in the background." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Right Click the icon for more options."
        Me.NotifyIcon1.BalloonTipTitle = "TheCrafters001 Launcher"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "TheCrafters001 Launcher"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenLauncherToolStripMenuItem, Me.ToolStripSeparator1, Me.SoftwareToolStripMenuItem, Me.GamesToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(181, 126)
        '
        'OpenLauncherToolStripMenuItem
        '
        Me.OpenLauncherToolStripMenuItem.Name = "OpenLauncherToolStripMenuItem"
        Me.OpenLauncherToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenLauncherToolStripMenuItem.Text = "Open Launcher"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'SoftwareToolStripMenuItem
        '
        Me.SoftwareToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TheCrafters001ToolStripMenuItem, Me.VLCToolStripMenuItem, Me.VisualStudioToolStripMenuItem, Me.VSDCVideoEditorToolStripMenuItem, Me.TextHashToolStripMenuItem})
        Me.SoftwareToolStripMenuItem.Name = "SoftwareToolStripMenuItem"
        Me.SoftwareToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SoftwareToolStripMenuItem.Text = "Software"
        '
        'TheCrafters001ToolStripMenuItem
        '
        Me.TheCrafters001ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EasyButlerToolStripMenuItem, Me.WebBrowserToolStripMenuItem, Me.FlashPlayer2ToolStripMenuItem})
        Me.TheCrafters001ToolStripMenuItem.Name = "TheCrafters001ToolStripMenuItem"
        Me.TheCrafters001ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TheCrafters001ToolStripMenuItem.Text = "TheCrafters001"
        '
        'EasyButlerToolStripMenuItem
        '
        Me.EasyButlerToolStripMenuItem.Name = "EasyButlerToolStripMenuItem"
        Me.EasyButlerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EasyButlerToolStripMenuItem.Text = "Easy Butler"
        '
        'WebBrowserToolStripMenuItem
        '
        Me.WebBrowserToolStripMenuItem.Name = "WebBrowserToolStripMenuItem"
        Me.WebBrowserToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.WebBrowserToolStripMenuItem.Text = "Web Browser"
        '
        'VLCToolStripMenuItem
        '
        Me.VLCToolStripMenuItem.Name = "VLCToolStripMenuItem"
        Me.VLCToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VLCToolStripMenuItem.Text = "VLC"
        '
        'VisualStudioToolStripMenuItem
        '
        Me.VisualStudioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisualStudio2019ToolStripMenuItem, Me.VisualStudioCodeToolStripMenuItem})
        Me.VisualStudioToolStripMenuItem.Name = "VisualStudioToolStripMenuItem"
        Me.VisualStudioToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VisualStudioToolStripMenuItem.Text = "Visual Studio"
        '
        'VisualStudio2019ToolStripMenuItem
        '
        Me.VisualStudio2019ToolStripMenuItem.Name = "VisualStudio2019ToolStripMenuItem"
        Me.VisualStudio2019ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VisualStudio2019ToolStripMenuItem.Text = "Visual Studio 2019"
        '
        'VisualStudioCodeToolStripMenuItem
        '
        Me.VisualStudioCodeToolStripMenuItem.Name = "VisualStudioCodeToolStripMenuItem"
        Me.VisualStudioCodeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VisualStudioCodeToolStripMenuItem.Text = "Visual Studio Code"
        '
        'VSDCVideoEditorToolStripMenuItem
        '
        Me.VSDCVideoEditorToolStripMenuItem.Name = "VSDCVideoEditorToolStripMenuItem"
        Me.VSDCVideoEditorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VSDCVideoEditorToolStripMenuItem.Text = "VSDC Video Editor"
        '
        'TextHashToolStripMenuItem
        '
        Me.TextHashToolStripMenuItem.Name = "TextHashToolStripMenuItem"
        Me.TextHashToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TextHashToolStripMenuItem.Text = "TextHash"
        '
        'GamesToolStripMenuItem
        '
        Me.GamesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SuperTextAdventureToolStripMenuItem, Me.SteamToolStripMenuItem})
        Me.GamesToolStripMenuItem.Name = "GamesToolStripMenuItem"
        Me.GamesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GamesToolStripMenuItem.Text = "Games"
        '
        'SuperTextAdventureToolStripMenuItem
        '
        Me.SuperTextAdventureToolStripMenuItem.Name = "SuperTextAdventureToolStripMenuItem"
        Me.SuperTextAdventureToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.SuperTextAdventureToolStripMenuItem.Text = "Super Text Adventure"
        '
        'SteamToolStripMenuItem
        '
        Me.SteamToolStripMenuItem.Name = "SteamToolStripMenuItem"
        Me.SteamToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.SteamToolStripMenuItem.Text = "Steam"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'FlashPlayer2ToolStripMenuItem
        '
        Me.FlashPlayer2ToolStripMenuItem.Name = "FlashPlayer2ToolStripMenuItem"
        Me.FlashPlayer2ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FlashPlayer2ToolStripMenuItem.Text = "Flash Player 2"
        '
        'Icon_SystemMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 31)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Icon_SystemMenu"
        Me.Opacity = 0R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Icon_SystemMenu"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents OpenLauncherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SoftwareToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GamesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TheCrafters001ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EasyButlerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WebBrowserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VLCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisualStudioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisualStudio2019ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisualStudioCodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VSDCVideoEditorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextHashToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuperTextAdventureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SteamToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlashPlayer2ToolStripMenuItem As ToolStripMenuItem
End Class
