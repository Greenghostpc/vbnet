<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormNewGame
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
        Me.Button_StartGame = New System.Windows.Forms.Button()
        Me.Label_Player1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox_P1_isAI = New System.Windows.Forms.CheckBox()
        Me.CheckBox_P2_isAI = New System.Windows.Forms.CheckBox()
        Me.TextBox_P1_Name = New System.Windows.Forms.TextBox()
        Me.TextBox_P2_Name = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button_StartGame
        '
        Me.Button_StartGame.Location = New System.Drawing.Point(163, 115)
        Me.Button_StartGame.Name = "Button_StartGame"
        Me.Button_StartGame.Size = New System.Drawing.Size(75, 23)
        Me.Button_StartGame.TabIndex = 0
        Me.Button_StartGame.Text = "Begin Game"
        Me.Button_StartGame.UseVisualStyleBackColor = True
        '
        'Label_Player1
        '
        Me.Label_Player1.AutoSize = True
        Me.Label_Player1.Location = New System.Drawing.Point(23, 34)
        Me.Label_Player1.Name = "Label_Player1"
        Me.Label_Player1.Size = New System.Drawing.Size(48, 13)
        Me.Label_Player1.TabIndex = 1
        Me.Label_Player1.Text = "Player 1:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Player 2:"
        '
        'CheckBox_P1_isAI
        '
        Me.CheckBox_P1_isAI.AutoSize = True
        Me.CheckBox_P1_isAI.Location = New System.Drawing.Point(196, 34)
        Me.CheckBox_P1_isAI.Name = "CheckBox_P1_isAI"
        Me.CheckBox_P1_isAI.Size = New System.Drawing.Size(42, 17)
        Me.CheckBox_P1_isAI.TabIndex = 3
        Me.CheckBox_P1_isAI.Text = "AI?"
        Me.CheckBox_P1_isAI.UseVisualStyleBackColor = True
        '
        'CheckBox_P2_isAI
        '
        Me.CheckBox_P2_isAI.AutoSize = True
        Me.CheckBox_P2_isAI.Location = New System.Drawing.Point(196, 71)
        Me.CheckBox_P2_isAI.Name = "CheckBox_P2_isAI"
        Me.CheckBox_P2_isAI.Size = New System.Drawing.Size(42, 17)
        Me.CheckBox_P2_isAI.TabIndex = 4
        Me.CheckBox_P2_isAI.Text = "AI?"
        Me.CheckBox_P2_isAI.UseVisualStyleBackColor = True
        '
        'TextBox_P1_Name
        '
        Me.TextBox_P1_Name.Location = New System.Drawing.Point(77, 31)
        Me.TextBox_P1_Name.Name = "TextBox_P1_Name"
        Me.TextBox_P1_Name.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_P1_Name.TabIndex = 5
        Me.TextBox_P1_Name.Text = "Player I"
        '
        'TextBox_P2_Name
        '
        Me.TextBox_P2_Name.Location = New System.Drawing.Point(77, 72)
        Me.TextBox_P2_Name.Name = "TextBox_P2_Name"
        Me.TextBox_P2_Name.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_P2_Name.TabIndex = 6
        Me.TextBox_P2_Name.Text = "Player II"
        '
        'FormNewGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 152)
        Me.Controls.Add(Me.TextBox_P2_Name)
        Me.Controls.Add(Me.TextBox_P1_Name)
        Me.Controls.Add(Me.CheckBox_P2_isAI)
        Me.Controls.Add(Me.CheckBox_P1_isAI)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label_Player1)
        Me.Controls.Add(Me.Button_StartGame)
        Me.Name = "FormNewGame"
        Me.Text = "New Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_StartGame As Button
    Friend WithEvents Label_Player1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox_P1_isAI As CheckBox
    Friend WithEvents CheckBox_P2_isAI As CheckBox
    Friend WithEvents TextBox_P1_Name As TextBox
    Friend WithEvents TextBox_P2_Name As TextBox
End Class
