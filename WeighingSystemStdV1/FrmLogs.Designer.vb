<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogs
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogs))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnExit = New MykeCtrlEx.PushButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DgError = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_CUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Eremarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_ELImg = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.BtnErrorClearLogs = New MykeCtrlEx.PushButton()
        Me.BtnEGen = New MykeCtrlEx.PushButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtEUser = New System.Windows.Forms.TextBox()
        Me.DTETo = New System.Windows.Forms.DateTimePicker()
        Me.TxtELoc = New System.Windows.Forms.ComboBox()
        Me.DTEFrom = New System.Windows.Forms.DateTimePicker()
        Me.DgUser = New System.Windows.Forms.DataGridView()
        Me.Col_User = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Activity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_ULimg = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.BtnClearUserlogs = New MykeCtrlEx.PushButton()
        Me.BtnUGen = New MykeCtrlEx.PushButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTUTo = New System.Windows.Forms.DateTimePicker()
        Me.TxtUUser = New System.Windows.Forms.TextBox()
        Me.TxtUACt = New System.Windows.Forms.ComboBox()
        Me.TxtULoc = New System.Windows.Forms.ComboBox()
        Me.DTUFrom = New System.Windows.Forms.DateTimePicker()
        Me.Img_Lst = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DgError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.DgUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Panel4.BackgroundImage = Global.WeighingSystemV1_1.My.Resources.Resources.WhiteHeader3
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1035, 44)
        Me.Panel4.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.BtnExit)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(953, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(80, 42)
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
        Me.Panel2.Controls.Add(Me.DgError)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.DgUser)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel2.Size = New System.Drawing.Size(1035, 502)
        Me.Panel2.TabIndex = 3
        '
        'DgError
        '
        Me.DgError.AllowUserToAddRows = False
        Me.DgError.AllowUserToDeleteRows = False
        Me.DgError.BackgroundColor = System.Drawing.Color.White
        Me.DgError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgError.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgError.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.Col_CUser, Me.Col_Eremarks, Me.Col_ELImg})
        Me.DgError.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgError.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgError.Location = New System.Drawing.Point(5, 391)
        Me.DgError.MultiSelect = False
        Me.DgError.Name = "DgError"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Aqua
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgError.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgError.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Aqua
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray
        Me.DgError.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgError.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.DgError.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgError.Size = New System.Drawing.Size(1025, 106)
        Me.DgError.TabIndex = 6
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Log Summary"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 500
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 130
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Date / Time"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 170
        '
        'Col_CUser
        '
        Me.Col_CUser.HeaderText = "User"
        Me.Col_CUser.Name = "Col_CUser"
        Me.Col_CUser.Width = 250
        '
        'Col_Eremarks
        '
        Me.Col_Eremarks.HeaderText = "Remarks"
        Me.Col_Eremarks.Name = "Col_Eremarks"
        Me.Col_Eremarks.Width = 150
        '
        'Col_ELImg
        '
        Me.Col_ELImg.HeaderText = ""
        Me.Col_ELImg.Name = "Col_ELImg"
        Me.Col_ELImg.Width = 30
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.WeighingSystemV1_1.My.Resources.Resources.WhiteHeader1
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TxtEUser)
        Me.Panel1.Controls.Add(Me.DTETo)
        Me.Panel1.Controls.Add(Me.TxtELoc)
        Me.Panel1.Controls.Add(Me.DTEFrom)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(5, 291)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1025, 100)
        Me.Panel1.TabIndex = 5
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.Controls.Add(Me.BtnErrorClearLogs)
        Me.Panel7.Controls.Add(Me.BtnEGen)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(871, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(154, 100)
        Me.Panel7.TabIndex = 159
        '
        'BtnErrorClearLogs
        '
        Me.BtnErrorClearLogs.BackgroundImage = CType(resources.GetObject("BtnErrorClearLogs.BackgroundImage"), System.Drawing.Image)
        Me.BtnErrorClearLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnErrorClearLogs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnErrorClearLogs.FlatAppearance.BorderSize = 0
        Me.BtnErrorClearLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnErrorClearLogs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnErrorClearLogs.ForeColor = System.Drawing.Color.Maroon
        Me.BtnErrorClearLogs.GUI_ACCSS = "JMoiakne122208"
        Me.BtnErrorClearLogs.GUI_ENABLE_HOVER = True
        Me.BtnErrorClearLogs.GUI_ENABLED = True
        Me.BtnErrorClearLogs.GUI_FORECOLOR_HOVER = System.Drawing.Color.Empty
        Me.BtnErrorClearLogs.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnErrorClearLogs.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnErrorClearLogs.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnErrorClearLogs.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnErrorClearLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnErrorClearLogs.Location = New System.Drawing.Point(7, 24)
        Me.BtnErrorClearLogs.Name = "BtnErrorClearLogs"
        Me.BtnErrorClearLogs.Size = New System.Drawing.Size(139, 46)
        Me.BtnErrorClearLogs.TabIndex = 150
        Me.BtnErrorClearLogs.Text = "Clear Error Logs"
        Me.BtnErrorClearLogs.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnErrorClearLogs.UseVisualStyleBackColor = True
        '
        'BtnEGen
        '
        Me.BtnEGen.BackgroundImage = CType(resources.GetObject("BtnEGen.BackgroundImage"), System.Drawing.Image)
        Me.BtnEGen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEGen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEGen.FlatAppearance.BorderSize = 0
        Me.BtnEGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEGen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnEGen.ForeColor = System.Drawing.Color.Maroon
        Me.BtnEGen.GUI_ACCSS = "JMoiakne122208"
        Me.BtnEGen.GUI_ENABLE_HOVER = True
        Me.BtnEGen.GUI_ENABLED = True
        Me.BtnEGen.GUI_FORECOLOR_HOVER = System.Drawing.Color.Empty
        Me.BtnEGen.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnEGen.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnEGen.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnEGen.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnEGen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEGen.Location = New System.Drawing.Point(7, 72)
        Me.BtnEGen.Name = "BtnEGen"
        Me.BtnEGen.Size = New System.Drawing.Size(139, 22)
        Me.BtnEGen.TabIndex = 149
        Me.BtnEGen.Text = "Generate"
        Me.BtnEGen.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnEGen.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(512, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 14)
        Me.Label11.TabIndex = 158
        Me.Label11.Text = "TO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(500, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 14)
        Me.Label10.TabIndex = 157
        Me.Label10.Text = "FROM"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(11, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 14)
        Me.Label9.TabIndex = 156
        Me.Label9.Text = "USER NAME"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(7, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 14)
        Me.Label6.TabIndex = 155
        Me.Label6.Text = "FILTER PANEL: ERROR LOGS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(536, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 14)
        Me.Label7.TabIndex = 154
        Me.Label7.Text = "DATE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(363, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 14)
        Me.Label8.TabIndex = 153
        Me.Label8.Text = "LOCATION"
        '
        'TxtEUser
        '
        Me.TxtEUser.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TxtEUser.Location = New System.Drawing.Point(14, 68)
        Me.TxtEUser.Name = "TxtEUser"
        Me.TxtEUser.Size = New System.Drawing.Size(345, 25)
        Me.TxtEUser.TabIndex = 151
        '
        'DTETo
        '
        Me.DTETo.CustomFormat = "MM-dd-yyyy hh:mm tt"
        Me.DTETo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTETo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTETo.Location = New System.Drawing.Point(539, 68)
        Me.DTETo.Name = "DTETo"
        Me.DTETo.Size = New System.Drawing.Size(170, 25)
        Me.DTETo.TabIndex = 150
        '
        'TxtELoc
        '
        Me.TxtELoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtELoc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtELoc.FormattingEnabled = True
        Me.TxtELoc.Items.AddRange(New Object() {"...", "Main Window", "Log-In Window", "User Accounts Window"})
        Me.TxtELoc.Location = New System.Drawing.Point(365, 68)
        Me.TxtELoc.Name = "TxtELoc"
        Me.TxtELoc.Size = New System.Drawing.Size(121, 25)
        Me.TxtELoc.TabIndex = 146
        '
        'DTEFrom
        '
        Me.DTEFrom.CustomFormat = "MM-dd-yyyy hh:mm tt"
        Me.DTEFrom.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTEFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTEFrom.Location = New System.Drawing.Point(539, 37)
        Me.DTEFrom.Name = "DTEFrom"
        Me.DTEFrom.Size = New System.Drawing.Size(170, 25)
        Me.DTEFrom.TabIndex = 145
        '
        'DgUser
        '
        Me.DgUser.AllowUserToAddRows = False
        Me.DgUser.AllowUserToDeleteRows = False
        Me.DgUser.BackgroundColor = System.Drawing.Color.White
        Me.DgUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgUser.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_User, Me.Col_Activity, Me.Col_Location, Me.Col_Date, Me.Col_Remarks, Me.Col_ULimg})
        Me.DgUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.DgUser.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgUser.Location = New System.Drawing.Point(5, 98)
        Me.DgUser.MultiSelect = False
        Me.DgUser.Name = "DgUser"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Aqua
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgUser.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DgUser.RowHeadersVisible = False
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Aqua
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.DimGray
        Me.DgUser.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DgUser.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.DgUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgUser.Size = New System.Drawing.Size(1025, 193)
        Me.DgUser.TabIndex = 4
        '
        'Col_User
        '
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0.00"
        Me.Col_User.DefaultCellStyle = DataGridViewCellStyle5
        Me.Col_User.HeaderText = "User"
        Me.Col_User.MaxInputLength = 250
        Me.Col_User.Name = "Col_User"
        Me.Col_User.Width = 350
        '
        'Col_Activity
        '
        Me.Col_Activity.HeaderText = "Log Activity"
        Me.Col_Activity.Name = "Col_Activity"
        Me.Col_Activity.Width = 150
        '
        'Col_Location
        '
        Me.Col_Location.HeaderText = "Location"
        Me.Col_Location.Name = "Col_Location"
        Me.Col_Location.Width = 130
        '
        'Col_Date
        '
        Me.Col_Date.HeaderText = "Date / Time"
        Me.Col_Date.Name = "Col_Date"
        Me.Col_Date.Width = 170
        '
        'Col_Remarks
        '
        Me.Col_Remarks.HeaderText = "Remarks"
        Me.Col_Remarks.Name = "Col_Remarks"
        Me.Col_Remarks.Width = 150
        '
        'Col_ULimg
        '
        Me.Col_ULimg.HeaderText = ""
        Me.Col_ULimg.Name = "Col_ULimg"
        Me.Col_ULimg.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Col_ULimg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Col_ULimg.Width = 30
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = Global.WeighingSystemV1_1.My.Resources.Resources.WhiteHeader1
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.DTUTo)
        Me.Panel5.Controls.Add(Me.TxtUUser)
        Me.Panel5.Controls.Add(Me.TxtUACt)
        Me.Panel5.Controls.Add(Me.TxtULoc)
        Me.Panel5.Controls.Add(Me.DTUFrom)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(5, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1025, 93)
        Me.Panel5.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.Controls.Add(Me.BtnClearUserlogs)
        Me.Panel6.Controls.Add(Me.BtnUGen)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(871, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(154, 93)
        Me.Panel6.TabIndex = 161
        '
        'BtnClearUserlogs
        '
        Me.BtnClearUserlogs.BackgroundImage = CType(resources.GetObject("BtnClearUserlogs.BackgroundImage"), System.Drawing.Image)
        Me.BtnClearUserlogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnClearUserlogs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClearUserlogs.FlatAppearance.BorderSize = 0
        Me.BtnClearUserlogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClearUserlogs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnClearUserlogs.ForeColor = System.Drawing.Color.Maroon
        Me.BtnClearUserlogs.GUI_ACCSS = "JMoiakne122208"
        Me.BtnClearUserlogs.GUI_ENABLE_HOVER = True
        Me.BtnClearUserlogs.GUI_ENABLED = True
        Me.BtnClearUserlogs.GUI_FORECOLOR_HOVER = System.Drawing.Color.Empty
        Me.BtnClearUserlogs.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnClearUserlogs.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnClearUserlogs.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnClearUserlogs.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnClearUserlogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClearUserlogs.Location = New System.Drawing.Point(6, 14)
        Me.BtnClearUserlogs.Name = "BtnClearUserlogs"
        Me.BtnClearUserlogs.Size = New System.Drawing.Size(139, 46)
        Me.BtnClearUserlogs.TabIndex = 144
        Me.BtnClearUserlogs.Text = "Clear User Logs"
        Me.BtnClearUserlogs.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnClearUserlogs.UseVisualStyleBackColor = True
        '
        'BtnUGen
        '
        Me.BtnUGen.BackgroundImage = CType(resources.GetObject("BtnUGen.BackgroundImage"), System.Drawing.Image)
        Me.BtnUGen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnUGen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUGen.FlatAppearance.BorderSize = 0
        Me.BtnUGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUGen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnUGen.ForeColor = System.Drawing.Color.Maroon
        Me.BtnUGen.GUI_ACCSS = "JMoiakne122208"
        Me.BtnUGen.GUI_ENABLE_HOVER = True
        Me.BtnUGen.GUI_ENABLED = True
        Me.BtnUGen.GUI_FORECOLOR_HOVER = System.Drawing.Color.Empty
        Me.BtnUGen.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnUGen.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnUGen.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnUGen.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnUGen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUGen.Location = New System.Drawing.Point(6, 63)
        Me.BtnUGen.Name = "BtnUGen"
        Me.BtnUGen.Size = New System.Drawing.Size(139, 24)
        Me.BtnUGen.TabIndex = 143
        Me.BtnUGen.Text = "Generate"
        Me.BtnUGen.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnUGen.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(652, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 14)
        Me.Label12.TabIndex = 160
        Me.Label12.Text = "TO"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(635, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 14)
        Me.Label13.TabIndex = 159
        Me.Label13.Text = "FROM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(4, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 14)
        Me.Label5.TabIndex = 149
        Me.Label5.Text = "FILTER PANEL: USER LOGS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(676, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 14)
        Me.Label4.TabIndex = 148
        Me.Label4.Text = "DATE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(502, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 14)
        Me.Label2.TabIndex = 147
        Me.Label2.Text = "LOCATION"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(354, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 14)
        Me.Label1.TabIndex = 146
        Me.Label1.Text = "ACTIVITY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(4, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 14)
        Me.Label3.TabIndex = 145
        Me.Label3.Text = "USER NAME"
        '
        'DTUTo
        '
        Me.DTUTo.CustomFormat = "MM-dd-yyyy hh:mm tt"
        Me.DTUTo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTUTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTUTo.Location = New System.Drawing.Point(679, 63)
        Me.DTUTo.Name = "DTUTo"
        Me.DTUTo.Size = New System.Drawing.Size(170, 25)
        Me.DTUTo.TabIndex = 144
        '
        'TxtUUser
        '
        Me.TxtUUser.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TxtUUser.Location = New System.Drawing.Point(6, 64)
        Me.TxtUUser.Name = "TxtUUser"
        Me.TxtUUser.Size = New System.Drawing.Size(345, 25)
        Me.TxtUUser.TabIndex = 12
        '
        'TxtUACt
        '
        Me.TxtUACt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtUACt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUACt.FormattingEnabled = True
        Me.TxtUACt.Items.AddRange(New Object() {"...", "Log-In", "Log-Out"})
        Me.TxtUACt.Location = New System.Drawing.Point(357, 64)
        Me.TxtUACt.Name = "TxtUACt"
        Me.TxtUACt.Size = New System.Drawing.Size(142, 25)
        Me.TxtUACt.TabIndex = 11
        '
        'TxtULoc
        '
        Me.TxtULoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtULoc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtULoc.FormattingEnabled = True
        Me.TxtULoc.Items.AddRange(New Object() {"...", "Main Window", "Log-In Window", "User Accounts Window"})
        Me.TxtULoc.Location = New System.Drawing.Point(505, 64)
        Me.TxtULoc.Name = "TxtULoc"
        Me.TxtULoc.Size = New System.Drawing.Size(121, 25)
        Me.TxtULoc.TabIndex = 10
        '
        'DTUFrom
        '
        Me.DTUFrom.CustomFormat = "MM-dd-yyyy hh:mm tt"
        Me.DTUFrom.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTUFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTUFrom.Location = New System.Drawing.Point(679, 32)
        Me.DTUFrom.Name = "DTUFrom"
        Me.DTUFrom.Size = New System.Drawing.Size(170, 25)
        Me.DTUFrom.TabIndex = 9
        '
        'Img_Lst
        '
        Me.Img_Lst.ImageStream = CType(resources.GetObject("Img_Lst.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Img_Lst.TransparentColor = System.Drawing.Color.Transparent
        Me.Img_Lst.Images.SetKeyName(0, "Dwn")
        Me.Img_Lst.Images.SetKeyName(1, "Up")
        Me.Img_Lst.Images.SetKeyName(2, "Warning")
        Me.Img_Lst.Images.SetKeyName(3, "Error")
        Me.Img_Lst.Images.SetKeyName(4, "arrow-159-128.png")
        Me.Img_Lst.Images.SetKeyName(5, "arrow-159-48.png")
        Me.Img_Lst.Images.SetKeyName(6, "arrow-159-24.png")
        Me.Img_Lst.Images.SetKeyName(7, "arrow-147-24.png")
        '
        'FrmLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1035, 546)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLogs"
        Me.Text = "Manage Logs"
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DgError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        CType(Me.DgUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Img_Lst As System.Windows.Forms.ImageList
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents DgUser As System.Windows.Forms.DataGridView
    Friend WithEvents DgError As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnExit As MykeCtrlEx.PushButton
    Friend WithEvents DTUFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtULoc As System.Windows.Forms.ComboBox
    Friend WithEvents TxtUACt As System.Windows.Forms.ComboBox
    Friend WithEvents TxtUUser As System.Windows.Forms.TextBox
    Friend WithEvents Col_User As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Activity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Location As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Remarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_ULimg As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DTUTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTETo As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnEGen As MykeCtrlEx.PushButton
    Friend WithEvents TxtELoc As System.Windows.Forms.ComboBox
    Friend WithEvents DTEFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_CUser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_Eremarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col_ELImg As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents TxtEUser As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents BtnUGen As MykeCtrlEx.PushButton
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents BtnClearUserlogs As MykeCtrlEx.PushButton
    Friend WithEvents BtnErrorClearLogs As MykeCtrlEx.PushButton
End Class
