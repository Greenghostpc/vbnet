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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.animalPictureBox = New System.Windows.Forms.PictureBox()
        Me.showPictureButton = New System.Windows.Forms.Button()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.indexLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.prevButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.addButton = New System.Windows.Forms.Button()
        CType(Me.animalPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Deer.jpg")
        Me.ImageList1.Images.SetKeyName(1, "Panda.jpg")
        Me.ImageList1.Images.SetKeyName(2, "Lion.jpg")
        Me.ImageList1.Images.SetKeyName(3, "Turtle.jpg")
        Me.ImageList1.Images.SetKeyName(4, "Bear.jpg")
        Me.ImageList1.Images.SetKeyName(5, "horse veiwer.jpg")
        Me.ImageList1.Images.SetKeyName(6, "Koala.jpg")
        Me.ImageList1.Images.SetKeyName(7, "Penguins.jpg")
        Me.ImageList1.Images.SetKeyName(8, "Cat.jpg")
        Me.ImageList1.Images.SetKeyName(9, "Squarl.jpg")
        '
        'animalPictureBox
        '
        Me.animalPictureBox.Location = New System.Drawing.Point(23, 12)
        Me.animalPictureBox.Name = "animalPictureBox"
        Me.animalPictureBox.Size = New System.Drawing.Size(248, 209)
        Me.animalPictureBox.TabIndex = 0
        Me.animalPictureBox.TabStop = False
        '
        'showPictureButton
        '
        Me.showPictureButton.Location = New System.Drawing.Point(303, 12)
        Me.showPictureButton.Name = "showPictureButton"
        Me.showPictureButton.Size = New System.Drawing.Size(106, 79)
        Me.showPictureButton.TabIndex = 1
        Me.showPictureButton.Text = "Show Pictures (slideshow)"
        Me.showPictureButton.UseVisualStyleBackColor = True
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(303, 116)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(88, 33)
        Me.nextButton.TabIndex = 2
        Me.nextButton.Text = "Next"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'indexLabel
        '
        Me.indexLabel.AutoSize = True
        Me.indexLabel.Location = New System.Drawing.Point(391, 163)
        Me.indexLabel.Name = "indexLabel"
        Me.indexLabel.Size = New System.Drawing.Size(0, 21)
        Me.indexLabel.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(212, 227)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 50)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'prevButton
        '
        Me.prevButton.Location = New System.Drawing.Point(407, 116)
        Me.prevButton.Name = "prevButton"
        Me.prevButton.Size = New System.Drawing.Size(88, 33)
        Me.prevButton.TabIndex = 5
        Me.prevButton.Text = "Prev"
        Me.prevButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(42, 243)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(75, 34)
        Me.addButton.TabIndex = 6
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 622)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.prevButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.indexLabel)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.showPictureButton)
        Me.Controls.Add(Me.animalPictureBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Photo Veiwer"
        CType(Me.animalPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents animalPictureBox As PictureBox
    Friend WithEvents showPictureButton As Button
    Friend WithEvents nextButton As Button
    Friend WithEvents indexLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents prevButton As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents addButton As Button
End Class
