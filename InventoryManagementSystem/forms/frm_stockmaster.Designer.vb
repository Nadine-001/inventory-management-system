<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_StockMaster
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_StockMaster))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblinc = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnlast = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnprev = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnfirst = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.lblmax = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtglist = New System.Windows.Forms.DataGridView()
        Me.txtitemid = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbounit = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.cbotype = New System.Windows.Forms.ComboBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnl_stockmaster = New System.Windows.Forms.Panel()
        Me.txtdescription = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        CType(Me.dtglist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_stockmaster.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(422, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 30)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(326, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Search :"
        '
        'lblinc
        '
        Me.lblinc.AutoSize = True
        Me.lblinc.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinc.Location = New System.Drawing.Point(10, 241)
        Me.lblinc.Name = "lblinc"
        Me.lblinc.Size = New System.Drawing.Size(14, 16)
        Me.lblinc.TabIndex = 26
        Me.lblinc.Text = "1"
        '
        'txtsearch
        '
        Me.txtsearch.BackColor = System.Drawing.Color.LightBlue
        Me.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsearch.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtsearch.ForeColor = System.Drawing.Color.Black
        Me.txtsearch.Location = New System.Drawing.Point(381, 239)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(185, 23)
        Me.txtsearch.TabIndex = 13
        '
        'btnnew
        '
        Me.btnnew.BackColor = System.Drawing.Color.Transparent
        Me.btnnew.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnnew.ForeColor = System.Drawing.Color.Black
        Me.btnnew.Location = New System.Drawing.Point(343, 173)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(73, 30)
        Me.btnnew.TabIndex = 17
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(26, 241)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 16)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "of"
        '
        'btnlast
        '
        Me.btnlast.BackColor = System.Drawing.Color.Transparent
        Me.btnlast.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.btnlast.ForeColor = System.Drawing.Color.Black
        Me.btnlast.Location = New System.Drawing.Point(220, 234)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(39, 30)
        Me.btnlast.TabIndex = 22
        Me.btnlast.Text = ">>"
        Me.btnlast.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.Transparent
        Me.btndelete.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btndelete.ForeColor = System.Drawing.Color.Black
        Me.btndelete.Location = New System.Drawing.Point(264, 173)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(73, 30)
        Me.btndelete.TabIndex = 18
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.Color.Transparent
        Me.btnnext.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.btnnext.ForeColor = System.Drawing.Color.Black
        Me.btnnext.Location = New System.Drawing.Point(172, 234)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(39, 30)
        Me.btnnext.TabIndex = 23
        Me.btnnext.Text = ">"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'btnprev
        '
        Me.btnprev.BackColor = System.Drawing.Color.Transparent
        Me.btnprev.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.btnprev.ForeColor = System.Drawing.Color.Black
        Me.btnprev.Location = New System.Drawing.Point(126, 234)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(39, 30)
        Me.btnprev.TabIndex = 24
        Me.btnprev.Text = "<"
        Me.btnprev.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.Transparent
        Me.btnupdate.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnupdate.ForeColor = System.Drawing.Color.Black
        Me.btnupdate.Location = New System.Drawing.Point(184, 173)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(74, 30)
        Me.btnupdate.TabIndex = 19
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btnfirst
        '
        Me.btnfirst.BackColor = System.Drawing.Color.Transparent
        Me.btnfirst.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.btnfirst.ForeColor = System.Drawing.Color.Black
        Me.btnfirst.Location = New System.Drawing.Point(81, 234)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.Size = New System.Drawing.Size(39, 30)
        Me.btnfirst.TabIndex = 25
        Me.btnfirst.Text = "<<"
        Me.btnfirst.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.Transparent
        Me.btnsave.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnsave.ForeColor = System.Drawing.Color.Black
        Me.btnsave.Location = New System.Drawing.Point(104, 173)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(74, 30)
        Me.btnsave.TabIndex = 20
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(344, 55)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(142, 25)
        Me.btnadd.TabIndex = 2
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'lblmax
        '
        Me.lblmax.AutoSize = True
        Me.lblmax.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmax.Location = New System.Drawing.Point(51, 241)
        Me.lblmax.Name = "lblmax"
        Me.lblmax.Size = New System.Drawing.Size(14, 16)
        Me.lblmax.TabIndex = 27
        Me.lblmax.Text = "1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Controls.Add(Me.dtglist)
        Me.Panel2.Controls.Add(Me.btnadd)
        Me.Panel2.Location = New System.Drawing.Point(0, 277)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(747, 291)
        Me.Panel2.TabIndex = 16
        '
        'dtglist
        '
        Me.dtglist.AllowUserToAddRows = False
        Me.dtglist.AllowUserToDeleteRows = False
        Me.dtglist.AllowUserToResizeColumns = False
        Me.dtglist.AllowUserToResizeRows = False
        Me.dtglist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtglist.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dtglist.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtglist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtglist.Location = New System.Drawing.Point(0, 0)
        Me.dtglist.Name = "dtglist"
        Me.dtglist.Size = New System.Drawing.Size(604, 291)
        Me.dtglist.TabIndex = 0
        '
        'txtitemid
        '
        Me.txtitemid.BackColor = System.Drawing.Color.LightBlue
        Me.txtitemid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtitemid.Enabled = False
        Me.txtitemid.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtitemid.ForeColor = System.Drawing.Color.Black
        Me.txtitemid.Location = New System.Drawing.Point(112, 64)
        Me.txtitemid.Name = "txtitemid"
        Me.txtitemid.Size = New System.Drawing.Size(185, 23)
        Me.txtitemid.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(58, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Item ID :"
        '
        'cbounit
        '
        Me.cbounit.BackColor = System.Drawing.Color.LightBlue
        Me.cbounit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbounit.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold)
        Me.cbounit.ForeColor = System.Drawing.Color.Black
        Me.cbounit.FormattingEnabled = True
        Me.cbounit.Items.AddRange(New Object() {"pcs.", "box"})
        Me.cbounit.Location = New System.Drawing.Point(475, 122)
        Me.cbounit.Name = "cbounit"
        Me.cbounit.Size = New System.Drawing.Size(91, 24)
        Me.cbounit.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(318, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Quantity :"
        '
        'txtqty
        '
        Me.txtqty.BackColor = System.Drawing.Color.LightBlue
        Me.txtqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtqty.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtqty.ForeColor = System.Drawing.Color.Black
        Me.txtqty.Location = New System.Drawing.Point(381, 122)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(88, 23)
        Me.txtqty.TabIndex = 4
        '
        'cbotype
        '
        Me.cbotype.BackColor = System.Drawing.Color.LightBlue
        Me.cbotype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbotype.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold)
        Me.cbotype.ForeColor = System.Drawing.Color.Black
        Me.cbotype.FormattingEnabled = True
        Me.cbotype.Location = New System.Drawing.Point(381, 64)
        Me.cbotype.Name = "cbotype"
        Me.cbotype.Size = New System.Drawing.Size(185, 24)
        Me.cbotype.TabIndex = 2
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.LightBlue
        Me.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtname.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtname.ForeColor = System.Drawing.Color.Black
        Me.txtname.Location = New System.Drawing.Point(111, 93)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(186, 23)
        Me.txtname.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(338, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Price :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(315, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Category :"
        '
        'txtprice
        '
        Me.txtprice.BackColor = System.Drawing.Color.LightBlue
        Me.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtprice.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtprice.ForeColor = System.Drawing.Color.Black
        Me.txtprice.Location = New System.Drawing.Point(381, 93)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(185, 23)
        Me.txtprice.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(32, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Description :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(39, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Item Name :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.CadetBlue
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(4, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 32)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Add New Item"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl_stockmaster
        '
        Me.pnl_stockmaster.BackColor = System.Drawing.Color.CadetBlue
        Me.pnl_stockmaster.Controls.Add(Me.Button1)
        Me.pnl_stockmaster.Controls.Add(Me.txtdescription)
        Me.pnl_stockmaster.Controls.Add(Me.txtitemid)
        Me.pnl_stockmaster.Controls.Add(Me.Label8)
        Me.pnl_stockmaster.Controls.Add(Me.btnnew)
        Me.pnl_stockmaster.Controls.Add(Me.cbounit)
        Me.pnl_stockmaster.Controls.Add(Me.Label7)
        Me.pnl_stockmaster.Controls.Add(Me.txtqty)
        Me.pnl_stockmaster.Controls.Add(Me.btndelete)
        Me.pnl_stockmaster.Controls.Add(Me.cbotype)
        Me.pnl_stockmaster.Controls.Add(Me.txtname)
        Me.pnl_stockmaster.Controls.Add(Me.Label4)
        Me.pnl_stockmaster.Controls.Add(Me.btnupdate)
        Me.pnl_stockmaster.Controls.Add(Me.Label3)
        Me.pnl_stockmaster.Controls.Add(Me.txtprice)
        Me.pnl_stockmaster.Controls.Add(Me.btnsave)
        Me.pnl_stockmaster.Controls.Add(Me.Label2)
        Me.pnl_stockmaster.Controls.Add(Me.Label1)
        Me.pnl_stockmaster.Controls.Add(Me.Label5)
        Me.pnl_stockmaster.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_stockmaster.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_stockmaster.Location = New System.Drawing.Point(0, 0)
        Me.pnl_stockmaster.Name = "pnl_stockmaster"
        Me.pnl_stockmaster.Size = New System.Drawing.Size(604, 220)
        Me.pnl_stockmaster.TabIndex = 14
        '
        'txtdescription
        '
        Me.txtdescription.BackColor = System.Drawing.Color.LightBlue
        Me.txtdescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescription.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtdescription.ForeColor = System.Drawing.Color.Black
        Me.txtdescription.Location = New System.Drawing.Point(111, 123)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(186, 23)
        Me.txtdescription.TabIndex = 9
        '
        'frm_StockMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(604, 568)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblinc)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnlast)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnprev)
        Me.Controls.Add(Me.btnfirst)
        Me.Controls.Add(Me.lblmax)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnl_stockmaster)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_StockMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Master"
        Me.Panel2.ResumeLayout(False)
        CType(Me.dtglist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_stockmaster.ResumeLayout(False)
        Me.pnl_stockmaster.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lblinc As Label
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents btnnew As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents btnlast As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnnext As Button
    Friend WithEvents btnprev As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnfirst As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents lblmax As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtitemid As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbounit As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtqty As TextBox
    Friend WithEvents cbotype As ComboBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtprice As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pnl_stockmaster As Panel
    Friend WithEvents dtglist As DataGridView
    Friend WithEvents txtdescription As TextBox
End Class
