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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.addButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.countLabel = New System.Windows.Forms.Label()
        Me.countButton = New System.Windows.Forms.Button()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.MoveButton = New System.Windows.Forms.Button()
        Me.addNamesButton = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"a", "b", "c"})
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(138, 12)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 95)
        Me.ListBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(264, 14)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(75, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "a"
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(264, 41)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(75, 23)
        Me.addButton.TabIndex = 3
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Count"
        '
        'countLabel
        '
        Me.countLabel.AutoSize = True
        Me.countLabel.Location = New System.Drawing.Point(12, 162)
        Me.countLabel.Name = "countLabel"
        Me.countLabel.Size = New System.Drawing.Size(0, 13)
        Me.countLabel.TabIndex = 5
        '
        'countButton
        '
        Me.countButton.Location = New System.Drawing.Point(12, 113)
        Me.countButton.Name = "countButton"
        Me.countButton.Size = New System.Drawing.Size(75, 23)
        Me.countButton.TabIndex = 6
        Me.countButton.Text = "Count"
        Me.countButton.UseVisualStyleBackColor = True
        '
        'RemoveButton
        '
        Me.RemoveButton.Location = New System.Drawing.Point(93, 113)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(75, 23)
        Me.RemoveButton.TabIndex = 7
        Me.RemoveButton.Text = "Remove"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(174, 113)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 8
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'MoveButton
        '
        Me.MoveButton.Location = New System.Drawing.Point(265, 71)
        Me.MoveButton.Name = "MoveButton"
        Me.MoveButton.Size = New System.Drawing.Size(75, 23)
        Me.MoveButton.TabIndex = 9
        Me.MoveButton.Text = "Move"
        Me.MoveButton.UseVisualStyleBackColor = True
        '
        'addNamesButton
        '
        Me.addNamesButton.Location = New System.Drawing.Point(264, 112)
        Me.addNamesButton.Name = "addNamesButton"
        Me.addNamesButton.Size = New System.Drawing.Size(75, 23)
        Me.addNamesButton.TabIndex = 10
        Me.addNamesButton.Text = "Add Names"
        Me.addNamesButton.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(53, 142)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton1.TabIndex = 11
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 358)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.addNamesButton)
        Me.Controls.Add(Me.MoveButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.countButton)
        Me.Controls.Add(Me.countLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Yeet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents addButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents countLabel As Label
    Friend WithEvents countButton As Button
    Friend WithEvents RemoveButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents MoveButton As Button
    Friend WithEvents addNamesButton As Button
    Friend WithEvents RadioButton1 As RadioButton
End Class
