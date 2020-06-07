'Shows credits
Public Class Credits
    Dim blnFadeinOut As Boolean
    'Determines whether form should be fading in or out
    Dim shrShowCheat As Short
    'Used for showing cheat codes

    Private Sub Credits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If blnMaximize = False Then
            Me.Left = RootMenu.Left + RootMenu.Width
            Me.Top = RootMenu.Top + RootMenu.Height / 3
            Me.Height = 340
            'In the event that the window is sized normally, the settings menu opens up outside the window
        Else
            Me.Height = RootMenu.Height / 2
            Me.Width = RootMenu.Height / 2
            Me.Left = RootMenu.Left + RootMenu.Width - Me.Width
            lblCredits.Font = New Font(lblCredits.Font.FontFamily, Me.Height / 40)
            lblCredits.Top = Me.Height - lblCredits.Height - 20
            lblDispCredTitle.Font = New Font(lblDispCredTitle.Font.FontFamily, Me.Height / 25)
            'If the window is fullscreen, put the settings menu inside and scale UI accordingly.
        End If

        tmrFadeTick.Start()
        Me.Opacity = 0
        'Start fade in
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Start fadeout
        tmrFadeTick.Start()
        blnFadeinOut = True
    End Sub

    'Fades in form over time based on fade in speed
    Private Sub tmrFadeTick_Tick(sender As Object, e As EventArgs) Handles tmrFadeTick.Tick
        'Determine fading in or fading out
        If Me.Opacity = 1 And blnFadeinOut = False Then
            'If fading in, and opacity reaches 100%, stop
            tmrFadeTick.Stop()
        ElseIf blnFadeinOut = False And Me.Opacity <> 1 Then
            'If fading in and opacity <> 100%, keep going
            Me.Opacity += sglWindowFadeSpd

            If blnMaximize = False Then
                'Checks whether or not to do the cool displacement animation
                'Depending on whether or not window is maximized
                Me.Left -= Me.Width / 100 * sglWindowFadeSpd / 0.04
                RootMenu.Left -= Me.Width / 100 * sglWindowFadeSpd / 0.04
            End If

        ElseIf blnFadeinOut = True And Me.Opacity <> 0 Then
            'If fading out and opacity <> 0%, keep going
            Me.Opacity -= sglWindowFadeSpd

            If blnMaximize = False Then
                'Checks whether or not to do the cool displacement animation
                'Depending on whether or not window is maximized
                Me.Left += Me.Width / 100 * sglWindowFadeSpd / 0.04
                RootMenu.Left += Me.Width / 100 * sglWindowFadeSpd / 0.04
            End If

        ElseIf blnFadeinOut = True And Me.Opacity = 0 Then
            'If fading out, and opacity is 0%, stop
            Me.Close()
            'Close form
        End If
    End Sub

    Private Sub lblCredits_Click(sender As Object, e As EventArgs) Handles lblCredits.Click
        'Hidden cheats for testing/curious users
        If shrShowCheat = 5 Then
            MessageBox.Show("In game mode: " & ControlChars.NewLine &
                            "Ctrl F8: Add 1 to incorrect" &
                            ControlChars.NewLine &
                            "Ctrl F9: Add 1 to correct" & ControlChars.NewLine &
                            "Ctrl F10: Add 30 seconds to time limit" & ControlChars.NewLine &
                            "In university Select:" & ControlChars.NewLine &
                            "Ctrl F10: Show Tier" & ControlChars.NewLine &
                            "Main Menu:" & ControlChars.NewLine &
                            "Ctrl F8: Final Story" & ControlChars.NewLine &
                            "Ctrl F9: HL Math" & ControlChars.NewLine &
                            "Ctrl F10: SL Math", "Cheats")
            blnCheat = True
            My.Settings.ach1 = True
            My.Settings.ach2 = True
            My.Settings.ach3 = True
            My.Settings.ach4 = True
            shrShowCheat = 0
        Else
            shrShowCheat += 1
        End If
    End Sub
End Class