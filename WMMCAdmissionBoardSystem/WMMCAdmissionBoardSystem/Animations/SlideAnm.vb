Public Class Slide
    Private IMGs As List(Of Image)
    Private waitTime As Integer = 8

    Private transition As Integer = 1

    Private Sub animationTimer_Tick(sender As Object, e As EventArgs) Handles animationTimer.Tick
        If transition = 1 Then
            If slide1.Width < Me.Width Then
                slide1.Width = slide1.Width + 5
            Else
                animationTimer.Enabled = False
                waitTimer.Enabled = True
                transition = 2
            End If
        ElseIf transition = 2 Then
            If slide1.Width > 0 Then
                slide1.Width = slide1.Width - 5
            Else
                animationTimer.Enabled = False
                waitTimer.Enabled = True
                transition = 1
            End If
        End If

    End Sub

    Private Sub Slide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        slide1.Width = 0
        waitTimer.Enabled = True
    End Sub

    Private Sub waitTimer_Tick(sender As Object, e As EventArgs) Handles waitTimer.Tick
        animationTimer.Enabled = True
        waitTimer.Enabled = False
    End Sub
End Class