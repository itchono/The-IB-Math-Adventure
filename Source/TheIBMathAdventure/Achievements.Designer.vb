<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Achievements
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Achievements))
        Me.tmrFadeTick = New System.Windows.Forms.Timer(Me.components)
        Me.lblDispTitle = New System.Windows.Forms.Label()
        Me.picAchievement1 = New System.Windows.Forms.PictureBox()
        Me.picAchievement2 = New System.Windows.Forms.PictureBox()
        Me.picAchievement3 = New System.Windows.Forms.PictureBox()
        Me.picAchievement4 = New System.Windows.Forms.PictureBox()
        Me.lblDispAchieve1 = New System.Windows.Forms.Label()
        Me.lblAchieveLock1 = New System.Windows.Forms.Label()
        Me.lblDispAchieve2 = New System.Windows.Forms.Label()
        Me.lblAchieveLock2 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblDispAchieve3 = New System.Windows.Forms.Label()
        Me.lblDispAchieve4 = New System.Windows.Forms.Label()
        Me.lblAchieveLock3 = New System.Windows.Forms.Label()
        Me.lblAchieveLock4 = New System.Windows.Forms.Label()
        Me.lblHighScore = New System.Windows.Forms.Label()
        CType(Me.picAchievement1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAchievement2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAchievement3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAchievement4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrFadeTick
        '
        Me.tmrFadeTick.Interval = 1
        '
        'lblDispTitle
        '
        Me.lblDispTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDispTitle.AutoSize = True
        Me.lblDispTitle.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispTitle.Location = New System.Drawing.Point(315, 12)
        Me.lblDispTitle.Name = "lblDispTitle"
        Me.lblDispTitle.Size = New System.Drawing.Size(225, 37)
        Me.lblDispTitle.TabIndex = 4
        Me.lblDispTitle.Text = "Achievements"
        '
        'picAchievement1
        '
        Me.picAchievement1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picAchievement1.Image = Global.TheIBMathAdventure.My.Resources.Resources.achLock
        Me.picAchievement1.InitialImage = Global.TheIBMathAdventure.My.Resources.Resources.achLock
        Me.picAchievement1.Location = New System.Drawing.Point(12, 73)
        Me.picAchievement1.Name = "picAchievement1"
        Me.picAchievement1.Size = New System.Drawing.Size(190, 190)
        Me.picAchievement1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAchievement1.TabIndex = 5
        Me.picAchievement1.TabStop = False
        '
        'picAchievement2
        '
        Me.picAchievement2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picAchievement2.Image = Global.TheIBMathAdventure.My.Resources.Resources.achLock
        Me.picAchievement2.InitialImage = Global.TheIBMathAdventure.My.Resources.Resources.achLock
        Me.picAchievement2.Location = New System.Drawing.Point(235, 73)
        Me.picAchievement2.Name = "picAchievement2"
        Me.picAchievement2.Size = New System.Drawing.Size(190, 190)
        Me.picAchievement2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAchievement2.TabIndex = 6
        Me.picAchievement2.TabStop = False
        '
        'picAchievement3
        '
        Me.picAchievement3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picAchievement3.Image = Global.TheIBMathAdventure.My.Resources.Resources.achLock
        Me.picAchievement3.InitialImage = Global.TheIBMathAdventure.My.Resources.Resources.achLock
        Me.picAchievement3.Location = New System.Drawing.Point(452, 73)
        Me.picAchievement3.Name = "picAchievement3"
        Me.picAchievement3.Size = New System.Drawing.Size(190, 190)
        Me.picAchievement3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAchievement3.TabIndex = 7
        Me.picAchievement3.TabStop = False
        '
        'picAchievement4
        '
        Me.picAchievement4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picAchievement4.Image = Global.TheIBMathAdventure.My.Resources.Resources.achLock
        Me.picAchievement4.InitialImage = Global.TheIBMathAdventure.My.Resources.Resources.achLock
        Me.picAchievement4.Location = New System.Drawing.Point(664, 73)
        Me.picAchievement4.Name = "picAchievement4"
        Me.picAchievement4.Size = New System.Drawing.Size(190, 190)
        Me.picAchievement4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAchievement4.TabIndex = 8
        Me.picAchievement4.TabStop = False
        '
        'lblDispAchieve1
        '
        Me.lblDispAchieve1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblDispAchieve1.AutoSize = True
        Me.lblDispAchieve1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispAchieve1.Location = New System.Drawing.Point(23, 283)
        Me.lblDispAchieve1.Name = "lblDispAchieve1"
        Me.lblDispAchieve1.Size = New System.Drawing.Size(165, 115)
        Me.lblDispAchieve1.TabIndex = 9
        Me.lblDispAchieve1.Text = "Ace" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Finish any math " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "program with " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a perfect score"
        Me.lblDispAchieve1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAchieveLock1
        '
        Me.lblAchieveLock1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblAchieveLock1.AutoSize = True
        Me.lblAchieveLock1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAchieveLock1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAchieveLock1.Location = New System.Drawing.Point(51, 410)
        Me.lblAchieveLock1.Name = "lblAchieveLock1"
        Me.lblAchieveLock1.Size = New System.Drawing.Size(106, 28)
        Me.lblAchieveLock1.TabIndex = 10
        Me.lblAchieveLock1.Text = "LOCKED"
        Me.lblAchieveLock1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDispAchieve2
        '
        Me.lblDispAchieve2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblDispAchieve2.AutoSize = True
        Me.lblDispAchieve2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispAchieve2.Location = New System.Drawing.Point(253, 283)
        Me.lblDispAchieve2.Name = "lblDispAchieve2"
        Me.lblDispAchieve2.Size = New System.Drawing.Size(145, 92)
        Me.lblDispAchieve2.TabIndex = 11
        Me.lblDispAchieve2.Text = "Ivy League" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Go to a Tier 5 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "university"
        Me.lblDispAchieve2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAchieveLock2
        '
        Me.lblAchieveLock2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblAchieveLock2.AutoSize = True
        Me.lblAchieveLock2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAchieveLock2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAchieveLock2.Location = New System.Drawing.Point(275, 410)
        Me.lblAchieveLock2.Name = "lblAchieveLock2"
        Me.lblAchieveLock2.Size = New System.Drawing.Size(106, 28)
        Me.lblAchieveLock2.TabIndex = 12
        Me.lblAchieveLock2.Text = "LOCKED"
        Me.lblAchieveLock2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImage = Global.TheIBMathAdventure.My.Resources.Resources.icoReturn
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(825, 12)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(51, 27)
        Me.btnClose.TabIndex = 15
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblDispAchieve3
        '
        Me.lblDispAchieve3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblDispAchieve3.AutoSize = True
        Me.lblDispAchieve3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispAchieve3.Location = New System.Drawing.Point(466, 283)
        Me.lblDispAchieve3.Name = "lblDispAchieve3"
        Me.lblDispAchieve3.Size = New System.Drawing.Size(160, 115)
        Me.lblDispAchieve3.TabIndex = 16
        Me.lblDispAchieve3.Text = "Ultimate Failure" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Finish any math" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "program " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "with a zero"
        Me.lblDispAchieve3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDispAchieve4
        '
        Me.lblDispAchieve4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblDispAchieve4.AutoSize = True
        Me.lblDispAchieve4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispAchieve4.Location = New System.Drawing.Point(664, 283)
        Me.lblDispAchieve4.Name = "lblDispAchieve4"
        Me.lblDispAchieve4.Size = New System.Drawing.Size(184, 92)
        Me.lblDispAchieve4.TabIndex = 17
        Me.lblDispAchieve4.Text = "A Bit of Everything" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Try every single" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "math program"
        Me.lblDispAchieve4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAchieveLock3
        '
        Me.lblAchieveLock3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblAchieveLock3.AutoSize = True
        Me.lblAchieveLock3.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAchieveLock3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAchieveLock3.Location = New System.Drawing.Point(492, 410)
        Me.lblAchieveLock3.Name = "lblAchieveLock3"
        Me.lblAchieveLock3.Size = New System.Drawing.Size(106, 28)
        Me.lblAchieveLock3.TabIndex = 18
        Me.lblAchieveLock3.Text = "LOCKED"
        Me.lblAchieveLock3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAchieveLock4
        '
        Me.lblAchieveLock4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblAchieveLock4.AutoSize = True
        Me.lblAchieveLock4.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAchieveLock4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAchieveLock4.Location = New System.Drawing.Point(705, 410)
        Me.lblAchieveLock4.Name = "lblAchieveLock4"
        Me.lblAchieveLock4.Size = New System.Drawing.Size(106, 28)
        Me.lblAchieveLock4.TabIndex = 19
        Me.lblAchieveLock4.Text = "LOCKED"
        Me.lblAchieveLock4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHighScore
        '
        Me.lblHighScore.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblHighScore.AutoSize = True
        Me.lblHighScore.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighScore.Location = New System.Drawing.Point(23, 471)
        Me.lblHighScore.Name = "lblHighScore"
        Me.lblHighScore.Size = New System.Drawing.Size(118, 23)
        Me.lblHighScore.TabIndex = 20
        Me.lblHighScore.Text = "High Score:"
        '
        'Achievements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(889, 520)
        Me.Controls.Add(Me.lblHighScore)
        Me.Controls.Add(Me.lblAchieveLock4)
        Me.Controls.Add(Me.lblAchieveLock3)
        Me.Controls.Add(Me.lblDispAchieve4)
        Me.Controls.Add(Me.lblDispAchieve3)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblAchieveLock2)
        Me.Controls.Add(Me.lblDispAchieve2)
        Me.Controls.Add(Me.lblAchieveLock1)
        Me.Controls.Add(Me.lblDispAchieve1)
        Me.Controls.Add(Me.picAchievement4)
        Me.Controls.Add(Me.picAchievement3)
        Me.Controls.Add(Me.picAchievement2)
        Me.Controls.Add(Me.picAchievement1)
        Me.Controls.Add(Me.lblDispTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Achievements"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Achievements"
        CType(Me.picAchievement1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAchievement2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAchievement3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAchievement4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrFadeTick As System.Windows.Forms.Timer
    Friend WithEvents lblDispTitle As System.Windows.Forms.Label
    Friend WithEvents picAchievement1 As System.Windows.Forms.PictureBox
    Friend WithEvents picAchievement2 As System.Windows.Forms.PictureBox
    Friend WithEvents picAchievement3 As System.Windows.Forms.PictureBox
    Friend WithEvents picAchievement4 As System.Windows.Forms.PictureBox
    Friend WithEvents lblDispAchieve1 As System.Windows.Forms.Label
    Friend WithEvents lblAchieveLock1 As System.Windows.Forms.Label
    Friend WithEvents lblDispAchieve2 As System.Windows.Forms.Label
    Friend WithEvents lblAchieveLock2 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblDispAchieve3 As System.Windows.Forms.Label
    Friend WithEvents lblDispAchieve4 As System.Windows.Forms.Label
    Friend WithEvents lblAchieveLock3 As System.Windows.Forms.Label
    Friend WithEvents lblAchieveLock4 As System.Windows.Forms.Label
    Friend WithEvents lblHighScore As System.Windows.Forms.Label
End Class
