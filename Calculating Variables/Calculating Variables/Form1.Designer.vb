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
        Me.AnswerLabel = New System.Windows.Forms.Label()
        Me.firsttextBox = New System.Windows.Forms.TextBox()
        Me.secondTextBox = New System.Windows.Forms.TextBox()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(281, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 26)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AnswerLabel
        '
        Me.AnswerLabel.AutoSize = True
        Me.AnswerLabel.Location = New System.Drawing.Point(85, 194)
        Me.AnswerLabel.Name = "AnswerLabel"
        Me.AnswerLabel.Size = New System.Drawing.Size(0, 13)
        Me.AnswerLabel.TabIndex = 1
        '
        'firsttextBox
        '
        Me.firsttextBox.Location = New System.Drawing.Point(88, 67)
        Me.firsttextBox.Name = "firsttextBox"
        Me.firsttextBox.Size = New System.Drawing.Size(100, 22)
        Me.firsttextBox.TabIndex = 2
        '
        'secondTextBox
        '
        Me.secondTextBox.Location = New System.Drawing.Point(88, 129)
        Me.secondTextBox.Name = "secondTextBox"
        Me.secondTextBox.Size = New System.Drawing.Size(100, 22)
        Me.secondTextBox.TabIndex = 3
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 450)
        Me.Splitter1.TabIndex = 4
        Me.Splitter1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(281, 127)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Subtract"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.secondTextBox)
        Me.Controls.Add(Me.firsttextBox)
        Me.Controls.Add(Me.AnswerLabel)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Calculating Variables"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents AnswerLabel As Label
    Friend WithEvents firsttextBox As TextBox
    Friend WithEvents secondTextBox As TextBox
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Button2 As Button
End Class
