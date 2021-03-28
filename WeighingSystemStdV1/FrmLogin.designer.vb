<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class FrmLogin
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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents TxtUserName As System.Windows.Forms.TextBox

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.TxtUserName = New System.Windows.Forms.TextBox()
        Me.Tbl_Login = New System.Windows.Forms.TabControl()
        Me.Pge_Login = New System.Windows.Forms.TabPage()
        Me.BtnExit = New MykeCtrlEx.PushButton()
        Me.BtnLogIn = New MykeCtrlEx.PushButton()
        Me.LblConnStat = New System.Windows.Forms.LinkLabel()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.Pge_Server = New System.Windows.Forms.TabPage()
        Me.BtnServerCancel = New MykeCtrlEx.PushButton()
        Me.BtnServerSave = New MykeCtrlEx.PushButton()
        Me.BtnServerEdit = New MykeCtrlEx.PushButton()
        Me.BtnReloadServeConnection = New MykeCtrlEx.PushButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.RdoSErver = New System.Windows.Forms.RadioButton()
        Me.RdoAccess = New System.Windows.Forms.RadioButton()
        Me.Tbl_Access = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnBrowse = New MykeCtrlEx.PushButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDBpath = New System.Windows.Forms.TextBox()
        Me.TxtAccessPwd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tbl_Sql = New System.Windows.Forms.TabControl()
        Me.Tbl_Settings = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CboServers = New System.Windows.Forms.ComboBox()
        Me.Tbl_authentication = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtServerLogin = New System.Windows.Forms.TextBox()
        Me.TxtServerPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tbl_Login.SuspendLayout()
        Me.Pge_Login.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pge_Server.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Access.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Tbl_Sql.SuspendLayout()
        Me.Tbl_Settings.SuspendLayout()
        Me.Tbl_authentication.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(155, 0)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(155, 61)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 0
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtUserName
        '
        Me.TxtUserName.Location = New System.Drawing.Point(155, 26)
        Me.TxtUserName.MaxLength = 40
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(220, 20)
        Me.TxtUserName.TabIndex = 1
        '
        'Tbl_Login
        '
        Me.Tbl_Login.Controls.Add(Me.Pge_Login)
        Me.Tbl_Login.Controls.Add(Me.Pge_Server)
        Me.Tbl_Login.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tbl_Login.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_Login.Name = "Tbl_Login"
        Me.Tbl_Login.SelectedIndex = 0
        Me.Tbl_Login.Size = New System.Drawing.Size(412, 225)
        Me.Tbl_Login.TabIndex = 0
        '
        'Pge_Login
        '
        Me.Pge_Login.Controls.Add(Me.BtnExit)
        Me.Pge_Login.Controls.Add(Me.BtnLogIn)
        Me.Pge_Login.Controls.Add(Me.LblConnStat)
        Me.Pge_Login.Controls.Add(Me.PasswordLabel)
        Me.Pge_Login.Controls.Add(Me.UsernameLabel)
        Me.Pge_Login.Controls.Add(Me.TxtUserName)
        Me.Pge_Login.Controls.Add(Me.TxtPassword)
        Me.Pge_Login.Controls.Add(Me.LogoPictureBox)
        Me.Pge_Login.Location = New System.Drawing.Point(4, 22)
        Me.Pge_Login.Name = "Pge_Login"
        Me.Pge_Login.Padding = New System.Windows.Forms.Padding(3)
        Me.Pge_Login.Size = New System.Drawing.Size(404, 199)
        Me.Pge_Login.TabIndex = 0
        Me.Pge_Login.Text = "Log-in"
        Me.Pge_Login.UseVisualStyleBackColor = True
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
        Me.BtnExit.GUI_FORECOLOR_HOVER = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnExit.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnExit.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnExit.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnExit.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnExit.Location = New System.Drawing.Point(268, 113)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(107, 36)
        Me.BtnExit.TabIndex = 7
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnLogIn
        '
        Me.BtnLogIn.BackgroundImage = CType(resources.GetObject("BtnLogIn.BackgroundImage"), System.Drawing.Image)
        Me.BtnLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLogIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogIn.FlatAppearance.BorderSize = 0
        Me.BtnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogIn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnLogIn.ForeColor = System.Drawing.Color.Maroon
        Me.BtnLogIn.GUI_ACCSS = "JMoiakne122208"
        Me.BtnLogIn.GUI_ENABLE_HOVER = True
        Me.BtnLogIn.GUI_ENABLED = True
        Me.BtnLogIn.GUI_FORECOLOR_HOVER = System.Drawing.Color.Empty
        Me.BtnLogIn.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnLogIn.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnLogIn.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnLogIn.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnLogIn.Location = New System.Drawing.Point(155, 113)
        Me.BtnLogIn.Name = "BtnLogIn"
        Me.BtnLogIn.Size = New System.Drawing.Size(107, 36)
        Me.BtnLogIn.TabIndex = 6
        Me.BtnLogIn.Text = "Login"
        Me.BtnLogIn.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnLogIn.UseVisualStyleBackColor = True
        '
        'LblConnStat
        '
        Me.LblConnStat.Image = CType(resources.GetObject("LblConnStat.Image"), System.Drawing.Image)
        Me.LblConnStat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblConnStat.Location = New System.Drawing.Point(152, 159)
        Me.LblConnStat.Name = "LblConnStat"
        Me.LblConnStat.Size = New System.Drawing.Size(247, 23)
        Me.LblConnStat.TabIndex = 5
        Me.LblConnStat.TabStop = True
        Me.LblConnStat.Text = "Failed to Connect to Server. Click for details"
        Me.LblConnStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblConnStat.Visible = False
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(155, 87)
        Me.TxtPassword.MaxLength = 30
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(220, 20)
        Me.TxtPassword.TabIndex = 2
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackgroundImage = CType(resources.GetObject("LogoPictureBox.BackgroundImage"), System.Drawing.Image)
        Me.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogoPictureBox.Location = New System.Drawing.Point(-16, 3)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(189, 183)
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'Pge_Server
        '
        Me.Pge_Server.AutoScroll = True
        Me.Pge_Server.Controls.Add(Me.BtnServerCancel)
        Me.Pge_Server.Controls.Add(Me.BtnServerSave)
        Me.Pge_Server.Controls.Add(Me.BtnServerEdit)
        Me.Pge_Server.Controls.Add(Me.BtnReloadServeConnection)
        Me.Pge_Server.Controls.Add(Me.PictureBox1)
        Me.Pge_Server.Controls.Add(Me.Label18)
        Me.Pge_Server.Controls.Add(Me.RdoSErver)
        Me.Pge_Server.Controls.Add(Me.RdoAccess)
        Me.Pge_Server.Controls.Add(Me.Tbl_Access)
        Me.Pge_Server.Controls.Add(Me.Tbl_Sql)
        Me.Pge_Server.Location = New System.Drawing.Point(4, 22)
        Me.Pge_Server.Name = "Pge_Server"
        Me.Pge_Server.Padding = New System.Windows.Forms.Padding(3)
        Me.Pge_Server.Size = New System.Drawing.Size(404, 199)
        Me.Pge_Server.TabIndex = 1
        Me.Pge_Server.Text = "Database Connection"
        Me.Pge_Server.UseVisualStyleBackColor = True
        '
        'BtnServerCancel
        '
        Me.BtnServerCancel.BackgroundImage = CType(resources.GetObject("BtnServerCancel.BackgroundImage"), System.Drawing.Image)
        Me.BtnServerCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnServerCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnServerCancel.FlatAppearance.BorderSize = 0
        Me.BtnServerCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnServerCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnServerCancel.ForeColor = System.Drawing.Color.Maroon
        Me.BtnServerCancel.GUI_ACCSS = "JMoiakne122208"
        Me.BtnServerCancel.GUI_ENABLE_HOVER = True
        Me.BtnServerCancel.GUI_ENABLED = True
        Me.BtnServerCancel.GUI_FORECOLOR_HOVER = System.Drawing.Color.Empty
        Me.BtnServerCancel.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Cancel24
        Me.BtnServerCancel.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnServerCancel.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnServerCancel.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnServerCancel.Image = CType(resources.GetObject("BtnServerCancel.Image"), System.Drawing.Image)
        Me.BtnServerCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnServerCancel.Location = New System.Drawing.Point(277, 154)
        Me.BtnServerCancel.Name = "BtnServerCancel"
        Me.BtnServerCancel.Size = New System.Drawing.Size(98, 37)
        Me.BtnServerCancel.TabIndex = 29
        Me.BtnServerCancel.Text = "&Cancel"
        Me.BtnServerCancel.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnServerCancel.UseVisualStyleBackColor = True
        '
        'BtnServerSave
        '
        Me.BtnServerSave.BackgroundImage = CType(resources.GetObject("BtnServerSave.BackgroundImage"), System.Drawing.Image)
        Me.BtnServerSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnServerSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnServerSave.FlatAppearance.BorderSize = 0
        Me.BtnServerSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnServerSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnServerSave.ForeColor = System.Drawing.Color.Maroon
        Me.BtnServerSave.GUI_ACCSS = "JMoiakne122208"
        Me.BtnServerSave.GUI_ENABLE_HOVER = True
        Me.BtnServerSave.GUI_ENABLED = True
        Me.BtnServerSave.GUI_FORECOLOR_HOVER = System.Drawing.Color.Empty
        Me.BtnServerSave.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Save26
        Me.BtnServerSave.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnServerSave.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnServerSave.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnServerSave.Image = CType(resources.GetObject("BtnServerSave.Image"), System.Drawing.Image)
        Me.BtnServerSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnServerSave.Location = New System.Drawing.Point(173, 154)
        Me.BtnServerSave.Name = "BtnServerSave"
        Me.BtnServerSave.Size = New System.Drawing.Size(98, 37)
        Me.BtnServerSave.TabIndex = 28
        Me.BtnServerSave.Text = "&Save"
        Me.BtnServerSave.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnServerSave.UseVisualStyleBackColor = True
        '
        'BtnServerEdit
        '
        Me.BtnServerEdit.BackgroundImage = CType(resources.GetObject("BtnServerEdit.BackgroundImage"), System.Drawing.Image)
        Me.BtnServerEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnServerEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnServerEdit.FlatAppearance.BorderSize = 0
        Me.BtnServerEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnServerEdit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnServerEdit.ForeColor = System.Drawing.Color.Maroon
        Me.BtnServerEdit.GUI_ACCSS = "JMoiakne122208"
        Me.BtnServerEdit.GUI_ENABLE_HOVER = True
        Me.BtnServerEdit.GUI_ENABLED = True
        Me.BtnServerEdit.GUI_FORECOLOR_HOVER = System.Drawing.Color.Empty
        Me.BtnServerEdit.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Edit24
        Me.BtnServerEdit.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnServerEdit.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnServerEdit.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnServerEdit.Image = CType(resources.GetObject("BtnServerEdit.Image"), System.Drawing.Image)
        Me.BtnServerEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnServerEdit.Location = New System.Drawing.Point(69, 154)
        Me.BtnServerEdit.Name = "BtnServerEdit"
        Me.BtnServerEdit.Size = New System.Drawing.Size(98, 37)
        Me.BtnServerEdit.TabIndex = 27
        Me.BtnServerEdit.Text = "&Edit"
        Me.BtnServerEdit.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnServerEdit.UseVisualStyleBackColor = True
        '
        'BtnReloadServeConnection
        '
        Me.BtnReloadServeConnection.BackgroundImage = CType(resources.GetObject("BtnReloadServeConnection.BackgroundImage"), System.Drawing.Image)
        Me.BtnReloadServeConnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnReloadServeConnection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReloadServeConnection.FlatAppearance.BorderSize = 0
        Me.BtnReloadServeConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReloadServeConnection.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnReloadServeConnection.ForeColor = System.Drawing.Color.Maroon
        Me.BtnReloadServeConnection.GUI_ACCSS = "JMoiakne122208"
        Me.BtnReloadServeConnection.GUI_ENABLE_HOVER = True
        Me.BtnReloadServeConnection.GUI_ENABLED = True
        Me.BtnReloadServeConnection.GUI_FORECOLOR_HOVER = System.Drawing.Color.Empty
        Me.BtnReloadServeConnection.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnReloadServeConnection.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnReloadServeConnection.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnReloadServeConnection.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnReloadServeConnection.Location = New System.Drawing.Point(20, 156)
        Me.BtnReloadServeConnection.Name = "BtnReloadServeConnection"
        Me.BtnReloadServeConnection.Size = New System.Drawing.Size(34, 23)
        Me.BtnReloadServeConnection.TabIndex = 25
        Me.BtnReloadServeConnection.Text = "..."
        Me.BtnReloadServeConnection.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnReloadServeConnection.UseVisualStyleBackColor = True
        Me.BtnReloadServeConnection.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(358, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 29)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label18.Location = New System.Drawing.Point(5, 7)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 13)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Connection Type"
        '
        'RdoSErver
        '
        Me.RdoSErver.AutoSize = True
        Me.RdoSErver.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoSErver.Location = New System.Drawing.Point(194, 5)
        Me.RdoSErver.Name = "RdoSErver"
        Me.RdoSErver.Size = New System.Drawing.Size(86, 18)
        Me.RdoSErver.TabIndex = 0
        Me.RdoSErver.Text = "SQL SERVER"
        Me.RdoSErver.UseVisualStyleBackColor = True
        Me.RdoSErver.Visible = False
        '
        'RdoAccess
        '
        Me.RdoAccess.AutoSize = True
        Me.RdoAccess.Checked = True
        Me.RdoAccess.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoAccess.Location = New System.Drawing.Point(103, 5)
        Me.RdoAccess.Name = "RdoAccess"
        Me.RdoAccess.Size = New System.Drawing.Size(85, 18)
        Me.RdoAccess.TabIndex = 1
        Me.RdoAccess.TabStop = True
        Me.RdoAccess.Text = "ACCESS FILE"
        Me.RdoAccess.UseVisualStyleBackColor = True
        '
        'Tbl_Access
        '
        Me.Tbl_Access.Controls.Add(Me.TabPage1)
        Me.Tbl_Access.Location = New System.Drawing.Point(7, 29)
        Me.Tbl_Access.Name = "Tbl_Access"
        Me.Tbl_Access.SelectedIndex = 0
        Me.Tbl_Access.Size = New System.Drawing.Size(386, 119)
        Me.Tbl_Access.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BtnBrowse)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TxtDBpath)
        Me.TabPage1.Controls.Add(Me.TxtAccessPwd)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(378, 93)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Settings"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnBrowse
        '
        Me.BtnBrowse.BackgroundImage = CType(resources.GetObject("BtnBrowse.BackgroundImage"), System.Drawing.Image)
        Me.BtnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBrowse.FlatAppearance.BorderSize = 0
        Me.BtnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBrowse.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnBrowse.ForeColor = System.Drawing.Color.Maroon
        Me.BtnBrowse.GUI_ACCSS = "JMoiakne122208"
        Me.BtnBrowse.GUI_ENABLE_HOVER = True
        Me.BtnBrowse.GUI_ENABLED = True
        Me.BtnBrowse.GUI_FORECOLOR_HOVER = System.Drawing.Color.Empty
        Me.BtnBrowse.GUI_ICONS = MykeCtrlEx.PushButton.Icons.None
        Me.BtnBrowse.GUI_IMAGE_TEMPLATE = MykeCtrlEx.PushButton.ButtonTemplates.SlickBlue
        Me.BtnBrowse.GUI_MOUSELEAVE_FORECOLOR = System.Drawing.Color.Empty
        Me.BtnBrowse.GUI_ORIENTATION = MykeCtrlEx.PushButton.Orientations.Horizontal
        Me.BtnBrowse.Location = New System.Drawing.Point(337, 12)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(26, 22)
        Me.BtnBrowse.TabIndex = 24
        Me.BtnBrowse.Text = "..."
        Me.BtnBrowse.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnBrowse.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 23)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Database File"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtDBpath
        '
        Me.TxtDBpath.Enabled = False
        Me.TxtDBpath.Location = New System.Drawing.Point(86, 13)
        Me.TxtDBpath.MaxLength = 60
        Me.TxtDBpath.Name = "TxtDBpath"
        Me.TxtDBpath.Size = New System.Drawing.Size(248, 20)
        Me.TxtDBpath.TabIndex = 0
        '
        'TxtAccessPwd
        '
        Me.TxtAccessPwd.Enabled = False
        Me.TxtAccessPwd.Location = New System.Drawing.Point(86, 46)
        Me.TxtAccessPwd.MaxLength = 40
        Me.TxtAccessPwd.Name = "TxtAccessPwd"
        Me.TxtAccessPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtAccessPwd.Size = New System.Drawing.Size(137, 20)
        Me.TxtAccessPwd.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 23)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tbl_Sql
        '
        Me.Tbl_Sql.Controls.Add(Me.Tbl_Settings)
        Me.Tbl_Sql.Controls.Add(Me.Tbl_authentication)
        Me.Tbl_Sql.Location = New System.Drawing.Point(8, 29)
        Me.Tbl_Sql.Name = "Tbl_Sql"
        Me.Tbl_Sql.SelectedIndex = 0
        Me.Tbl_Sql.Size = New System.Drawing.Size(386, 119)
        Me.Tbl_Sql.TabIndex = 0
        Me.Tbl_Sql.Visible = False
        '
        'Tbl_Settings
        '
        Me.Tbl_Settings.Controls.Add(Me.Label4)
        Me.Tbl_Settings.Controls.Add(Me.TxtDB)
        Me.Tbl_Settings.Controls.Add(Me.Label3)
        Me.Tbl_Settings.Controls.Add(Me.CboServers)
        Me.Tbl_Settings.Location = New System.Drawing.Point(4, 22)
        Me.Tbl_Settings.Name = "Tbl_Settings"
        Me.Tbl_Settings.Padding = New System.Windows.Forms.Padding(3)
        Me.Tbl_Settings.Size = New System.Drawing.Size(378, 93)
        Me.Tbl_Settings.TabIndex = 0
        Me.Tbl_Settings.Text = "Settings"
        Me.Tbl_Settings.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(5, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 23)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtDB
        '
        Me.TxtDB.Enabled = False
        Me.TxtDB.Location = New System.Drawing.Point(86, 46)
        Me.TxtDB.MaxLength = 40
        Me.TxtDB.Name = "TxtDB"
        Me.TxtDB.Size = New System.Drawing.Size(137, 20)
        Me.TxtDB.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(5, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 23)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Database "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CboServers
        '
        Me.CboServers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboServers.FormattingEnabled = True
        Me.CboServers.Items.AddRange(New Object() {"..."})
        Me.CboServers.Location = New System.Drawing.Point(86, 15)
        Me.CboServers.Name = "CboServers"
        Me.CboServers.Size = New System.Drawing.Size(244, 21)
        Me.CboServers.TabIndex = 0
        '
        'Tbl_authentication
        '
        Me.Tbl_authentication.Controls.Add(Me.Label5)
        Me.Tbl_authentication.Controls.Add(Me.TxtServerLogin)
        Me.Tbl_authentication.Controls.Add(Me.TxtServerPassword)
        Me.Tbl_authentication.Controls.Add(Me.Label6)
        Me.Tbl_authentication.Location = New System.Drawing.Point(4, 22)
        Me.Tbl_authentication.Name = "Tbl_authentication"
        Me.Tbl_authentication.Padding = New System.Windows.Forms.Padding(3)
        Me.Tbl_authentication.Size = New System.Drawing.Size(378, 93)
        Me.Tbl_authentication.TabIndex = 1
        Me.Tbl_authentication.Text = "Authentication"
        Me.Tbl_authentication.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(9, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 23)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Login"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtServerLogin
        '
        Me.TxtServerLogin.Enabled = False
        Me.TxtServerLogin.Location = New System.Drawing.Point(90, 13)
        Me.TxtServerLogin.Name = "TxtServerLogin"
        Me.TxtServerLogin.Size = New System.Drawing.Size(220, 20)
        Me.TxtServerLogin.TabIndex = 0
        '
        'TxtServerPassword
        '
        Me.TxtServerPassword.Enabled = False
        Me.TxtServerPassword.Location = New System.Drawing.Point(90, 48)
        Me.TxtServerPassword.Name = "TxtServerPassword"
        Me.TxtServerPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtServerPassword.Size = New System.Drawing.Size(220, 20)
        Me.TxtServerPassword.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(9, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 23)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Password"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(412, 225)
        Me.Controls.Add(Me.Tbl_Login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome"
        Me.Tbl_Login.ResumeLayout(False)
        Me.Pge_Login.ResumeLayout(False)
        Me.Pge_Login.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pge_Server.ResumeLayout(False)
        Me.Pge_Server.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Access.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Tbl_Sql.ResumeLayout(False)
        Me.Tbl_Settings.ResumeLayout(False)
        Me.Tbl_Settings.PerformLayout()
        Me.Tbl_authentication.ResumeLayout(False)
        Me.Tbl_authentication.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tbl_Login As System.Windows.Forms.TabControl
    Friend WithEvents Pge_Login As System.Windows.Forms.TabPage
    Friend WithEvents Pge_Server As System.Windows.Forms.TabPage
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Tbl_Sql As System.Windows.Forms.TabControl
    Friend WithEvents Tbl_Settings As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtDB As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Tbl_authentication As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtServerLogin As System.Windows.Forms.TextBox
    Friend WithEvents TxtServerPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblConnStat As System.Windows.Forms.LinkLabel
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents RdoAccess As System.Windows.Forms.RadioButton
    Friend WithEvents RdoSErver As System.Windows.Forms.RadioButton
    Friend WithEvents CboServers As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Access As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtDBpath As System.Windows.Forms.TextBox
    Friend WithEvents TxtAccessPwd As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnLogIn As MykeCtrlEx.PushButton
    Friend WithEvents BtnExit As MykeCtrlEx.PushButton
    Friend WithEvents BtnReloadServeConnection As MykeCtrlEx.PushButton
    Friend WithEvents BtnBrowse As MykeCtrlEx.PushButton
    Friend WithEvents BtnServerEdit As MykeCtrlEx.PushButton
    Friend WithEvents BtnServerSave As MykeCtrlEx.PushButton
    Friend WithEvents BtnServerCancel As MykeCtrlEx.PushButton

End Class
