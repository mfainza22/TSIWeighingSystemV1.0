<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditTrans
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditTrans))
        Me.PnlHeader = New System.Windows.Forms.Panel()
        Me.BtnUpdatePrice = New MykeCtrlEx.PushButton()
        Me.BtnDelete = New MykeCtrlEx.PushButton()
        Me.BtnExit = New MykeCtrlEx.PushButton()
        Me.BtnEdit = New MykeCtrlEx.PushButton()
        Me.BtnPrint = New MykeCtrlEx.PushButton()
        Me.Btncancel = New MykeCtrlEx.PushButton()
        Me.Btnsave = New MykeCtrlEx.PushButton()
        Me.TxtGross = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtTare = New System.Windows.Forms.TextBox()
        Me.TxtNet = New System.Windows.Forms.TextBox()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlDetails = New System.Windows.Forms.Panel()
        Me.PnlWeightStat = New System.Windows.Forms.Panel()
        Me.TxtReasons = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LblFinalNetUnit = New System.Windows.Forms.Label()
        Me.LblDedUnit = New System.Windows.Forms.Label()
        Me.TxtDeduct = New System.Windows.Forms.TextBox()
        Me.TxtFINAL = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtDTUpd = New System.Windows.Forms.TextBox()
        Me.TxtDTOut = New System.Windows.Forms.TextBox()
        Me.TxtDTIn = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtWin = New System.Windows.Forms.TextBox()
        Me.TxtWout = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtUpdby = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtGr_Time = New System.Windows.Forms.TextBox()
        Me.TxtTR_Time = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtRefNo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtRemarks = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtDriver = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TxtPriceUnit = New System.Windows.Forms.TextBox()
        Me.CboCommodity = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnComm = New MykeCtrlEx.PushButton()
        Me.TxtPrice = New System.Windows.Forms.TextBox()
        Me.LblPrice = New System.Windows.Forms.Label()
        Me.TxtPlateNo = New System.Windows.Forms.TextBox()
        Me.TxtTicketNo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtDrNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnClient = New MykeCtrlEx.PushButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RdoSup = New System.Windows.Forms.RadioButton()
        Me.CboClient = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RdoCust = New System.Windows.Forms.RadioButton()
        Me.Pnl_Weight = New System.Windows.Forms.Panel()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlHeader.SuspendLayout()
        Me.PnlMain.SuspendLayout()
        Me.PnlDetails.SuspendLayout()
        Me.PnlWeightStat.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlHeader
        '
        Me.PnlHeader.BackColor = System.Drawing.Color.White
        Me.PnlHeader.BackgroundImage = Global.WeighingSystemV1_1.My.Resources.Resources.WhiteHeader3
        Me.PnlHeader.Controls.Add(Me.BtnUpdatePrice)
        Me.PnlHeader.Controls.Add(Me.BtnDelete)
        Me.PnlHeader.Controls.Add(Me.BtnExit)
        Me.PnlHeader.Controls.Add(Me.BtnEdit)
        Me.PnlHeader.Controls.Add(Me.BtnPrint)
        Me.PnlHeader.Controls.Add(Me.Btncancel)
        Me.PnlHeader.Controls.Add(Me.Btnsave)
        Me.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.PnlHeader.Name = "PnlHeader"
        Me.PnlHeader.Size = New System.Drawing.Size(1366, 53)
        Me.PnlHeader.TabIndex = 1
        '
        'BtnUpdatePrice
        '
        Me.BtnUpdatePrice.BackgroundImage = CType(resources.GetObject("BtnUpdatePrice.BackgroundImage"), System.Drawing.Image)
        Me.BtnUpdatePrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnUpdatePrice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdatePrice.FlatAppearance.BorderSize = 0
        Me.BtnUpdatePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdatePrice.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdatePrice.ForeColor = System.Drawing.Color.Black
        Me.BtnUpdatePrice.GUI_ACCSS = "JMoiakne122208"
        Me.BtnUpdatePrice.GUI_ENABLE_HOVER = True
        Me.BtnUpdatePrice.GUI_ENABLED = True
        Me.BtnUpdatePrice.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnUpdatePrice.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnUpdatePrice.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnUpdatePrice.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnUpdatePrice.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnUpdatePrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdatePrice.Location = New System.Drawing.Point(722, 8)
        Me.BtnUpdatePrice.Name = "BtnUpdatePrice"
        Me.BtnUpdatePrice.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.BtnUpdatePrice.Size = New System.Drawing.Size(132, 32)
        Me.BtnUpdatePrice.TabIndex = 8
        Me.BtnUpdatePrice.Text = "CTRL+U Update Price"
        Me.BtnUpdatePrice.UseVisualStyleBackColor = True
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
        Me.BtnDelete.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Exit26
        Me.BtnDelete.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnDelete.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnDelete.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(150, 8)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.BtnDelete.Size = New System.Drawing.Size(137, 32)
        Me.BtnDelete.TabIndex = 2
        Me.BtnDelete.Text = "DEL REMOVE"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.BtnExit.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Home24
        Me.BtnExit.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnExit.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnExit.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
        Me.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExit.Location = New System.Drawing.Point(865, 8)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Padding = New System.Windows.Forms.Padding(5)
        Me.BtnExit.Size = New System.Drawing.Size(89, 32)
        Me.BtnExit.TabIndex = 7
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.BackgroundImage = CType(resources.GetObject("BtnEdit.BackgroundImage"), System.Drawing.Image)
        Me.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEdit.FlatAppearance.BorderSize = 0
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.Color.Black
        Me.BtnEdit.GUI_ACCSS = "JMoiakne122208"
        Me.BtnEdit.GUI_ENABLE_HOVER = True
        Me.BtnEdit.GUI_ENABLED = True
        Me.BtnEdit.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnEdit.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Edit16
        Me.BtnEdit.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnEdit.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnEdit.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.Location = New System.Drawing.Point(7, 8)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.BtnEdit.Size = New System.Drawing.Size(137, 32)
        Me.BtnEdit.TabIndex = 0
        Me.BtnEdit.Text = "F1 EDIT"
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.UseVisualStyleBackColor = True
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
        Me.BtnPrint.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Printer20
        Me.BtnPrint.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnPrint.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnPrint.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPrint.Location = New System.Drawing.Point(579, 8)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.BtnPrint.Size = New System.Drawing.Size(137, 32)
        Me.BtnPrint.TabIndex = 6
        Me.BtnPrint.Text = "CTRL+P Print"
        Me.BtnPrint.UseVisualStyleBackColor = True
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
        Me.Btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btncancel.Location = New System.Drawing.Point(436, 8)
        Me.Btncancel.Name = "Btncancel"
        Me.Btncancel.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.Btncancel.Size = New System.Drawing.Size(137, 32)
        Me.Btncancel.TabIndex = 4
        Me.Btncancel.Text = "ESC  CANCEL"
        Me.Btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Btnsave.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Save26
        Me.Btnsave.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.Btnsave.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.Btnsave.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.Btnsave.Image = CType(resources.GetObject("Btnsave.Image"), System.Drawing.Image)
        Me.Btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnsave.Location = New System.Drawing.Point(293, 8)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.Btnsave.Size = New System.Drawing.Size(137, 32)
        Me.Btnsave.TabIndex = 3
        Me.Btnsave.Text = "F3  SAVE"
        Me.Btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnsave.UseVisualStyleBackColor = True
        '
        'TxtGross
        '
        Me.TxtGross.BackColor = System.Drawing.Color.White
        Me.TxtGross.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGross.ForeColor = System.Drawing.Color.Black
        Me.TxtGross.Location = New System.Drawing.Point(116, 29)
        Me.TxtGross.Name = "TxtGross"
        Me.TxtGross.ReadOnly = True
        Me.TxtGross.Size = New System.Drawing.Size(116, 31)
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
        Me.Label20.Location = New System.Drawing.Point(5, 80)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 15)
        Me.Label20.TabIndex = 140
        Me.Label20.Text = "Tare Weight"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(5, 113)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 15)
        Me.Label21.TabIndex = 144
        Me.Label21.Text = "Net Weight"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(5, 43)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(77, 15)
        Me.Label19.TabIndex = 142
        Me.Label19.Text = "Gross Weight"
        '
        'TxtTare
        '
        Me.TxtTare.BackColor = System.Drawing.Color.White
        Me.TxtTare.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTare.ForeColor = System.Drawing.Color.Black
        Me.TxtTare.Location = New System.Drawing.Point(116, 65)
        Me.TxtTare.Name = "TxtTare"
        Me.TxtTare.ReadOnly = True
        Me.TxtTare.Size = New System.Drawing.Size(116, 31)
        Me.TxtTare.TabIndex = 139
        Me.TxtTare.TabStop = False
        Me.TxtTare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNet
        '
        Me.TxtNet.BackColor = System.Drawing.Color.White
        Me.TxtNet.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNet.ForeColor = System.Drawing.Color.Black
        Me.TxtNet.Location = New System.Drawing.Point(116, 101)
        Me.TxtNet.Name = "TxtNet"
        Me.TxtNet.ReadOnly = True
        Me.TxtNet.Size = New System.Drawing.Size(116, 31)
        Me.TxtNet.TabIndex = 143
        Me.TxtNet.TabStop = False
        Me.TxtNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PnlMain
        '
        Me.PnlMain.AutoScroll = True
        Me.PnlMain.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PnlMain.Controls.Add(Me.PnlDetails)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 53)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Padding = New System.Windows.Forms.Padding(5)
        Me.PnlMain.Size = New System.Drawing.Size(1366, 547)
        Me.PnlMain.TabIndex = 0
        '
        'PnlDetails
        '
        Me.PnlDetails.AutoScroll = True
        Me.PnlDetails.BackColor = System.Drawing.Color.White
        Me.PnlDetails.BackgroundImage = Global.WeighingSystemV1_1.My.Resources.Resources.WhiteHeader1
        Me.PnlDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlDetails.Controls.Add(Me.PnlWeightStat)
        Me.PnlDetails.Controls.Add(Me.Panel2)
        Me.PnlDetails.Controls.Add(Me.Panel1)
        Me.PnlDetails.Controls.Add(Me.TxtRefNo)
        Me.PnlDetails.Controls.Add(Me.Label9)
        Me.PnlDetails.Controls.Add(Me.TxtRemarks)
        Me.PnlDetails.Controls.Add(Me.Label12)
        Me.PnlDetails.Controls.Add(Me.TxtDriver)
        Me.PnlDetails.Controls.Add(Me.Label11)
        Me.PnlDetails.Controls.Add(Me.Panel7)
        Me.PnlDetails.Controls.Add(Me.TxtPlateNo)
        Me.PnlDetails.Controls.Add(Me.TxtTicketNo)
        Me.PnlDetails.Controls.Add(Me.Label8)
        Me.PnlDetails.Controls.Add(Me.Label7)
        Me.PnlDetails.Controls.Add(Me.TxtDrNo)
        Me.PnlDetails.Controls.Add(Me.Label4)
        Me.PnlDetails.Controls.Add(Me.Panel4)
        Me.PnlDetails.Controls.Add(Me.Pnl_Weight)
        Me.PnlDetails.Location = New System.Drawing.Point(5, 5)
        Me.PnlDetails.Name = "PnlDetails"
        Me.PnlDetails.Size = New System.Drawing.Size(952, 768)
        Me.PnlDetails.TabIndex = 1
        '
        'PnlWeightStat
        '
        Me.PnlWeightStat.BackColor = System.Drawing.Color.Transparent
        Me.PnlWeightStat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlWeightStat.Controls.Add(Me.TxtReasons)
        Me.PnlWeightStat.Controls.Add(Me.Label17)
        Me.PnlWeightStat.Controls.Add(Me.LblFinalNetUnit)
        Me.PnlWeightStat.Controls.Add(Me.LblDedUnit)
        Me.PnlWeightStat.Controls.Add(Me.TxtDeduct)
        Me.PnlWeightStat.Controls.Add(Me.TxtFINAL)
        Me.PnlWeightStat.Controls.Add(Me.Label16)
        Me.PnlWeightStat.Controls.Add(Me.Label18)
        Me.PnlWeightStat.Location = New System.Drawing.Point(20, 321)
        Me.PnlWeightStat.Name = "PnlWeightStat"
        Me.PnlWeightStat.Size = New System.Drawing.Size(589, 120)
        Me.PnlWeightStat.TabIndex = 181
        '
        'TxtReasons
        '
        Me.TxtReasons.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtReasons.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtReasons.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtReasons.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReasons.Location = New System.Drawing.Point(91, 79)
        Me.TxtReasons.Name = "TxtReasons"
        Me.TxtReasons.Size = New System.Drawing.Size(491, 27)
        Me.TxtReasons.TabIndex = 171
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(9, 73)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 39)
        Me.Label17.TabIndex = 170
        Me.Label17.Text = "Reason For Deduction"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblFinalNetUnit
        '
        Me.LblFinalNetUnit.BackColor = System.Drawing.Color.Transparent
        Me.LblFinalNetUnit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFinalNetUnit.ForeColor = System.Drawing.Color.Black
        Me.LblFinalNetUnit.Location = New System.Drawing.Point(214, 51)
        Me.LblFinalNetUnit.Name = "LblFinalNetUnit"
        Me.LblFinalNetUnit.Size = New System.Drawing.Size(84, 15)
        Me.LblFinalNetUnit.TabIndex = 169
        Me.LblFinalNetUnit.Text = "(KG)"
        Me.LblFinalNetUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblDedUnit
        '
        Me.LblDedUnit.BackColor = System.Drawing.Color.Transparent
        Me.LblDedUnit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDedUnit.ForeColor = System.Drawing.Color.Black
        Me.LblDedUnit.Location = New System.Drawing.Point(211, 16)
        Me.LblDedUnit.Name = "LblDedUnit"
        Me.LblDedUnit.Size = New System.Drawing.Size(84, 15)
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
        Me.TxtDeduct.Location = New System.Drawing.Point(91, 11)
        Me.TxtDeduct.Name = "TxtDeduct"
        Me.TxtDeduct.Size = New System.Drawing.Size(115, 26)
        Me.TxtDeduct.TabIndex = 0
        Me.TxtDeduct.Text = "0.00"
        Me.TxtDeduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtFINAL
        '
        Me.TxtFINAL.BackColor = System.Drawing.SystemColors.Window
        Me.TxtFINAL.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFINAL.ForeColor = System.Drawing.Color.Black
        Me.TxtFINAL.Location = New System.Drawing.Point(91, 42)
        Me.TxtFINAL.Name = "TxtFINAL"
        Me.TxtFINAL.ReadOnly = True
        Me.TxtFINAL.Size = New System.Drawing.Size(115, 31)
        Me.TxtFINAL.TabIndex = 1
        Me.TxtFINAL.TabStop = False
        Me.TxtFINAL.Text = "64000"
        Me.TxtFINAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(9, 50)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 15)
        Me.Label16.TabIndex = 153
        Me.Label16.Text = "Final Net:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(9, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 36)
        Me.Label18.TabIndex = 167
        Me.Label18.Text = "Net Wt. Deduction (%):"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.WeighingSystemV1_1.My.Resources.Resources.WhiteHeader1
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 657)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(950, 109)
        Me.Panel2.TabIndex = 180
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.TxtDTUpd)
        Me.Panel3.Controls.Add(Me.TxtDTOut)
        Me.Panel3.Controls.Add(Me.TxtDTIn)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.txtWin)
        Me.Panel3.Controls.Add(Me.TxtWout)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.TxtUpdby)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(387, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(561, 107)
        Me.Panel3.TabIndex = 0
        '
        'TxtDTUpd
        '
        Me.TxtDTUpd.BackColor = System.Drawing.Color.White
        Me.TxtDTUpd.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDTUpd.ForeColor = System.Drawing.Color.Black
        Me.TxtDTUpd.Location = New System.Drawing.Point(415, 71)
        Me.TxtDTUpd.Name = "TxtDTUpd"
        Me.TxtDTUpd.ReadOnly = True
        Me.TxtDTUpd.Size = New System.Drawing.Size(139, 26)
        Me.TxtDTUpd.TabIndex = 168
        Me.TxtDTUpd.TabStop = False
        '
        'TxtDTOut
        '
        Me.TxtDTOut.BackColor = System.Drawing.Color.White
        Me.TxtDTOut.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDTOut.ForeColor = System.Drawing.Color.Black
        Me.TxtDTOut.Location = New System.Drawing.Point(415, 40)
        Me.TxtDTOut.Name = "TxtDTOut"
        Me.TxtDTOut.ReadOnly = True
        Me.TxtDTOut.Size = New System.Drawing.Size(139, 26)
        Me.TxtDTOut.TabIndex = 167
        Me.TxtDTOut.TabStop = False
        '
        'TxtDTIn
        '
        Me.TxtDTIn.BackColor = System.Drawing.Color.White
        Me.TxtDTIn.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDTIn.ForeColor = System.Drawing.Color.Black
        Me.TxtDTIn.Location = New System.Drawing.Point(415, 8)
        Me.TxtDTIn.Name = "TxtDTIn"
        Me.TxtDTIn.ReadOnly = True
        Me.TxtDTIn.Size = New System.Drawing.Size(139, 26)
        Me.TxtDTIn.TabIndex = 166
        Me.TxtDTIn.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(18, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 15)
        Me.Label10.TabIndex = 160
        Me.Label10.Text = "Weighed in By:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(18, 45)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 15)
        Me.Label14.TabIndex = 161
        Me.Label14.Text = "Weighed out By:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtWin
        '
        Me.txtWin.BackColor = System.Drawing.Color.White
        Me.txtWin.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWin.ForeColor = System.Drawing.Color.Black
        Me.txtWin.Location = New System.Drawing.Point(162, 8)
        Me.txtWin.Name = "txtWin"
        Me.txtWin.ReadOnly = True
        Me.txtWin.Size = New System.Drawing.Size(251, 26)
        Me.txtWin.TabIndex = 162
        Me.txtWin.TabStop = False
        '
        'TxtWout
        '
        Me.TxtWout.BackColor = System.Drawing.Color.White
        Me.TxtWout.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWout.ForeColor = System.Drawing.Color.Black
        Me.TxtWout.Location = New System.Drawing.Point(162, 40)
        Me.TxtWout.Name = "TxtWout"
        Me.TxtWout.ReadOnly = True
        Me.TxtWout.Size = New System.Drawing.Size(251, 26)
        Me.TxtWout.TabIndex = 163
        Me.TxtWout.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(18, 77)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(98, 15)
        Me.Label15.TabIndex = 164
        Me.Label15.Text = "Last Modified By:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TxtUpdby
        '
        Me.TxtUpdby.BackColor = System.Drawing.Color.White
        Me.TxtUpdby.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUpdby.ForeColor = System.Drawing.Color.Black
        Me.TxtUpdby.Location = New System.Drawing.Point(162, 72)
        Me.TxtUpdby.Name = "TxtUpdby"
        Me.TxtUpdby.ReadOnly = True
        Me.TxtUpdby.Size = New System.Drawing.Size(251, 26)
        Me.TxtUpdby.TabIndex = 165
        Me.TxtUpdby.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TxtGr_Time)
        Me.Panel1.Controls.Add(Me.TxtTR_Time)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxtGross)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.TxtTare)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.TxtNet)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(615, 146)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 169)
        Me.Panel1.TabIndex = 178
        '
        'TxtGr_Time
        '
        Me.TxtGr_Time.BackColor = System.Drawing.Color.White
        Me.TxtGr_Time.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtGr_Time.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGr_Time.ForeColor = System.Drawing.Color.Black
        Me.TxtGr_Time.Location = New System.Drawing.Point(238, 35)
        Me.TxtGr_Time.Name = "TxtGr_Time"
        Me.TxtGr_Time.ReadOnly = True
        Me.TxtGr_Time.Size = New System.Drawing.Size(75, 21)
        Me.TxtGr_Time.TabIndex = 150
        Me.TxtGr_Time.TabStop = False
        '
        'TxtTR_Time
        '
        Me.TxtTR_Time.BackColor = System.Drawing.Color.White
        Me.TxtTR_Time.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTR_Time.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTR_Time.ForeColor = System.Drawing.Color.Black
        Me.TxtTR_Time.Location = New System.Drawing.Point(238, 71)
        Me.TxtTR_Time.Name = "TxtTR_Time"
        Me.TxtTR_Time.ReadOnly = True
        Me.TxtTR_Time.Size = New System.Drawing.Size(75, 21)
        Me.TxtTR_Time.TabIndex = 148
        Me.TxtTR_Time.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(4, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 20)
        Me.Label3.TabIndex = 146
        Me.Label3.Text = "WEIGHT DATA"
        '
        'TxtRefNo
        '
        Me.TxtRefNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtRefNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtRefNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRefNo.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRefNo.Location = New System.Drawing.Point(772, 29)
        Me.TxtRefNo.Name = "TxtRefNo"
        Me.TxtRefNo.Size = New System.Drawing.Size(169, 43)
        Me.TxtRefNo.TabIndex = 176
        Me.TxtRefNo.Text = "00000001"
        Me.TxtRefNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(666, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 27)
        Me.Label9.TabIndex = 177
        Me.Label9.Text = "Receipt Number:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtRemarks
        '
        Me.TxtRemarks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtRemarks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtRemarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRemarks.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRemarks.Location = New System.Drawing.Point(112, 550)
        Me.TxtRemarks.Multiline = True
        Me.TxtRemarks.Name = "TxtRemarks"
        Me.TxtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtRemarks.Size = New System.Drawing.Size(457, 53)
        Me.TxtRemarks.TabIndex = 7
        Me.TxtRemarks.Text = "SAMPLE ONLY. TSI STANDARD SOFTWARE"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(20, 551)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 27)
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
        Me.TxtDriver.Location = New System.Drawing.Point(112, 521)
        Me.TxtDriver.Name = "TxtDriver"
        Me.TxtDriver.Size = New System.Drawing.Size(326, 27)
        Me.TxtDriver.TabIndex = 6
        Me.TxtDriver.Text = "JANNO GIBBS"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(20, 523)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 27)
        Me.Label11.TabIndex = 171
        Me.Label11.Text = "Driver Name"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.TxtPriceUnit)
        Me.Panel7.Controls.Add(Me.CboCommodity)
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Controls.Add(Me.BtnComm)
        Me.Panel7.Controls.Add(Me.TxtPrice)
        Me.Panel7.Controls.Add(Me.LblPrice)
        Me.Panel7.Location = New System.Drawing.Point(20, 240)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(589, 75)
        Me.Panel7.TabIndex = 3
        '
        'TxtPriceUnit
        '
        Me.TxtPriceUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtPriceUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtPriceUnit.BackColor = System.Drawing.Color.White
        Me.TxtPriceUnit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPriceUnit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPriceUnit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPriceUnit.Location = New System.Drawing.Point(215, 45)
        Me.TxtPriceUnit.Name = "TxtPriceUnit"
        Me.TxtPriceUnit.Size = New System.Drawing.Size(88, 20)
        Me.TxtPriceUnit.TabIndex = 2
        Me.TxtPriceUnit.TabStop = False
        Me.TxtPriceUnit.Text = "/KG"
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
        Me.CboCommodity.Location = New System.Drawing.Point(95, 7)
        Me.CboCommodity.MaxLength = 50
        Me.CboCommodity.Name = "CboCommodity"
        Me.CboCommodity.Size = New System.Drawing.Size(457, 27)
        Me.CboCommodity.Sorted = True
        Me.CboCommodity.TabIndex = 0
        Me.CboCommodity.Text = "MIXED WASTE"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 42)
        Me.Label2.TabIndex = 153
        Me.Label2.Text = "Commodity/Materials"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnComm
        '
        Me.BtnComm.BackgroundImage = CType(resources.GetObject("BtnComm.BackgroundImage"), System.Drawing.Image)
        Me.BtnComm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnComm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnComm.FlatAppearance.BorderSize = 0
        Me.BtnComm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnComm.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnComm.ForeColor = System.Drawing.Color.Black
        Me.BtnComm.GUI_ACCSS = "JMoiakne122208"
        Me.BtnComm.GUI_ENABLE_HOVER = True
        Me.BtnComm.GUI_ENABLED = True
        Me.BtnComm.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnComm.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnComm.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnComm.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnComm.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnComm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnComm.Location = New System.Drawing.Point(556, 7)
        Me.BtnComm.Name = "BtnComm"
        Me.BtnComm.Size = New System.Drawing.Size(26, 26)
        Me.BtnComm.TabIndex = 166
        Me.BtnComm.TabStop = False
        Me.BtnComm.Text = "..."
        Me.BtnComm.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnComm.UseVisualStyleBackColor = True
        Me.BtnComm.Visible = False
        '
        'TxtPrice
        '
        Me.TxtPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtPrice.BackColor = System.Drawing.Color.White
        Me.TxtPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPrice.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrice.Location = New System.Drawing.Point(97, 45)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Size = New System.Drawing.Size(112, 27)
        Me.TxtPrice.TabIndex = 1
        Me.TxtPrice.TabStop = False
        Me.TxtPrice.Text = "0.00"
        Me.TxtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblPrice
        '
        Me.LblPrice.BackColor = System.Drawing.Color.Transparent
        Me.LblPrice.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrice.ForeColor = System.Drawing.Color.Black
        Me.LblPrice.Location = New System.Drawing.Point(9, 38)
        Me.LblPrice.Name = "LblPrice"
        Me.LblPrice.Size = New System.Drawing.Size(77, 27)
        Me.LblPrice.TabIndex = 167
        Me.LblPrice.Text = "Price"
        Me.LblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtPlateNo
        '
        Me.TxtPlateNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtPlateNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtPlateNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPlateNo.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPlateNo.Location = New System.Drawing.Point(116, 103)
        Me.TxtPlateNo.Name = "TxtPlateNo"
        Me.TxtPlateNo.Size = New System.Drawing.Size(223, 37)
        Me.TxtPlateNo.TabIndex = 1
        Me.TxtPlateNo.Text = "ABC 123"
        '
        'TxtTicketNo
        '
        Me.TxtTicketNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtTicketNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtTicketNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTicketNo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTicketNo.Location = New System.Drawing.Point(112, 492)
        Me.TxtTicketNo.Name = "TxtTicketNo"
        Me.TxtTicketNo.Size = New System.Drawing.Size(186, 27)
        Me.TxtTicketNo.TabIndex = 5
        Me.TxtTicketNo.Text = "108"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(20, 493)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 27)
        Me.Label8.TabIndex = 164
        Me.Label8.Text = "Lorry/ISO #"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(20, 464)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 27)
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
        Me.TxtDrNo.Location = New System.Drawing.Point(112, 463)
        Me.TxtDrNo.Name = "TxtDrNo"
        Me.TxtDrNo.Size = New System.Drawing.Size(186, 27)
        Me.TxtDrNo.TabIndex = 4
        Me.TxtDrNo.Text = "9879-16587"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(27, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 40)
        Me.Label4.TabIndex = 160
        Me.Label4.Text = "Plate Number:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.TxtAddress)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.BtnClient)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.RdoSup)
        Me.Panel4.Controls.Add(Me.CboClient)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.RdoCust)
        Me.Panel4.Location = New System.Drawing.Point(20, 146)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(589, 92)
        Me.Panel4.TabIndex = 2
        '
        'TxtAddress
        '
        Me.TxtAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtAddress.BackColor = System.Drawing.Color.White
        Me.TxtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAddress.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddress.Location = New System.Drawing.Point(97, 63)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(454, 19)
        Me.TxtAddress.TabIndex = 3
        Me.TxtAddress.TabStop = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(9, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 27)
        Me.Label13.TabIndex = 160
        Me.Label13.Text = "Address:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnClient
        '
        Me.BtnClient.BackgroundImage = CType(resources.GetObject("BtnClient.BackgroundImage"), System.Drawing.Image)
        Me.BtnClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnClient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClient.FlatAppearance.BorderSize = 0
        Me.BtnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClient.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClient.ForeColor = System.Drawing.Color.Black
        Me.BtnClient.GUI_ACCSS = "JMoiakne122208"
        Me.BtnClient.GUI_ENABLE_HOVER = True
        Me.BtnClient.GUI_ENABLED = True
        Me.BtnClient.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnClient.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnClient.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnClient.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnClient.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClient.Location = New System.Drawing.Point(556, 29)
        Me.BtnClient.Name = "BtnClient"
        Me.BtnClient.Size = New System.Drawing.Size(26, 27)
        Me.BtnClient.TabIndex = 159
        Me.BtnClient.TabStop = False
        Me.BtnClient.Text = "..."
        Me.BtnClient.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnClient.UseVisualStyleBackColor = True
        Me.BtnClient.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(9, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 27)
        Me.Label5.TabIndex = 158
        Me.Label5.Text = "Name:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RdoSup
        '
        Me.RdoSup.AutoSize = True
        Me.RdoSup.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoSup.Location = New System.Drawing.Point(182, 6)
        Me.RdoSup.Name = "RdoSup"
        Me.RdoSup.Size = New System.Drawing.Size(78, 22)
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
        Me.CboClient.Location = New System.Drawing.Point(95, 31)
        Me.CboClient.MaxLength = 50
        Me.CboClient.Name = "CboClient"
        Me.CboClient.Size = New System.Drawing.Size(456, 27)
        Me.CboClient.Sorted = True
        Me.CboClient.TabIndex = 2
        Me.CboClient.Text = "TERRINIEL SCALES INC."
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 27)
        Me.Label1.TabIndex = 151
        Me.Label1.Text = "Client Type:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RdoCust
        '
        Me.RdoCust.AutoSize = True
        Me.RdoCust.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoCust.Location = New System.Drawing.Point(97, 6)
        Me.RdoCust.Name = "RdoCust"
        Me.RdoCust.Size = New System.Drawing.Size(86, 22)
        Me.RdoCust.TabIndex = 0
        Me.RdoCust.TabStop = True
        Me.RdoCust.Text = "Customer"
        Me.RdoCust.UseVisualStyleBackColor = True
        '
        'Pnl_Weight
        '
        Me.Pnl_Weight.BackColor = System.Drawing.Color.Transparent
        Me.Pnl_Weight.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl_Weight.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_Weight.Name = "Pnl_Weight"
        Me.Pnl_Weight.Size = New System.Drawing.Size(950, 23)
        Me.Pnl_Weight.TabIndex = 0
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
        Me.Code.Name = "Code"
        Me.Code.Width = 200
        '
        'Col_Desc
        '
        Me.Col_Desc.HeaderText = "Description"
        Me.Col_Desc.MaxInputLength = 35
        Me.Col_Desc.Name = "Col_Desc"
        Me.Col_Desc.Width = 300
        '
        'FrmEditTrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1366, 600)
        Me.Controls.Add(Me.PnlMain)
        Me.Controls.Add(Me.PnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmEditTrans"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTrans"
        Me.PnlHeader.ResumeLayout(False)
        Me.PnlMain.ResumeLayout(False)
        Me.PnlDetails.ResumeLayout(False)
        Me.PnlDetails.PerformLayout()
        Me.PnlWeightStat.ResumeLayout(False)
        Me.PnlWeightStat.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnEdit As MykeCtrlEx.PushButton
    Friend WithEvents Btnsave As MykeCtrlEx.PushButton
    Friend WithEvents Btncancel As MykeCtrlEx.PushButton
    Friend WithEvents BtnPrint As MykeCtrlEx.PushButton
    Friend WithEvents PnlHeader As System.Windows.Forms.Panel
    Friend WithEvents BtnExit As MykeCtrlEx.PushButton
    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents PnlDetails As System.Windows.Forms.Panel
    Friend WithEvents Pnl_Weight As System.Windows.Forms.Panel
    Friend WithEvents TxtGross As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TxtTare As System.Windows.Forms.TextBox
    Friend WithEvents TxtNet As System.Windows.Forms.TextBox
    Friend WithEvents CboClient As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RdoCust As System.Windows.Forms.RadioButton
    Friend WithEvents RdoSup As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtPlateNo As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CboCommodity As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtDrNo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtTicketNo As System.Windows.Forms.TextBox
    Friend WithEvents BtnClient As MykeCtrlEx.PushButton
    Friend WithEvents BtnComm As MykeCtrlEx.PushButton
    Friend WithEvents LblPrice As System.Windows.Forms.Label
    Friend WithEvents TxtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents TxtDriver As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents BtnDelete As MykeCtrlEx.PushButton
    Friend WithEvents TxtPriceUnit As System.Windows.Forms.TextBox
    Friend WithEvents TxtRefNo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtGr_Time As System.Windows.Forms.TextBox
    Friend WithEvents TxtTR_Time As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TxtDTUpd As System.Windows.Forms.TextBox
    Friend WithEvents TxtDTOut As System.Windows.Forms.TextBox
    Friend WithEvents TxtDTIn As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtWin As System.Windows.Forms.TextBox
    Friend WithEvents TxtWout As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtUpdby As System.Windows.Forms.TextBox
    Friend WithEvents PnlWeightStat As System.Windows.Forms.Panel
    Friend WithEvents TxtReasons As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents LblFinalNetUnit As System.Windows.Forms.Label
    Friend WithEvents LblDedUnit As System.Windows.Forms.Label
    Friend WithEvents TxtDeduct As System.Windows.Forms.TextBox
    Friend WithEvents TxtFINAL As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents BtnUpdatePrice As MykeCtrlEx.PushButton
End Class
