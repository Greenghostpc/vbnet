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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fillButton = New System.Windows.Forms.Button()
        Me.drainButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.radiusTextBox = New System.Windows.Forms.TextBox()
        Me.heightTextBox = New System.Windows.Forms.TextBox()
        Me.fillTextBox = New System.Windows.Forms.TextBox()
        Me.drainTextBox = New System.Windows.Forms.TextBox()
        Me.contentsTextBox = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Radius"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Height"
        '
        'fillButton
        '
        Me.fillButton.Location = New System.Drawing.Point(12, 103)
        Me.fillButton.Name = "fillButton"
        Me.fillButton.Size = New System.Drawing.Size(100, 23)
        Me.fillButton.TabIndex = 2
        Me.fillButton.Text = "Fill"
        Me.fillButton.UseVisualStyleBackColor = True
        '
        'drainButton
        '
        Me.drainButton.Location = New System.Drawing.Point(12, 147)
        Me.drainButton.Name = "drainButton"
        Me.drainButton.Size = New System.Drawing.Size(100, 23)
        Me.drainButton.TabIndex = 3
        Me.drainButton.Text = "Drain"
        Me.drainButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Contents"
        '
        'radiusTextBox
        '
        Me.radiusTextBox.Location = New System.Drawing.Point(128, 30)
        Me.radiusTextBox.Name = "radiusTextBox"
        Me.radiusTextBox.Size = New System.Drawing.Size(100, 20)
        Me.radiusTextBox.TabIndex = 5
        '
        'heightTextBox
        '
        Me.heightTextBox.Location = New System.Drawing.Point(128, 65)
        Me.heightTextBox.Name = "heightTextBox"
        Me.heightTextBox.Size = New System.Drawing.Size(100, 20)
        Me.heightTextBox.TabIndex = 6
        '
        'fillTextBox
        '
        Me.fillTextBox.Location = New System.Drawing.Point(128, 105)
        Me.fillTextBox.Name = "fillTextBox"
        Me.fillTextBox.Size = New System.Drawing.Size(100, 20)
        Me.fillTextBox.TabIndex = 7
        '
        'drainTextBox
        '
        Me.drainTextBox.Location = New System.Drawing.Point(128, 149)
        Me.drainTextBox.Name = "drainTextBox"
        Me.drainTextBox.Size = New System.Drawing.Size(100, 20)
        Me.drainTextBox.TabIndex = 8
        '
        'contentsTextBox
        '
        Me.contentsTextBox.Location = New System.Drawing.Point(128, 191)
        Me.contentsTextBox.Name = "contentsTextBox"
        Me.contentsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.contentsTextBox.TabIndex = 9
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 303)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(246, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(246, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(79, 229)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(75, 23)
        Me.calculateButton.TabIndex = 12
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 258)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(222, 42)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Fraction"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 325)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.contentsTextBox)
        Me.Controls.Add(Me.drainTextBox)
        Me.Controls.Add(Me.fillTextBox)
        Me.Controls.Add(Me.heightTextBox)
        Me.Controls.Add(Me.radiusTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.drainButton)
        Me.Controls.Add(Me.fillButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents fillButton As Button
    Friend WithEvents drainButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents radiusTextBox As TextBox
    Friend WithEvents heightTextBox As TextBox
    Friend WithEvents fillTextBox As TextBox
    Friend WithEvents drainTextBox As TextBox
    Friend WithEvents contentsTextBox As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents calculateButton As Button
    Friend WithEvents Button1 As Button
End Class
