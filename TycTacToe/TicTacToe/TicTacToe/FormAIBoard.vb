Public Class FormAIBoard

    Public Sub New(ByVal PlayerName As String, ByVal GameMoves As Dictionary(Of String, String))

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = PlayerName & "'s Turn!"

        For Each gameSpace In GameMoves
            Me.Controls("Label_" & gameSpace.Key).Text = gameSpace.Value

        Next
    End Sub


    Private Sub FormAIBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button_NextMove_Click(sender As Object, e As EventArgs) Handles Button_NextMove.Click
        Me.Close()
    End Sub
End Class