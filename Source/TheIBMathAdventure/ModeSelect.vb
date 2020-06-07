'Allows user to choose their path of play
Public Class ModeSelect

    Dim shrStoryText As Short
    'Remembering what part of the story text to load


    Private Sub ModeSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNameDisplay.Hide()
        lblDiffDisplay.Hide()
        pnlStory.Hide()
        tlpDifficultySelect.Hide()
        'Hides unecessary elements on startup

        tmrFadeTick.Start()
        Me.Opacity = 0
        'For fading in

        'If the window should be maximized
        If blnMaximize = True Then
            Me.WindowState = FormWindowState.Maximized
            btnMaximize.BackgroundImage = My.Resources.icoRestore

            'Scaling for UI
            lblDiff1.Font = New Font(lblDiff1.Font.FontFamily, Me.Height / 40)
            lblDiff2.Font = New Font(lblDiff2.Font.FontFamily, Me.Height / 40)
            lblDiff3.Font = New Font(lblDiff3.Font.FontFamily, Me.Height / 40)
            'Scaling difficulty labels

            lblStoryTell.Font = New Font(lblStoryTell.Font.FontFamily, Me.Height / 35)
            picImageBoxIB.Height += Me.Width / 4
            picImageBoxIB.Width += Me.Width / 4
            picImageBoxIB.Top -= Me.Width / 4
            'Scaling story elements
        End If
    End Sub


    'Code for the name input textbox
    Private Sub txtNameInput_TextChanged(sender As Object, e As EventArgs) Handles txtNameInput.TextChanged
        If txtNameInput.Text <> "Enter your username" Then
            txtNameInput.ForeColor = Color.Black
        End If
        'Once the user clicks in the box, "Enter your username disappears"
    End Sub
    Private Sub txtNameInput_MouseDown(sender As Object, e As MouseEventArgs) Handles txtNameInput.MouseDown
        txtNameInput.Clear()
    End Sub
    'Text field starts off as "Input your username" with gray text.
    'This changes when you click or type in the text field so that everything is blank


    'User clicks submit button
    Private Sub btnSubmitName_Click(sender As Object, e As EventArgs) Handles btnSubmitName.Click
        If txtNameInput.Text = "" Or txtNameInput.ForeColor = Color.LightGray Then
            MessageBox.Show("Please enter a vaild username.", "Error")
            'Catch invalid username 
        Else
            'If username is valid, start story "Cutscene"
            strUserName = txtNameInput.Text
            lblNameDisplay.Show()
            lblNameDisplay.Text = "You are: " & strUserName
            txtNameInput.Enabled = False
            pnlStory.Show()

            'Using system resource instead of imagelist for higher resolution
            picImageBoxIB.Image = My.Resources.icoIBLogo
        End If
    End Sub


    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If blnMaximize = False Then
            'If window is not maximized, maximize the window
            Me.WindowState = FormWindowState.Maximized
            btnMaximize.BackgroundImage = My.Resources.icoRestore
            blnMaximize += 1

            'Scaling for UI
            lblDiff1.Font = New Font(lblDiff1.Font.FontFamily, Me.Height / 40)
            lblDiff2.Font = New Font(lblDiff2.Font.FontFamily, Me.Height / 40)
            lblDiff3.Font = New Font(lblDiff3.Font.FontFamily, Me.Height / 40)
            'Scaling difficulty labels

            lblStoryTell.Font = New Font(lblStoryTell.Font.FontFamily, Me.Height / 35)
            picImageBoxIB.Height += Me.Width / 4
            picImageBoxIB.Width += Me.Width / 4
            picImageBoxIB.Top -= Me.Width / 4
            'Scaling story elements

        Else
            'If the window is maximized, restore the window
            Me.WindowState = FormWindowState.Normal
            btnMaximize.BackgroundImage = My.Resources.icoMaximize
            blnMaximize += 1

            'Scaling for UI
            lblDiff1.Font = New Font(lblDiff1.Font.FontFamily, 12)
            lblDiff2.Font = New Font(lblDiff2.Font.FontFamily, 12)
            lblDiff3.Font = New Font(lblDiff3.Font.FontFamily, 12)
            'Scaling difficulty labels

            lblStoryTell.Font = New Font(lblStoryTell.Font.FontFamily, 14)
            picImageBoxIB.Height = pnlStory.Height / 1.5
            picImageBoxIB.Width = pnlStory.Height / 1.5
            picImageBoxIB.Top = pnlStory.Height - picImageBoxIB.Height - 10
            'Scaling story elements
        End If
    End Sub

    Private Sub txtNameInput_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNameInput.KeyDown
        'Check if enter key is pressed - for convenience of user
        If e.KeyCode = Keys.Enter Then
            btnSubmitName.PerformClick()
            'Clicks button
        End If
    End Sub

    Private Sub btnReturnMenu_Click(sender As Object, e As EventArgs) Handles btnReturnMenu.Click
        'If user clicks "Return to Menu"
        Dim choice = MsgBox("Are you sure you want to return to the menu? All progress will be lost!", MsgBoxStyle.YesNo, "Confirm")
        If choice = MsgBoxResult.Yes Then
            RootMenu.Show()
            Me.Close()
            'Terminate self
        End If
    End Sub

    'Fades in form over time based on fade in speed
    Private Sub FadeTick_Tick(sender As Object, e As EventArgs) Handles tmrFadeTick.Tick
        If Me.Opacity = 1 Then
            'If opacity is 100%, stop fade in
            tmrFadeTick.Stop()
        Else
            Me.Opacity += sglWindowFadeSpd
            'Otherwise, fade in
        End If
    End Sub

    Private Sub btnStoryNxt_Click(sender As Object, e As EventArgs) Handles btnStoryNxt.Click
        'Every time the user clicks the button, advance the story
        Select Case shrStoryText
            Case 0
                '1st step
                lblStoryTell.Text = "With it, came new perils in the realm" & ControlChars.NewLine & "of education, particularly in mathematics."
            Case 1
                '2nd step
                lblStoryTell.Text = "Now, in 2016, you, " & strUserName & ControlChars.NewLine & "are to choose your path of education in IB math."
            Case 2
                '3rd step - go to difficulty select
                lblStoryTell.Text = "Select your math program (Pick a difficulty):"
                picImageBoxIB.Hide()
                btnStoryNxt.Enabled = False
                tlpDifficultySelect.Show()
            Case 3
                '4th step - ready to go
                Game.Show()
                Me.Close()
        End Select
        shrStoryText += 1
    End Sub


    'Choosing Difficulty

    'Difficulty: Math Studies (mode 1, easy)
    'Highlights box if cursor hovers over it
    Private Sub picDiffMS_MouseMove(sender As Object, e As MouseEventArgs) Handles picDiffMS.MouseMove
        picDiffMS.BackColor = Color.FromArgb(68, 138, 255)
        '(Changes colour)
    End Sub

    'Unhighlights box if cursor leaves and the user has not selected the mode
    Private Sub picDiffMS_MouseLeave(sender As Object, e As EventArgs) Handles picDiffMS.MouseLeave
        If shrGamemode <> 1 Then
            picDiffMS.BackColor = Color.FromArgb(129, 199, 132)
            '(Changes colour back if user chooses something different)
        End If
    End Sub

    'The user chooses MS difficulty
    Private Sub picDiffMS_Click(sender As Object, e As EventArgs) Handles picDiffMS.Click
        picDiffMS.BackColor = Color.FromArgb(129, 199, 132)
        picDiffSL.BackColor = Color.FromArgb(255, 192, 128)
        picDiffHL.BackColor = Color.FromArgb(255, 128, 128)
        'Changing colours accordingly in case another was selected

        shrGamemode = 1
        'Sets game mode

        lblDiffDisplay.ForeColor = Color.Black
        lblDiffDisplay.Text = "Difficulty: Math Studies"
        lblDiffDisplay.Left = Me.Width - lblDiffDisplay.Width - 30
        lblDiffDisplay.Show()
        btnStoryNxt.Enabled = True
        'Housekeeping/prompt user

        'Plays a tactile sound
        If My.Settings.blnSoundMode = True Then
            My.Computer.Audio.Play(My.Resources.Kachunk, AudioPlayMode.Background)
        End If
    End Sub

    'Difficulty: SL Math (mode 2, normal)
    'Same logic as above
    Private Sub picDiffSL_Click(sender As Object, e As EventArgs) Handles picDiffSL.Click
        picDiffSL.BackColor = Color.FromArgb(68, 138, 255)
        picDiffMS.BackColor = Color.FromArgb(129, 199, 132)
        picDiffHL.BackColor = Color.FromArgb(255, 128, 128)
        shrGamemode = 2
        'Sets game mode

        lblDiffDisplay.ForeColor = Color.Black
        lblDiffDisplay.Text = "Difficulty: SL Math"
        lblDiffDisplay.Left = Me.Width - lblDiffDisplay.Width - 30
        lblDiffDisplay.Show()
        btnStoryNxt.Enabled = True
        'Housekeeping/prompt user

        'Plays a tactile sound
        If My.Settings.blnSoundMode = True Then
            My.Computer.Audio.Play(My.Resources.Kachunk, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub picDiffSL_MouseEnter(sender As Object, e As EventArgs) Handles picDiffSL.MouseEnter
        picDiffSL.BackColor = Color.FromArgb(68, 138, 255)
    End Sub

    Private Sub picDiffSL_MouseLeave(sender As Object, e As EventArgs) Handles picDiffSL.MouseLeave
        If shrGamemode <> 2 Then
            picDiffSL.BackColor = Color.FromArgb(255, 192, 128)
        End If
    End Sub

    'Difficulty: HL Math (mode 3, hard)
    Private Sub picDiffHL_Click(sender As Object, e As EventArgs) Handles picDiffHL.Click
        picDiffSL.BackColor = Color.FromArgb(255, 192, 128)
        picDiffMS.BackColor = Color.FromArgb(129, 199, 132)
        picDiffHL.BackColor = Color.FromArgb(68, 138, 255)
        shrGamemode = 3
        'Set game mode

        lblDiffDisplay.ForeColor = Color.Black
        lblDiffDisplay.Text = "Difficulty: HL Math"
        lblDiffDisplay.Left = Me.Width - lblDiffDisplay.Width - 30
        lblDiffDisplay.Show()
        btnStoryNxt.Enabled = True
        'Housekeeping/prompt user

        'Plays a tactile sound
        If My.Settings.blnSoundMode = True Then
            My.Computer.Audio.Play(My.Resources.Kachunk, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub picDiffHL_MouseEnter(sender As Object, e As EventArgs) Handles picDiffHL.MouseEnter
        If shrGamemode <> 4 Then
            'Check if mode is Hyper IB
            picDiffHL.BackColor = Color.FromArgb(68, 138, 255)
        End If
    End Sub

    Private Sub picDiffHL_MouseLeave(sender As Object, e As EventArgs) Handles picDiffHL.MouseLeave
        If shrGamemode <> 3 And shrGamemode <> 4 Then
            picDiffHL.BackColor = Color.FromArgb(255, 128, 128)
        End If
    End Sub

    'Bonus - Hyper IB Mode
    Private Sub picDiffHL_DoubleClick(sender As Object, e As EventArgs) Handles picDiffHL.DoubleClick
        picDiffSL.BackColor = Color.FromArgb(255, 192, 128)
        picDiffMS.BackColor = Color.FromArgb(129, 199, 132)
        picDiffHL.BackColor = Color.FromArgb(166, 2, 20)
        shrGamemode = 4
        'Set game mode

        lblDiffDisplay.ForeColor = Color.DarkRed
        lblDiffDisplay.Text = "Difficulty: HYPER IB MODE"
        lblDiffDisplay.Left = Me.Width - lblDiffDisplay.Width - 30
        lblDiffDisplay.Show()
        btnStoryNxt.Enabled = True
        'Housekeeping/prompt user

        'Plays a tactile sound
        If My.Settings.blnSoundMode = True Then
            My.Computer.Audio.Play(My.Resources.Kachunk, AudioPlayMode.Background)
        End If
    End Sub
    'End of choosing difficulty
End Class