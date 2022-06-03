<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_report))
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnitemlisat = New System.Windows.Forms.Button()
        Me.cbooption = New System.Windows.Forms.ComboBox()
        Me.btnListStockin = New System.Windows.Forms.Button()
        Me.btnStockOut = New System.Windows.Forms.Button()
        Me.btnStockReturn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpto = New System.Windows.Forms.DateTimePicker()
        Me.dptfrom = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.AutoScroll = True
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(164, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowGotoPageButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowLogo = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(967, 593)
        Me.CrystalReportViewer1.TabIndex = 3
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(164, 593)
        Me.Panel1.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnitemlisat)
        Me.GroupBox2.Controls.Add(Me.cbooption)
        Me.GroupBox2.Controls.Add(Me.btnListStockin)
        Me.GroupBox2.Controls.Add(Me.btnStockOut)
        Me.GroupBox2.Controls.Add(Me.btnStockReturn)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 10.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(146, 210)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Report Type"
        '
        'btnitemlisat
        '
        Me.btnitemlisat.BackColor = System.Drawing.Color.Transparent
        Me.btnitemlisat.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnitemlisat.ForeColor = System.Drawing.Color.Black
        Me.btnitemlisat.Location = New System.Drawing.Point(9, 28)
        Me.btnitemlisat.Name = "btnitemlisat"
        Me.btnitemlisat.Size = New System.Drawing.Size(124, 30)
        Me.btnitemlisat.TabIndex = 3
        Me.btnitemlisat.Text = "Item List"
        Me.btnitemlisat.UseVisualStyleBackColor = False
        '
        'cbooption
        '
        Me.cbooption.BackColor = System.Drawing.Color.LightBlue
        Me.cbooption.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbooption.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold)
        Me.cbooption.FormattingEnabled = True
        Me.cbooption.Items.AddRange(New Object() {"Daily Report", "Weekly Report", "Monthly Report"})
        Me.cbooption.Location = New System.Drawing.Point(9, 64)
        Me.cbooption.Name = "cbooption"
        Me.cbooption.Size = New System.Drawing.Size(124, 24)
        Me.cbooption.TabIndex = 2
        Me.cbooption.Text = "--Select--"
        '
        'btnListStockin
        '
        Me.btnListStockin.BackColor = System.Drawing.Color.Transparent
        Me.btnListStockin.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnListStockin.ForeColor = System.Drawing.Color.Black
        Me.btnListStockin.Location = New System.Drawing.Point(9, 93)
        Me.btnListStockin.Name = "btnListStockin"
        Me.btnListStockin.Size = New System.Drawing.Size(124, 30)
        Me.btnListStockin.TabIndex = 0
        Me.btnListStockin.Text = "Stock Items"
        Me.btnListStockin.UseVisualStyleBackColor = False
        '
        'btnStockOut
        '
        Me.btnStockOut.BackColor = System.Drawing.Color.Transparent
        Me.btnStockOut.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnStockOut.ForeColor = System.Drawing.Color.Black
        Me.btnStockOut.Location = New System.Drawing.Point(9, 129)
        Me.btnStockOut.Name = "btnStockOut"
        Me.btnStockOut.Size = New System.Drawing.Size(124, 30)
        Me.btnStockOut.TabIndex = 0
        Me.btnStockOut.Text = "Sold Items"
        Me.btnStockOut.UseVisualStyleBackColor = False
        '
        'btnStockReturn
        '
        Me.btnStockReturn.BackColor = System.Drawing.Color.Transparent
        Me.btnStockReturn.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnStockReturn.ForeColor = System.Drawing.Color.Black
        Me.btnStockReturn.Location = New System.Drawing.Point(9, 165)
        Me.btnStockReturn.Name = "btnStockReturn"
        Me.btnStockReturn.Size = New System.Drawing.Size(124, 30)
        Me.btnStockReturn.TabIndex = 0
        Me.btnStockReturn.Text = "Returned Items"
        Me.btnStockReturn.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpto)
        Me.GroupBox1.Controls.Add(Me.dptfrom)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 10.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 240)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 130)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Date Filter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(6, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "From"
        '
        'dtpto
        '
        Me.dtpto.CalendarMonthBackground = System.Drawing.Color.LightBlue
        Me.dtpto.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpto.Location = New System.Drawing.Point(7, 88)
        Me.dtpto.Name = "dtpto"
        Me.dtpto.Size = New System.Drawing.Size(131, 23)
        Me.dtpto.TabIndex = 2
        '
        'dptfrom
        '
        Me.dptfrom.CalendarMonthBackground = System.Drawing.Color.LightBlue
        Me.dptfrom.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.dptfrom.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dptfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dptfrom.Location = New System.Drawing.Point(7, 44)
        Me.dptfrom.Name = "dptfrom"
        Me.dptfrom.Size = New System.Drawing.Size(131, 23)
        Me.dptfrom.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"January", "February", "March ", "April", "June", "July", "August", "September", "October", "November", "December"})
        Me.ComboBox1.Location = New System.Drawing.Point(266, 77)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(124, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'frm_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1131, 593)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnitemlisat As Button
    Friend WithEvents cbooption As ComboBox
    Friend WithEvents btnListStockin As Button
    Friend WithEvents btnStockOut As Button
    Friend WithEvents btnStockReturn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpto As DateTimePicker
    Friend WithEvents dptfrom As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
End Class
