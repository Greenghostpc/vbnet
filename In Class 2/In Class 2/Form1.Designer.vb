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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.americanTextBox = New System.Windows.Forms.TextBox()
        Me.britishTextBox = New System.Windows.Forms.TextBox()
        Me.mexicanTextBox = New System.Windows.Forms.TextBox()
        Me.canadianTextBox = New System.Windows.Forms.TextBox()
        Me.japaneseTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.japaneseTextBox)
        Me.GroupBox1.Controls.Add(Me.canadianTextBox)
        Me.GroupBox1.Controls.Add(Me.mexicanTextBox)
        Me.GroupBox1.Controls.Add(Me.britishTextBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(51, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 198)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "American Dollars:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "British Pounds"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 14)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Mexican Pesos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 14)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Canadian Dollar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 14)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Japanese Yuro"
        '
        'americanTextBox
        '
        Me.americanTextBox.Location = New System.Drawing.Point(215, 46)
        Me.americanTextBox.Name = "americanTextBox"
        Me.americanTextBox.Size = New System.Drawing.Size(116, 21)
        Me.americanTextBox.TabIndex = 1
        '
        'britishTextBox
        '
        Me.britishTextBox.Location = New System.Drawing.Point(163, 22)
        Me.britishTextBox.Name = "britishTextBox"
        Me.britishTextBox.Size = New System.Drawing.Size(116, 21)
        Me.britishTextBox.TabIndex = 4
        '
        'mexicanTextBox
        '
        Me.mexicanTextBox.Location = New System.Drawing.Point(163, 70)
        Me.mexicanTextBox.Name = "mexicanTextBox"
        Me.mexicanTextBox.Size = New System.Drawing.Size(116, 21)
        Me.mexicanTextBox.TabIndex = 5
        '
        'canadianTextBox
        '
        Me.canadianTextBox.Location = New System.Drawing.Point(163, 114)
        Me.canadianTextBox.Name = "canadianTextBox"
        Me.canadianTextBox.Size = New System.Drawing.Size(116, 21)
        Me.canadianTextBox.TabIndex = 6
        '
        'japaneseTextBox
        '
        Me.japaneseTextBox.Location = New System.Drawing.Point(163, 158)
        Me.japaneseTextBox.Name = "japaneseTextBox"
        Me.japaneseTextBox.Size = New System.Drawing.Size(116, 21)
        Me.japaneseTextBox.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(84, 314)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 25)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(215, 314)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 25)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(390, 377)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.americanTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Currency Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents japaneseTextBox As TextBox
    Friend WithEvents canadianTextBox As TextBox
    Friend WithEvents mexicanTextBox As TextBox
    Friend WithEvents britishTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents americanTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
