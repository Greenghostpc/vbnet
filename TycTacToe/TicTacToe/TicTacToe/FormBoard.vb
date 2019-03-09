Public Class FormBoard
    Private GameMaster As IGameMaster
    Private P1_isAI, P2_isAI As Boolean
    Private P1_Name, P2_Name As String

    Private isPlayer1sTurn As Boolean
    Private twoAIMode As Boolean 'used to control game speed-- game goes by in a fraction of a second, if two robots are playing

    Public Sub New(ByVal P1_isAI As Boolean, ByVal P2_isAI As Boolean, ByVal P1_Name As String, ByVal P2_Name As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        GameMaster = New GameMaster()
        Me.P1_isAI = P1_isAI
        Me.P1_Name = P1_Name

        Me.P2_isAI = P2_isAI
        Me.P2_Name = P2_Name

        isPlayer1sTurn = True

        If (P1_isAI AndAlso P2_isAI) Then
            twoAIMode = True
        Else
            twoAIMode = False
        End If
    End Sub

    Private Sub aiGameLogic()
        'The game needs to be handled differently, if there are two AI's
        ''through the reusable, object oriented nature of the design, the implementation of this alternative is relatively simple
        Me.Hide()


        While (Not (GameMaster.isTie()))
            aiPlayerTurn(getNextPlayer())
        End While
        'Me.Show()
        MessageBox.Show("Tie!")
        Environment.Exit(0)
    End Sub

    Private Sub aiPlayerTurn(ByRef Player As PC)

        Dim move As IGameSpace = GameMaster.getGameSpace(Player.getMove())
        'keep getting input until it is a valid move
        If (GameMaster.isValidMove(move)) Then
            move.FillSpace(Player)
            move.getLabel.Text = Player.getMark()

            Dim aiInputFrm As FormAIBoard = New FormAIBoard(Player.PlayerName, GameMaster.getGameMoves())

            aiInputFrm.ShowDialog()


            'Check for win before ending loop
            If (GameMaster.isWin(Player)) Then
                'Me.Show()
                MessageBox.Show(Player.PlayerName & " Wins!")
                Environment.Exit(0)
            End If
        Else
            'Invalid input? Call function again
            aiPlayerTurn(Player)
        End If
    End Sub

    Private Sub gameLogic()
        While (Not (GameMaster.isTie())) 'While it is not a tie (we check for a win at the end of the loop in playerTurn() ) 
            playerTurn(getNextPlayer())
        End While

        MessageBox.Show("Tie!")
        Environment.Exit(0)
    End Sub

    Private Function getNextPlayer() As IPlayer
        If (isPlayer1sTurn) Then
            isPlayer1sTurn = False
            Return GameMaster.getPlayer1
        Else
            isPlayer1sTurn = True
            Return GameMaster.getPlayer2
        End If
    End Function

    Private Sub playerTurn(ByRef Player As IPlayer)

        Label_PlayerTurn.Text = Player.PlayerName & "'s Turn"
        Dim move As IGameSpace
        If (Player.GetType.ToString = "TicTacToe.User") Then
            Dim UserPlayer As User = Player
            UserPlayer.setGameMoves(GameMaster.getGameMoves())
            move = GameMaster.getGameSpace(UserPlayer.getMove())
        Else
            move = GameMaster.getGameSpace(Player.getMove())
        End If
        'keep getting input until it is a valid move
        If (GameMaster.isValidMove(move)) Then
            move.FillSpace(Player)
            move.getLabel.Text = Player.getMark()
            'Check for win before ending loop
            If (GameMaster.isWin(Player)) Then
                MessageBox.Show(Player.PlayerName & " Wins!")
                Environment.Exit(0)
            End If
        Else
            'Invalid input? Call function again
            playerTurn(Player)
        End If



    End Sub


    Private Sub FormBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim LabelList As List(Of Label) = New List(Of Label)
        LabelList.Add(Label_1A)
        LabelList.Add(Label_1B)
        LabelList.Add(Label_1C)
        LabelList.Add(Label_2A)
        LabelList.Add(Label_2B)
        LabelList.Add(Label_2C)
        LabelList.Add(Label_3A)
        LabelList.Add(Label_3B)
        LabelList.Add(Label_3C)


        GameMaster.NewGame(P1_Name, P2_Name, P1_isAI, P2_isAI, LabelList)
        If (Not twoAIMode) Then
            gameLogic()
        Else
            aiGameLogic()
        End If
    End Sub





End Class
