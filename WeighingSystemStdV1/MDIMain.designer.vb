<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIMAIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIMAIN))
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip_main = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LblUserId = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LblName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LblServer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LblTimer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Pnl_MainBtn = New System.Windows.Forms.Panel()
        Me.PnlUtilities = New System.Windows.Forms.Panel()
        Me.BtnSystemSettings = New MykeCtrlEx.PushButton()
        Me.BtnSettings = New MykeCtrlEx.PushButton()
        Me.PnlAdmin = New System.Windows.Forms.Panel()
        Me.BtnLogs = New MykeCtrlEx.PushButton()
        Me.BtnUser = New MykeCtrlEx.PushButton()
        Me.BtnAdmin = New MykeCtrlEx.PushButton()
        Me.PnlReports = New System.Windows.Forms.Panel()
        Me.Btnlog = New MykeCtrlEx.PushButton()
        Me.BtnTransReport = New MykeCtrlEx.PushButton()
        Me.BtnReports = New MykeCtrlEx.PushButton()
        Me.PnlDatabase = New System.Windows.Forms.Panel()
        Me.BtnDriver = New MykeCtrlEx.PushButton()
        Me.BtnTrucks = New MykeCtrlEx.PushButton()
        Me.BtnMaterials = New MykeCtrlEx.PushButton()
        Me.BtnHauler = New MykeCtrlEx.PushButton()
        Me.BtnSUp = New MykeCtrlEx.PushButton()
        Me.BtnCust = New MykeCtrlEx.PushButton()
        Me.BtnDatabase = New MykeCtrlEx.PushButton()
        Me.PnlOperation = New System.Windows.Forms.Panel()
        Me.BtnManagement = New MykeCtrlEx.PushButton()
        Me.BtnTrans = New MykeCtrlEx.PushButton()
        Me.BtnOperation = New MykeCtrlEx.PushButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LblH = New System.Windows.Forms.Label()
        Me.BtnExit = New MykeCtrlEx.PushButton()
        Me.StatusStrip_main.SuspendLayout()
        Me.Pnl_MainBtn.SuspendLayout()
        Me.PnlUtilities.SuspendLayout()
        Me.PnlAdmin.SuspendLayout()
        Me.PnlReports.SuspendLayout()
        Me.PnlDatabase.SuspendLayout()
        Me.PnlOperation.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1000
        '
        'StatusStrip_main
        '
        Me.StatusStrip_main.BackColor = System.Drawing.Color.White
        Me.StatusStrip_main.BackgroundImage = Global.WeighingSystemV1_1.My.Resources.Resources.WhiteHeader3
        Me.StatusStrip_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StatusStrip_main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.LblUserId, Me.ToolStripStatusLabel2, Me.LblName, Me.LblServer, Me.LblTimer})
        Me.StatusStrip_main.Location = New System.Drawing.Point(0, 702)
        Me.StatusStrip_main.Name = "StatusStrip_main"
        Me.StatusStrip_main.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StatusStrip_main.Size = New System.Drawing.Size(1008, 28)
        Me.StatusStrip_main.SizingGrip = False
        Me.StatusStrip_main.TabIndex = 15
        Me.StatusStrip_main.Text = "StatusStrip"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(49, 23)
        Me.ToolStripStatusLabel1.Text = "User Id:"
        '
        'LblUserId
        '
        Me.LblUserId.BackColor = System.Drawing.Color.Transparent
        Me.LblUserId.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUserId.Name = "LblUserId"
        Me.LblUserId.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblUserId.Size = New System.Drawing.Size(64, 23)
        Me.LblUserId.Text = "00000001"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.Margin = New System.Windows.Forms.Padding(30, 3, 0, 2)
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(72, 23)
        Me.ToolStripStatusLabel2.Text = "User Name:"
        '
        'LblName
        '
        Me.LblName.BackColor = System.Drawing.Color.Transparent
        Me.LblName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.Name = "LblName"
        Me.LblName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblName.Size = New System.Drawing.Size(128, 23)
        Me.LblName.Text = "MICHAEL A. FAINZA"
        '
        'LblServer
        '
        Me.LblServer.BackColor = System.Drawing.Color.Transparent
        Me.LblServer.Name = "LblServer"
        Me.LblServer.Size = New System.Drawing.Size(450, 23)
        Me.LblServer.Spring = True
        Me.LblServer.Text = "  "
        '
        'LblTimer
        '
        Me.LblTimer.AutoSize = False
        Me.LblTimer.BackColor = System.Drawing.Color.Transparent
        Me.LblTimer.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTimer.Name = "LblTimer"
        Me.LblTimer.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblTimer.Size = New System.Drawing.Size(200, 23)
        Me.LblTimer.Text = "Jan. 1, 2014    12:00:00 pm"
        Me.LblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Pnl_MainBtn
        '
        Me.Pnl_MainBtn.AutoScroll = True
        Me.Pnl_MainBtn.BackColor = System.Drawing.Color.White
        Me.Pnl_MainBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pnl_MainBtn.Controls.Add(Me.PnlUtilities)
        Me.Pnl_MainBtn.Controls.Add(Me.BtnSettings)
        Me.Pnl_MainBtn.Controls.Add(Me.PnlAdmin)
        Me.Pnl_MainBtn.Controls.Add(Me.BtnAdmin)
        Me.Pnl_MainBtn.Controls.Add(Me.PnlReports)
        Me.Pnl_MainBtn.Controls.Add(Me.BtnReports)
        Me.Pnl_MainBtn.Controls.Add(Me.PnlDatabase)
        Me.Pnl_MainBtn.Controls.Add(Me.BtnDatabase)
        Me.Pnl_MainBtn.Controls.Add(Me.PnlOperation)
        Me.Pnl_MainBtn.Controls.Add(Me.BtnOperation)
        Me.Pnl_MainBtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.Pnl_MainBtn.Location = New System.Drawing.Point(0, 50)
        Me.Pnl_MainBtn.Name = "Pnl_MainBtn"
        Me.Pnl_MainBtn.Padding = New System.Windows.Forms.Padding(5)
        Me.Pnl_MainBtn.Size = New System.Drawing.Size(272, 652)
        Me.Pnl_MainBtn.TabIndex = 17
        '
        'PnlUtilities
        '
        Me.PnlUtilities.BackColor = System.Drawing.Color.Transparent
        Me.PnlUtilities.Controls.Add(Me.BtnSystemSettings)
        Me.PnlUtilities.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlUtilities.Location = New System.Drawing.Point(5, 718)
        Me.PnlUtilities.Name = "PnlUtilities"
        Me.PnlUtilities.Size = New System.Drawing.Size(245, 105)
        Me.PnlUtilities.TabIndex = 55
        '
        'BtnSystemSettings
        '
        Me.BtnSystemSettings.BackgroundImage = CType(resources.GetObject("BtnSystemSettings.BackgroundImage"), System.Drawing.Image)
        Me.BtnSystemSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSystemSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSystemSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSystemSettings.FlatAppearance.BorderSize = 0
        Me.BtnSystemSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSystemSettings.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSystemSettings.ForeColor = System.Drawing.Color.Black
        Me.BtnSystemSettings.GUI_ACCSS = "JMoiakne122208"
        Me.BtnSystemSettings.GUI_ENABLE_HOVER = True
        Me.BtnSystemSettings.GUI_ENABLED = True
        Me.BtnSystemSettings.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnSystemSettings.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnSystemSettings.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnSystemSettings.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnSystemSettings.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnSystemSettings.Location = New System.Drawing.Point(0, 0)
        Me.BtnSystemSettings.Name = "BtnSystemSettings"
        Me.BtnSystemSettings.Size = New System.Drawing.Size(245, 28)
        Me.BtnSystemSettings.TabIndex = 37
        Me.BtnSystemSettings.Text = "System Settings"
        Me.BtnSystemSettings.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnSystemSettings.UseVisualStyleBackColor = True
        '
        'BtnSettings
        '
        Me.BtnSettings.BackgroundImage = CType(resources.GetObject("BtnSettings.BackgroundImage"), System.Drawing.Image)
        Me.BtnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSettings.FlatAppearance.BorderSize = 0
        Me.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSettings.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSettings.ForeColor = System.Drawing.Color.Black
        Me.BtnSettings.GUI_ACCSS = "JMoiakne122208"
        Me.BtnSettings.GUI_ENABLE_HOVER = True
        Me.BtnSettings.GUI_ENABLED = True
        Me.BtnSettings.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnSettings.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Down16
        Me.BtnSettings.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.Blue
        Me.BtnSettings.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnSettings.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnSettings.Image = CType(resources.GetObject("BtnSettings.Image"), System.Drawing.Image)
        Me.BtnSettings.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BtnSettings.Location = New System.Drawing.Point(5, 673)
        Me.BtnSettings.Name = "BtnSettings"
        Me.BtnSettings.Size = New System.Drawing.Size(245, 45)
        Me.BtnSettings.TabIndex = 54
        Me.BtnSettings.Text = "Settings"
        Me.BtnSettings.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnSettings.UseVisualStyleBackColor = True
        '
        'PnlAdmin
        '
        Me.PnlAdmin.BackColor = System.Drawing.Color.Transparent
        Me.PnlAdmin.Controls.Add(Me.BtnLogs)
        Me.PnlAdmin.Controls.Add(Me.BtnUser)
        Me.PnlAdmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlAdmin.Location = New System.Drawing.Point(5, 583)
        Me.PnlAdmin.Name = "PnlAdmin"
        Me.PnlAdmin.Size = New System.Drawing.Size(245, 90)
        Me.PnlAdmin.TabIndex = 53
        '
        'BtnLogs
        '
        Me.BtnLogs.BackgroundImage = CType(resources.GetObject("BtnLogs.BackgroundImage"), System.Drawing.Image)
        Me.BtnLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLogs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogs.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnLogs.FlatAppearance.BorderSize = 0
        Me.BtnLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnLogs.ForeColor = System.Drawing.Color.Black
        Me.BtnLogs.GUI_ACCSS = "JMoiakne122208"
        Me.BtnLogs.GUI_ENABLE_HOVER = True
        Me.BtnLogs.GUI_ENABLED = True
        Me.BtnLogs.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnLogs.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnLogs.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnLogs.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnLogs.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnLogs.Location = New System.Drawing.Point(0, 28)
        Me.BtnLogs.Name = "BtnLogs"
        Me.BtnLogs.Size = New System.Drawing.Size(245, 28)
        Me.BtnLogs.TabIndex = 40
        Me.BtnLogs.Text = "Manage Logs"
        Me.BtnLogs.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnLogs.UseVisualStyleBackColor = True
        '
        'BtnUser
        '
        Me.BtnUser.BackgroundImage = CType(resources.GetObject("BtnUser.BackgroundImage"), System.Drawing.Image)
        Me.BtnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnUser.FlatAppearance.BorderSize = 0
        Me.BtnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUser.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnUser.ForeColor = System.Drawing.Color.Black
        Me.BtnUser.GUI_ACCSS = "JMoiakne122208"
        Me.BtnUser.GUI_ENABLE_HOVER = True
        Me.BtnUser.GUI_ENABLED = True
        Me.BtnUser.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnUser.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnUser.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnUser.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnUser.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnUser.Location = New System.Drawing.Point(0, 0)
        Me.BtnUser.Name = "BtnUser"
        Me.BtnUser.Size = New System.Drawing.Size(245, 28)
        Me.BtnUser.TabIndex = 39
        Me.BtnUser.Text = "User Accounts"
        Me.BtnUser.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnUser.UseVisualStyleBackColor = True
        '
        'BtnAdmin
        '
        Me.BtnAdmin.BackgroundImage = CType(resources.GetObject("BtnAdmin.BackgroundImage"), System.Drawing.Image)
        Me.BtnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAdmin.FlatAppearance.BorderSize = 0
        Me.BtnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdmin.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdmin.ForeColor = System.Drawing.Color.Black
        Me.BtnAdmin.GUI_ACCSS = "JMoiakne122208"
        Me.BtnAdmin.GUI_ENABLE_HOVER = True
        Me.BtnAdmin.GUI_ENABLED = True
        Me.BtnAdmin.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnAdmin.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Down16
        Me.BtnAdmin.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.Blue
        Me.BtnAdmin.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnAdmin.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnAdmin.Image = CType(resources.GetObject("BtnAdmin.Image"), System.Drawing.Image)
        Me.BtnAdmin.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BtnAdmin.Location = New System.Drawing.Point(5, 538)
        Me.BtnAdmin.Name = "BtnAdmin"
        Me.BtnAdmin.Size = New System.Drawing.Size(245, 45)
        Me.BtnAdmin.TabIndex = 52
        Me.BtnAdmin.Text = "Administration"
        Me.BtnAdmin.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnAdmin.UseVisualStyleBackColor = True
        '
        'PnlReports
        '
        Me.PnlReports.BackColor = System.Drawing.Color.Transparent
        Me.PnlReports.Controls.Add(Me.Btnlog)
        Me.PnlReports.Controls.Add(Me.BtnTransReport)
        Me.PnlReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlReports.Location = New System.Drawing.Point(5, 455)
        Me.PnlReports.Name = "PnlReports"
        Me.PnlReports.Size = New System.Drawing.Size(245, 83)
        Me.PnlReports.TabIndex = 51
        '
        'Btnlog
        '
        Me.Btnlog.BackgroundImage = CType(resources.GetObject("Btnlog.BackgroundImage"), System.Drawing.Image)
        Me.Btnlog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnlog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnlog.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btnlog.FlatAppearance.BorderSize = 0
        Me.Btnlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnlog.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Btnlog.ForeColor = System.Drawing.Color.Black
        Me.Btnlog.GUI_ACCSS = "JMoiakne122208"
        Me.Btnlog.GUI_ENABLE_HOVER = True
        Me.Btnlog.GUI_ENABLED = True
        Me.Btnlog.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btnlog.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.Btnlog.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.Btnlog.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.Btnlog.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.Btnlog.Location = New System.Drawing.Point(0, 28)
        Me.Btnlog.Name = "Btnlog"
        Me.Btnlog.Size = New System.Drawing.Size(245, 28)
        Me.Btnlog.TabIndex = 14
        Me.Btnlog.Text = "Log Reports"
        Me.Btnlog.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Btnlog.UseVisualStyleBackColor = True
        Me.Btnlog.Visible = False
        '
        'BtnTransReport
        '
        Me.BtnTransReport.BackgroundImage = CType(resources.GetObject("BtnTransReport.BackgroundImage"), System.Drawing.Image)
        Me.BtnTransReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnTransReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTransReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnTransReport.FlatAppearance.BorderSize = 0
        Me.BtnTransReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTransReport.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnTransReport.ForeColor = System.Drawing.Color.Black
        Me.BtnTransReport.GUI_ACCSS = "JMoiakne122208"
        Me.BtnTransReport.GUI_ENABLE_HOVER = True
        Me.BtnTransReport.GUI_ENABLED = True
        Me.BtnTransReport.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnTransReport.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnTransReport.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnTransReport.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnTransReport.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnTransReport.Location = New System.Drawing.Point(0, 0)
        Me.BtnTransReport.Name = "BtnTransReport"
        Me.BtnTransReport.Size = New System.Drawing.Size(245, 28)
        Me.BtnTransReport.TabIndex = 13
        Me.BtnTransReport.Text = "Transaction Reports"
        Me.BtnTransReport.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnTransReport.UseVisualStyleBackColor = True
        '
        'BtnReports
        '
        Me.BtnReports.BackgroundImage = CType(resources.GetObject("BtnReports.BackgroundImage"), System.Drawing.Image)
        Me.BtnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnReports.FlatAppearance.BorderSize = 0
        Me.BtnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReports.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReports.ForeColor = System.Drawing.Color.Black
        Me.BtnReports.GUI_ACCSS = "JMoiakne122208"
        Me.BtnReports.GUI_ENABLE_HOVER = True
        Me.BtnReports.GUI_ENABLED = True
        Me.BtnReports.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnReports.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Down16
        Me.BtnReports.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.Blue
        Me.BtnReports.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnReports.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnReports.Image = CType(resources.GetObject("BtnReports.Image"), System.Drawing.Image)
        Me.BtnReports.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BtnReports.Location = New System.Drawing.Point(5, 410)
        Me.BtnReports.Name = "BtnReports"
        Me.BtnReports.Size = New System.Drawing.Size(245, 45)
        Me.BtnReports.TabIndex = 49
        Me.BtnReports.Text = "Reporting"
        Me.BtnReports.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnReports.UseVisualStyleBackColor = True
        '
        'PnlDatabase
        '
        Me.PnlDatabase.BackColor = System.Drawing.Color.Transparent
        Me.PnlDatabase.Controls.Add(Me.BtnDriver)
        Me.PnlDatabase.Controls.Add(Me.BtnTrucks)
        Me.PnlDatabase.Controls.Add(Me.BtnMaterials)
        Me.PnlDatabase.Controls.Add(Me.BtnHauler)
        Me.PnlDatabase.Controls.Add(Me.BtnSUp)
        Me.PnlDatabase.Controls.Add(Me.BtnCust)
        Me.PnlDatabase.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlDatabase.Location = New System.Drawing.Point(5, 181)
        Me.PnlDatabase.Name = "PnlDatabase"
        Me.PnlDatabase.Size = New System.Drawing.Size(245, 229)
        Me.PnlDatabase.TabIndex = 50
        '
        'BtnDriver
        '
        Me.BtnDriver.BackgroundImage = CType(resources.GetObject("BtnDriver.BackgroundImage"), System.Drawing.Image)
        Me.BtnDriver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDriver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDriver.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnDriver.FlatAppearance.BorderSize = 0
        Me.BtnDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDriver.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnDriver.ForeColor = System.Drawing.Color.Black
        Me.BtnDriver.GUI_ACCSS = "JMoiakne122208"
        Me.BtnDriver.GUI_ENABLE_HOVER = True
        Me.BtnDriver.GUI_ENABLED = True
        Me.BtnDriver.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnDriver.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnDriver.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnDriver.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnDriver.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnDriver.Location = New System.Drawing.Point(0, 140)
        Me.BtnDriver.Name = "BtnDriver"
        Me.BtnDriver.Size = New System.Drawing.Size(245, 28)
        Me.BtnDriver.TabIndex = 12
        Me.BtnDriver.Text = "Drivers"
        Me.BtnDriver.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnDriver.UseVisualStyleBackColor = True
        '
        'BtnTrucks
        '
        Me.BtnTrucks.BackgroundImage = CType(resources.GetObject("BtnTrucks.BackgroundImage"), System.Drawing.Image)
        Me.BtnTrucks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnTrucks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTrucks.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnTrucks.FlatAppearance.BorderSize = 0
        Me.BtnTrucks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTrucks.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnTrucks.ForeColor = System.Drawing.Color.Black
        Me.BtnTrucks.GUI_ACCSS = "JMoiakne122208"
        Me.BtnTrucks.GUI_ENABLE_HOVER = True
        Me.BtnTrucks.GUI_ENABLED = True
        Me.BtnTrucks.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnTrucks.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnTrucks.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnTrucks.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnTrucks.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnTrucks.Location = New System.Drawing.Point(0, 112)
        Me.BtnTrucks.Name = "BtnTrucks"
        Me.BtnTrucks.Size = New System.Drawing.Size(245, 28)
        Me.BtnTrucks.TabIndex = 11
        Me.BtnTrucks.Text = "Trucks"
        Me.BtnTrucks.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnTrucks.UseVisualStyleBackColor = True
        '
        'BtnMaterials
        '
        Me.BtnMaterials.BackgroundImage = CType(resources.GetObject("BtnMaterials.BackgroundImage"), System.Drawing.Image)
        Me.BtnMaterials.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMaterials.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMaterials.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnMaterials.FlatAppearance.BorderSize = 0
        Me.BtnMaterials.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMaterials.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnMaterials.ForeColor = System.Drawing.Color.Black
        Me.BtnMaterials.GUI_ACCSS = "JMoiakne122208"
        Me.BtnMaterials.GUI_ENABLE_HOVER = True
        Me.BtnMaterials.GUI_ENABLED = True
        Me.BtnMaterials.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnMaterials.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnMaterials.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnMaterials.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnMaterials.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnMaterials.Location = New System.Drawing.Point(0, 84)
        Me.BtnMaterials.Name = "BtnMaterials"
        Me.BtnMaterials.Size = New System.Drawing.Size(245, 28)
        Me.BtnMaterials.TabIndex = 10
        Me.BtnMaterials.Text = "Commodity"
        Me.BtnMaterials.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnMaterials.UseVisualStyleBackColor = True
        '
        'BtnHauler
        '
        Me.BtnHauler.BackgroundImage = CType(resources.GetObject("BtnHauler.BackgroundImage"), System.Drawing.Image)
        Me.BtnHauler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnHauler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHauler.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnHauler.FlatAppearance.BorderSize = 0
        Me.BtnHauler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHauler.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnHauler.ForeColor = System.Drawing.Color.Black
        Me.BtnHauler.GUI_ACCSS = "JMoiakne122208"
        Me.BtnHauler.GUI_ENABLE_HOVER = True
        Me.BtnHauler.GUI_ENABLED = True
        Me.BtnHauler.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnHauler.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnHauler.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnHauler.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnHauler.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnHauler.Location = New System.Drawing.Point(0, 56)
        Me.BtnHauler.Name = "BtnHauler"
        Me.BtnHauler.Size = New System.Drawing.Size(245, 28)
        Me.BtnHauler.TabIndex = 13
        Me.BtnHauler.Text = "Hauler"
        Me.BtnHauler.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnHauler.UseVisualStyleBackColor = True
        '
        'BtnSUp
        '
        Me.BtnSUp.BackgroundImage = CType(resources.GetObject("BtnSUp.BackgroundImage"), System.Drawing.Image)
        Me.BtnSUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSUp.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSUp.FlatAppearance.BorderSize = 0
        Me.BtnSUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSUp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSUp.ForeColor = System.Drawing.Color.Black
        Me.BtnSUp.GUI_ACCSS = "JMoiakne122208"
        Me.BtnSUp.GUI_ENABLE_HOVER = True
        Me.BtnSUp.GUI_ENABLED = True
        Me.BtnSUp.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnSUp.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnSUp.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnSUp.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnSUp.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnSUp.Location = New System.Drawing.Point(0, 28)
        Me.BtnSUp.Name = "BtnSUp"
        Me.BtnSUp.Size = New System.Drawing.Size(245, 28)
        Me.BtnSUp.TabIndex = 9
        Me.BtnSUp.Text = "Supplier"
        Me.BtnSUp.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnSUp.UseVisualStyleBackColor = True
        '
        'BtnCust
        '
        Me.BtnCust.BackgroundImage = CType(resources.GetObject("BtnCust.BackgroundImage"), System.Drawing.Image)
        Me.BtnCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCust.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCust.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCust.FlatAppearance.BorderSize = 0
        Me.BtnCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCust.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnCust.ForeColor = System.Drawing.Color.Black
        Me.BtnCust.GUI_ACCSS = "JMoiakne122208"
        Me.BtnCust.GUI_ENABLE_HOVER = True
        Me.BtnCust.GUI_ENABLED = True
        Me.BtnCust.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnCust.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnCust.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnCust.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnCust.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnCust.Location = New System.Drawing.Point(0, 0)
        Me.BtnCust.Name = "BtnCust"
        Me.BtnCust.Size = New System.Drawing.Size(245, 28)
        Me.BtnCust.TabIndex = 8
        Me.BtnCust.Text = "Customer"
        Me.BtnCust.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnCust.UseVisualStyleBackColor = True
        '
        'BtnDatabase
        '
        Me.BtnDatabase.BackgroundImage = CType(resources.GetObject("BtnDatabase.BackgroundImage"), System.Drawing.Image)
        Me.BtnDatabase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDatabase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDatabase.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnDatabase.FlatAppearance.BorderSize = 0
        Me.BtnDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDatabase.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDatabase.ForeColor = System.Drawing.Color.Black
        Me.BtnDatabase.GUI_ACCSS = "JMoiakne122208"
        Me.BtnDatabase.GUI_ENABLE_HOVER = True
        Me.BtnDatabase.GUI_ENABLED = True
        Me.BtnDatabase.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnDatabase.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Down16
        Me.BtnDatabase.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.Blue
        Me.BtnDatabase.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnDatabase.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnDatabase.Image = CType(resources.GetObject("BtnDatabase.Image"), System.Drawing.Image)
        Me.BtnDatabase.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BtnDatabase.Location = New System.Drawing.Point(5, 136)
        Me.BtnDatabase.Name = "BtnDatabase"
        Me.BtnDatabase.Size = New System.Drawing.Size(245, 45)
        Me.BtnDatabase.TabIndex = 48
        Me.BtnDatabase.Text = "Database/File Maintenance"
        Me.BtnDatabase.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnDatabase.UseVisualStyleBackColor = True
        '
        'PnlOperation
        '
        Me.PnlOperation.BackColor = System.Drawing.Color.Transparent
        Me.PnlOperation.Controls.Add(Me.BtnManagement)
        Me.PnlOperation.Controls.Add(Me.BtnTrans)
        Me.PnlOperation.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlOperation.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlOperation.Location = New System.Drawing.Point(5, 50)
        Me.PnlOperation.Name = "PnlOperation"
        Me.PnlOperation.Size = New System.Drawing.Size(245, 86)
        Me.PnlOperation.TabIndex = 47
        '
        'BtnManagement
        '
        Me.BtnManagement.BackgroundImage = CType(resources.GetObject("BtnManagement.BackgroundImage"), System.Drawing.Image)
        Me.BtnManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnManagement.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnManagement.FlatAppearance.BorderSize = 0
        Me.BtnManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnManagement.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnManagement.ForeColor = System.Drawing.Color.Black
        Me.BtnManagement.GUI_ACCSS = "JMoiakne122208"
        Me.BtnManagement.GUI_ENABLE_HOVER = True
        Me.BtnManagement.GUI_ENABLED = True
        Me.BtnManagement.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnManagement.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnManagement.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnManagement.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnManagement.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnManagement.Location = New System.Drawing.Point(0, 26)
        Me.BtnManagement.Name = "BtnManagement"
        Me.BtnManagement.Size = New System.Drawing.Size(245, 26)
        Me.BtnManagement.TabIndex = 8
        Me.BtnManagement.Text = "Management"
        Me.BtnManagement.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnManagement.UseVisualStyleBackColor = True
        '
        'BtnTrans
        '
        Me.BtnTrans.BackgroundImage = CType(resources.GetObject("BtnTrans.BackgroundImage"), System.Drawing.Image)
        Me.BtnTrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnTrans.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTrans.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnTrans.FlatAppearance.BorderSize = 0
        Me.BtnTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTrans.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTrans.ForeColor = System.Drawing.Color.Black
        Me.BtnTrans.GUI_ACCSS = "JMoiakne122208"
        Me.BtnTrans.GUI_ENABLE_HOVER = True
        Me.BtnTrans.GUI_ENABLED = True
        Me.BtnTrans.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnTrans.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnTrans.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnTrans.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnTrans.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnTrans.Location = New System.Drawing.Point(0, 0)
        Me.BtnTrans.Name = "BtnTrans"
        Me.BtnTrans.Size = New System.Drawing.Size(245, 26)
        Me.BtnTrans.TabIndex = 7
        Me.BtnTrans.Text = "Transaction"
        Me.BtnTrans.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnTrans.UseVisualStyleBackColor = True
        '
        'BtnOperation
        '
        Me.BtnOperation.BackgroundImage = CType(resources.GetObject("BtnOperation.BackgroundImage"), System.Drawing.Image)
        Me.BtnOperation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnOperation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOperation.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnOperation.FlatAppearance.BorderSize = 0
        Me.BtnOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOperation.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOperation.ForeColor = System.Drawing.Color.Black
        Me.BtnOperation.GUI_ACCSS = "JMoiakne122208"
        Me.BtnOperation.GUI_ENABLE_HOVER = True
        Me.BtnOperation.GUI_ENABLED = True
        Me.BtnOperation.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnOperation.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Down16
        Me.BtnOperation.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.Blue
        Me.BtnOperation.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Black
        Me.BtnOperation.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnOperation.Image = CType(resources.GetObject("BtnOperation.Image"), System.Drawing.Image)
        Me.BtnOperation.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BtnOperation.Location = New System.Drawing.Point(5, 5)
        Me.BtnOperation.Name = "BtnOperation"
        Me.BtnOperation.Size = New System.Drawing.Size(245, 45)
        Me.BtnOperation.TabIndex = 46
        Me.BtnOperation.Text = "Transaction"
        Me.BtnOperation.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnOperation.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BackgroundImage = Global.WeighingSystemV1_1.My.Resources.Resources.WhiteHeader1
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1008, 50)
        Me.Panel4.TabIndex = 19
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.LblH)
        Me.Panel3.Controls.Add(Me.BtnExit)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(583, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5, 10, 5, 10)
        Me.Panel3.Size = New System.Drawing.Size(425, 50)
        Me.Panel3.TabIndex = 8
        '
        'LblH
        '
        Me.LblH.Dock = System.Windows.Forms.DockStyle.Right
        Me.LblH.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblH.Location = New System.Drawing.Point(8, 10)
        Me.LblH.Name = "LblH"
        Me.LblH.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.LblH.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblH.Size = New System.Drawing.Size(291, 30)
        Me.LblH.TabIndex = 143
        Me.LblH.Text = "Welcome | admin"
        Me.LblH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnExit
        '
        Me.BtnExit.BackgroundImage = CType(resources.GetObject("BtnExit.BackgroundImage"), System.Drawing.Image)
        Me.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnExit.ForeColor = System.Drawing.Color.Maroon
        Me.BtnExit.GUI_ACCSS = "JMoiakne122208"
        Me.BtnExit.GUI_ENABLE_HOVER = True
        Me.BtnExit.GUI_ENABLED = True
        Me.BtnExit.GUI_FORECOLOR_HOVER = System.Drawing.Color.Empty
        Me.BtnExit.GUI_ICONS = MykeCtrlEx.PushButton.Icons.User16
        Me.BtnExit.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickYellow
        Me.BtnExit.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnExit.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
        Me.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExit.Location = New System.Drawing.Point(299, 10)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(121, 30)
        Me.BtnExit.TabIndex = 142
        Me.BtnExit.Text = "Log out"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'MDIMAIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.Pnl_MainBtn)
        Me.Controls.Add(Me.StatusStrip_main)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "MDIMAIN"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weighing System"
        Me.StatusStrip_main.ResumeLayout(False)
        Me.StatusStrip_main.PerformLayout()
        Me.Pnl_MainBtn.ResumeLayout(False)
        Me.PnlUtilities.ResumeLayout(False)
        Me.PnlAdmin.ResumeLayout(False)
        Me.PnlReports.ResumeLayout(False)
        Me.PnlDatabase.ResumeLayout(False)
        Me.PnlOperation.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip_main As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LblUserId As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LblName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LblServer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LblTimer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BtnExit As MykeCtrlEx.PushButton
    Friend WithEvents Pnl_MainBtn As System.Windows.Forms.Panel
    Friend WithEvents PnlUtilities As System.Windows.Forms.Panel
    Friend WithEvents BtnSystemSettings As MykeCtrlEx.PushButton
    Friend WithEvents BtnSettings As MykeCtrlEx.PushButton
    Friend WithEvents PnlAdmin As System.Windows.Forms.Panel
    Friend WithEvents BtnLogs As MykeCtrlEx.PushButton
    Friend WithEvents BtnUser As MykeCtrlEx.PushButton
    Friend WithEvents BtnAdmin As MykeCtrlEx.PushButton
    Friend WithEvents PnlReports As System.Windows.Forms.Panel
    Friend WithEvents Btnlog As MykeCtrlEx.PushButton
    Friend WithEvents BtnTransReport As MykeCtrlEx.PushButton
    Friend WithEvents BtnReports As MykeCtrlEx.PushButton
    Friend WithEvents PnlDatabase As System.Windows.Forms.Panel
    Friend WithEvents BtnDriver As MykeCtrlEx.PushButton
    Friend WithEvents BtnTrucks As MykeCtrlEx.PushButton
    Friend WithEvents BtnMaterials As MykeCtrlEx.PushButton
    Friend WithEvents BtnHauler As MykeCtrlEx.PushButton
    Friend WithEvents BtnSUp As MykeCtrlEx.PushButton
    Friend WithEvents BtnCust As MykeCtrlEx.PushButton
    Friend WithEvents BtnDatabase As MykeCtrlEx.PushButton
    Friend WithEvents PnlOperation As System.Windows.Forms.Panel
    Friend WithEvents BtnManagement As MykeCtrlEx.PushButton
    Friend WithEvents BtnTrans As MykeCtrlEx.PushButton
    Friend WithEvents BtnOperation As MykeCtrlEx.PushButton
    Friend WithEvents LblH As System.Windows.Forms.Label

End Class
