Public Class FadeSingleaAnm
    Private timeOfTransition As Integer
    Private transition As Integer = 1

    Public Property TimeOfTranistion As Integer
        Get
            Return transition
        End Get
        Set(value As Integer)
            transition = value
            waitTimer.Interval = value
        End Set
    End Property

    Sub New(imgs As Image)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        picture.Image = imgs
    End Sub

    Private Sub FadeIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        animationTimer.Enabled = True
    End Sub

    Private Sub animationTimer_Tick(sender As Object, e As EventArgs) Handles animationTimer.Tick
        If transition = 1 Then
            Me.Opacity = Me.Opacity + 0.1
            If Me.Opacity = 1 Then
                animationTimer.Enabled = False
                waitTimer.Enabled = True
                transition = 2
            End If
        Else
            Me.Opacity = Me.Opacity - 0.1
            If Me.Opacity = 0 Then
                closeForm()
            End If
        End If
    End Sub

    Private Sub closeForm()
        Me.Close()
    End Sub
    Private Sub waitTimer_Tick(sender As Object, e As EventArgs) Handles waitTimer.Tick
        animationTimer.Enabled = True
        waitTimer.Enabled = False
    End Sub
End Class