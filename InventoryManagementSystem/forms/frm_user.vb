Imports MySql.Data.MySqlClient

Public Class frm_user
    Private Sub frm_adduser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            reloadDtg("Select user_id as 'ID', name as 'Name', user_name as 'Username', type as 'Type' From user", dtg_listUser)
            dtg_listUser.Columns(0).Visible = False
            If lbl_id.Text = "id" Then
                btn_update.Enabled = False
                btn_delete.Enabled = False
                btn_saveuser.Enabled = True
            Else
                btn_saveuser.Enabled = False
                btn_update.Enabled = True
                btn_delete.Enabled = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_new.Click
        txt_name.Clear()
        txt_pass.Clear()
        txt_username.Clear()
        cbo_type.Text = "--Select--"
        lbl_id.Text = "id"

        Call frm_adduser_Load(sender, e)
    End Sub

    Private Sub btn_saveuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_saveuser.Click
        If txt_name.Text = "" Or txt_pass.Text = "" Or txt_username.Text = "" Or cbo_type.Text = "--Select--" Then
            MsgBox("Action can not be performed. All fields require to be filled up.", MsgBoxStyle.Exclamation, "Inventory Management System")
        Else
            create("insert into user (name,user_name,pass,type) " _
             & "values('" & txt_name.Text & "','" & txt_username.Text _
             & "',sha1('" & txt_pass.Text & "'),'" & cbo_type.Text _
             & "')", "User", "User")

            Call frm_adduser_Load(sender, e)
        End If
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Try
            If txt_name.Text = "" Or txt_pass.Text = "" Or txt_username.Text = "" Or cbo_type.Text = "--Select--" Then
                MsgBox("Action can not be performed. All fields require to be filled up.", MsgBoxStyle.Exclamation, "Inventory Management System")
            Else
                updates("update user set name = '" & txt_name.Text & "',user_name= '" & txt_username.Text _
                            & "',pass= sha1('" & txt_pass.Text & "'),type= '" & cbo_type.Text _
                            & "' where user_id = " & lbl_id.Text, "User", "User")
                Call frm_adduser_Load(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Try
            deletes("delete from user where user_id = '" & lbl_id.Text & "'", "User", "User")
            Call frm_adduser_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        txt_name.Clear()
        txt_pass.Clear()
        txt_username.Clear()
        cbo_type.Text = "--Select--"
        lbl_id.Text = "id"
    End Sub

    Private Sub dtg_listUser_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtg_listUser.DoubleClick
        Try
            With dtg_listUser.CurrentRow
                lbl_id.Text = .Cells(0).Value
                txt_name.Text = .Cells(1).Value
                txt_username.Text = .Cells(2).Value
                cbo_type.Text = .Cells(3).Value
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lbl_id_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl_id.TextChanged
        Try
            If lbl_id.Text = "id" Then
                btn_update.Enabled = False
                btn_delete.Enabled = False
                btn_saveuser.Enabled = True
            Else
                btn_saveuser.Enabled = False
                btn_update.Enabled = True
                btn_delete.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
End Class