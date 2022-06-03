Public Class frmview_stockout
    Private Sub frmview_stockout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT  `TRANSACTIONNUMBER`,concat(`FIRSTNAME`, `LASTNAME`) as 'SUPLIER',`NAME` as 'ITEMNAME', `DESCRIPTION`, `PRICE` , `TRANSACTIONDATE`, o.`QTY`, `TOTALPRICE` FROM tblperson p, tblstock_in_out o, tblitems i WHERE REMARKS='StockOut' AND i.`ITEMID`=o.`ITEMID` and p.`SUPLIERCUSTOMERID`=o.`SUPLIERCUSTOMERID` and p.TYPE = 'Customer'"
        reloadDtg(sql, dtglist)
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        sql = "SELECT  `TRANSACTIONNUMBER`,concat(`FIRSTNAME`, `LASTNAME`) as 'SUPLIER',`NAME` as 'ITEMNAME', `DESCRIPTION`, `PRICE`, `TRANSACTIONDATE`, o.`QTY`, `TOTALPRICE` FROM tblperson p, tblstock_in_out o, tblitems i WHERE REMARKS='StockOut' AND i.`ITEMID`=o.`ITEMID` and p.`SUPLIERCUSTOMERID`=o.`SUPLIERCUSTOMERID` and p.TYPE = 'Customer'" &
        " AND (NAME like '%" & txtsearch.Text & "%' OR  TRANSACTIONNUMBER like '%" & txtsearch.Text & "%')"
        reloadDtg(sql, dtglist)
    End Sub

    Private Sub dtglist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtglist.CellContentClick

    End Sub
End Class