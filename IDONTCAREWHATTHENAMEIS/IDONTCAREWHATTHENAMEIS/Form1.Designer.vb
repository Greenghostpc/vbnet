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
        Me.SideTextBox = New System.Windows.Forms.TextBox()
        Me.AreaTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PerimeterTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.perimeter2TextBox = New System.Windows.Forms.TextBox()
        Me.area2TextBox = New System.Windows.Forms.TextBox()
        Me.widthTextBox = New System.Windows.Forms.TextBox()
        Me.lengthTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lTextBox = New System.Windows.Forms.TextBox()
        Me.wTextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.hTextBox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.vTextBox = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.saTextBox = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.radiusTextBox = New System.Windows.Forms.TextBox()
        Me.heightTextBox = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.contentsTextBox = New System.Windows.Forms.TextBox()
        Me.fillTextBox = New System.Windows.Forms.TextBox()
        Me.drainTextBox = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Side"
        '
        'SideTextBox
        '
        Me.SideTextBox.Location = New System.Drawing.Point(94, 26)
        Me.SideTextBox.Name = "SideTextBox"
        Me.SideTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SideTextBox.TabIndex = 1
        '
        'AreaTextBox
        '
        Me.AreaTextBox.Location = New System.Drawing.Point(94, 67)
        Me.AreaTextBox.Name = "AreaTextBox"
        Me.AreaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AreaTextBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Area"
        '
        'PerimeterTextBox
        '
        Me.PerimeterTextBox.Location = New System.Drawing.Point(94, 106)
        Me.PerimeterTextBox.Name = "PerimeterTextBox"
        Me.PerimeterTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PerimeterTextBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Perimeter"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(68, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AreaTextBox)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PerimeterTextBox)
        Me.GroupBox1.Controls.Add(Me.SideTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 178)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Square"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.perimeter2TextBox)
        Me.GroupBox2.Controls.Add(Me.area2TextBox)
        Me.GroupBox2.Controls.Add(Me.widthTextBox)
        Me.GroupBox2.Controls.Add(Me.lengthTextBox)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(257, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(208, 178)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rectangle"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(75, 144)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Calculate"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'perimeter2TextBox
        '
        Me.perimeter2TextBox.Location = New System.Drawing.Point(75, 101)
        Me.perimeter2TextBox.Name = "perimeter2TextBox"
        Me.perimeter2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.perimeter2TextBox.TabIndex = 7
        '
        'area2TextBox
        '
        Me.area2TextBox.Location = New System.Drawing.Point(75, 74)
        Me.area2TextBox.Name = "area2TextBox"
        Me.area2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.area2TextBox.TabIndex = 6
        '
        'widthTextBox
        '
        Me.widthTextBox.Location = New System.Drawing.Point(75, 53)
        Me.widthTextBox.Name = "widthTextBox"
        Me.widthTextBox.Size = New System.Drawing.Size(100, 20)
        Me.widthTextBox.TabIndex = 5
        '
        'lengthTextBox
        '
        Me.lengthTextBox.Location = New System.Drawing.Point(75, 26)
        Me.lengthTextBox.Name = "lengthTextBox"
        Me.lengthTextBox.Size = New System.Drawing.Size(100, 20)
        Me.lengthTextBox.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Perimeter"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Area"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Width"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Length"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(487, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(208, 178)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Right triangle"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(75, 144)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Calculate"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(75, 101)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(75, 74)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(75, 53)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 5
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(75, 26)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Perimeter"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Area"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Height"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Base"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(20, 220)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "length"
        '
        'lTextBox
        '
        Me.lTextBox.Location = New System.Drawing.Point(106, 220)
        Me.lTextBox.Name = "lTextBox"
        Me.lTextBox.Size = New System.Drawing.Size(100, 20)
        Me.lTextBox.TabIndex = 11
        '
        'wTextBox
        '
        Me.wTextBox.Location = New System.Drawing.Point(106, 246)
        Me.wTextBox.Name = "wTextBox"
        Me.wTextBox.Size = New System.Drawing.Size(100, 20)
        Me.wTextBox.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 246)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "width"
        '
        'hTextBox
        '
        Me.hTextBox.Location = New System.Drawing.Point(106, 272)
        Me.hTextBox.Name = "hTextBox"
        Me.hTextBox.Size = New System.Drawing.Size(100, 20)
        Me.hTextBox.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(20, 272)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "height"
        '
        'vTextBox
        '
        Me.vTextBox.Location = New System.Drawing.Point(106, 298)
        Me.vTextBox.Name = "vTextBox"
        Me.vTextBox.Size = New System.Drawing.Size(100, 20)
        Me.vTextBox.TabIndex = 17
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(20, 298)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 13)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "volume"
        '
        'saTextBox
        '
        Me.saTextBox.Location = New System.Drawing.Point(106, 328)
        Me.saTextBox.Name = "saTextBox"
        Me.saTextBox.Size = New System.Drawing.Size(100, 20)
        Me.saTextBox.TabIndex = 19
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(20, 328)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 13)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "SurfaceArea"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(92, 377)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "Calculate"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(348, 219)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 13)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Radius"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(351, 246)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(38, 13)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "Height"
        '
        'radiusTextBox
        '
        Me.radiusTextBox.Location = New System.Drawing.Point(396, 213)
        Me.radiusTextBox.Name = "radiusTextBox"
        Me.radiusTextBox.Size = New System.Drawing.Size(100, 20)
        Me.radiusTextBox.TabIndex = 23
        '
        'heightTextBox
        '
        Me.heightTextBox.Location = New System.Drawing.Point(396, 245)
        Me.heightTextBox.Name = "heightTextBox"
        Me.heightTextBox.Size = New System.Drawing.Size(100, 20)
        Me.heightTextBox.TabIndex = 24
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(312, 298)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 26
        Me.Button5.Text = "Fill"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(312, 341)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 27
        Me.Button6.Text = "Drain"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(329, 387)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 13)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "Contents"
        '
        'contentsTextBox
        '
        Me.contentsTextBox.Location = New System.Drawing.Point(396, 384)
        Me.contentsTextBox.Name = "contentsTextBox"
        Me.contentsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.contentsTextBox.TabIndex = 29
        '
        'fillTextBox
        '
        Me.fillTextBox.Location = New System.Drawing.Point(396, 297)
        Me.fillTextBox.Name = "fillTextBox"
        Me.fillTextBox.Size = New System.Drawing.Size(100, 20)
        Me.fillTextBox.TabIndex = 30
        '
        'drainTextBox
        '
        Me.drainTextBox.Location = New System.Drawing.Point(396, 341)
        Me.drainTextBox.Name = "drainTextBox"
        Me.drainTextBox.Size = New System.Drawing.Size(100, 20)
        Me.drainTextBox.TabIndex = 31
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(538, 209)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 32
        Me.Button7.Text = "Barrel"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.drainTextBox)
        Me.Controls.Add(Me.fillTextBox)
        Me.Controls.Add(Me.contentsTextBox)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.heightTextBox)
        Me.Controls.Add(Me.radiusTextBox)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.saTextBox)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.vTextBox)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.hTextBox)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.wTextBox)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lTextBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SideTextBox As TextBox
    Friend WithEvents AreaTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PerimeterTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents perimeter2TextBox As TextBox
    Friend WithEvents area2TextBox As TextBox
    Friend WithEvents widthTextBox As TextBox
    Friend WithEvents lengthTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lTextBox As TextBox
    Friend WithEvents wTextBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents hTextBox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents vTextBox As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents saTextBox As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents radiusTextBox As TextBox
    Friend WithEvents heightTextBox As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents contentsTextBox As TextBox
    Friend WithEvents fillTextBox As TextBox
    Friend WithEvents drainTextBox As TextBox
    Friend WithEvents Button7 As Button
End Class
