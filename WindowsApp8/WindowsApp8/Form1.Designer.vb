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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.redTextBox = New System.Windows.Forms.TextBox()
        Me.greenTextBox = New System.Windows.Forms.TextBox()
        Me.blueTextBox = New System.Windows.Forms.TextBox()
        Me.viewColorButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.colorPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.colorPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Red(0-225)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Green(0-225)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Blue(0-225)"
        '
        'redTextBox
        '
        Me.redTextBox.Location = New System.Drawing.Point(142, 9)
        Me.redTextBox.Name = "redTextBox"
        Me.redTextBox.Size = New System.Drawing.Size(100, 20)
        Me.redTextBox.TabIndex = 3
        '
        'greenTextBox
        '
        Me.greenTextBox.Location = New System.Drawing.Point(142, 37)
        Me.greenTextBox.Name = "greenTextBox"
        Me.greenTextBox.Size = New System.Drawing.Size(100, 20)
        Me.greenTextBox.TabIndex = 4
        '
        'blueTextBox
        '
        Me.blueTextBox.Location = New System.Drawing.Point(142, 63)
        Me.blueTextBox.Name = "blueTextBox"
        Me.blueTextBox.Size = New System.Drawing.Size(100, 20)
        Me.blueTextBox.TabIndex = 5
        '
        'viewColorButton
        '
        Me.viewColorButton.Location = New System.Drawing.Point(13, 107)
        Me.viewColorButton.Name = "viewColorButton"
        Me.viewColorButton.Size = New System.Drawing.Size(75, 23)
        Me.viewColorButton.TabIndex = 6
        Me.viewColorButton.Text = "View Color"
        Me.viewColorButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(142, 106)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'colorPictureBox
        '
        Me.colorPictureBox.Location = New System.Drawing.Point(301, 37)
        Me.colorPictureBox.Name = "colorPictureBox"
        Me.colorPictureBox.Size = New System.Drawing.Size(134, 92)
        Me.colorPictureBox.TabIndex = 8
        Me.colorPictureBox.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 163)
        Me.Controls.Add(Me.colorPictureBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.viewColorButton)
        Me.Controls.Add(Me.blueTextBox)
        Me.Controls.Add(Me.greenTextBox)
        Me.Controls.Add(Me.redTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "lllll"
        CType(Me.colorPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents redTextBox As TextBox
    Friend WithEvents greenTextBox As TextBox
    Friend WithEvents blueTextBox As TextBox
    Friend WithEvents viewColorButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents colorPictureBox As PictureBox
End Class
