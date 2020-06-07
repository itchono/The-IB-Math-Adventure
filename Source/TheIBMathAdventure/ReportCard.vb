'Shows final stats
Public Class ReportCard
    Dim shrSequence As Short
    'Variable used for dramatically showing everything in

    Private Sub ReportCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shrUniChoice = 0
        'Reset university choice if previously made

        'Checks if window should be maximized
        If blnMaximize = True Then
            'If so, maximizes window
            Me.WindowState = FormWindowState.Maximized
            btnMaximize.BackgroundImage = My.Resources.icoRestore

            'Scaling for UI
            lblDispTitle.Font = New Font(lblDispTitle.Font.FontFamily, Me.Width / 35, style:=FontStyle.Bold)
            lblDispInfo.Font = New Font(lblDispInfo.Font.FontFamily, Me.Width / 40)
            lblDispGrade.Font = New Font(lblDispGrade.Font.FontFamily, Me.Width / 55)
            lblGrade.Font = New Font(lblGrade.Font.FontFamily, Me.Width / 55)
            lblDispUni.Font = New Font(lblDispUni.Font.FontFamily, Me.Width / 55)
            lblUniversity.Font = New Font(lblUniversity.Font.FontFamily, Me.Width / 60)
        End If

        tlpReportCard.Hide()
        lblDispTitle.Hide()
        lblDispInfo.Hide()
        lblDispGrade.Hide()
        lblGrade.Hide()
        lblUniversity.Hide()
        lblDispUni.Hide()
        btnProceed.Hide()
        'Hide report card for dramatic sequence in

        Select Case sglGrade
            Case Is < 50
                Me.BackgroundImage = My.Resources.bgTileHexRed
            Case 50 To 75
                Me.BackgroundImage = My.Resources.bgTileHexOrange
            Case Is > 75
                Me.BackgroundImage = My.Resources.bgTileHexGreen
        End Select

        tmrFadeTick.Start()
        Me.Opacity = 0
        'For fading in
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

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If blnMaximize = False Then
            'If window is not maximized, maximize the window
            Me.WindowState = FormWindowState.Maximized
            btnMaximize.BackgroundImage = My.Resources.icoRestore
            blnMaximize += 1

            'Scaling for UI
            lblDispTitle.Font = New Font(lblDispTitle.Font.FontFamily, Me.Width / 35, style:=FontStyle.Bold)
            lblDispInfo.Font = New Font(lblDispInfo.Font.FontFamily, Me.Width / 40)
            lblDispGrade.Font = New Font(lblDispGrade.Font.FontFamily, Me.Width / 55)
            lblGrade.Font = New Font(lblGrade.Font.FontFamily, Me.Width / 55)
            lblDispUni.Font = New Font(lblDispUni.Font.FontFamily, Me.Width / 55)
            lblUniversity.Font = New Font(lblUniversity.Font.FontFamily, Me.Width / 60)

        Else
            'If the window is maximized, restore the window
            Me.WindowState = FormWindowState.Normal
            btnMaximize.BackgroundImage = My.Resources.icoMaximize
            blnMaximize += 1

            'Scaling for UI
            lblDispTitle.Font = New Font(lblDispTitle.Font.FontFamily, 24, FontStyle.Bold)
            lblDispInfo.Font = New Font(lblDispInfo.Font.FontFamily, 16)
            lblDispGrade.Font = New Font(lblDispGrade.Font.FontFamily, 12)
            lblGrade.Font = New Font(lblGrade.Font.FontFamily, 12)
            lblDispUni.Font = New Font(lblDispUni.Font.FontFamily, 12)
            lblUniversity.Font = New Font(lblUniversity.Font.FontFamily, 12)
        End If
    End Sub

    'Fades in form over time based on fade in speed
    Private Sub tmrFadeTick_Tick(sender As Object, e As EventArgs) Handles tmrFadeTick.Tick
        If Me.Opacity = 1 Then
            'If opacity is 100%, stop fade in
            tmrFadeTick.Stop()
            tmrSequenceTick.Start()
        Else
            Me.Opacity += sglWindowFadeSpd
            'Otherwise, fade in
        End If
    End Sub

    Public Function Kachunk()
        'Play tactile sound (making code more efficient)
        If My.Settings.blnSoundMode = True Then
            My.Computer.Audio.Play(My.Resources.Kachunk, AudioPlayMode.Background)
        End If
    End Function


    Private Sub tmrSequenceTick_Tick(sender As Object, e As EventArgs) Handles tmrSequenceTick.Tick
        'Every time the sequence in timer ticks
        Select Case shrSequence
            Case 2
                'Show report card frame
                tlpReportCard.Show()
                Kachunk()
            Case 5
                'Show title
                lblDispTitle.Show()
                Kachunk()
            Case 10
                'Show name and program name
                Select Case shrGamemode
                    Case 1
                        lblDispInfo.Text = strUserName & ControlChars.NewLine & "IB Math Studies"
                        blnTrackAch4(0) = True
                        'Tracking for achievement 4 - MS completed
                    Case 2
                        lblDispInfo.Text = strUserName & ControlChars.NewLine & "IB SL Math"
                        blnTrackAch4(1) = True
                        'Tracking for achievement 4 - SL completed
                    Case 3
                        lblDispInfo.Text = strUserName & ControlChars.NewLine & "IB HL Math"
                        blnTrackAch4(2) = True
                        'Tracking for achievement 4 - HL completed
                    Case 4
                        lblDispInfo.Text = strUserName & ControlChars.NewLine & "Hyper IB Mode"
                        blnTrackAch4(3) = True
                        'Tracking for achievement 4 - H-IB completed
                End Select
                lblDispInfo.Show()
                Kachunk()

            Case 15
                'Show "Grade"
                lblDispGrade.Show()
                Kachunk()
            Case 20
                'Show Grade
                lblGrade.Text = sglGrade
                lblGrade.Show()
                Kachunk()
            Case 25
                'Show "Post secondary institution"
                lblDispUni.Show()
                Kachunk()

            Case 30
                'Determines which universities the user can go to
                'MARKING SCHEME
                '       Less than 50    50 to 59    60 to 74    75 to 84    85 to 94    95 or Above
                'MS     FAIL            FAIL        Tier 1      Tier 2      Tier 2      Tier 2
                'SL     FAIL            Tier 1      Tier 2      Tier 3      Tier 4      Tier 4
                'HL     FAIL            Tier 1      Tier 2      Tier 3      Tier 4      Tier 5    **Also applies to Hyper IB Mode
                Select Case Int(sglGrade)
                    Case Is < 50
                        lblUniversity.Text = "Due to failing your course, you must go to Algonquin College."
                        shrUniversityTier = 0
                    Case 50 To 59
                        Select Case shrGamemode
                            Case 1
                                lblUniversity.Text = "Due to your dissatisfactory marks even in Math Studies, you must go to Algonquin College."
                                shrUniversityTier = 0
                            Case Is > 1
                                lblUniversity.Text = "Due to your dissatisfactory marks, you are only able to go to tier 1 universities:"
                                shrUniversityTier = 1
                        End Select
                    Case 60 To 74
                        Select Case shrGamemode
                            Case 1
                                lblUniversity.Text = "Due to your mediocre marks in math studies, you can go to tier 1 universities."
                                shrUniversityTier = 1
                            Case Is > 1
                                lblUniversity.Text = "Due to your mediocre marks, you are only able to go to tier 2 universities."
                                shrUniversityTier = 2
                        End Select

                    Case 75 To 84
                        Select Case shrGamemode
                            Case 1
                                lblUniversity.Text = "Due to your good marks, but considering the fact that you took Math Studies, you can go to tier 2 universities."
                                shrUniversityTier = 2
                            Case Is > 1
                                lblUniversity.Text = "Due to your good marks, you are able to go to tier 3 universities."
                                shrUniversityTier = 3
                        End Select

                    Case 85 To 94
                        Select Case shrGamemode
                            Case 1
                                lblUniversity.Text = "Due to your excellent marks, but considering the fact that you took Math Studies, you can go to tier 2 universities."
                                shrUniversityTier = 2
                            Case 2
                                lblUniversity.Text = "Due to your excellent marks, but considering the fact that you took SL Math, you can go to tier 3 universities."
                                shrUniversityTier = 3
                            Case Is > 2
                                lblUniversity.Text = "Due to your excellent marks, you are able to go to tier 4 universities."
                                shrUniversityTier = 4
                        End Select

                    Case Is >= 95
                        Select Case shrGamemode
                            Case 1
                                lblUniversity.Text = "Due to your outstanding marks, but considering the fact that you took Math Studies, you can go to tier 2 universities."
                                shrUniversityTier = 2
                            Case 2
                                lblUniversity.Text = "Due to your outstanding marks, but considering the fact that you took SL Math, you can go to tier 4 universities."
                                shrUniversityTier = 4
                            Case Is > 2
                                lblUniversity.Text = "Congratulations, your outstanding marks in IB Math have truly distinguished your academic ability and you are able to go to tier 5 universities."
                                shrUniversityTier = 5
                                'Code should be mostly self-explanatory
                        End Select
                End Select

                lblUniversity.Show()
                Kachunk()
            Case 35
                If shrUniversityTier <> 0 Then
                    btnProceed.Text = "Choose University"
                Else
                    btnProceed.Text = "Next"
                End If
                btnProceed.Show()
                Kachunk()

                tmrSequenceTick.Stop()

                'CHECK FOR ACHIEVEMENT 1 - ACE
                If sglGrade = 100 And My.Settings.ach1 = False Then
                    'If user got 100%,
                    My.Settings.ach1 = True
                    If My.Settings.blnSoundMode = True Then
                        My.Computer.Audio.Play(My.Resources.AIRHORN, AudioPlayMode.Background)
                    End If
                    'Play sound and congratulate user
                    MessageBox.Show("Ace - Finish any math program with a perfect score.", "Achievement Get!")
                End If

                'CHECK FOR ACHIEVEMENT 3 - Ultimate Failure
                If sglGrade = 0 And My.Settings.ach3 = False Then
                    'If user got 0%
                    My.Settings.ach3 = True
                    If My.Settings.blnSoundMode = True Then
                        My.Computer.Audio.Play(My.Resources.AIRHORN, AudioPlayMode.Background)
                    End If
                    'Play sound and congratulate user
                    MessageBox.Show("Ultimate failure - Finish any math program with a zero.", "Achievement Get!")
                End If

                'CHECK FOR ACHIEVEMENT 4 - A Bit of Everything
                If blnTrackAch4(0) = True And blnTrackAch4(1) = True And
                    blnTrackAch4(2) = True And blnTrackAch4(3) = True And
                    My.Settings.ach4 = False Then
                    My.Settings.ach4 = True
                    If My.Settings.blnSoundMode = True Then
                        My.Computer.Audio.Play(My.Resources.AIRHORN, AudioPlayMode.Background)
                    End If
                    'Play sound and congratulate user
                    MessageBox.Show("A Bit of Everything - Try every single math program.", "Achievement Get!")
                End If
        End Select

        shrSequence += 1
        'Advance sequence by 1
    End Sub

    Private Sub btnShowUni_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        If shrUniversityTier <> 0 Then
            ChooseUniversity.Show()
            'If user is eligible for a university
        Else
            FinalStory.Show()
            'If user has to go to Algonquin College
        End If
        Me.Close()
        'Terminate self
    End Sub
End Class