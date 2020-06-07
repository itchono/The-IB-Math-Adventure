<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IntroSplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IntroSplash))
        Me.picMainLogo = New System.Windows.Forms.PictureBox()
        Me.lblMainTitle = New System.Windows.Forms.Label()
        Me.lblDispLoading = New System.Windows.Forms.Label()
        Me.lblDisplBldVers = New System.Windows.Forms.Label()
        CType(Me.picMainLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picMainLogo
        '
        Me.picMainLogo.BackColor = System.Drawing.Color.Transparent
        Me.picMainLogo.Image = Global.TheIBMathAdventure.My.Resources.Resources.icoIBLogo
        Me.picMainLogo.InitialImage = CType(resources.GetObject("picMainLogo.InitialImage"), System.Drawing.Image)
        Me.picMainLogo.Location = New System.Drawing.Point(24, 50)
        Me.picMainLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picMainLogo.Name = "picMainLogo"
        Me.picMainLogo.Size = New System.Drawing.Size(169, 152)
        Me.picMainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMainLogo.TabIndex = 3
        Me.picMainLogo.TabStop = False
        '
        'lblMainTitle
        '
        Me.lblMainTitle.AutoSize = True
        Me.lblMainTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblMainTitle.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainTitle.Location = New System.Drawing.Point(21, 16)
        Me.lblMainTitle.Name = "lblMainTitle"
        Me.lblMainTitle.Size = New System.Drawing.Size(232, 231)
        Me.lblMainTitle.TabIndex = 2
        Me.lblMainTitle.Text = "The" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Math Adventure" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblDispLoading
        '
        Me.lblDispLoading.AutoSize = True
        Me.lblDispLoading.BackColor = System.Drawing.Color.Transparent
        Me.lblDispLoading.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispLoading.Location = New System.Drawing.Point(18, 273)
        Me.lblDispLoading.Name = "lblDispLoading"
        Me.lblDispLoading.Size = New System.Drawing.Size(212, 33)
        Me.lblDispLoading.TabIndex = 4
        Me.lblDispLoading.Text = "Now Loading..."
        '
        'lblDisplBldVers
        '
        Me.lblDisplBldVers.AutoSize = True
        Me.lblDisplBldVers.BackColor = System.Drawing.Color.Transparent
        Me.lblDisplBldVers.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplBldVers.Location = New System.Drawing.Point(317, 9)
        Me.lblDisplBldVers.Name = "lblDisplBldVers"
        Me.lblDisplBldVers.Size = New System.Drawing.Size(199, 46)
        Me.lblDisplBldVers.TabIndex = 5
        Me.lblDisplBldVers.Text = "Release Version 1.3" & Global.Microsoft.VisualBasic.ChrW(13) & "December 17, 2016"
        Me.lblDisplBldVers.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'IntroSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 320)
        Me.Controls.Add(Me.lblDisplBldVers)
        Me.Controls.Add(Me.lblDispLoading)
        Me.Controls.Add(Me.picMainLogo)
        Me.Controls.Add(Me.lblMainTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "IntroSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The IB Math Adventure - Loading"
        CType(Me.picMainLogo,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents picMainLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblMainTitle As System.Windows.Forms.Label
    Friend WithEvents lblDispLoading As System.Windows.Forms.Label
    Friend WithEvents lblDisplBldVers As System.Windows.Forms.Label
End Class
