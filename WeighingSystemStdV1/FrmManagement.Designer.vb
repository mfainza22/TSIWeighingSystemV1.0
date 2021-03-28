<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManagement
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmManagement))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblRecord = New System.Windows.Forms.Label()
        Me.Col_Desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlList = New System.Windows.Forms.Panel()
        Me.Dg = New System.Windows.Forms.DataGridView()
        Me.Col_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_DateTimeIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_DateTimeOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_PlateNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Client = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Comm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Pricing = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Gross = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Tare = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Net = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Dr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_TktNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Driver = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Weigher = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_WeigherOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pnl_Weight = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CboSearchBy = New System.Windows.Forms.ComboBox()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.BtnGen = New MykeCtrlEx.PushButton()
        Me.DTto = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.RdoOutbound = New System.Windows.Forms.RadioButton()
        Me.RdoInbound = New System.Windows.Forms.RadioButton()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlHeader = New System.Windows.Forms.Panel()
        Me.BtnDelete = New MykeCtrlEx.PushButton()
        Me.BtnExit = New MykeCtrlEx.PushButton()
        Me.BtnView = New MykeCtrlEx.PushButton()
        Me.BtnPrint = New MykeCtrlEx.PushButton()
        Me.Panel1.SuspendLayout()
        Me.PnlMain.SuspendLayout()
        Me.PnlList.SuspendLayout()
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_Weight.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 15)
        Me.Label1.TabIndex = 163
        Me.Label1.Text = "Number of records found:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.WeighingSystemV1_1.My.Resources.Resources.WhiteHeader3
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LblRecord)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 466)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1354, 35)
        Me.Panel1.TabIndex = 3
        '
        'LblRecord
        '
        Me.LblRecord.AutoSize = True
        Me.LblRecord.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRecord.Location = New System.Drawing.Point(147, 1)
        Me.LblRecord.Name = "LblRecord"
        Me.LblRecord.Size = New System.Drawing.Size(30, 36)
        Me.LblRecord.TabIndex = 164
        Me.LblRecord.Text = "0"
        '
        'Col_Desc
        '
        Me.Col_Desc.HeaderText = "Description"
        Me.Col_Desc.MaxInputLength = 35
        Me.Col_Desc.Name = "Col_Desc"
        Me.Col_Desc.Width = 300
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.Transparent
        Me.PnlMain.Controls.Add(Me.PnlList)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 87)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Padding = New System.Windows.Forms.Padding(5)
        Me.PnlMain.Size = New System.Drawing.Size(1366, 513)
        Me.PnlMain.TabIndex = 2
        '
        'PnlList
        '
        Me.PnlList.BackColor = System.Drawing.Color.Transparent
        Me.PnlList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlList.Controls.Add(Me.Dg)
        Me.PnlList.Controls.Add(Me.Pnl_Weight)
        Me.PnlList.Controls.Add(Me.Panel4)
        Me.PnlList.Controls.Add(Me.Panel1)
        Me.PnlList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlList.Location = New System.Drawing.Point(5, 5)
        Me.PnlList.Name = "PnlList"
        Me.PnlList.Size = New System.Drawing.Size(1356, 503)
        Me.PnlList.TabIndex = 1
        '
        'Dg
        '
        Me.Dg.AllowUserToAddRows = False
        Me.Dg.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dg.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dg.BackgroundColor = System.Drawing.Color.White
        Me.Dg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dg.ColumnHeadersHeight = 30
        Me.Dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_Id, Me.Col_DateTimeIn, Me.Col_DateTimeOut, Me.Col_PlateNo, Me.Col_Client, Me.Col_Comm, Me.Col_Pricing, Me.Col_Gross, Me.Col_Tare, Me.Col_Net, Me.Col_Dr, Me.Col_TktNO, Me.Col_Driver, Me.Col_remarks, Me.Col_Weigher, Me.Col_WeigherOut})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dg.DefaultCellStyle = DataGridViewCellStyle3
        Me.Dg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.Dg.GridColor = System.Drawing.Color.Aqua
        Me.Dg.Location = New System.Drawing.Point(0, 101)
        Me.Dg.MultiSelect = False
        Me.Dg.Name = "Dg"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Aqua
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Dg.RowHeadersVisible = False
        Me.Dg.RowHeadersWidth = 20
        Me.Dg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Aqua
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DimGray
        Me.Dg.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.Dg.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dg.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DimGray
        Me.Dg.RowTemplate.Height = 24
        Me.Dg.RowTemplate.ReadOnly = True
        Me.Dg.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg.Size = New System.Drawing.Size(1354, 365)
        Me.Dg.StandardTab = True
        Me.Dg.TabIndex = 249
        '
        'Col_Id
        '
        Me.Col_Id.HeaderText = "Ref. No."
        Me.Col_Id.MaxInputLength = 0
        Me.Col_Id.MinimumWidth = 120
        Me.Col_Id.Name = "Col_Id"
        Me.Col_Id.ReadOnly = True
        Me.Col_Id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Col_Id.Width = 120
        '
        'Col_DateTimeIn
        '
        Me.Col_DateTimeIn.HeaderText = "Date & Time In"
        Me.Col_DateTimeIn.MaxInputLength = 35
        Me.Col_DateTimeIn.Name = "Col_DateTimeIn"
        Me.Col_DateTimeIn.Width = 150
        '
        'Col_DateTimeOut
        '
        Me.Col_DateTimeOut.HeaderText = "Date & Time Out"
        Me.Col_DateTimeOut.Name = "Col_DateTimeOut"
        Me.Col_DateTimeOut.Width = 150
        '
        'Col_PlateNo
        '
        Me.Col_PlateNo.HeaderText = "Plate Number"
        Me.Col_PlateNo.Name = "Col_PlateNo"
        '
        'Col_Client
        '
        Me.Col_Client.HeaderText = "Supplier/Customer Name"
        Me.Col_Client.Name = "Col_Client"
        Me.Col_Client.Width = 200
        '
        'Col_Comm
        '
        Me.Col_Comm.HeaderText = "Commodity/Materials"
        Me.Col_Comm.Name = "Col_Comm"
        Me.Col_Comm.Width = 140
        '
        'Col_Pricing
        '
        Me.Col_Pricing.HeaderText = "Price"
        Me.Col_Pricing.Name = "Col_Pricing"
        Me.Col_Pricing.Visible = False
        '
        'Col_Gross
        '
        Me.Col_Gross.HeaderText = "Gross Wt."
        Me.Col_Gross.Name = "Col_Gross"
        '
        'Col_Tare
        '
        Me.Col_Tare.HeaderText = "Tare Wt."
        Me.Col_Tare.Name = "Col_Tare"
        '
        'Col_Net
        '
        Me.Col_Net.HeaderText = "Net Wt."
        Me.Col_Net.Name = "Col_Net"
        '
        'Col_Dr
        '
        Me.Col_Dr.HeaderText = "Dr No."
        Me.Col_Dr.MinimumWidth = 120
        Me.Col_Dr.Name = "Col_Dr"
        Me.Col_Dr.Width = 120
        '
        'Col_TktNO
        '
        Me.Col_TktNO.HeaderText = "Ticket No."
        Me.Col_TktNO.MinimumWidth = 120
        Me.Col_TktNO.Name = "Col_TktNO"
        Me.Col_TktNO.Width = 120
        '
        'Col_Driver
        '
        Me.Col_Driver.HeaderText = "Driver"
        Me.Col_Driver.Name = "Col_Driver"
        Me.Col_Driver.Width = 180
        '
        'Col_remarks
        '
        Me.Col_remarks.HeaderText = "Remarks"
        Me.Col_remarks.Name = "Col_remarks"
        '
        'Col_Weigher
        '
        Me.Col_Weigher.HeaderText = "Weighed in by"
        Me.Col_Weigher.Name = "Col_Weigher"
        Me.Col_Weigher.Width = 180
        '
        'Col_WeigherOut
        '
        Me.Col_WeigherOut.HeaderText = "Weighed Out By"
        Me.Col_WeigherOut.Name = "Col_WeigherOut"
        Me.Col_WeigherOut.Width = 180
        '
        'Pnl_Weight
        '
        Me.Pnl_Weight.BackColor = System.Drawing.Color.Transparent
        Me.Pnl_Weight.Controls.Add(Me.Panel2)
        Me.Pnl_Weight.Controls.Add(Me.BtnGen)
        Me.Pnl_Weight.Controls.Add(Me.DTto)
        Me.Pnl_Weight.Controls.Add(Me.Label3)
        Me.Pnl_Weight.Controls.Add(Me.DTFrom)
        Me.Pnl_Weight.Controls.Add(Me.Label2)
        Me.Pnl_Weight.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl_Weight.Location = New System.Drawing.Point(0, 31)
        Me.Pnl_Weight.Name = "Pnl_Weight"
        Me.Pnl_Weight.Size = New System.Drawing.Size(1354, 70)
        Me.Pnl_Weight.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.CboSearchBy)
        Me.Panel2.Controls.Add(Me.TxtSearch)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(957, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(397, 70)
        Me.Panel2.TabIndex = 241
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(2, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 240
        Me.Label4.Text = "Search By:"
        '
        'CboSearchBy
        '
        Me.CboSearchBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboSearchBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboSearchBy.BackColor = System.Drawing.Color.White
        Me.CboSearchBy.DropDownHeight = 150
        Me.CboSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSearchBy.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSearchBy.FormattingEnabled = True
        Me.CboSearchBy.IntegralHeight = False
        Me.CboSearchBy.Items.AddRange(New Object() {"PLATE NUMBER", "REFERENCE NO.", "SUPPLIER NAME"})
        Me.CboSearchBy.Location = New System.Drawing.Point(5, 37)
        Me.CboSearchBy.MaxLength = 50
        Me.CboSearchBy.Name = "CboSearchBy"
        Me.CboSearchBy.Size = New System.Drawing.Size(190, 27)
        Me.CboSearchBy.Sorted = True
        Me.CboSearchBy.TabIndex = 165
        '
        'TxtSearch
        '
        Me.TxtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSearch.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.Location = New System.Drawing.Point(201, 37)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(190, 26)
        Me.TxtSearch.TabIndex = 163
        '
        'BtnGen
        '
        Me.BtnGen.BackgroundImage = CType(resources.GetObject("BtnGen.BackgroundImage"), System.Drawing.Image)
        Me.BtnGen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGen.FlatAppearance.BorderSize = 0
        Me.BtnGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGen.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGen.ForeColor = System.Drawing.Color.Black
        Me.BtnGen.GUI_ACCSS = "JMoiakne122208"
        Me.BtnGen.GUI_ENABLE_HOVER = True
        Me.BtnGen.GUI_ENABLED = True
        Me.BtnGen.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnGen.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnGen.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnGen.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnGen.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnGen.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGen.Location = New System.Drawing.Point(350, 33)
        Me.BtnGen.Name = "BtnGen"
        Me.BtnGen.Size = New System.Drawing.Size(95, 26)
        Me.BtnGen.TabIndex = 240
        Me.BtnGen.Text = "GENERATE"
        Me.BtnGen.UseVisualStyleBackColor = True
        '
        'DTto
        '
        Me.DTto.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTto.Location = New System.Drawing.Point(215, 34)
        Me.DTto.Name = "DTto"
        Me.DTto.Size = New System.Drawing.Size(129, 26)
        Me.DTto.TabIndex = 237
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(187, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 15)
        Me.Label3.TabIndex = 239
        Me.Label3.Text = "To:"
        '
        'DTFrom
        '
        Me.DTFrom.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTFrom.Location = New System.Drawing.Point(49, 34)
        Me.DTFrom.Name = "DTFrom"
        Me.DTFrom.Size = New System.Drawing.Size(135, 26)
        Me.DTFrom.TabIndex = 236
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(5, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 15)
        Me.Label2.TabIndex = 238
        Me.Label2.Text = "From:"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.RdoOutbound)
        Me.Panel4.Controls.Add(Me.RdoInbound)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1354, 31)
        Me.Panel4.TabIndex = 248
        '
        'RdoOutbound
        '
        Me.RdoOutbound.Appearance = System.Windows.Forms.Appearance.Button
        Me.RdoOutbound.Dock = System.Windows.Forms.DockStyle.Left
        Me.RdoOutbound.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoOutbound.Location = New System.Drawing.Point(734, 0)
        Me.RdoOutbound.Name = "RdoOutbound"
        Me.RdoOutbound.Size = New System.Drawing.Size(617, 31)
        Me.RdoOutbound.TabIndex = 245
        Me.RdoOutbound.Text = "OUTBOUND TRANSACTION"
        Me.RdoOutbound.UseVisualStyleBackColor = True
        '
        'RdoInbound
        '
        Me.RdoInbound.Appearance = System.Windows.Forms.Appearance.Button
        Me.RdoInbound.Checked = True
        Me.RdoInbound.Dock = System.Windows.Forms.DockStyle.Left
        Me.RdoInbound.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoInbound.Location = New System.Drawing.Point(0, 0)
        Me.RdoInbound.Name = "RdoInbound"
        Me.RdoInbound.Size = New System.Drawing.Size(734, 31)
        Me.RdoInbound.TabIndex = 244
        Me.RdoInbound.TabStop = True
        Me.RdoInbound.Text = "INBOUND TRANSACTION"
        Me.RdoInbound.UseVisualStyleBackColor = True
        '
        'Code
        '
        Me.Code.HeaderText = "Material Code"
        Me.Code.MaxInputLength = 15
        Me.Code.Name = "Code"
        Me.Code.Width = 200
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.MaxInputLength = 0
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 2
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.Width = 2
        '
        'PnlHeader
        '
        Me.PnlHeader.BackColor = System.Drawing.Color.White
        Me.PnlHeader.BackgroundImage = Global.WeighingSystemV1_1.My.Resources.Resources.WhiteHeader1
        Me.PnlHeader.Controls.Add(Me.BtnDelete)
        Me.PnlHeader.Controls.Add(Me.BtnExit)
        Me.PnlHeader.Controls.Add(Me.BtnView)
        Me.PnlHeader.Controls.Add(Me.BtnPrint)
        Me.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.PnlHeader.Name = "PnlHeader"
        Me.PnlHeader.Size = New System.Drawing.Size(1366, 87)
        Me.PnlHeader.TabIndex = 3
        '
        'BtnDelete
        '
        Me.BtnDelete.BackgroundImage = CType(resources.GetObject("BtnDelete.BackgroundImage"), System.Drawing.Image)
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.Black
        Me.BtnDelete.GUI_ACCSS = "JMoiakne122208"
        Me.BtnDelete.GUI_ENABLE_HOVER = True
        Me.BtnDelete.GUI_ENABLED = True
        Me.BtnDelete.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnDelete.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Exit34
        Me.BtnDelete.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnDelete.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnDelete.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnDelete.Location = New System.Drawing.Point(123, 8)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.BtnDelete.Size = New System.Drawing.Size(110, 64)
        Me.BtnDelete.TabIndex = 2
        Me.BtnDelete.Text = "DEL REMOVE"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.BackgroundImage = CType(resources.GetObject("BtnExit.BackgroundImage"), System.Drawing.Image)
        Me.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.Black
        Me.BtnExit.GUI_ACCSS = "JMoiakne122208"
        Me.BtnExit.GUI_ENABLE_HOVER = True
        Me.BtnExit.GUI_ENABLED = True
        Me.BtnExit.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnExit.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Home32
        Me.BtnExit.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnExit.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnExit.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
        Me.BtnExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnExit.Location = New System.Drawing.Point(377, 8)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Padding = New System.Windows.Forms.Padding(5)
        Me.BtnExit.Size = New System.Drawing.Size(110, 64)
        Me.BtnExit.TabIndex = 7
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnView
        '
        Me.BtnView.BackgroundImage = CType(resources.GetObject("BtnView.BackgroundImage"), System.Drawing.Image)
        Me.BtnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnView.FlatAppearance.BorderSize = 0
        Me.BtnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnView.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnView.ForeColor = System.Drawing.Color.Black
        Me.BtnView.GUI_ACCSS = "JMoiakne122208"
        Me.BtnView.GUI_ENABLE_HOVER = True
        Me.BtnView.GUI_ENABLED = True
        Me.BtnView.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnView.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Edit24
        Me.BtnView.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnView.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnView.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnView.Image = CType(resources.GetObject("BtnView.Image"), System.Drawing.Image)
        Me.BtnView.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnView.Location = New System.Drawing.Point(7, 8)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.BtnView.Size = New System.Drawing.Size(110, 64)
        Me.BtnView.TabIndex = 0
        Me.BtnView.Text = "F1 VIEW DATA"
        Me.BtnView.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnView.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        Me.BtnPrint.BackgroundImage = CType(resources.GetObject("BtnPrint.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrint.FlatAppearance.BorderSize = 0
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrint.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.ForeColor = System.Drawing.Color.Black
        Me.BtnPrint.GUI_ACCSS = "JMoiakne122208"
        Me.BtnPrint.GUI_ENABLE_HOVER = True
        Me.BtnPrint.GUI_ENABLED = True
        Me.BtnPrint.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnPrint.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Printer24
        Me.BtnPrint.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnPrint.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnPrint.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPrint.Location = New System.Drawing.Point(239, 8)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.BtnPrint.Size = New System.Drawing.Size(132, 64)
        Me.BtnPrint.TabIndex = 6
        Me.BtnPrint.Text = "CTRL+P RE-PRINT SLIP"
        Me.BtnPrint.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'FrmManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BackgroundImage = Global.WeighingSystemV1_1.My.Resources.Resources.f
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 600)
        Me.Controls.Add(Me.PnlMain)
        Me.Controls.Add(Me.PnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmManagement"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTrans"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PnlMain.ResumeLayout(False)
        Me.PnlList.ResumeLayout(False)
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_Weight.ResumeLayout(False)
        Me.Pnl_Weight.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.PnlHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LblRecord As System.Windows.Forms.Label
    Friend WithEvents BtnDelete As MykeCtrlEx.PushButton
    Friend WithEvents Col_Desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnExit As MykeCtrlEx.PushButton
    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents PnlList As System.Windows.Forms.Panel
    Friend WithEvents Code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnView As MykeCtrlEx.PushButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnPrint As MykeCtrlEx.PushButton
    Friend WithEvents PnlHeader As System.Windows.Forms.Panel
    Friend WithEvents Pnl_Weight As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CboSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents BtnGen As MykeCtrlEx.PushButton
    Friend WithEvents DTto As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DTFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents RdoOutbound As System.Windows.Forms.RadioButton
    Friend WithEvents RdoInbound As System.Windows.Forms.RadioButton
    Friend WithEvents Dg As System.Windows.Forms.DataGridView
    Friend WithEvents Col_Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_DateTimeIn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_DateTimeOut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_PlateNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Client As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Comm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Pricing As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Gross As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Tare As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Net As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Dr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_TktNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Driver As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_remarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Weigher As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_WeigherOut As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
