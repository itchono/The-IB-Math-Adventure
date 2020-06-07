'Ending message
Public Class FinalStory

    Dim shrStory As Short
    'Remembering what part of the story text to load

    'Code for maximizing and restoring window
    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If blnMaximize = False Then
            'If window is not maximized, maximize
            btnMaximize.BackgroundImage = My.Resources.icoRestore
            Me.WindowState = FormWindowState.Maximized
            blnMaximize += 1
            'Flips boolean to remember that window is maximized

            'UI Scaling
            lblStory1.Font = New Font(lblStory1.Font.FontFamily, Me.Width / 50)
            lblStory2.Font = New Font(lblStory2.Font.FontFamily, Me.Width / 50)
            lblStory3.Font = New Font(lblStory3.Font.FontFamily, Me.Width / 50)
            lblDispTitle.Font = New Font(lblDispTitle.Font.FontFamily, style:=FontStyle.Bold, emSize:=Me.Width / 50)
            lblDispTitle.Left = Me.Width / 2 - lblDispTitle.Width / 2
        Else
            'If window is maxmized, restore
            btnMaximize.BackgroundImage = My.Resources.icoMaximize
            Me.WindowState = FormWindowState.Normal
            blnMaximize += 1
            'Flips boolean to remember that window is restored

            'UI Scaling
            lblStory1.Font = New Font(lblStory1.Font.FontFamily, 16)
            lblStory2.Font = New Font(lblStory2.Font.FontFamily, 16)
            lblStory3.Font = New Font(lblStory3.Font.FontFamily, 16)
            lblDispTitle.Font = New Font(lblDispTitle.Font.FontFamily, style:=FontStyle.Bold, emSize:=16)
            lblDispTitle.Left = Me.Width / 2 - lblDispTitle.Width / 2
        End If
    End Sub

    'Fades in form over time based on fade in speed
    Private Sub tmrFadeTick_Tick(sender As Object, e As EventArgs) Handles tmrFadeTick.Tick
        If Me.Opacity = 1 Then
            'If opacity is 100%, stop fade in
            tmrFadeTick.Stop()
        Else
            Me.Opacity += sglWindowFadeSpd
            'Otherwise, fade in
        End If
    End Sub

    Private Sub btnReturnMenu_Click(sender As Object, e As EventArgs) Handles btnReturnMenu.Click
        'If user clicks "Return to Menu"
        Dim choice = MsgBox("Are you sure you want to return to the menu? All progress will be lost!", MsgBoxStyle.YesNo, "Confirm")
        'Ask for confirmation
        If choice = MsgBoxResult.Yes Then
            RootMenu.Show()
            Me.Close()
            'Terminate self
        End If
    End Sub

    Private Sub FinalStory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If blnMaximize = True Then
            'If window is not maximized, maximize
            btnMaximize.BackgroundImage = My.Resources.icoRestore
            Me.WindowState = FormWindowState.Maximized

            'UI Scaling
            lblStory1.Font = New Font(lblStory1.Font.FontFamily, Me.Width / 50)
            lblStory2.Font = New Font(lblStory2.Font.FontFamily, Me.Width / 50)
            lblStory3.Font = New Font(lblStory3.Font.FontFamily, Me.Width / 50)
            lblDispTitle.Font = New Font(lblDispTitle.Font.FontFamily, style:=FontStyle.Bold, emSize:=Me.Width / 50)
            lblDispTitle.Left = Me.Width / 2 - lblDispTitle.Width / 2
        End If

        Me.Opacity = 0
        tmrFadeTick.Start()
        'Begin fade in


        'Story Preparation
        Dim strUniName(9) As String
        lblStory2.Hide()
        lblStory3.Hide()
        strUniName = New String() {"Algonquin College",
                                   "uOttawa",
                                   "Carleton University",
                                   "Ryerson University",
                                   "the University of Toronto",
                                   "the University of Waterloo",
                                   "McGill University",
                                   "the Massachusetts Institute of Technology",
                                   "Harvard University"}
        'Displays the post-secondary institution that the user attended
        lblStory1.Text = "With " & strUserName & "'s graduation," & ControlChars.NewLine & "they moved onto " &
            strUniName(shrUniChoice) & ControlChars.NewLine & " to pursue their post-secondary education."

        'Fills in username
        lblStory2.Text = "Though they missed the thrill of" & ControlChars.NewLine & "the International Baccalaureate program at times, " & ControlChars.NewLine &
            strUserName & ControlChars.NewLine & "was glad that it was all over."
    End Sub

    Private Sub btnStoryNxt_Click(sender As Object, e As EventArgs) Handles btnStoryNxt.Click
        shrStory += 1
        'Add 1 to story phase

        'Show corresponding story entry
        Select Case shrStory
            Case 1
                lblStory2.Show()
            Case 2
                lblStory3.Show()
                btnStoryNxt.Width += Me.Width / 20
                btnStoryNxt.Left -= Me.Width / 20
                btnStoryNxt.Text = "Return to Menu"
            Case 3
                Dim shrScore As Short
                shrScore = sglGrade * shrUniversityTier
                If shrScore > My.Settings.HighScore Then
                    My.Settings.HighScore = shrScore
                End If
                'The full end of the game
                MessageBox.Show("Your final score is " & shrScore & " points.", "One More Thing...")
                RootMenu.Show()
                Me.Close()
        End Select
    End Sub
End Class