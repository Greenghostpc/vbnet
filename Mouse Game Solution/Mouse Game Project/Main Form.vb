' Project name:         Mouse Game Project
' Project purpose:      Simulates the Find the Mouse game
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    ' class-level variable for storing a random number
    Private randomNumber As Integer

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        Dim randomGenerator As New Random
        ramdomNumber = ramdomGenerator.Next(1, 6)
        picture
    End Sub
End Class
