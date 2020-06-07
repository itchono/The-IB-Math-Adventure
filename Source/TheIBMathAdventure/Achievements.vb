'Displays achievements
Public Class Achievements
    Dim blnFadeinOut As Boolean
    'Determines whether form should be fading in or out

    Private Sub Credits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrFadeTick.Start()
        Me.Opacity = 0
        'Start fade in

        'Check achievements
        'Pattern:
        'If the achievement state is true,
        'Display visual confirmation

        If My.Settings.ach1 = True Then
            lblAchieveLock1.Text = "TAKEN"
            lblAchieveLock1.ForeColor = Color.Green
            picAchievement1.Image = My.Resources.ach100
        End If
        If My.Settings.ach2 = True Then
            lblAchieveLock2.Text = "TAKEN"
            lblAchieveLock2.ForeColor = Color.Green
            picAchievement2.Image = My.Resources.uniHarvard
        End If
        If My.Settings.ach3 = True Then
            lblAchieveLock3.Text = "TAKEN"
            lblAchieveLock3.ForeColor = Color.Green
            picAchievement3.Image = My.Resources.achFail
        End If
        If My.Settings.ach4 = True Then
            lblAchieveLock4.Text = "TAKEN"
            lblAchieveLock4.ForeColor = Color.Green
            picAchievement4.Image = My.Resources.achBitofAll
        End If

        lblHighScore.Text = "High Score: " & My.Settings.HighScore
        'Displays the high score
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Start fadeout
        tmrFadeTick.Start()
        blnFadeinOut = True
    End Sub

    'Fades in form over time based on fade in speed
    Private Sub FadeTick_Tick(sender As Object, e As EventArgs) Handles tmrFadeTick.Tick
        'Determine fading in or fading out
        If Me.Opacity = 1 And blnFadeinOut = False Then
            'If fading in, and opacity reaches 100%, stop
            tmrFadeTick.Stop()
        ElseIf blnFadeinOut = False And Me.Opacity <> 1 Then
            'If fading in and opacity <> 100%, keep going
            Me.Opacity += sglWindowFadeSpd

        ElseIf blnFadeinOut = True And Me.Opacity <> 0 Then
            'If fading out and opacity <> 0%, keep going
            Me.Opacity -= sglWindowFadeSpd

        ElseIf blnFadeinOut = True And Me.Opacity = 0 Then
            'If fading out, and opacity is 0%, stop
            Me.Close()
            'Close form
        End If
    End Sub
End Class