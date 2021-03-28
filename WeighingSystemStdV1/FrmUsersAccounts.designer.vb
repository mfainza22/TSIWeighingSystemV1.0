<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsersAccounts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsersAccounts))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnSave = New MykeCtrlEx.PushButton()
        Me.BtnCancel = New MykeCtrlEx.PushButton()
        Me.BtnDelete = New MykeCtrlEx.PushButton()
        Me.BtnEdit = New MykeCtrlEx.PushButton()
        Me.BtnAdd = New MykeCtrlEx.PushButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnExit = New MykeCtrlEx.PushButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DG = New System.Windows.Forms.DataGridView()
        Me.Col_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_DisplayName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_ContactNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Online = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Offline = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Inbound = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Management = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_DB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Reports = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Settings = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_UserControl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_ModTrans = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_ReprintTrans = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Logs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.BtnFirst = New System.Windows.Forms.ToolStripButton()
        Me.BtnBack = New System.Windows.Forms.ToolStripButton()
        Me.LblRecord = New System.Windows.Forms.ToolStripTextBox()
        Me.BtnNext = New System.Windows.Forms.ToolStripButton()
        Me.BtnLast = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DgPermission = New System.Windows.Forms.DataGridView()
        Me.Col_Access = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Allow = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Col_write = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtConfirm = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtUserName = New System.Windows.Forms.TextBox()
        Me.TxtDisplayName = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtContactNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DgPermission, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Panel4.BackgroundImage = Global.WeighingSystemV1_1.My.Resources.Resources.WhiteHeader3
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Controls.Add(Me.BtnSave)
        Me.Panel4.Controls.Add(Me.BtnCancel)
        Me.Panel4.Controls.Add(Me.BtnDelete)
        Me.Panel4.Controls.Add(Me.BtnEdit)
        Me.Panel4.Controls.Add(Me.BtnAdd)
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1018, 43)
        Me.Panel4.TabIndex = 1
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImage = CType(resources.GetObject("BtnSave.BackgroundImage"), System.Drawing.Image)
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.ForeColor = System.Drawing.Color.Maroon
        Me.BtnSave.GUI_ACCSS = "JMoiakne122208"
        Me.BtnSave.GUI_ENABLE_HOVER = True
        Me.BtnSave.GUI_ENABLED = True
        Me.BtnSave.GUI_FORECOLOR_HOVER = System.Drawing.Color.Empty
        Me.BtnSave.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Save26
        Me.BtnSave.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickYellow
        Me.BtnSave.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnSave.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(314, 6)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(95, 31)
        Me.BtnSave.TabIndex = 147
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.BackgroundImage = CType(resources.GetObject("BtnCancel.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnCancel.ForeColor = System.Drawing.Color.Maroon
        Me.BtnCancel.GUI_ACCSS = "JMoiakne122208"
        Me.BtnCancel.GUI_ENABLE_HOVER = True
        Me.BtnCancel.GUI_ENABLED = True
        Me.BtnCancel.GUI_FORECOLOR_HOVER = System.Drawing.Color.Empty
        Me.BtnCancel.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Cancel32
        Me.BtnCancel.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickYellow
        Me.BtnCancel.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnCancel.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancel.Location = New System.Drawing.Point(415, 6)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(108, 31)
        Me.BtnCancel.TabIndex = 146
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.BackgroundImage = CType(resources.GetObject("BtnDelete.BackgroundImage"), System.Drawing.Image)
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnDelete.ForeColor = System.Drawing.Color.Maroon
        Me.BtnDelete.GUI_ACCSS = "JMoiakne122208"
        Me.BtnDelete.GUI_ENABLE_HOVER = True
        Me.BtnDelete.GUI_ENABLED = True
        Me.BtnDelete.GUI_FORECOLOR_HOVER = System.Drawing.Color.Empty
        Me.BtnDelete.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Delete16
        Me.BtnDelete.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickYellow
        Me.BtnDelete.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnDelete.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(213, 7)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(95, 28)
        Me.BtnDelete.TabIndex = 145
        Me.BtnDelete.Text = "&Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.BackgroundImage = CType(resources.GetObject("BtnEdit.BackgroundImage"), System.Drawing.Image)
        Me.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEdit.FlatAppearance.BorderSize = 0
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnEdit.ForeColor = System.Drawing.Color.Maroon
        Me.BtnEdit.GUI_ACCSS = "JMoiakne122208"
        Me.BtnEdit.GUI_ENABLE_HOVER = True
        Me.BtnEdit.GUI_ENABLED = True
        Me.BtnEdit.GUI_FORECOLOR_HOVER = System.Drawing.Color.Empty
        Me.BtnEdit.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Edit16
        Me.BtnEdit.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickYellow
        Me.BtnEdit.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnEdit.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.Location = New System.Drawing.Point(112, 7)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(95, 28)
        Me.BtnEdit.TabIndex = 144
        Me.BtnEdit.Text = "&Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.BackgroundImage = CType(resources.GetObject("BtnAdd.BackgroundImage"), System.Drawing.Image)
        Me.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.FlatAppearance.BorderSize = 0
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnAdd.ForeColor = System.Drawing.Color.Maroon
        Me.BtnAdd.GUI_ACCSS = "JMoiakne122208"
        Me.BtnAdd.GUI_ENABLE_HOVER = True
        Me.BtnAdd.GUI_ENABLED = True
        Me.BtnAdd.GUI_FORECOLOR_HOVER = System.Drawing.Color.Empty
        Me.BtnAdd.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Add16
        Me.BtnAdd.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickYellow
        Me.BtnAdd.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnAdd.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnAdd.Image = CType(resources.GetObject("BtnAdd.Image"), System.Drawing.Image)
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdd.Location = New System.Drawing.Point(11, 6)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(95, 28)
        Me.BtnAdd.TabIndex = 143
        Me.BtnAdd.Text = "&Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.BtnExit)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(938, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(80, 43)
        Me.Panel3.TabIndex = 8
        '
        'BtnExit
        '
        Me.BtnExit.BackgroundImage = CType(resources.GetObject("BtnExit.BackgroundImage"), System.Drawing.Image)
        Me.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnExit.ForeColor = System.Drawing.Color.Maroon
        Me.BtnExit.GUI_ACCSS = "JMoiakne122208"
        Me.BtnExit.GUI_ENABLE_HOVER = True
        Me.BtnExit.GUI_ENABLED = True
        Me.BtnExit.GUI_FORECOLOR_HOVER = System.Drawing.Color.Empty
        Me.BtnExit.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Home24
        Me.BtnExit.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickYellow
        Me.BtnExit.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnExit.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
        Me.BtnExit.Location = New System.Drawing.Point(9, 6)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(63, 31)
        Me.BtnExit.TabIndex = 142
        Me.BtnExit.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.DG)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel2.Size = New System.Drawing.Size(297, 595)
        Me.Panel2.TabIndex = 0
        '
        'DG
        '
        Me.DG.AllowUserToAddRows = False
        Me.DG.AllowUserToDeleteRows = False
        Me.DG.AllowUserToResizeColumns = False
        Me.DG.AllowUserToResizeRows = False
        Me.DG.BackgroundColor = System.Drawing.Color.White
        Me.DG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_Id, Me.Col_Name, Me.Col_DisplayName, Me.Col_Password, Me.Col_ContactNo, Me.Col_Online, Me.Col_Offline, Me.Col_Inbound, Me.Col_Management, Me.Col_DB, Me.Col_Reports, Me.Col_Settings, Me.Col_UserControl, Me.Col_ModTrans, Me.Col_ReprintTrans, Me.Col_Logs})
        Me.DG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DG.Location = New System.Drawing.Point(5, 99)
        Me.DG.MultiSelect = False
        Me.DG.Name = "DG"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Aqua
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Aqua
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DimGray
        Me.DG.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG.Size = New System.Drawing.Size(287, 491)
        Me.DG.TabIndex = 0
        '
        'Col_Id
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.Col_Id.DefaultCellStyle = DataGridViewCellStyle2
        Me.Col_Id.HeaderText = "ID"
        Me.Col_Id.MaxInputLength = 0
        Me.Col_Id.MinimumWidth = 2
        Me.Col_Id.Name = "Col_Id"
        Me.Col_Id.ReadOnly = True
        Me.Col_Id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Col_Id.Width = 2
        '
        'Col_Name
        '
        Me.Col_Name.HeaderText = "User Name"
        Me.Col_Name.Name = "Col_Name"
        Me.Col_Name.ReadOnly = True
        Me.Col_Name.Visible = False
        Me.Col_Name.Width = 250
        '
        'Col_DisplayName
        '
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.Col_DisplayName.DefaultCellStyle = DataGridViewCellStyle3
        Me.Col_DisplayName.HeaderText = "Display Name"
        Me.Col_DisplayName.MaxInputLength = 300
        Me.Col_DisplayName.Name = "Col_DisplayName"
        Me.Col_DisplayName.Width = 350
        '
        'Col_Password
        '
        Me.Col_Password.HeaderText = "Password"
        Me.Col_Password.Name = "Col_Password"
        Me.Col_Password.Visible = False
        '
        'Col_ContactNo
        '
        Me.Col_ContactNo.HeaderText = "ContactNo"
        Me.Col_ContactNo.Name = "Col_ContactNo"
        Me.Col_ContactNo.Visible = False
        '
        'Col_Online
        '
        Me.Col_Online.HeaderText = "Online"
        Me.Col_Online.Name = "Col_Online"
        Me.Col_Online.Visible = False
        '
        'Col_Offline
        '
        Me.Col_Offline.HeaderText = "Offline"
        Me.Col_Offline.Name = "Col_Offline"
        Me.Col_Offline.Visible = False
        '
        'Col_Inbound
        '
        Me.Col_Inbound.HeaderText = "Inbound"
        Me.Col_Inbound.Name = "Col_Inbound"
        Me.Col_Inbound.Visible = False
        '
        'Col_Management
        '
        Me.Col_Management.HeaderText = "Managemenet"
        Me.Col_Management.Name = "Col_Management"
        Me.Col_Management.Visible = False
        '
        'Col_DB
        '
        Me.Col_DB.HeaderText = "DB"
        Me.Col_DB.Name = "Col_DB"
        Me.Col_DB.Visible = False
        '
        'Col_Reports
        '
        Me.Col_Reports.HeaderText = "Reports"
        Me.Col_Reports.Name = "Col_Reports"
        Me.Col_Reports.Visible = False
        '
        'Col_Settings
        '
        Me.Col_Settings.HeaderText = "Settings"
        Me.Col_Settings.Name = "Col_Settings"
        Me.Col_Settings.Visible = False
        '
        'Col_UserControl
        '
        Me.Col_UserControl.HeaderText = "UserControl"
        Me.Col_UserControl.Name = "Col_UserControl"
        Me.Col_UserControl.Visible = False
        '
        'Col_ModTrans
        '
        Me.Col_ModTrans.HeaderText = "ModTrans"
        Me.Col_ModTrans.Name = "Col_ModTrans"
        Me.Col_ModTrans.Visible = False
        '
        'Col_ReprintTrans
        '
        Me.Col_ReprintTrans.HeaderText = "RePrint"
        Me.Col_ReprintTrans.Name = "Col_ReprintTrans"
        Me.Col_ReprintTrans.Visible = False
        '
        'Col_Logs
        '
        Me.Col_Logs.HeaderText = "Logs"
        Me.Col_Logs.Name = "Col_Logs"
        Me.Col_Logs.Visible = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Panel5.BackgroundImage = Global.WeighingSystemV1_1.My.Resources.Resources.WhiteHeader1
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Controls.Add(Me.TxtSearch)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(5, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(287, 94)
        Me.Panel5.TabIndex = 60
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(7, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 15)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "Search"
        '
        'TxtSearch
        '
        Me.TxtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSearch.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.Location = New System.Drawing.Point(7, 66)
        Me.TxtSearch.MaxLength = 50
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(268, 23)
        Me.TxtSearch.TabIndex = 60
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.BackgroundImage = Global.WeighingSystemV1_1.My.Resources.Resources.WhiteHeader3
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.BtnFirst, Me.BtnBack, Me.LblRecord, Me.BtnNext, Me.BtnLast, Me.ToolStripSeparator1, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 638)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1018, 33)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripLabel1.Margin = New System.Windows.Forms.Padding(27, 1, 0, 2)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(44, 30)
        Me.ToolStripLabel1.Text = "Record"
        '
        'BtnFirst
        '
        Me.BtnFirst.AutoSize = False
        Me.BtnFirst.BackColor = System.Drawing.Color.Transparent
        Me.BtnFirst.BackgroundImage = CType(resources.GetObject("BtnFirst.BackgroundImage"), System.Drawing.Image)
        Me.BtnFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(24, 24)
        '
        'BtnBack
        '
        Me.BtnBack.AutoSize = False
        Me.BtnBack.BackColor = System.Drawing.Color.Transparent
        Me.BtnBack.BackgroundImage = CType(resources.GetObject("BtnBack.BackgroundImage"), System.Drawing.Image)
        Me.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnBack.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(24, 24)
        '
        'LblRecord
        '
        Me.LblRecord.AutoSize = False
        Me.LblRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblRecord.Name = "LblRecord"
        Me.LblRecord.Size = New System.Drawing.Size(100, 23)
        Me.LblRecord.Text = "0 of 0"
        Me.LblRecord.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnNext
        '
        Me.BtnNext.AutoSize = False
        Me.BtnNext.BackColor = System.Drawing.Color.Transparent
        Me.BtnNext.BackgroundImage = CType(resources.GetObject("BtnNext.BackgroundImage"), System.Drawing.Image)
        Me.BtnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnNext.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(24, 24)
        '
        'BtnLast
        '
        Me.BtnLast.AutoSize = False
        Me.BtnLast.BackColor = System.Drawing.Color.Transparent
        Me.BtnLast.BackgroundImage = CType(resources.GetObject("BtnLast.BackgroundImage"), System.Drawing.Image)
        Me.BtnLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(24, 24)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(139, 30)
        Me.ToolStripLabel2.Text = "TABLE: USER ACCOUNTS"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(14, 3)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 22)
        Me.Label13.TabIndex = 116
        Me.Label13.Text = "Access"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.DgPermission)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(297, 304)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5, 30, 5, 5)
        Me.Panel1.Size = New System.Drawing.Size(721, 334)
        Me.Panel1.TabIndex = 117
        '
        'DgPermission
        '
        Me.DgPermission.AllowUserToAddRows = False
        Me.DgPermission.AllowUserToDeleteRows = False
        Me.DgPermission.AllowUserToResizeColumns = False
        Me.DgPermission.AllowUserToResizeRows = False
        Me.DgPermission.BackgroundColor = System.Drawing.Color.White
        Me.DgPermission.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgPermission.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DgPermission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgPermission.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_Access, Me.Col_Allow, Me.Col_write})
        Me.DgPermission.Dock = System.Windows.Forms.DockStyle.Left
        Me.DgPermission.GridColor = System.Drawing.Color.White
        Me.DgPermission.Location = New System.Drawing.Point(5, 30)
        Me.DgPermission.Name = "DgPermission"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Aqua
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgPermission.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Aqua
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.DimGray
        Me.DgPermission.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DgPermission.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgPermission.Size = New System.Drawing.Size(544, 299)
        Me.DgPermission.TabIndex = 1
        '
        'Col_Access
        '
        Me.Col_Access.HeaderText = "Permission"
        Me.Col_Access.Name = "Col_Access"
        Me.Col_Access.ReadOnly = True
        Me.Col_Access.Width = 250
        '
        'Col_Allow
        '
        Me.Col_Allow.HeaderText = "Allow"
        Me.Col_Allow.Name = "Col_Allow"
        Me.Col_Allow.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Col_Allow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Col_write
        '
        Me.Col_write.HeaderText = "Read/Write"
        Me.Col_write.Name = "Col_write"
        Me.Col_write.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Controls.Add(Me.TxtId)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.TxtConfirm)
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.TxtUserName)
        Me.Panel6.Controls.Add(Me.TxtDisplayName)
        Me.Panel6.Controls.Add(Me.TxtPassword)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.TxtContactNo)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(297, 43)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(721, 261)
        Me.Panel6.TabIndex = 118
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(555, 182)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 15)
        Me.Label12.TabIndex = 133
        Me.Label12.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(436, 129)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 15)
        Me.Label11.TabIndex = 132
        Me.Label11.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(436, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 15)
        Me.Label9.TabIndex = 131
        Me.Label9.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(436, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 15)
        Me.Label8.TabIndex = 130
        Me.Label8.Text = "*"
        '
        'TxtId
        '
        Me.TxtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtId.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtId.Location = New System.Drawing.Point(332, 16)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(217, 26)
        Me.TxtId.TabIndex = 116
        Me.TxtId.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(261, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "RECORD ID"
        '
        'TxtConfirm
        '
        Me.TxtConfirm.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtConfirm.Location = New System.Drawing.Point(162, 128)
        Me.TxtConfirm.MaxLength = 50
        Me.TxtConfirm.Name = "TxtConfirm"
        Me.TxtConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtConfirm.Size = New System.Drawing.Size(273, 26)
        Me.TxtConfirm.TabIndex = 119
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(38, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 26)
        Me.Label10.TabIndex = 129
        Me.Label10.Text = "RE-ENTER PASSWORD"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(15, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 22)
        Me.Label7.TabIndex = 128
        Me.Label7.Text = "Account Info"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(38, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 14)
        Me.Label5.TabIndex = 124
        Me.Label5.Text = "PASSWORD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(38, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 14)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "USER NAME"
        '
        'TxtUserName
        '
        Me.TxtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtUserName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUserName.Location = New System.Drawing.Point(162, 58)
        Me.TxtUserName.MaxLength = 50
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(273, 26)
        Me.TxtUserName.TabIndex = 117
        '
        'TxtDisplayName
        '
        Me.TxtDisplayName.AcceptsReturn = True
        Me.TxtDisplayName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDisplayName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDisplayName.Location = New System.Drawing.Point(162, 182)
        Me.TxtDisplayName.MaxLength = 50
        Me.TxtDisplayName.Name = "TxtDisplayName"
        Me.TxtDisplayName.Size = New System.Drawing.Size(387, 26)
        Me.TxtDisplayName.TabIndex = 120
        '
        'TxtPassword
        '
        Me.TxtPassword.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(162, 93)
        Me.TxtPassword.MaxLength = 50
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TxtPassword.Size = New System.Drawing.Size(273, 26)
        Me.TxtPassword.TabIndex = 118
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(36, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 14)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "DISPLAY NAME"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(15, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 22)
        Me.Label6.TabIndex = 127
        Me.Label6.Text = "Basic Information"
        '
        'TxtContactNo
        '
        Me.TxtContactNo.AcceptsReturn = True
        Me.TxtContactNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtContactNo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContactNo.Location = New System.Drawing.Point(162, 220)
        Me.TxtContactNo.MaxLength = 50
        Me.TxtContactNo.Name = "TxtContactNo"
        Me.TxtContactNo.Size = New System.Drawing.Size(115, 26)
        Me.TxtContactNo.TabIndex = 121
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(37, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 14)
        Me.Label4.TabIndex = 126
        Me.Label4.Text = "CONTACT NUMBER"
        '
        'FrmUsersAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.WeighingSystemV1_1.My.Resources.Resources.f
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1018, 671)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FrmUsersAccounts"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Control Maintenance"
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgPermission, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LblRecord As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BtnNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnFirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnBack As System.Windows.Forms.ToolStripButton
    Friend WithEvents DG As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents DgPermission As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtConfirm As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtUserName As System.Windows.Forms.TextBox
    Friend WithEvents TxtDisplayName As System.Windows.Forms.TextBox
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtContactNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Col_Access As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Allow As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Col_write As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BtnAdd As MykeCtrlEx.PushButton
    Friend WithEvents BtnExit As MykeCtrlEx.PushButton
    Friend WithEvents BtnEdit As MykeCtrlEx.PushButton
    Friend WithEvents BtnSave As MykeCtrlEx.PushButton
    Friend WithEvents BtnCancel As MykeCtrlEx.PushButton
    Friend WithEvents BtnDelete As MykeCtrlEx.PushButton
    Friend WithEvents Col_Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_DisplayName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Password As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_ContactNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Online As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Offline As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Inbound As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Management As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_DB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Reports As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Settings As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_UserControl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_ModTrans As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_ReprintTrans As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Logs As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
