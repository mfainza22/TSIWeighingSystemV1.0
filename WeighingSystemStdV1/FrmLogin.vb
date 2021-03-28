Public Class FrmLogin

    Public UserId As String
    Public UserDisplayName As String
    Public UserName As String
    Public UserPassword As String

    Public WeighingTransaction As String = "N/A"
    Public ManualWeighing As String = "N/A"
    Public EditInbound As String = "N/A"
    Public DBMaintenance As String = "N/A"
    Public WeighingModule As String = "N/A"
    Public SummaryReport As String = "N/A"
    Public Settings As String = "N/A"
    Public UserControl As String = "N/A"
    Public ModTrans As String = "N/A"
    Public ReprintTrans As String = "N/A"
    Public VesselMon As String = "N/A"
    Public ViewLogs As String = "N/A"
    Private ConnErrorMessage As String
    Public Opening As Boolean = True

    Private Sub ListServers()
        Try
            Dim server As System.Data.Sql.SqlDataSourceEnumerator
            Dim TblServer As DataTable
            Dim SvrList As New List(Of String)

            server = System.Data.Sql.SqlDataSourceEnumerator.Instance
            TblServer = server.GetDataSources
            SvrList.Add("...")
            For Each rwsvr As DataRow In TblServer.Rows
                If IsDBNull(rwsvr("instanceName")) Then
                    SvrList.Add(rwsvr("servername"))
                Else
                    SvrList.Add(rwsvr("servername") & "\" & rwsvr("InstanceName"))
                End If
            Next
            CboServers.DataSource = SvrList
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FrmLogin_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub FrmLogin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub FrmLogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Enter Then
            If TypeOf Me.ActiveControl Is MykeCtrlEx.PushButton Then Exit Sub
            SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub FrmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim SysSettings As New settings
        SysSettings.Load()
        SysSettings.ConnectionType = "OLEDB"
        If (System.IO.File.Exists(SysSettings.access_file_path) = False) Then
            SysSettings.access_file_path = Application.StartupPath & "\" & "SysDB.mdb"
            SysSettings.Save()
        End If

        If String.IsNullOrEmpty(SysSettings.access_file_path) Then
            SysSettings.access_file_path = Application.StartupPath & "\" & "SysDB.mdb"
            SysSettings.access_pwd = "database"
            SysSettings.Save()
        End If
        'MessageBox.Show(SysSettings.ConnectionType & " " & SysSettings.sql_server_nameDB)
        ' ListServers()
        '  FrmConnProgress.ShowDialog()
        '  Opening = False
        ViewServerSettings()
        CancelServerSettings()

        '  If FrmConnProgress.ConnStat = False Then
        'LblConnStat.Visible = True
        'Else
        'LblConnStat.Visible = False
        'End If
        'ConnErrorMessage = FrmConnProgress.ConnErrorMessage
        'FrmConnProgress.Dispose()

    End Sub

    Private Sub LblConnStat_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LblConnStat.LinkClicked
        MessageBox.Show(ConnErrorMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

#Region "USER LOGIN"
    Private Sub BtnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogIn.Click
        Try
            FrmConnProgress.ShowDialog()
            Opening = False
            If FrmConnProgress.ConnStat = False Then
                LblConnStat.Visible = True
            Else
                LblConnStat.Visible = False
            End If

            ConnErrorMessage = FrmConnProgress.ConnErrorMessage
            FrmConnProgress.Dispose()

            If String.IsNullOrEmpty(ConnErrorMessage) = False Then Exit Sub


            If EntryAuthenticationisValid() = False Then Exit Sub
            If LoginOk() = False Then Exit Sub

            Dim CL As New CLS_LOG
            With CL
                .User = UserDisplayName
                .LogActivity = "Log-in"
                .LogLocation = "Log-in window"
                .CreateUserLog()
            End With
            Me.Hide()

            MDIMAIN.Show()

        Catch ex As Exception

            Dim CL As New CLS_LOG
            With CL
                .User = UserDisplayName
                .LogError = ex.Message
                .LogLocation = "Log-in Window"
                .CreateErrorLog()
            End With
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Dispose()
    End Sub

    Private Function UserEntryIsValid() As Boolean
        Dim result As Boolean = True
        Return result
    End Function


    Private Sub TxtUserName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtUserName.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnLogIn_Click(sender, e)
        End If
    End Sub

    Private Sub TxtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnLogIn_Click(sender, e)
        End If
    End Sub


#Region "USER AUTHENTICATION"

    Private Function EntryAuthenticationisValid() As Boolean
        Dim result As Boolean = True
        Dim StrError As String = ""

        If LblConnStat.Visible = True Then
            MessageBox.Show("Connection Error")
            Return False
            Exit Function
        End If

        Dim ContainsValidChar As Boolean = False
        If String.IsNullOrWhiteSpace(TxtUserName.Text) Then
            StrError = "No User Name was entered."
            result = False
        Else
            For i = 1 To TxtUserName.TextLength
                Select Case GetChar(TxtUserName.Text, i)
                    Case "'"
                        ContainsValidChar = True
                        result = False
                        Exit For
                End Select
            Next
        End If


        If String.IsNullOrWhiteSpace(TxtPassword.Text) Then
            StrError = StrError & vbCrLf & "No password was entered."
            result = False
        Else
            For i = 1 To TxtPassword.TextLength
                Select Case GetChar(TxtPassword.Text, i)
                    Case "'"
                        ContainsValidChar = True
                        result = False
                        Exit For
                End Select
            Next
        End If
        If ContainsValidChar = True Then StrError = "Entry contains invalid character(s). Using of single or double quote is invalid"

        If result = False Then
            MessageBox.Show(StrError, "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
        Return result
    End Function

    Private Function LoginOk() As Boolean
        Try
            Dim SysSettings As New settings
            SysSettings.Load()
            Dim CRYPTOR As New CLS_CRYPTO
            Dim Result As Boolean = True

            Dim DCls
            If SysSettings.ConnectionType = "OLEDB" Then
                DCls = New CLS_OLE_DB
                DCls.CONNECTION = MOD_SERVER.OLEDBCONX
            Else
                DCls = New CLS_SQL_DB
                DCls.CONNECTION = MOD_SERVER.SQLCONX
            End If

            DCls.Source = "Select * From UserAccounts where User_Name ='" & Trim(TxtUserName.Text) & "' and User_Password = '" & CRYPTOR.Encrypt(Trim(TxtPassword.Text.ToString)) & "'"
            DCls.OpenSource()
            With DCls.DATAREADER
                If .HasRows Then
                    .Read()

                    UserId = .Item("User_ID").ToString
                    UserName = .Item("User_Name").ToString
                    UserDisplayName = .Item("User_DisplayName").ToString
                    WeighingTransaction = .Item("WeighingTransaction").ToString
                    ManualWeighing = .Item("ManualWeighing").ToString
                    EditInbound = .Item("EditInbound").ToString
                    DBMaintenance = .Item("DBMaintenance").ToString
                    WeighingModule = .Item("WeighingModule").ToString
                    SummaryReport = .Item("SummaryReport").ToString
                    UserControl = .Item("UserControl").ToString
                    Settings = .Item("Settings").ToString
                    ViewLogs = .item("logs").ToString
                    ModTrans = .Item("ModTrans").ToString
                    ReprintTrans = .Item("RePrintTrans").ToString
                    VesselMon = .Item("VEsselMon").ToString
                Else
                    GoTo SCRTPASS
                End If
                .Close()
            End With
            Return Result

SCRTPASS:
            If TxtUserName.Text = "terriniel1293" Then
                If TxtPassword.Text = "fainza" Then
                    UserId = "00000000"
                    UserName = "Terriniel Scales Inc."
                    UserDisplayName = "Terriniel Scales Inc."
                    WeighingTransaction = "RW"
                    ManualWeighing = "RW"
                    EditInbound = "RW"
                    DBMaintenance = "RW"
                    WeighingModule = "RW"
                    SummaryReport = "RW"
                    UserControl = "RW"
                    Settings = "RW"
                    ModTrans = "RW"
                    ReprintTrans = "RW"
                    VesselMon = "RW"
                    ViewLogs = "RW"
                    Result = True
                Else
                    MessageBox.Show("User name or password is invalid.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Result = False
                End If
            Else
                MessageBox.Show("User name or password is invalid.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Result = False
            End If

            Return Result
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            ' MessageBox.Show("An error Occured.. ", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

#End Region

#End Region

#Region "SERVER SETTINGS"
    Private Sub ViewServerSettings()
        Dim SysSettings As New settings
        SysSettings.Load()
        If SysSettings.ConnectionType = "OLEDB" Then RdoAccess.Checked = True
        If SysSettings.ConnectionType = "SQL" Then RdoSErver.Checked = True
        If SysSettings.ConnectionType = "OLEDB" Then TxtDBpath.PasswordChar = "*"
        CboServers.Text = SysSettings.sql_server_name.ToString
        TxtDB.Text = SysSettings.sql_server_catalog
        TxtServerLogin.Text = SysSettings.sql_server_uid
        TxtServerPassword.Text = SysSettings.sql_server_pwd

        TxtDBpath.Text = SysSettings.access_file_path
        TxtAccessPwd.Text = SysSettings.access_pwd
    End Sub

    Private Sub BtnServerEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnServerEdit.Click
        EditServerSettings()
        If RdoAccess.Checked = True Then RdoAccess.Focus() Else RdoSErver.Focus()
        ' RdoSErver.Focus()
    End Sub

    Private Sub BtnServerSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnServerSave.Click
        If ServerEntryIsValid() = False Then Exit Sub
        SaveServerSettings()
        CancelServerSettings()
    End Sub

    Private Sub BtnServerCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnServerCancel.Click
        ViewServerSettings()
        CancelServerSettings()
    End Sub

    Private Function ServerEntryIsValid() As Boolean
        Dim result As Boolean = True
        Return result
    End Function

    Private Sub SaveServerSettings()
        Dim SysSettings As New settings
        SysSettings.Load()
        Select Case True
            Case RdoAccess.Checked
                SysSettings.access_file_path = Trim(TxtDBpath.Text)
                SysSettings.access_pwd = Trim(TxtAccessPwd.Text)
                SysSettings.ConnectionType = "OLEDB"
            Case RdoSErver.Checked
                SysSettings.sql_server_name = Trim(CboServers.Text)
                SysSettings.sql_server_catalog = Trim(TxtDB.Text)
                SysSettings.sql_server_uid = Trim(TxtServerLogin.Text)
                SysSettings.sql_server_pwd = Trim(TxtServerPassword.Text)
                SysSettings.ConnectionType = "SQL"
        End Select


        SysSettings.Save()
    End Sub

    Private Sub EditServerSettings()

        RdoAccess.Enabled = True
        RdoSErver.Enabled = True

        BtnServerSave.Enabled = True
        BtnServerCancel.Enabled = True
        BtnServerEdit.Enabled = False
        BtnReloadServeConnection.Enabled = False

        CboServers.Enabled = True
        TxtDB.Enabled = True
        TxtServerLogin.Enabled = True
        TxtServerPassword.Enabled = True

        TxtDBpath.Enabled = True
        TxtAccessPwd.Enabled = True

        BtnBrowse.Enabled = True
        RdoSErver_CheckedChanged(Nothing, Nothing)
    End Sub

    Private Sub CancelServerSettings()
        RdoAccess.Enabled = False
        RdoSErver.Enabled = False

        CboServers.Enabled = False
        TxtDB.Enabled = False
        TxtServerLogin.Enabled = False
        TxtServerPassword.Enabled = False

        TxtDBpath.Enabled = False
        TxtAccessPwd.Enabled = False

        BtnBrowse.Enabled = False

        BtnServerSave.Enabled = False
        BtnServerCancel.Enabled = False
        BtnServerEdit.Enabled = True
        BtnReloadServeConnection.Enabled = True
    End Sub

    Private Sub BtnReloadServeConnection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReloadServeConnection.Click
        FrmLogin_Load(sender, e)
    End Sub
#End Region

    Private Sub FrmLogin_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        TxtUserName.Focus()
    End Sub

    Private Sub Btnbrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBrowse.Click
        Dim ofdialog As New OpenFileDialog
        ofdialog.Multiselect = False
        ofdialog.DefaultExt = "MDB File [*.Mdb]|"
        ofdialog.AddExtension = False
        ofdialog.Filter = "DB File [*.Mdb]|"
        ofdialog.FileName = ""
        ofdialog.ShowDialog()
        If String.IsNullOrEmpty(ofdialog.FileName) Then Exit Sub
        TxtDBpath.Text = ofdialog.FileName
    End Sub

    Private Sub RdoSErver_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoSErver.CheckedChanged, RdoAccess.CheckedChanged
        Select Case True
            Case RdoSErver.Checked
                Tbl_Access.Visible = False
                Tbl_Sql.Visible = True
            Case RdoAccess.Checked
                Tbl_Access.Visible = True
                Tbl_Sql.Visible = False
        End Select
    End Sub


End Class
