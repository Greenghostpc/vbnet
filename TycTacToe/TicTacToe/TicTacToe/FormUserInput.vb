Public Class FormUserInput

    Public PlayerMove As String

    Public Sub New(ByVal PlayerName As String, ByVal GameMoves As Dictionary(Of String, String))

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = PlayerName & "'s Turn!"

        For Each gameSpace In GameMoves
            Me.Controls("Label_" & gameSpace.Key).Text = gameSpace.Value

        Next


    End Sub

    Private Sub FormUserInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub ReturnMove(ByVal Move As String)
        PlayerMove = Move
        Me.Hide()
    End Sub



    Private Sub Label_1A_Click(sender As Object, e As EventArgs) Handles Label_1A.Click
        ReturnMove("1A")
    End Sub

    Private Sub Label_2A_Click(sender As Object, e As EventArgs) Handles Label_2A.Click
        ReturnMove("2A")
    End Sub

    Private Sub Label_3A_Click(sender As Object, e As EventArgs) Handles Label_3A.Click
        ReturnMove("3A")
    End Sub

    Private Sub Label_1B_Click(sender As Object, e As EventArgs) Handles Label_1B.Click
        ReturnMove("1B")
    End Sub

    Private Sub Label_2B_Click(sender As Object, e As EventArgs) Handles Label_2B.Click
        ReturnMove("2B")
    End Sub

    Private Sub Label_3B_Click(sender As Object, e As EventArgs) Handles Label_3B.Click
        ReturnMove("3B")
    End Sub

    Private Sub Label_1C_Click(sender As Object, e As EventArgs) Handles Label_1C.Click
        ReturnMove("1C")
    End Sub

    Private Sub Label_2C_Click(sender As Object, e As EventArgs) Handles Label_2C.Click
        ReturnMove("2C")
    End Sub

    Private Sub Label_3C_Click(sender As Object, e As EventArgs) Handles Label_3C.Click
        ReturnMove("3C")
    End Sub


End Class