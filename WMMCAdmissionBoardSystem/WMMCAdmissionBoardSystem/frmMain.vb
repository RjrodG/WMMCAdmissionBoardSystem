Public Class frmMain
    Private Sub frmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F12 Then
            frmConnection.Show()
        End If
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getDataSqlServer()
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label6.Text = TimeOfDay
        Label4.Text = Today.ToLongDateString.ToString
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim privoccu, privtotal, privpercen As Integer
        Dim wardoccu, wardtotal, wardpercen As Integer
        privoccu = DBconnSQLServer.fetchSQLServer("SELECT COUNT(*) FROM wmmcBedCapacity WHERE classification = 'PRIVATE' AND status = 'OCCUPIED'").Tables(0).Rows(0).Item(0).ToString
        privtotal = DBconnSQLServer.fetchSQLServer("SELECT COUNT(*) FROM wmmcBedCapacity WHERE classification = 'PRIVATE'").Tables(0).Rows(0).Item(0).ToString
        privpercen = privoccu / privtotal * 100
        lbprivate.Text = privpercen.ToString("00") + "%"
        wardoccu = DBconnSQLServer.fetchSQLServer("SELECT COUNT(*) FROM wmmcBedCapacity WHERE classification = 'WARD' AND status = 'OCCUPIED'").Tables(0).Rows(0).Item(0).ToString
        wardtotal = DBconnSQLServer.fetchSQLServer("SELECT COUNT(*) FROM wmmcBedCapacity WHERE classification = 'WARD'").Tables(0).Rows(0).Item(0).ToString
        wardpercen = wardoccu / wardtotal * 100
        lbward.Text = wardpercen.ToString("00") + "%"
    End Sub

End Class