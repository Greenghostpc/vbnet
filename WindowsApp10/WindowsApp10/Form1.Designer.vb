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
        Me.mileButton = New System.Windows.Forms.Button()
        Me.yardsButton = New System.Windows.Forms.Button()
        Me.metersButton = New System.Windows.Forms.Button()
        Me.answerlabel = New System.Windows.Forms.Label()
        Me.inputTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'mileButton
        '
        Me.mileButton.Location = New System.Drawing.Point(12, 12)
        Me.mileButton.Name = "mileButton"
        Me.mileButton.Size = New System.Drawing.Size(87, 23)
        Me.mileButton.TabIndex = 0
        Me.mileButton.Text = "Miles To Feet"
        Me.mileButton.UseVisualStyleBackColor = True
        '
        'yardsButton
        '
        Me.yardsButton.Location = New System.Drawing.Point(12, 42)
        Me.yardsButton.Name = "yardsButton"
        Me.yardsButton.Size = New System.Drawing.Size(87, 23)
        Me.yardsButton.TabIndex = 1
        Me.yardsButton.Text = "Yards to Feet"
        Me.yardsButton.UseVisualStyleBackColor = True
        '
        'metersButton
        '
        Me.metersButton.Location = New System.Drawing.Point(12, 72)
        Me.metersButton.Name = "metersButton"
        Me.metersButton.Size = New System.Drawing.Size(87, 23)
        Me.metersButton.TabIndex = 2
        Me.metersButton.Text = "Meters to Feet"
        Me.metersButton.UseVisualStyleBackColor = True
        '
        'answerlabel
        '
        Me.answerlabel.AutoSize = True
        Me.answerlabel.Location = New System.Drawing.Point(147, 52)
        Me.answerlabel.Name = "answerlabel"
        Me.answerlabel.Size = New System.Drawing.Size(0, 13)
        Me.answerlabel.TabIndex = 4
        '
        'inputTextBox
        '
        Me.inputTextBox.Location = New System.Drawing.Point(167, 12)
        Me.inputTextBox.Name = "inputTextBox"
        Me.inputTextBox.Size = New System.Drawing.Size(100, 22)
        Me.inputTextBox.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 120)
        Me.Controls.Add(Me.inputTextBox)
        Me.Controls.Add(Me.answerlabel)
        Me.Controls.Add(Me.metersButton)
        Me.Controls.Add(Me.yardsButton)
        Me.Controls.Add(Me.mileButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mileButton As Button
    Friend WithEvents yardsButton As Button
    Friend WithEvents metersButton As Button
    Friend WithEvents answerlabel As Label
    Friend WithEvents inputTextBox As TextBox
End Class
