'Allows user to choose a university
Public Class ChooseUniversity

    Public Event FinishScreen()
    'Event used to move on

    Private Sub ChooseUniversity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrFadeTick.Start()
        Me.Opacity = 0
        'Start fade in

        'PATCH 1.3 - Moved line of code to ReportCard form

        If blnMaximize = True Then
            'If form should be maximized, maximize
            Me.WindowState = FormWindowState.Maximized
            btnMaximize.BackgroundImage = My.Resources.icoRestore

            'Scaling for UI
            lblDispUni1.Font = New Font(lblDispUni1.Font.FontFamily, Me.Width / 60)
            lblDispUni2.Font = New Font(lblDispUni2.Font.FontFamily, Me.Width / 60)
            lblDispUni3.Font = New Font(lblDispUni3.Font.FontFamily, Me.Width / 60)
            lblDispUni4.Font = New Font(lblDispUni4.Font.FontFamily, Me.Width / 60)
            lblDispUni5.Font = New Font(lblDispUni5.Font.FontFamily, Me.Width / 60)
            lblDispUni6.Font = New Font(lblDispUni6.Font.FontFamily, Me.Width / 60)
            lblDispUni7.Font = New Font(lblDispUni7.Font.FontFamily, Me.Width / 60)
            lblDispUni8.Font = New Font(lblDispUni8.Font.FontFamily, Me.Width / 60)
        End If

        'Allow Cheat Codes
        Me.KeyPreview = True

        'Control Locks
        'The user can choose from up to 8 universities depending on their course and final mark.
        'Math Studies is capped at tier 2 (even with 100%)
        'SL Math is capped at tier 4
        'HL Math and Hyper IB go up to tier 5
        Select Case shrUniversityTier
            Case 1
                picUniversity3.Enabled = False
                picUniversity3.BackColor = Color.LightGray
                picUniversity4.Enabled = False
                picUniversity4.BackColor = Color.LightGray
                picUniversity5.Enabled = False
                picUniversity5.BackColor = Color.LightGray
                picUniversity6.Enabled = False
                picUniversity6.BackColor = Color.LightGray
                picUniversity7.Enabled = False
                picUniversity7.BackColor = Color.LightGray
                picUniversity8.Enabled = False
                picUniversity8.BackColor = Color.LightGray
            Case 2
                picUniversity4.Enabled = False
                picUniversity4.BackColor = Color.LightGray
                picUniversity5.Enabled = False
                picUniversity5.BackColor = Color.LightGray
                picUniversity6.Enabled = False
                picUniversity6.BackColor = Color.LightGray
                picUniversity7.Enabled = False
                picUniversity7.BackColor = Color.LightGray
                picUniversity8.Enabled = False
                picUniversity8.BackColor = Color.LightGray
            Case 3
                picUniversity5.Enabled = False
                picUniversity5.BackColor = Color.LightGray
                picUniversity6.Enabled = False
                picUniversity6.BackColor = Color.LightGray
                picUniversity7.Enabled = False
                picUniversity7.BackColor = Color.LightGray
                picUniversity8.Enabled = False
                picUniversity8.BackColor = Color.LightGray
            Case 4
                picUniversity7.Enabled = False
                picUniversity7.BackColor = Color.LightGray
                picUniversity8.Enabled = False
                picUniversity8.BackColor = Color.LightGray
        End Select
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
    'Code for maximizing and restoring window
    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If blnMaximize = False Then
            'If window is not maximized, maximize
            Me.WindowState = FormWindowState.Maximized
            btnMaximize.BackgroundImage = My.Resources.icoRestore
            blnMaximize += 1

            'Scaling for UI
            lblDispUni1.Font = New Font(lblDispUni1.Font.FontFamily, Me.Width / 60)
            lblDispUni2.Font = New Font(lblDispUni2.Font.FontFamily, Me.Width / 60)
            lblDispUni3.Font = New Font(lblDispUni3.Font.FontFamily, Me.Width / 60)
            lblDispUni4.Font = New Font(lblDispUni4.Font.FontFamily, Me.Width / 60)
            lblDispUni5.Font = New Font(lblDispUni5.Font.FontFamily, Me.Width / 60)
            lblDispUni6.Font = New Font(lblDispUni6.Font.FontFamily, Me.Width / 60)
            lblDispUni7.Font = New Font(lblDispUni7.Font.FontFamily, Me.Width / 60)
            lblDispUni8.Font = New Font(lblDispUni8.Font.FontFamily, Me.Width / 60)
        Else
            'If window is maxmized, restore
            Me.WindowState = FormWindowState.Normal
            btnMaximize.BackgroundImage = My.Resources.icoMaximize
            blnMaximize += 1

            'Scaling for UI
            lblDispUni1.Font = New Font(lblDispUni1.Font.FontFamily, 12)
            lblDispUni2.Font = New Font(lblDispUni2.Font.FontFamily, 12)
            lblDispUni3.Font = New Font(lblDispUni3.Font.FontFamily, 12)
            lblDispUni4.Font = New Font(lblDispUni4.Font.FontFamily, 12)
            lblDispUni5.Font = New Font(lblDispUni5.Font.FontFamily, 12)
            lblDispUni6.Font = New Font(lblDispUni6.Font.FontFamily, 12)
            lblDispUni7.Font = New Font(lblDispUni7.Font.FontFamily, 12)
            lblDispUni8.Font = New Font(lblDispUni8.Font.FontFamily, 12)
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

    Private Sub ChooseUniversity_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.F10 AndAlso e.Modifiers = Keys.Control) Then
            MessageBox.Show(shrUniversityTier, "University tier:")
        End If
    End Sub

    'When a user clicks on a university, a message is displayed and congratulates the user.

    Private Sub picUniversity8_Click(sender As Object, e As EventArgs) Handles picUniversity8.Click
        'CHECK FOR ACIEVEMENT 2: Ivy League
        If My.Settings.ach2 = False Then
            My.Settings.ach2 = True

            'Play achievement sound
            If My.Settings.blnSoundMode = True Then
                My.Computer.Audio.Play(My.Resources.AIRHORN, AudioPlayMode.Background)
            End If
            MessageBox.Show("Ivy League - Go to a tier 5 university.", "Achievement Get!")
        End If

        'Set university choice and congratulate; then move on
        MessageBox.Show("Congratulations, " & strUserName & ", on your successful admission to Harvard. You will surely become a great lawyer!", "Good Job!")
        shrUniChoice = 8
        RaiseEvent FinishScreen()
    End Sub

    Private Sub picUniversity7_Click(sender As Object, e As EventArgs) Handles picUniversity7.Click
        'CHECK FOR ACIEVEMENT 2: Ivy League
        If My.Settings.ach2 = False Then
            My.Settings.ach2 = True
            If My.Settings.blnSoundMode = True Then
                My.Computer.Audio.Play(My.Resources.AIRHORN, AudioPlayMode.Background)
            End If
            MessageBox.Show("Ivy League - Go to a tier 5 university.", "Achievement Get!")
        End If
        'Set university choice and congratulate; then move on
        MessageBox.Show("Congratulations, " & strUserName & ", on your successful admission to the Massacheussetts Institute of Technology. You will surely become a great scientist!", "Good Job!")
        shrUniChoice = 7
        RaiseEvent FinishScreen()
    End Sub

    Private Sub picUniversity6_Click(sender As Object, e As EventArgs) Handles picUniversity6.Click
        'Set university choice and congratulate; then move on
        MessageBox.Show("Congratulations, " & strUserName & ", on your successful admission to McGill. You will surely become a great doctor!", "Good Job!")
        shrUniChoice = 6
        RaiseEvent FinishScreen()
    End Sub

    Private Sub picUniversity5_Click(sender As Object, e As EventArgs) Handles picUniversity5.Click
        'Set university choice and then move on
        shrUniChoice = 5
        RaiseEvent FinishScreen()
    End Sub

    Private Sub picUniversity4_Click(sender As Object, e As EventArgs) Handles picUniversity4.Click
        'Set university choice and then move on
        shrUniChoice = 4
        RaiseEvent FinishScreen()
    End Sub

    Private Sub picUniversity3_Click(sender As Object, e As EventArgs) Handles picUniversity3.Click
        'Set university choice and then move on
        shrUniChoice = 3
        RaiseEvent FinishScreen()
    End Sub

    Private Sub picUniversity2_Click(sender As Object, e As EventArgs) Handles picUniversity2.Click
        'Set university choice and then move on
        shrUniChoice = 2
        RaiseEvent FinishScreen()
    End Sub

    Private Sub picUniversity1_Click(sender As Object, e As EventArgs) Handles picUniversity1.Click
        'Set university choice and then move on
        shrUniChoice = 1
        RaiseEvent FinishScreen()
    End Sub

    Private Sub FinishTrigger() Handles Me.FinishScreen
        If My.Settings.blnSoundMode = True Then
            My.Computer.Audio.Play(My.Resources.Tada, AudioPlayMode.Background)
        End If
        'Plays celebratory sound
        If shrUniChoice < 6 Then
            MessageBox.Show("Congratulations on your selection of university!", "Good Job!")
        End If
        FinalStory.Show()
        Me.Close()
        'Proceed to next form
    End Sub
End Class