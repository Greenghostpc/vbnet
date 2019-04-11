<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdministratorLogin
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
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.usernameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(63, 146)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(130, 13)
        Me.LinkLabel2.TabIndex = 14
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Not an Admin? Click here!"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(66, 108)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(61, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Login Page"
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Location = New System.Drawing.Point(119, 72)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.passwordTextBox.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Password:"
        '
        'usernameTextBox
        '
        Me.usernameTextBox.Location = New System.Drawing.Point(119, 32)
        Me.usernameTextBox.Name = "usernameTextBox"
        Me.usernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.usernameTextBox.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Username:"
        '
        'AdministratorLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 182)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.passwordTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.usernameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AdministratorLogin"
        Me.Text = "Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents passwordTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents usernameTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
