<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game))
        Me.lblInfoDisplay = New System.Windows.Forms.Label()
        Me.lblDispAuxSeptember = New System.Windows.Forms.Label()
        Me.lblDispAuxJune = New System.Windows.Forms.Label()
        Me.lblTimeline = New System.Windows.Forms.Label()
        Me.lblTimerDisp = New System.Windows.Forms.Label()
        Me.tmrFadeTick = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGameTick = New System.Windows.Forms.Timer(Me.components)
        Me.tlpProblem = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTerm3 = New System.Windows.Forms.Label()
        Me.lblOperate2 = New System.Windows.Forms.Label()
        Me.lblTerm2 = New System.Windows.Forms.Label()
        Me.lblOperate1 = New System.Windows.Forms.Label()
        Me.lblTerm1 = New System.Windows.Forms.Label()
        Me.lblDispEquals = New System.Windows.Forms.Label()
        Me.txtAnsInput = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSubmitAns = New System.Windows.Forms.Button()
        Me.tlpScore = New System.Windows.Forms.TableLayoutPanel()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.lblIncorrect = New System.Windows.Forms.Label()
        Me.lblCorrect = New System.Windows.Forms.Label()
        Me.lblCurrentInfo = New System.Windows.Forms.Label()
        Me.lblTimerNotch = New System.Windows.Forms.Label()
        Me.lblQuestionsRemaining = New System.Windows.Forms.Label()
        Me.btnPauseResume = New System.Windows.Forms.Button()
        Me.lblDispPause = New System.Windows.Forms.Label()
        Me.lblDispTitle = New System.Windows.Forms.Label()
        Me.tlpStatus = New System.Windows.Forms.TableLayoutPanel()
        Me.btnReturnMenu = New System.Windows.Forms.Button()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.tlpProblem.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.tlpScore.SuspendLayout()
        Me.tlpStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInfoDisplay
        '
        Me.lblInfoDisplay.AutoSize = True
        Me.lblInfoDisplay.BackColor = System.Drawing.Color.Transparent
        Me.lblInfoDisplay.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoDisplay.Location = New System.Drawing.Point(4, 1)
        Me.lblInfoDisplay.Name = "lblInfoDisplay"
        Me.lblInfoDisplay.Size = New System.Drawing.Size(146, 23)
        Me.lblInfoDisplay.TabIndex = 0
        Me.lblInfoDisplay.Text = "<Info Display>"
        '
        'lblDispAuxSeptember
        '
        Me.lblDispAuxSeptember.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDispAuxSeptember.AutoSize = True
        Me.lblDispAuxSeptember.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispAuxSeptember.Location = New System.Drawing.Point(12, 481)
        Me.lblDispAuxSeptember.Name = "lblDispAuxSeptember"
        Me.lblDispAuxSeptember.Size = New System.Drawing.Size(0, 22)
        Me.lblDispAuxSeptember.TabIndex = 1
        '
        'lblDispAuxJune
        '
        Me.lblDispAuxJune.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDispAuxJune.AutoSize = True
        Me.lblDispAuxJune.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispAuxJune.Location = New System.Drawing.Point(779, 482)
        Me.lblDispAuxJune.Name = "lblDispAuxJune"
        Me.lblDispAuxJune.Size = New System.Drawing.Size(0, 22)
        Me.lblDispAuxJune.TabIndex = 2
        '
        'lblTimeline
        '
        Me.lblTimeline.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTimeline.BackColor = System.Drawing.Color.Gray
        Me.lblTimeline.Location = New System.Drawing.Point(1, 457)
        Me.lblTimeline.Name = "lblTimeline"
        Me.lblTimeline.Size = New System.Drawing.Size(890, 10)
        Me.lblTimeline.TabIndex = 3
        '
        'lblTimerDisp
        '
        Me.lblTimerDisp.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblTimerDisp.AutoSize = True
        Me.lblTimerDisp.BackColor = System.Drawing.Color.White
        Me.lblTimerDisp.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimerDisp.Location = New System.Drawing.Point(349, 481)
        Me.lblTimerDisp.Name = "lblTimerDisp"
        Me.lblTimerDisp.Size = New System.Drawing.Size(162, 23)
        Me.lblTimerDisp.TabIndex = 4
        Me.lblTimerDisp.Text = "Time Remaining:"
        '
        'tmrFadeTick
        '
        Me.tmrFadeTick.Interval = 1
        '
        'tmrGameTick
        '
        Me.tmrGameTick.Interval = 1000
        '
        'tlpProblem
        '
        Me.tlpProblem.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpProblem.BackColor = System.Drawing.Color.Transparent
        Me.tlpProblem.ColumnCount = 5
        Me.tlpProblem.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlpProblem.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpProblem.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlpProblem.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpProblem.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlpProblem.Controls.Add(Me.lblTerm3, 4, 0)
        Me.tlpProblem.Controls.Add(Me.lblOperate2, 3, 0)
        Me.tlpProblem.Controls.Add(Me.lblTerm2, 2, 0)
        Me.tlpProblem.Controls.Add(Me.lblOperate1, 1, 0)
        Me.tlpProblem.Controls.Add(Me.lblTerm1, 0, 0)
        Me.tlpProblem.Location = New System.Drawing.Point(154, 166)
        Me.tlpProblem.Name = "tlpProblem"
        Me.tlpProblem.RowCount = 1
        Me.tlpProblem.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpProblem.Size = New System.Drawing.Size(608, 49)
        Me.tlpProblem.TabIndex = 11
        '
        'lblTerm3
        '
        Me.lblTerm3.AutoSize = True
        Me.lblTerm3.BackColor = System.Drawing.Color.Transparent
        Me.lblTerm3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTerm3.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTerm3.Location = New System.Drawing.Point(427, 0)
        Me.lblTerm3.Name = "lblTerm3"
        Me.lblTerm3.Size = New System.Drawing.Size(178, 49)
        Me.lblTerm3.TabIndex = 4
        Me.lblTerm3.Text = "<T3>"
        Me.lblTerm3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOperate2
        '
        Me.lblOperate2.AutoSize = True
        Me.lblOperate2.BackColor = System.Drawing.Color.Transparent
        Me.lblOperate2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOperate2.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperate2.Location = New System.Drawing.Point(397, 0)
        Me.lblOperate2.Name = "lblOperate2"
        Me.lblOperate2.Size = New System.Drawing.Size(24, 49)
        Me.lblOperate2.TabIndex = 3
        Me.lblOperate2.Text = "2"
        Me.lblOperate2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTerm2
        '
        Me.lblTerm2.AutoSize = True
        Me.lblTerm2.BackColor = System.Drawing.Color.Transparent
        Me.lblTerm2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTerm2.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTerm2.Location = New System.Drawing.Point(215, 0)
        Me.lblTerm2.Name = "lblTerm2"
        Me.lblTerm2.Size = New System.Drawing.Size(176, 49)
        Me.lblTerm2.TabIndex = 2
        Me.lblTerm2.Text = "<T2>"
        Me.lblTerm2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOperate1
        '
        Me.lblOperate1.AutoSize = True
        Me.lblOperate1.BackColor = System.Drawing.Color.Transparent
        Me.lblOperate1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOperate1.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperate1.Location = New System.Drawing.Point(185, 0)
        Me.lblOperate1.Name = "lblOperate1"
        Me.lblOperate1.Size = New System.Drawing.Size(24, 49)
        Me.lblOperate1.TabIndex = 1
        Me.lblOperate1.Text = "1"
        Me.lblOperate1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTerm1
        '
        Me.lblTerm1.AutoSize = True
        Me.lblTerm1.BackColor = System.Drawing.Color.Transparent
        Me.lblTerm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTerm1.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTerm1.Location = New System.Drawing.Point(3, 0)
        Me.lblTerm1.Name = "lblTerm1"
        Me.lblTerm1.Size = New System.Drawing.Size(176, 49)
        Me.lblTerm1.TabIndex = 0
        Me.lblTerm1.Text = "<T1>"
        Me.lblTerm1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDispEquals
        '
        Me.lblDispEquals.AutoSize = True
        Me.lblDispEquals.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDispEquals.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispEquals.Location = New System.Drawing.Point(3, 0)
        Me.lblDispEquals.Name = "lblDispEquals"
        Me.lblDispEquals.Size = New System.Drawing.Size(68, 41)
        Me.lblDispEquals.TabIndex = 12
        Me.lblDispEquals.Text = "="
        Me.lblDispEquals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAnsInput
        '
        Me.txtAnsInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAnsInput.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnsInput.Location = New System.Drawing.Point(77, 3)
        Me.txtAnsInput.Name = "txtAnsInput"
        Me.txtAnsInput.Size = New System.Drawing.Size(261, 34)
        Me.txtAnsInput.TabIndex = 13
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.63865!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.36134!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblDispEquals, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtAnsInput, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnSubmitAns, 2, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(210, 276)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(497, 41)
        Me.TableLayoutPanel2.TabIndex = 15
        '
        'btnSubmitAns
        '
        Me.btnSubmitAns.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubmitAns.BackColor = System.Drawing.SystemColors.Control
        Me.btnSubmitAns.Location = New System.Drawing.Point(344, 3)
        Me.btnSubmitAns.Name = "btnSubmitAns"
        Me.btnSubmitAns.Size = New System.Drawing.Size(150, 35)
        Me.btnSubmitAns.TabIndex = 14
        Me.btnSubmitAns.Text = "Submit"
        Me.btnSubmitAns.UseVisualStyleBackColor = False
        '
        'tlpScore
        '
        Me.tlpScore.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.tlpScore.BackColor = System.Drawing.Color.White
        Me.tlpScore.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpScore.ColumnCount = 1
        Me.tlpScore.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpScore.Controls.Add(Me.lblGrade, 0, 2)
        Me.tlpScore.Controls.Add(Me.lblIncorrect, 0, 1)
        Me.tlpScore.Controls.Add(Me.lblCorrect, 0, 0)
        Me.tlpScore.Location = New System.Drawing.Point(296, 348)
        Me.tlpScore.Name = "tlpScore"
        Me.tlpScore.RowCount = 3
        Me.tlpScore.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpScore.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpScore.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tlpScore.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpScore.Size = New System.Drawing.Size(309, 100)
        Me.tlpScore.TabIndex = 16
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblGrade.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade.Location = New System.Drawing.Point(4, 67)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(301, 32)
        Me.lblGrade.TabIndex = 2
        Me.lblGrade.Text = "Grade: N/A"
        Me.lblGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIncorrect
        '
        Me.lblIncorrect.AutoSize = True
        Me.lblIncorrect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblIncorrect.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncorrect.Location = New System.Drawing.Point(4, 34)
        Me.lblIncorrect.Name = "lblIncorrect"
        Me.lblIncorrect.Size = New System.Drawing.Size(301, 32)
        Me.lblIncorrect.TabIndex = 1
        Me.lblIncorrect.Text = "Incorrect: 0"
        Me.lblIncorrect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorrect
        '
        Me.lblCorrect.AutoSize = True
        Me.lblCorrect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCorrect.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrect.Location = New System.Drawing.Point(4, 1)
        Me.lblCorrect.Name = "lblCorrect"
        Me.lblCorrect.Size = New System.Drawing.Size(301, 32)
        Me.lblCorrect.TabIndex = 0
        Me.lblCorrect.Text = "Correct: 0"
        Me.lblCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCurrentInfo
        '
        Me.lblCurrentInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCurrentInfo.AutoSize = True
        Me.lblCurrentInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentInfo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentInfo.Location = New System.Drawing.Point(596, 57)
        Me.lblCurrentInfo.MaximumSize = New System.Drawing.Size(290, 0)
        Me.lblCurrentInfo.Name = "lblCurrentInfo"
        Me.lblCurrentInfo.Size = New System.Drawing.Size(129, 23)
        Me.lblCurrentInfo.TabIndex = 17
        Me.lblCurrentInfo.Text = "Current Info:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblCurrentInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTimerNotch
        '
        Me.lblTimerNotch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTimerNotch.BackColor = System.Drawing.Color.DimGray
        Me.lblTimerNotch.Location = New System.Drawing.Point(1, 447)
        Me.lblTimerNotch.Name = "lblTimerNotch"
        Me.lblTimerNotch.Size = New System.Drawing.Size(10, 26)
        Me.lblTimerNotch.TabIndex = 18
        '
        'lblQuestionsRemaining
        '
        Me.lblQuestionsRemaining.AutoSize = True
        Me.lblQuestionsRemaining.BackColor = System.Drawing.Color.Transparent
        Me.lblQuestionsRemaining.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionsRemaining.Location = New System.Drawing.Point(4, 62)
        Me.lblQuestionsRemaining.Name = "lblQuestionsRemaining"
        Me.lblQuestionsRemaining.Size = New System.Drawing.Size(171, 23)
        Me.lblQuestionsRemaining.TabIndex = 19
        Me.lblQuestionsRemaining.Text = "Remaining Tests:"
        '
        'btnPauseResume
        '
        Me.btnPauseResume.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPauseResume.BackColor = System.Drawing.Color.Transparent
        Me.btnPauseResume.BackgroundImage = Global.TheIBMathAdventure.My.Resources.Resources.icoPause
        Me.btnPauseResume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPauseResume.FlatAppearance.BorderSize = 0
        Me.btnPauseResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPauseResume.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPauseResume.Location = New System.Drawing.Point(783, 8)
        Me.btnPauseResume.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPauseResume.Name = "btnPauseResume"
        Me.btnPauseResume.Size = New System.Drawing.Size(34, 28)
        Me.btnPauseResume.TabIndex = 22
        Me.btnPauseResume.UseVisualStyleBackColor = False
        '
        'lblDispPause
        '
        Me.lblDispPause.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDispPause.AutoSize = True
        Me.lblDispPause.BackColor = System.Drawing.Color.Transparent
        Me.lblDispPause.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispPause.ForeColor = System.Drawing.Color.Red
        Me.lblDispPause.Location = New System.Drawing.Point(372, 231)
        Me.lblDispPause.Name = "lblDispPause"
        Me.lblDispPause.Size = New System.Drawing.Size(137, 39)
        Me.lblDispPause.TabIndex = 23
        Me.lblDispPause.Text = "PAUSED"
        '
        'lblDispTitle
        '
        Me.lblDispTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDispTitle.AutoSize = True
        Me.lblDispTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblDispTitle.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispTitle.Location = New System.Drawing.Point(315, 9)
        Me.lblDispTitle.Name = "lblDispTitle"
        Me.lblDispTitle.Size = New System.Drawing.Size(249, 37)
        Me.lblDispTitle.TabIndex = 24
        Me.lblDispTitle.Text = "The School Year"
        '
        'tlpStatus
        '
        Me.tlpStatus.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpStatus.ColumnCount = 1
        Me.tlpStatus.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpStatus.Controls.Add(Me.lblInfoDisplay, 0, 0)
        Me.tlpStatus.Controls.Add(Me.lblQuestionsRemaining, 0, 1)
        Me.tlpStatus.Location = New System.Drawing.Point(17, 48)
        Me.tlpStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tlpStatus.Name = "tlpStatus"
        Me.tlpStatus.RowCount = 2
        Me.tlpStatus.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tlpStatus.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlpStatus.Size = New System.Drawing.Size(227, 90)
        Me.tlpStatus.TabIndex = 25
        '
        'btnReturnMenu
        '
        Me.btnReturnMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnReturnMenu.BackgroundImage = Global.TheIBMathAdventure.My.Resources.Resources.icoReturn
        Me.btnReturnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnReturnMenu.FlatAppearance.BorderSize = 0
        Me.btnReturnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturnMenu.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnMenu.Location = New System.Drawing.Point(13, 9)
        Me.btnReturnMenu.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnReturnMenu.Name = "btnReturnMenu"
        Me.btnReturnMenu.Size = New System.Drawing.Size(51, 27)
        Me.btnReturnMenu.TabIndex = 26
        Me.btnReturnMenu.UseVisualStyleBackColor = False
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.BackColor = System.Drawing.Color.White
        Me.btnMaximize.BackgroundImage = Global.TheIBMathAdventure.My.Resources.Resources.icoMaximize
        Me.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMaximize.FlatAppearance.BorderSize = 0
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaximize.Location = New System.Drawing.Point(824, 9)
        Me.btnMaximize.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(52, 27)
        Me.btnMaximize.TabIndex = 27
        Me.btnMaximize.UseVisualStyleBackColor = False
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.TheIBMathAdventure.My.Resources.Resources.bgTileHexGray
        Me.ClientSize = New System.Drawing.Size(889, 520)
        Me.Controls.Add(Me.btnMaximize)
        Me.Controls.Add(Me.btnReturnMenu)
        Me.Controls.Add(Me.tlpStatus)
        Me.Controls.Add(Me.lblDispTitle)
        Me.Controls.Add(Me.lblDispPause)
        Me.Controls.Add(Me.btnPauseResume)
        Me.Controls.Add(Me.lblTimerNotch)
        Me.Controls.Add(Me.lblCurrentInfo)
        Me.Controls.Add(Me.tlpScore)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.tlpProblem)
        Me.Controls.Add(Me.lblTimerDisp)
        Me.Controls.Add(Me.lblTimeline)
        Me.Controls.Add(Me.lblDispAuxJune)
        Me.Controls.Add(Me.lblDispAuxSeptember)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Game"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The IB Math Adventure"
        Me.tlpProblem.ResumeLayout(False)
        Me.tlpProblem.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.tlpScore.ResumeLayout(False)
        Me.tlpScore.PerformLayout()
        Me.tlpStatus.ResumeLayout(False)
        Me.tlpStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInfoDisplay As System.Windows.Forms.Label
    Friend WithEvents lblDispAuxSeptember As System.Windows.Forms.Label
    Friend WithEvents lblDispAuxJune As System.Windows.Forms.Label
    Friend WithEvents lblTimeline As System.Windows.Forms.Label
    Friend WithEvents lblTimerDisp As System.Windows.Forms.Label
    Friend WithEvents tmrFadeTick As System.Windows.Forms.Timer
    Friend WithEvents tmrGameTick As System.Windows.Forms.Timer
    Friend WithEvents tlpProblem As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTerm3 As System.Windows.Forms.Label
    Friend WithEvents lblOperate2 As System.Windows.Forms.Label
    Friend WithEvents lblTerm2 As System.Windows.Forms.Label
    Friend WithEvents lblOperate1 As System.Windows.Forms.Label
    Friend WithEvents lblTerm1 As System.Windows.Forms.Label
    Friend WithEvents lblDispEquals As System.Windows.Forms.Label
    Friend WithEvents txtAnsInput As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnSubmitAns As System.Windows.Forms.Button
    Friend WithEvents tlpScore As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblIncorrect As System.Windows.Forms.Label
    Friend WithEvents lblCorrect As System.Windows.Forms.Label
    Friend WithEvents lblGrade As System.Windows.Forms.Label
    Friend WithEvents lblCurrentInfo As System.Windows.Forms.Label
    Friend WithEvents lblTimerNotch As System.Windows.Forms.Label
    Friend WithEvents lblQuestionsRemaining As System.Windows.Forms.Label
    Friend WithEvents btnPauseResume As System.Windows.Forms.Button
    Friend WithEvents lblDispPause As System.Windows.Forms.Label
    Friend WithEvents lblDispTitle As System.Windows.Forms.Label
    Friend WithEvents tlpStatus As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnReturnMenu As System.Windows.Forms.Button
    Friend WithEvents btnMaximize As System.Windows.Forms.Button
End Class
