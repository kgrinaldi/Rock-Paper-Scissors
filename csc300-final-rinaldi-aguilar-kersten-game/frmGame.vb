Public Class frmGame

    Dim Rock As New Piece
    Dim Scissors As New Piece
    Dim Paper As New Piece

    Dim intCount As Integer = 4
    Dim intRock As Integer = 0
    Dim intScissors As Integer = 0
    Dim intPaper As Integer = 0

    Public GstrKey As String

    Private Sub frmPrototype_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim intWidth As Integer = PicBox.Width 'sets the positions on start up
        Dim intHeight As Integer = PicBox.Height

        Rock.FieldWidth = PicBox.Width
        Rock.FieldHeight = PicBox.Height
        Rock.PositionX = CInt(intWidth / 4)
        Rock.PositionY = CInt(intHeight / 4)
        Rock.StartingPostionX = CInt(intWidth / 4)
        Rock.StartingPostionY = CInt(intHeight / 4)

        Scissors.PositionX = CInt(3 * intWidth / 4)
        Scissors.PositionY = CInt(intHeight / 4)
        Scissors.FieldWidth = PicBox.Width
        Scissors.FieldHeight = PicBox.Height
        Scissors.StartingPostionX = CInt(3 * intWidth / 4)
        Scissors.StartingPostionY = CInt(intHeight / 4)

        Paper.PositionX = CInt(intWidth / 2)
        Paper.PositionY = CInt(3 * intHeight / 4)
        Paper.FieldWidth = PicBox.Width
        Paper.FieldHeight = PicBox.Height
        Paper.StartingPostionX = CInt(intWidth / 2)
        Paper.StartingPostionY = CInt(3 * intHeight / 4)





    End Sub

    Sub StartGame()

        tmrPaint.Enabled = False
        tmrRockMovement.Enabled = False
        tmrScissorsMovement.Enabled = False
        tmrPaperMovement.Enabled = False

        intRock = 0
        Rock.PositionX = Rock.StartingPostionX 'resets positions
        Rock.PositionY = Rock.StartingPostionY
        lblRock.Text = "Rock - 0"
        Rock.Score = 0
        intScissors = 0
        Scissors.PositionX = Scissors.StartingPostionX
        Scissors.PositionY = Scissors.StartingPostionY
        lblScissors.Text = "Scissors - 0"
        Scissors.Score = 0
        intPaper = 0
        Paper.PositionX = Paper.StartingPostionX
        Paper.PositionY = Paper.StartingPostionY
        lblPaper.Text = "Paper - 0"
        Paper.Score = 0

        tmrCountdown.Enabled = True

    End Sub

    Sub RockCollision()

        Select Case Rock.PositionX

            Case (Scissors.PositionX) To (Scissors.PositionX + Scissors.SizeWidth)

                Select Case Rock.PositionY

                    Case (Scissors.PositionY) To (Scissors.PositionY + Scissors.SizeHeight)
                        intScissors = 0
                        Scissors.PositionX = Scissors.StartingPostionX
                        Scissors.PositionY = Scissors.StartingPostionY
                        Rock.IncreaseScore(100)
                        lblRock.Text = "Rock - " & Rock.Score

                    Case Else

                End Select

            Case Else

        End Select



    End Sub

    Sub ScissorsCollision()

        Select Case Scissors.PositionX

            Case (Paper.PositionX) To (Paper.PositionX + Paper.SizeWidth)

                Select Case Scissors.PositionY

                    Case (Paper.PositionY) To (Paper.PositionY + Paper.SizeHeight)
                        intPaper = 0
                        Paper.PositionX = Paper.StartingPostionX
                        Paper.PositionY = Paper.StartingPostionY
                        Scissors.IncreaseScore(100)
                        lblScissors.Text = "Scissors - " & Scissors.Score

                    Case Else

                End Select

            Case Else

        End Select

    End Sub

    Sub PaperCollision()

        Select Case Paper.PositionX

            Case (Rock.PositionX) To (Rock.PositionX + Rock.SizeWidth)

                Select Case Paper.PositionY

                    Case (Rock.PositionY) To (Rock.PositionY + Rock.SizeHeight)
                        intRock = 0
                        Rock.PositionX = Rock.StartingPostionX
                        Rock.PositionY = Rock.StartingPostionY
                        Paper.IncreaseScore(100)
                        lblPaper.Text = "Paper - " & Paper.Score

                    Case Else

                End Select

            Case Else

        End Select


    End Sub

    Sub Draw()

        Dim gr As Graphics 'background variables


        Dim intWidth As Integer = PicBox.Width
        Dim intHeight As Integer = PicBox.Height

        Dim intRockX As Integer = Rock.PositionX.ToString
        Dim intRockY As Integer = Rock.PositionY.ToString

        Dim intScissorsX As Integer = Scissors.PositionX.ToString
        Dim intScissorsY As Integer = Scissors.PositionY.ToString

        Dim intPaperX As Integer = Paper.PositionX.ToString
        Dim intPaperY As Integer = Paper.PositionY.ToString

        Dim intPieceWidth As Integer = Rock.SizeWidth.ToString 'piece variables
        Dim intPieceHeight As Integer = Rock.SizeHeight.ToString
        Dim RockColor As Brush = Brushes.Black
        Dim ScissorsColor As Brush = Brushes.Silver
        Dim PaperColor As Brush = Brushes.White

        gr = PicBox.CreateGraphics

        gr.FillRectangle(Brushes.Gray, 0, 0, intWidth, intHeight) 'battlefield

        gr.FillRectangle(RockColor, intRockX, intRockY, intPieceWidth, intPieceHeight) 'rock
        gr.FillRectangle(ScissorsColor, intScissorsX, intScissorsY, intPieceWidth, intPieceHeight) 'scissors
        gr.FillRectangle(PaperColor, intPaperX, intPaperY, intPieceWidth, intPieceHeight) 'paper

        



    End Sub


    Private Sub frmPrototype_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress

        GstrKey = e.KeyChar
        e.Handled = True
        KeyHandler()

    End Sub

    Sub KeyHandler()

        Dim strTempKey As String = ""

        If Not GstrKey = "" And tmrCountdown.Enabled = False Then 'the "and" statement is in here so that the controls don't activate while the countdown timer is running
            strTempKey = GstrKey.ToUpper 'temporary placeholder
            GstrKey = ""

            Select Case strTempKey

                Case "R"
                    StartGame()

                Case "W" 'rock controls

                    intRock = 1

                    If tmrRockMovement.Enabled = False Then

                        tmrRockMovement.Enabled = True

                    End If

                Case "S"
                    intRock = 2

                    If tmrRockMovement.Enabled = False Then

                        tmrRockMovement.Enabled = True

                    End If

                Case "A"
                    intRock = 3

                    If tmrRockMovement.Enabled = False Then

                        tmrRockMovement.Enabled = True

                    End If

                Case "D"
                    intRock = 4

                    If tmrRockMovement.Enabled = False Then

                        tmrRockMovement.Enabled = True

                    End If

                Case "I" 'scissors
                    intScissors = 1

                    If tmrScissorsMovement.Enabled = False Then

                        tmrScissorsMovement.Enabled = True

                    End If

                Case "K"
                    intScissors = 2

                    If tmrScissorsMovement.Enabled = False Then

                        tmrScissorsMovement.Enabled = True

                    End If

                Case "J"
                    intScissors = 3

                    If tmrScissorsMovement.Enabled = False Then

                        tmrScissorsMovement.Enabled = True

                    End If



                Case "L"
                    intScissors = 4

                    If tmrScissorsMovement.Enabled = False Then

                        tmrScissorsMovement.Enabled = True

                    End If

                Case "5" 'paper
                    intPaper = 1

                    If tmrPaperMovement.Enabled = False Then

                        tmrPaperMovement.Enabled = True

                    End If


                Case "2"
                    intPaper = 2

                    If tmrPaperMovement.Enabled = False Then

                        tmrPaperMovement.Enabled = True

                    End If

                Case "1"
                    intPaper = 3

                    If tmrPaperMovement.Enabled = False Then

                        tmrPaperMovement.Enabled = True

                    End If

                Case "3"
                    intPaper = 4

                    If tmrPaperMovement.Enabled = False Then

                        tmrPaperMovement.Enabled = True

                    End If

                Case Else

            End Select

        End If

    End Sub


    Private Sub tmrPaint_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPaint.Tick 'draws the field repeatedly

        Dim intWidth As Integer = PicBox.Width
        Dim intHeight As Integer = PicBox.Height
        Dim gr As Graphics 'background variables
        Dim Ariel As New Font("Ariel", 12, FontStyle.Bold)

        gr = PicBox.CreateGraphics

        tmrPaint.Interval = 200
        Draw()

        If Rock.Score >= 1000 Then

            gr.DrawString("Rock Wins!", Ariel, Brushes.Black, CInt(7 * intWidth / 16), CInt(intHeight / 2))

            tmrRockMovement.Enabled = False
            tmrScissorsMovement.Enabled = False
            tmrPaperMovement.Enabled = False
            tmrPaint.Enabled = False

        ElseIf Scissors.Score >= 1000 Then

            gr.DrawString("Scissors Wins!", Ariel, Brushes.Black, CInt(3 * intWidth / 8), CInt(intHeight / 2))

            tmrRockMovement.Enabled = False
            tmrScissorsMovement.Enabled = False
            tmrPaperMovement.Enabled = False
            tmrPaint.Enabled = False

        ElseIf Paper.Score >= 1000 Then

            gr.DrawString("Paper Wins!", Ariel, Brushes.Black, CInt(7 * intWidth / 16), CInt(intHeight / 2))

            tmrRockMovement.Enabled = False
            tmrScissorsMovement.Enabled = False
            tmrPaperMovement.Enabled = False
            tmrPaint.Enabled = False

        Else

        End If

    End Sub

    

    Private Sub tmrCountdown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCountdown.Tick
        Dim intWidth As Integer = PicBox.Width 'sets the positions on start up
        Dim intHeight As Integer = PicBox.Height
        Dim Ariel As New Font("Ariel", 12, FontStyle.Bold)
        Dim gr As Graphics

        tmrCountdown.Interval = 1000
        gr = PicBox.CreateGraphics

        If Not intCount = 1 Then
            Draw()
            intCount -= 1
            gr.DrawString(intCount.ToString, Ariel, Brushes.Black, CInt(intWidth / 2), CInt(intHeight / 2)) 'draws the number

        Else
            Draw()
            intCount = 4
            tmrCountdown.Enabled = False
            tmrPaint.Enabled = True
            tmrRockMovement.Enabled = True
            tmrScissorsMovement.Enabled = True
            tmrPaperMovement.Enabled = True


        End If
    End Sub

    Private Sub tmrRock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRockMovement.Tick

        tmrRockMovement.Interval = 50

        Select Case intRock

            Case "1"
                Rock.MovementUp(Rock.Speed)
            Case "2"
                Rock.MovementDown(Rock.Speed)
            Case "3"
                Rock.MovementLeft(Rock.Speed)
            Case "4"
                Rock.MovementRight(Rock.Speed)
            Case Else


        End Select

        RockCollision()

    End Sub


    Private Sub tmrScissorsMovement_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrScissorsMovement.Tick
        tmrScissorsMovement.Interval = 50

        Select Case intScissors

            Case "1"
                Scissors.MovementUp(Scissors.Speed)
            Case "2"
                Scissors.MovementDown(Scissors.Speed)
            Case "3"
                Scissors.MovementLeft(Scissors.Speed)
            Case "4"
                Scissors.MovementRight(Scissors.Speed)
            Case Else

        End Select

        ScissorsCollision()

    End Sub

    Private Sub tmrPaperMovement_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPaperMovement.Tick
        tmrPaperMovement.Interval = 50

        Select Case intPaper

            Case "1"
                Paper.MovementUp(Paper.Speed)
            Case "2"
                Paper.MovementDown(Paper.Speed)
            Case "3"
                Paper.MovementLeft(Paper.Speed)
            Case "4"
                Paper.MovementRight(Paper.Speed)
            Case Else
        End Select

        PaperCollision()

    End Sub

    
    Private Sub StartToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem.Click

        StartGame()

    End Sub

    Private Sub ControlsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlsToolStripMenuItem.Click

        MsgBox("Press R to Start a New Game" & Environment.NewLine(1) & Environment.NewLine(1) _
               & "WASD Moves Rock(Black)" & Environment.NewLine(1) _
               & "IJKL Moves Scissors(Silver)" & Environment.NewLine(1) _
               & "5123 Moves Paper(White)", MsgBoxStyle.Information, "Controls")


    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        End

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click

        MsgBox("CSC 300 - Rock, Paper, Scissors" & _
               Environment.NewLine(1) & Environment.NewLine(1) & "Created By" & _
               Environment.NewLine(1) & "Kevin Rinaldi" & _
               Environment.NewLine(1) & "Evan Kersten" & Environment.NewLine(1) & "Linda Aguilar", MsgBoxStyle.Information, "About") 'environment.newline



    End Sub

    

    
End Class

Public Class Piece
    Private gr As Graphics 'this is to make color conversions easier
    Private m_strName As String = "Rock"
    Private m_strDimensions As String = m_intX & " x " & m_intY
    Private m_intX As Integer
    Private m_intY As Integer
    Private m_intSpeed As Integer = 5
    Private m_intStartX As Integer
    Private m_intStartY As Integer
    Private m_intWidth As Integer = 15
    Private m_intHeight As Integer = 15
    Private m_intFieldWidth As Integer = 20
    Private m_intFieldHeight As Integer = 20
    Private m_intScore As Integer = 0
    Private m_Color As Brush = Brushes.White

    Public Property Name()
        Set(ByVal N)

            m_strName = N

        End Set

        Get

            Return m_strName

        End Get



    End Property

    Public Property StartingPostionX As Integer

        Set(ByVal X As Integer)

            m_intStartX = X

        End Set

        Get

            Return m_intStartX

        End Get

    End Property

    Public Property StartingPostionY As Integer

        Set(ByVal X As Integer)

            m_intStartY = X

        End Set

        Get

            Return m_intStartY

        End Get

    End Property

    Public Property PositionX As Integer
        Set(ByVal X As Integer)

            m_intX = X


        End Set

        Get

            Return m_intX

        End Get

    End Property

    Public Property PositionY As Integer
        Set(ByVal Y As Integer)

            m_intY = Y

        End Set

        Get

            Return m_intY

        End Get

    End Property

    Public Property SizeWidth
        Set(ByVal Width)

            m_intWidth = Width

        End Set

        Get

            Return m_intWidth

        End Get

    End Property

    Public Property SizeHeight
        Set(ByVal Height)

            m_intHeight = Height

        End Set

        Get

            Return m_intHeight

        End Get

    End Property


    Public Property Score
        Set(ByVal Score)

            m_intScore = Score

        End Set

        Get

            Return m_intScore

        End Get

    End Property

    Public Property Color
        Set(ByVal C)

            m_Color = C

        End Set

        Get

            Return m_Color

        End Get


    End Property

    Public Property FieldWidth()

        Set(ByVal X)

            m_intFieldWidth = X

        End Set

        Get

            Return m_intFieldWidth

        End Get


    End Property

    Public Property FieldHeight()

        Set(ByVal Y)

            m_intFieldHeight = Y

        End Set

        Get

            Return m_intFieldHeight

        End Get


    End Property

    Public Property Speed()

        Set(ByVal X)

            m_intSpeed = X

        End Set

        Get

            Return m_intSpeed

        End Get

    End Property


    Public Function MovementLeft(ByVal X As Integer)

        If Not m_intX <= 0 Then

            m_intX -= X

        Else

            m_intX = 0

        End If

        Return m_intX

    End Function

    Public Function MovementRight(ByVal X As Integer)

        If Not m_intX >= m_intFieldWidth - m_intWidth Then

            m_intX += X

        Else

            m_intX = m_intFieldWidth - m_intWidth

        End If

        Return m_intX

    End Function

    Public Function MovementUp(ByVal Y As Integer)

        If Not m_intY <= 0 Then

            m_intY -= Y

        Else

            m_intY = 0

        End If

        Return m_intY

    End Function

    Public Function MovementDown(ByVal Y As Integer)

        If Not m_intY >= m_intFieldHeight - m_intHeight Then

            m_intY += Y

        Else

            m_intY = m_intFieldHeight - m_intHeight

        End If

        Return m_intY

    End Function

    Public Function IncreaseScore(ByVal X As Integer)

        If X > 0 Then

            m_intScore += X

        Else


        End If



        Return m_intScore

    End Function

    Public Function DecreaseScore(ByVal X As Integer)

        If m_intScore < 1 Then

            m_intScore += X

        Else


        End If



        Return m_intScore

    End Function

    Public Function Dimensions()

        Return m_intWidth & " x " & m_intHeight

    End Function

    Public Function Position()

        Return m_intX & " x " & m_intY

    End Function

    Public Function FieldSize()

        Return m_intFieldWidth & " x " & m_intFieldHeight

    End Function

    Public Function Widen(ByVal X As Integer)

        m_intWidth += X
        Return m_intWidth

    End Function

    Public Function Heighten(ByVal Y As Integer)

        m_intHeight += Y
        Return m_intHeight

    End Function

    Public Function UnWiden(ByVal X As Integer)

        If m_intWidth < 2 Then

            m_intWidth = 1

        Else

            m_intWidth -= X

        End If



        Return m_intWidth

    End Function

    Public Function UnHeighten(ByVal Y As Integer)

        If m_intHeight < 2 Then

            m_intHeight = 1

        Else

            m_intHeight -= Y

        End If


        Return m_intHeight

    End Function

End Class