<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_setting
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_setting))
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.btnusave = New System.Windows.Forms.Button()
        Me.btncdel = New System.Windows.Forms.Button()
        Me.btncupdate = New System.Windows.Forms.Button()
        Me.btncload = New System.Windows.Forms.Button()
        Me.dtgtypelist = New System.Windows.Forms.DataGridView()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnuupdate = New System.Windows.Forms.Button()
        Me.btnuload = New System.Windows.Forms.Button()
        Me.dtgulist = New System.Windows.Forms.DataGridView()
        Me.btncsave = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnunew = New System.Windows.Forms.Button()
        Me.btnudel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btncnew = New System.Windows.Forms.Button()
        CType(Me.dtgtypelist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgulist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUnit
        '
        Me.txtUnit.BackColor = System.Drawing.Color.LightBlue
        Me.txtUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnit.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtUnit.ForeColor = System.Drawing.Color.Black
        Me.txtUnit.Location = New System.Drawing.Point(72, 28)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(122, 22)
        Me.txtUnit.TabIndex = 2
        '
        'btnusave
        '
        Me.btnusave.BackColor = System.Drawing.Color.Transparent
        Me.btnusave.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnusave.ForeColor = System.Drawing.Color.Black
        Me.btnusave.Location = New System.Drawing.Point(199, 54)
        Me.btnusave.Name = "btnusave"
        Me.btnusave.Size = New System.Drawing.Size(75, 23)
        Me.btnusave.TabIndex = 0
        Me.btnusave.Text = "Save"
        Me.btnusave.UseVisualStyleBackColor = False
        '
        'btncdel
        '
        Me.btncdel.BackColor = System.Drawing.Color.Transparent
        Me.btncdel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btncdel.ForeColor = System.Drawing.Color.Black
        Me.btncdel.Location = New System.Drawing.Point(199, 108)
        Me.btncdel.Name = "btncdel"
        Me.btncdel.Size = New System.Drawing.Size(75, 23)
        Me.btncdel.TabIndex = 6
        Me.btncdel.Text = "Delete"
        Me.btncdel.UseVisualStyleBackColor = False
        '
        'btncupdate
        '
        Me.btncupdate.BackColor = System.Drawing.Color.Transparent
        Me.btncupdate.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btncupdate.ForeColor = System.Drawing.Color.Black
        Me.btncupdate.Location = New System.Drawing.Point(199, 81)
        Me.btncupdate.Name = "btncupdate"
        Me.btncupdate.Size = New System.Drawing.Size(75, 23)
        Me.btncupdate.TabIndex = 5
        Me.btncupdate.Text = "Update"
        Me.btncupdate.UseVisualStyleBackColor = False
        '
        'btncload
        '
        Me.btncload.BackColor = System.Drawing.Color.Transparent
        Me.btncload.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btncload.ForeColor = System.Drawing.Color.Black
        Me.btncload.Location = New System.Drawing.Point(199, 135)
        Me.btncload.Name = "btncload"
        Me.btncload.Size = New System.Drawing.Size(75, 23)
        Me.btncload.TabIndex = 4
        Me.btncload.Text = "Load"
        Me.btncload.UseVisualStyleBackColor = False
        '
        'dtgtypelist
        '
        Me.dtgtypelist.AllowUserToAddRows = False
        Me.dtgtypelist.AllowUserToDeleteRows = False
        Me.dtgtypelist.AllowUserToResizeColumns = False
        Me.dtgtypelist.AllowUserToResizeRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dtgtypelist.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgtypelist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgtypelist.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dtgtypelist.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgtypelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgtypelist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgtypelist.Location = New System.Drawing.Point(6, 54)
        Me.dtgtypelist.Name = "dtgtypelist"
        Me.dtgtypelist.RowHeadersVisible = False
        Me.dtgtypelist.Size = New System.Drawing.Size(187, 312)
        Me.dtgtypelist.TabIndex = 3
        '
        'txtCategory
        '
        Me.txtCategory.BackColor = System.Drawing.Color.LightBlue
        Me.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCategory.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtCategory.ForeColor = System.Drawing.Color.Black
        Me.txtCategory.Location = New System.Drawing.Point(72, 28)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(121, 22)
        Me.txtCategory.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Category :"
        '
        'btnuupdate
        '
        Me.btnuupdate.BackColor = System.Drawing.Color.Transparent
        Me.btnuupdate.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnuupdate.ForeColor = System.Drawing.Color.Black
        Me.btnuupdate.Location = New System.Drawing.Point(199, 81)
        Me.btnuupdate.Name = "btnuupdate"
        Me.btnuupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnuupdate.TabIndex = 5
        Me.btnuupdate.Text = "Update"
        Me.btnuupdate.UseVisualStyleBackColor = False
        '
        'btnuload
        '
        Me.btnuload.BackColor = System.Drawing.Color.Transparent
        Me.btnuload.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnuload.ForeColor = System.Drawing.Color.Black
        Me.btnuload.Location = New System.Drawing.Point(199, 135)
        Me.btnuload.Name = "btnuload"
        Me.btnuload.Size = New System.Drawing.Size(75, 23)
        Me.btnuload.TabIndex = 4
        Me.btnuload.Text = "Load"
        Me.btnuload.UseVisualStyleBackColor = False
        '
        'dtgulist
        '
        Me.dtgulist.AllowUserToAddRows = False
        Me.dtgulist.AllowUserToDeleteRows = False
        Me.dtgulist.AllowUserToResizeColumns = False
        Me.dtgulist.AllowUserToResizeRows = False
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.dtgulist.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgulist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgulist.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dtgulist.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgulist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgulist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgulist.Location = New System.Drawing.Point(7, 54)
        Me.dtgulist.Name = "dtgulist"
        Me.dtgulist.RowHeadersVisible = False
        Me.dtgulist.Size = New System.Drawing.Size(187, 312)
        Me.dtgulist.TabIndex = 3
        '
        'btncsave
        '
        Me.btncsave.BackColor = System.Drawing.Color.Transparent
        Me.btncsave.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btncsave.ForeColor = System.Drawing.Color.Black
        Me.btncsave.Location = New System.Drawing.Point(199, 54)
        Me.btncsave.Name = "btncsave"
        Me.btncsave.Size = New System.Drawing.Size(75, 23)
        Me.btncsave.TabIndex = 0
        Me.btncsave.Text = "Save"
        Me.btncsave.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnunew)
        Me.GroupBox2.Controls.Add(Me.btnudel)
        Me.GroupBox2.Controls.Add(Me.btnuupdate)
        Me.GroupBox2.Controls.Add(Me.btnuload)
        Me.GroupBox2.Controls.Add(Me.dtgulist)
        Me.GroupBox2.Controls.Add(Me.txtUnit)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btnusave)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(297, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(280, 372)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add New Item Unit"
        '
        'btnunew
        '
        Me.btnunew.BackColor = System.Drawing.Color.Transparent
        Me.btnunew.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnunew.ForeColor = System.Drawing.Color.Black
        Me.btnunew.Location = New System.Drawing.Point(199, 27)
        Me.btnunew.Name = "btnunew"
        Me.btnunew.Size = New System.Drawing.Size(75, 23)
        Me.btnunew.TabIndex = 8
        Me.btnunew.Text = "New"
        Me.btnunew.UseVisualStyleBackColor = False
        '
        'btnudel
        '
        Me.btnudel.BackColor = System.Drawing.Color.Transparent
        Me.btnudel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnudel.ForeColor = System.Drawing.Color.Black
        Me.btnudel.Location = New System.Drawing.Point(199, 108)
        Me.btnudel.Name = "btnudel"
        Me.btnudel.Size = New System.Drawing.Size(75, 23)
        Me.btnudel.TabIndex = 7
        Me.btnudel.Text = "Delete"
        Me.btnudel.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Item Unit :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btncnew)
        Me.GroupBox1.Controls.Add(Me.btncdel)
        Me.GroupBox1.Controls.Add(Me.btncupdate)
        Me.GroupBox1.Controls.Add(Me.btncload)
        Me.GroupBox1.Controls.Add(Me.dtgtypelist)
        Me.GroupBox1.Controls.Add(Me.txtCategory)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btncsave)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(279, 372)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add New Category"
        '
        'btncnew
        '
        Me.btncnew.BackColor = System.Drawing.Color.Transparent
        Me.btncnew.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btncnew.ForeColor = System.Drawing.Color.Black
        Me.btncnew.Location = New System.Drawing.Point(199, 27)
        Me.btncnew.Name = "btncnew"
        Me.btncnew.Size = New System.Drawing.Size(75, 23)
        Me.btncnew.TabIndex = 7
        Me.btncnew.Text = "New"
        Me.btncnew.UseVisualStyleBackColor = False
        '
        'frm_setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(589, 394)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_setting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting"
        CType(Me.dtgtypelist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgulist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtUnit As TextBox
    Friend WithEvents btnusave As Button
    Friend WithEvents btncdel As Button
    Friend WithEvents btncupdate As Button
    Friend WithEvents btncload As Button
    Friend WithEvents dtgtypelist As DataGridView
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnuupdate As Button
    Friend WithEvents btnuload As Button
    Friend WithEvents dtgulist As DataGridView
    Friend WithEvents btncsave As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnudel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnunew As Button
    Friend WithEvents btncnew As Button
End Class
