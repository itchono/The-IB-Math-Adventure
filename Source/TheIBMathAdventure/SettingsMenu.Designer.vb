<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsMenu))
        Me.lblDispInfo1 = New System.Windows.Forms.Label()
        Me.lblDispInfo2 = New System.Windows.Forms.Label()
        Me.txtFadeSpd = New System.Windows.Forms.TextBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.tmrFadeTick = New System.Windows.Forms.Timer(Me.components)
        Me.chbSound = New System.Windows.Forms.CheckBox()
        Me.btnResetStats = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDispInfo1
        '
        Me.lblDispInfo1.AutoSize = True
        Me.lblDispInfo1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispInfo1.Location = New System.Drawing.Point(12, 9)
        Me.lblDispInfo1.Name = "lblDispInfo1"
        Me.lblDispInfo1.Size = New System.Drawing.Size(83, 23)
        Me.lblDispInfo1.TabIndex = 0
        Me.lblDispInfo1.Text = "Settings"
        '
        'lblDispInfo2
        '
        Me.lblDispInfo2.AutoSize = True
        Me.lblDispInfo2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispInfo2.Location = New System.Drawing.Point(12, 53)
        Me.lblDispInfo2.Name = "lblDispInfo2"
        Me.lblDispInfo2.Size = New System.Drawing.Size(147, 21)
        Me.lblDispInfo2.TabIndex = 1
        Me.lblDispInfo2.Text = "Fade Speed (%):"
        '
        'txtFadeSpd
        '
        Me.txtFadeSpd.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFadeSpd.Location = New System.Drawing.Point(16, 77)
        Me.txtFadeSpd.Name = "txtFadeSpd"
        Me.txtFadeSpd.Size = New System.Drawing.Size(100, 22)
        Me.txtFadeSpd.TabIndex = 2
        Me.txtFadeSpd.Text = "100"
        '
        'btnApply
        '
        Me.btnApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnApply.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.Location = New System.Drawing.Point(12, 208)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(83, 33)
        Me.btnApply.TabIndex = 3
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(101, 208)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(83, 33)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'tmrFadeTick
        '
        Me.tmrFadeTick.Interval = 1
        '
        'chbSound
        '
        Me.chbSound.AutoSize = True
        Me.chbSound.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbSound.Location = New System.Drawing.Point(16, 114)
        Me.chbSound.Name = "chbSound"
        Me.chbSound.Size = New System.Drawing.Size(93, 27)
        Me.chbSound.TabIndex = 5
        Me.chbSound.Text = "Sound"
        Me.chbSound.UseVisualStyleBackColor = True
        '
        'btnResetStats
        '
        Me.btnResetStats.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnResetStats.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetStats.Location = New System.Drawing.Point(12, 160)
        Me.btnResetStats.Name = "btnResetStats"
        Me.btnResetStats.Size = New System.Drawing.Size(200, 33)
        Me.btnResetStats.TabIndex = 6
        Me.btnResetStats.Text = "Reset Stats and Settings"
        Me.btnResetStats.UseVisualStyleBackColor = True
        '
        'SettingsMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(403, 253)
        Me.Controls.Add(Me.btnResetStats)
        Me.Controls.Add(Me.chbSound)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.txtFadeSpd)
        Me.Controls.Add(Me.lblDispInfo2)
        Me.Controls.Add(Me.lblDispInfo1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SettingsMenu"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDispInfo1 As System.Windows.Forms.Label
    Friend WithEvents lblDispInfo2 As System.Windows.Forms.Label
    Friend WithEvents txtFadeSpd As System.Windows.Forms.TextBox
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents tmrFadeTick As System.Windows.Forms.Timer
    Friend WithEvents chbSound As System.Windows.Forms.CheckBox
    Friend WithEvents btnResetStats As System.Windows.Forms.Button
End Class
