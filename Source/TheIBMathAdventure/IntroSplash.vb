'An interesting splash screen to show while loading

Public Class IntroSplash
    Private Sub IntroSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If RootMenu.Opacity = 1 Then
            Me.Close()
        End If
        'Closes splash screen once menu is loaded
    End Sub
End Class