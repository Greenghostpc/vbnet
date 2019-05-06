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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.firstComboBox = New System.Windows.Forms.ComboBox()
        Me.lastComboBox = New System.Windows.Forms.ComboBox()
        Me.emailComboBox = New System.Windows.Forms.ComboBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.photoPictureBox = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.brandComboBox = New System.Windows.Forms.ComboBox()
        Me.lengthComboBox = New System.Windows.Forms.ComboBox()
        Me.heightComboBox = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.photoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(593, 193)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'firstComboBox
        '
        Me.firstComboBox.FormattingEnabled = True
        Me.firstComboBox.Location = New System.Drawing.Point(11, 18)
        Me.firstComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.firstComboBox.Name = "firstComboBox"
        Me.firstComboBox.Size = New System.Drawing.Size(110, 25)
        Me.firstComboBox.TabIndex = 1
        '
        'lastComboBox
        '
        Me.lastComboBox.FormattingEnabled = True
        Me.lastComboBox.Location = New System.Drawing.Point(159, 18)
        Me.lastComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lastComboBox.Name = "lastComboBox"
        Me.lastComboBox.Size = New System.Drawing.Size(110, 25)
        Me.lastComboBox.TabIndex = 2
        '
        'emailComboBox
        '
        Me.emailComboBox.FormattingEnabled = True
        Me.emailComboBox.Location = New System.Drawing.Point(307, 18)
        Me.emailComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.emailComboBox.Name = "emailComboBox"
        Me.emailComboBox.Size = New System.Drawing.Size(110, 25)
        Me.emailComboBox.TabIndex = 3
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(256, 256)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'photoPictureBox
        '
        Me.photoPictureBox.Location = New System.Drawing.Point(14, 51)
        Me.photoPictureBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.photoPictureBox.Name = "photoPictureBox"
        Me.photoPictureBox.Size = New System.Drawing.Size(403, 311)
        Me.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.photoPictureBox.TabIndex = 4
        Me.photoPictureBox.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(17, 370)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 30)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "First"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(121, 370)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 30)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Next"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'brandComboBox
        '
        Me.brandComboBox.FormattingEnabled = True
        Me.brandComboBox.Location = New System.Drawing.Point(455, 18)
        Me.brandComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.brandComboBox.Name = "brandComboBox"
        Me.brandComboBox.Size = New System.Drawing.Size(110, 25)
        Me.brandComboBox.TabIndex = 7
        '
        'lengthComboBox
        '
        Me.lengthComboBox.FormattingEnabled = True
        Me.lengthComboBox.Location = New System.Drawing.Point(604, 18)
        Me.lengthComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lengthComboBox.Name = "lengthComboBox"
        Me.lengthComboBox.Size = New System.Drawing.Size(110, 25)
        Me.lengthComboBox.TabIndex = 8
        '
        'heightComboBox
        '
        Me.heightComboBox.FormattingEnabled = True
        Me.heightComboBox.Location = New System.Drawing.Point(752, 18)
        Me.heightComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.heightComboBox.Name = "heightComboBox"
        Me.heightComboBox.Size = New System.Drawing.Size(110, 25)
        Me.heightComboBox.TabIndex = 9
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(225, 371)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(98, 30)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Previous"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(329, 371)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(98, 30)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Last"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 588)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.heightComboBox)
        Me.Controls.Add(Me.lengthComboBox)
        Me.Controls.Add(Me.brandComboBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.photoPictureBox)
        Me.Controls.Add(Me.emailComboBox)
        Me.Controls.Add(Me.lastComboBox)
        Me.Controls.Add(Me.firstComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.photoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents firstComboBox As ComboBox
    Friend WithEvents lastComboBox As ComboBox
    Friend WithEvents emailComboBox As ComboBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents photoPictureBox As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents brandComboBox As ComboBox
    Friend WithEvents lengthComboBox As ComboBox
    Friend WithEvents heightComboBox As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
