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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.mainPictureBox = New System.Windows.Forms.PictureBox()
        Me.colorButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.visualButton = New System.Windows.Forms.Button()
        CType(Me.mainPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainPictureBox
        '
        Me.mainPictureBox.Image = CType(resources.GetObject("mainPictureBox.Image"), System.Drawing.Image)
        Me.mainPictureBox.Location = New System.Drawing.Point(14, 13)
        Me.mainPictureBox.Name = "mainPictureBox"
        Me.mainPictureBox.Size = New System.Drawing.Size(468, 245)
        Me.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mainPictureBox.TabIndex = 0
        Me.mainPictureBox.TabStop = False
        '
        'colorButton
        '
        Me.colorButton.Location = New System.Drawing.Point(31, 264)
        Me.colorButton.Name = "colorButton"
        Me.colorButton.Size = New System.Drawing.Size(87, 24)
        Me.colorButton.TabIndex = 1
        Me.colorButton.Text = "Color"
        Me.colorButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(553, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name:"
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(619, 40)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(116, 20)
        Me.nameTextBox.TabIndex = 3
        '
        'visualButton
        '
        Me.visualButton.Location = New System.Drawing.Point(231, 264)
        Me.visualButton.Name = "visualButton"
        Me.visualButton.Size = New System.Drawing.Size(75, 23)
        Me.visualButton.TabIndex = 4
        Me.visualButton.Text = "Button1"
        Me.visualButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(933, 484)
        Me.Controls.Add(Me.visualButton)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.colorButton)
        Me.Controls.Add(Me.mainPictureBox)
        Me.Font = New System.Drawing.Font("Lucida Fax", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "YEET"
        CType(Me.mainPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainPictureBox As PictureBox
    Friend WithEvents colorButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents visualButton As Button
End Class
