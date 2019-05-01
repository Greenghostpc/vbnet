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
        Me.testTextBox = New System.Windows.Forms.TextBox()
        Me.homeworkTextBox = New System.Windows.Forms.TextBox()
        Me.finalTextBox = New System.Windows.Forms.TextBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.answerLabel = New System.Windows.Forms.Label()
        Me.testButton = New System.Windows.Forms.Button()
        Me.homeworkButton = New System.Windows.Forms.Button()
        Me.finalButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Test"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Homework"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Final Exam"
        '
        'testTextBox
        '
        Me.testTextBox.Location = New System.Drawing.Point(80, 15)
        Me.testTextBox.Name = "testTextBox"
        Me.testTextBox.Size = New System.Drawing.Size(100, 20)
        Me.testTextBox.TabIndex = 3
        '
        'homeworkTextBox
        '
        Me.homeworkTextBox.Location = New System.Drawing.Point(80, 48)
        Me.homeworkTextBox.Name = "homeworkTextBox"
        Me.homeworkTextBox.Size = New System.Drawing.Size(100, 20)
        Me.homeworkTextBox.TabIndex = 4
        '
        'finalTextBox
        '
        Me.finalTextBox.Location = New System.Drawing.Point(80, 81)
        Me.finalTextBox.Name = "finalTextBox"
        Me.finalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.finalTextBox.TabIndex = 5
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(17, 131)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(75, 23)
        Me.calculateButton.TabIndex = 6
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(96, 131)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'answerLabel
        '
        Me.answerLabel.AutoSize = True
        Me.answerLabel.Location = New System.Drawing.Point(171, 166)
        Me.answerLabel.Name = "answerLabel"
        Me.answerLabel.Size = New System.Drawing.Size(0, 13)
        Me.answerLabel.TabIndex = 8
        '
        'testButton
        '
        Me.testButton.Location = New System.Drawing.Point(187, 18)
        Me.testButton.Name = "testButton"
        Me.testButton.Size = New System.Drawing.Size(75, 23)
        Me.testButton.TabIndex = 9
        Me.testButton.Text = "Button1"
        Me.testButton.UseVisualStyleBackColor = True
        '
        'homeworkButton
        '
        Me.homeworkButton.Location = New System.Drawing.Point(187, 44)
        Me.homeworkButton.Name = "homeworkButton"
        Me.homeworkButton.Size = New System.Drawing.Size(75, 23)
        Me.homeworkButton.TabIndex = 10
        Me.homeworkButton.Text = "Button3"
        Me.homeworkButton.UseVisualStyleBackColor = True
        '
        'finalButton
        '
        Me.finalButton.Location = New System.Drawing.Point(187, 77)
        Me.finalButton.Name = "finalButton"
        Me.finalButton.Size = New System.Drawing.Size(75, 23)
        Me.finalButton.TabIndex = 11
        Me.finalButton.Text = "Button4"
        Me.finalButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.finalButton)
        Me.Controls.Add(Me.homeworkButton)
        Me.Controls.Add(Me.testButton)
        Me.Controls.Add(Me.answerLabel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.finalTextBox)
        Me.Controls.Add(Me.homeworkTextBox)
        Me.Controls.Add(Me.testTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "GradeCalculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents testTextBox As TextBox
    Friend WithEvents homeworkTextBox As TextBox
    Friend WithEvents finalTextBox As TextBox
    Friend WithEvents calculateButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents answerLabel As Label
    Friend WithEvents testButton As Button
    Friend WithEvents homeworkButton As Button
    Friend WithEvents finalButton As Button
End Class
