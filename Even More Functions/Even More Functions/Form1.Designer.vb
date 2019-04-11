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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.aLabel = New System.Windows.Forms.Label()
        Me.pLabel = New System.Windows.Forms.Label()
        Me.Side1TextBox = New System.Windows.Forms.TextBox()
        Me.Side2TextBox = New System.Windows.Forms.TextBox()
        Me.Side3TextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(67, 203)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Side 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Side 2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Side 3:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Area"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Perimeter"
        '
        'aLabel
        '
        Me.aLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.aLabel.Location = New System.Drawing.Point(98, 132)
        Me.aLabel.Name = "aLabel"
        Me.aLabel.Size = New System.Drawing.Size(100, 23)
        Me.aLabel.TabIndex = 6
        '
        'pLabel
        '
        Me.pLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pLabel.Location = New System.Drawing.Point(98, 168)
        Me.pLabel.Name = "pLabel"
        Me.pLabel.Size = New System.Drawing.Size(100, 23)
        Me.pLabel.TabIndex = 7
        '
        'Side1TextBox
        '
        Me.Side1TextBox.Location = New System.Drawing.Point(98, 33)
        Me.Side1TextBox.Name = "Side1TextBox"
        Me.Side1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Side1TextBox.TabIndex = 8
        '
        'Side2TextBox
        '
        Me.Side2TextBox.Location = New System.Drawing.Point(98, 66)
        Me.Side2TextBox.Name = "Side2TextBox"
        Me.Side2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Side2TextBox.TabIndex = 9
        '
        'Side3TextBox
        '
        Me.Side3TextBox.Location = New System.Drawing.Point(98, 99)
        Me.Side3TextBox.Name = "Side3TextBox"
        Me.Side3TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Side3TextBox.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 259)
        Me.Controls.Add(Me.Side3TextBox)
        Me.Controls.Add(Me.Side2TextBox)
        Me.Controls.Add(Me.Side1TextBox)
        Me.Controls.Add(Me.pLabel)
        Me.Controls.Add(Me.aLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "EINS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents aLabel As Label
    Friend WithEvents pLabel As Label
    Friend WithEvents Side1TextBox As TextBox
    Friend WithEvents Side2TextBox As TextBox
    Friend WithEvents Side3TextBox As TextBox
End Class
