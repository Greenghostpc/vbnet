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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Worth = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.homeworkTextBox = New System.Windows.Forms.TextBox()
        Me.tgradeTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.cwTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Fgradelabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(130, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Hw Grade"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Classwork grade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Testgrade"
        '
        'Worth
        '
        Me.Worth.AutoSize = True
        Me.Worth.Location = New System.Drawing.Point(273, 28)
        Me.Worth.Name = "Worth"
        Me.Worth.Size = New System.Drawing.Size(36, 13)
        Me.Worth.TabIndex = 4
        Me.Worth.Text = "Worth"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(248, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Final Grade"
        '
        'homeworkTextBox
        '
        Me.homeworkTextBox.Location = New System.Drawing.Point(12, 69)
        Me.homeworkTextBox.Name = "homeworkTextBox"
        Me.homeworkTextBox.Size = New System.Drawing.Size(100, 20)
        Me.homeworkTextBox.TabIndex = 6
        '
        'tgradeTextBox
        '
        Me.tgradeTextBox.Location = New System.Drawing.Point(12, 168)
        Me.tgradeTextBox.Name = "tgradeTextBox"
        Me.tgradeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.tgradeTextBox.TabIndex = 7
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(241, 112)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 8
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(241, 69)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 9
        '
        'cwTextBox
        '
        Me.cwTextBox.Location = New System.Drawing.Point(12, 112)
        Me.cwTextBox.Name = "cwTextBox"
        Me.cwTextBox.Size = New System.Drawing.Size(100, 20)
        Me.cwTextBox.TabIndex = 10
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(241, 152)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 11
        '
        'Fgradelabel
        '
        Me.Fgradelabel.AutoSize = True
        Me.Fgradelabel.Location = New System.Drawing.Point(251, 254)
        Me.Fgradelabel.Name = "Fgradelabel"
        Me.Fgradelabel.Size = New System.Drawing.Size(0, 13)
        Me.Fgradelabel.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 266)
        Me.Controls.Add(Me.Fgradelabel)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.cwTextBox)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.tgradeTextBox)
        Me.Controls.Add(Me.homeworkTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Worth)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "YEEEEET"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Worth As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents homeworkTextBox As TextBox
    Friend WithEvents tgradeTextBox As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents cwTextBox As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Fgradelabel As Label
End Class
