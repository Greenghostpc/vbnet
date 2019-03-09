Imports TicTacToe

Public Class PC
    Implements IPlayer

    Private _PlayerName As String
    Private spaceNoMap As Dictionary(Of Integer, String)
    Private _PlayerSymbol As Char
    Private _LastAttemptedMove As String


    Public Sub New(ByVal PlayerSymbol As Char)
        _PlayerSymbol = PlayerSymbol
        populateSpaceMapping()
    End Sub

    Private Sub populateSpaceMapping()
        'Populates the dictionary for mapping the spaceNo to the spaceID
        spaceNoMap = New Dictionary(Of Integer, String)
        spaceNoMap.Add(1, "1A")
        spaceNoMap.Add(2, "2A")
        spaceNoMap.Add(3, "3A")
        spaceNoMap.Add(4, "1B")
        spaceNoMap.Add(5, "2B")
        spaceNoMap.Add(6, "3B")
        spaceNoMap.Add(7, "1C")
        spaceNoMap.Add(8, "2C")
        spaceNoMap.Add(9, "3C")

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

    Public Function getMove() As String Implements IPlayer.getMove
        'AI Move can be arbitrary as per instructions
        Dim randGenerator As New Random()
        Dim spaceNo As Integer = randGenerator.Next(1, 10) 'Generates a random number between 1 and 9
        Dim spaceID As String = spaceNoMap(spaceNo)
        LastAttemptedMove = spaceID

        Return spaceID
    End Function

    Public Function getMark() As String Implements IPlayer.getMark
        Return _PlayerSymbol
    End Function
End Class
