'Used for changing settings
Public Class SettingsMenu
    Dim blnFadeInOut As Boolean
    'Determines whether form should be fading in or out

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        'If the user clicks apply, apply settings
        sglWindowFadeSpd = Val(txtFadeSpd.Text) / 100 * 0.04
        'Fade speed

        If chbSound.Checked = True Then
            My.Settings.blnSoundMode = True
        Else
            My.Settings.blnSoundMode = False
        End If
        'Sound

        'Close the form (Start fadeout sequence)
        tmrFadeTick.Start()
        blnFadeInOut = True
    End Sub

    Private Sub SettingsMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If blnMaximize = False Then
            Me.Left = RootMenu.Left + RootMenu.Width
            Me.Top = RootMenu.Top + RootMenu.Height / 3
            'In the event that the window is sized normally, the settings menu opens up outside the window
        Else
            Me.Left = RootMenu.Left + RootMenu.Width - Me.Width
            'If the window is fullscreen, put the settings menu inside.
        End If

        tmrFadeTick.Start()
        Me.Opacity = 0
        'Start fade in

        'Loads values from memory/settings into display
        txtFadeSpd.Text = sglWindowFadeSpd / 4 * 10000
        If My.Settings.blnSoundMode = True Then
            chbSound.Checked = True
        End If
    End Sub

    'Fades in form over time based on fade in speed
    Private Sub GameTick_Tick(sender As Object, e As EventArgs) Handles tmrFadeTick.Tick
        'Determine fading in or fading out
        If Me.Opacity = 1 And blnFadeInOut = False Then
            'If fading in, and opacity reaches 100%, stop
            tmrFadeTick.Stop()
        ElseIf blnFadeInOut = False And Me.Opacity <> 1 Then
            'If fading in and opacity <> 100%, keep going
            Me.Opacity += sglWindowFadeSpd

            If blnMaximize = False Then
                'Checks whether or not to do the cool displacement animation
                'Depending on whether or not window is maximized
                Me.Left -= Me.Width / 100 * sglWindowFadeSpd / 0.04
                RootMenu.Left -= Me.Width / 100 * sglWindowFadeSpd / 0.04
            End If

        ElseIf blnFadeInOut = True And Me.Opacity <> 0 Then
            'If fading out and opacity <> 0%, keep going
            Me.Opacity -= sglWindowFadeSpd

            If blnMaximize = False Then
                'Checks whether or not to do the cool displacement animation
                'Depending on whether or not window is maximized
                Me.Left += Me.Width / 100 * sglWindowFadeSpd / 0.04
                RootMenu.Left += Me.Width / 100 * sglWindowFadeSpd / 0.04
            End If

        ElseIf blnFadeInOut = True And Me.Opacity = 0 Then
            'If fading out, and opacity is 0%, stop
            Me.Close()
            'Close form
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'CANCEL
        'Close form and DO NOT apply settings
        tmrFadeTick.Start()
        blnFadeInOut = True
    End Sub

    Private Sub btnResetStats_Click(sender As Object, e As EventArgs) Handles btnResetStats.Click
        'If the user chooses to reset, give them a message prompt for confimation.
        Dim choice = MsgBox("Are you sure? All persistent stats and settings will be lost!", MsgBoxStyle.YesNo, "Confirm")
        If choice = MsgBoxResult.Yes Then
            'If they answer yes, reset
            My.Settings.Reset()
            chbSound.Checked = True
        End If
        'If not, do nothing
    End Sub
End Class