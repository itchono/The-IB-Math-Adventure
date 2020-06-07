<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportCard))
        Me.tmrFadeTick = New System.Windows.Forms.Timer(Me.components)
        Me.tlpReportCard = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDispUni = New System.Windows.Forms.Label()
        Me.lblDispTitle = New System.Windows.Forms.Label()
        Me.lblDispInfo = New System.Windows.Forms.Label()
        Me.lblDispGrade = New System.Windows.Forms.Label()
        Me.lblUniversity = New System.Windows.Forms.Label()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.btnReturnMenu = New System.Windows.Forms.Button()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.tmrSequenceTick = New System.Windows.Forms.Timer(Me.components)
        Me.tlpReportCard.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrFadeTick
        '
        Me.tmrFadeTick.Interval = 1
        '
        'tlpReportCard
        '
        Me.tlpReportCard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpReportCard.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.tlpReportCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tlpReportCard.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpReportCard.ColumnCount = 2
        Me.tlpReportCard.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.tlpReportCard.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.tlpReportCard.Controls.Add(Me.lblDispUni, 0, 2)
        Me.tlpReportCard.Controls.Add(Me.lblDispTitle, 0, 0)
        Me.tlpReportCard.Controls.Add(Me.lblDispInfo, 1, 0)
        Me.tlpReportCard.Controls.Add(Me.lblDispGrade, 0, 1)
        Me.tlpReportCard.Controls.Add(Me.lblUniversity, 0, 2)
        Me.tlpReportCard.Controls.Add(Me.lblGrade, 1, 1)
        Me.tlpReportCard.Location = New System.Drawing.Point(108, 116)
        Me.tlpReportCard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tlpReportCard.Name = "tlpReportCard"
        Me.tlpReportCard.RowCount = 3
        Me.tlpReportCard.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpReportCard.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlpReportCard.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlpReportCard.Size = New System.Drawing.Size(788, 448)
        Me.tlpReportCard.TabIndex = 12
        '
        'lblDispUni
        '
        Me.lblDispUni.AutoSize = True
        Me.lblDispUni.BackColor = System.Drawing.Color.Transparent
        Me.lblDispUni.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispUni.Location = New System.Drawing.Point(4, 313)
        Me.lblDispUni.Name = "lblDispUni"
        Me.lblDispUni.Size = New System.Drawing.Size(203, 90)
        Me.lblDispUni.TabIndex = 5
        Me.lblDispUni.Text = "Destination Post-Secondary Institution"
        '
        'lblDispTitle
        '
        Me.lblDispTitle.AutoSize = True
        Me.lblDispTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblDispTitle.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispTitle.Location = New System.Drawing.Point(4, 1)
        Me.lblDispTitle.Name = "lblDispTitle"
        Me.lblDispTitle.Size = New System.Drawing.Size(188, 168)
        Me.lblDispTitle.TabIndex = 0
        Me.lblDispTitle.Text = "Final Report Card"
        '
        'lblDispInfo
        '
        Me.lblDispInfo.AutoSize = True
        Me.lblDispInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblDispInfo.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispInfo.Location = New System.Drawing.Point(279, 1)
        Me.lblDispInfo.Name = "lblDispInfo"
        Me.lblDispInfo.Size = New System.Drawing.Size(398, 39)
        Me.lblDispInfo.TabIndex = 1
        Me.lblDispInfo.Text = "<Username and course>"
        '
        'lblDispGrade
        '
        Me.lblDispGrade.AutoSize = True
        Me.lblDispGrade.BackColor = System.Drawing.Color.Transparent
        Me.lblDispGrade.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispGrade.Location = New System.Drawing.Point(4, 179)
        Me.lblDispGrade.Name = "lblDispGrade"
        Me.lblDispGrade.Size = New System.Drawing.Size(89, 30)
        Me.lblDispGrade.TabIndex = 2
        Me.lblDispGrade.Text = "Grade"
        '
        'lblUniversity
        '
        Me.lblUniversity.AutoSize = True
        Me.lblUniversity.BackColor = System.Drawing.Color.Transparent
        Me.lblUniversity.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUniversity.Location = New System.Drawing.Point(279, 313)
        Me.lblUniversity.Name = "lblUniversity"
        Me.lblUniversity.Size = New System.Drawing.Size(155, 30)
        Me.lblUniversity.TabIndex = 3
        Me.lblUniversity.Text = "<University>"
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.BackColor = System.Drawing.Color.Transparent
        Me.lblGrade.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade.Location = New System.Drawing.Point(279, 179)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(135, 30)
        Me.lblGrade.TabIndex = 4
        Me.lblGrade.Text = "<Percent>"
        '
        'btnProceed
        '
        Me.btnProceed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProceed.BackColor = System.Drawing.SystemColors.Control
        Me.btnProceed.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProceed.Location = New System.Drawing.Point(705, 580)
        Me.btnProceed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(190, 35)
        Me.btnProceed.TabIndex = 13
        Me.btnProceed.Text = "Choose University"
        Me.btnProceed.UseVisualStyleBackColor = False
        '
        'btnReturnMenu
        '
        Me.btnReturnMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnReturnMenu.BackgroundImage = Global.TheIBMathAdventure.My.Resources.Resources.icoReturn
        Me.btnReturnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnReturnMenu.FlatAppearance.BorderSize = 0
        Me.btnReturnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturnMenu.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnMenu.Location = New System.Drawing.Point(15, 15)
        Me.btnReturnMenu.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnReturnMenu.Name = "btnReturnMenu"
        Me.btnReturnMenu.Size = New System.Drawing.Size(57, 34)
        Me.btnReturnMenu.TabIndex = 14
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
        Me.btnMaximize.Location = New System.Drawing.Point(927, 15)
        Me.btnMaximize.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(58, 34)
        Me.btnMaximize.TabIndex = 15
        Me.btnMaximize.UseVisualStyleBackColor = False
        '
        'tmrSequenceTick
        '
        '
        'ReportCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.btnMaximize)
        Me.Controls.Add(Me.btnReturnMenu)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.tlpReportCard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ReportCard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The IB Math Adventure"
        Me.tlpReportCard.ResumeLayout(False)
        Me.tlpReportCard.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrFadeTick As System.Windows.Forms.Timer
    Friend WithEvents tlpReportCard As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblDispTitle As System.Windows.Forms.Label
    Friend WithEvents lblDispInfo As System.Windows.Forms.Label
    Friend WithEvents lblDispGrade As System.Windows.Forms.Label
    Friend WithEvents lblUniversity As System.Windows.Forms.Label
    Friend WithEvents lblDispUni As System.Windows.Forms.Label
    Friend WithEvents lblGrade As System.Windows.Forms.Label
    Friend WithEvents btnProceed As System.Windows.Forms.Button
    Friend WithEvents btnReturnMenu As System.Windows.Forms.Button
    Friend WithEvents btnMaximize As System.Windows.Forms.Button
    Friend WithEvents tmrSequenceTick As System.Windows.Forms.Timer
End Class
