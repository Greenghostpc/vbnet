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
        Me.lblQ1Prompt = New System.Windows.Forms.Label()
        Me.lblQ2Prompt = New System.Windows.Forms.Label()
        Me.lblFEPrompt = New System.Windows.Forms.Label()
        Me.txtQ1Grade = New System.Windows.Forms.TextBox()
        Me.txtQ2Grade = New System.Windows.Forms.TextBox()
        Me.txtFEGrade = New System.Windows.Forms.TextBox()
        Me.lblGrades = New System.Windows.Forms.Label()
        Me.btnShowGrade = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblQ1Prompt
        '
        Me.lblQ1Prompt.AutoSize = True
        Me.lblQ1Prompt.Location = New System.Drawing.Point(25, 32)
        Me.lblQ1Prompt.Name = "lblQ1Prompt"
        Me.lblQ1Prompt.Size = New System.Drawing.Size(90, 13)
        Me.lblQ1Prompt.TabIndex = 0
        Me.lblQ1Prompt.Text = "Homework Grade"
        '
        'lblQ2Prompt
        '
        Me.lblQ2Prompt.AutoSize = True
        Me.lblQ2Prompt.Location = New System.Drawing.Point(25, 67)
        Me.lblQ2Prompt.Name = "lblQ2Prompt"
        Me.lblQ2Prompt.Size = New System.Drawing.Size(60, 13)
        Me.lblQ2Prompt.TabIndex = 1
        Me.lblQ2Prompt.Text = "Test Grade"
        '
        'lblFEPrompt
        '
        Me.lblFEPrompt.AutoSize = True
        Me.lblFEPrompt.Location = New System.Drawing.Point(25, 101)
        Me.lblFEPrompt.Name = "lblFEPrompt"
        Me.lblFEPrompt.Size = New System.Drawing.Size(90, 13)
        Me.lblFEPrompt.TabIndex = 2
        Me.lblFEPrompt.Text = "Final Exam Grade"
        '
        'txtQ1Grade
        '
        Me.txtQ1Grade.Location = New System.Drawing.Point(256, 29)
        Me.txtQ1Grade.Name = "txtQ1Grade"
        Me.txtQ1Grade.Size = New System.Drawing.Size(87, 20)
        Me.txtQ1Grade.TabIndex = 3
        '
        'txtQ2Grade
        '
        Me.txtQ2Grade.Location = New System.Drawing.Point(256, 64)
        Me.txtQ2Grade.Name = "txtQ2Grade"
        Me.txtQ2Grade.Size = New System.Drawing.Size(87, 20)
        Me.txtQ2Grade.TabIndex = 4
        '
        'txtFEGrade
        '
        Me.txtFEGrade.Location = New System.Drawing.Point(256, 98)
        Me.txtFEGrade.Name = "txtFEGrade"
        Me.txtFEGrade.Size = New System.Drawing.Size(87, 20)
        Me.txtFEGrade.TabIndex = 5
        '
        'lblGrades
        '
        Me.lblGrades.Location = New System.Drawing.Point(25, 143)
        Me.lblGrades.Name = "lblGrades"
        Me.lblGrades.Size = New System.Drawing.Size(240, 63)
        Me.lblGrades.TabIndex = 6
        '
        'btnShowGrade
        '
        Me.btnShowGrade.Location = New System.Drawing.Point(131, 137)
        Me.btnShowGrade.Name = "btnShowGrade"
        Me.btnShowGrade.Size = New System.Drawing.Size(91, 24)
        Me.btnShowGrade.TabIndex = 7
        Me.btnShowGrade.Text = "Your Grade"
        Me.btnShowGrade.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(150, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Text = "40"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(150, 64)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 9
        Me.TextBox2.Text = "40"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(150, 98)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 10
        Me.TextBox3.Text = "20"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.ToolStripSeparator2, Me.ToolStripLabel3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(368, 25)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 169)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(368, 22)
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(40, 22)
        Me.ToolStripLabel1.Text = "Home"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(40, 22)
        Me.ToolStripLabel2.Text = "About"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel3.Text = "Reset"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(264, 17)
        Me.ToolStripStatusLabel1.Text = "Running this application may lead to depression!"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 191)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnShowGrade)
        Me.Controls.Add(Me.lblGrades)
        Me.Controls.Add(Me.txtFEGrade)
        Me.Controls.Add(Me.txtQ2Grade)
        Me.Controls.Add(Me.txtQ1Grade)
        Me.Controls.Add(Me.lblFEPrompt)
        Me.Controls.Add(Me.lblQ2Prompt)
        Me.Controls.Add(Me.lblQ1Prompt)
        Me.Name = "Form1"
        Me.Text = " Grade Calculator"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblQ1Prompt As System.Windows.Forms.Label
    Friend WithEvents lblQ2Prompt As System.Windows.Forms.Label
    Friend WithEvents lblFEPrompt As System.Windows.Forms.Label
    Friend WithEvents txtQ1Grade As System.Windows.Forms.TextBox
    Friend WithEvents txtQ2Grade As System.Windows.Forms.TextBox
    Friend WithEvents txtFEGrade As System.Windows.Forms.TextBox
    Friend WithEvents lblGrades As System.Windows.Forms.Label
    Friend WithEvents btnShowGrade As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
