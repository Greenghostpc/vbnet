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
        Me.outputLabel = New System.Windows.Forms.Label()
        Me.inputTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.outputPartTwoLabel = New System.Windows.Forms.Label()
        Me.inputPartTwoTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.outputPartThreeLabel = New System.Windows.Forms.Label()
        Me.inputPartThreeTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 46)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'outputLabel
        '
        Me.outputLabel.AutoSize = True
        Me.outputLabel.Location = New System.Drawing.Point(39, 61)
        Me.outputLabel.Name = "outputLabel"
        Me.outputLabel.Size = New System.Drawing.Size(37, 20)
        Me.outputLabel.TabIndex = 1
        Me.outputLabel.Text = "Feet"
        '
        'inputTextBox
        '
        Me.inputTextBox.Location = New System.Drawing.Point(12, 118)
        Me.inputTextBox.Name = "inputTextBox"
        Me.inputTextBox.Size = New System.Drawing.Size(86, 27)
        Me.inputTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter Miles"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(104, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 46)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Calculate"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'outputPartTwoLabel
        '
        Me.outputPartTwoLabel.AutoSize = True
        Me.outputPartTwoLabel.Location = New System.Drawing.Point(124, 61)
        Me.outputPartTwoLabel.Name = "outputPartTwoLabel"
        Me.outputPartTwoLabel.Size = New System.Drawing.Size(44, 20)
        Me.outputPartTwoLabel.TabIndex = 6
        Me.outputPartTwoLabel.Text = "yards"
        '
        'inputPartTwoTextBox
        '
        Me.inputPartTwoTextBox.Location = New System.Drawing.Point(112, 118)
        Me.inputPartTwoTextBox.Name = "inputPartTwoTextBox"
        Me.inputPartTwoTextBox.Size = New System.Drawing.Size(78, 27)
        Me.inputPartTwoTextBox.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(108, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Enter Miles"
        '
        'outputPartThreeLabel
        '
        Me.outputPartThreeLabel.AutoSize = True
        Me.outputPartThreeLabel.Location = New System.Drawing.Point(214, 61)
        Me.outputPartThreeLabel.Name = "outputPartThreeLabel"
        Me.outputPartThreeLabel.Size = New System.Drawing.Size(54, 20)
        Me.outputPartThreeLabel.TabIndex = 12
        Me.outputPartThreeLabel.Text = "Meters"
        '
        'inputPartThreeTextBox
        '
        Me.inputPartThreeTextBox.Location = New System.Drawing.Point(204, 118)
        Me.inputPartThreeTextBox.Name = "inputPartThreeTextBox"
        Me.inputPartThreeTextBox.Size = New System.Drawing.Size(78, 27)
        Me.inputPartThreeTextBox.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(200, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Enter Miles"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(196, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 46)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Calculate"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 160)
        Me.Controls.Add(Me.outputPartThreeLabel)
        Me.Controls.Add(Me.inputPartThreeTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.inputPartTwoTextBox)
        Me.Controls.Add(Me.outputPartTwoLabel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.inputTextBox)
        Me.Controls.Add(Me.outputLabel)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents outputLabel As Label
    Friend WithEvents inputTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents outputPartTwoLabel As Label
    Friend WithEvents inputPartTwoTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents outputPartThreeLabel As Label
    Friend WithEvents inputPartThreeTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
End Class
