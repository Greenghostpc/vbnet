Imports TicTacToe

Public Class GameSpace
    Implements IGameSpace

    'This object represents the individual space in the gameboard
    Private isFilled As Boolean
    Private PlayerFilled As IPlayer
    Private label As Label

    Public Sub New(ByRef label As Label)
        isFilled = False
        Me.label = label

    End Sub

    Public Sub FillSpace(ByRef Player As IPlayer) Implements IGameSpace.FillSpace
        isFilled = True
        PlayerFilled = Player
        label.Text = Player.getMark()

    End Sub

    Public Function whoFilled() As IPlayer Implements IGameSpace.whoFilled
        If (isFilled) Then
            Return PlayerFilled
        End If
        Return Nothing
    End Function

    Private Function IGameSpace_isFilled() As Boolean Implements IGameSpace.isFilled
        Return isFilled
    End Function

    Public Function getLabel() As Label Implements IGameSpace.getLabel
        Return label
    End Function
End Class
