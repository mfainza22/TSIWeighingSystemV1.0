Public Class FrmSystemSettings
   
    Private Sub FrmSystemSettings_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TypeOf Me.ActiveControl Is MykeCtrlEx.PushButton Then Exit Sub
            SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub


    Private Sub FrmSys2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboConnType.Items.Clear()
        cboConnType.Items.Add("IP")
        cboConnType.Items.Add("COMM")

        ListDB()

        GeneralRefreshSettings()
        DisableGeneralEdit()

        PortRefreshSettings()
        DisablePortEdit()

        ServerRefreshSettings()
        DisableServerEdit()

        LoadRefNo()
        DisableRefNoEdit()

        ProfileRefreshSettings()
        DisableProfileEdit()
    End Sub

#Region "GENERAL"
    Private Sub GeneralRefreshSettings()
        Dim SysSettings As New settings
        SysSettings.Load()
        Select Case SysSettings.WeighingType
            Case "S"
                Rdo_SingleWeighing.Checked = True
            Case "IO"
                Rdo_InOutWeighing.Checked = True
            Case "M"
        End Select
 
        If SysSettings.UnitWeight = "KG" Then
            RdoUKg.Checked = True
            RdoUTons.Checked = False
        Else
            RdoUKg.Checked = False
            RdoUTons.Checked = True
        End If

        If Convert.ToBoolean(SysSettings.EnablePricing) = True Then Chk_EnablePricing.Checked = True Else Chk_EnablePricing.Checked = False
        If SysSettings.UnitPrice = "KG" Then
            RdoPKg.Checked = True
            RdoPTons.Checked = False
        Else
            RdoPKg.Checked = False
            RdoPTons.Checked = True
        End If

        If SysSettings.EnableDeduction = True Then
            Chk_EnableDeduction.Checked = True
        Else
            Chk_EnableDeduction.Checked = False
        End If

        Select Case SysSettings.DeductUnit
            Case "KG"
                RdoDKg.Checked = True
            Case "%"
                RdoDP.Checked = True
        End Select

        Select Case SysSettings.EnablePrintOut
            Case True
                RdoEnablePrint.Checked = True
            Case False
                RdoEnablePrint.Checked = False
        End Select

        Select Case SysSettings.EnablePrintOut
            Case True
                RdoEnablePrint.Checked = True
            Case False
                RdoDisablePrint.Checked = True
        End Select

        Select Case SysSettings.PrintAll
            Case True
                RdoPrintAll.Checked = True
            Case False
                RdoPrintInOut.Checked = True
        End Select

        CboIndicator.Text = SysSettings.device
        cboConnType.Text = SysSettings.DeviceConnectionType
    End Sub

    Private Sub GeneralSaveSettings()
        Dim SysSettings As New settings
        SysSettings.Load()
        Select Case True
            Case Rdo_SingleWeighing.Checked
                SysSettings.WeighingType = "S"
            Case Rdo_InOutWeighing.Checked
                SysSettings.WeighingType = "IO"
        End Select

        If RdoUKg.Checked = True Then
            SysSettings.UnitWeight = "KG"
        Else
            SysSettings.UnitWeight = "TONS"
        End If

        SysSettings.EnablePricing = Chk_EnablePricing.Checked
        If RdoPKg.Checked = True Then
            SysSettings.UnitPrice = "KG"
        Else
            SysSettings.UnitPrice = "TONS"
        End If

        SysSettings.EnableDeduction = Chk_EnableDeduction.Checked
        If RdoDKg.Checked = True Then
            SysSettings.DeductUnit = "KG"
        Else
            SysSettings.DeductUnit = "%"
        End If

        Select Case RdoEnablePrint.Checked
            Case True
                SysSettings.EnablePrintOut = True
            Case False
                SysSettings.EnablePrintOut = False
        End Select

        Select Case True
            Case RdoPrintAll.Checked
                SysSettings.PrintAll = True
            Case RdoPrintInOut.Checked
                SysSettings.PrintAll = False
        End Select


        SysSettings.device = CboIndicator.Text
        SysSettings.DeviceConnectionType = cboConnType.Text
        SysSettings.Save()
    End Sub
    Private Sub EnableGeneralEdit()
        For Each ctr As Control In Pnl_General.Controls
            ctr.Enabled = True
        Next

        If RdoEnablePrint.Checked = True Then
            Pnl_PrintInOut.Enabled = True
        Else
            Pnl_PrintInOut.Enabled = False
        End If
        BtnEdit.Enabled = False
        BtnSave.Enabled = True
        BtnCancel.Enabled = True
    End Sub

    Private Sub DisableGeneralEdit()
        For Each ctr As Control In Pnl_General.Controls
            ctr.Enabled = False
        Next


        BtnEdit.Enabled = True
        BtnSave.Enabled = False
        BtnCancel.Enabled = False
    End Sub
#End Region


#Region "SERVER"
    Private Sub ListDB()
        Dim SysSettings As New settings
        SysSettings.Load()
        If SysSettings.ConnectionType = "SQL" Then
            CboDB.Items.Clear()
            '  If ServerState = False Then Exit Sub
            Dim l As New CLS_SQL_DB
            Try

                CboDB.AutoCompleteCustomSource.Clear()
                Dim s As String = "Select name from sys.databases where database_id > 4 order by name desc"

                l.CONNECTION = SQLCONX
                l.Source = s
                l.OpenSource()
                While l.DATAREADER.Read()
                    CboDB.Items.Add(l.DATAREADER.Item(0))
                End While
                l.CMD.Dispose()
                l.DATAREADER.Close()
            Catch ex As Exception
                l.CMD.Dispose()
                l.DATAREADER.Close()
            End Try
        End If
    End Sub

    Private Sub ServerRefreshSettings()
        Dim SysSettings As New settings
        SysSettings.Load()
        CboServer.Text = SysSettings.sql_server_name
        TxtUserName.Text = SysSettings.sql_server_uid
        TxtPassword.Text = SysSettings.sql_server_pwd
        CboDB.Text = SysSettings.sql_server_catalog
        TxtDBpath.Text = SysSettings.access_file_path
        TxtAccessPwd.Text = SysSettings.access_pwd
    End Sub

    Private Sub ServerSaveSettings()
        Dim SysSettings As New settings
        SysSettings.Load()
        Select Case True
            Case RdoAccess.Checked
                SysSettings.access_file_path = Trim(TxtDBpath.Text)
                SysSettings.access_pwd = Trim(TxtAccessPwd.Text)
                SysSettings.ConnectionType = "OLEDB"
            Case RdoSErver.Checked
                SysSettings.sql_server_name = Trim(CboServer.Text)
                SysSettings.sql_server_uid = Trim(TxtUserName.Text)
                SysSettings.sql_server_pwd = Trim(TxtPassword.Text)
                SysSettings.sql_server_catalog = Trim(CboDB.Text)
                SysSettings.ConnectionType = "SQL"
        End Select

        SysSettings.Save()
    End Sub

    Private Sub RdoSErver_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoSErver.CheckedChanged, RdoAccess.CheckedChanged
        Select Case True
            Case RdoSErver.Checked
                PnlAccess.Visible = False
                PnlServer.Visible = True
            Case RdoAccess.Checked
                PnlAccess.Visible = True
                PnlServer.Visible = False
        End Select
    End Sub


    Private Sub EnableServerEdit()
        CboServer.Enabled = True
        TxtUserName.Enabled = True
        TxtPassword.Enabled = True
        CboDB.Enabled = True

        TxtAccessPwd.Enabled = True
        TxtDBpath.Enabled = True
        BtnBrowse.Enabled = True


        BtnEdit.Enabled = False
        BtnSave.Enabled = True
        BtnCancel.Enabled = True
    End Sub

    Private Sub DisableServerEdit()
        CboServer.Enabled = False
        TxtUserName.Enabled = False
        TxtPassword.Enabled = False
        CboDB.Enabled = False

        TxtAccessPwd.Enabled = False
        TxtDBpath.Enabled = False
        BtnBrowse.Enabled = False
        BtnBrowse.Enabled = False

        BtnEdit.Enabled = True
        BtnSave.Enabled = False
        BtnCancel.Enabled = False
    End Sub
#End Region

#Region "PORTS"

    Private Sub RefreshAvailablPorts()
        LblPortError.Visible = False
        LblPortError.Text = ""

        Dim AvailablePorts(,) As String = Nothing
        ListPorts(AvailablePorts)

        TV_Ports.Nodes.Clear()
        For i = 0 To PORTCOUNTED - 1
            TV_Ports.Nodes.Add(AvailablePorts(i, 0))
            TV_Ports.Nodes(i).Nodes.Add(AvailablePorts(i, 1))
            TV_Ports.Nodes(i).Nodes.Add(AvailablePorts(i, 2))
        Next

        If TV_Ports.Nodes.Count = 0 Then
            TV_Ports.Nodes.Add("No Ports detected")
        End If

    End Sub
    Private PORTCOUNTED As Integer
    Public Sub ListPorts(ByRef AvailablePorts(,) As String)
        On Error Resume Next
        CboPort.Items.Clear()
        CboPort.Items.Add("...")
        For Each SP As String In My.Computer.Ports.SerialPortNames
            CboPort.Items.Add(SP)
        Next

        '    Try
        Dim _SEARCHER = New System.Management.ManagementObjectSearcher( _
  "Select * from  Win32_PnpEntity")
        Dim TOTALOBJ As Integer = _SEARCHER.Get.Count - 1
        Dim _VAR_APORTS(TOTALOBJ, 5) As String
        Dim _PORTCOUNTED As Integer = 0

        For Each _QUERYJOB As System.Management.ManagementObject In _SEARCHER.Get()
            If (_QUERYJOB("Caption") = Nothing) Then Continue For
            If _QUERYJOB("Caption").ToString.Contains("COM") = True Then
                If _QUERYJOB("DeviceId").ToString.Contains("USB") = True Then
                    txtIP.Text = txtIP.Text & Environment.NewLine & "_____PnpENtity_____________________________ "

                    For Each Prop As System.Management.PropertyData In _QUERYJOB.Properties
                        Select Case Prop.Name.ToLower
                            Case "Name".ToLower
                                If IsNothing(_QUERYJOB(Prop.Name)) Then
                                    _VAR_APORTS(_PORTCOUNTED, 0) = Prop.Name.ToString & ": "
                                Else
                                    _VAR_APORTS(_PORTCOUNTED, 0) = Prop.Name.ToString & ": " & _QUERYJOB(Prop.Name).ToString
                                End If
                            Case "DeviceId".ToLower
                                If IsNothing(_QUERYJOB(Prop.Name)) Then
                                    _VAR_APORTS(_PORTCOUNTED, 1) = Prop.Name.ToString & ": "
                                Else
                                    _VAR_APORTS(_PORTCOUNTED, 1) = Prop.Name.ToString & ": " & _QUERYJOB(Prop.Name).ToString
                                End If
                            Case "status".ToLower
                                If IsNothing(_QUERYJOB(Prop.Name)) Then
                                    _VAR_APORTS(_PORTCOUNTED, 2) = Prop.Name.ToString & ": "
                                Else
                                    _VAR_APORTS(_PORTCOUNTED, 2) = Prop.Name.ToString & ": " & _QUERYJOB(Prop.Name).ToString
                                End If
                        End Select


                        If IsNothing(_QUERYJOB(Prop.Name)) Then
                            txtIP.Text = txtIP.Text & Environment.NewLine & Prop.Name.ToString & ": "
                        Else
                            txtIP.Text = txtIP.Text & Environment.NewLine & Prop.Name.ToString & ": " & _QUERYJOB(Prop.Name).ToString
                        End If
                    Next
                    _PORTCOUNTED += 1
                End If
            End If
        Next

        _SEARCHER = New System.Management.ManagementObjectSearcher( _
             "Select * from  Win32_SerialPort")
        TOTALOBJ = TOTALOBJ + _SEARCHER.Get.Count - 1

        For Each _QUERYJOB As System.Management.ManagementObject In _SEARCHER.Get()

            txtIP.Text = txtIP.Text & Environment.NewLine & "__________________________________ "

            For Each Prop As System.Management.PropertyData In _QUERYJOB.Properties
                Select Case Prop.Name.ToLower
                    Case "Name".ToLower
                        If IsNothing(_QUERYJOB(Prop.Name)) Then
                            _VAR_APORTS(_PORTCOUNTED, 0) = Prop.Name.ToString & ": "
                        Else
                            _VAR_APORTS(_PORTCOUNTED, 0) = Prop.Name.ToString & ": " & _QUERYJOB(Prop.Name).ToString
                        End If
                    Case "DeviceId".ToLower
                        If IsNothing(_QUERYJOB(Prop.Name)) Then
                            _VAR_APORTS(_PORTCOUNTED, 1) = Prop.Name.ToString & ": "
                        Else
                            _VAR_APORTS(_PORTCOUNTED, 1) = Prop.Name.ToString & ": " & _QUERYJOB(Prop.Name).ToString
                        End If
                    Case "status".ToLower
                        If IsNothing(_QUERYJOB(Prop.Name)) Then
                            _VAR_APORTS(_PORTCOUNTED, 2) = Prop.Name.ToString & ": "
                        Else
                            _VAR_APORTS(_PORTCOUNTED, 2) = Prop.Name.ToString & ": " & _QUERYJOB(Prop.Name).ToString
                        End If
                End Select


                If IsNothing(_QUERYJOB(Prop.Name)) Then
                    txtIP.Text = txtIP.Text & Environment.NewLine & Prop.Name.ToString & ": "
                Else
                    txtIP.Text = txtIP.Text & Environment.NewLine & Prop.Name.ToString & ": " & _QUERYJOB(Prop.Name).ToString
                End If
            Next
            _PORTCOUNTED += 1
        Next


        AvailablePorts = _VAR_APORTS
        PORTCOUNTED = _PORTCOUNTED

        'Catch err As System.Management.ManagementException
        '    LblPortError.Visible = True
        '    LblPortError.Text = "Failed to read connected ports: " & err.Message
        'End Try

    End Sub


    Dim PortName As String = String.Empty
    Dim BitsPerSecond As String = String.Empty
    Dim Parity As String = String.Empty
    Dim DataBits As String = String.Empty
    Dim StopBits As String = String.Empty


    Private Sub PortRefreshSettings()
        Dim SysSettings As New settings
        SysSettings.Load()
        If (SysSettings.comm_port = Nothing) Then SysSettings.comm_port = "COM1"
        CboPort.Items.Clear()
        For Each SP As String In My.Computer.Ports.SerialPortNames
            CboPort.Items.Add(SP)
        Next

        If TV_Ports.Nodes.Count > 0 Then
            For Each ND As TreeNode In TV_Ports.Nodes
                If ND.Text.Contains(SysSettings.comm_port) Then
                    ND.BackColor = Color.LightYellow
                End If
            Next
        End If

        PortName = SysSettings.comm_port
        BitsPerSecond = SysSettings.baud_rate
        Parity = SysSettings.parity
        DataBits = SysSettings.data_bits
        StopBits = SysSettings.stop_bits

        CboPort.SelectedItem = PortName
        CboBitsPerSecond.SelectedItem = BitsPerSecond

        Select Case Parity
            Case "E"
                CboParity.Text = "Even"
            Case "O"
                CboParity.Text = "Odd"
            Case "N"
                CboParity.Text = "None"
            Case "M"
                CboParity.Text = "Mark"
            Case "S"
                CboParity.Text = "Space"
        End Select

        CboDataBits.SelectedItem = DataBits
        CboStopBits.SelectedItem = StopBits
        txtIP.Text = SysSettings.IPAddress
        txtPort.Text = SysSettings.IPPort
    End Sub

    Private Sub PortSaveSettings()
        Dim SysSettings As New settings
        SysSettings.Load()
        SysSettings.comm_port = CboPort.Text
        SysSettings.baud_rate = CboBitsPerSecond.Text
        Select Case CboParity.Text
            Case "Even"
                SysSettings.parity = "E"
            Case "Odd"
                SysSettings.parity = "O"
            Case "None"
                SysSettings.parity = "N"
            Case "Mark"
                SysSettings.parity = "M"
            Case "Space"
                SysSettings.parity = "S"
            Case Else
        End Select
        SysSettings.data_bits = CboDataBits.Text
        SysSettings.stop_bits = CboStopBits.Text
        SysSettings.IPAddress = txtIP.Text
        SysSettings.IPPort = txtPort.Text
        SysSettings.Save()
    End Sub




    Private Sub EnablePortEdit()
        CboPort.Enabled = True
        CboBitsPerSecond.Enabled = True
        CboParity.Enabled = True
        CboDataBits.Enabled = True
        CboStopBits.Enabled = True

        txtIP.Enabled = True
        txtPort.Enabled = True

        BtnEdit.Enabled = False
        BtnSave.Enabled = True
        BtnCancel.Enabled = True
    End Sub

    Private Sub DisablePortEdit()
        CboPort.Enabled = False
        CboBitsPerSecond.Enabled = False
        CboParity.Enabled = False
        CboDataBits.Enabled = False
        CboStopBits.Enabled = False

        txtIP.Enabled = False
        txtPort.Enabled = False

        BtnEdit.Enabled = True
        BtnSave.Enabled = False
        BtnCancel.Enabled = False
    End Sub
#End Region

#Region "REF. NO. PROCEDURE"
    Private Sub EnableRefNoEdit()
        TxtId.Enabled = True
        BtnSave.Enabled = True
        BtnCancel.Enabled = True
        BtnEdit.Enabled = False
    End Sub
    Private Sub DisableRefNoEdit()
        TxtId.Enabled = False
        BtnSave.Enabled = False
        BtnCancel.Enabled = False
        BtnEdit.Enabled = True
    End Sub

    Private Sub LoadRefNo()
        Dim SysSettings As New settings
        SysSettings.Load()
        Dim Lister
        If SysSettings.ConnectionType = "OLEDB" Then
            Lister = New CLS_OLE_DB
            Lister.connection = OLEDBCONX
        Else
            Lister = New CLS_SQL_DB
            Lister.connection = SQLCONX
        End If
        Lister.Table = "RefNo"
        Lister.OpenTable()

        With Lister.DataReader
            If Lister.DataReader.HasRows Then
                .Read()
                If IsDBNull(.Item("OutBound_Id")) Then
                    TxtId.Text = ""
                Else
                    TxtId.Text = .Item("OutBound_Id")
                End If
            Else
            End If

            .Close()
        End With
    End Sub


    Private Function Validation() As Boolean
        LblRefNoError.Visible = False
        Dim Result As Boolean = True

        Dim Validator As New CLS_CONTROLTOGGLES
        If Validator.ValidChars(Me) = False Then
            LblRefNoError.Visible = True
            LblRefNoError.Text = "Using of quote(') and double quote("") is invalid"
            Return False
            Exit Function
        End If

        If MOD_DATABASEPROC.ExistenceFound("Select RefNo From OutBound_Tbl where RefNo = '" & TxtId.Text & "'", Nothing, Nothing, Nothing) = True Then
            Result = False
            LblRefNoError.Visible = True
            LblRefNoError.Text = "Specified Reference No. already exists. Please Try Another"
            Return Result
        End If

        Return Result
    End Function

    Private Sub SaveRefNo()
        If Validation() = False Then Exit Sub
        Dim SysSettings As New settings
        SysSettings.Load()
        Dim Saver
        If SysSettings.ConnectionType = "OLEDB" Then
            Saver = New CLS_OLE_DB
            Saver.connection = OLEDBCONX
        Else
            Saver = New CLS_SQL_DB
            Saver.connection = SQLCONX
        End If

        Saver.Table = "RefNo"
        Saver.FieldName = "OutBound_Id"
        Saver.Text = Trim(TxtId.Text)
        Saver.Source = "Update RefNo set Outbound_Id = '" & Trim(TxtId.Text) & "'"
        Saver.ExecuteCommand()
        Saver.Cmd.Dispose()

        MessageBox.Show("New Reference Number saved.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub TxtId_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtId.LostFocus
        TxtId.Text = String.Format("{0:00000000}", Val(TxtId.Text))
    End Sub
#End Region



#Region "PANEL TOGGLE"
    Private Sub BtnGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGeneral.Click
        ShowPanel(Pnl_General)
        GeneralRefreshSettings()

    End Sub

    Private Sub BtnPortEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPorts.Click
        ShowPanel(Pnl_Ports)
        RefreshAvailablPorts()
        PortRefreshSettings()

    End Sub

    Private Sub BtnDbase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDbase.Click
        ShowPanel(Pnl_Connection)
        ListDB()
        ServerRefreshSettings()
        DisableServerEdit()
    End Sub

    Private Sub BtnRefNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefNo.Click
        ShowPanel(Pnl_refno)
        LoadRefNo()
        DisableRefNoEdit()
    End Sub

    Private Sub BtnProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProfile.Click
        SetDialog()
        ShowPanel(Pnl_Profile)
        ProfileRefreshSettings()
        DisableProfileEdit()
    End Sub

    Private Sub BtnPrinters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrinters.Click
        '  Pnl_Ports.Parent = Pnl_Details
        '     Pnl_Ports.Visible = True
    End Sub

    Private Sub ShowPanel(ByRef pnl As Panel)
        For Each pnls As Panel In Pnl_Details.Controls.OfType(Of Panel)()
            pnls.Visible = False
        Next

        Pnl_ActionBtns.Visible = True
        pnl.Parent = Pnl_Details
        pnl.Visible = True
    End Sub

#End Region

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        If FrmLogin.Settings = "RO" Then
            MessageBox.Show("You do not have access to edit system settings.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If


        Select Case True
            Case Pnl_General.Visible
                EnableGeneralEdit()
            Case Pnl_Ports.Visible
                EnablePortEdit()
            Case Pnl_Connection.Visible
                EnableServerEdit()
            Case Pnl_refno.Visible
                EnableRefNoEdit()
            Case Pnl_Profile.Visible
                EnableProfileEdit()
        End Select

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Select Case True
            Case Pnl_General.Visible
                GeneralSaveSettings()
                DisableGeneralEdit()
            Case Pnl_Ports.Visible
                PortSaveSettings()
                DisablePortEdit()
            Case Pnl_Connection.Visible
                ServerSaveSettings()
                DisableServerEdit()
            Case Pnl_refno.Visible
                SaveRefNo()
                DisableRefNoEdit()
            Case Pnl_Profile.Visible
                ProfileSaveSettings()
                DisableProfileEdit()
        End Select
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        LblRefNoError.Visible = False
        LblPortError.Visible = False

        Select Case True
            Case Pnl_General.Visible
                GeneralRefreshSettings()
                DisableGeneralEdit()
            Case Pnl_Ports.Visible
                PortRefreshSettings()
                DisablePortEdit()
            Case Pnl_Connection.Visible
                ServerRefreshSettings()
                DisableServerEdit()
            Case Pnl_refno.Visible
                LoadRefNo()
                DisableRefNoEdit()
            Case Pnl_Profile.Visible
                ProfileRefreshSettings()
                DisableProfileEdit()
        End Select
    End Sub



    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub BtnAdv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdv.Click
        If BtnAdv.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Down16 Then
            Pnl_Adv.Visible = True
            BtnAdv.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Up16
        Else
            BtnAdv.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Down16
            Pnl_Adv.Visible = False
        End If
    End Sub

    Private Sub TV_Ports_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TV_Ports.AfterSelect

    End Sub

    Private Sub TV_Ports_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TV_Ports.DoubleClick
        Try
            Dim SysSettings As New settings
            SysSettings.Load()
            If TV_Ports.Nodes.Count = 0 Then Exit Sub

            If TV_Ports.SelectedNode.Level = 0 Then
                Dim Status As String = Trim(Mid(TV_Ports.SelectedNode.Nodes(1).Text.ToLower, 9, TV_Ports.SelectedNode.Nodes(1).Text.Length))

                If Status = "Ok".ToLower = False Then
                    MessageBox.Show("Failed to set selected port due to system error.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If


                Dim Prt As String = _
                    Replace(Mid(TV_Ports.SelectedNode.Text, TV_Ports.SelectedNode.Text.Length - 4, 6), ")", "")
                'MessageBox.Show(Prt)
                SysSettings.comm_port = Prt
                SysSettings.Save()
                CboPort.Text = SysSettings.comm_port
                MessageBox.Show(TV_Ports.SelectedNode.Text & "selected.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("No value is available.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RefeshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefeshToolStripMenuItem.Click
        Select Case True
            Case Pnl_Ports.Visible
                PortRefreshSettings()
                DisablePortEdit()
            Case Pnl_Connection.Visible
                ServerRefreshSettings()
                DisableServerEdit()
            Case Pnl_refno.Visible
                LoadRefNo()
                DisableRefNoEdit()
        End Select
    End Sub


#Region "PROFILE"
    Private OFdialog As New OpenFileDialog
    Private Sub SetDialog()
        OFdialog.Multiselect = False
        OFdialog.DefaultExt = "JPEG image [*.jpg]|"
        OFdialog.AddExtension = False
        OFdialog.Filter = "JPEG Image [*.jpg]|*.jpg| Bitmap Image [*.BMP]|*.BMP| Png [*.PNG]|*.Png"
        OFdialog.FileName = ""
    End Sub

    Private Sub ProfileRefreshSettings()
        Dim Viewer As New CLS_OLE_DB
        With Viewer
            .CONNECTION = OLEDBCONX
            .Source = "Select * from CompanyProfile where Id = '1'"
            .OpenSource()
        End With

        If Viewer.DATAREADER.HasRows Then
            While Viewer.DATAREADER.Read
                With Viewer.DATAREADER
                    If IsDBNull(.Item("CompanyName")) Then TxtCompanyNme.Text = "" Else TxtCompanyNme.Text = .Item("CompanyName")
                    If IsDBNull(.Item("OfficeAddress")) Then TxtCompanyAddr.Text = "" Else TxtCompanyAddr.Text = .Item("OfficeAddress")
                    Try
                        If IsDBNull(Viewer.DATAREADER("CompanyLogo")) = False Then
                            Dim cmd As New System.Data.OleDb.OleDbCommand("select CompanyLogo from COmpanyProfile where Id = '1'", OLEDBCONX)
                            Pict.Image = Image.FromStream(New IO.MemoryStream(CType(cmd.ExecuteScalar, Byte())))
                        End If
                    Catch ex As Exception

                    End Try
                End With
            End While
            Viewer.DATAREADER.Close()
        End If

    End Sub

    Private Sub ProfileSaveSettings()
        Dim Viewer As New CLS_OLE_DB
        With Viewer
            .CONNECTION = OLEDBCONX
            .Source = "Update CompanyProfile set " & _
                "[CompanyName] = '" & Trim(TxtCompanyNme.Text) & "'" & _
                ",[OfficeAddress] = '" & Trim(TxtCompanyAddr.Text) & "'" & _
                "Where Id  = '1'"
            .OpenSource()

            SavePhoto(Pict.Image)
        End With


    End Sub

#Region "SAVING PROFILE PHOTO"
    Private Sub SavePhoto(ByVal img As Image)
        Dim cmd As New System.Data.OleDb.OleDbCommand
        If IsNothing(img) Then
            Dim Saver As New CLS_OLE_DB
            Saver.CONNECTION = OLEDBCONX
            Saver.Source = "Update CompanyProfile set CompanyLogo = Null where Id ='1'"
            Saver.ExecuteCommand()
            cmd.Dispose()
        Else
            cmd = New System.Data.OleDb.OleDbCommand("Update CompanyProfile set CompanyLogo = (@ImageData) where Id ='1'", OLEDBCONX)
            Dim param As New System.Data.OleDb.OleDbParameter("@ImageData", SqlDbType.VarBinary)
            Dim ImageData As Byte() = ConvertImage(img)
            param.Value = ImageData
            cmd.Parameters.Add(param)
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Public Function ConvertImage(ByVal myImage As Image) As Byte()
        Dim mstream As New System.IO.MemoryStream
        myImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)

        Dim myBytes(mstream.Length - 1) As Byte
        mstream.Position = 0

        mstream.Read(myBytes, 0, mstream.Length)

        Return myBytes
    End Function
#End Region



    Private LOgoPath As String = ""
    Private Sub BtnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnChange.Click

        OFDIalog.ShowDialog()
        If String.IsNullOrEmpty(OFDIalog.FileName) Then Exit Sub

        Pict.SizeMode = PictureBoxSizeMode.StretchImage
        Pict.Image = Image.FromFile(OFDIalog.FileName)
        LOgoPath = OFDIalog.FileName

        '   Pict.ImageLocation = OFdialog.FileName.ToString
    End Sub


    Private Sub BtnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemove.Click
        Pict.Image = Nothing
    End Sub


    Private Sub EnableProfileEdit()
        TxtCompanyAddr.Enabled = True
        TxtCompanyNme.Enabled = True
        BtnChange.Enabled = True
        BtnRemove.Enabled = True

        BtnSave.Enabled = True
        BtnCancel.Enabled = True
        BtnEdit.Enabled = False
    End Sub


    Private Sub DisableProfileEdit()
        TxtCompanyAddr.Enabled = False
        TxtCompanyNme.Enabled = False
        BtnChange.Enabled = False
        BtnRemove.Enabled = False
        BtnSave.Enabled = False
        BtnCancel.Enabled = False
        BtnEdit.Enabled = True
    End Sub
#End Region


    Private Sub RdoPrintInOut_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoEnablePrint.CheckedChanged, RdoDisablePrint.CheckedChanged
        If RdoEnablePrint.Enabled = True Then Pnl_PrintInOut.Enabled = True Else _
            Pnl_PrintInOut.Enabled = False

    End Sub

    Private Sub PushButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBackupData.Click
        Dim SysSettings As New settings
        SysSettings.Load()
        SFDialog.DefaultExt = "Access File[*.Mdb]|"
        SFDialog.AddExtension = False
        SFDialog.Filter = "Access File [*.mdb]|*.mdb"
        SFDialog.ShowDialog()
        If String.IsNullOrEmpty(SFDialog.FileName) = False Then
            System.IO.File.Copy(SysSettings.access_file_path, SFDialog.FileName)

            MessageBox.Show("Datase backup complete.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub

    Private Sub BtnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBackup.Click
        If FrmLogin.Settings = "RO" Then
            MessageBox.Show("You do not have access to backup database.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If


        ShowPanel(Pnl_Backup)
        Pnl_ActionBtns.Visible = False
    End Sub

    Private Sub Pnl_Backup_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Pnl_Backup.Paint

    End Sub

    Private Sub Pnl_Backup_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pnl_Backup.VisibleChanged
        If Pnl_Backup.Visible = False Then
            Pnl_ActionBtns.Visible = True
        End If
    End Sub

    Private Sub CboIndicator_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboIndicator.SelectedIndexChanged

    End Sub
End Class