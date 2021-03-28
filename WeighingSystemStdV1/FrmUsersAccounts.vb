Imports System.Data.SqlClient

Public Class FrmUsersAccounts
#Region "VARIABLES"

    Dim Ctrl(16) As Control
    Dim Grphcs As Graphics

    Dim X As Double = 125
    Dim Y As Double = 250

    Dim OnEdit As Boolean
    Dim AddSwitch As Boolean
    Dim EditSwitch As Boolean

    Dim PreviousCode As String
    Dim PreviousName As String
    Dim PreviousID As String
    Dim EditedId As String
    Dim Id_Val As String
#End Region

    Private Sub FrmUsersAccounts_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Alt Or e.Control Or e.Shift = False Then
            If e.KeyCode = Keys.Enter Then
                If TypeOf Me.ActiveControl Is MykeCtrlEx.PushButton Then Exit Sub
                SelectNextControl(Me.ActiveControl, True, True, True, True)
            End If
        End If

        If e.Alt Or e.Shift = True Then Exit Sub
        If e.Control = True Then
            Select Case e.KeyCode
                Case Keys.A
                    BtnAdd_Click(sender, e)
                Case Keys.E
                    BtnEdit_Click(sender, e)
                Case Keys.Delete
                    BtnDelete_Click(sender, e)
                Case Keys.S
                    BtnSave_Click(sender, e)
            End Select
        Else
            If e.KeyCode = Keys.Escape Then
                BtnCancel_Click(sender, e)
            End If
        End If
    End Sub


    Private Sub FrmUsersAccounts_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetPermisisonGrid()
        ListData()
        DisableData()
    End Sub

    Private Sub SetPermisisonGrid()
        Dim rw(3) As String
        rw(0) = "WEIGHING TRANSACTION"
        DgPermission.Rows.Add(rw)
        rw(0) = "OFFLINE WEIGHING"
        DgPermission.Rows.Add(rw)
        rw(0) = "REPRINT-TICKET(ALLOW ONLY)"
        DgPermission.Rows.Add(rw)
        rw(0) = "TRANSACTION MANAGEMENT"
        DgPermission.Rows.Add(rw)
        rw(0) = "FILE MAINTENANCE"
        DgPermission.Rows.Add(rw)
        rw(0) = "REPORTING(ALLOW ONLY)"
        DgPermission.Rows.Add(rw)
        rw(0) = "USER CONTROL"
        DgPermission.Rows.Add(rw)
        rw(0) = "SETTINGS"
        DgPermission.Rows.Add(rw)
        rw(0) = "LOGS"
        DgPermission.Rows.Add(rw)
    End Sub

    Private Sub ListData()
        Try
            Dim SysSettings As New settings
            SysSettings.Load()

            Dim Cls_Crypt As New CLS_CRYPTO
            DG.Rows.Clear()
            Dim cls
            If SysSettings.ConnectionType = "OLEDB" Then
                cls = New CLS_OLE_DB
                cls.connection = OLEDBCONX
            Else
                cls = New CLS_SQL_DB
                cls.connection = SQLCONX
            End If

            With cls
                .Table = "UserAccounts"
                .OpenTable()
            End With
            With cls.DataReader
                If .HasRows Then
                    Dim Rw As DataGridViewRow
                    While .Read
                        DG.Rows.Add(.Item("User_Id"))
                        DG.Rows(DG.Rows.Count - 1).Selected = True
                        DG.FirstDisplayedScrollingRowIndex = DG.Rows.Count - 1
                        DG.CurrentCell = DG.Rows.Item(DG.Rows.Count - 1).Cells(0)
                        Rw = DG.CurrentRow

                        If IsDBNull(.Item("User_Name")) Then Rw.Cells("Col_Name").Value = "" Else Rw.Cells("Col_Name").Value = Trim(.Item("User_Name").ToString)
                        If IsDBNull(.Item("User_DisplayName")) Then Rw.Cells("Col_DisplayName").Value = "" Else Rw.Cells("Col_DisplayName").Value = Trim(.Item("User_DisplayName").ToString)
                        If IsDBNull(.Item("User_Password")) Then Rw.Cells("Col_Password").Value = "" Else Rw.Cells("Col_Password").Value = Cls_Crypt.Decrypt(Trim(.Item("User_Password").ToString))
                        If IsDBNull(.Item("ContactNo")) Then Rw.Cells("Col_ContactNo").Value = "" Else Rw.Cells("Col_ContactNo").Value = Trim(.Item("ContactNo").ToString)

                        If IsDBNull(.Item("WeighingTransaction")) Then Rw.Cells("Col_Online").Value = "" Else Rw.Cells("Col_Online").Value = Trim(.Item("WeighingTransaction").ToString)
                        If IsDBNull(.Item("ManualWeighing")) Then Rw.Cells("Col_Offline").Value = "" Else Rw.Cells("Col_Offline").Value = Trim(.Item("ManualWeighing").ToString)
                        If IsDBNull(.Item("EditInBound")) Then Rw.Cells("Col_inbound").Value = "" Else Rw.Cells("Col_inbound").Value = Trim(.Item("EditInbound").ToString)
                        If IsDBNull(.Item("WeighingModule")) Then Rw.Cells("Col_management").Value = "" Else Rw.Cells("Col_Management").Value = Trim(.Item("WeighingModule").ToString)
                        If IsDBNull(.Item("DBMaintenance")) Then Rw.Cells("Col_DB").Value = "" Else Rw.Cells("Col_DB").Value = Trim(.Item("DBMaintenance").ToString)
                        If IsDBNull(.Item("SummaryReport")) Then Rw.Cells("Col_Reports").Value = "" Else Rw.Cells("Col_reports").Value = Trim(.Item("SummaryReport").ToString)
                        If IsDBNull(.Item("Settings")) Then Rw.Cells("Col_Settings").Value = "" Else Rw.Cells("Col_Settings").Value = Trim(.Item("Settings").ToString)
                        If IsDBNull(.Item("UserControl")) Then Rw.Cells("Col_UserControl").Value = "" Else Rw.Cells("Col_UserControl").Value = Trim(.Item("UserControl").ToString)
                        If IsDBNull(.Item("ModTrans")) Then Rw.Cells("Col_ModTrans").Value = "" Else Rw.Cells("Col_ModTrans").Value = Trim(.Item("ModTrans").ToString)
                        If IsDBNull(.Item("RePrintTrans")) Then Rw.Cells("Col_RePrintTrans").Value = "" Else Rw.Cells("Col_RePrintTrans").Value = Trim(.Item("RePrintTrans").ToString)
                        '  If IsDBNull(.Item("VesselMon")) Then Rw.Cells("Col_VesselMon").Value = "" Else Rw.Cells("Col_VesselMon").Value = Trim(.Item("VesselMon").ToString)
                        If IsDBNull(.Item("Logs")) Then Rw.Cells("Col_Logs").Value = "" Else Rw.Cells("Col_logs").Value = Trim(.Item("Logs").ToString)

                        TxtSearch.AutoCompleteCustomSource.Add(Rw.Cells("Col_DisplayName").Value)
                    End While
                End If
                .Close()
            End With


            BtnFirst_Click(Nothing, Nothing)

            ViewData()

        Catch ex As Exception
            Dim CL As New CLS_LOG
            With CL
                .User = FrmLogin.UserDisplayName
                .LogError = ex.Message
                .LogLocation = "User Accounts  Window"
                .Remarks = "An error encountered while listing data"
                .CreateErrorLog()
            End With
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GetUserPermission(ByVal PerVal As String, ByVal RowNum As Integer)
        Select Case PerVal
            Case "N/A"
                DgPermission.Rows(RowNum).Cells(1).Value = False
                DgPermission.Rows(RowNum).Cells(2).Value = False
            Case "RO"
                DgPermission.Rows(RowNum).Cells(1).Value = True
                DgPermission.Rows(RowNum).Cells(2).Value = False
            Case "RW"
                DgPermission.Rows(RowNum).Cells(1).Value = False
                DgPermission.Rows(RowNum).Cells(2).Value = True
        End Select
    End Sub


    Private Sub ViewData()
        Try
            ClearData()

            TxtId.Text = DG.CurrentRow.Cells("Col_Id").Value
            TxtUserName.Text = DG.CurrentRow.Cells("Col_Name").Value
            TxtPassword.Text = DG.CurrentRow.Cells("Col_password").Value
            TxtConfirm.Text = DG.CurrentRow.Cells("Col_password").Value
            TxtDisplayName.Text = DG.CurrentRow.Cells("Col_displayName").Value
            TxtContactNo.Text = DG.CurrentRow.Cells("Col_ContactNo").Value

            GetUserPermission(DG.CurrentRow.Cells(Col_Online.Name).Value, 0)
            GetUserPermission(DG.CurrentRow.Cells(Col_Offline.Name).Value, 1)
            GetUserPermission(DG.CurrentRow.Cells(Col_ReprintTrans.Name).Value, 2)
            GetUserPermission(DG.CurrentRow.Cells(Col_Management.Name).Value, 3)
            GetUserPermission(DG.CurrentRow.Cells(Col_DB.Name).Value, 4)
            GetUserPermission(DG.CurrentRow.Cells(Col_Reports.Name).Value, 5)
            GetUserPermission(DG.CurrentRow.Cells(Col_UserControl.Name).Value, 6)
            GetUserPermission(DG.CurrentRow.Cells(Col_Settings.Name).Value, 7)
            GetUserPermission(DG.CurrentRow.Cells(Col_Logs.Name).Value, 8)

        Catch ex As Exception
            Dim CL As New CLS_LOG
            With CL
                .User = FrmLogin.UserDisplayName
                .LogError = ex.Message
                .LogLocation = "Useraccounts Window"
                .Remarks = "An error encountered while viewing entry"
                .CreateErrorLog()
            End With
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub DgPermission_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgPermission.CellClick
        If DgPermission.Rows.Count = 0 Then Exit Sub
        If e.ColumnIndex = 0 Then Exit Sub
        If e.RowIndex = -1 Then Exit Sub
        Select Case e.ColumnIndex
            Case 1
                If DgPermission.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = False Then
                    DgPermission.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = False
                End If
            Case 2
                If DgPermission.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = False Then
                    DgPermission.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value = False
                End If
        End Select
    End Sub






    Private Sub DG_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG.Click
        If DG.Rows(DG.Rows.Count - 1).IsNewRow Then
            LblRecord.Text = DG.CurrentRow.Index + 1 & " OF " & DG.Rows.Count - 1
        Else
            LblRecord.Text = DG.CurrentRow.Index + 1 & " OF " & DG.Rows.Count
        End If

        ViewData()
    End Sub

    Private Sub DG_CurrentCellChanged(sender As Object, e As EventArgs) Handles DG.CurrentCellChanged

    End Sub


    Private Sub DG_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG.DoubleClick
        BtnEdit_Click(sender, e)
    End Sub


    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If BtnAdd.Enabled = False Then Exit Sub
        AddSwitch = True
        EditSwitch = False
        OnEdit = True

        ClearData()
        EnableData()
        TxtId.Enabled = False
        TxtUserName.Focus()
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        If BtnEdit.Enabled = False Then Exit Sub
        If DG.Rows.Count = 0 Then Exit Sub
        PreviousID = TxtId.Text
        PreviousName = TxtUserName.Text
        EditSwitch = True
        AddSwitch = False
        OnEdit = True
        EnableData()
        TxtUserName.Focus()
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Try
            If BtnDelete.Enabled = False Then Exit Sub
            Dim SysSettings As New settings
            SysSettings.Load()
            If TxtId.Text = FrmLogin.UserId Then
                MessageBox.Show("Unable to delete user that is currently logging in", "", MessageBoxButtons.OK)
                Exit Sub

            End If
            If DG.Rows.Count = 0 Then Exit Sub
            If DG.Enabled = False Then Exit Sub


            If MOD_DATABASEPROC.ExistenceFound("select * From Outbound_Tbl where WeigherIn  = '" & DG.CurrentRow.Cells(0).Value & "'", Nothing, Nothing, Nothing) Then
                MessageBox.Show("* User account cannot cannot be deleted because it is being used by another table.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            If MOD_DATABASEPROC.ExistenceFound("select * From Outbound_Tbl where WeigherOut  = '" & DG.CurrentRow.Cells(0).Value & "'", Nothing, Nothing, Nothing) Then
                MessageBox.Show("* User account cannot cannot be deleted because it is being used by another table.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            If MOD_DATABASEPROC.ExistenceFound("select * From Outbound_Tbl where MODby  = '" & DG.CurrentRow.Cells(0).Value & "'", Nothing, Nothing, Nothing) Then
                MessageBox.Show("* User account cannot cannot be deleted because it is being used by another table.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            If MessageBox.Show("Are you sure you want to delete selected record\s?", "", MessageBoxButtons.YesNo, _
                               MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim Remover
                If SysSettings.ConnectionType = "OLEDB" Then
                    Remover = New CLS_OLE_DB
                    Remover.connection = OLEDBCONX
                Else
                    Remover = New CLS_SQL_DB
                    Remover.connection = SQLCONX
                End If

                Remover.Table = "UserAccounts"
                Remover.FieldName = "User_id"
                Dim ss As New CLS_OLE_DB

                Remover.DeleteMultiple(DG, 0, TxtSearch)

                'LblReccount.Text = DG.Rows.Count

                DG_Click(sender, e)

                MessageBox.Show("Deleting Complete...", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            Dim CL As New CLS_LOG
            With CL
                .User = FrmLogin.UserDisplayName
                .LogError = ex.Message
                .LogLocation = "User Accounts Window"
                .Remarks = "An error encountered while deleting  entry"
                .CreateErrorLog()
            End With
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try

            If BtnSave.Enabled = False Then Exit Sub
          

            Dim Cls_Crypt As New CLS_CRYPTO

            Dim Validator As New CLS_CONTROLTOGGLES
            If Validator.ValidChars(Me) = False Then
                MessageBox.Show("Using of quote(') and double quote("") is invalid", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            If Validation() = False Then Exit Sub
            If Trim(TxtPassword.Text) <> Trim(TxtConfirm.Text) Then
                MessageBox.Show("Password confirmation didn't match.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

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


            If AddSwitch = True Then

                With Saver
                    .table = "refNo"
                    .FieldName = "user_id"
                    TxtId.Text = .GeneratedId
                End With

                Saver.Table = "UserAccounts"
                Saver.Source = "Insert into UserAccounts (User_Id,User_Name,User_PassWord" & _
                    ",User_DisplayName,ContactNo" & _
                    ",WeighingTransaction,ManualWeighing,RepRintTrans" & _
                    ",WeighingModule,DBMaintenance,SummaryReport" & _
                     ",UserControl,Settings,logs)" & _
                        "values (" & _
                    "'" & TxtId.Text & "'" & _
                    ",'" & Trim(TxtUserName.Text) & "','" & Cls_Crypt.Encrypt((TxtPassword.Text)) & "'" & _
                    ",'" & Trim(TxtDisplayName.Text) & "','" & Trim(TxtContactNo.Text) & "'" & _
                    ",'" & GetPermissionValue(0) & "','" & GetPermissionValue(1) & "','" & GetPermissionValue(2) & "'" & _
                     ",'" & GetPermissionValue(3) & "','" & GetPermissionValue(4) & "','" & GetPermissionValue(5) & "'" & _
                      ",'" & GetPermissionValue(6) & "','" & GetPermissionValue(7) & "','" & GetPermissionValue(8) & "')"

                Saver.ExecuteCommand()
                Saver.Cmd.Dispose()

                TxtSearch.AutoCompleteCustomSource.Add(Trim(TxtDisplayName.Text))

                Saver.Table = "RefNo"
                Saver.FieldName = "User_id"
                Saver.Text = TxtId.Text
                Saver.UpdateId()

                UpdateList()

                DG_Click(Nothing, Nothing)
                DisableData()

                MessageBox.Show("New Record Added...", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            If EditSwitch = True Then

                Saver.Source = "Update UserAccounts Set " & _
                  "User_Name= '" & Trim(TxtUserName.Text) & "'" & _
                  ",User_PassWord= '" & Cls_Crypt.Encrypt((TxtPassword.Text)) & "'" & _
                 ",User_DisplayName = '" & Trim(TxtDisplayName.Text) & "'" & _
                ",ContactNo = '" & TxtContactNo.Text.Trim & "'" & _
                 ",WeighingTransaction= '" & GetPermissionValue(0) & "'" & _
                ",ManualWeighing= '" & GetPermissionValue(1) & "'" & _
                ",ReprintTrans= '" & GetPermissionValue(2) & "'" & _
                ",WeighingModule= '" & GetPermissionValue(3) & "'" & _
                ",DBMaintenance= '" & GetPermissionValue(4) & "'" & _
                ",SummaryReport= '" & GetPermissionValue(5) & "'" & _
                ",Settings= '" & GetPermissionValue(6) & "'" & _
                 ",UserControl= '" & GetPermissionValue(7) & "'" & _
                    ",logs= '" & GetPermissionValue(8) & "'" & _
                 "where User_id = '" & TxtId.Text & "'"
                ' MessageBox.Show(Saver.source)
                Saver.ExecuteCommand()
                Saver.Cmd.Dispose()

                TxtSearch.AutoCompleteCustomSource.Remove(Trim(TxtDisplayName.Text))
                TxtSearch.AutoCompleteCustomSource.Add(Trim(TxtDisplayName.Text))
                UpdateList()
                DG_Click(Nothing, Nothing)
                DisableData()

                MessageBox.Show("Editing Record Complete...", "", MessageBoxButtons.OK, MessageBoxIcon.Information)


                AddSwitch = False
                EditSwitch = False
                OnEdit = False

                If TxtId.Text = FrmLogin.UserId Then
                    If MessageBox.Show("User should log-out to take its effect. Do you want to logout?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Me.Close()
                        MDIMAIN.BtnExit_Click(sender, e)
                    End If
                End If
            End If

        Catch ex As Exception
            Dim CL As New CLS_LOG
            With CL
                .User = FrmLogin.UserDisplayName
                .LogError = ex.Message
                .LogLocation = "User Accounts Window"
                .Remarks = "An error encountered while saving entry"
                .CreateErrorLog()
            End With
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        If BtnCancel.Enabled = False Then Exit Sub
        ClearData()
        DisableData()
        DG_Click(sender, e)
    End Sub







    Private Function GetPermissionValue(ByVal RowNum As Integer) As String
        If DgPermission.Rows(RowNum).Cells(1).Value = False And DgPermission.Rows(RowNum).Cells(2).Value = False Then
            Return "N/A"
        End If
        Select Case True

            Case DgPermission.Rows(RowNum).Cells(1).Value
                Return "RO"
            Case DgPermission.Rows(RowNum).Cells(2).Value
                Return "RW"
        End Select
        Return Nothing
    End Function


    Private Function Validation() As Boolean
        Try

            Dim Result As Boolean = True

            Dim StrErr As String = Nothing
            If String.IsNullOrEmpty(TxtUserName.Text) Then
                StrErr = "No User Name was entered"
                Result = False
            Else
                Select Case True
                    Case AddSwitch
                        If MOD_DATABASEPROC.ExistenceFound("Select * From UserAccounts where User_Name = '" & Trim(TxtUserName.Text) & "'", _
                                                Nothing, Nothing, Nothing) = True Then
                            StrErr = "User Name is already in the registered"
                            Result = False
                        End If
                    Case EditSwitch
                        If MOD_DATABASEPROC.ExistenceFound("Select * From UserAccounts where User_Name = '" & Trim(TxtUserName.Text) & "' and User_Id <> '" & TxtId.Text & "'", _
                                                Nothing, Nothing, Nothing) = True Then
                            StrErr = "User Name is already in the registered"
                            Result = False
                        End If
                End Select
             
            End If


            If String.IsNullOrEmpty(TxtDisplayName.Text) Then
                StrErr = Environment.NewLine & "No Display Name was entered"
                Result = False
            Else

                Select Case True
                    Case AddSwitch
                        If MOD_DATABASEPROC.ExistenceFound("Select * From UserAccounts where User_DisplayName = '" & Trim(TxtDisplayName.Text) & "'", _
                                                                    Nothing, Nothing, Nothing) = True Then
                            StrErr = Environment.NewLine & "Display Name is already in the database"
                            Result = False
                        End If
                    Case EditSwitch
                        If MOD_DATABASEPROC.ExistenceFound("Select * From UserAccounts where User_DisplayName = '" & Trim(TxtDisplayName.Text) & "' and User_Id <> '" & TxtId.Text & "'", _
                                                  Nothing, Nothing, Nothing) = True Then
                            StrErr = Environment.NewLine & "Display Name is already in the database"
                            Result = False
                        End If
                End Select
             
            End If

            If StrErr IsNot Nothing Then
                MessageBox.Show(StrErr, "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
            Return Result

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return False
        End Try
    End Function

    Private Sub UpdateList()
        Try

            Dim SysSettings As New settings
            SysSettings.Load()
            Dim cls
            If SysSettings.ConnectionType = "OLEDB" Then
                cls = New CLS_OLE_DB
                cls.connection = OLEDBCONX
            Else
                cls = New CLS_SQL_DB
                cls.connection = SQLCONX
            End If

            cls.table = "UserAccounts"
            cls.fieldname = "user_id"
            cls.text = TxtId.Text
            cls.searchtable()

            With cls.datareader
                If .HasRows Then

                    Dim Rw As DataGridViewRow
                    While .Read

                        If AddSwitch = True Then
                            DG.Rows.Add(.Item("User_Id"))
                            DG.Rows(DG.Rows.Count - 1).Selected = True
                            DG.FirstDisplayedScrollingRowIndex = DG.Rows.Count - 1
                            DG.CurrentCell = DG.Rows.Item(DG.Rows.Count - 1).Cells(0)
                        End If

                        Rw = DG.CurrentRow

                        If IsDBNull(.Item("User_Name")) Then Rw.Cells("Col_Name").Value = "" Else Rw.Cells("Col_Name").Value = Trim(.Item("User_Name").ToString)
                        If IsDBNull(.Item("User_DisplayName")) Then Rw.Cells("Col_DisplayName").Value = "" Else Rw.Cells("Col_DisplayName").Value = Trim(.Item("User_DisplayName").ToString)
                        If IsDBNull(.Item("User_Password")) Then Rw.Cells("Col_Password").Value = "" Else Rw.Cells("Col_Password").Value = Trim(.Item("User_Password").ToString)
                        If IsDBNull(.Item("ContactNo")) Then Rw.Cells("Col_ContactNo").Value = "" Else Rw.Cells("Col_ContactNo").Value = Trim(.Item("ContactNo").ToString)

                        If IsDBNull(.Item("WeighingTransaction")) Then Rw.Cells("Col_Online").Value = "" Else Rw.Cells("Col_Online").Value = Trim(.Item("WeighingTransaction").ToString)
                        If IsDBNull(.Item("ManualWeighing")) Then Rw.Cells("Col_Offline").Value = "" Else Rw.Cells("Col_Offline").Value = Trim(.Item("ManualWeighing").ToString)
                        '  If IsDBNull(.Item("EditOutBound")) Then Rw.Cells("Col_Management").Value = "" Else Rw.Cells("Col_management").Value = Trim(.Item("EditOutBoun").ToString)
                        If IsDBNull(.Item("WeighingModule")) Then Rw.Cells("Col_management").Value = "" Else Rw.Cells("Col_Management").Value = Trim(.Item("WeighingModule").ToString)
                        If IsDBNull(.Item("DBMaintenance")) Then Rw.Cells("Col_DB").Value = "" Else Rw.Cells("Col_DB").Value = Trim(.Item("DBMaintenance").ToString)
                        If IsDBNull(.Item("SummaryReport")) Then Rw.Cells("Col_Reports").Value = "" Else Rw.Cells("Col_reports").Value = Trim(.Item("SummaryReport").ToString)
                        If IsDBNull(.Item("Settings")) Then Rw.Cells("Col_Settings").Value = "" Else Rw.Cells("Col_Settings").Value = Trim(.Item("Settings").ToString)
                        If IsDBNull(.Item("UserControl")) Then Rw.Cells("Col_UserControl").Value = "" Else Rw.Cells("Col_UserControl").Value = Trim(.Item("UserControl").ToString)
                        If IsDBNull(.Item("ModTrans")) Then Rw.Cells("COl_ModTrans").Value = "" Else Rw.Cells("Col_ModTrans").Value = Trim(.Item("ModTrans").ToString)
                        If IsDBNull(.Item("RePrintTrans")) Then Rw.Cells("Col_RePrintTrans").Value = "" Else Rw.Cells("Col_RePrintTrans").Value = Trim(.Item("RePrintTrans").ToString)
                        If IsDBNull(.Item("Logs")) Then Rw.Cells("Col_LOgs").Value = "" Else Rw.Cells("Col_LOgs").Value = Trim(.Item("LOgs").ToString)


                        If AddSwitch = True Then
                            TxtSearch.AutoCompleteCustomSource.Add(Rw.Cells("Col_Name").Value)
                        Else
                            TxtSearch.AutoCompleteCustomSource.Remove(PreviousName)
                            TxtSearch.AutoCompleteCustomSource.Add(Rw.Cells("Col_Name").Value)
                        End If

                    End While
                End If

                .Close()
            End With

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub




    Private Sub ClearData()
        Dim CLS_CLR As New CLS_CONTROLTOGGLES
        CLS_CLR.ClearDataControls(Me)

        For Each Rw As DataGridViewRow In DgPermission.Rows
            Rw.Cells(1).Value = False
            Rw.Cells(2).Value = False
        Next
    End Sub

    Private Sub EnableData()
        Dim CLS_CLR As New CLS_CONTROLTOGGLES
        CLS_CLR.EnableDataControls(Me)
        DgPermission.Enabled = True
        TxtId.Enabled = False
        BtnAdd.Enabled = False
        BtnEdit.Enabled = False
        BtnDelete.Enabled = False
        BtnSave.Enabled = True
        BtnCancel.Enabled = True
        TxtSearch.Enabled = False
        DG.Enabled = False
    End Sub

    Private Sub DisableData()
  Dim CLS_CLR As New CLS_CONTROLTOGGLES
        CLS_CLR.DisableDataControls(Me)
        DgPermission.Enabled = False
        BtnAdd.Enabled = True
        BtnEdit.Enabled = True
        BtnDelete.Enabled = True
        BtnSave.Enabled = False
        BtnCancel.Enabled = False
        TxtSearch.Enabled = True
        TxtId.Enabled = False
        DG.Enabled = True
    End Sub

    Private Sub TxtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearch.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                BtnSearch_Click(sender, e)
        End Select
    End Sub
    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

#Region "NAVIGATION ARROW"


    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        If Dg.Rows.Count = 0 Then Exit Sub
        If IsNothing(Dg.CurrentRow) Then Exit Sub
        If DG.CurrentRow.Index = DG.Rows.Count - 1 Then Exit Sub
        DG.Rows(DG.CurrentRow.Index + 1).Selected = True
        DG.FirstDisplayedScrollingRowIndex = DG.CurrentRow.Index + 1
        DG.CurrentCell = DG.Rows.Item(DG.CurrentRow.Index + 1).Cells(2)
        Dg_Click(sender, e)
    End Sub

    Private Sub Btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBack.Click
        If Dg.Rows.Count = 0 Then Exit Sub
        If IsNothing(Dg.CurrentRow) Then Exit Sub
        If Dg.CurrentRow.Index = 0 Then Exit Sub
        Dg.Rows(Dg.CurrentRow.Index - 1).Selected = True
        Dg.FirstDisplayedScrollingRowIndex = Dg.CurrentRow.Index - 1
        Dg.CurrentCell = Dg.Rows.Item(Dg.CurrentRow.Index - 1).Cells(2)
        Dg_Click(sender, e)
    End Sub

    Private Sub BtnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirst.Click
        If Dg.Rows.Count = 0 Then Exit Sub
        If IsNothing(Dg.CurrentRow) Then Exit Sub
        DG.Rows(0).Selected = True
        DG.FirstDisplayedScrollingRowIndex = 0
        DG.CurrentCell = DG.Rows.Item(0).Cells(2)
        Dg_Click(sender, e)
    End Sub

    Private Sub BtnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLast.Click
        If Dg.Rows.Count = Dg.Rows.Count - 1 Then Exit Sub
        If IsNothing(Dg.CurrentRow) Then Exit Sub
        Dg.Rows(Dg.Rows.Count - 1).Selected = True
        Dg.FirstDisplayedScrollingRowIndex = 0
        Dg.CurrentCell = Dg.Rows.Item(Dg.Rows.Count - 1).Cells(2)
        Dg_Click(sender, e)
    End Sub
#End Region
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click

        Me.Close()
    End Sub


    Private Sub Panel6_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel6.Paint

    End Sub
End Class