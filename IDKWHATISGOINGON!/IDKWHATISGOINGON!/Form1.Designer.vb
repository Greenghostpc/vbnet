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
        Me.integerTextBox = New System.Windows.Forms.TextBox()
        Me.integeroutputTextBox = New System.Windows.Forms.TextBox()
        Me.doubleoutputTextBox = New System.Windows.Forms.TextBox()
        Me.doubleTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.decimaloutputTextBox = New System.Windows.Forms.TextBox()
        Me.decimalTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tryParseButton = New System.Windows.Forms.Button()
        Me.stringoutputTextBox = New System.Windows.Forms.TextBox()
        Me.stringTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Integer"
        '
        'integerTextBox
        '
        Me.integerTextBox.Location = New System.Drawing.Point(98, 13)
        Me.integerTextBox.Name = "integerTextBox"
        Me.integerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.integerTextBox.TabIndex = 1
        '
        'integeroutputTextBox
        '
        Me.integeroutputTextBox.Location = New System.Drawing.Point(254, 13)
        Me.integeroutputTextBox.Name = "integeroutputTextBox"
        Me.integeroutputTextBox.Size = New System.Drawing.Size(100, 20)
        Me.integeroutputTextBox.TabIndex = 2
        '
        'doubleoutputTextBox
        '
        Me.doubleoutputTextBox.Location = New System.Drawing.Point(254, 39)
        Me.doubleoutputTextBox.Name = "doubleoutputTextBox"
        Me.doubleoutputTextBox.Size = New System.Drawing.Size(100, 20)
        Me.doubleoutputTextBox.TabIndex = 5
        '
        'doubleTextBox
        '
        Me.doubleTextBox.Location = New System.Drawing.Point(98, 39)
        Me.doubleTextBox.Name = "doubleTextBox"
        Me.doubleTextBox.Size = New System.Drawing.Size(100, 20)
        Me.doubleTextBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Double"
        '
        'decimaloutputTextBox
        '
        Me.decimaloutputTextBox.Location = New System.Drawing.Point(254, 65)
        Me.decimaloutputTextBox.Name = "decimaloutputTextBox"
        Me.decimaloutputTextBox.Size = New System.Drawing.Size(100, 20)
        Me.decimaloutputTextBox.TabIndex = 8
        '
        'decimalTextBox
        '
        Me.decimalTextBox.Location = New System.Drawing.Point(98, 65)
        Me.decimalTextBox.Name = "decimalTextBox"
        Me.decimalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.decimalTextBox.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Decimal"
        '
        'tryParseButton
        '
        Me.tryParseButton.Location = New System.Drawing.Point(191, 117)
        Me.tryParseButton.Name = "tryParseButton"
        Me.tryParseButton.Size = New System.Drawing.Size(75, 23)
        Me.tryParseButton.TabIndex = 9
        Me.tryParseButton.Text = "TryParse"
        Me.tryParseButton.UseVisualStyleBackColor = True
        '
        'stringoutputTextBox
        '
        Me.stringoutputTextBox.Location = New System.Drawing.Point(254, 91)
        Me.stringoutputTextBox.Name = "stringoutputTextBox"
        Me.stringoutputTextBox.Size = New System.Drawing.Size(100, 20)
        Me.stringoutputTextBox.TabIndex = 12
        '
        'stringTextBox
        '
        Me.stringTextBox.Location = New System.Drawing.Point(98, 91)
        Me.stringTextBox.Name = "stringTextBox"
        Me.stringTextBox.Size = New System.Drawing.Size(100, 20)
        Me.stringTextBox.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "String"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.stringoutputTextBox)
        Me.Controls.Add(Me.stringTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tryParseButton)
        Me.Controls.Add(Me.decimaloutputTextBox)
        Me.Controls.Add(Me.decimalTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.doubleoutputTextBox)
        Me.Controls.Add(Me.doubleTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.integeroutputTextBox)
        Me.Controls.Add(Me.integerTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Data Types"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents integerTextBox As TextBox
    Friend WithEvents integeroutputTextBox As TextBox
    Friend WithEvents doubleoutputTextBox As TextBox
    Friend WithEvents doubleTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents decimaloutputTextBox As TextBox
    Friend WithEvents decimalTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tryParseButton As Button
    Friend WithEvents stringoutputTextBox As TextBox
    Friend WithEvents stringTextBox As TextBox
    Friend WithEvents Label4 As Label
End Class
