Public Interface IGameMaster

    Sub NewGame(ByVal Player1_Name As String, ByVal Player2_Name As String, ByVal Player1_isPlayer As Boolean, ByVal Player2_isPlayer As Boolean, ByRef LabelList As List(Of Label))
    'Constructs the GameBoard and each of the pieces
    'Given inputs dictate whether or not it is a user or ai to be constructed

    Function isWin(ByRef Player As IPlayer) As Boolean
    'Checks the board for the given playerObj and checks for a win
    'returns a boolean representing the success case

    Function isValidMove(ByRef GameSpace As IGameSpace) As Boolean
    'Checks to see if the GameSpace is filled or not
    'Returns a boolean representing if it is populated or not

    Function isTie() As Boolean
    'Checks all the gamespaces to see if they are all filled: if all filled and !Win, then isTie=true;else=false
    'returns a boolean representing if the game is a tie or not

    Function getGameMoves() As Dictionary(Of String, String)
    'returns a dictionary containing the values of the game board
    ''Key = SpaceID
    ''Value = SpaceValue (no null vals, pass in " " for empty spaces)

    Function getPlayer1() As IPlayer
    Function getPlayer2() As IPlayer

    Function getGameSpace(ByRef Label As Label) As IGameSpace
    Function getGameSpace(ByRef SpaceID As String) As IGameSpace
End Interface
