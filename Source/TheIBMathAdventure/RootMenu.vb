'Mingde Yin's "The IB Math Adventure"
'ICS2O-02 2016 - 2017 
'Mr. Hudson
'Music from FTL: Faster than Light used

'Build Version: Release 1.3 (Hotfix patch)
'2016/12/17

'The only thing that was changed was a copy/paste of one line of code as well as changing SignDisp to a subroutine

'The IB Math Adventure follows the journey of a young student in the IB DP program, trying to get their IB diploma
'and go to a university. The rich, 5 minute linear story provides an exciting adventure with various
'twists and turns. Will you be able to go to a good university?


'Outline of the program:
'1. Root Menu
'Form shown on startup - Welcome to the user
'User can start the game, tweak settings, view the credits, their achievements or quit the game
'   1a. Settings
'   The user can adjust fade speed, sound (off/on), or reset stats and settings
'   1b. Credits
'   1c. Achievements
'   The user can view if they've gotten 1 of 4 achievements and the high score
'   These are saved using my.settings
'CHEATS:
'The user can activate cheats by clicking on the text in the credits several times until a prompt comes up.
'This will allow them to do various things, such a skip tests or change scenes at will.

'2. Mode Select
'User is guided through setting up their game, including entering a username and selecting a difficulty
'User also sees a bit of lore about the game

'3. Main Game
'User plays through one of 3 (4) difficulties:
'   Math Studies: Math problems involving 2 numbers and simple addition or subtraction
'   SL Math: Math problems involving 2 numbers and simple addition, subtraction, multipication or division
'   HL Math: Math problems involving 2 or 3 numbers and addition, subtraction, multiplication or division
'   (Secret) Hyper IB Mode: HL math plus exponentiation as well as random multiple choice science problems

'The various game modes:
'   Math Studies (MCR3UE): 15 questions, 1 operation (addition and subtraction only), 2 numbers from 0 to 15, 60 seconds
'   SL Math (MHF4U2/MCV4U2): 20 quetions, 1 operation (all operations), 2 numbers from 0 to 30, 100 seconds
'   HL Math (MHF4U1/MCV4U1): 20 questions, 2 operations (all operations), 3 numbers from 0 to 30, 100 seconds
'   Hyper IB Mode: 20 questions, 2 operations (all operations), 3 numbers from 0 to 100, 100 seconds

'Buff/Debuff Mechanic:
'Depending on mark, values are either added of subtracted to/from a variable
'   Negative = Good
'   Positive = Bad
'   Mark over 95 = -2
'   Mark 80 to 95 = -1
'   Mark 50 to 79 = + 1
'   Mark below 50 = +2

'Rewards/Debuffs - HOW THEY WORK:
'If the user is failing, and has over -5 on the variable,
'   The user is given 20 seconds less
'If the user is doing well, and has over +5 on the variable,
'The user is either:
'   1. Given 20 more seconds
'   2. Given 5 fewer tests

'The grade is calculated as follows: (Correct) / (Correct + Incorrect) = (Grade)  'Which is essentially just an accuracy percentage.

'The user is given live feedback through the "Current Info" label.

'When the user finishes all tests, they are taken to the report card.
'If the user goes not finish all tests by the time the timer reaches 0, they are given a zero (0).

'4. Report Card
'Displays final stats
'If the user gets above 50 (60 in some cases), they can choose a university.

'5. University Select
'Lets you choose one of 8 institutions based on user's performance
'MARKING SCHEME
'       Less than 50    50 to 59    60 to 74    75 to 84    85 to 94    95 or Above
'MS     FAIL            FAIL        Tier 1      Tier 2      Tier 2      Tier 2
'SL     FAIL            Tier 1      Tier 2      Tier 3      Tier 4      Tier 4
'HL     FAIL            Tier 1      Tier 2      Tier 3      Tier 4      Tier 5    **Also applies to Hyper IB Mode

'6. Final Story
'An ending message for the user.


'Initial menu
Public Class RootMenu

    Private Sub RootMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        'Randomize seed for more randomness on program load

        tmrFadeTick.Start()
        Me.Opacity = 0
        'For fading in

        KeyPreview = True
        'For cheats

        'Splash text - like in Minecraft
        'Chooses 1 of 10 random messages
        Dim strSplashTextDB(9) As String
        strSplashTextDB = New String() {"Now with 100% more game!",
                               "Particle Wang got a 79.",
                               "I don't know - Kevin Gu 2016",
                               "It's kindergarten. -Dragos Calitoiu 2016 - Kevin Zhao 2016",
                               "One hundred and two degrees celsius.",
                               "Healthy food is self-actualization. - Patrick Wang 2016",
                               "Once they kill you, you're dead - Kevin Zhao 2016",
                               "97",
                               "10/10 - IGN",
                               "I am currently panicking a lot like a lot cause I just realized I haven't studied and the test is tmrw - Patrick Wang 2016"}
        Dim shrSplashTextSelect As Short
        shrSplashTextSelect = Int(9 * Rnd())

        lblSplashText.Text = strSplashTextDB(shrSplashTextSelect)

        'Checks if window should be maximized
        If blnMaximize = True Then
            'If so, maximizes window
            Me.WindowState = FormWindowState.Maximized
            btnMaximize.BackgroundImage = My.Resources.icoRestore


            'Scaling for UI
            lblMainTitle.Font = New Font(lblMainTitle.Font.FontFamily, Me.Height / 30)
            lblSplashText.Font = New Font(lblSplashText.Font.FontFamily, Me.Height / 40)
            lblSplashText.MaximumSize = New Size(Me.Width / 2, 0)
            tlpButtons.Size = New Size(Me.Width / 5, Me.Width / 5)
            tlpButtons.Top = Me.Height - tlpButtons.Height - 20
            tlpButtons.Left = Me.Width - tlpButtons.Width - 20

            'Button panel, main title, splash text and logo are scaled according to window size - compatability with all resolutions (tested at up to 3840 x 2160p)
        End If

        'More scaling for compatibility in the event that the window takes on a different size
        lblSplashText.Top = Me.Height * 19 / 20 - lblSplashText.Height
        picMainLogo.Size = New Size(lblMainTitle.Height * 2 / 3, lblMainTitle.Height * 2 / 3)
        picMainLogo.Top = lblMainTitle.Top + Me.Height / 15

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        If blnTrackAch4(0) = True Or blnTrackAch4(1) = True Or
                 blnTrackAch4(2) = True Or blnTrackAch4(3) = True Then
            MessageBox.Show("Good job getting " & strUserName & " through IB and high school!", "Before you go...")
        End If
        My.Settings.Save()
        Application.Exit()
        'Quits program if user clicks quit
    End Sub

    Private Sub btnStartGame_Click(sender As Object, e As EventArgs) Handles btnStartGame.Click
        ModeSelect.Show()
        Me.Close()
        'Changes to ModeSelect form
        'Then terminates self
    End Sub


    'Code for maximizing or restoring window
    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        'Maximizing Window
        If blnMaximize = False Then
            'If window is not maximized, maximize the window
            Me.WindowState = FormWindowState.Maximized
            btnMaximize.BackgroundImage = My.Resources.icoRestore
            blnMaximize += 1

            'Scaling for UI - Maximizing
            lblMainTitle.Font = New Font(lblMainTitle.Font.FontFamily, Me.Height / 30)
            'Scaling main title

            lblSplashText.Font = New Font(lblSplashText.Font.FontFamily, Me.Height / 40)
            lblSplashText.MaximumSize = New Size(Me.Width / 2, 0)
            'Scaling splash text

            tlpButtons.Size = New Size(Me.Width / 5, Me.Width / 5)
            tlpButtons.Top = Me.Height - tlpButtons.Height - 20
            tlpButtons.Left = Me.Width - tlpButtons.Width - 20
            'Scaling control buttons

            lblSplashText.Top = Me.Height * 19 / 20 - lblSplashText.Height
            picMainLogo.Size = New Size(lblMainTitle.Height * 2 / 3, lblMainTitle.Height * 2 / 3)
            picMainLogo.Top = lblMainTitle.Top + Me.Height / 15
            'More scaling


            'Restoring Window
        Else
            'If the window is maximized, restore the window
            Me.WindowState = FormWindowState.Normal
            btnMaximize.BackgroundImage = My.Resources.icoMaximize
            blnMaximize += 1

            'Scaling for UI - Restoring to default values
            lblMainTitle.Font = New Font(lblMainTitle.Font.FontFamily, 16)
            'Sclaing main title

            lblSplashText.Font = New Font(lblSplashText.Font.FontFamily, 14)
            lblSplashText.MaximumSize = New Size(Me.Width / 2, 0)
            'Scaling splash text

            tlpButtons.Size = New Size(158, 221)
            tlpButtons.Left = Me.Width - tlpButtons.Width - 10
            tlpButtons.Top = Me.Height - tlpButtons.Height - 10
            'Scaling control buttons

            lblSplashText.Top = Me.Height * 19 / 20 - lblSplashText.Height
            picMainLogo.Size = New Size(lblMainTitle.Height * 2 / 3, lblMainTitle.Height * 2 / 3)
            picMainLogo.Top = lblMainTitle.Top + Me.Height / 15
            'More scaling
        End If
    End Sub

    'Fades in form over time based on fade in speed
    Private Sub FadeTick_Tick(sender As Object, e As EventArgs) Handles tmrFadeTick.Tick
        If Me.Opacity = 1 Then
            'Stops fade in when opacity reaches 100%
            tmrFadeTick.Stop()
        Else
            Me.Opacity += sglWindowFadeSpd
            'Fades in my fade in speed
        End If
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        'User opens settings menu
        SettingsMenu.ShowDialog()
    End Sub

    Private Sub btnCredits_Click(sender As Object, e As EventArgs) Handles btnCredits.Click
        'User opens credits dialog
        Credits.ShowDialog()
    End Sub

    Private Sub btnAchievements_Click(sender As Object, e As EventArgs) Handles btnAchievements.Click
        'User opens achievements page
        Achievements.Show()
    End Sub

    'DEVELOPER CHEATS
    Private Sub RootMenu_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If blnCheat = True Then
            If (e.KeyCode = Keys.F10 AndAlso e.Modifiers = Keys.Control) Then
                'Brings user to game; HL math and username "Test"
                shrGamemode = 3
                strUserName = "Test"
                Game.Show()
                Me.Close()
            ElseIf (e.KeyCode = Keys.F9 AndAlso e.Modifiers = Keys.Control) Then
                'Brings user to game; SL math and username "Test"
                shrGamemode = 2
                strUserName = "Test"
                Game.Show()
                Me.Close()
            ElseIf (e.KeyCode = Keys.F8 AndAlso e.Modifiers = Keys.Control) Then
                'Brings user to final story scene and username "Test"
                strUserName = "Test"
                FinalStory.Show()
                Me.Close()
            End If
        End If
    End Sub
End Class
