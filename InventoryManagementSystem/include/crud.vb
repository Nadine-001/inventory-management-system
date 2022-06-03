Imports MySql.Data.MySqlClient

Module crud  
    Public con As MySqlConnection = mysqldb()
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Public ds As New DataSet
    Public sql As String
    Public result As String
    Public add As String
    Public edit As String

#Region "old crud"
    Public Sub save_or_update(ByVal sql As String, ByVal add As String, ByVal edit As String)
        con.Open()
        With cmd
            .Connection = con
            .CommandText = sql
        End With
        dt = New DataTable
        da = New MySqlDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()
        If dt.Rows.Count > 0 Then
            con.Open()
            With cmd
                .Connection = con
                .CommandText = edit
                result = cmd.ExecuteNonQuery
            End With
            con.Close()
        Else
            con.Open()
            With cmd
                .Connection = con
                .CommandText = add
                result = cmd.ExecuteNonQuery
            End With
        End If
        con.Close()
    End Sub

    Public Sub createNoMsg(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
                cmd.ExecuteNonQuery()
            End With
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "createNoMsg", MsgBoxStyle.Information, "Inventory Management System")
        End Try
    End Sub

    Public Sub create(ByVal sql As String, ByVal msgsuccess As String, ByVal msgerror As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox(msgerror & " is failed to save in the database ", MsgBoxStyle.Information, "Inventory Management System")
                Else
                    MsgBox(msgsuccess & " has been saved to the database", MsgBoxStyle.Information, "Inventory Management System")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message & " create", MsgBoxStyle.Information, "Inventory Management System")
        End Try
        con.Close()
    End Sub

    Public Sub reloadDtg(ByVal sql As String, ByVal dtg As DataGridView)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            dt = New DataTable
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dtg.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message & "reloadDtg", MsgBoxStyle.Information, "Inventory Management System")
        End Try

        con.Close()
        da.Dispose()
    End Sub

    Public Sub reloadtxt(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            dt = New DataTable
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message & "reloadtxt", MsgBoxStyle.Information, "Inventory Management System")
        End Try
        con.Close()
        da.Dispose()
    End Sub

    Public Sub updates(ByVal sql As String, ByVal msgsuccess As String, ByVal msgerror As String)
        Try
            con.Open()
            cmd = New MySqlCommand
            With cmd
                .Connection = con
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox(msgerror & " is failed to updated on database.", MsgBoxStyle.Information, "Inventory Management System")
                Else
                    MsgBox(msgsuccess & " has been updated on database.", MsgBoxStyle.Information, "Inventory Management System")
                End If
            End With
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "updates", MsgBoxStyle.Information, "Inventory Management System")
        End Try
    End Sub

    Public Sub deletes(ByVal sql As String, ByVal msgsuccess As String, ByVal msgerror As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            result = cmd.ExecuteNonQuery
            If result = 0 Then
                MsgBox(msgerror & " is failed to delete from database.", MsgBoxStyle.Information, "Inventory Management System")
            Else
                MsgBox(msgsuccess & " has been deleted from database.", MsgBoxStyle.Information, "Inventory Management System")
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Inventory Management System")
        End Try
    End Sub
#End Region

End Module