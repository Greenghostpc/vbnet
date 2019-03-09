' Project name:         Slot Machine Project
' Project purpose:      Simulates a slot machine
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Dim randGen As New Random

Dim leftIndex As Integer

Dim centerIndex As Integer

Dim rightIndex As Integer

clickHereButton.enabled = False

Public Class MainForm

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub clickHereButton_Click(sender As Object, e As EventArgs) Handles clickHereButton.Click

    End Sub

    Private Sub leftPictureBox_Click(sender As Object, e As EventArgs) Handles leftPictureBox.Click

    End Sub
End Class
