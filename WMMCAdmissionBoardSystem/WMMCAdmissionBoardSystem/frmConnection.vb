Public Class frmConnection
    Private TstServerSQL As String
    Private TstUserSQL As String
    Private TstDBNameSQL As String
    Private TstPassSQL As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmConnection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtserver.Focus()
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            If txtserver.Text.ToUpper = "" Then
                MessageBox.Show("Please fill completely", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                TstServerSQL = txtserver.Text
                TstDBNameSQL = txtdb.Text
                TstUserSQL = txtuser.Text
                TstPassSQL = txtpass.Text

                consql.ConnectionString = "Data Source = " & TstServerSQL & ";  " _
                                         & "Initial Catalog = " & TstDBNameSQL & "; " _
                                         & "User ID = " & TstUserSQL & "; " _
                                         & "Password = " & TstPassSQL & ""
                consql.Open()
                MessageBox.Show("Connection Successful", "Database", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If MsgBox("Want To Save Connection?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    serversql = txtserver.Text
                    databasesql = txtdb.Text
                    usersql = txtuser.Text
                    passsql = txtpass.Text

                    Call saveDataSqlServer()
                End If

            End If
        Catch ex As Exception
            MsgBox("Failed to Connect to the Database, Check if the Connection is Correct or Database Is Open", MsgBoxStyle.Exclamation, "Database Settings")
            MessageBox.Show(ex.ToString)
        Finally
            closeDatabaseSqlServer()
        End Try
    End Sub

End Class