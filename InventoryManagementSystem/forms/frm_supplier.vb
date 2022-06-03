Public Class frm_supplier
    Dim ID As String = 0
    Dim maxcolumn

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        sql = "INSERT INTO tblsuplier (`SUPLIERID`, `FIRSTNAME`, `LASTNAME`, `ADDRESS`, `TELEPHONE`, `MOBILE`, `TYPE`)" &
        " VALUES ('" & ID & "','" & txtfname.Text & "','" & txtlname.Text & "','" & txtaddress.Text & "','" & txttelephone.Text & "','" & txtmobile.Text & "','SUPLIER')"
        create(sql, txtfname.Text & " " & txtlname.Text, txtfname.Text & " " & txtlname.Text)

        sql = "SELECT * FROM tblsuplier"
        reloadDtg(sql, dtglist)

        cleartext(Panel1)

        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False
        dtglist.Columns(0).Visible = False

        createNoMsg("UPDATE tblautonumber SET END = END + INCREMENT WHERE ID =3")

        reloadtxt("SELECT CONCAT(STRT, END) FROM tblautonumber WHERE ID = 3")
        ID = dt.Rows(0).Item(0)
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        sql = "UPDATE tblsuplier SET  `FIRSTNAME`='" & txtfname.Text & "', `LASTNAME`='" & txtlname.Text &
        "', `ADDRESS`='" & txtaddress.Text & "', `TELEPHONE`='" & txttelephone.Text & "', `MOBILE`='" & txtmobile.Text & "' WHERE `SUPLIERID`='" & ID & "'"
        updates(sql, txtfname.Text & " " & txtlname.Text, txtfname.Text & " " & txtlname.Text)

        sql = "SELECT * FROM tblsuplier"
        reloadDtg(sql, dtglist)

        cleartext(Panel1)

        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False
        dtglist.Columns(0).Visible = False

        reloadtxt("SELECT CONCAT(STRT, END) FROM tblautonumber WHERE ID = 3")
        ID = dt.Rows(0).Item(0)
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        sql = "DELETE FROM tblsuplier WHERE `SUPLIERID`='" & dtglist.CurrentRow.Cells("SUPLIERID").Value & "'"
        deletes(sql, dtglist.CurrentRow.Cells("SUPLIERID").Value, dtglist.CurrentRow.Cells("SUPLIERID").Value)

        sql = "SELECT * FROM tblsuplier"
        reloadDtg(sql, dtglist)

        cleartext(Panel1)

        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False
        dtglist.Columns(0).Visible = False

        reloadtxt("SELECT CONCAT(STRT, END) FROM tblautonumber WHERE ID = 3")
        ID = dt.Rows(0).Item(0)
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        sql = "SELECT * FROM tblsuplier SUPLIERID LIKE '%" & txtsearch.Text & "%'"
        reloadDtg(sql, dtglist)

        cleartext(Panel1)

        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False
        dtglist.Columns(0).Visible = False

        reloadtxt("SELECT CONCAT(STRT, END) FROM tblautonumber WHERE ID = 3")
        ID = dt.Rows(0).Item(0)
    End Sub

    Private Sub frm_customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT * FROM tblsuplier"
        reloadDtg(sql, dtglist)

        cleartext(Panel1)

        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False
        dtglist.Columns(0).Visible = False

        reloadtxt("SELECT CONCAT(STRT, END) FROM tblautonumber WHERE ID = 3")
        ID = dt.Rows(0).Item(0)
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        sql = "SELECT * FROM tblsuplier WHERE TYPE='SUPLIER'"
        reloadDtg(sql, dtglist)

        cleartext(Panel1)

        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False
        dtglist.Columns(0).Visible = False

        reloadtxt("SELECT CONCAT(STRT, END) FROM tblautonumber WHERE ID = 3")
        ID = dt.Rows(0).Item(0)
    End Sub

    Private Sub dtglist_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtglist.DoubleClick
        Dim frmCollection = Application.OpenForms
        If frmCollection.OfType(Of frm_transaction).Any Then
            frm_transaction.txt_suplierId.Text = dtglist.CurrentRow.Cells(1).Value
            Me.Close()
        Else
            Try
                ID = dtglist.CurrentRow.Cells(1).Value
                reloadtxt("SELECT * FROM tblsuplier WHERE SUPLIERID ='" & dtglist.CurrentRow.Cells(1).Value & "'")
                txtfname.Text = dt.Rows(0).Item("FIRSTNAME")
                txtlname.Text = dt.Rows(0).Item("LASTNAME")
                txtaddress.Text = dt.Rows(0).Item("ADDRESS")
                txttelephone.Text = dt.Rows(0).Item("TELEPHONE")
                txtmobile.Text = dt.Rows(0).Item("MOBILE")
            Catch ex As Exception
                MsgBox("Invalid request.", MsgBoxStyle.Exclamation, "Inventory Management System")
            End Try
        End If
    End Sub
End Class