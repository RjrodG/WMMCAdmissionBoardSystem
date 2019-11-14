Public Class FadeMultipleAnm
    Private IMGs As List(Of Image)
    Sub New(imgs As List(Of Image))

        ' This call is required by the designer.
        InitializeComponent()
        Me.IMGs = imgs
    End Sub
    Private Sub FadeMultiple_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub waitTimer_Tick(sender As Object, e As EventArgs)

    End Sub
End Class