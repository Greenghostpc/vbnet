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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.coftTextBox = New System.Windows.Forms.TextBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.FinalPriceLabel = New System.Windows.Forms.Label()
        Me.percentoftiptextbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'coftTextBox
        '
        Me.coftTextBox.Font = New System.Drawing.Font("Goudy Stout", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coftTextBox.Location = New System.Drawing.Point(481, 77)
        Me.coftTextBox.Name = "coftTextBox"
        Me.coftTextBox.Size = New System.Drawing.Size(100, 36)
        Me.coftTextBox.TabIndex = 0
        '
        'calcButton
        '
        Me.calcButton.Font = New System.Drawing.Font("Goudy Stout", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calcButton.Location = New System.Drawing.Point(119, 171)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(319, 36)
        Me.calcButton.TabIndex = 1
        Me.calcButton.Text = "Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'FinalPriceLabel
        '
        Me.FinalPriceLabel.AutoSize = True
        Me.FinalPriceLabel.Font = New System.Drawing.Font("Goudy Stout", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinalPriceLabel.Location = New System.Drawing.Point(476, 179)
        Me.FinalPriceLabel.Name = "FinalPriceLabel"
        Me.FinalPriceLabel.Size = New System.Drawing.Size(0, 28)
        Me.FinalPriceLabel.TabIndex = 2
        '
        'percentoftiptextbox
        '
        Me.percentoftiptextbox.Font = New System.Drawing.Font("Goudy Stout", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.percentoftiptextbox.Location = New System.Drawing.Point(481, 121)
        Me.percentoftiptextbox.Name = "percentoftiptextbox"
        Me.percentoftiptextbox.Size = New System.Drawing.Size(100, 36)
        Me.percentoftiptextbox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Goudy Stout", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Price (without sales tax)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Goudy Stout", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(345, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 28)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tip:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(453, 251)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(249, 158)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Brush Script MT", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(450, 428)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Käsespätzle"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.percentoftiptextbox)
        Me.Controls.Add(Me.FinalPriceLabel)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.coftTextBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents coftTextBox As TextBox
    Friend WithEvents calcButton As Button
    Friend WithEvents FinalPriceLabel As Label
    Friend WithEvents percentoftiptextbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
End Class
