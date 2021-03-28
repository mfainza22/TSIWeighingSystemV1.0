<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTrans
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTrans))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlDetails = New System.Windows.Forms.Panel()
        Me.PnlWeightStat = New System.Windows.Forms.Panel()
        Me.TxtReasons = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LblFinalNetUnit = New System.Windows.Forms.Label()
        Me.LblDedUnit = New System.Windows.Forms.Label()
        Me.TxtDeduct = New System.Windows.Forms.TextBox()
        Me.TxtFINAL = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtRefNo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtRemarks = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtDriver = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtPlateNo = New System.Windows.Forms.TextBox()
        Me.TxtTicketNo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtDrNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PnlClient = New System.Windows.Forms.Panel()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnAddCust = New MykeCtrlEx.PushButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RdoSup = New System.Windows.Forms.RadioButton()
        Me.CboClient = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RdoCust = New System.Windows.Forms.RadioButton()
        Me.PnlCommodity = New System.Windows.Forms.Panel()
        Me.LblPriceUnit = New System.Windows.Forms.Label()
        Me.CboCommodity = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAddComm = New MykeCtrlEx.PushButton()
        Me.TxtPrice = New System.Windows.Forms.TextBox()
        Me.LblPriceLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PnlList = New System.Windows.Forms.Panel()
        Me.Dg = New System.Windows.Forms.DataGridView()
        Me.Col_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_PlateNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_DateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_InboundWt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Client = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Comm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Pricing = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Dr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_TktNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Driver = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Weigher = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlSearch = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblRecord = New System.Windows.Forms.Label()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PnlHeader = New System.Windows.Forms.Panel()
        Me.LblError = New System.Windows.Forms.Label()
        Me.BtnPrintOut = New MykeCtrlEx.PushButton()
        Me.BtnDelete = New MykeCtrlEx.PushButton()
        Me.TxtGross = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DTPicker = New System.Windows.Forms.DateTimePicker()
        Me.Pnl_indicator = New System.Windows.Forms.Panel()
        Me.TxtOnline = New WeightDev.WeightIndicator()
        Me.TxtUnit = New System.Windows.Forms.TextBox()
        Me.TxtWeightType = New System.Windows.Forms.TextBox()
        Me.TxtOffline = New System.Windows.Forms.TextBox()
        Me.TxtDateTime = New System.Windows.Forms.TextBox()
        Me.BtnSetup = New MykeCtrlEx.PushButton()
        Me.BtnExit = New MykeCtrlEx.PushButton()
        Me.BtnIn = New MykeCtrlEx.PushButton()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.BtnPrintIN = New MykeCtrlEx.PushButton()
        Me.BtnOUt = New MykeCtrlEx.PushButton()
        Me.Btncancel = New MykeCtrlEx.PushButton()
        Me.Btnsave = New MykeCtrlEx.PushButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtNet = New System.Windows.Forms.TextBox()
        Me.TxtTare = New System.Windows.Forms.TextBox()
        Me.PnlMain.SuspendLayout()
        Me.PnlDetails.SuspendLayout()
        Me.PnlWeightStat.SuspendLayout()
        Me.PnlClient.SuspendLayout()
        Me.PnlCommodity.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PnlList.SuspendLayout()
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlSearch.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PnlHeader.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Pnl_indicator.SuspendLayout()
        Me.SuspendLayout()
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
        'Code
        '
        Me.Code.HeaderText = "Material Code"
        Me.Code.MaxInputLength = 15
        Me.Code.MinimumWidth = 6
        Me.Code.Name = "Code"
        Me.Code.Width = 200
        '
        'Col_Desc
        '
        Me.Col_Desc.HeaderText = "Description"
        Me.Col_Desc.MaxInputLength = 35
        Me.Col_Desc.MinimumWidth = 6
        Me.Col_Desc.Name = "Col_Desc"
        Me.Col_Desc.Width = 300
        '
        'PnlMain
        '
        Me.PnlMain.BackColor = System.Drawing.Color.White
        Me.PnlMain.BackgroundImage = CType(resources.GetObject("PnlMain.BackgroundImage"), System.Drawing.Image)
        Me.PnlMain.Controls.Add(Me.PnlDetails)
        Me.PnlMain.Controls.Add(Me.Panel1)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 166)
        Me.PnlMain.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.PnlMain.Size = New System.Drawing.Size(1821, 728)
        Me.PnlMain.TabIndex = 0
        '
        'PnlDetails
        '
        Me.PnlDetails.AutoScroll = True
        Me.PnlDetails.BackColor = System.Drawing.Color.Transparent
        Me.PnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlDetails.Controls.Add(Me.PnlWeightStat)
        Me.PnlDetails.Controls.Add(Me.TxtRefNo)
        Me.PnlDetails.Controls.Add(Me.Label9)
        Me.PnlDetails.Controls.Add(Me.TxtRemarks)
        Me.PnlDetails.Controls.Add(Me.Label12)
        Me.PnlDetails.Controls.Add(Me.TxtDriver)
        Me.PnlDetails.Controls.Add(Me.Label11)
        Me.PnlDetails.Controls.Add(Me.TxtPlateNo)
        Me.PnlDetails.Controls.Add(Me.TxtTicketNo)
        Me.PnlDetails.Controls.Add(Me.Label8)
        Me.PnlDetails.Controls.Add(Me.Label7)
        Me.PnlDetails.Controls.Add(Me.TxtDrNo)
        Me.PnlDetails.Controls.Add(Me.Label4)
        Me.PnlDetails.Controls.Add(Me.PnlClient)
        Me.PnlDetails.Controls.Add(Me.PnlCommodity)
        Me.PnlDetails.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlDetails.Location = New System.Drawing.Point(748, 6)
        Me.PnlDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlDetails.Name = "PnlDetails"
        Me.PnlDetails.Size = New System.Drawing.Size(774, 716)
        Me.PnlDetails.TabIndex = 0
        '
        'PnlWeightStat
        '
        Me.PnlWeightStat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlWeightStat.Controls.Add(Me.TxtReasons)
        Me.PnlWeightStat.Controls.Add(Me.Label17)
        Me.PnlWeightStat.Controls.Add(Me.LblFinalNetUnit)
        Me.PnlWeightStat.Controls.Add(Me.LblDedUnit)
        Me.PnlWeightStat.Controls.Add(Me.TxtDeduct)
        Me.PnlWeightStat.Controls.Add(Me.TxtFINAL)
        Me.PnlWeightStat.Controls.Add(Me.Label15)
        Me.PnlWeightStat.Controls.Add(Me.Label16)
        Me.PnlWeightStat.Location = New System.Drawing.Point(9, 304)
        Me.PnlWeightStat.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlWeightStat.Name = "PnlWeightStat"
        Me.PnlWeightStat.Size = New System.Drawing.Size(750, 147)
        Me.PnlWeightStat.TabIndex = 3
        '
        'TxtReasons
        '
        Me.TxtReasons.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtReasons.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtReasons.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtReasons.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReasons.Location = New System.Drawing.Point(121, 97)
        Me.TxtReasons.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtReasons.Name = "TxtReasons"
        Me.TxtReasons.Size = New System.Drawing.Size(608, 32)
        Me.TxtReasons.TabIndex = 171
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(12, 90)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(112, 48)
        Me.Label17.TabIndex = 170
        Me.Label17.Text = "Reason For Deduction"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblFinalNetUnit
        '
        Me.LblFinalNetUnit.BackColor = System.Drawing.Color.Transparent
        Me.LblFinalNetUnit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFinalNetUnit.ForeColor = System.Drawing.Color.White
        Me.LblFinalNetUnit.Location = New System.Drawing.Point(283, 63)
        Me.LblFinalNetUnit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblFinalNetUnit.Name = "LblFinalNetUnit"
        Me.LblFinalNetUnit.Size = New System.Drawing.Size(112, 18)
        Me.LblFinalNetUnit.TabIndex = 169
        Me.LblFinalNetUnit.Text = "(KG)"
        Me.LblFinalNetUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblDedUnit
        '
        Me.LblDedUnit.BackColor = System.Drawing.Color.Transparent
        Me.LblDedUnit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDedUnit.ForeColor = System.Drawing.Color.White
        Me.LblDedUnit.Location = New System.Drawing.Point(281, 20)
        Me.LblDedUnit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDedUnit.Name = "LblDedUnit"
        Me.LblDedUnit.Size = New System.Drawing.Size(112, 18)
        Me.LblDedUnit.TabIndex = 168
        Me.LblDedUnit.Text = "(%)"
        Me.LblDedUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtDeduct
        '
        Me.TxtDeduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtDeduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtDeduct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDeduct.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDeduct.Location = New System.Drawing.Point(121, 14)
        Me.TxtDeduct.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDeduct.Name = "TxtDeduct"
        Me.TxtDeduct.Size = New System.Drawing.Size(152, 30)
        Me.TxtDeduct.TabIndex = 0
        Me.TxtDeduct.Text = "0.00"
        Me.TxtDeduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtFINAL
        '
        Me.TxtFINAL.BackColor = System.Drawing.SystemColors.Window
        Me.TxtFINAL.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFINAL.ForeColor = System.Drawing.Color.Black
        Me.TxtFINAL.Location = New System.Drawing.Point(121, 52)
        Me.TxtFINAL.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtFINAL.Name = "TxtFINAL"
        Me.TxtFINAL.ReadOnly = True
        Me.TxtFINAL.Size = New System.Drawing.Size(152, 36)
        Me.TxtFINAL.TabIndex = 1
        Me.TxtFINAL.TabStop = False
        Me.TxtFINAL.Text = "64000"
        Me.TxtFINAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(12, 62)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 18)
        Me.Label15.TabIndex = 153
        Me.Label15.Text = "Final Net:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(12, 11)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(105, 44)
        Me.Label16.TabIndex = 167
        Me.Label16.Text = "Net Wt. Deduction (%):"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtRefNo
        '
        Me.TxtRefNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtRefNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtRefNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRefNo.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRefNo.Location = New System.Drawing.Point(535, 11)
        Me.TxtRefNo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtRefNo.Name = "TxtRefNo"
        Me.TxtRefNo.ReadOnly = True
        Me.TxtRefNo.Size = New System.Drawing.Size(224, 44)
        Me.TxtRefNo.TabIndex = 174
        Me.TxtRefNo.Text = "00000001"
        Me.TxtRefNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(393, 11)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(149, 33)
        Me.Label9.TabIndex = 175
        Me.Label9.Text = "Receipt Number:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtRemarks
        '
        Me.TxtRemarks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtRemarks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtRemarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRemarks.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRemarks.Location = New System.Drawing.Point(132, 530)
        Me.TxtRemarks.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtRemarks.Multiline = True
        Me.TxtRemarks.Name = "TxtRemarks"
        Me.TxtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtRemarks.Size = New System.Drawing.Size(608, 64)
        Me.TxtRemarks.TabIndex = 7
        Me.TxtRemarks.Text = "SAMPLE ONLY. TSI STANDARD SOFTWARE"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(20, 532)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 33)
        Me.Label12.TabIndex = 173
        Me.Label12.Text = "Remarks"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtDriver
        '
        Me.TxtDriver.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtDriver.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtDriver.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDriver.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDriver.Location = New System.Drawing.Point(132, 495)
        Me.TxtDriver.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDriver.Name = "TxtDriver"
        Me.TxtDriver.Size = New System.Drawing.Size(433, 32)
        Me.TxtDriver.TabIndex = 6
        Me.TxtDriver.Text = "JANNO GIBBS"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(20, 497)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 33)
        Me.Label11.TabIndex = 171
        Me.Label11.Text = "Driver Name"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtPlateNo
        '
        Me.TxtPlateNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtPlateNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtPlateNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPlateNo.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPlateNo.Location = New System.Drawing.Point(128, 52)
        Me.TxtPlateNo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPlateNo.Name = "TxtPlateNo"
        Me.TxtPlateNo.Size = New System.Drawing.Size(296, 44)
        Me.TxtPlateNo.TabIndex = 0
        Me.TxtPlateNo.Text = "ABC 123"
        '
        'TxtTicketNo
        '
        Me.TxtTicketNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtTicketNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtTicketNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTicketNo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTicketNo.Location = New System.Drawing.Point(485, 460)
        Me.TxtTicketNo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTicketNo.Name = "TxtTicketNo"
        Me.TxtTicketNo.Size = New System.Drawing.Size(252, 32)
        Me.TxtTicketNo.TabIndex = 5
        Me.TxtTicketNo.Text = "108"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(387, 460)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 33)
        Me.Label8.TabIndex = 164
        Me.Label8.Text = "Ticket No."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(20, 460)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 33)
        Me.Label7.TabIndex = 163
        Me.Label7.Text = "DR. No."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtDrNo
        '
        Me.TxtDrNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtDrNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtDrNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDrNo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDrNo.Location = New System.Drawing.Point(132, 459)
        Me.TxtDrNo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDrNo.Name = "TxtDrNo"
        Me.TxtDrNo.Size = New System.Drawing.Size(247, 32)
        Me.TxtDrNo.TabIndex = 4
        Me.TxtDrNo.Text = "9879-16587"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(16, 52)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 49)
        Me.Label4.TabIndex = 160
        Me.Label4.Text = "Plate Number:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PnlClient
        '
        Me.PnlClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlClient.Controls.Add(Me.TxtAddress)
        Me.PnlClient.Controls.Add(Me.Label13)
        Me.PnlClient.Controls.Add(Me.BtnAddCust)
        Me.PnlClient.Controls.Add(Me.Label5)
        Me.PnlClient.Controls.Add(Me.RdoSup)
        Me.PnlClient.Controls.Add(Me.CboClient)
        Me.PnlClient.Controls.Add(Me.Label1)
        Me.PnlClient.Controls.Add(Me.RdoCust)
        Me.PnlClient.Location = New System.Drawing.Point(8, 102)
        Me.PnlClient.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlClient.Name = "PnlClient"
        Me.PnlClient.Size = New System.Drawing.Size(751, 113)
        Me.PnlClient.TabIndex = 1
        '
        'TxtAddress
        '
        Me.TxtAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtAddress.BackColor = System.Drawing.Color.White
        Me.TxtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAddress.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddress.Location = New System.Drawing.Point(121, 78)
        Me.TxtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(613, 23)
        Me.TxtAddress.TabIndex = 3
        Me.TxtAddress.TabStop = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(12, 70)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 33)
        Me.Label13.TabIndex = 160
        Me.Label13.Text = "Address:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnAddCust
        '
        Me.BtnAddCust.BackgroundImage = CType(resources.GetObject("BtnAddCust.BackgroundImage"), System.Drawing.Image)
        Me.BtnAddCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAddCust.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddCust.FlatAppearance.BorderSize = 0
        Me.BtnAddCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddCust.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddCust.ForeColor = System.Drawing.Color.Black
        Me.BtnAddCust.GUI_ACCSS = "JMoiakne122208"
        Me.BtnAddCust.GUI_ENABLE_HOVER = True
        Me.BtnAddCust.GUI_ENABLED = True
        Me.BtnAddCust.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnAddCust.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnAddCust.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnAddCust.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnAddCust.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnAddCust.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddCust.Location = New System.Drawing.Point(705, 36)
        Me.BtnAddCust.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAddCust.Name = "BtnAddCust"
        Me.BtnAddCust.Size = New System.Drawing.Size(35, 33)
        Me.BtnAddCust.TabIndex = 159
        Me.BtnAddCust.TabStop = False
        Me.BtnAddCust.Text = "..."
        Me.BtnAddCust.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAddCust.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 37)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 33)
        Me.Label5.TabIndex = 158
        Me.Label5.Text = "Name:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RdoSup
        '
        Me.RdoSup.AutoSize = True
        Me.RdoSup.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoSup.ForeColor = System.Drawing.Color.White
        Me.RdoSup.Location = New System.Drawing.Point(243, 7)
        Me.RdoSup.Margin = New System.Windows.Forms.Padding(4)
        Me.RdoSup.Name = "RdoSup"
        Me.RdoSup.Size = New System.Drawing.Size(94, 27)
        Me.RdoSup.TabIndex = 1
        Me.RdoSup.TabStop = True
        Me.RdoSup.Text = "Supplier"
        Me.RdoSup.UseVisualStyleBackColor = True
        '
        'CboClient
        '
        Me.CboClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboClient.BackColor = System.Drawing.Color.White
        Me.CboClient.DropDownHeight = 150
        Me.CboClient.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboClient.FormattingEnabled = True
        Me.CboClient.IntegralHeight = False
        Me.CboClient.Location = New System.Drawing.Point(121, 36)
        Me.CboClient.Margin = New System.Windows.Forms.Padding(4)
        Me.CboClient.MaxLength = 50
        Me.CboClient.Name = "CboClient"
        Me.CboClient.Size = New System.Drawing.Size(569, 32)
        Me.CboClient.Sorted = True
        Me.CboClient.TabIndex = 2
        Me.CboClient.Text = "TERRINIEL SCALES INC."
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 33)
        Me.Label1.TabIndex = 151
        Me.Label1.Text = "Client Type:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RdoCust
        '
        Me.RdoCust.AutoSize = True
        Me.RdoCust.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoCust.ForeColor = System.Drawing.Color.White
        Me.RdoCust.Location = New System.Drawing.Point(129, 7)
        Me.RdoCust.Margin = New System.Windows.Forms.Padding(4)
        Me.RdoCust.Name = "RdoCust"
        Me.RdoCust.Size = New System.Drawing.Size(106, 27)
        Me.RdoCust.TabIndex = 0
        Me.RdoCust.TabStop = True
        Me.RdoCust.Text = "Customer"
        Me.RdoCust.UseVisualStyleBackColor = True
        '
        'PnlCommodity
        '
        Me.PnlCommodity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlCommodity.Controls.Add(Me.LblPriceUnit)
        Me.PnlCommodity.Controls.Add(Me.CboCommodity)
        Me.PnlCommodity.Controls.Add(Me.Label2)
        Me.PnlCommodity.Controls.Add(Me.BtnAddComm)
        Me.PnlCommodity.Controls.Add(Me.TxtPrice)
        Me.PnlCommodity.Controls.Add(Me.LblPriceLabel)
        Me.PnlCommodity.Location = New System.Drawing.Point(8, 219)
        Me.PnlCommodity.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlCommodity.Name = "PnlCommodity"
        Me.PnlCommodity.Size = New System.Drawing.Size(751, 81)
        Me.PnlCommodity.TabIndex = 2
        '
        'LblPriceUnit
        '
        Me.LblPriceUnit.BackColor = System.Drawing.Color.Transparent
        Me.LblPriceUnit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPriceUnit.ForeColor = System.Drawing.Color.Black
        Me.LblPriceUnit.Location = New System.Drawing.Point(287, 47)
        Me.LblPriceUnit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPriceUnit.Name = "LblPriceUnit"
        Me.LblPriceUnit.Size = New System.Drawing.Size(103, 33)
        Me.LblPriceUnit.TabIndex = 168
        Me.LblPriceUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CboCommodity
        '
        Me.CboCommodity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboCommodity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboCommodity.BackColor = System.Drawing.Color.White
        Me.CboCommodity.DropDownHeight = 150
        Me.CboCommodity.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCommodity.FormattingEnabled = True
        Me.CboCommodity.IntegralHeight = False
        Me.CboCommodity.Location = New System.Drawing.Point(121, 9)
        Me.CboCommodity.Margin = New System.Windows.Forms.Padding(4)
        Me.CboCommodity.MaxLength = 50
        Me.CboCommodity.Name = "CboCommodity"
        Me.CboCommodity.Size = New System.Drawing.Size(571, 32)
        Me.CboCommodity.Sorted = True
        Me.CboCommodity.TabIndex = 0
        Me.CboCommodity.Text = "MIXED WASTE"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 52)
        Me.Label2.TabIndex = 153
        Me.Label2.Text = "Commodity/Materials"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnAddComm
        '
        Me.BtnAddComm.BackgroundImage = CType(resources.GetObject("BtnAddComm.BackgroundImage"), System.Drawing.Image)
        Me.BtnAddComm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAddComm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddComm.FlatAppearance.BorderSize = 0
        Me.BtnAddComm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddComm.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddComm.ForeColor = System.Drawing.Color.Black
        Me.BtnAddComm.GUI_ACCSS = "JMoiakne122208"
        Me.BtnAddComm.GUI_ENABLE_HOVER = True
        Me.BtnAddComm.GUI_ENABLED = True
        Me.BtnAddComm.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnAddComm.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnAddComm.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnAddComm.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnAddComm.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnAddComm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddComm.Location = New System.Drawing.Point(705, 9)
        Me.BtnAddComm.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAddComm.Name = "BtnAddComm"
        Me.BtnAddComm.Size = New System.Drawing.Size(35, 32)
        Me.BtnAddComm.TabIndex = 166
        Me.BtnAddComm.TabStop = False
        Me.BtnAddComm.Text = "..."
        Me.BtnAddComm.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAddComm.UseVisualStyleBackColor = True
        '
        'TxtPrice
        '
        Me.TxtPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtPrice.BackColor = System.Drawing.SystemColors.Control
        Me.TxtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPrice.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrice.Location = New System.Drawing.Point(123, 50)
        Me.TxtPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Size = New System.Drawing.Size(149, 25)
        Me.TxtPrice.TabIndex = 1
        Me.TxtPrice.TabStop = False
        Me.TxtPrice.Text = "0.00"
        Me.TxtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblPriceLabel
        '
        Me.LblPriceLabel.BackColor = System.Drawing.Color.Transparent
        Me.LblPriceLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPriceLabel.ForeColor = System.Drawing.Color.White
        Me.LblPriceLabel.Location = New System.Drawing.Point(12, 43)
        Me.LblPriceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPriceLabel.Name = "LblPriceLabel"
        Me.LblPriceLabel.Size = New System.Drawing.Size(103, 33)
        Me.LblPriceLabel.TabIndex = 167
        Me.LblPriceLabel.Text = "Price"
        Me.LblPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.PnlList)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(7, 6)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 0, 13, 0)
        Me.Panel1.Size = New System.Drawing.Size(741, 716)
        Me.Panel1.TabIndex = 0
        '
        'PnlList
        '
        Me.PnlList.BackColor = System.Drawing.Color.Transparent
        Me.PnlList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlList.Controls.Add(Me.Dg)
        Me.PnlList.Controls.Add(Me.PnlSearch)
        Me.PnlList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlList.Location = New System.Drawing.Point(0, 0)
        Me.PnlList.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlList.Name = "PnlList"
        Me.PnlList.Size = New System.Drawing.Size(728, 716)
        Me.PnlList.TabIndex = 0
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
        Me.Dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_Id, Me.Col_PlateNo, Me.Col_DateTime, Me.Col_InboundWt, Me.Col_Client, Me.Col_Comm, Me.Col_Pricing, Me.Col_Dr, Me.Col_TktNO, Me.Col_Driver, Me.Col_remarks, Me.Col_Weigher})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dg.DefaultCellStyle = DataGridViewCellStyle3
        Me.Dg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.Dg.GridColor = System.Drawing.Color.Aqua
        Me.Dg.Location = New System.Drawing.Point(0, 79)
        Me.Dg.Margin = New System.Windows.Forms.Padding(4)
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
        Me.Dg.RowTemplate.Height = 26
        Me.Dg.RowTemplate.ReadOnly = True
        Me.Dg.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg.Size = New System.Drawing.Size(726, 635)
        Me.Dg.StandardTab = True
        Me.Dg.TabIndex = 0
        '
        'Col_Id
        '
        Me.Col_Id.HeaderText = "Ref. No."
        Me.Col_Id.MaxInputLength = 0
        Me.Col_Id.MinimumWidth = 2
        Me.Col_Id.Name = "Col_Id"
        Me.Col_Id.ReadOnly = True
        Me.Col_Id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Col_Id.Width = 2
        '
        'Col_PlateNo
        '
        Me.Col_PlateNo.HeaderText = "Plate Number"
        Me.Col_PlateNo.MinimumWidth = 6
        Me.Col_PlateNo.Name = "Col_PlateNo"
        Me.Col_PlateNo.Width = 125
        '
        'Col_DateTime
        '
        Me.Col_DateTime.HeaderText = "Date & Time"
        Me.Col_DateTime.MaxInputLength = 35
        Me.Col_DateTime.MinimumWidth = 6
        Me.Col_DateTime.Name = "Col_DateTime"
        Me.Col_DateTime.Width = 150
        '
        'Col_InboundWt
        '
        Me.Col_InboundWt.HeaderText = "Inbound Wt."
        Me.Col_InboundWt.MinimumWidth = 6
        Me.Col_InboundWt.Name = "Col_InboundWt"
        Me.Col_InboundWt.Width = 125
        '
        'Col_Client
        '
        Me.Col_Client.HeaderText = "Supplier/Customer Name"
        Me.Col_Client.MinimumWidth = 6
        Me.Col_Client.Name = "Col_Client"
        Me.Col_Client.Width = 200
        '
        'Col_Comm
        '
        Me.Col_Comm.HeaderText = "Commodity/Materials"
        Me.Col_Comm.MinimumWidth = 6
        Me.Col_Comm.Name = "Col_Comm"
        Me.Col_Comm.Width = 200
        '
        'Col_Pricing
        '
        Me.Col_Pricing.HeaderText = "Price"
        Me.Col_Pricing.MinimumWidth = 6
        Me.Col_Pricing.Name = "Col_Pricing"
        Me.Col_Pricing.Visible = False
        Me.Col_Pricing.Width = 125
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
        Me.Col_Driver.MinimumWidth = 6
        Me.Col_Driver.Name = "Col_Driver"
        Me.Col_Driver.Width = 180
        '
        'Col_remarks
        '
        Me.Col_remarks.HeaderText = "Remarks"
        Me.Col_remarks.MinimumWidth = 6
        Me.Col_remarks.Name = "Col_remarks"
        Me.Col_remarks.Width = 125
        '
        'Col_Weigher
        '
        Me.Col_Weigher.HeaderText = "Weighed in by"
        Me.Col_Weigher.MinimumWidth = 6
        Me.Col_Weigher.Name = "Col_Weigher"
        Me.Col_Weigher.Width = 125
        '
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.Transparent
        Me.PnlSearch.BackgroundImage = Global.WeighingSystemV1_1.My.Resources.Resources.WhiteHeader1
        Me.PnlSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlSearch.Controls.Add(Me.Panel2)
        Me.PnlSearch.Controls.Add(Me.TxtSearch)
        Me.PnlSearch.Controls.Add(Me.Label14)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Location = New System.Drawing.Point(0, 0)
        Me.PnlSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(726, 79)
        Me.PnlSearch.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.LblRecord)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(393, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(333, 79)
        Me.Panel2.TabIndex = 139
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(164, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 21)
        Me.Label3.TabIndex = 165
        Me.Label3.Text = "Total Pending Truck/s"
        '
        'LblRecord
        '
        Me.LblRecord.AutoSize = True
        Me.LblRecord.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRecord.Location = New System.Drawing.Point(289, 27)
        Me.LblRecord.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblRecord.Name = "LblRecord"
        Me.LblRecord.Size = New System.Drawing.Size(39, 45)
        Me.LblRecord.TabIndex = 166
        Me.LblRecord.Text = "0"
        Me.LblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtSearch
        '
        Me.TxtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSearch.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.Location = New System.Drawing.Point(16, 33)
        Me.TxtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(281, 36)
        Me.TxtSearch.TabIndex = 0
        Me.TxtSearch.Text = "ABC 123"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(17, 11)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(268, 21)
        Me.Label14.TabIndex = 138
        Me.Label14.Text = "type here to search for plate number."
        '
        'PnlHeader
        '
        Me.PnlHeader.BackColor = System.Drawing.Color.Transparent
        Me.PnlHeader.BackgroundImage = CType(resources.GetObject("PnlHeader.BackgroundImage"), System.Drawing.Image)
        Me.PnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlHeader.Controls.Add(Me.LblError)
        Me.PnlHeader.Controls.Add(Me.BtnPrintOut)
        Me.PnlHeader.Controls.Add(Me.BtnDelete)
        Me.PnlHeader.Controls.Add(Me.TxtGross)
        Me.PnlHeader.Controls.Add(Me.Label20)
        Me.PnlHeader.Controls.Add(Me.Panel3)
        Me.PnlHeader.Controls.Add(Me.BtnSetup)
        Me.PnlHeader.Controls.Add(Me.BtnExit)
        Me.PnlHeader.Controls.Add(Me.BtnIn)
        Me.PnlHeader.Controls.Add(Me.Label21)
        Me.PnlHeader.Controls.Add(Me.BtnPrintIN)
        Me.PnlHeader.Controls.Add(Me.BtnOUt)
        Me.PnlHeader.Controls.Add(Me.Btncancel)
        Me.PnlHeader.Controls.Add(Me.Btnsave)
        Me.PnlHeader.Controls.Add(Me.Label19)
        Me.PnlHeader.Controls.Add(Me.TxtNet)
        Me.PnlHeader.Controls.Add(Me.TxtTare)
        Me.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.PnlHeader.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlHeader.Name = "PnlHeader"
        Me.PnlHeader.Size = New System.Drawing.Size(1821, 166)
        Me.PnlHeader.TabIndex = 1
        '
        'LblError
        '
        Me.LblError.BackColor = System.Drawing.Color.Transparent
        Me.LblError.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblError.ForeColor = System.Drawing.Color.Black
        Me.LblError.Image = CType(resources.GetObject("LblError.Image"), System.Drawing.Image)
        Me.LblError.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.LblError.Location = New System.Drawing.Point(5, 110)
        Me.LblError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblError.Name = "LblError"
        Me.LblError.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblError.Size = New System.Drawing.Size(532, 34)
        Me.LblError.TabIndex = 147
        Me.LblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblError.Visible = False
        '
        'BtnPrintOut
        '
        Me.BtnPrintOut.BackgroundImage = CType(resources.GetObject("BtnPrintOut.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrintOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPrintOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintOut.FlatAppearance.BorderSize = 0
        Me.BtnPrintOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrintOut.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintOut.ForeColor = System.Drawing.Color.Black
        Me.BtnPrintOut.GUI_ACCSS = "JMoiakne122208"
        Me.BtnPrintOut.GUI_ENABLE_HOVER = True
        Me.BtnPrintOut.GUI_ENABLED = True
        Me.BtnPrintOut.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnPrintOut.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Printer20
        Me.BtnPrintOut.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnPrintOut.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnPrintOut.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnPrintOut.Image = CType(resources.GetObject("BtnPrintOut.Image"), System.Drawing.Image)
        Me.BtnPrintOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPrintOut.Location = New System.Drawing.Point(297, 142)
        Me.BtnPrintOut.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPrintOut.Name = "BtnPrintOut"
        Me.BtnPrintOut.Padding = New System.Windows.Forms.Padding(0, 6, 0, 6)
        Me.BtnPrintOut.Size = New System.Drawing.Size(148, 25)
        Me.BtnPrintOut.TabIndex = 146
        Me.BtnPrintOut.Text = "Re-Print Last Weigh-Out"
        Me.BtnPrintOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPrintOut.UseVisualStyleBackColor = True
        Me.BtnPrintOut.Visible = False
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
        Me.BtnDelete.Location = New System.Drawing.Point(281, 10)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Padding = New System.Windows.Forms.Padding(0, 6, 0, 6)
        Me.BtnDelete.Size = New System.Drawing.Size(113, 82)
        Me.BtnDelete.TabIndex = 2
        Me.BtnDelete.Text = "DEL REMOVE"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'TxtGross
        '
        Me.TxtGross.BackColor = System.Drawing.Color.Black
        Me.TxtGross.Font = New System.Drawing.Font("DS-Digital", 23.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGross.ForeColor = System.Drawing.Color.Gold
        Me.TxtGross.Location = New System.Drawing.Point(841, 7)
        Me.TxtGross.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtGross.Name = "TxtGross"
        Me.TxtGross.ReadOnly = True
        Me.TxtGross.Size = New System.Drawing.Size(176, 46)
        Me.TxtGross.TabIndex = 145
        Me.TxtGross.TabStop = False
        Me.TxtGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(749, 69)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 20)
        Me.Label20.TabIndex = 140
        Me.Label20.Text = "TARE WT."
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.DTPicker)
        Me.Panel3.Controls.Add(Me.Pnl_indicator)
        Me.Panel3.Controls.Add(Me.TxtDateTime)
        Me.Panel3.Location = New System.Drawing.Point(1024, 9)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(503, 152)
        Me.Panel3.TabIndex = 126
        '
        'DTPicker
        '
        Me.DTPicker.CustomFormat = "MM-dd-yyyy   hh:mm tt"
        Me.DTPicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DTPicker.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPicker.Location = New System.Drawing.Point(7, 103)
        Me.DTPicker.Margin = New System.Windows.Forms.Padding(4)
        Me.DTPicker.Name = "DTPicker"
        Me.DTPicker.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DTPicker.Size = New System.Drawing.Size(480, 40)
        Me.DTPicker.TabIndex = 150
        Me.DTPicker.Visible = False
        '
        'Pnl_indicator
        '
        Me.Pnl_indicator.BackColor = System.Drawing.Color.Black
        Me.Pnl_indicator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pnl_indicator.Controls.Add(Me.TxtOnline)
        Me.Pnl_indicator.Controls.Add(Me.TxtUnit)
        Me.Pnl_indicator.Controls.Add(Me.TxtWeightType)
        Me.Pnl_indicator.Controls.Add(Me.TxtOffline)
        Me.Pnl_indicator.Location = New System.Drawing.Point(7, 7)
        Me.Pnl_indicator.Margin = New System.Windows.Forms.Padding(4)
        Me.Pnl_indicator.Name = "Pnl_indicator"
        Me.Pnl_indicator.Size = New System.Drawing.Size(480, 91)
        Me.Pnl_indicator.TabIndex = 148
        '
        'TxtOnline
        '
        Me.TxtOnline.AccessPwd = "mijochanel09041990"
        Me.TxtOnline.BackColor = System.Drawing.Color.Black
        Me.TxtOnline.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtOnline.CommBaudRate = 9600
        Me.TxtOnline.CommDataBits = 8
        Me.TxtOnline.CommDTREnable = True
        Me.TxtOnline.CommNewLine = "" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TxtOnline.CommParity = "None"
        Me.TxtOnline.CommPortName = "COM1"
        Me.TxtOnline.CommReadBufferSize = 4
        Me.TxtOnline.CommReadTimeout = 0
        Me.TxtOnline.CommReceivedBytesThreshold = 1
        Me.TxtOnline.CommRTSEnable = False
        Me.TxtOnline.CommStopBits = "1"
        Me.TxtOnline.CommWriteTimeout = 1000
        Me.TxtOnline.ConnectionType = Nothing
        Me.TxtOnline.DataLength = 0
        Me.TxtOnline.DataSent = 0
        Me.TxtOnline.DiscardInBuffer = False
        Me.TxtOnline.DiscardOutBuffer = False
        Me.TxtOnline.EndCharacter = Nothing
        Me.TxtOnline.ExtStartIndex = 0
        Me.TxtOnline.Font = New System.Drawing.Font("DS-Digital", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOnline.ForeColor = System.Drawing.Color.YellowGreen
        Me.TxtOnline.IPAddress = "192.168.1.41"
        Me.TxtOnline.IPPort = "1"
        Me.TxtOnline.IPReadTimeOut = 1000
        Me.TxtOnline.LengthViewer = Nothing
        Me.TxtOnline.Location = New System.Drawing.Point(7, 5)
        Me.TxtOnline.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtOnline.Name = "TxtOnline"
        Me.TxtOnline.ReadingInterval = 100
        Me.TxtOnline.ReadOnly = True
        Me.TxtOnline.SignalViewer = Nothing
        Me.TxtOnline.SimulationIncrement = New Decimal(New Integer() {10, 0, 0, 0})
        Me.TxtOnline.SimulationSpeed = 100
        Me.TxtOnline.Size = New System.Drawing.Size(337, 80)
        Me.TxtOnline.TabIndex = 151
        Me.TxtOnline.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtOnline.WeighingDevice = Nothing
        '
        'TxtUnit
        '
        Me.TxtUnit.BackColor = System.Drawing.Color.Black
        Me.TxtUnit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUnit.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUnit.ForeColor = System.Drawing.Color.Lime
        Me.TxtUnit.Location = New System.Drawing.Point(356, 15)
        Me.TxtUnit.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtUnit.Name = "TxtUnit"
        Me.TxtUnit.ReadOnly = True
        Me.TxtUnit.Size = New System.Drawing.Size(68, 33)
        Me.TxtUnit.TabIndex = 147
        Me.TxtUnit.TabStop = False
        Me.TxtUnit.Text = "Kg"
        '
        'TxtWeightType
        '
        Me.TxtWeightType.BackColor = System.Drawing.Color.Black
        Me.TxtWeightType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtWeightType.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWeightType.ForeColor = System.Drawing.Color.Lime
        Me.TxtWeightType.Location = New System.Drawing.Point(355, 39)
        Me.TxtWeightType.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtWeightType.Name = "TxtWeightType"
        Me.TxtWeightType.ReadOnly = True
        Me.TxtWeightType.Size = New System.Drawing.Size(109, 33)
        Me.TxtWeightType.TabIndex = 148
        Me.TxtWeightType.TabStop = False
        Me.TxtWeightType.Text = "Gross"
        '
        'TxtOffline
        '
        Me.TxtOffline.BackColor = System.Drawing.SystemColors.MenuText
        Me.TxtOffline.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtOffline.Font = New System.Drawing.Font("DS-Digital", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOffline.ForeColor = System.Drawing.Color.Red
        Me.TxtOffline.Location = New System.Drawing.Point(7, 4)
        Me.TxtOffline.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtOffline.Name = "TxtOffline"
        Me.TxtOffline.Size = New System.Drawing.Size(337, 80)
        Me.TxtOffline.TabIndex = 150
        Me.TxtOffline.TabStop = False
        Me.TxtOffline.Text = "0"
        Me.TxtOffline.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDateTime
        '
        Me.TxtDateTime.BackColor = System.Drawing.Color.Black
        Me.TxtDateTime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDateTime.ForeColor = System.Drawing.Color.Lime
        Me.TxtDateTime.Location = New System.Drawing.Point(97, 105)
        Me.TxtDateTime.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDateTime.Name = "TxtDateTime"
        Me.TxtDateTime.ReadOnly = True
        Me.TxtDateTime.Size = New System.Drawing.Size(375, 46)
        Me.TxtDateTime.TabIndex = 146
        Me.TxtDateTime.TabStop = False
        Me.TxtDateTime.Text = "09-04-2012  9:00 AM"
        Me.TxtDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnSetup
        '
        Me.BtnSetup.BackgroundImage = CType(resources.GetObject("BtnSetup.BackgroundImage"), System.Drawing.Image)
        Me.BtnSetup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSetup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSetup.FlatAppearance.BorderSize = 0
        Me.BtnSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSetup.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSetup.ForeColor = System.Drawing.Color.Black
        Me.BtnSetup.GUI_ACCSS = "JMoiakne122208"
        Me.BtnSetup.GUI_ENABLE_HOVER = True
        Me.BtnSetup.GUI_ENABLED = True
        Me.BtnSetup.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnSetup.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Settings20
        Me.BtnSetup.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnSetup.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnSetup.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnSetup.Image = CType(resources.GetObject("BtnSetup.Image"), System.Drawing.Image)
        Me.BtnSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSetup.Location = New System.Drawing.Point(453, 142)
        Me.BtnSetup.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSetup.Name = "BtnSetup"
        Me.BtnSetup.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BtnSetup.Size = New System.Drawing.Size(149, 25)
        Me.BtnSetup.TabIndex = 5
        Me.BtnSetup.Text = "F6 SETUP"
        Me.BtnSetup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSetup.UseVisualStyleBackColor = True
        Me.BtnSetup.Visible = False
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
        Me.BtnExit.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Home24
        Me.BtnExit.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnExit.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnExit.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
        Me.BtnExit.Location = New System.Drawing.Point(632, 10)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BtnExit.Size = New System.Drawing.Size(111, 82)
        Me.BtnExit.TabIndex = 7
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnIn
        '
        Me.BtnIn.BackgroundImage = CType(resources.GetObject("BtnIn.BackgroundImage"), System.Drawing.Image)
        Me.BtnIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIn.FlatAppearance.BorderSize = 0
        Me.BtnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIn.ForeColor = System.Drawing.Color.Black
        Me.BtnIn.GUI_ACCSS = "JMoiakne122208"
        Me.BtnIn.GUI_ENABLE_HOVER = True
        Me.BtnIn.GUI_ENABLED = True
        Me.BtnIn.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnIn.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Add32
        Me.BtnIn.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnIn.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnIn.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnIn.Image = CType(resources.GetObject("BtnIn.Image"), System.Drawing.Image)
        Me.BtnIn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnIn.Location = New System.Drawing.Point(9, 10)
        Me.BtnIn.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnIn.Name = "BtnIn"
        Me.BtnIn.Padding = New System.Windows.Forms.Padding(0, 6, 0, 6)
        Me.BtnIn.Size = New System.Drawing.Size(123, 82)
        Me.BtnIn.TabIndex = 0
        Me.BtnIn.Text = "F1   WEIGH-IN"
        Me.BtnIn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnIn.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(749, 118)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(65, 20)
        Me.Label21.TabIndex = 144
        Me.Label21.Text = "NET WT."
        '
        'BtnPrintIN
        '
        Me.BtnPrintIN.BackgroundImage = CType(resources.GetObject("BtnPrintIN.BackgroundImage"), System.Drawing.Image)
        Me.BtnPrintIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPrintIN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintIN.FlatAppearance.BorderSize = 0
        Me.BtnPrintIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrintIN.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintIN.ForeColor = System.Drawing.Color.Black
        Me.BtnPrintIN.GUI_ACCSS = "JMoiakne122208"
        Me.BtnPrintIN.GUI_ENABLE_HOVER = True
        Me.BtnPrintIN.GUI_ENABLED = True
        Me.BtnPrintIN.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnPrintIN.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Printer20
        Me.BtnPrintIN.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnPrintIN.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnPrintIN.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnPrintIN.Image = CType(resources.GetObject("BtnPrintIN.Image"), System.Drawing.Image)
        Me.BtnPrintIN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPrintIN.Location = New System.Drawing.Point(632, 100)
        Me.BtnPrintIN.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPrintIN.Name = "BtnPrintIN"
        Me.BtnPrintIN.Padding = New System.Windows.Forms.Padding(0, 6, 0, 6)
        Me.BtnPrintIN.Size = New System.Drawing.Size(111, 59)
        Me.BtnPrintIN.TabIndex = 6
        Me.BtnPrintIN.Text = "Re-Print Weigh-In"
        Me.BtnPrintIN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPrintIN.UseVisualStyleBackColor = True
        Me.BtnPrintIN.Visible = False
        '
        'BtnOUt
        '
        Me.BtnOUt.BackgroundImage = CType(resources.GetObject("BtnOUt.BackgroundImage"), System.Drawing.Image)
        Me.BtnOUt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnOUt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOUt.FlatAppearance.BorderSize = 0
        Me.BtnOUt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOUt.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOUt.ForeColor = System.Drawing.Color.Black
        Me.BtnOUt.GUI_ACCSS = "JMoiakne122208"
        Me.BtnOUt.GUI_ENABLE_HOVER = True
        Me.BtnOUt.GUI_ENABLED = True
        Me.BtnOUt.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnOUt.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Delete32
        Me.BtnOUt.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnOUt.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnOUt.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnOUt.Image = CType(resources.GetObject("BtnOUt.Image"), System.Drawing.Image)
        Me.BtnOUt.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnOUt.Location = New System.Drawing.Point(136, 10)
        Me.BtnOUt.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnOUt.Name = "BtnOUt"
        Me.BtnOUt.Padding = New System.Windows.Forms.Padding(0, 6, 0, 6)
        Me.BtnOUt.Size = New System.Drawing.Size(140, 82)
        Me.BtnOUt.TabIndex = 1
        Me.BtnOUt.Text = "F2   WEIGH-OUT"
        Me.BtnOUt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnOUt.UseVisualStyleBackColor = True
        '
        'Btncancel
        '
        Me.Btncancel.BackgroundImage = CType(resources.GetObject("Btncancel.BackgroundImage"), System.Drawing.Image)
        Me.Btncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btncancel.FlatAppearance.BorderSize = 0
        Me.Btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btncancel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncancel.ForeColor = System.Drawing.Color.Black
        Me.Btncancel.GUI_ACCSS = "JMoiakne122208"
        Me.Btncancel.GUI_ENABLE_HOVER = True
        Me.Btncancel.GUI_ENABLED = True
        Me.Btncancel.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btncancel.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Cancel32
        Me.Btncancel.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.Btncancel.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.Btncancel.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.Btncancel.Image = CType(resources.GetObject("Btncancel.Image"), System.Drawing.Image)
        Me.Btncancel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btncancel.Location = New System.Drawing.Point(516, 10)
        Me.Btncancel.Margin = New System.Windows.Forms.Padding(4)
        Me.Btncancel.Name = "Btncancel"
        Me.Btncancel.Padding = New System.Windows.Forms.Padding(0, 6, 0, 6)
        Me.Btncancel.Size = New System.Drawing.Size(111, 82)
        Me.Btncancel.TabIndex = 4
        Me.Btncancel.Text = "ESC  CANCEL"
        Me.Btncancel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btncancel.UseVisualStyleBackColor = True
        '
        'Btnsave
        '
        Me.Btnsave.BackgroundImage = CType(resources.GetObject("Btnsave.BackgroundImage"), System.Drawing.Image)
        Me.Btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnsave.FlatAppearance.BorderSize = 0
        Me.Btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnsave.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsave.ForeColor = System.Drawing.Color.Black
        Me.Btnsave.GUI_ACCSS = "JMoiakne122208"
        Me.Btnsave.GUI_ENABLE_HOVER = True
        Me.Btnsave.GUI_ENABLED = True
        Me.Btnsave.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btnsave.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Save32
        Me.Btnsave.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.Btnsave.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.Btnsave.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.Btnsave.Image = CType(resources.GetObject("Btnsave.Image"), System.Drawing.Image)
        Me.Btnsave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btnsave.Location = New System.Drawing.Point(400, 10)
        Me.Btnsave.Margin = New System.Windows.Forms.Padding(4)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Padding = New System.Windows.Forms.Padding(0, 6, 0, 6)
        Me.Btnsave.Size = New System.Drawing.Size(111, 82)
        Me.Btnsave.TabIndex = 3
        Me.Btnsave.Text = "F3  SAVE"
        Me.Btnsave.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btnsave.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(745, 18)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(84, 20)
        Me.Label19.TabIndex = 142
        Me.Label19.Text = "GROSS WT."
        '
        'TxtNet
        '
        Me.TxtNet.BackColor = System.Drawing.Color.Black
        Me.TxtNet.Font = New System.Drawing.Font("DS-Digital", 23.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNet.ForeColor = System.Drawing.Color.Gold
        Me.TxtNet.Location = New System.Drawing.Point(841, 112)
        Me.TxtNet.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNet.Name = "TxtNet"
        Me.TxtNet.ReadOnly = True
        Me.TxtNet.Size = New System.Drawing.Size(176, 46)
        Me.TxtNet.TabIndex = 143
        Me.TxtNet.TabStop = False
        Me.TxtNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTare
        '
        Me.TxtTare.BackColor = System.Drawing.Color.Black
        Me.TxtTare.Font = New System.Drawing.Font("DS-Digital", 23.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTare.ForeColor = System.Drawing.Color.Gold
        Me.TxtTare.Location = New System.Drawing.Point(841, 60)
        Me.TxtTare.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTare.Name = "TxtTare"
        Me.TxtTare.ReadOnly = True
        Me.TxtTare.Size = New System.Drawing.Size(176, 46)
        Me.TxtTare.TabIndex = 139
        Me.TxtTare.TabStop = False
        Me.TxtTare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FrmTrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1821, 894)
        Me.Controls.Add(Me.PnlMain)
        Me.Controls.Add(Me.PnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmTrans"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.PnlMain.ResumeLayout(False)
        Me.PnlDetails.ResumeLayout(False)
        Me.PnlDetails.PerformLayout()
        Me.PnlWeightStat.ResumeLayout(False)
        Me.PnlWeightStat.PerformLayout()
        Me.PnlClient.ResumeLayout(False)
        Me.PnlClient.PerformLayout()
        Me.PnlCommodity.ResumeLayout(False)
        Me.PnlCommodity.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.PnlList.ResumeLayout(False)
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlSearch.ResumeLayout(False)
        Me.PnlSearch.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PnlHeader.ResumeLayout(False)
        Me.PnlHeader.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Pnl_indicator.ResumeLayout(False)
        Me.Pnl_indicator.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnIn As MykeCtrlEx.PushButton
    Friend WithEvents BtnOUt As MykeCtrlEx.PushButton
    Friend WithEvents Btnsave As MykeCtrlEx.PushButton
    Friend WithEvents Btncancel As MykeCtrlEx.PushButton
    Friend WithEvents BtnPrintIN As MykeCtrlEx.PushButton
    Friend WithEvents PnlHeader As System.Windows.Forms.Panel
    Friend WithEvents BtnSetup As MykeCtrlEx.PushButton
    Friend WithEvents BtnExit As MykeCtrlEx.PushButton
    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Pnl_indicator As System.Windows.Forms.Panel
    Friend WithEvents TxtUnit As System.Windows.Forms.TextBox
    Friend WithEvents TxtWeightType As System.Windows.Forms.TextBox
    Friend WithEvents TxtDateTime As System.Windows.Forms.TextBox
    Friend WithEvents TxtGross As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TxtTare As System.Windows.Forms.TextBox
    Friend WithEvents TxtNet As System.Windows.Forms.TextBox
    Friend WithEvents PnlList As System.Windows.Forms.Panel
    Friend WithEvents Dg As System.Windows.Forms.DataGridView
    Friend WithEvents PnlSearch As System.Windows.Forms.Panel
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnDelete As MykeCtrlEx.PushButton
    Friend WithEvents TxtOffline As System.Windows.Forms.TextBox
    Friend WithEvents Col_Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_PlateNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_DateTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_InboundWt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Client As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Comm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Pricing As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Dr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_TktNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Driver As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_remarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Weigher As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnPrintOut As MykeCtrlEx.PushButton
    Friend WithEvents DTPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblError As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblRecord As System.Windows.Forms.Label
    Friend WithEvents TxtOnline As WeightDev.WeightIndicator
    Friend WithEvents PnlDetails As System.Windows.Forms.Panel
    Friend WithEvents PnlWeightStat As System.Windows.Forms.Panel
    Friend WithEvents TxtReasons As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents LblFinalNetUnit As System.Windows.Forms.Label
    Friend WithEvents LblDedUnit As System.Windows.Forms.Label
    Friend WithEvents TxtDeduct As System.Windows.Forms.TextBox
    Friend WithEvents TxtFINAL As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtRefNo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtDriver As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtPlateNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtTicketNo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtDrNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PnlClient As System.Windows.Forms.Panel
    Friend WithEvents TxtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents BtnAddCust As MykeCtrlEx.PushButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RdoSup As System.Windows.Forms.RadioButton
    Friend WithEvents CboClient As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RdoCust As System.Windows.Forms.RadioButton
    Friend WithEvents PnlCommodity As System.Windows.Forms.Panel
    Friend WithEvents LblPriceUnit As System.Windows.Forms.Label
    Friend WithEvents CboCommodity As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnAddComm As MykeCtrlEx.PushButton
    Friend WithEvents TxtPrice As System.Windows.Forms.TextBox
    Friend WithEvents LblPriceLabel As System.Windows.Forms.Label
End Class
