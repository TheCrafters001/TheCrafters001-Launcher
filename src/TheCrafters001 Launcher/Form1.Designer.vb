<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Software_Page = New System.Windows.Forms.TabPage()
        Me.Games_Page = New System.Windows.Forms.TabPage()
        Me.Misc_page = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.About_Page = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.Software_Page.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.Software_Page)
        Me.TabControl1.Controls.Add(Me.Games_Page)
        Me.TabControl1.Controls.Add(Me.Misc_page)
        Me.TabControl1.Controls.Add(Me.About_Page)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(776, 426)
        Me.TabControl1.TabIndex = 0
        '
        'Software_Page
        '
        Me.Software_Page.Controls.Add(Me.PictureBox1)
        Me.Software_Page.Location = New System.Drawing.Point(4, 22)
        Me.Software_Page.Name = "Software_Page"
        Me.Software_Page.Padding = New System.Windows.Forms.Padding(3)
        Me.Software_Page.Size = New System.Drawing.Size(768, 400)
        Me.Software_Page.TabIndex = 0
        Me.Software_Page.Text = "Software"
        Me.Software_Page.UseVisualStyleBackColor = True
        '
        'Games_Page
        '
        Me.Games_Page.Location = New System.Drawing.Point(4, 22)
        Me.Games_Page.Name = "Games_Page"
        Me.Games_Page.Padding = New System.Windows.Forms.Padding(3)
        Me.Games_Page.Size = New System.Drawing.Size(768, 400)
        Me.Games_Page.TabIndex = 1
        Me.Games_Page.Text = "Games"
        Me.Games_Page.UseVisualStyleBackColor = True
        '
        'Misc_page
        '
        Me.Misc_page.Location = New System.Drawing.Point(4, 22)
        Me.Misc_page.Name = "Misc_page"
        Me.Misc_page.Size = New System.Drawing.Size(768, 400)
        Me.Misc_page.TabIndex = 2
        Me.Misc_page.Text = "Misc"
        Me.Misc_page.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'About_Page
        '
        Me.About_Page.Location = New System.Drawing.Point(4, 22)
        Me.About_Page.Name = "About_Page"
        Me.About_Page.Size = New System.Drawing.Size(768, 400)
        Me.About_Page.TabIndex = 3
        Me.About_Page.Text = "About/Update"
        Me.About_Page.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.Software_Page.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Software_Page As TabPage
    Friend WithEvents Games_Page As TabPage
    Friend WithEvents Misc_page As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents About_Page As TabPage
End Class
