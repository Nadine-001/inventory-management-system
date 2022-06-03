Public Class frm_setting
    Dim typeid As Integer = 0
    Dim unitid As Integer = 0

    Private Sub btncsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncsave.Click
        sql = "INSERT INTO tblsettings (DESCRIPTION,PARA) VALUES ('" & txtCategory.Text & "','Category')"
        create(sql, txtCategory.Text, txtCategory.Text)

        sql = "INSERT INTO tblautonumber (STRT,END,INCREMENT,DESCRIPTION)" &
           " VALUES ('" & txtCategory.Text.Substring(0, 1) & "0000" & "',1,1,'" & txtCategory.Text & "')"
        createNoMsg(sql)

        txtCategory.Clear()
        sql = "SELECT ID, DESCRIPTION as 'Category' FROM tblsettings WHERE PARA='Category'"
        reloadDtg(sql, dtgtypelist)
        dtgtypelist.Columns(0).Visible = False
    End Sub

    Private Sub btncload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncload.Click
        sql = "SELECT ID, DESCRIPTION as 'Category' FROM tblsettings WHERE PARA='Category'"
        reloadDtg(sql, dtgtypelist)
        dtgtypelist.Columns(0).Visible = False
        txtCategory.Clear()
    End Sub

    Private Sub dtgtypelist_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgtypelist.DoubleClick
        txtCategory.Text = dtgtypelist.CurrentRow.Cells(1).Value
        typeid = dtgtypelist.CurrentRow.Cells(0).Value

        btncupdate.Enabled = True
        btncdel.Enabled = True
        btncsave.Enabled = False
    End Sub

    Private Sub btncupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncupdate.Click
        sql = "UPDATE tblsettings  SET DESCRIPTION= '" & txtCategory.Text & "' WHERE ID ='" & typeid & "'"
        updates(sql, txtCategory.Text, txtCategory.Text)
        sql = "SELECT ID, DESCRIPTION as 'Category' FROM tblsettings WHERE PARA='Category'"
        reloadDtg(sql, dtgtypelist)
        dtgtypelist.Columns(0).Visible = False
        txtCategory.Clear()
    End Sub

    Private Sub btnuload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnuload.Click
        sql = "SELECT ID, DESCRIPTION as 'Item Unit' FROM tblsettings WHERE PARA='Unit'"
        reloadDtg(sql, dtgulist)
        dtgulist.Columns(0).Visible = False
        txtUnit.Clear()
    End Sub

    Private Sub btnusave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnusave.Click
        sql = "INSERT INTO tblsettings (DESCRIPTION,PARA) VALUES ('" & txtUnit.Text & "','Unit')"
        create(sql, txtUnit.Text, txtUnit.Text)
        txtUnit.Clear()
        sql = "SELECT ID, DESCRIPTION as 'Item Unit' FROM tblsettings WHERE PARA='Unit'"
        reloadDtg(sql, dtgulist)
        dtgulist.Columns(0).Visible = False
    End Sub

    Private Sub btnuupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnuupdate.Click
        sql = "UPDATE tblsettings  SET DESCRIPTION= '" & txtCategory.Text & "' WHERE ID ='" & unitid & "'"
        updates(sql, txtUnit.Text, txtUnit.Text)
        sql = "SELECT ID, DESCRIPTION as 'Item Unit' FROM tblsettings WHERE PARA='Unit'"
        reloadDtg(sql, dtgulist)
        dtgulist.Columns(0).Visible = False
        txtUnit.Clear()
    End Sub

    Private Sub dtgulist_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgulist.DoubleClick
        txtUnit.Text = dtgulist.CurrentRow.Cells(1).Value
        unitid = dtgulist.CurrentRow.Cells(0).Value

        btnuupdate.Enabled = True
        btnudel.Enabled = True
        btnusave.Enabled = False
    End Sub

    Private Sub frm_settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtgtypelist.DefaultCellStyle.ForeColor = Color.Black
        dtgulist.DefaultCellStyle.ForeColor = Color.Black

        btncupdate.Enabled = False
        btncdel.Enabled = False
        btnuupdate.Enabled = False
        btnudel.Enabled = False
    End Sub

    Private Sub btncdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncdel.Click
        sql = "DELETE FROM `tblautonumber` WHERE `ID`='" & dtgtypelist.CurrentRow.Cells(0).Value & "'"
        createNoMsg(sql)
        sql = "DELETE FROM `tblsettings` WHERE `ID`='" & dtgtypelist.CurrentRow.Cells(0).Value & "'"
        deletes(sql, txtCategory.Text, txtCategory.Text)
    End Sub

    Private Sub btnudel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnudel.Click
        sql = "DELETE FROM `tblsettings` WHERE `ID`='" & dtgulist.CurrentRow.Cells(0).Value & "'"
        deletes(sql, txtCategory.Text, txtCategory.Text)
    End Sub

    Private Sub btncnew_Click(sender As Object, e As EventArgs) Handles btncnew.Click
        txtCategory.Clear()

        btncupdate.Enabled = False
        btncdel.Enabled = False
        btncsave.Enabled = True
    End Sub

    Private Sub btnunew_Click(sender As Object, e As EventArgs) Handles btnunew.Click
        txtUnit.Clear()

        btnuupdate.Enabled = False
        btnudel.Enabled = False
        btnusave.Enabled = True
    End Sub
End Class