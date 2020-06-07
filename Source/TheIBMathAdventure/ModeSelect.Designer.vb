<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModeSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModeSelect))
        Me.lblContextTitle = New System.Windows.Forms.Label()
        Me.txtNameInput = New System.Windows.Forms.TextBox()
        Me.btnSubmitName = New System.Windows.Forms.Button()
        Me.lblNameDisplay = New System.Windows.Forms.Label()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.pnlStory = New System.Windows.Forms.Panel()
        Me.tlpDifficultySelect = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDiff3 = New System.Windows.Forms.Label()
        Me.picDiffMS = New System.Windows.Forms.PictureBox()
        Me.picDiffHL = New System.Windows.Forms.PictureBox()
        Me.lblDiff2 = New System.Windows.Forms.Label()
        Me.picDiffSL = New System.Windows.Forms.PictureBox()
        Me.lblDiff1 = New System.Windows.Forms.Label()
        Me.btnStoryNxt = New System.Windows.Forms.Button()
        Me.picImageBoxIB = New System.Windows.Forms.PictureBox()
        Me.lblStoryTell = New System.Windows.Forms.Label()
        Me.btnReturnMenu = New System.Windows.Forms.Button()
        Me.tmrFadeTick = New System.Windows.Forms.Timer(Me.components)
        Me.lblDiffDisplay = New System.Windows.Forms.Label()
        Me.pnlStory.SuspendLayout()
        Me.tlpDifficultySelect.SuspendLayout()
        CType(Me.picDiffMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDiffHL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDiffSL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImageBoxIB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblContextTitle
        '
        Me.lblContextTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblContextTitle.AutoSize = True
        Me.lblContextTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblContextTitle.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContextTitle.Location = New System.Drawing.Point(304, 9)
        Me.lblContextTitle.Name = "lblContextTitle"
        Me.lblContextTitle.Size = New System.Drawing.Size(221, 37)
        Me.lblContextTitle.TabIndex = 0
        Me.lblContextTitle.Text = "Who Are You?"
        Me.lblContextTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNameInput
        '
        Me.txtNameInput.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNameInput.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameInput.ForeColor = System.Drawing.Color.LightGray
        Me.txtNameInput.Location = New System.Drawing.Point(290, 64)
        Me.txtNameInput.Name = "txtNameInput"
        Me.txtNameInput.Size = New System.Drawing.Size(248, 34)
        Me.txtNameInput.TabIndex = 1
        Me.txtNameInput.Text = "Enter your username"
        '
        'btnSubmitName
        '
        Me.btnSubmitName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSubmitName.BackColor = System.Drawing.SystemColors.Control
        Me.btnSubmitName.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitName.Location = New System.Drawing.Point(372, 117)
        Me.btnSubmitName.Name = "btnSubmitName"
        Me.btnSubmitName.Size = New System.Drawing.Size(92, 30)
        Me.btnSubmitName.TabIndex = 2
        Me.btnSubmitName.Text = "Submit"
        Me.btnSubmitName.UseVisualStyleBackColor = False
        '
        'lblNameDisplay
        '
        Me.lblNameDisplay.AutoSize = True
        Me.lblNameDisplay.BackColor = System.Drawing.Color.Transparent
        Me.lblNameDisplay.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameDisplay.Location = New System.Drawing.Point(27, 161)
        Me.lblNameDisplay.Name = "lblNameDisplay"
        Me.lblNameDisplay.Size = New System.Drawing.Size(123, 33)
        Me.lblNameDisplay.TabIndex = 3
        Me.lblNameDisplay.Text = "You are:"
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
        Me.btnMaximize.TabIndex = 7
        Me.btnMaximize.UseVisualStyleBackColor = False
        '
        'pnlStory
        '
        Me.pnlStory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlStory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStory.Controls.Add(Me.tlpDifficultySelect)
        Me.pnlStory.Controls.Add(Me.btnStoryNxt)
        Me.pnlStory.Controls.Add(Me.picImageBoxIB)
        Me.pnlStory.Controls.Add(Me.lblStoryTell)
        Me.pnlStory.Location = New System.Drawing.Point(33, 202)
        Me.pnlStory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlStory.Name = "pnlStory"
        Me.pnlStory.Size = New System.Drawing.Size(820, 307)
        Me.pnlStory.TabIndex = 8
        '
        'tlpDifficultySelect
        '
        Me.tlpDifficultySelect.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpDifficultySelect.ColumnCount = 3
        Me.tlpDifficultySelect.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpDifficultySelect.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tlpDifficultySelect.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tlpDifficultySelect.Controls.Add(Me.lblDiff3, 2, 1)
        Me.tlpDifficultySelect.Controls.Add(Me.picDiffMS, 0, 0)
        Me.tlpDifficultySelect.Controls.Add(Me.picDiffHL, 2, 0)
        Me.tlpDifficultySelect.Controls.Add(Me.lblDiff2, 1, 1)
        Me.tlpDifficultySelect.Controls.Add(Me.picDiffSL, 1, 0)
        Me.tlpDifficultySelect.Controls.Add(Me.lblDiff1, 0, 1)
        Me.tlpDifficultySelect.Location = New System.Drawing.Point(19, 77)
        Me.tlpDifficultySelect.Margin = New System.Windows.Forms.Padding(3, 20, 3, 3)
        Me.tlpDifficultySelect.Name = "tlpDifficultySelect"
        Me.tlpDifficultySelect.RowCount = 2
        Me.tlpDifficultySelect.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.22222!))
        Me.tlpDifficultySelect.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.77778!))
        Me.tlpDifficultySelect.Size = New System.Drawing.Size(782, 225)
        Me.tlpDifficultySelect.TabIndex = 10
        '
        'lblDiff3
        '
        Me.lblDiff3.AutoSize = True
        Me.lblDiff3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDiff3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiff3.Location = New System.Drawing.Point(523, 139)
        Me.lblDiff3.Name = "lblDiff3"
        Me.lblDiff3.Size = New System.Drawing.Size(256, 86)
        Me.lblDiff3.TabIndex = 5
        Me.lblDiff3.Text = "MHF4U1/MCV4U1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "IB HL Math" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2 year program"
        Me.lblDiff3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picDiffMS
        '
        Me.picDiffMS.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.picDiffMS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picDiffMS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picDiffMS.Location = New System.Drawing.Point(53, 10)
        Me.picDiffMS.Margin = New System.Windows.Forms.Padding(53, 10, 53, 3)
        Me.picDiffMS.Name = "picDiffMS"
        Me.picDiffMS.Size = New System.Drawing.Size(154, 126)
        Me.picDiffMS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDiffMS.TabIndex = 0
        Me.picDiffMS.TabStop = False
        '
        'picDiffHL
        '
        Me.picDiffHL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.picDiffHL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picDiffHL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picDiffHL.Location = New System.Drawing.Point(573, 10)
        Me.picDiffHL.Margin = New System.Windows.Forms.Padding(53, 10, 53, 3)
        Me.picDiffHL.Name = "picDiffHL"
        Me.picDiffHL.Size = New System.Drawing.Size(156, 126)
        Me.picDiffHL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDiffHL.TabIndex = 2
        Me.picDiffHL.TabStop = False
        '
        'lblDiff2
        '
        Me.lblDiff2.AutoSize = True
        Me.lblDiff2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDiff2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiff2.Location = New System.Drawing.Point(263, 139)
        Me.lblDiff2.Name = "lblDiff2"
        Me.lblDiff2.Size = New System.Drawing.Size(254, 86)
        Me.lblDiff2.TabIndex = 4
        Me.lblDiff2.Text = "MHF4U2/MCV4U2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "IB SL Math" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2 year program"
        Me.lblDiff2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picDiffSL
        '
        Me.picDiffSL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.picDiffSL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picDiffSL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picDiffSL.Location = New System.Drawing.Point(313, 10)
        Me.picDiffSL.Margin = New System.Windows.Forms.Padding(53, 10, 53, 3)
        Me.picDiffSL.Name = "picDiffSL"
        Me.picDiffSL.Size = New System.Drawing.Size(154, 126)
        Me.picDiffSL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDiffSL.TabIndex = 1
        Me.picDiffSL.TabStop = False
        '
        'lblDiff1
        '
        Me.lblDiff1.AutoSize = True
        Me.lblDiff1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDiff1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiff1.Location = New System.Drawing.Point(3, 139)
        Me.lblDiff1.Name = "lblDiff1"
        Me.lblDiff1.Size = New System.Drawing.Size(254, 86)
        Me.lblDiff1.TabIndex = 3
        Me.lblDiff1.Text = "MCR3UE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "IB Math Studies" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 year program"
        Me.lblDiff1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStoryNxt
        '
        Me.btnStoryNxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStoryNxt.BackColor = System.Drawing.SystemColors.Control
        Me.btnStoryNxt.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStoryNxt.Location = New System.Drawing.Point(709, 15)
        Me.btnStoryNxt.Name = "btnStoryNxt"
        Me.btnStoryNxt.Size = New System.Drawing.Size(92, 30)
        Me.btnStoryNxt.TabIndex = 10
        Me.btnStoryNxt.Text = "Next"
        Me.btnStoryNxt.UseVisualStyleBackColor = False
        '
        'picImageBoxIB
        '
        Me.picImageBoxIB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picImageBoxIB.BackColor = System.Drawing.Color.Transparent
        Me.picImageBoxIB.InitialImage = CType(resources.GetObject("picImageBoxIB.InitialImage"), System.Drawing.Image)
        Me.picImageBoxIB.Location = New System.Drawing.Point(27, 87)
        Me.picImageBoxIB.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.picImageBoxIB.Name = "picImageBoxIB"
        Me.picImageBoxIB.Size = New System.Drawing.Size(200, 200)
        Me.picImageBoxIB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImageBoxIB.TabIndex = 2
        Me.picImageBoxIB.TabStop = False
        '
        'lblStoryTell
        '
        Me.lblStoryTell.AutoSize = True
        Me.lblStoryTell.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStoryTell.Location = New System.Drawing.Point(21, 14)
        Me.lblStoryTell.Name = "lblStoryTell"
        Me.lblStoryTell.Size = New System.Drawing.Size(558, 60)
        Me.lblStoryTell.TabIndex = 0
        Me.lblStoryTell.Text = "In the mid 1960s, the Intenational" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Baccalaureate IBDP program was conceived."
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
        Me.btnReturnMenu.TabIndex = 9
        Me.btnReturnMenu.UseVisualStyleBackColor = False
        '
        'tmrFadeTick
        '
        Me.tmrFadeTick.Interval = 1
        '
        'lblDiffDisplay
        '
        Me.lblDiffDisplay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDiffDisplay.AutoSize = True
        Me.lblDiffDisplay.BackColor = System.Drawing.Color.Transparent
        Me.lblDiffDisplay.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiffDisplay.Location = New System.Drawing.Point(532, 161)
        Me.lblDiffDisplay.Name = "lblDiffDisplay"
        Me.lblDiffDisplay.Size = New System.Drawing.Size(134, 33)
        Me.lblDiffDisplay.TabIndex = 10
        Me.lblDiffDisplay.Text = "Difficulty:"
        '
        'ModeSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.TheIBMathAdventure.My.Resources.Resources.bgTileHexBlue
        Me.ClientSize = New System.Drawing.Size(889, 520)
        Me.Controls.Add(Me.lblDiffDisplay)
        Me.Controls.Add(Me.btnReturnMenu)
        Me.Controls.Add(Me.pnlStory)
        Me.Controls.Add(Me.btnMaximize)
        Me.Controls.Add(Me.lblNameDisplay)
        Me.Controls.Add(Me.btnSubmitName)
        Me.Controls.Add(Me.txtNameInput)
        Me.Controls.Add(Me.lblContextTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ModeSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The IB Math Adventure"
        Me.pnlStory.ResumeLayout(False)
        Me.pnlStory.PerformLayout()
        Me.tlpDifficultySelect.ResumeLayout(False)
        Me.tlpDifficultySelect.PerformLayout()
        CType(Me.picDiffMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDiffHL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDiffSL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picImageBoxIB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblContextTitle As System.Windows.Forms.Label
    Friend WithEvents txtNameInput As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmitName As System.Windows.Forms.Button
    Friend WithEvents lblNameDisplay As System.Windows.Forms.Label
    Friend WithEvents btnMaximize As System.Windows.Forms.Button
    Friend WithEvents pnlStory As System.Windows.Forms.Panel
    Friend WithEvents lblStoryTell As System.Windows.Forms.Label
    Friend WithEvents picImageBoxIB As System.Windows.Forms.PictureBox
    Friend WithEvents btnReturnMenu As System.Windows.Forms.Button
    Friend WithEvents tmrFadeTick As System.Windows.Forms.Timer
    Friend WithEvents btnStoryNxt As System.Windows.Forms.Button
    Friend WithEvents picDiffHL As System.Windows.Forms.PictureBox
    Friend WithEvents picDiffSL As System.Windows.Forms.PictureBox
    Friend WithEvents picDiffMS As System.Windows.Forms.PictureBox
    Friend WithEvents lblDiff3 As System.Windows.Forms.Label
    Friend WithEvents lblDiff2 As System.Windows.Forms.Label
    Friend WithEvents lblDiff1 As System.Windows.Forms.Label
    Friend WithEvents tlpDifficultySelect As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblDiffDisplay As System.Windows.Forms.Label
End Class
