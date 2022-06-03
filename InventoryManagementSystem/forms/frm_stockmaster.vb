Public Class frm_StockMaster
    Dim itemid As Integer
    Dim maxcolumn As Integer

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        For Each obj As Control In pnl_stockmaster.Controls
            If TypeOf obj Is TextBox Then
                If obj.Text = "" Then
                    MsgBox("Action can not be performed. All fields require to be filled up.", MsgBoxStyle.Exclamation, "Inventory Management System")
                    Exit Sub
                End If
            End If
            If TypeOf obj Is ComboBox Then
                If obj.Text = "--Select--" Or obj.Text = "" Then
                    MsgBox("Action can not be performed. All fields require to be filled up.", MsgBoxStyle.Exclamation, "Inventory Management System")
                    Exit Sub
                End If
            End If
        Next

        sql = "INSERT INTO  `tblstock_in_out` (`ITEMID`, `QTY`,`TRANSACTIONDATE`, `TOTALPRICE`, `REMARKS`)" &
           " VALUES ('" & txtitemid.Text & "','" & txtqty.Text & "','" & Format(Now, "yyyy-MM-dd") & "','" & txtprice.Text &
           "','StockIn')"
        createNoMsg(sql)

        sql = "SELECT ITEMID FROM tblitems WHERE ITEMID='" & txtitemid.Text & "'"
        reloadtxt(sql)

        If dt.Rows.Count > 0 Then
            sql = "UPDATE tblitems SET qty =qty + '" & txtqty.Text & "' WHERE ITEMID ='" & txtitemid.Text & "'"
            createNoMsg(sql)

            MsgBox(txtname.Text & " has been saved to the database.", MsgBoxStyle.OkOnly, "Inventory Management System")
        Else
            sql = "insert into tblitems  (ITEMID,`NAME`, `DESCRIPTION`, `TYPE`, `PRICE`, `QTY`,UNIT)" &
           "VALUES ('" & txtitemid.Text & "','" & txtname.Text & "','" & txtdescription.Text & "','" & cbotype.Text _
           & "','" & txtprice.Text & "','" & txtqty.Text & "','" & cbounit.Text & "' )"
            create(sql, txtname.Text, txtname.Text)
            updateautonumber(cbotype.Text)
        End If

        sql = "SELECT * FROM tblitems"
        reloadDtg(sql, dtglist)
        cleartext(pnl_stockmaster)
        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False
        dtgcolor(dtglist, 5)
    End Sub

    Private Sub frm_stockmaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnupdate.Enabled = False
        btndelete.Enabled = False

        sql = "SELECT * FROM tblitems"
        reloadDtg(sql, dtglist)
        dtgcolor(dtglist, 5)
        fillcbo("SELECT * FROM `tblsettings` WHERE `PARA`='CATEGORY'", cbotype)
        fillcbo("SELECT * FROM `tblsettings` WHERE `PARA`='Unit'", cbounit)
        cleartext(pnl_stockmaster)
        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False
        select_navigation("SELECT ITEMID FROM tblitems")
        lblmax.Text = maxrows
        lblinc.Text = inc
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            sql = "DELETE FROM tblitems WHERE ITEMID='" & dtglist.CurrentRow.Cells(0).Value & "'"
            deletes(sql, "Item", "Item")
            sql = "SELECT * FROM tblitems"
            reloadDtg(sql, dtglist)
            cleartext(pnl_stockmaster)
            maxcolumn = dtglist.Columns.Count - 1
            dtglist.Columns(maxcolumn).Visible = False
        Catch ex As Exception
            MsgBox("Invalid action.", MsgBoxStyle.Exclamation, "Inventory Management System")
        End Try
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        sql = "UPDATE tblitems SET `NAME`='" & txtname.Text & "', `DESCRIPTION`='" & txtdescription.Text & "', `TYPE`='" & cbotype.Text & "', `PRICE`='" & txtprice.Text &
            "' , `QTY`='" & txtqty.Text & "', `UNIT`='" & cbounit.Text & "' WHERE `ITEMID`='" & txtitemid.Text & "'"
        updates(sql, txtname.Text, txtname.Text)

        sql = "SELECT * FROM tblitems"
        reloadDtg(sql, dtglist)

        cleartext(pnl_stockmaster)
        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False
        dtgcolor(dtglist, 5)
    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        btndelete.Enabled = False
        btnupdate.Enabled = False
        btnsave.Enabled = True

        sql = "SELECT * FROM tblitems"
        reloadDtg(sql, dtglist)
        dtgcolor(dtglist, 5)
        cleartext(pnl_stockmaster)
        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False
    End Sub

    Private Sub dtglist_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtglist.DoubleClick
        Dim frmCollection = Application.OpenForms
        If frmCollection.OfType(Of frm_transaction).Any Then
            frm_transaction.txtSup_itemid.Text = dtglist.CurrentRow.Cells(0).Value
            Me.Close()
        Else
            Try
                sql = "SELECT * FROM tblitems WHERE ITEMID='" & dtglist.CurrentRow.Cells(0).Value & "'"
                reloadtxt(sql)
                txtitemid.Text = dt.Rows(0).Item("ITEMID")
                txtname.Text = dt.Rows(0).Item("NAME")
                txtdescription.Text = dt.Rows(0).Item("DESCRIPTION")
                txtprice.Text = dt.Rows(0).Item("PRICE")
                cbotype.Text = dt.Rows(0).Item("TYPE")
                txtqty.Text = dt.Rows(0).Item("QTY")
                cbounit.Text = dt.Rows(0).Item("UNIT")

                btnsave.Enabled = False
                btndelete.Enabled = True
                btnupdate.Enabled = True
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        sql = "SELECT * FROM tblitems WHERE ITEMID LIKE '%" & txtsearch.Text & "%' OR NAME LIKE '%" & txtsearch.Text & "%'"
        reloadDtg(sql, dtglist)
        cleartext(pnl_stockmaster)
        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False
        dtgcolor(dtglist, 5)
    End Sub

    Private Sub btnfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfirst.Click
        sql = "SELECT ITEMID FROM tblitems"
        select_navigation(sql)
        inc = 0
        lblinc.Text = inc + 1
        navagate_records(txtitemid)
    End Sub

    Private Sub btnprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprev.Click
        Try
            select_navigation("SELECT ITEMID FROM tblitems")
            If inc > 0 Then
                inc = inc - 1
                lblinc.Text = inc + 1
                navagate_records(txtitemid)
            Else
                If inc - 1 Then
                    MsgBox("First row", MsgBoxStyle.Information, "Inventory Management System")
                End If
            End If
        Catch ex As Exception
            'nothing
        End Try
    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        Try
            select_navigation("SELECT ITEMID FROM tblitems")
            If inc <> maxrows - 1 Then
                inc = inc + 1
                lblinc.Text = inc + 1
                navagate_records(txtitemid)
            Else
                If inc = maxrows - 1 Then
                    MsgBox("No more row", MsgBoxStyle.Information, "Inventory Management System")
                End If
            End If
        Catch ex As Exception
            'nothing
        End Try
    End Sub

    Private Sub btnlast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlast.Click
        Try
            select_navigation("SELECT ITEMID FROM tblitems")
            If inc <> maxrows - 1 Then
                inc = maxrows - 1
                lblinc.Text = inc + 1
                navagate_records(txtitemid)
            End If
        Catch ex As Exception
            'nothing
        End Try
    End Sub

    Private Sub txtitemid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtitemid.TextChanged
        Try
            sql = "SELECT * FROM tblitems WHERE ITEMID='" & txtitemid.Text & "'"
            reloadtxt(sql)
            If dt.Rows.Count > 0 Then
                txtname.Text = dt.Rows(0).Item(1)
                txtdescription.Text = dt.Rows(0).Item(2)
                txtprice.Text = dt.Rows(0).Item(4)
                cbotype.Text = dt.Rows(0).Item(3)
                txtqty.Text = dt.Rows(0).Item("QTY")
                cbounit.Text = dt.Rows(0).Item("UNIT")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub cbotype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbotype.SelectedIndexChanged
        Try
            sql = "SELECT * FROM tblitems WHERE ITEMID='" & txtitemid.Text & "'"
            reloadtxt(sql)
            If dt.Rows.Count > 0 Then
                txtname.Text = dt.Rows(0).Item(1)
            Else
                loadautonumber(cbotype.Text, txtitemid)
            End If
        Catch ex As Exception
            'nothing
        End Try
    End Sub
End Class