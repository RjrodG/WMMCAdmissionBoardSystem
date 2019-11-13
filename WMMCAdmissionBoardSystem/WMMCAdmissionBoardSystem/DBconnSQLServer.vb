Imports System.Data.SqlClient
Imports System.Data
Module DBconnSQLServer
    Public consql As New SqlConnection
    Public dasql As SqlDataAdapter
    Public serversql, databasesql, usersql, passsql As String

    Public Sub openDatabaseSqlServer()
        Try
            If consql.State = ConnectionState.Closed Then
                consql.ConnectionString = "Data Source = " & serversql & ";  " _
                                          & "Initial Catalog = " & databasesql & "; " _
                                          & "User ID = " & usersql & "; " _
                                          & "Password = " & passsql & ""
                consql.Open()
            End If
        Catch ex As SqlException
            MessageBox.Show(ex.Message & Chr(13) &
                "Check the network connection. ", "Connection Failed.",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Public Sub closeDatabaseSqlServer()
        Try
            consql.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.Message & Chr(13), "Disconnection Failed.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Public Sub execSQLServer(ByVal sqlstr As String)
        Try
            openDatabaseSqlServer()
            Dim cmd As New SqlCommand
            cmd.CommandText = sqlstr
            cmd.CommandType = CommandType.Text
            cmd.Connection = consql
            cmd.ExecuteNonQuery()
        Catch ex As SqlException
            MsgBox("ERROR:" + ex.ErrorCode.ToString + ":" + "Check network connection or contact the IT department for support.")
        Finally
            closeDatabaseSqlServer()
        End Try
    End Sub

    Public Function execdeleteSQLServer(ByVal sqlstr As String) As Boolean
        Try
            openDatabaseSqlServer()
            Dim cmd As New SqlCommand
            cmd.CommandText = sqlstr
            cmd.CommandType = CommandType.Text
            cmd.Connection = consql
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As SqlException
            Return False
        Finally
            closeDatabaseSqlServer()
        End Try
    End Function

    Public Function fetchSQLServer(ByVal sqlstr As String) As DataSet
        Try
            openDatabaseSqlServer()
            dasql = New SqlDataAdapter(sqlstr, consql)
            Dim ds As New DataSet
            dasql.Fill(ds, "Data")
            Return ds
        Catch ex As SqlException
            MsgBox("ERROR:" + ex.ErrorCode.ToString + ":" + "Check network connection or contact the IT department for support.")
            Return Nothing
        Finally
            closeDatabaseSqlServer()
        End Try
    End Function


    Public Sub getDataSqlServer()
        Dim AppNameServer As String = Application.ProductName
        Try
            serversql = GetSetting(AppNameServer, "DBSection2", "DB_Server", "10.5.19.25")
            databasesql = GetSetting(AppNameServer, "DBSection2", "DB_Name", "LiveDB_WMMC")
            usersql = GetSetting(AppNameServer, "DBSection2", "DB_User", "sa")
            passsql = GetSetting(AppNameServer, "DBSection2", "DB_Pass", "s@password1")

        Catch ex As Exception
            MsgBox("Failed To Get Database Connection", MsgBoxStyle.Critical, "Database Error")
        End Try
    End Sub

    Public Sub saveDataSqlServer()
        Dim AppNameServer As String = Application.ProductName
        Try
            SaveSetting(AppNameServer, "DBSection2", "DB_Server", serversql)
            SaveSetting(AppNameServer, "DBSection2", "DB_Name", databasesql)
            SaveSetting(AppNameServer, "DBSection2", "DB_User", usersql)
            SaveSetting(AppNameServer, "DBSection2", "DB_Pass", passsql)
            MsgBox("Setting Saved Successfully")
        Catch ex As Exception
            MsgBox("Failed To Save Connection", MsgBoxStyle.Information)
        End Try
    End Sub
End Module
