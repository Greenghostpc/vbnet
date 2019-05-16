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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.TrackBar3 = New System.Windows.Forms.TrackBar()
        Me.TrackBar4 = New System.Windows.Forms.TrackBar()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(14, 23)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 24)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Color"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Rectangle", "Ellipse", "Gradient", "Shape"})
        Me.ComboBox1.Location = New System.Drawing.Point(95, 23)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(89, 22)
        Me.ComboBox1.TabIndex = 21
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "paint"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(808, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.ClearToolStripMenuItem.Text = "New"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(95, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.ClearToolStripMenuItem1})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'ClearToolStripMenuItem1
        '
        Me.ClearToolStripMenuItem1.Name = "ClearToolStripMenuItem1"
        Me.ClearToolStripMenuItem1.Size = New System.Drawing.Size(103, 22)
        Me.ClearToolStripMenuItem1.Text = "Clear"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 450)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(808, 22)
        Me.StatusStrip1.TabIndex = 14
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TrackBar2
        '
        Me.TrackBar2.Location = New System.Drawing.Point(14, 72)
        Me.TrackBar2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TrackBar2.Maximum = 200
        Me.TrackBar2.Minimum = 20
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(119, 45)
        Me.TrackBar2.TabIndex = 4
        Me.TrackBar2.Value = 20
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(14, 125)
        Me.TrackBar1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TrackBar1.Maximum = 200
        Me.TrackBar1.Minimum = 20
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(119, 45)
        Me.TrackBar1.TabIndex = 3
        Me.TrackBar1.Value = 20
        '
        'TrackBar3
        '
        Me.TrackBar3.Location = New System.Drawing.Point(14, 173)
        Me.TrackBar3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TrackBar3.Maximum = 5
        Me.TrackBar3.Minimum = -5
        Me.TrackBar3.Name = "TrackBar3"
        Me.TrackBar3.Size = New System.Drawing.Size(119, 45)
        Me.TrackBar3.TabIndex = 10
        '
        'TrackBar4
        '
        Me.TrackBar4.Location = New System.Drawing.Point(14, 232)
        Me.TrackBar4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TrackBar4.Maximum = 5
        Me.TrackBar4.Minimum = -5
        Me.TrackBar4.Name = "TrackBar4"
        Me.TrackBar4.Size = New System.Drawing.Size(119, 45)
        Me.TrackBar4.TabIndex = 11
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(128, 152)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(64, 18)
        Me.CheckBox2.TabIndex = 9
        Me.CheckBox2.Text = "Gravity "
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(119, 51)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(42, 18)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Fill"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 14)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Up"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 14)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Left"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(125, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 14)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Down"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(125, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 14)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Right"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(126, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 14)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Long"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(125, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 14)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Wide"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TrackBar4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TrackBar3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TrackBar2)
        Me.GroupBox1.Controls.Add(Me.TrackBar1)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 5)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(209, 290)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(259, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(376, 28)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(497, 27)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(808, 472)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Paint v2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ClearToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents TrackBar3 As TrackBar
    Friend WithEvents TrackBar4 As TrackBar
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
