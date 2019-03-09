Imports TicTacToe

Public Class GameMaster
    Implements IGameMaster

    Private Player1 As IPlayer
    Private Player2 As IPlayer

    Private GameSpaces As Dictionary(Of String, IGameSpace)
    Private WinComboLists As List(Of List(Of IGameSpace))
    Private WinCombo1 As List(Of IGameSpace) '1A, 2A, 3A    ''FIRST ROW
    Private WinCombo2 As List(Of IGameSpace) '1B, 2B, 3B    ''SECOND ROW
    Private WinCombo3 As List(Of IGameSpace) '1C, 2C, 3C    ''THIRD ROW
    Private WinCombo4 As List(Of IGameSpace) '1A, 2B, 3C    ''DIAGNOL1
    Private WinCombo5 As List(Of IGameSpace) '3A, 2B, 1C    ''DIAGNOL2
    Private WinCombo6 As List(Of IGameSpace) '1A, 1B, 1C    ''FIRST COLUMN
    Private WinCombo7 As List(Of IGameSpace) '2A, 2B, 2C    ''SECOND COLUMN
    Private WinCombo8 As List(Of IGameSpace) '3A, 3B, 3C    ''THIRD COLUMN

    Public Sub NewGame(Player1_Name As String, Player2_Name As String, Player1_isAI As Boolean, Player2_isAI As Boolean, ByRef labelList As List(Of Label)) Implements IGameMaster.NewGame
        If (Player1_isAI) Then
            Player1 = New PC("x")
        Else
            Player1 = New User("X")
        End If

        If (Player2_isAI) Then
            Player2 = New PC("0")
        Else
            Player2 = New User("O")
        End If
        Player1.PlayerName = Player1_Name
        Player2.PlayerName = Player2_Name

        populateGameSpaces(labelList)
        populateWinComboLists()

    End Sub

    Public Function isValidMove(ByRef GameSpace As IGameSpace) As Boolean Implements IGameMaster.isValidMove
        Try
            Return Not GameSpace.isFilled

        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function isWin(ByRef Player As IPlayer) As Boolean Implements IGameMaster.isWin
        Dim hasWon As Boolean = False

        For Each winList In WinComboLists
            Dim numFilled As Integer = 0
            For Each gameSpace In winList
                If (gameSpace.whoFilled IsNot Nothing) Then
                    If (gameSpace.whoFilled.PlayerName = Player.PlayerName) Then
                        numFilled = numFilled + 1
                    End If
                End If
                If (numFilled = 3) Then
                    hasWon = True
                End If
            Next

        Next
        Return hasWon
    End Function



    Private Sub populateGameSpaces(ByRef LabelList As List(Of Label))
        'Builder function
        'Populates the GameSpaces and sets their states to unfilled
        GameSpaces = New Dictionary(Of String, IGameSpace)
        GameSpaces.Add("1A", New GameSpace(LabelList.ElementAt(0)))
        GameSpaces.Add("2A", New GameSpace(LabelList.ElementAt(1)))
        GameSpaces.Add("3A", New GameSpace(LabelList.ElementAt(2)))
        GameSpaces.Add("1B", New GameSpace(LabelList.ElementAt(3)))
        GameSpaces.Add("2B", New GameSpace(LabelList.ElementAt(4)))
        GameSpaces.Add("3B", New GameSpace(LabelList.ElementAt(5)))
        GameSpaces.Add("1C", New GameSpace(LabelList.ElementAt(6)))
        GameSpaces.Add("2C", New GameSpace(LabelList.ElementAt(7)))
        GameSpaces.Add("3C", New GameSpace(LabelList.ElementAt(8)))

    End Sub

    Private Sub populateWinComboLists()
        'Builder Function
        'Populates the Winning combination lists with the relative gameobjects
        Dim curGameSpace As IGameSpace

        'Instantiate the Lists
        WinComboLists = New List(Of List(Of IGameSpace))
        WinCombo1 = New List(Of IGameSpace)
        WinCombo2 = New List(Of IGameSpace)
        WinCombo3 = New List(Of IGameSpace)
        WinCombo4 = New List(Of IGameSpace)
        WinCombo5 = New List(Of IGameSpace)
        WinCombo6 = New List(Of IGameSpace)
        WinCombo7 = New List(Of IGameSpace)
        WinCombo8 = New List(Of IGameSpace)

        'GameSpace_1A
        curGameSpace = GameSpaces("1A")
        WinCombo1.Add(curGameSpace)
        WinCombo4.Add(curGameSpace)
        WinCombo6.Add(curGameSpace)

        'GameSpace_2A
        curGameSpace = GameSpaces("2A")
        WinCombo1.Add(curGameSpace)
        WinCombo7.Add(curGameSpace)

        'GameSpace_3A
        curGameSpace = GameSpaces("3A")
        WinCombo1.Add(curGameSpace)
        WinCombo5.Add(curGameSpace)
        WinCombo8.Add(curGameSpace)

        'GameSpace_1B
        curGameSpace = GameSpaces("1B")
        WinCombo2.Add(curGameSpace)
        WinCombo6.Add(curGameSpace)

        'GameSpace_2B
        curGameSpace = GameSpaces("2B")
        WinCombo2.Add(curGameSpace)
        WinCombo4.Add(curGameSpace)
        WinCombo5.Add(curGameSpace)
        WinCombo7.Add(curGameSpace)

        'GameSpace_3B
        curGameSpace = GameSpaces("3B")
        WinCombo2.Add(curGameSpace)
        WinCombo8.Add(curGameSpace)

        'GameSpace_1C
        curGameSpace = GameSpaces("1C")
        WinCombo3.Add(curGameSpace)
        WinCombo5.Add(curGameSpace)
        WinCombo6.Add(curGameSpace)

        'GameSpace_2C
        curGameSpace = GameSpaces("2C")
        WinCombo3.Add(curGameSpace)
        WinCombo7.Add(curGameSpace)

        'GameSpace_3C
        curGameSpace = GameSpaces("3C")
        WinCombo3.Add(curGameSpace)
        WinCombo4.Add(curGameSpace)
        WinCombo8.Add(curGameSpace)

        WinComboLists.Add(WinCombo1)
        WinComboLists.Add(WinCombo2)
        WinComboLists.Add(WinCombo3)
        WinComboLists.Add(WinCombo4)
        WinComboLists.Add(WinCombo5)
        WinComboLists.Add(WinCombo6)
        WinComboLists.Add(WinCombo7)
        WinComboLists.Add(WinCombo8)

    End Sub

    Public Function getPlayer1() As IPlayer Implements IGameMaster.getPlayer1
        Return Player1
    End Function

    Public Function getPlayer2() As IPlayer Implements IGameMaster.getPlayer2
        Return Player2
    End Function

    Public Function getGameSpace(ByRef Label As Label) As IGameSpace Implements IGameMaster.getGameSpace
        For Each gameSpace In GameSpaces
            If (gameSpace.Value.getLabel Is Label) Then
                Return gameSpace.Value
            End If
        Next
        Return Nothing
    End Function

    Public Function getGameSpace(ByRef SpaceID As String) As IGameSpace Implements IGameMaster.getGameSpace
        Try
            Return GameSpaces(SpaceID)

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function isTie() As Boolean Implements IGameMaster.isTie
        For Each gameSpace In GameSpaces
            If (Not gameSpace.Value.isFilled()) Then 'if the gameSpace is empty
                Return False
            End If
        Next
        'All GameSpaces are fileld
        Return True
    End Function

    Public Function getGameMoves() As Dictionary(Of String, String) Implements IGameMaster.getGameMoves
        Dim retDict As New Dictionary(Of String, String)
        For Each valPair In GameSpaces
            Dim spaceValue As String = " "
            If (valPair.Value.whoFilled IsNot Nothing) Then
                spaceValue = valPair.Value.whoFilled.getMark()
            End If
            retDict.Add(valPair.Key, spaceValue)
        Next
        Return retDict
    End Function
End Class
