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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.displayPictureBox = New System.Windows.Forms.PictureBox()
        Me.modelsButton = New System.Windows.Forms.Button()
        Me.modelsPictureBox = New System.Windows.Forms.PictureBox()
        Me.modelxPictureBox = New System.Windows.Forms.PictureBox()
        Me.modelxButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.displayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.modelsPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.modelxPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'displayPictureBox
        '
        Me.displayPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.displayPictureBox.Name = "displayPictureBox"
        Me.displayPictureBox.Size = New System.Drawing.Size(322, 219)
        Me.displayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.displayPictureBox.TabIndex = 0
        Me.displayPictureBox.TabStop = False
        '
        'modelsButton
        '
        Me.modelsButton.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modelsButton.Location = New System.Drawing.Point(13, 238)
        Me.modelsButton.Name = "modelsButton"
        Me.modelsButton.Size = New System.Drawing.Size(75, 23)
        Me.modelsButton.TabIndex = 1
        Me.modelsButton.Text = "Model S"
        Me.modelsButton.UseVisualStyleBackColor = True
        '
        'modelsPictureBox
        '
        Me.modelsPictureBox.Image = CType(resources.GetObject("modelsPictureBox.Image"), System.Drawing.Image)
        Me.modelsPictureBox.Location = New System.Drawing.Point(12, 267)
        Me.modelsPictureBox.Name = "modelsPictureBox"
        Me.modelsPictureBox.Size = New System.Drawing.Size(76, 50)
        Me.modelsPictureBox.TabIndex = 2
        Me.modelsPictureBox.TabStop = False
        '
        'modelxPictureBox
        '
        Me.modelxPictureBox.Image = CType(resources.GetObject("modelxPictureBox.Image"), System.Drawing.Image)
        Me.modelxPictureBox.Location = New System.Drawing.Point(124, 267)
        Me.modelxPictureBox.Name = "modelxPictureBox"
        Me.modelxPictureBox.Size = New System.Drawing.Size(76, 50)
        Me.modelxPictureBox.TabIndex = 4
        Me.modelxPictureBox.TabStop = False
        '
        'modelxButton
        '
        Me.modelxButton.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modelxButton.Location = New System.Drawing.Point(125, 237)
        Me.modelxButton.Name = "modelxButton"
        Me.modelxButton.Size = New System.Drawing.Size(75, 23)
        Me.modelxButton.TabIndex = 3
        Me.modelxButton.Text = "Model X"
        Me.modelxButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(344, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Model:"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.nameLabel.Location = New System.Drawing.Point(425, 20)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(10, 15)
        Me.nameLabel.TabIndex = 6
        Me.nameLabel.Text = " "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(628, 316)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.modelxPictureBox)
        Me.Controls.Add(Me.modelxButton)
        Me.Controls.Add(Me.modelsPictureBox)
        Me.Controls.Add(Me.modelsButton)
        Me.Controls.Add(Me.displayPictureBox)
        Me.Name = "Form1"
        Me.Text = "TeslaDex"
        CType(Me.displayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.modelsPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.modelxPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents displayPictureBox As PictureBox
    Friend WithEvents modelsButton As Button
    Friend WithEvents modelsPictureBox As PictureBox
    Friend WithEvents modelxPictureBox As PictureBox
    Friend WithEvents modelxButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
