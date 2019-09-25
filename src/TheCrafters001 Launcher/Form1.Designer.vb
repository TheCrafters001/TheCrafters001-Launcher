<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile3 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile4 = New MetroFramework.Controls.MetroTile()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'MetroTile1
        '
        Me.MetroTile1.Enabled = False
        Me.MetroTile1.Location = New System.Drawing.Point(23, 63)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(125, 125)
        Me.MetroTile1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroTile1.TabIndex = 6
        Me.MetroTile1.Text = "Software"
        Me.MetroTile1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroTile2
        '
        Me.MetroTile2.Enabled = False
        Me.MetroTile2.Location = New System.Drawing.Point(154, 63)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(125, 125)
        Me.MetroTile2.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroTile2.TabIndex = 7
        Me.MetroTile2.Text = "Games"
        Me.MetroTile2.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroTile3
        '
        Me.MetroTile3.Enabled = False
        Me.MetroTile3.Location = New System.Drawing.Point(285, 63)
        Me.MetroTile3.Name = "MetroTile3"
        Me.MetroTile3.Size = New System.Drawing.Size(125, 125)
        Me.MetroTile3.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroTile3.TabIndex = 8
        Me.MetroTile3.Text = "Misc"
        Me.MetroTile3.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroTile4
        '
        Me.MetroTile4.Location = New System.Drawing.Point(416, 63)
        Me.MetroTile4.Name = "MetroTile4"
        Me.MetroTile4.Size = New System.Drawing.Size(125, 125)
        Me.MetroTile4.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroTile4.TabIndex = 9
        Me.MetroTile4.Text = "TheCrafters001"
        Me.MetroTile4.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(466, 404)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 10
        Me.MetroButton1.Text = "About"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(385, 404)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton2.TabIndex = 11
        Me.MetroButton2.Text = "Debug"
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 450)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroTile4)
        Me.Controls.Add(Me.MetroTile3)
        Me.Controls.Add(Me.MetroTile2)
        Me.Controls.Add(Me.MetroTile1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "TheCrafters001 Launcher!"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile3 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile4 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
End Class
