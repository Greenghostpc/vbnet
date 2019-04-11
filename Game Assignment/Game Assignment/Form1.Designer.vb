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
        Me.clickHereButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.leftLabel = New System.Windows.Forms.Label()
        Me.midLabel = New System.Windows.Forms.Label()
        Me.rightLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.congLabel = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'clickHereButton
        '
        Me.clickHereButton.BackgroundImage = Global.Game_Assignment.My.Resources.Resources.pattterm
        Me.clickHereButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clickHereButton.Location = New System.Drawing.Point(11, 148)
        Me.clickHereButton.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.clickHereButton.Name = "clickHereButton"
        Me.clickHereButton.Size = New System.Drawing.Size(353, 28)
        Me.clickHereButton.TabIndex = 5
        Me.clickHereButton.Text = "Spin It for $5"
        Me.clickHereButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.clickHereButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(546, 78)
        Me.Button1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 44)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Collect Prize"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(464, 24)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(339, 33)
        Me.ComboBox1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(238, 337)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 25)
        Me.Label1.TabIndex = 9
        '
        'leftLabel
        '
        Me.leftLabel.AutoSize = True
        Me.leftLabel.Location = New System.Drawing.Point(6, 78)
        Me.leftLabel.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.leftLabel.Name = "leftLabel"
        Me.leftLabel.Size = New System.Drawing.Size(30, 25)
        Me.leftLabel.TabIndex = 10
        Me.leftLabel.Text = "X"
        '
        'midLabel
        '
        Me.midLabel.AutoSize = True
        Me.midLabel.Location = New System.Drawing.Point(129, 78)
        Me.midLabel.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.midLabel.Name = "midLabel"
        Me.midLabel.Size = New System.Drawing.Size(30, 25)
        Me.midLabel.TabIndex = 11
        Me.midLabel.Text = "X"
        '
        'rightLabel
        '
        Me.rightLabel.AutoSize = True
        Me.rightLabel.Location = New System.Drawing.Point(274, 78)
        Me.rightLabel.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.rightLabel.Name = "rightLabel"
        Me.rightLabel.Size = New System.Drawing.Size(30, 25)
        Me.rightLabel.TabIndex = 12
        Me.rightLabel.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Balance:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(134, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "75"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(82, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 25)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Your Prize Here"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(418, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(395, 25)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "You may only collect one of each prize"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(560, 189)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(201, 33)
        Me.TextBox1.TabIndex = 17
        '
        'congLabel
        '
        Me.congLabel.AutoSize = True
        Me.congLabel.Location = New System.Drawing.Point(36, 250)
        Me.congLabel.Name = "congLabel"
        Me.congLabel.Size = New System.Drawing.Size(0, 25)
        Me.congLabel.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(612, 243)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 32)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Enter Name"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(447, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 25)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(91, 308)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 25)
        Me.Label7.TabIndex = 22
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(211, 308)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 25)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Ago"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Game_Assignment.My.Resources.Resources.gambling
        Me.ClientSize = New System.Drawing.Size(819, 383)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.congLabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rightLabel)
        Me.Controls.Add(Me.midLabel)
        Me.Controls.Add(Me.leftLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.clickHereButton)
        Me.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Gambling Is Fun!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents clickHereButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents leftLabel As Label
    Friend WithEvents midLabel As Label
    Friend WithEvents rightLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents congLabel As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label8 As Label
End Class
