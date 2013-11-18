<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.isUpToDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.repoUpdated = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.RefreshList = New System.Windows.Forms.Button()
        Me.RefreshWorlds = New System.Windows.Forms.Button()
        Me.Bowser = New System.Windows.Forms.PictureBox()
        Me.Mario = New System.Windows.Forms.PictureBox()
        Me.Luigi = New System.Windows.Forms.PictureBox()
        Me.Toad = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.Bowser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Luigi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 429)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Settings"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(242, 62)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(266, 199)
        Me.ListBox2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Emulogic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(9, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Available for Download"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Emulogic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(275, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Installed"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Button2.Location = New System.Drawing.Point(242, 262)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 90)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Delete Selected" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "World" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Enabled = False
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(12, 262)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 90)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Install Selected World"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Emulogic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 389)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Description:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Emulogic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(57, 413)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Author:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(129, 408)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(378, 20)
        Me.TextBox2.TabIndex = 13
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 62)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(214, 199)
        Me.ListBox1.TabIndex = 15
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(694, 380)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(214, 20)
        Me.TextBox3.TabIndex = 16
        Me.TextBox3.Text = "IF YOU SEE THIS YOU ARE DEBUGGING"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(694, 406)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(214, 20)
        Me.TextBox4.TabIndex = 17
        Me.TextBox4.Text = "IF YOU SEE THIS YOU ARE DEBUGGING"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(362, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(146, 23)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Expand Debug Dialogs->"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(605, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(305, 78)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = resources.GetString("Label5.Text")
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackgroundImage = CType(resources.GetObject("StatusStrip1.BackgroundImage"), System.Drawing.Image)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.isUpToDate, Me.ToolStripStatusLabel1, Me.repoUpdated})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 460)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(920, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 21
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'isUpToDate
        '
        Me.isUpToDate.Font = New System.Drawing.Font("Emulogic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isUpToDate.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.isUpToDate.Name = "isUpToDate"
        Me.isUpToDate.Size = New System.Drawing.Size(97, 17)
        Me.isUpToDate.Text = "isUpToDate"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Emulogic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(25, 17)
        Me.ToolStripStatusLabel1.Text = "--"
        '
        'repoUpdated
        '
        Me.repoUpdated.Font = New System.Drawing.Font("Emulogic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.repoUpdated.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.repoUpdated.Name = "repoUpdated"
        Me.repoUpdated.Size = New System.Drawing.Size(106, 17)
        Me.repoUpdated.Text = "repoUpdated"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Location = New System.Drawing.Point(680, 33)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(130, 13)
        Me.LinkLabel1.TabIndex = 22
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Manually Run Update.exe"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(680, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Label6"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Location = New System.Drawing.Point(680, 46)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(125, 13)
        Me.LinkLabel2.TabIndex = 24
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Tumblr. Holds changelog"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(129, 354)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox1.Size = New System.Drawing.Size(378, 48)
        Me.RichTextBox1.TabIndex = 25
        Me.RichTextBox1.Text = ""
        '
        'RefreshList
        '
        Me.RefreshList.BackgroundImage = CType(resources.GetObject("RefreshList.BackgroundImage"), System.Drawing.Image)
        Me.RefreshList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RefreshList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshList.Location = New System.Drawing.Point(114, 293)
        Me.RefreshList.Name = "RefreshList"
        Me.RefreshList.Size = New System.Drawing.Size(25, 24)
        Me.RefreshList.TabIndex = 26
        Me.RefreshList.UseVisualStyleBackColor = True
        '
        'RefreshWorlds
        '
        Me.RefreshWorlds.BackgroundImage = CType(resources.GetObject("RefreshWorlds.BackgroundImage"), System.Drawing.Image)
        Me.RefreshWorlds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RefreshWorlds.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshWorlds.Location = New System.Drawing.Point(344, 293)
        Me.RefreshWorlds.Name = "RefreshWorlds"
        Me.RefreshWorlds.Size = New System.Drawing.Size(25, 24)
        Me.RefreshWorlds.TabIndex = 27
        Me.RefreshWorlds.UseVisualStyleBackColor = True
        '
        'Bowser
        '
        Me.Bowser.BackColor = System.Drawing.Color.Transparent
        Me.Bowser.Image = CType(resources.GetObject("Bowser.Image"), System.Drawing.Image)
        Me.Bowser.Location = New System.Drawing.Point(683, 100)
        Me.Bowser.Name = "Bowser"
        Me.Bowser.Size = New System.Drawing.Size(64, 81)
        Me.Bowser.TabIndex = 28
        Me.Bowser.TabStop = False
        '
        'Mario
        '
        Me.Mario.BackColor = System.Drawing.Color.Transparent
        Me.Mario.BackgroundImage = CType(resources.GetObject("Mario.BackgroundImage"), System.Drawing.Image)
        Me.Mario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Mario.Location = New System.Drawing.Point(463, 267)
        Me.Mario.Name = "Mario"
        Me.Mario.Size = New System.Drawing.Size(32, 64)
        Me.Mario.TabIndex = 29
        Me.Mario.TabStop = False
        '
        'Luigi
        '
        Me.Luigi.BackColor = System.Drawing.Color.Transparent
        Me.Luigi.BackgroundImage = CType(resources.GetObject("Luigi.BackgroundImage"), System.Drawing.Image)
        Me.Luigi.Location = New System.Drawing.Point(182, 291)
        Me.Luigi.Name = "Luigi"
        Me.Luigi.Size = New System.Drawing.Size(32, 64)
        Me.Luigi.TabIndex = 30
        Me.Luigi.TabStop = False
        '
        'Toad
        '
        Me.Toad.BackColor = System.Drawing.Color.Transparent
        Me.Toad.BackgroundImage = CType(resources.GetObject("Toad.BackgroundImage"), System.Drawing.Image)
        Me.Toad.Location = New System.Drawing.Point(220, 3)
        Me.Toad.Name = "Toad"
        Me.Toad.Size = New System.Drawing.Size(49, 53)
        Me.Toad.TabIndex = 31
        Me.Toad.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(389, 262)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 64)
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(920, 482)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Toad)
        Me.Controls.Add(Me.Luigi)
        Me.Controls.Add(Me.Mario)
        Me.Controls.Add(Me.Bowser)
        Me.Controls.Add(Me.RefreshWorlds)
        Me.Controls.Add(Me.RefreshList)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "SMBX World Manager"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.Bowser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Luigi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents isUpToDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents repoUpdated As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents RefreshList As System.Windows.Forms.Button
    Friend WithEvents RefreshWorlds As System.Windows.Forms.Button
    Friend WithEvents Bowser As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Mario As System.Windows.Forms.PictureBox
    Friend WithEvents Luigi As System.Windows.Forms.PictureBox
    Friend WithEvents Toad As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
