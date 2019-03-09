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
        Me.Box1 = New System.Windows.Forms.Label()
        Me.Box4 = New System.Windows.Forms.Label()
        Me.Box3 = New System.Windows.Forms.Label()
        Me.Box2 = New System.Windows.Forms.Label()
        Me.Box5 = New System.Windows.Forms.Label()
        Me.Box6 = New System.Windows.Forms.Label()
        Me.Box8 = New System.Windows.Forms.Label()
        Me.Box9 = New System.Windows.Forms.Label()
        Me.Box7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Box1
        '
        Me.Box1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Box1.Location = New System.Drawing.Point(218, 35)
        Me.Box1.Name = "Box1"
        Me.Box1.Size = New System.Drawing.Size(126, 104)
        Me.Box1.TabIndex = 0
        Me.Box1.Text = " "
        '
        'Box4
        '
        Me.Box4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Box4.Location = New System.Drawing.Point(218, 154)
        Me.Box4.Name = "Box4"
        Me.Box4.Size = New System.Drawing.Size(126, 104)
        Me.Box4.TabIndex = 1
        '
        'Box3
        '
        Me.Box3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Box3.Location = New System.Drawing.Point(482, 35)
        Me.Box3.Name = "Box3"
        Me.Box3.Size = New System.Drawing.Size(126, 104)
        Me.Box3.TabIndex = 2
        '
        'Box2
        '
        Me.Box2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Box2.Location = New System.Drawing.Point(350, 35)
        Me.Box2.Name = "Box2"
        Me.Box2.Size = New System.Drawing.Size(126, 104)
        Me.Box2.TabIndex = 3
        '
        'Box5
        '
        Me.Box5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Box5.Location = New System.Drawing.Point(350, 154)
        Me.Box5.Name = "Box5"
        Me.Box5.Size = New System.Drawing.Size(126, 104)
        Me.Box5.TabIndex = 4
        '
        'Box6
        '
        Me.Box6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Box6.Location = New System.Drawing.Point(482, 154)
        Me.Box6.Name = "Box6"
        Me.Box6.Size = New System.Drawing.Size(126, 104)
        Me.Box6.TabIndex = 5
        '
        'Box8
        '
        Me.Box8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Box8.Location = New System.Drawing.Point(350, 271)
        Me.Box8.Name = "Box8"
        Me.Box8.Size = New System.Drawing.Size(126, 104)
        Me.Box8.TabIndex = 6
        '
        'Box9
        '
        Me.Box9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Box9.Location = New System.Drawing.Point(482, 271)
        Me.Box9.Name = "Box9"
        Me.Box9.Size = New System.Drawing.Size(126, 104)
        Me.Box9.TabIndex = 7
        '
        'Box7
        '
        Me.Box7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Box7.Location = New System.Drawing.Point(218, 271)
        Me.Box7.Name = "Box7"
        Me.Box7.Size = New System.Drawing.Size(126, 104)
        Me.Box7.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(113, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(113, 228)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Check Winner"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Box7)
        Me.Controls.Add(Me.Box9)
        Me.Controls.Add(Me.Box8)
        Me.Controls.Add(Me.Box6)
        Me.Controls.Add(Me.Box5)
        Me.Controls.Add(Me.Box2)
        Me.Controls.Add(Me.Box3)
        Me.Controls.Add(Me.Box4)
        Me.Controls.Add(Me.Box1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Box1 As Label
    Friend WithEvents Box4 As Label
    Friend WithEvents Box3 As Label
    Friend WithEvents Box2 As Label
    Friend WithEvents Box5 As Label
    Friend WithEvents Box6 As Label
    Friend WithEvents Box8 As Label
    Friend WithEvents Box9 As Label
    Friend WithEvents Box7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
