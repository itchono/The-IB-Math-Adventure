<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RootMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RootMenu))
        Me.lblMainTitle = New System.Windows.Forms.Label()
        Me.picMainLogo = New System.Windows.Forms.PictureBox()
        Me.btnStartGame = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnCredits = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.tmrFadeTick = New System.Windows.Forms.Timer(Me.components)
        Me.lblSplashText = New System.Windows.Forms.Label()
        Me.tlpButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAchievements = New System.Windows.Forms.Button()
        Me.btnMaximize = New System.Windows.Forms.Button()
        CType(Me.picMainLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMainTitle
        '
        Me.lblMainTitle.AutoSize = True
        Me.lblMainTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblMainTitle.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainTitle.Location = New System.Drawing.Point(27, 22)
        Me.lblMainTitle.Name = "lblMainTitle"
        Me.lblMainTitle.Size = New System.Drawing.Size(232, 297)
        Me.lblMainTitle.TabIndex = 0
        Me.lblMainTitle.Text = "The" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Math Adventure" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'picMainLogo
        '
        Me.picMainLogo.BackColor = System.Drawing.Color.Transparent
        Me.picMainLogo.Image = Global.TheIBMathAdventure.My.Resources.Resources.icoIBLogo
        Me.picMainLogo.InitialImage = CType(resources.GetObject("picMainLogo.InitialImage"), System.Drawing.Image)
        Me.picMainLogo.Location = New System.Drawing.Point(30, 65)
        Me.picMainLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picMainLogo.Name = "picMainLogo"
        Me.picMainLogo.Size = New System.Drawing.Size(208, 208)
        Me.picMainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMainLogo.TabIndex = 1
        Me.picMainLogo.TabStop = False
        '
        'btnStartGame
        '
        Me.btnStartGame.AutoSize = True
        Me.btnStartGame.BackColor = System.Drawing.SystemColors.Control
        Me.btnStartGame.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnStartGame.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartGame.Location = New System.Drawing.Point(3, 2)
        Me.btnStartGame.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnStartGame.Name = "btnStartGame"
        Me.btnStartGame.Size = New System.Drawing.Size(152, 40)
        Me.btnStartGame.TabIndex = 2
        Me.btnStartGame.Text = "Start Game"
        Me.btnStartGame.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.SystemColors.Control
        Me.btnSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSettings.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.Location = New System.Drawing.Point(3, 90)
        Me.btnSettings.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(152, 40)
        Me.btnSettings.TabIndex = 3
        Me.btnSettings.Text = "Settings "
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'btnCredits
        '
        Me.btnCredits.BackColor = System.Drawing.SystemColors.Control
        Me.btnCredits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCredits.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredits.Location = New System.Drawing.Point(3, 134)
        Me.btnCredits.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCredits.Name = "btnCredits"
        Me.btnCredits.Size = New System.Drawing.Size(152, 40)
        Me.btnCredits.TabIndex = 4
        Me.btnCredits.Text = "Credits"
        Me.btnCredits.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.SystemColors.Control
        Me.btnQuit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnQuit.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(3, 178)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(152, 41)
        Me.btnQuit.TabIndex = 5
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'tmrFadeTick
        '
        Me.tmrFadeTick.Interval = 1
        '
        'lblSplashText
        '
        Me.lblSplashText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSplashText.AutoSize = True
        Me.lblSplashText.BackColor = System.Drawing.Color.Transparent
        Me.lblSplashText.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSplashText.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblSplashText.Location = New System.Drawing.Point(25, 455)
        Me.lblSplashText.MaximumSize = New System.Drawing.Size(500, 0)
        Me.lblSplashText.Name = "lblSplashText"
        Me.lblSplashText.Size = New System.Drawing.Size(162, 30)
        Me.lblSplashText.TabIndex = 7
        Me.lblSplashText.Text = "<Splashtext>"
        '
        'tlpButtons
        '
        Me.tlpButtons.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpButtons.BackColor = System.Drawing.Color.Transparent
        Me.tlpButtons.ColumnCount = 1
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpButtons.Controls.Add(Me.btnAchievements, 0, 1)
        Me.tlpButtons.Controls.Add(Me.btnSettings, 0, 2)
        Me.tlpButtons.Controls.Add(Me.btnCredits, 0, 3)
        Me.tlpButtons.Controls.Add(Me.btnQuit, 0, 4)
        Me.tlpButtons.Controls.Add(Me.btnStartGame, 0, 0)
        Me.tlpButtons.Location = New System.Drawing.Point(719, 275)
        Me.tlpButtons.Margin = New System.Windows.Forms.Padding(3, 3, 20, 20)
        Me.tlpButtons.Name = "tlpButtons"
        Me.tlpButtons.RowCount = 5
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpButtons.Size = New System.Drawing.Size(158, 221)
        Me.tlpButtons.TabIndex = 8
        '
        'btnAchievements
        '
        Me.btnAchievements.BackColor = System.Drawing.SystemColors.Control
        Me.btnAchievements.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAchievements.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAchievements.Location = New System.Drawing.Point(3, 46)
        Me.btnAchievements.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAchievements.Name = "btnAchievements"
        Me.btnAchievements.Size = New System.Drawing.Size(152, 40)
        Me.btnAchievements.TabIndex = 9
        Me.btnAchievements.Text = "Achievements"
        Me.btnAchievements.UseVisualStyleBackColor = False
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
        Me.btnMaximize.Location = New System.Drawing.Point(825, 11)
        Me.btnMaximize.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(52, 27)
        Me.btnMaximize.TabIndex = 9
        Me.btnMaximize.UseVisualStyleBackColor = False
        '
        'RootMenu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(889, 520)
        Me.Controls.Add(Me.btnMaximize)
        Me.Controls.Add(Me.tlpButtons)
        Me.Controls.Add(Me.lblSplashText)
        Me.Controls.Add(Me.picMainLogo)
        Me.Controls.Add(Me.lblMainTitle)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "RootMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The IB Math Adventure"
        CType(Me.picMainLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpButtons.ResumeLayout(False)
        Me.tlpButtons.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMainTitle As System.Windows.Forms.Label
    Friend WithEvents picMainLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnStartGame As System.Windows.Forms.Button
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents btnCredits As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents tmrFadeTick As System.Windows.Forms.Timer
    Friend WithEvents lblSplashText As System.Windows.Forms.Label
    Friend WithEvents tlpButtons As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnAchievements As System.Windows.Forms.Button
    Friend WithEvents btnMaximize As System.Windows.Forms.Button

End Class
