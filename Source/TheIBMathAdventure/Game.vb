'Be prepared to read this for a while (771 lines below)

'Main game mode
Public Class Game

    Dim shrOperate1, shrOperate2,
        shrCorrect, shrIncorrect,
        shrTimer, shrTimeLimit, shrMsgTimer,
        shrBuffDebuff As Short
    'Variables that will determine the sign (shrOperate2 will only be used in HL and Hyper mode)
    'Variables that keep track of the number of correct and incorrect questions
    'Timer variable as well as time limit, and a time limit for messages on screen
    'Vabiable used to determine if the user gets debuffs

    Dim intTerm1, intTerm2, intTerm3 As Integer
    'Variables that will determine the numbers to be opearated on (intTerm3 will only be used in HL and Hyper Mode)
    'Using intergers because 32 bit computation is quicker.

    Dim blnPause As Boolean
    'Determines whether or not the game is paused

    'Fades in form over time based on fade in speed
    Private Sub FadeTick_Tick(sender As Object, e As EventArgs) Handles tmrFadeTick.Tick
        If Me.Opacity = 1 Then
            'Stops fade when done.
            tmrFadeTick.Stop()

            'Start music (removed)

            'Prompts users to use order of operations if there are 3 operations
            If shrGamemode >= 3 Then
                MessageBox.Show("Remember to follow the order of operations!", "Important!")
            End If
            MessageBox.Show("Start when ready." & ControlChars.NewLine & "You will have limited time to complete" & ControlChars.NewLine & "all of your tests (math problems). Good luck!", "Ready?")
            'Prompts user to be ready

            'Display accurate dates and theme based on difficulty
            'Math Studies only lasts 1 year, while the others last 2 years
            'Hyper IB mode uses a red BG
            Select Case shrGamemode
                Case 1
                    Me.BackgroundImage = My.Resources.bgTileHexBlue
                    lblDispAuxJune.Text = "June 2017"
                Case 2
                    Me.BackgroundImage = My.Resources.bgTileHexBlue
                    lblDispAuxJune.Text = "June 2018"
                Case 3 To 4
                    Me.BackgroundImage = My.Resources.bgTileHexRed
                    lblDispAuxJune.Text = "June 2018"
            End Select
            lblDispAuxSeptember.Text = "September 2016"

            'Show elements
            lblQuestionsRemaining.Show()
            lblTimerDisp.Text = "Time Remaining: " & shrTimeLimit

            tmrGameTick.Start()
            shrTimer = 0
            'Start Game Timer after user prompt
        Else
            'If fade is not done, keep fading in
            Me.Opacity += sglWindowFadeSpd
        End If
    End Sub

    'Code for maximizing and restoring window
    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If blnMaximize = False Then
            'If window is not maximized, maximize
            btnMaximize.BackgroundImage = My.Resources.icoRestore
            Me.WindowState = FormWindowState.Maximized
            blnMaximize += 1
            'Flips boolean to remember that window is maximized

            'Scaling for UI
            lblTerm1.Font = New Font(lblTerm1.Font.FontFamily, Me.Width / 30)
            lblTerm2.Font = New Font(lblTerm2.Font.FontFamily, Me.Width / 30)
            lblTerm3.Font = New Font(lblTerm3.Font.FontFamily, Me.Width / 30)
            lblOperate1.Font = New Font(lblOperate1.Font.FontFamily, Me.Width / 30)
            lblOperate2.Font = New Font(lblOperate2.Font.FontFamily, Me.Width / 30)
            tlpProblem.Top -= Me.Height / 8
            tlpProblem.Height += Me.Height / 5
            If shrGamemode < 3 Then
                tlpProblem.Left = Me.Width / 2 - (tlpProblem.Width / 3)
            Else
                tlpProblem.Left = Me.Width / 2 - (tlpProblem.Width / 2)
            End If
            'Scaling math problem

            lblDispTitle.Font = New Font(lblDispTitle.Font.FontFamily, style:=FontStyle.Bold, emSize:=Me.Width / 30)
            lblDispTitle.Left = Me.Width / 2 - lblDispTitle.Width / 2
            'Scaling title
        Else
            'If window is maxmized, restore
            btnMaximize.BackgroundImage = My.Resources.icoMaximize
            Me.WindowState = FormWindowState.Normal
            blnMaximize += 1
            'Flips boolean to remember that window is restored

            'Scaling for UI
            lblTerm1.Font = New Font(lblTerm1.Font.FontFamily, 16)
            lblTerm2.Font = New Font(lblTerm2.Font.FontFamily, 16)
            lblTerm3.Font = New Font(lblTerm3.Font.FontFamily, 16)
            lblOperate1.Font = New Font(lblOperate1.Font.FontFamily, 16)
            lblOperate2.Font = New Font(lblOperate2.Font.FontFamily, 16)
            tlpProblem.Top = 166
            tlpProblem.Height = 61
            If shrGamemode < 3 Then
                tlpProblem.Left = Me.Width / 2 - (tlpProblem.Width / 3)
            Else
                tlpProblem.Left = Me.Width / 2 - (tlpProblem.Width / 2)
            End If
            'Scaling math problem

            lblDispTitle.Font = New Font(lblDispTitle.Font.FontFamily, style:=FontStyle.Bold, emSize:=18)
            lblDispTitle.Left = Me.Width / 2 - lblDispTitle.Width / 2
            'Scaling title
        End If
    End Sub

    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If blnMaximize = True Then
            'If window should be maximized, maximize
            btnMaximize.BackgroundImage = My.Resources.icoRestore
            Me.WindowState = FormWindowState.Maximized

            'Scaling for UI
            lblTerm1.Font = New Font(lblTerm1.Font.FontFamily, Me.Width / 30)
            lblTerm2.Font = New Font(lblTerm2.Font.FontFamily, Me.Width / 30)
            lblTerm3.Font = New Font(lblTerm3.Font.FontFamily, Me.Width / 30)
            lblOperate1.Font = New Font(lblOperate1.Font.FontFamily, Me.Width / 30)
            lblOperate2.Font = New Font(lblOperate2.Font.FontFamily, Me.Width / 30)
            tlpProblem.Top -= Me.Height / 8
            tlpProblem.Height += Me.Height / 5
            If shrGamemode < 3 Then
                tlpProblem.Left = Me.Width / 2 - (tlpProblem.Width / 3)
            Else
                tlpProblem.Left = Me.Width / 2 - (tlpProblem.Width / 2)
            End If
            'Scaling math problem

            lblDispTitle.Font = New Font(lblDispTitle.Font.FontFamily, style:=FontStyle.Bold, emSize:=Me.Width / 30)
            lblDispTitle.Left = Me.Width / 2 - lblDispTitle.Width / 2
            'Scaling title
        End If

        Randomize()
        'Randomize seed for more randomness

        tmrFadeTick.Start()
        Me.Opacity = 0
        'Start fade in

        KeyPreview = True
        'For cheat menu

        'Hide unecessary elements
        lblDispPause.Hide()

        'GENERATING THE NUMBERS AND STARTING THE GAME:
        Select Case shrGamemode
            'Display info and generate data depending on game mode
            Case 1
                'If game mode is math studies,
                lblInfoDisplay.Text = "IB Math Studies" & ControlChars.NewLine & strUserName
                tlpProblem.Left = Me.Width / 2 - (tlpProblem.Width * 0.3)
                'Generates first problem and displays part of the problem

                'Clearing other values since MS doesn't use those
                lblTerm3.Hide()
                lblOperate2.Hide()
                lblOperate2.Text = ""
                lblTerm3.Text = ""

                'Set time limit and tests remaining
                shrTimeLimit = 60
                lblQuestionsRemaining.Text = "Remaining Tests: 15"

                'Make BG of labels easier to see
                lblTerm1.BackColor = Color.LightGray
                lblTerm2.BackColor = Color.LightGray
                lblOperate1.BackColor = Color.LightGray

            Case 2
                'If game mode is SL math,
                lblInfoDisplay.Text = "IB Math SL" & ControlChars.NewLine & strUserName
                tlpProblem.Left = Me.Width / 2 - (tlpProblem.Width * 0.3)
                'Generates first problem and displays part of the problem

                'Clearing other values since SL doesn't use those
                lblTerm3.Hide()
                lblOperate2.Hide()
                lblOperate2.Text = ""
                lblTerm3.Text = ""

                'Set time limit and tests remaining
                shrTimeLimit = 100
                lblQuestionsRemaining.Text = "Remaining Tests: 20"

                'Make BG of labels easier to see
                lblTerm1.BackColor = Color.LightGray
                lblTerm2.BackColor = Color.LightGray
                lblOperate1.BackColor = Color.LightGray

            Case 3
                'If game mode is HL math,
                lblInfoDisplay.Text = "IB Math HL" & ControlChars.NewLine & strUserName
                'Set time limit
                shrTimeLimit = 100
                lblQuestionsRemaining.Text = "Remaining Tests: 20"

                'Make BG of labels easier to see
                lblTerm1.BackColor = Color.LightGray
                lblTerm2.BackColor = Color.LightGray
                lblTerm3.BackColor = Color.LightGray
                lblOperate2.BackColor = Color.LightGray
                lblOperate1.BackColor = Color.LightGray

            Case 4
                lblInfoDisplay.ForeColor = Color.Red
                lblInfoDisplay.Text = "Hyper IB Mode" & ControlChars.NewLine & strUserName
                'Set time limit
                shrTimeLimit = 100
                lblQuestionsRemaining.Text = "Remaining Tests: 20"

                'Make BG of labels easier to see
                lblTerm1.BackColor = Color.LightGray
                lblTerm2.BackColor = Color.LightGray
                lblTerm3.BackColor = Color.LightGray
                lblOperate2.BackColor = Color.LightGray
                lblOperate1.BackColor = Color.LightGray
        End Select

        'Display math problem
        intTerm1 = NumberGen()
        intTerm2 = NumberGen()
        intTerm3 = NumberGen()
        'Generate numbers
        'SEE ALSO: "NumberGen"

        shrOperate1 = SignGen()
        shrOperate2 = SignGen()
        'Generate signs

        lblTerm1.Text = intTerm1
        lblTerm2.Text = intTerm2
        lblTerm3.Text = intTerm3
        'Displays numbers

        SignDisp()
        'Dispays sign(s) (minus changes in the function)
        'SEE ALSO: "SignGen"
    End Sub

    Private Sub btnReturnMenu_Click(sender As Object, e As EventArgs) Handles btnReturnMenu.Click
        'If user clicks "Return to Menu"
        tmrGameTick.Stop()
        'Pause game while showing prompt

        Dim choice = MsgBox("Are you sure you want to return to the menu? All progress will be lost!", MsgBoxStyle.YesNo, "Confirm")
        If choice = MsgBoxResult.Yes Then
            RootMenu.Show()
            My.Computer.Audio.Stop()
            'Stop audio
            Me.Close()
            'Terminate self
        Else
            tmrGameTick.Start()
            'Start timer again if user decides to keep playing
        End If
    End Sub


    'WHEN THE USER SUBMITS AN ANSWER
    Private Sub btnSubmitAns_Click(sender As Object, e As EventArgs) Handles btnSubmitAns.Click
        'This section uses quite a few If statements - follow along with the comments
        tmrGameTick.Stop()
        'Stops timer while processing

        'CHECK 1: Check if textbox input is valid
        If IsNothing(txtAnsInput.Text) Or Not IsNumeric(txtAnsInput.Text) Then
            'In the event that the input contains characters other than numbers or is blank, an error message is displayed
            MessageBox.Show("Please enter valid input.", "Error")
            'Catch invalid input
            tmrGameTick.Start()
            'Resume game
        Else
            'CHECKING ANSWER
            If checkans() = True Then
                'Case: Correct
                MessageBox.Show("Correct, good job!", "Result...")
                shrCorrect += 1
            Else
                'Case: Incorrect
                MessageBox.Show("Incorrect.", "Result...")
                shrIncorrect += 1
            End If

            Select Case shrGamemode
                'Displays the number of remaining questions depending on game mode
                Case 1
                    'In MS, you have 15 tests to do
                    lblQuestionsRemaining.Text = "Remaining Tests: " & 15 - shrCorrect - shrIncorrect
                Case Is >= 2
                    'In SL, HL and H-IB, you have 20 tests to do
                    lblQuestionsRemaining.Text = "Remaining Tests: " & 20 - shrCorrect - shrIncorrect
            End Select

            'HOUSEKEEPING STUFF

            lblCorrect.Text = "Correct: " & shrCorrect
            lblIncorrect.Text = "Incorrect: " & shrIncorrect
            sglGrade = shrCorrect / (shrCorrect + shrIncorrect) * 100
            lblGrade.Text = "Grade: " & sglGrade & "%"
            shrMsgTimer = 5

            'CHECK 2: Check if the user has completed all questions
            If (shrGamemode = 1 And shrCorrect + shrIncorrect >= 15) Or (shrGamemode > 1 And shrCorrect + shrIncorrect >= 20) Then
                'If so, end and go to another screen
                btnSubmitAns.Enabled = False
                lblTimerNotch.Left = Me.Width - lblTimerNotch.Width
                'Move timer notch all the way to the other side to show that the user has completed the year.
                MessageBox.Show("You successfully completed your IB math program. Congratulations! You will now be shown your final report card.", "Good Job!")
                tmrGameTick.Stop()
                ReportCard.Show()
                My.Computer.Audio.Stop()
                'Stop audio
                Me.Close()
                'Close form and move on
            Else
                'If the user has to keep answering questions,
                'GENERATE NEXT PROBLEM (same code as before)

                intTerm1 = NumberGen()
                intTerm2 = NumberGen()
                intTerm3 = NumberGen()

                shrOperate1 = SignGen()
                shrOperate2 = SignGen()

                lblTerm1.Text = intTerm1
                lblTerm2.Text = intTerm2
                lblTerm3.Text = intTerm3

                SignDisp()


                'CHECK 3:
                'Rewards/Debuffs:

                'HOW THEY WORK:
                'If the user is failing, and has over -5 on the variable,
                'The user is given 20 seconds less
                'If the user is doing well, and has over +5 on the variable,
                'The user is either:
                '1. Given 20 more seconds
                '2. Given 5 fewer tests

                If shrBuffDebuff >= 5 Then
                    MessageBox.Show("Your parents have signed you up for extracurricular math in order to improve your marks. You now have less time to focus on studying", "Uh-oh")
                    shrTimer += 20
                    lblTimerDisp.Text = "Time Remaining: " & shrTimeLimit - shrTimer

                ElseIf shrBuffDebuff <= -5 Then
                    Dim shrOutcome As Short
                    shrOutcome = Int(2 * Rnd())
                    Select Case shrOutcome
                        Case 0
                            MessageBox.Show("Your parents are proud of your performance and have allotted more time to your studies.", "Hooray!")
                            shrTimeLimit += 20
                            lblTimerDisp.Text = "Time Remaining: " & shrTimeLimit - shrTimer
                        Case 1
                            MessageBox.Show("Your teachers see your excellent performance and are allowing you to skip 5 tests.", "Hooray!")
                            shrCorrect += 5
                            Select Case shrGamemode
                                Case 1
                                    If 15 - shrCorrect - shrIncorrect < 1 Then
                                        shrCorrect += (15 - shrCorrect - shrIncorrect) - 1
                                    End If
                                    lblQuestionsRemaining.Text = "Remaining Tests: " & 15 - shrCorrect - shrIncorrect
                                Case Is >= 2
                                    If 20 - shrCorrect - shrIncorrect < 1 Then
                                        shrCorrect += (20 - shrCorrect - shrIncorrect) - 1
                                    End If
                                    lblQuestionsRemaining.Text = "Remaining Tests: " & 20 - shrCorrect - shrIncorrect
                            End Select
                            lblCorrect.Text = "Correct: " & shrCorrect
                    End Select
                End If
                shrBuffDebuff = 0
                tmrGameTick.Start()
                'Resume game
            End If
        End If
        txtAnsInput.Clear()
        'Clear textbox
    End Sub

    Private Sub txtAnsInput_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAnsInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Detects pressing enter
            btnSubmitAns.PerformClick()
        End If
    End Sub

    Private Sub tmrGameTick_Tick(sender As Object, e As EventArgs) Handles tmrGameTick.Tick
        'Every second, game ticks
        shrTimer += 1

        If shrTimer > shrTimeLimit Then
            'If user goes past time limit, show failure
            tmrGameTick.Stop()
            MessageBox.Show("You have failed to complete all assignments on time and will receive a zero in this course", "Uh-oh")
            sglGrade = 0
            ReportCard.Show()
            My.Computer.Audio.Stop()
            'Stop audio
            Me.Close()
            'Fail and move on
        Else
            lblTimerDisp.Text = "Time Remaining: " & shrTimeLimit - shrTimer
            lblTimerNotch.Left = Me.Width * shrTimer / shrTimeLimit
        End If

        'Splash info - like in Cities: Skylines or other games with instant feedback messages
        If shrMsgTimer >= 3 And (shrCorrect > 0 Or shrIncorrect > 0) Then


            'Display a message according to mark
            'ALSO, Buff/Debuff System Mechanics
            'Depending on mark, values are either added of subtracted to/from a variable
            '   Negative = Good
            '   Positive = Bad
            '   Mark over 95 = -2
            '   Mark 80 to 95 = -1
            '   Mark 50 to 79 = + 1
            '   Mark below 50 = +2

            Dim shrMsg As Short
            Dim strMsgText(2) As String
            Select Case sglGrade
                Case Is > 95
                    strMsgText = New String() {"Your parents are proud of your performance.",
                                           "You're doing very well in school, good job!"}
                    shrBuffDebuff -= 2
                    'Reward/Punishment mechanic: dependant on how well user is doing
                Case 80 To 95
                    strMsgText = New String() {"Your parents say that you're doing well, but can still do better!",
                                           "You're doing fairly well in school."}
                    shrBuffDebuff -= 1
                Case 65 To 79
                    strMsgText = New String() {"Your parents want you to keep getting better.",
                                           "Your parents are considering extracurricular math to help you get better."}
                    shrBuffDebuff += 1
                Case 50 To 64
                    strMsgText = New String() {"Your parents are not pleased with your performance in school.",
                                           "Your parents are considering extracurricular math to help you get better."}
                    shrBuffDebuff += 1
                Case Is < 50
                    strMsgText = New String() {"Your parents are VERY concerned with your performance in school.",
                                           "Your parents are heavily considering extracurricular math to help you get better."}
                    shrBuffDebuff += 2
            End Select

            shrMsg = Int(2 * Rnd())
            'Selects message randomly depending on how well user is doing
            lblCurrentInfo.Text = "Current Info: " & strMsgText(shrMsg)
            shrMsgTimer = 0
            'Resets message tick

        Else
            shrMsgTimer += 1
            'Otherwise, wait until displaying the next message
        End If

    End Sub

    Private Sub btnPauseResume_Click(sender As Object, e As EventArgs) Handles btnPauseResume.Click
        'If user clicks pause/resume button

        If blnPause = False Then
            'If game is not paused, pause the game by stopping the gametick
            tmrGameTick.Stop()
            Me.BackgroundImage = My.Resources.bgTileHexGray
            'Change BG to show pause
            blnPause += 1
            btnPauseResume.BackgroundImage = My.Resources.icoPlay
            'Flip pause state

            'Control Lock and hide elements
            btnSubmitAns.Enabled = False
            txtAnsInput.Enabled = False
            tlpProblem.Hide()
            lblDispPause.Show()
        Else
            'If game is paused, resume game by starting gametick
            tmrGameTick.Start()
            Select Case shrGamemode
                Case 1 To 2
                    Me.BackgroundImage = My.Resources.bgTileHexBlue
                Case 3 To 4
                    Me.BackgroundImage = My.Resources.bgTileHexRed
            End Select
            'Restores BG (Refer to above for more info)
            blnPause += 1
            btnPauseResume.BackgroundImage = My.Resources.icoPause
            'Flip pause state

            'Control Unlock and show elements
            btnSubmitAns.Enabled = True
            txtAnsInput.Enabled = True
            tlpProblem.Show()
            lblDispPause.Hide()
        End If

    End Sub

    'Cheats
    Private Sub Game_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If blnCheat = True Then
            If (e.KeyCode = Keys.F10 AndAlso e.Modifiers = Keys.Control) Then
                shrTimeLimit += 30
                'Add 30 seconds to time limit
            ElseIf (e.KeyCode = Keys.F9 AndAlso e.Modifiers = Keys.Control) Then
                shrCorrect += 1
                lblCorrect.Text = "Correct: " & shrCorrect
                'Add 1 to correct
            ElseIf (e.KeyCode = Keys.F8 AndAlso e.Modifiers = Keys.Control) Then
                shrIncorrect += 1
                lblIncorrect.Text = "Incorrect: " & shrIncorrect
                'Add 1 to incorrect
            End If
        End If
    End Sub


    'FUNCTIONS
    'Used to make code more efficient
    'Because I don't want to write 1500 lines of code
    'And you probably don't want to read it

    'Used for number generation based on game mode
    Public Function NumberGen() As Short
        'Yo dawg, I heard you like randomized stuff, so I put a randomize() after a randomize() so you can random while you random.
        Randomize()
        Select Case shrGamemode
            Case 1
                Return Int(16 * Rnd())
                'Generates number between 0 and 15 for MS
            Case 2 To 3
                Return Int(31 * Rnd())
                'Generates number between 0 and 30 for SL or HL
            Case 4
                Return Int(101 * Rnd())
                'Generates number between 0 and 100 for Hyper IB
        End Select
    End Function

    'Generates operation signs based on game mode
    Public Function SignGen() As Short
        Select Case shrGamemode
            Case 1
                Return Int(2 * Rnd() + 1)
                'Addition or subtraction
            Case Else
                Return Int(4 * Rnd() + 1)
                'All operations
        End Select
    End Function

    'Subroutine for displaying the sign and making adjustments in case of certain cases
    Sub SignDisp()
        'Display sign on first operator
        Select Case shrOperate1
            Case 1
                'If addition
                lblOperate1.Text = "+"
            Case 2
                'If subraction
                lblOperate1.Text = "-"
            Case 3
                'If multiplication
                lblOperate1.Text = "x"
                'Reduction for multiplication so as to reduce difficulty
                intTerm1 \= 2
                lblTerm1.Text = intTerm1
                intTerm2 \= 2
                lblTerm2.Text = intTerm2
                'Re-display terms to update info
            Case 4
                'If division
                lblOperate1.Text = "÷"
                'Makes all numbers divisible properly and reduces difficulty
                intTerm1 \= 2
                intTerm2 \= 2
                If intTerm1 < 1 Then
                    intTerm1 += 1
                End If
                If intTerm2 < 1 Then
                    intTerm2 += 1
                End If
                intTerm1 *= intTerm2
                lblTerm1.Text = intTerm1
                lblTerm2.Text = intTerm2
                'Re-display terms to update info
        End Select

        If shrGamemode >= 3 Then
            'Display sign on second operator
            Select Case shrOperate2
                Case 1
                    'If addition
                    lblOperate2.Text = "+"
                Case 2
                    'If subtraction
                    lblOperate2.Text = "-"
                Case 3
                    'If multiplication
                    lblOperate2.Text = "x"
                    'Reduction for multiplication so as to reduce difficulty
                    intTerm3 \= 2
                    lblTerm3.Text = intTerm3
                    'Re-display terms
                Case 4
                    'If division
                    lblOperate2.Text = "÷"
                    'Makes all numbers divisible properly and reduces difficulty
                    intTerm3 \= 2
                    If intTerm3 < 1 Then
                        intTerm3 += 1
                    End If
                    intTerm2 *= intTerm3
                    intTerm1 *= intTerm2
                    intTerm1 *= intTerm3
                    lblTerm1.Text = intTerm1
                    lblTerm2.Text = intTerm2
                    lblTerm3.Text = intTerm3
                    'Re-display terms
                Case Else
                    'If it's not being used
                    lblOperate2.Text = ""
            End Select
        End If
    End Sub

    'MASSIVE WALL OF CODE REQUIRED FOR ACTUALLY CHECKING THE ANSWER - PROCEED AT YOUR OWN RISK
    'Just kidding, it's all structured and you should be able to understand how it works.
    'There are 16 possible outcomes (4 primary and secondary operators) and every single one is listed so it may seem daunting.
    Public Function checkans() As Boolean
        Dim intAnswer As Integer
        intAnswer = Val(txtAnsInput.Text)
        'Uses an intermediate variable

        Select Case shrOperate1
            Case 1
                'If first operator is +,
                If (shrGamemode = 1 Or shrGamemode = 2) And intAnswer = intTerm1 + intTerm2 Then
                    Return True
                ElseIf shrGamemode = 3 Or shrGamemode = 4 Then
                    Select Case shrOperate2
                        Case 1
                            'If second operator is +,
                            If intAnswer = intTerm1 + intTerm2 + intTerm3 Then
                                Return True
                            End If
                        Case 2
                            'If second operator is -,
                            If intAnswer = intTerm1 + intTerm2 - intTerm3 Then
                                Return True
                            End If
                        Case 3
                            'If second operator is *,
                            If intAnswer = intTerm1 + intTerm2 * intTerm3 Then
                                Return True
                            End If
                        Case 4
                            'If second operator is /,
                            If intAnswer = intTerm1 + intTerm2 / intTerm3 Then
                                Return True
                            End If
                    End Select
                End If
            Case 2
                'If first operator is -,
                If (shrGamemode = 1 Or shrGamemode = 2) And intAnswer = intTerm1 - intTerm2 Then
                    Return True
                ElseIf shrGamemode = 3 Or shrGamemode = 4 Then
                    Select Case shrOperate2
                        Case 1
                            'If second operator is +,
                            If intAnswer = intTerm1 - intTerm2 + intTerm3 Then
                                Return True
                            End If
                        Case 2
                            'If second operator is -,
                            If intAnswer = intTerm1 - intTerm2 - intTerm3 Then
                                Return True
                            End If
                        Case 3
                            'If second operator is *,
                            If intAnswer = intTerm1 - intTerm2 * intTerm3 Then
                                Return True
                            End If
                        Case 4
                            'If second operator is /,
                            If intAnswer = intTerm1 - intTerm2 / intTerm3 Then
                                Return True
                            End If
                    End Select
                End If
            Case 3
                'If first operator is *,
                If (shrGamemode = 1 Or shrGamemode = 2) And intAnswer = intTerm1 * intTerm2 Then
                    Return True
                ElseIf shrGamemode = 3 Or shrGamemode = 4 Then
                    Select Case shrOperate2
                        Case 1
                            'If second operator is +,
                            If intAnswer = intTerm1 * intTerm2 + intTerm3 Then
                                Return True
                            End If
                        Case 2
                            'If second operator is -,
                            If intAnswer = intTerm1 * intTerm2 - intTerm3 Then
                                Return True
                            End If
                        Case 3
                            'If second operator is *,
                            If intAnswer = intTerm1 * intTerm2 * intTerm3 Then
                                Return True
                            End If
                        Case 4
                            'If second operator is /,
                            If intAnswer = intTerm1 * intTerm2 / intTerm3 Then
                                Return True
                            End If
                    End Select
                End If
            Case 4
                'If first operator is /,
                If (shrGamemode = 1 Or shrGamemode = 2) And intAnswer = intTerm1 / intTerm2 Then
                    Return True
                ElseIf shrGamemode = 3 Or shrGamemode = 4 Then
                    Select Case shrOperate2
                        Case 1
                            'If second operator is +,
                            If intAnswer = intTerm1 / intTerm2 + intTerm3 Then
                                Return True
                            End If
                        Case 2
                            'If second operator is -,
                            If intAnswer = intTerm1 / intTerm2 - intTerm3 Then
                                Return True
                            End If
                        Case 3
                            'If second operator is *,
                            If intAnswer = intTerm1 / intTerm2 * intTerm3 Then
                                Return True
                            End If
                        Case 4
                            'If second operator is /,
                            If intAnswer = intTerm1 / intTerm2 / intTerm3 Then
                                Return True
                            End If
                    End Select
                End If
            Case Else
                Return False
        End Select
    End Function
End Class