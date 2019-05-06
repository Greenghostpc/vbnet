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
        Me.components = New System.ComponentModel.Container()
        Dim Timer2 As System.Windows.Forms.Timer
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Avatar = New System.Windows.Forms.PictureBox()
        Me.guy2 = New System.Windows.Forms.PictureBox()
        Me.guy3 = New System.Windows.Forms.PictureBox()
        Me.guy1 = New System.Windows.Forms.PictureBox()
        Me.guy4 = New System.Windows.Forms.PictureBox()
        Me.goal2 = New System.Windows.Forms.PictureBox()
        Me.goal1 = New System.Windows.Forms.PictureBox()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Avatar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.guy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.guy3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.guy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.guy4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.goal2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.goal1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer2
        '
        Timer2.Enabled = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(-1, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(744, 25)
        Me.Label1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(722, -13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 313)
        Me.Label2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(-1, -3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 303)
        Me.Label3.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.OliveDrab
        Me.Label4.Location = New System.Drawing.Point(-1, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(730, 23)
        Me.Label4.TabIndex = 8
        '
        'Avatar
        '
        Me.Avatar.Image = Global.WindowsApp16.My.Resources.Resources.soccerBall
        Me.Avatar.Location = New System.Drawing.Point(351, 233)
        Me.Avatar.Name = "Avatar"
        Me.Avatar.Size = New System.Drawing.Size(45, 41)
        Me.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Avatar.TabIndex = 4
        Me.Avatar.TabStop = False
        '
        'guy2
        '
        Me.guy2.Image = CType(resources.GetObject("guy2.Image"), System.Drawing.Image)
        Me.guy2.Location = New System.Drawing.Point(213, 155)
        Me.guy2.Name = "guy2"
        Me.guy2.Size = New System.Drawing.Size(56, 114)
        Me.guy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.guy2.TabIndex = 3
        Me.guy2.TabStop = False
        '
        'guy3
        '
        Me.guy3.BackColor = System.Drawing.Color.Transparent
        Me.guy3.Image = CType(resources.GetObject("guy3.Image"), System.Drawing.Image)
        Me.guy3.Location = New System.Drawing.Point(496, 155)
        Me.guy3.Name = "guy3"
        Me.guy3.Size = New System.Drawing.Size(55, 114)
        Me.guy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.guy3.TabIndex = 2
        Me.guy3.TabStop = False
        '
        'guy1
        '
        Me.guy1.Image = CType(resources.GetObject("guy1.Image"), System.Drawing.Image)
        Me.guy1.Location = New System.Drawing.Point(137, 155)
        Me.guy1.Name = "guy1"
        Me.guy1.Size = New System.Drawing.Size(55, 114)
        Me.guy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.guy1.TabIndex = 1
        Me.guy1.TabStop = False
        '
        'guy4
        '
        Me.guy4.Image = CType(resources.GetObject("guy4.Image"), System.Drawing.Image)
        Me.guy4.Location = New System.Drawing.Point(557, 155)
        Me.guy4.Name = "guy4"
        Me.guy4.Size = New System.Drawing.Size(55, 114)
        Me.guy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.guy4.TabIndex = 0
        Me.guy4.TabStop = False
        '
        'goal2
        '
        Me.goal2.Image = CType(resources.GetObject("goal2.Image"), System.Drawing.Image)
        Me.goal2.Location = New System.Drawing.Point(629, 67)
        Me.goal2.Name = "goal2"
        Me.goal2.Size = New System.Drawing.Size(98, 207)
        Me.goal2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.goal2.TabIndex = 9
        Me.goal2.TabStop = False
        '
        'goal1
        '
        Me.goal1.Image = Global.WindowsApp16.My.Resources.Resources.goalie
        Me.goal1.Location = New System.Drawing.Point(33, 67)
        Me.goal1.Name = "goal1"
        Me.goal1.Size = New System.Drawing.Size(98, 207)
        Me.goal1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.goal1.TabIndex = 10
        Me.goal1.TabStop = False
        '
        'Timer3
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(739, 298)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.goal1)
        Me.Controls.Add(Me.goal2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.guy2)
        Me.Controls.Add(Me.guy3)
        Me.Controls.Add(Me.guy1)
        Me.Controls.Add(Me.guy4)
        Me.Controls.Add(Me.Avatar)
        Me.Name = "Form1"
        Me.Text = "Mnc Sof"
        CType(Me.Avatar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.guy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.guy3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.guy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.guy4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.goal2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.goal1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents guy4 As PictureBox
    Friend WithEvents guy1 As PictureBox
    Friend WithEvents guy3 As PictureBox
    Friend WithEvents guy2 As PictureBox
    Friend WithEvents Avatar As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents goal2 As PictureBox
    Friend WithEvents goal1 As PictureBox
    Friend WithEvents Timer3 As Timer
End Class
