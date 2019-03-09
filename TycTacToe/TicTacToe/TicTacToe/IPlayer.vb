Public Interface IPlayer
    Function getMove() As String
    'Gets input for moving, then returns the ID of the attempted move

    Property PlayerName As String

    Function getMark() As String

    Property LastAttemptedMove As String
End Interface
