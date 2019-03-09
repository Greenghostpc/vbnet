Public Class FormNewGame
    Private Sub FormNewGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox_P1_isAI_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_P1_isAI.CheckedChanged
        checkSetTextbox()
    End Sub

    Private Sub CheckBox_P2_isAI_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_P2_isAI.CheckedChanged
        checkSetTextbox()
    End Sub

    Private Sub checkSetTextbox()
        'Checks the current state of each of the checkboxes and sets the text/readonly of the associated box
        If (CheckBox_P1_isAI.Checked) Then
            TextBox_P1_Name.ReadOnly = True
            TextBox_P1_Name.Text = "Robot A"
        Else
            TextBox_P1_Name.ReadOnly = False
            TextBox_P1_Name.Text = "Player I"
        End If

        If (CheckBox_P2_isAI.Checked) Then
            TextBox_P2_Name.ReadOnly = True
            TextBox_P2_Name.Text = "Robot B"
        Else
            TextBox_P2_Name.ReadOnly = False
            TextBox_P2_Name.Text = "Player II"
        End If
    End Sub

    Private Sub Button_StartGame_Click(sender As Object, e As EventArgs) Handles Button_StartGame.Click
        Dim Player1_isAI As Boolean = CheckBox_P1_isAI.Checked
        Dim Player2_isAI As Boolean = CheckBox_P2_isAI.Checked
        Dim Player1_Name As String = TextBox_P1_Name.Text
        Dim Player2_Name As String = TextBox_P2_Name.Text
        Dim game As New FormBoard(Player1_isAI, Player2_isAI, Player1_Name, Player2_Name)
        Me.Hide()

        game.Show()

    End Sub
End Class