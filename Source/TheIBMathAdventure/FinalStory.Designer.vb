<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinalStory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FinalStory))
        Me.lblDispTitle = New System.Windows.Forms.Label()
        Me.lblStory1 = New System.Windows.Forms.Label()
        Me.lblStory2 = New System.Windows.Forms.Label()
        Me.lblStory3 = New System.Windows.Forms.Label()
        Me.btnReturnMenu = New System.Windows.Forms.Button()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.btnStoryNxt = New System.Windows.Forms.Button()
        Me.tmrFadeTick = New System.Windows.Forms.Timer(Me.components)
        Me.tlpStory = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpStory.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDispTitle
        '
        Me.lblDispTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDispTitle.AutoSize = True
        Me.lblDispTitle.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispTitle.Location = New System.Drawing.Point(260, 9)
        Me.lblDispTitle.Name = "lblDispTitle"
        Me.lblDispTitle.Size = New System.Drawing.Size(341, 32)
        Me.lblDispTitle.TabIndex = 0
        Me.lblDispTitle.Text = "The End of the Adventure"
        '
        'lblStory1
        '
        Me.lblStory1.AutoSize = True
        Me.lblStory1.BackColor = System.Drawing.Color.Transparent
        Me.lblStory1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblStory1.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStory1.Location = New System.Drawing.Point(3, 0)
        Me.lblStory1.Name = "lblStory1"
        Me.lblStory1.Size = New System.Drawing.Size(789, 114)
        Me.lblStory1.TabIndex = 1
        Me.lblStory1.Text = "With <>'s graduation, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "they moved on to <> to pursue their" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "post-secondary educa" & _
    "tion. "
        '
        'lblStory2
        '
        Me.lblStory2.AutoSize = True
        Me.lblStory2.BackColor = System.Drawing.Color.Transparent
        Me.lblStory2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblStory2.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStory2.Location = New System.Drawing.Point(3, 114)
        Me.lblStory2.Name = "lblStory2"
        Me.lblStory2.Size = New System.Drawing.Size(789, 152)
        Me.lblStory2.TabIndex = 2
        Me.lblStory2.Text = "Though they missed the thrill of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the International Baccalaureate program at time" & _
    "s, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<> " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "was glad that it was all over. "
        '
        'lblStory3
        '
        Me.lblStory3.AutoSize = True
        Me.lblStory3.BackColor = System.Drawing.Color.Transparent
        Me.lblStory3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblStory3.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStory3.Location = New System.Drawing.Point(3, 266)
        Me.lblStory3.Name = "lblStory3"
        Me.lblStory3.Size = New System.Drawing.Size(789, 116)
        Me.lblStory3.TabIndex = 3
        Me.lblStory3.Text = "With the end of their IB Math Adventure," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " it was time for them to go on their ne" & _
    "xt" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "adventure: life."
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
        Me.btnReturnMenu.TabIndex = 11
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
        Me.btnMaximize.TabIndex = 10
        Me.btnMaximize.UseVisualStyleBackColor = False
        '
        'btnStoryNxt
        '
        Me.btnStoryNxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStoryNxt.BackColor = System.Drawing.SystemColors.Control
        Me.btnStoryNxt.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStoryNxt.Location = New System.Drawing.Point(711, 454)
        Me.btnStoryNxt.Name = "btnStoryNxt"
        Me.btnStoryNxt.Size = New System.Drawing.Size(142, 45)
        Me.btnStoryNxt.TabIndex = 12
        Me.btnStoryNxt.Text = "Next"
        Me.btnStoryNxt.UseVisualStyleBackColor = False
        '
        'tmrFadeTick
        '
        Me.tmrFadeTick.Interval = 1
        '
        'tlpStory
        '
        Me.tlpStory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpStory.BackColor = System.Drawing.Color.Transparent
        Me.tlpStory.ColumnCount = 1
        Me.tlpStory.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpStory.Controls.Add(Me.lblStory1, 0, 0)
        Me.tlpStory.Controls.Add(Me.lblStory2, 0, 1)
        Me.tlpStory.Controls.Add(Me.lblStory3, 0, 2)
        Me.tlpStory.Location = New System.Drawing.Point(32, 86)
        Me.tlpStory.Name = "tlpStory"
        Me.tlpStory.RowCount = 3
        Me.tlpStory.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlpStory.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpStory.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlpStory.Size = New System.Drawing.Size(795, 382)
        Me.tlpStory.TabIndex = 13
        '
        'FinalStory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(889, 520)
        Me.Controls.Add(Me.btnStoryNxt)
        Me.Controls.Add(Me.tlpStory)
        Me.Controls.Add(Me.btnReturnMenu)
        Me.Controls.Add(Me.btnMaximize)
        Me.Controls.Add(Me.lblDispTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FinalStory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The IB Math Adventure"
        Me.tlpStory.ResumeLayout(False)
        Me.tlpStory.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDispTitle As System.Windows.Forms.Label
    Friend WithEvents lblStory1 As System.Windows.Forms.Label
    Friend WithEvents lblStory2 As System.Windows.Forms.Label
    Friend WithEvents lblStory3 As System.Windows.Forms.Label
    Friend WithEvents btnReturnMenu As System.Windows.Forms.Button
    Friend WithEvents btnMaximize As System.Windows.Forms.Button
    Friend WithEvents btnStoryNxt As System.Windows.Forms.Button
    Friend WithEvents tmrFadeTick As System.Windows.Forms.Timer
    Friend WithEvents tlpStory As System.Windows.Forms.TableLayoutPanel
End Class
