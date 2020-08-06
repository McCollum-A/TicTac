Public Class FormGame
    Public Playing As Boolean 'T/F to track if a game is active or not
    Public PlayerTurn As Integer 'Track player 1 "1" or Player 2 "2" 's turn
    Public CurrentSpot As Object 'Which of the 9 spots of the board is selected, containing the label as an object
    Public CurrentTurn As Integer 'Counter to track turns 1 through 9, as the board has 9 spots
    Public GameOver As Boolean 'T/F flag for weither the game is over or not
    '------------------
    Public Grid(2, 2) As Integer
    Public GridRow As Integer = 0
    Public GridColumn As Integer = 0

    Private Sub FormGame_Load(sender As Object, e As EventArgs) Handles Me.Load
        Playing = False 'On load, the game is not being played
        GameOver = False 'On load, the game is not won
        LblPlayer.Text = "Player: None" 'Sets text
        CurrentTurn = 0 'Sets turn Count
        LblSpot1.Tag = "0, 0"
        LblSpot2.Tag = "1, 0"
        LblSpot3.Tag = "2, 0"
        LblSpot4.Tag = "0, 1"
        LblSpot5.Tag = "1, 1"
        LblSpot6.Tag = "2, 1"
        LblSpot7.Tag = "0, 1"
        LblSpot8.Tag = "1, 2"
        LblSpot9.Tag = "2, 2"
    End Sub
    Private Sub PlayerMark() 'Private sub to be called when a player chooses which square to mark
        ' MessageBox.Show(CurrentSpot.Tag)
        If Playing = True And CurrentTurn < 9 And PlayerTurn = 1 Then
            CurrentSpot.text = "X" '[selected label object].text property
            PlayerTurn = 2 'Set the next player's turn
            LblPlayer.Text = "Player: O" 'Display next player's turn
        ElseIf Playing = True And CurrentTurn < 9 And PlayerTurn = 2 Then
            CurrentSpot.text = "O"
            PlayerTurn = 1
            LblPlayer.Text = "Player: X"
        Else
            Return 'If for some reason the if/then test fails, end this Sub
        End If

        CurrentTurn = CurrentTurn + 1 'Move the overall game turn counter up 1
        'BtnStart.Text = CurrentTurn.ToString
        Call WinLogic() 'Call this Sub to check if this turn caused a player to win

        'Below for Visual Debug, Remove upon release
        LblR1.Text = Grid(0, 0)
        LblR2.Text = Grid(1, 0)
        LblR3.Text = Grid(2, 0)
        LblC1.Text = Grid(0, 1)
        LblC2.Text = Grid(1, 1)
        LblC3.Text = Grid(2, 1)
        LblBS.Text = Grid(0, 2)
        LblFS.Text = Grid(1, 2)
        Label1.Text = Grid(2, 2)

    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        If CurrentTurn = 0 Then 'Test if this is the first round of play
            Playing = True 'game is now being played
            PlayerTurn = 1 'set turn to turn 1
            LblPlayer.Text = "Player: X" 'Display current player's turn
            BtnStart.Text = "Playing..."
            BtnStart.Enabled = False
        ElseIf GameOver = True Then 'Test if this is the 2nd or greater turn of play
            LblSpot1.Text = "-" 'Set 9 spots to show "-" instead of X or O
            LblSpot2.Text = "-"
            LblSpot3.Text = "-"
            LblSpot4.Text = "-"
            LblSpot5.Text = "-"
            LblSpot6.Text = "-"
            LblSpot7.Text = "-"
            LblSpot8.Text = "-"
            LblSpot9.Text = "-"
            Playing = True
            GameOver = False 'It is now a re-match, so gameover is false
            PlayerTurn = 1
            LblPlayer.Text = "Player: X"
            CurrentTurn = 0
            ReDim Grid(2, 2)
            BtnStart.Text = "Playing..."
            BtnStart.Enabled = False

        Else

        End If


    End Sub

    Private Sub LblSpot1_Click_1(sender As Object, e As EventArgs) Handles LblSpot1.Click
        CurrentSpot = LblSpot1 'Sets the CurrentSpot object holder as the clicked spot
        GridColumn = 0
        GridRow = 0
        Call GameBoard()
        Call PlayerMark() 'Call sub to activate the player's choice
    End Sub

    Private Sub LblSpot2_Click(sender As Object, e As EventArgs) Handles LblSpot2.Click
        CurrentSpot = LblSpot2
        GridColumn = 1
        GridRow = 0
        Call GameBoard()
        Call PlayerMark()
    End Sub

    Private Sub LblSpot3_Click(sender As Object, e As EventArgs) Handles LblSpot3.Click
        CurrentSpot = LblSpot3
        GridColumn = 2
        GridRow = 0
        Call GameBoard()
        Call PlayerMark()
    End Sub

    Private Sub LblSpot4_Click(sender As Object, e As EventArgs) Handles LblSpot4.Click
        CurrentSpot = LblSpot4
        GridColumn = 0
        GridRow = 1
        Call GameBoard()
        Call PlayerMark()
    End Sub

    Private Sub LblSpot5_Click(sender As Object, e As EventArgs) Handles LblSpot5.Click
        CurrentSpot = LblSpot5
        GridColumn = 1
        GridRow = 1
        Call GameBoard()
        Call PlayerMark()
    End Sub

    Private Sub LblSpot6_Click(sender As Object, e As EventArgs) Handles LblSpot6.Click
        CurrentSpot = LblSpot6
        GridColumn = 2
        GridRow = 1
        Call GameBoard()
        Call PlayerMark()
    End Sub

    Private Sub LblSpot7_Click(sender As Object, e As EventArgs) Handles LblSpot7.Click
        CurrentSpot = LblSpot7
        GridColumn = 0
        GridRow = 2
        Call GameBoard()
        Call PlayerMark()
    End Sub

    Private Sub LblSpot8_Click(sender As Object, e As EventArgs) Handles LblSpot8.Click
        CurrentSpot = LblSpot8
        GridColumn = 1
        GridRow = 2
        Call GameBoard()
        Call PlayerMark()
    End Sub

    Private Sub LblSpot9_Click(sender As Object, e As EventArgs) Handles LblSpot9.Click
        CurrentSpot = LblSpot9
        GridColumn = 2
        GridRow = 2
        Call GameBoard()
        Call PlayerMark()
    End Sub

    Private Sub WinLogic()
        'This is the game's victory logic. The 8 arrays represent the 8 lines you can fill up to win tic-tac-toe. So this if/then checks
        'to see if any array contains 3 (an X equals 1) or -3 (an O equals -1), and therefore a player has won
        Dim Row1 As Integer = Grid(0, 0) + Grid(1, 0) + Grid(2, 0)
        Dim Row2 As Integer = Grid(0, 1) + Grid(1, 1) + Grid(2, 1)
        Dim Row3 As Integer = Grid(0, 2) + Grid(1, 2) + Grid(2, 2)
        Dim Column1 As Integer = Grid(0, 0) + Grid(0, 1) + Grid(0, 2)
        Dim Column2 As Integer = Grid(1, 0) + Grid(1, 1) + Grid(1, 2)
        Dim Column3 As Integer = Grid(2, 0) + Grid(2, 1) + Grid(2, 2)
        Dim ForwardS As Integer = Grid(0, 2) + Grid(1, 1) + Grid(2, 0)
        Dim BackS As Integer = Grid(0, 0) + Grid(1, 1) + Grid(2, 2)
        If Row1 = 3 OrElse Row2 = 3 OrElse Row3 = 3 OrElse Column1 = 3 OrElse Column2 = 3 OrElse Column3 = 3 OrElse ForwardS = 3 OrElse BackS = 3 Then
            LblPlayer.Text = "X Wins!" 'Display who won
            GameOver = True 'Sets the game as over
            Playing = False 'Sets the game as being not actively played
            BtnStart.Text = "Restart" 'Renames start button
            BtnStart.Enabled = True
        ElseIf Row1 = -3 OrElse Row2 = -3 OrElse Row3 = -3 OrElse Column1 = -3 OrElse Column2 = -3 OrElse Column3 = -3 OrElse ForwardS = -3 OrElse BackS = -3 Then
            LblPlayer.Text = "O Wins!"
            GameOver = True
            Playing = False
            BtnStart.Text = "Restart"
            BtnStart.Enabled = True
        ElseIf CurrentTurn = 9 Then
            LblPlayer.Text = "Draw!"
            GameOver = True
            Playing = False
            BtnStart.Text = "Restart"
            BtnStart.Enabled = True
        Else
            Exit Sub
        End If

    End Sub

    Private Sub GameBoard()
        'PlayerTurn 1 for p1 2 for p2
        'MessageBox.Show(GridColumn.ToString)
        'MessageBox.Show(GridRow.ToString)
        If PlayerTurn = 1 Then
            Grid(GridColumn, GridRow) = 1
        ElseIf PlayerTurn = 2 Then
            Grid(GridColumn, GridRow) = -1
        End If

    End Sub

End Class
