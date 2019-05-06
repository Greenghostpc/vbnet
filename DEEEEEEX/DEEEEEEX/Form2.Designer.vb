<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.firstTextBox = New System.Windows.Forms.TextBox()
        Me.lastTextBox = New System.Windows.Forms.TextBox()
        Me.emailTextBox = New System.Windows.Forms.TextBox()
        Me.photoPictureBox = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.brandTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lengthTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.heightTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.photoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(289, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Model"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(289, 56)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mileage"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(289, 86)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cost"
        '
        'firstTextBox
        '
        Me.firstTextBox.Location = New System.Drawing.Point(377, 26)
        Me.firstTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.firstTextBox.Name = "firstTextBox"
        Me.firstTextBox.Size = New System.Drawing.Size(132, 22)
        Me.firstTextBox.TabIndex = 0
        '
        'lastTextBox
        '
        Me.lastTextBox.Location = New System.Drawing.Point(377, 56)
        Me.lastTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lastTextBox.Name = "lastTextBox"
        Me.lastTextBox.Size = New System.Drawing.Size(132, 22)
        Me.lastTextBox.TabIndex = 1
        '
        'emailTextBox
        '
        Me.emailTextBox.Location = New System.Drawing.Point(377, 86)
        Me.emailTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.Size = New System.Drawing.Size(132, 22)
        Me.emailTextBox.TabIndex = 2
        '
        'photoPictureBox
        '
        Me.photoPictureBox.Location = New System.Drawing.Point(16, 14)
        Me.photoPictureBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.photoPictureBox.Name = "photoPictureBox"
        Me.photoPictureBox.Size = New System.Drawing.Size(265, 157)
        Me.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.photoPictureBox.TabIndex = 10
        Me.photoPictureBox.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(428, 291)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 27)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(584, 290)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 27)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(49, 190)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 27)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Add Picture"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'brandTextBox
        '
        Me.brandTextBox.Location = New System.Drawing.Point(377, 116)
        Me.brandTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.brandTextBox.Name = "brandTextBox"
        Me.brandTextBox.Size = New System.Drawing.Size(132, 22)
        Me.brandTextBox.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(289, 116)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Brand"
        '
        'lengthTextBox
        '
        Me.lengthTextBox.Location = New System.Drawing.Point(377, 146)
        Me.lengthTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lengthTextBox.Name = "lengthTextBox"
        Me.lengthTextBox.Size = New System.Drawing.Size(132, 22)
        Me.lengthTextBox.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(289, 146)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 15)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Length"
        '
        'heightTextBox
        '
        Me.heightTextBox.Location = New System.Drawing.Point(377, 176)
        Me.heightTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.heightTextBox.Name = "heightTextBox"
        Me.heightTextBox.Size = New System.Drawing.Size(132, 22)
        Me.heightTextBox.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(289, 176)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 15)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Height"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 376)
        Me.Controls.Add(Me.heightTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lengthTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.brandTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.photoPictureBox)
        Me.Controls.Add(Me.emailTextBox)
        Me.Controls.Add(Me.lastTextBox)
        Me.Controls.Add(Me.firstTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.photoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents firstTextBox As TextBox
    Friend WithEvents lastTextBox As TextBox
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents photoPictureBox As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents brandTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lengthTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents heightTextBox As TextBox
    Friend WithEvents Label6 As Label
End Class
