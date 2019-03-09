' Project name:         Guess the Word Project
' Project purpose:      Simulates the Guess the 
'                       Word game 
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private word As String
    Private incorrect As Integer


    Private Sub EnableDisableButtons(ByVal setting As Boolean)
        ' enable or disable letter buttons

        aButton.Enabled = setting
        bButton.Enabled = setting
        cButton.Enabled = setting
        dButton.Enabled = setting
        eButton.Enabled = setting
        fButton.Enabled = setting
        gButton.Enabled = setting
        hButton.Enabled = setting
        iButton.Enabled = setting
        jButton.Enabled = setting
        kButton.Enabled = setting
        lButton.Enabled = setting
        mButton.Enabled = setting
        nButton.Enabled = setting
        oButton.Enabled = setting
        pButton.Enabled = setting
        qButton.Enabled = setting
        rButton.Enabled = setting
        sButton.Enabled = setting
        tButton.Enabled = setting
        uButton.Enabled = setting
        vButton.Enabled = setting
        wButton.Enabled = setting
        xButton.Enabled = setting
        yButton.Enabled = setting
        zButton.Enabled = setting
    End Sub

    Private Sub CheckStatus(ByVal dashStatus As Boolean)
        If dashStatus = True Then
            If wordLabel.Text.Contains("-") = False Then
                MessageBox.Show("Great guesssing!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call EnableDisableButtons(False)
            End If
        Else
            incorrect += 1
            incorrectLabel.Text = incorrect.ToString
            If incorrect = 10 Then
                MessageBox.Show("Sorry, The word is " & word, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call EnableDisableButtons(False)
            End If
        End If
    End Sub

    Private Sub LetterButtons(ByVal sender As Object, ByVal e As System.EventArgs) Handles aButton.Click,
        bButton.Click, cButton.Click, dButton.Click, eButton.Click, jButton.Click, iButton.Click, hButton.Click,
        gButton.Click, fButton.Click, oButton.Click, nButton.Click, mButton.Click, lButton.Click, kButton.Click,
        tButton.Click, sButton.Click, rButton.Click, qButton.Click, pButton.Click, yButton.Click, xButton.Click,
        wButton.Click, vButton.Click, uButton.Click, zButton.Click

        Dim clickedButton As Button
        Dim dashReplaced As Boolean

        clickedButton = TryCast(sender, Button)
        clickedButton.Enabled = False

        For Index As Integer = 0 To 4
            If word.Substring(Index, 1) = clickedButton.Text Then
                wordLabel.Text = wordLabel.Text.Remove(Index, 1)
                wordLabel.Text = wordLabel.Text.Insert(Index, clickedButton.Text)
                dashReplaced = True
            End If
        Next Index
        Call CheckStatus(dashReplaced)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        wordLabel.Text = String.Empty
        incorrectLabel.Text = String.Empty
        incorrect = 0
        word = InputBox("Enter a 5 Letter word:", "Player1").ToUpper
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aButton.Enabled = True
        bButton.Enabled = True
        cButton.Enabled = True
        dButton.Enabled = True
        eButton.Enabled = True
        fButton.Enabled = True
        gButton.Enabled = True
        hButton.Enabled = True
        iButton.Enabled = True
        jButton.Enabled = True
        kButton.Enabled = True
        lButton.Enabled = True
        mButton.Enabled = True
        nButton.Enabled = True
        oButton.Enabled = True
        pButton.Enabled = True
        qButton.Enabled = True
        rButton.Enabled = True
        sButton.Enabled = True
        tButton.Enabled = True
        uButton.Enabled = True
        vButton.Enabled = True
        wButton.Enabled = True
        xButton.Enabled = True
        yButton.Enabled = True
        zButton.Enabled = True
    End Sub
End Class
