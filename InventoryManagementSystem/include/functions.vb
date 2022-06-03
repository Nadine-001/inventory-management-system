Module functions
    Public Sub cleartext(ByVal obj As Object)
        For Each ctrl As Control In obj.Controls
            If ctrl.GetType Is GetType(TextBox) Then
                ctrl.Text = Nothing
            End If
        Next
        For Each ctrl As Control In obj.Controls
            If ctrl.GetType Is GetType(RichTextBox) Then
                ctrl.Text = Nothing
            End If
        Next
        For Each ctrl As Control In obj.Controls
            If ctrl.GetType Is GetType(ComboBox) Then
                ctrl.Text = "--Select--"
            End If
        Next
    End Sub

    Public Sub dtgcolor(ByVal dtg As DataGridView, ByVal value As Integer)
        Try
            Dim rw As DataGridViewRow
            dtg.RowHeadersVisible = False
            dtg.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            For Each c As DataGridViewColumn In dtg.Columns
                c.SortMode = DataGridViewColumnSortMode.Programmatic
            Next

            For Each rw In dtg.Rows
                rw.DefaultCellStyle.ForeColor = Color.White
                rw.DefaultCellStyle.SelectionBackColor = Color.Yellow
                rw.DefaultCellStyle.SelectionForeColor = Color.Black

                If rw.Cells(value).Value <= 20 Then
                    rw.DefaultCellStyle.BackColor = Color.Red
                ElseIf rw.Cells(value).Value > 20 And rw.Cells(value).Value <= 50 Then
                    rw.DefaultCellStyle.BackColor = Color.Orange
                ElseIf rw.Cells(value).Value > 50 Then
                    rw.DefaultCellStyle.BackColor = Color.Green
                End If
            Next

        Catch ex As Exception
            'nothing
        End Try
    End Sub

    Public Sub enable_disable(result As Boolean)
        With Form1
            .ts_Customer.Enabled = result
            .ts_Transaction.Enabled = result
            .ts_StockMaster.Enabled = result
            .ts_Setting.Enabled = result
            .ts_ManageUser.Enabled = result
            .ts_Report.Enabled = result
            .ts_Supplier.Enabled = result
        End With
    End Sub
End Module
