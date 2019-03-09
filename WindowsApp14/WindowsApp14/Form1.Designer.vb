<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MusicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.songComboBox1 = New System.Windows.Forms.ComboBox()
        Me.songComboBox2 = New System.Windows.Forms.ComboBox()
        Me.songComboBox3 = New System.Windows.Forms.ComboBox()
        Me.songComboBox4 = New System.Windows.Forms.ComboBox()
        Me.songComboBox5 = New System.Windows.Forms.ComboBox()
        Me.songComboBox6 = New System.Windows.Forms.ComboBox()
        Me.songImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(16, 282)
        Me.Button1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 37)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MusicToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(365, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'MusicToolStripMenuItem
        '
        Me.MusicToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem})
        Me.MusicToolStripMenuItem.Name = "MusicToolStripMenuItem"
        Me.MusicToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.MusicToolStripMenuItem.Text = "Music"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Line-UP"
        '
        'songComboBox1
        '
        Me.songComboBox1.FormattingEnabled = True
        Me.songComboBox1.Location = New System.Drawing.Point(16, 51)
        Me.songComboBox1.Name = "songComboBox1"
        Me.songComboBox1.Size = New System.Drawing.Size(121, 32)
        Me.songComboBox1.TabIndex = 4
        '
        'songComboBox2
        '
        Me.songComboBox2.FormattingEnabled = True
        Me.songComboBox2.Location = New System.Drawing.Point(16, 89)
        Me.songComboBox2.Name = "songComboBox2"
        Me.songComboBox2.Size = New System.Drawing.Size(121, 32)
        Me.songComboBox2.TabIndex = 5
        '
        'songComboBox3
        '
        Me.songComboBox3.FormattingEnabled = True
        Me.songComboBox3.Location = New System.Drawing.Point(16, 127)
        Me.songComboBox3.Name = "songComboBox3"
        Me.songComboBox3.Size = New System.Drawing.Size(121, 32)
        Me.songComboBox3.TabIndex = 6
        '
        'songComboBox4
        '
        Me.songComboBox4.FormattingEnabled = True
        Me.songComboBox4.Location = New System.Drawing.Point(16, 165)
        Me.songComboBox4.Name = "songComboBox4"
        Me.songComboBox4.Size = New System.Drawing.Size(121, 32)
        Me.songComboBox4.TabIndex = 7
        '
        'songComboBox5
        '
        Me.songComboBox5.FormattingEnabled = True
        Me.songComboBox5.Location = New System.Drawing.Point(16, 203)
        Me.songComboBox5.Name = "songComboBox5"
        Me.songComboBox5.Size = New System.Drawing.Size(121, 32)
        Me.songComboBox5.TabIndex = 8
        '
        'songComboBox6
        '
        Me.songComboBox6.FormattingEnabled = True
        Me.songComboBox6.Location = New System.Drawing.Point(16, 241)
        Me.songComboBox6.Name = "songComboBox6"
        Me.songComboBox6.Size = New System.Drawing.Size(121, 32)
        Me.songComboBox6.TabIndex = 9
        '
        'songImageList
        '
        Me.songImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.songImageList.ImageSize = New System.Drawing.Size(16, 16)
        Me.songImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(157, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(191, 234)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(16, 328)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 34)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "First"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(148, 328)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 34)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Next"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(148, 282)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(120, 37)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Last"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 368)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.songComboBox6)
        Me.Controls.Add(Me.songComboBox5)
        Me.Controls.Add(Me.songComboBox4)
        Me.Controls.Add(Me.songComboBox3)
        Me.Controls.Add(Me.songComboBox2)
        Me.Controls.Add(Me.songComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MusicToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents songComboBox1 As ComboBox
    Friend WithEvents songComboBox2 As ComboBox
    Friend WithEvents songComboBox3 As ComboBox
    Friend WithEvents songComboBox4 As ComboBox
    Friend WithEvents songComboBox5 As ComboBox
    Friend WithEvents songComboBox6 As ComboBox
    Friend WithEvents songImageList As ImageList
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
