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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StudentLoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeacherLoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministratorLoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(384, 73)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Wilkommen!"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentLoginToolStripMenuItem, Me.TeacherLoginToolStripMenuItem, Me.AdministratorLoginToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(592, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StudentLoginToolStripMenuItem
        '
        Me.StudentLoginToolStripMenuItem.Name = "StudentLoginToolStripMenuItem"
        Me.StudentLoginToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.StudentLoginToolStripMenuItem.Text = "Student Login"
        '
        'TeacherLoginToolStripMenuItem
        '
        Me.TeacherLoginToolStripMenuItem.Name = "TeacherLoginToolStripMenuItem"
        Me.TeacherLoginToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.TeacherLoginToolStripMenuItem.Text = "Teacher Login"
        '
        'AdministratorLoginToolStripMenuItem
        '
        Me.AdministratorLoginToolStripMenuItem.Name = "AdministratorLoginToolStripMenuItem"
        Me.AdministratorLoginToolStripMenuItem.Size = New System.Drawing.Size(125, 20)
        Me.AdministratorLoginToolStripMenuItem.Text = "Administrator Login"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 118)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mainform"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StudentLoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TeacherLoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministratorLoginToolStripMenuItem As ToolStripMenuItem
End Class
