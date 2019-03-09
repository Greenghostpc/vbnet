Public Interface IGameSpace
    Sub FillSpace(ByRef Player As IPlayer)
    'Filles the Space and Marks the input player as the filler

    Function isFilled() As Boolean
    'Checks whether or not the GameSpace is filled 
    'returns a boolean representing the case

    Function whoFilled() As IPlayer
    'Returns the Player object of who filled the space

    Function getLabel() As Label
    'returns the associated Label forms object


End Interface
