Imports TicTacToe

Public Class User
    Implements IPlayer

    Private _PlayerSymbol As Char
    Private _PlayerName As String
    Private _LastAttemptedMove As String
    Private _GameMoves As Dictionary(Of String, String)
    Public Sub New(ByVal PlayerSymbol As Char)
        _PlayerSymbol = PlayerSymbol

    End Sub

    Public Property PlayerName As String Implements IPlayer.PlayerName
        Get
            Return _PlayerName
        End Get
        Set(value As String)
            _PlayerName = value
        End Set
    End Property

    Public Property LastAttemptedMove As String Implements IPlayer.LastAttemptedMove
        Get
            Return _LastAttemptedMove
        End Get
        Set(value As String)
            _LastAttemptedMove = value
        End Set
    End Property

    Public Sub setGameMoves(ByVal GameMoves As Dictionary(Of String, String))
        _GameMoves = GameMoves
    End Sub

    Public Function getMove() As String Implements IPlayer.getMove
        Dim userInputFrm As FormUserInput = New FormUserInput(PlayerName, _GameMoves)
        Try
            While (userInputFrm.PlayerMove Is Nothing)

                userInputFrm.ShowDialog()

            End While
        Catch ex As Exception
            Application.Exit()
        End Try


        'Update LastAttemptedMove before returning
        LastAttemptedMove = userInputFrm.PlayerMove

        userInputFrm.Close()
        Return LastAttemptedMove
    End Function

    Public Function getMark() As String Implements IPlayer.getMark
        Return _PlayerSymbol
    End Function
End Class
