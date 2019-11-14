Public Class frmMain
    Private animationInterval As Integer = 15000
    Private IMgsFiles As Integer = 1

    Private Sub frmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F12 Then
            SetAnimationInterval(False)
            frmConnection.ShowDialog()
            SetAnimationInterval(True)
        End If

        If e.KeyCode = Keys.F11 Then
            If Me.WindowState = FormWindowState.Maximized Then
                Me.ControlBox = True
                Me.WindowState = FormWindowState.Normal
            Else
                Me.ControlBox = False
                Me.WindowState = FormWindowState.Maximized
            End If
        End If

        If e.KeyCode = Keys.F10 Then
            SetAnimationInterval(False)
            frmShowAppLocation.ShowDialog()
            SetAnimationInterval(True)
        End If
    End Sub

    Private Sub SetAnimationInterval(flag As Boolean)
        If flag Then
            Clock.Start()
            GetAdmissionInterval.Start()
            ShowAnimationInterval.Interval = animationInterval
            ShowAnimationInterval.Start()
        Else
            Clock.Stop()
            GetAdmissionInterval.Stop()
            ShowAnimationInterval.Stop()
        End If

    End Sub

    Public Sub getAdmissionPercentage()
        Dim privoccu, privtotal, privpercen As Integer
        Dim wardoccu, wardtotal, wardpercen As Integer
        Try
            privoccu = DBconnSQLServer.fetchSQLServer("SELECT COUNT(*) FROM wmmcBedCapacity WHERE classification = 'PRIVATE' AND status = 'OCCUPIED'").Tables(0).Rows(0).Item(0).ToString
            privtotal = DBconnSQLServer.fetchSQLServer("SELECT COUNT(*) FROM wmmcBedCapacity WHERE classification = 'PRIVATE'").Tables(0).Rows(0).Item(0).ToString
            privpercen = privoccu / privtotal * 100
            If (privpercen = "100") Then
                lbprivate.Location = New Point(15, 19)
                lbprivate.Text = privpercen.ToString("00") + "%"
            Else
                lbprivate.Location = New Point(67, 19)
                lbprivate.Text = privpercen.ToString("00") + "%"
            End If
            wardoccu = DBconnSQLServer.fetchSQLServer("SELECT COUNT(*) FROM wmmcBedCapacity WHERE classification = 'WARD' AND status = 'OCCUPIED'").Tables(0).Rows(0).Item(0).ToString
            wardtotal = DBconnSQLServer.fetchSQLServer("SELECT COUNT(*) FROM wmmcBedCapacity WHERE classification = 'WARD'").Tables(0).Rows(0).Item(0).ToString
            wardpercen = wardoccu / wardtotal * 100
            If (wardpercen = "100") Then
                lbward.Location = New Point(11, 19)
                lbward.Text = wardpercen.ToString("00") + "%"
            Else
                lbward.Location = New Point(67, 19)
                lbward.Text = wardpercen.ToString("00") + "%"
                lbward.Text = wardpercen.ToString("00") + "%"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getDataSqlServer()
        getAdmissionPercentage()
        ShowAnimationInterval.Interval = animationInterval
        SetAnimationInterval(True)
    End Sub

    Private Sub Clock_Tick(sender As Object, e As EventArgs) Handles Clock.Tick
        Label6.Text = TimeOfDay
        Label4.Text = Today.ToLongDateString.ToString
    End Sub

    Private Sub GetAdmissionInterval_Tick(sender As Object, e As EventArgs) Handles GetAdmissionInterval.Tick
        getAdmissionPercentage()
    End Sub

    Private Sub ShowAnimationInterval_Tick(sender As Object, e As EventArgs) Handles ShowAnimationInterval.Tick
        Try
            Dim id As String = IMgsFiles.ToString + ".JPG"
            If IMgsFiles = 9 Then
                ShowAnimationInterval.Interval += 20000
                IMgsFiles = 1
            ElseIf IMgsFiles = 4 Then
                ShowAnimationInterval.Interval += 20000
                IMgsFiles += 1
            Else
                ShowAnimationInterval.Interval = 9000
                IMgsFiles += 1
            End If
            Dim folder As String = Application.StartupPath() + "\Photos\"
            Dim filename As String = System.IO.Path.Combine(folder, id)

            Dim frm As New FadeSingleaAnm(Image.FromFile(filename))
            frm.ShowDialog(Me)
        Catch ex As Exception

        End Try

    End Sub
End Class