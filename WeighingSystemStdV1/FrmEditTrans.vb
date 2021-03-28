Public Class FrmEditTrans

#Region "COMMON VARIABLES"
    Private WeighIn As Boolean = False
    Private Weighout As Boolean = False
#End Region

    Private Sub FrmEditTrans_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Alt Or e.Control Or e.Shift = False Then
            If e.KeyCode = Keys.Enter Then
                If TypeOf Me.ActiveControl Is MykeCtrlEx.PushButton Then Exit Sub
                SelectNextControl(Me.ActiveControl, True, True, True, True)
            End If
        End If

        If e.Alt Or e.Shift = True Then Exit Sub
        If e.Control = True Then
            Select Case e.KeyCode
                Case Keys.S
                    Btnsave_Click(sender, e)
                Case Keys.P
                    BtnPrint_Click(sender, e)
                Case Keys.U
                    BtnUpdatePrice_Click(sender, e)
            End Select
        Else
            Select Case e.KeyCode
                Case Keys.F3
                    Btnsave_Click(sender, e)
                Case Keys.Delete
                    BtnDelete_Click(sender, e)
                Case Keys.Escape
                    Btncancel_Click(sender, e)
            End Select
        End If
    End Sub

    Private SysSettings As New settings()
    Private Sub FrmEditTrans_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        SysSettings = New settings()
        SysSettings.Load()
        'Dim pd As System.Windows.Forms.Padding
        'pd.Left = Me.Width * 0.1
        'pd.Right = Me.Width * 0.1
        'pd.Top = 5
        'PnlMain.Padding = pd
        PnlDetails.Top = 5
        PnlDetails.Left = Me.Width / 2 - PnlDetails.Width / 2

        If FrmManagement.RdoInbound.Checked = True Then
            WeighIn = True
            Weighout = False
        Else
            WeighIn = False
            Weighout = True
        End If

        AddHandler Btnsave.Click, AddressOf Btnsave_Click
        AddHandler Btncancel.Click, AddressOf Btncancel_Click
        '  AddHandler BtnEdit.Click, AddressOf BtnEdit_Click
        AddHandler BtnDelete.Click, AddressOf BtnDelete_Click
        AddHandler BtnPrint.Click, AddressOf BtnPrint_Click
        AddHandler BtnExit.Click, AddressOf BtnExit_Click
        AddHandler CboCommodity.KeyPress, AddressOf UPPERCASE_KeyPress
        AddHandler CboClient.KeyPress, AddressOf UPPERCASE_KeyPress

        SetData()

        MOD_DATABASEPROC.ThrowArrayToControl(CboCommodity, CommList)
        MOD_DATABASEPROC.ThrowArrayToControl(TxtDriver, DRVList)

        ClearData()

        Viewdata()

        DisableData()

        BtnClient.Focus()
    End Sub

#Region "SETTINGS DATA VARIABLES"
    Private SupList As New List(Of String)
    Private CustList As New List(Of String)
    Private CommList As New List(Of String)
    Private DRVList As New List(Of String)
    Private Sub SetData()
        MOD_DATABASEPROC.ListDataToArray(CustList, Nothing, "Select CustName From Cust_Tbl where Cactive = true", "CustName", Nothing)
        MOD_DATABASEPROC.ListDataToArray(SupList, Nothing, "Select SupName From Sup_Tbl where SActive = yes", "SupName", Nothing)
        MOD_DATABASEPROC.ListDataToArray(CommList, Nothing, "Select CommDesc from Comm_tbl where active = true", "CommDesc", Nothing)
        MOD_DATABASEPROC.ListDataToArray(DRVList, Nothing, "Select DriverName from Drv_tbl", "DriverName", Nothing)
    End Sub
#End Region

#Region "DATA VIEWING PROCEDURE"
    Private PLATENO_Tmp As String = ""
    Private INBOUNDWT_Tmp As Integer = 0
    Private DTIN_Tmp As String = ""
    Private WEIGHERIN_Tmp As String = ""
    Private RefNO_Tmp As String = ""
    Private Unitweight As String = ""
    Private StartDeduction As Boolean = False
    Private Sub Viewdata()
        Dim SysSettings As New settings()
        SysSettings.Load()
        StartDeduction = True

        '  ClearData()
        Dim Src As String = _
             "SELECT " & _
            "(SELECT CUSTNAME FROM CUST_TBL WHERE CUSTCODE = CustomerCode)" & _
            ",(SELECT CUSTAddr FROM CUST_TBL WHERE CUSTCODE = CustomerCode)" & _
",(SELECT SUPNAME FROM SUP_TBL WHERE SUPCODE =SupplierCode)" & _
",(SELECT SUPAddr FROM SUP_TBL WHERE SUPCODE =SupplierCode)" & _
",(SELECT COMMDESC FROM COMM_TBL WHERE COMMCODE = CommodityCode)" & _
",(SELECT USER_DISPLAYNAME FROM USERACCOUNTS WHERE User_id = WeigherIn)" & _
",(SELECT USER_DISPLAYNAME FROM USERACCOUNTS WHERE User_id = WeigherOUt)" & _
",(SELECT USER_DISPLAYNAME FROM USERACCOUNTS WHERE User_id = MODBy)" & _
",* FROM OUTBOUND_TBL where Refno = '" & FrmManagement.Dg.CurrentRow.Cells("Col_Id").Value & "'"

        Dim cls
        If SysSettings.ConnectionType = "OLEDB" Then
            cls = New CLS_OLE_DB
            cls.connection = OLEDBCONX
        Else
            cls = New CLS_SQL_DB
            cls.connection = SQLCONX
        End If

        With cls
            .source = Src
            .opensource()
        End With

        With cls.DataReader
            If .HasRows Then
                While .Read
                    RefNO_Tmp = .item("RefNo")
                    TxtRefNo.Text = RefNO_Tmp
                    If IsDBNull(.Item("DTIn")) Then TxtDTIn.Text = "" Else TxtDTIn.Text = Format(.Item("DTIn"), "MM-dd-yyyy hh:mm tt")
                    If IsDBNull(.Item("DTOUt")) Then TxtDTOut.Text = "" Else TxtDTOut.Text = Format(.Item("DTOUt"), "MM-dd-yyyy hh:mm tt")
                    If IsDBNull(.Item("PlateNo")) Then TxtPlateNo.Text = "" Else TxtPlateNo.Text = Trim(.Item("PlateNo").ToString)

                    Select Case True
                        Case IsDBNull(.item(0))
                            RdoSup.Checked = True
                            RdoCust.Checked = False
                            If IsDBNull(.Item(2)) Then CboClient.Text = "" Else CboClient.Text = .item(2)
                            If IsDBNull(.Item(3)) Then TxtAddress.Text = "" Else TxtAddress.Text = .item(3)
                        Case IsDBNull(.item(2))
                            RdoSup.Checked = False
                            RdoCust.Checked = True
                            If IsDBNull(.Item(0)) Then CboClient.Text = "" Else CboClient.Text = .item(0)
                            If IsDBNull(.Item(1)) Then TxtAddress.Text = "" Else TxtAddress.Text = .item(1)
                        Case Else
                            CboClient.Text = ""
                            TxtAddress.Text = ""
                    End Select

                    If IsDBNull(.Item(4)) Then CboCommodity.Text = "" Else CboCommodity.Text = .item(4)
                    If IsDBNull(.Item("pricing")) Then TxtPrice.Text = "" Else _
        TxtPrice.Text = FormatNumber(Trim(.Item("Pricing")), 2, TriState.True, TriState.True, TriState.True)
                    If IsDBNull(.item("UnitPerPrice")) Then TxtPriceUnit.Text = "/" Else TxtPriceUnit.Text = "/" & .item("UnitPerPrice")

                    'If IsDBNull(.Item("Gross_Wt")) Then TxtGross.Text = 0 Else TxtGross.Text = .item("Gross_Wt")
                    'If IsDBNull(.Item("Tare_wt")) Then TxtTare.Text = "" Else TxtTare.Text = .item("Tare_wt")
                    'If IsDBNull(.Item("Net_wt")) Then TxtNet.Text = "" Else TxtNet.Text = .item("Net_wt")
                    If IsDBNull(.Item("Gross_DT")) Then TxtGr_Time.Text = "" Else TxtGr_Time.Text = Format(.item("Gross_DT"), "hh:mm tt")
                    If IsDBNull(.Item("Tare_DT")) Then TxtTR_Time.Text = "" Else TxtTR_Time.Text = Format(.item("Tare_DT"), "hh:mm tt")

                    If IsDBNull(.Item("DrNO")) Then TxtDrNo.Text = "" Else TxtDrNo.Text = .item("DRNO")
                    If IsDBNull(.Item("TicketNo")) Then TxtTicketNo.Text = "" Else TxtTicketNo.Text = .item("TicketNo")
                    If IsDBNull(.Item("DriverName")) Then TxtDriver.Text = "" Else TxtDriver.Text = .item("DriverName")
                    If IsDBNull(.Item("remarks")) Then TxtRemarks.Text = "" Else TxtRemarks.Text = .item("remarks")
                    If IsDBNull(.Item(5)) Then txtWin.Text = "" Else txtWin.Text = .Item(5).ToString
                    If IsDBNull(.Item(6)) Then TxtWout.Text = "" Else TxtWout.Text = .Item(6)
                    If IsDBNull(.Item(7)) Then TxtUpdby.Text = "" Else TxtUpdby.Text = .Item(7).ToString
                    If IsDBNull(.Item("ModDT")) Then TxtDTUpd.Text = "" Else TxtDTUpd.Text = Format(.Item("ModDT"), "MM-dd-yyyy hh:mm tt")

                    If WeighIn = True Then
                        If IsDBNull(.Item("inbound_Wt")) Then TxtGross.Text = 0 Else TxtGross.Text = .item("Inbound_wt")
                        PnlWeightStat.Enabled = False
                    Else
                        Unitweight = .item("UnitWeight")
                        LblFinalNetUnit.Text = Unitweight
                        Select Case Unitweight
                            Case "KG"
                                If IsDBNull(.Item("Gross_Wt")) Then TxtGross.Text = 0 Else TxtGross.Text = FormatNumber(.item("Gross_Wt"), 0, TriState.True, TriState.True, TriState.True)
                                If IsDBNull(.Item("Tare_Wt")) Then TxtTare.Text = 0 Else TxtTare.Text = FormatNumber(.item("tare_Wt"), 0, TriState.True, TriState.True, TriState.True)
                                If IsDBNull(.Item("net_Wt")) Then TxtNet.Text = 0 Else TxtNet.Text = FormatNumber(.item("net_Wt"), 0, TriState.True, TriState.True, TriState.True)
                                If IsDBNull(.Item("Final_Wt")) Then TxtFINAL.Text = 0 Else TxtFINAL.Text = FormatNumber(.item("Final_Wt"), 0, TriState.True, TriState.True, TriState.True)
                            Case "TONS"
                                If IsDBNull(.Item("Gross_Wt")) Then TxtGross.Text = 0 Else TxtGross.Text = FormatNumber(.item("Gross_Wt"), 2, TriState.True, TriState.True, TriState.True)
                                If IsDBNull(.Item("Tare_Wt")) Then TxtTare.Text = 0 Else TxtTare.Text = FormatNumber(.item("tare_Wt"), 2, TriState.True, TriState.True, TriState.True)
                                If IsDBNull(.Item("net_Wt")) Then TxtNet.Text = 0 Else TxtNet.Text = FormatNumber(.item("net_Wt"), 2, TriState.True, TriState.True, TriState.True)
                                If IsDBNull(.Item("Final_Wt")) Then TxtFINAL.Text = 0 Else TxtFINAL.Text = FormatNumber(.item("Final_Wt"), 2, TriState.True, TriState.True, TriState.True)
                        End Select

                        LblDedUnit.Text = ("(" & SysSettings.DeductUnit & ")")
                        If IsDBNull(.Item("MC")) Then TxtDeduct.Text = 0 Else TxtDeduct.Text = FormatNumber(.item("MC"), 2, TriState.False, TriState.False, TriState.False)
                        If IsDBNull(.Item("DedReason")) Then TxtReasons.Text = 0 Else TxtReasons.Text = .item("DedReason")
                        PnlWeightStat.Enabled = True
                    End If

                    If SysSettings.EnableDeduction = False Then PnlWeightStat.Enabled = False
                End While
            End If
            .Close()
        End With
        Dim tmp_cl As String = CboClient.Text
        If RdoCust.Checked = True Then
            MOD_DATABASEPROC.ThrowArrayToControl(CboClient, CustList)
        Else
            MOD_DATABASEPROC.ThrowArrayToControl(CboClient, SupList)
        End If
        CboClient.Text = tmp_cl
    End Sub
#End Region

#Region "VALIDATION PROCEDURE"

    Private CustCode As String = ""
    Private SupCode As String = ""
    Private CommCode As String = ""
    Private Pricing As String = "0.00"
    Private UnitPerPrice As String = SysSettings.UnitPrice

    Private Mc As String = 0.0
    Private Function Validation() As Boolean
        Dim SysSettings As New settings()
        SysSettings.Load()
        Dim Errortext As String = Nothing
        CustCode = ""
        SupCode = ""
        CommCode = ""
        Dim Validator As New CLS_CONTROLTOGGLES
        If Validator.ValidChars(Me) = False Then
            MessageBox.Show("Using of quote/s is invalid.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
            Exit Function
        End If



        Dim DataValue As String
        DataValue = Trim(TxtPlateNo.Text)
        If String.IsNullOrEmpty(DataValue) Then
            Errortext = Errortext & Environment.NewLine & "Plate Number is required."
        Else
            Select Case True
                Case WeighIn
                    If MOD_DATABASEPROC.ExistenceFound("Select * from Outbound_Tbl where PlateNo = '" & Trim(DataValue) & "' and DTOut is null and RefNo <> '" & TxtRefNo.Text & "'", Nothing, "Refno", Nothing) Then
                        If MOD_DATABASEPROC.ReturnedData <> TxtRefNo.Text Then
                            Errortext = Errortext & Environment.NewLine & "* Plate number already registered for inbound weighing."
                        End If
                    End If
                Case Weighout
                    'If MOD_DATABASEPROC.ExistenceFound("Select * from OUTBOUND_Tbl where PlateNo = '" & Trim(DataValue) & "' and DTOut is null and RefNo <> '" & RefNO_Tmp & "'", Nothing, Nothing, Nothing) Then
                    '    Errortext = Errortext & Environment.NewLine & "* Plate number already registered for inbound weighing."
                    'End If
            End Select
        End If

        DataValue = Trim(CboClient.Text)
        If String.IsNullOrEmpty(DataValue) Then
            Errortext = Errortext & Environment.NewLine & "* Client Name is required."
        Else
            Select Case True
                Case RdoCust.Checked
                    SupCode = ""
                    If MOD_DATABASEPROC.ExistenceFound("Select CustCode from Cust_Tbl where CustName = '" & Trim(DataValue) & "'", Nothing, "CustCode", Nothing) = False Then
                        Errortext = Errortext & Environment.NewLine & "* Client not found in the database."
                    Else
                        CustCode = ReturnedData
                    End If
                Case RdoSup.Checked
                    CustCode = ""
                    If MOD_DATABASEPROC.ExistenceFound("Select SupCode from Sup_Tbl where SupName = '" & Trim(DataValue) & "'", Nothing, "SupCode", Nothing) = False Then
                        Errortext = Errortext & Environment.NewLine & "* Client not found in the database."
                    Else
                        SupCode = ReturnedData
                    End If
            End Select
        End If

        DataValue = Trim(CboCommodity.Text)
        If String.IsNullOrEmpty(DataValue) Then
            Errortext = Errortext & Environment.NewLine & "* Commodity is required."
        Else
            If MOD_DATABASEPROC.ExistenceFound("Select CommCode from Comm_Tbl where CommDesc = '" & Trim(DataValue) & "'", Nothing, "CommCOde", Nothing) = False Then
                Errortext = Errortext & Environment.NewLine & "* Commodity not found in the database."
            Else
                CommCode = ReturnedData
            End If
        End If


        If SysSettings.EnablePricing = True Then
            Pricing = _
    Replace(TxtPrice.Text, ",", "")
            If String.IsNullOrEmpty(Pricing) Then Pricing = 0.0
            If IsNumeric(Pricing) = False Then
                Errortext = Errortext & Environment.NewLine & "* Price should be numeric."
            End If
        Else
            Pricing = 0
        End If


        If SysSettings.WeighingType = "S" Then
            If SysSettings.EnableDeduction = True Then
                Mc = _
        Replace(TxtDeduct.Text, ",", "")
                If String.IsNullOrEmpty(Mc) Then Mc = 0.0
                If IsNumeric(Mc) = False Then
                    Errortext = Errortext & Environment.NewLine & "* Moisture Deduction should be numeric."
                Else
                    If Mc <> 0 Then
                        If String.IsNullOrEmpty(TxtReasons.Text) Then
                            '  Errortext = Errortext & Environment.NewLine & "* Reason for deduction is required."
                        End If
                    End If
                End If

            Else
                Mc = 0
            End If
        Else
            If Weighout = True Then
                If SysSettings.EnableDeduction = True Then
                    Mc = _
            Replace(TxtDeduct.Text, ",", "")
                    If String.IsNullOrEmpty(Mc) Then Mc = 0.0
                    If IsNumeric(Mc) = False Then
                        Errortext = Errortext & Environment.NewLine & "* Moisture Deduction should be numeric."
                    Else
                        If Mc <> 0 Then
                            If String.IsNullOrEmpty(TxtReasons.Text) Then
                                '   Errortext = Errortext & Environment.NewLine & "* Reason for deduction is required."
                            End If
                        End If
                    End If
                Else
                    Mc = 0
                End If
            End If

        End If
        If IsNothing(Errortext) = False Then
            MessageBox.Show(Errortext, "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
            Exit Function
        Else
            Return True
        End If
    End Function


#End Region

#Region "SAVING DATA PROCEDURE"
    Private INBOUND_REFNO As String
    Private Sub SaveInboundData()
        Try
            Dim SysSettings As New settings()
            SysSettings.Load()
            If Btnsave.Enabled = False Then Exit Sub
            Dim Saver
            If SysSettings.ConnectionType = "OLEDB" Then
                Saver = New CLS_OLE_DB
                Saver.CONNECTION = OLEDBCONX
            Else
                Saver = New CLS_SQL_DB
                Saver.CONNECTION = SQLCONX
            End If

            Dim Src As String = "INSERT INTO OUTBOUND_Tbl " & _
    "([RefNo],[DTIn],[PlateNo],[CustomerCode],[SupplierCode]" & _
    ",[CommodityCode],[DRNo],[TicketNo]" & _
    ",[Gross_Wt],[Remarks],[WeigherIn],[DriverName])" & _
     "VALUES " & _
    "('" & INBOUND_REFNO & "','" & Now & "','" & TxtPlateNo.Text.Trim & "','" & CustCode & "','" & SupCode & "'" & _
    ",'" & CommCode & "','" & TxtDrNo.Text.Trim & "','" & TxtTicketNo.Text.Trim & "'" & _
    ",'" & TxtGross.Text & "','" & TxtRemarks.Text.Trim & "','" & FrmLogin.UserId & "','" & Trim(TxtDriver.Text) & "')"
            Saver.source = Src
            Saver.executecommand()

            Saver.Table = "RefNo"
            Saver.FieldName = "Outbound_Id"
            Saver.Text = INBOUND_REFNO
            Saver.UpdateId()

            SaveDriverName()
            MessageBox.Show("Inbound Weighing Complete.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'UpdateList()

        Btncancel_Click(Nothing, Nothing)
    End Sub

    Private Sub SaveOutboundData()
        Try
            Dim SysSettings As New settings()
            SysSettings.Load()
            Dim Saver
            If SysSettings.ConnectionType = "OLEDB" Then
                Saver = New CLS_OLE_DB
                Saver.CONNECTION = OLEDBCONX
            Else
                Saver = New CLS_SQL_DB
                Saver.CONNECTION = SQLCONX
            End If

            Dim FOROUTBOUNDONLY As String = ""

            Dim FinalNet As Double = 0.0


            If Weighout = True Then
                If SysSettings.EnableDeduction = True Then FinalNet = TxtFINAL.Text
                If SysSettings.EnableDeduction = False Then FinalNet = TxtNet.Text
                FOROUTBOUNDONLY =
                ",[Pricing] = '" & Pricing & "'" & _
",[UnitPerPrice] = = '" & UnitPerPrice & "'" & _
",[MC] = '" & Mc & "'" & _
",[Final_Wt] = '" & FinalNet & "'"
            End If

            Dim Src As String
            Src = "UPDATE Outbound_Tbl SET" & _
"[PlateNo] = '" & TxtPlateNo.Text.Trim & "'" & _
",[CustomerCode] = '" & CustCode & "'" & _
",[SupplierCode] = '" & SupCode & "'" & _
",[CommodityCode] = '" & CommCode & "'" & FOROUTBOUNDONLY & _
",[DRNo] = '" & TxtDrNo.Text.Trim & "'" & _
",[TicketNo] = '" & TxtTicketNo.Text.Trim & "'" & _
",[Remarks] = '" & TxtRemarks.Text.Trim & "'" & _
",[DriverName] = '" & Trim(TxtDriver.Text) & "'" & _
",[ModBy] = '" & FrmLogin.UserId & "'" & _
",[ModDT] = '" & Now & "'" & _
 " where RefNo = '" & RefNO_Tmp & "'"
            Saver.source = Src
            Saver.executecommand()

            SaveDriverName()

            MessageBox.Show("Editing Complete. ", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Btncancel_Click(Nothing, Nothing)

    End Sub

    Private Sub SaveDriverName()
        Try
            Dim SysSettings As New settings()
            SysSettings.Load()
            Dim Saver
            If SysSettings.ConnectionType = "OLEDB" Then
                Saver = New CLS_OLE_DB
                Saver.CONNECTION = OLEDBCONX
            Else
                Saver = New CLS_SQL_DB
                Saver.CONNECTION = SQLCONX
            End If
            If MOD_DATABASEPROC.ExistenceFound("Select * from DRV_TBl where DriverName = '" & Trim(TxtDriver.Text) & "'", Nothing, "DriverId", Nothing) Then
                Dim Src As String
                Src = "UPDate Drv_tbl set DriverName= '" & Trim(TxtDriver.Text) & "' where DriverName = '" & TxtDriver.Text & "'"
                Saver.source = Src
                Saver.executecommand()
            Else
                Dim Src As String
                Src = "INSERT INTO Drv_tbl (DriverName) values ('" & Trim(TxtDriver.Text) & "')"
                Saver.source = Src
                Saver.executecommand()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "An error encountered while saving driver data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region


    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        If BtnEdit.Enabled = False Then Exit Sub
        If FrmLogin.WeighingModule = "RO" Then
            MessageBox.Show("Access denied. You are not allowed to edit or delete this record.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        EnableData()
    End Sub

    Private Sub Btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Btnsave.Enabled = False Then Exit Sub
        Try
            If Validation() = False Then Exit Sub

            If MessageBox.Show("Are entries correct?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub

            'Select Case True
            '    Case WeighIn
            '        SaveInboundData()
            '    Case Weighout
            SaveOutboundData()
            'End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Btncancel.Enabled = False Then Exit Sub
        DisableData()
        Viewdata()
    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If BtnPrint.Enabled = False Then Exit Sub
        Dim SysSettings As New settings()
        SysSettings.Load()
        If MessageBox.Show("Continue re-printing of ticket?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then Exit Sub

        Select Case WeighIn
            Case True
                If SysSettings.PrintAll = False Then _
                MOD_REPORTING.PrintToPrinter(Application.StartupPath & "\Reports\" & "TcktIn.rpt", "{OutBound_tbl.Refno} = '" & TxtRefNo.Text & "'", Nothing)
            Case False
                MOD_REPORTING.PrintToPrinter(Application.StartupPath & "\Reports\" & "TcktInOutAll.rpt", "{OutBound_tbl.Refno} = '" & TxtRefNo.Text & "'", Nothing, TxtRefNo.Text)
        End Select


    End Sub



    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim SysSettings As New settings()
            SysSettings.Load()
            If BtnDelete.Enabled = False Then Exit Sub
            If FrmLogin.WeighingModule = "RO" Then
                MessageBox.Show("Access denied. You are not allowed to edit or delete this record.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            If MessageBox.Show("Are you sure you want to delete selected record\s?", "", MessageBoxButtons.YesNo, _
                               MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Dim Remover
                ' Remover()
                If SysSettings.ConnectionType = "OLEDB" Then
                    Remover = New CLS_OLE_DB
                    Remover.connection = OLEDBCONX
                Else
                    Remover = New CLS_SQL_DB
                    Remover.connection = SQLCONX
                End If
                Remover.Table = "Outbound_Tbl"
                Remover.FieldName = "RefNo"
                Remover.Text = TxtRefNo.Text
                Remover.Source = "Delete From " & Remover.Table & " where RefNo = '" & Remover.Text & "'"
                Remover.ExecuteCommand()

                MessageBox.Show("Deleting Complete...", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FrmManagement.Dg.Rows.Remove(FrmManagement.Dg.CurrentRow)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "An error occured while deleting data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub






    Private Sub SearchClient()
        Dim cls
        Dim SysSettings As New settings()
        SysSettings.Load()
        If SysSettings.ConnectionType = "OLEDB" Then
            cls = New CLS_OLE_DB
            cls.connection = OLEDBCONX
        Else
            cls = New CLS_SQL_DB
            cls.connection = SQLCONX
        End If

        With cls
            Select Case True
                Case RdoCust.Checked
                    .source = "Select * From Cust_Tbl where CUSTNAME = '" & Trim(CboClient.Text) & "'"
                Case RdoSup.Checked
                    .source = "Select * From Sup_Tbl where SUPNAME = '" & Trim(CboClient.Text) & "'"
            End Select
            .opensource()
        End With

        If cls.DATAREADER.HasRows Then
            cls.DATAREADER.Read()
            With cls.DATAREADER
                Select Case True
                    Case RdoCust.Checked
                        If IsDBNull(.Item("CUSTADDR")) Then TxtAddress.Text = "" Else TxtAddress.Text = .Item("CUSTADDR")
                    Case RdoSup.Checked
                        If IsDBNull(.Item("SUPADDR")) Then TxtAddress.Text = "" Else TxtAddress.Text = .Item("SUPADDR")
                End Select
                .Close()
            End With
        End If

    End Sub

    Private Sub SearchCOmmodity()
        Dim SysSettings As New settings()
        SysSettings.Load()
        Dim cls
        If SysSettings.ConnectionType = "OLEDB" Then
            cls = New CLS_OLE_DB
            cls.connection = OLEDBCONX
        Else
            cls = New CLS_SQL_DB
            cls.connection = SQLCONX
        End If

        With cls
            .source = "Select * From  Comm_Tbl where CommdEsc = '" & Trim(CboCommodity.Text) & "'"
            .opensource()
        End With

        If cls.DATAREADER.HasRows Then
            cls.DATAREADER.Read()
            With cls.DATAREADER
                If IsDBNull(.Item("Pricing")) Then TxtPrice.Text = "" Else TxtPrice.Text = .Item("Pricing")
                .Close()
            End With
        End If

    End Sub

    Private Sub UPPERCASE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.KeyChar = Convert.ToChar(e.KeyChar.ToString.ToUpper)
    End Sub

    Private Sub RdoCust_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RdoCust.CheckedChanged
        CboClient.Items.Clear()
        CboClient.Text = ""
        Select Case RdoCust.Checked
            Case True
                MOD_DATABASEPROC.ThrowArrayToControl(CboClient, CustList)
            Case False
                MOD_DATABASEPROC.ThrowArrayToControl(CboClient, SupList)
        End Select
    End Sub



#Region "BUTTON TOGGLES"

    Private Sub ClearData()
        Dim CLS_TOGGLES As New CLS_CONTROLTOGGLES
        CLS_TOGGLES.ClearDataControls(Me)
    End Sub

    Private Sub EnableData()
        Dim cls_toggles As New CLS_CONTROLTOGGLES
        cls_toggles.EnableDataControls(Me)

        BtnEdit.Enabled = False
        BtnDelete.Enabled = False
        Btnsave.Enabled = True
        Btncancel.Enabled = True
        BtnPrint.Enabled = False
        BtnUpdatePrice.Enabled = False

    End Sub

    Private Sub DisableData()
        Dim SysSettings As New settings()
        SysSettings.Load()
        Dim cls_toggles As New CLS_CONTROLTOGGLES
        cls_toggles.DisableDataControls(Me)

        BtnEdit.Enabled = True
        BtnDelete.Enabled = True
        Btnsave.Enabled = False
        Btncancel.Enabled = False
        BtnPrint.Enabled = True
        If WeighIn = True Then
            BtnUpdatePrice.Enabled = False
        Else
            If SysSettings.EnablePricing = True Then
                BtnUpdatePrice.Enabled = True
            Else
                BtnUpdatePrice.Enabled = False
            End If
        End If

    End Sub

#End Region

    Private Sub TxtDeduct_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDeduct.LostFocus
        Dim TMP As String = (Replace(TxtDeduct.Text, ",", ""))
        If String.IsNullOrEmpty(TMP) = True Then TMP = "0.00"
        If IsNumeric(TMP) = False Then Exit Sub

        Dim DMC As Double = Replace(TMP, ",", "")
        TxtDeduct.Text = FormatNumber(DMC, 2, TriState.True, TriState.True, TriState.True)
    End Sub
    Private Sub TxtDeduct_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDeduct.TextChanged
        If StartDeduction = False Then Exit Sub
        If Weighout = False Then Exit Sub
        TxtFINAL.Text = DeductWeight(TxtDeduct.Text, TxtNet.Text _
                                     , _
                                     Unitweight)
    End Sub

    Private Function DeductWeight(ByVal Deduction As String, ByVal NetWeight As String, ByVal Unitweight As String) As String
        Dim SysSettings As New settings()
        SysSettings.Load()
        If String.IsNullOrEmpty(Deduction) Then Deduction = "0.00"
        Deduction = FormatNumber(Deduction, 2, TriState.False, TriState.False, TriState.False)
        NetWeight = FormatNumber(NetWeight, 2, TriState.False, TriState.False, TriState.False)
        Dim result As String = NetWeight
        Deduction = (Replace(Deduction, ",", ""))
        If String.IsNullOrEmpty(Deduction) = True Then Deduction = "0.00"
        If IsNumeric(Deduction) = False Then
            Return result
            Exit Function
        End If




        Select Case Unitweight
            Case "KG"
                Select Case SysSettings.DeductUnit
                    Case "KG"
                        result = NetWeight - Deduction
                    Case "%"
                        Deduction = CDbl(Deduction * 0.01)
                        result = NetWeight - (Deduction * NetWeight)
                End Select
                result = FormatNumber(result, 0, TriState.True, TriState.True, TriState.True)
            Case "TONS"
                Select Case SysSettings.DeductUnit
                    Case "KG"
                        result = NetWeight - (Deduction / 1000)
                    Case "%"
                        Deduction = CDbl(Deduction * 0.01)
                        result = NetWeight - (Deduction * NetWeight)
                End Select
                result = FormatNumber(result, 2, TriState.True, TriState.True, TriState.True)

                If CDbl(result) = 0 Then result = "0.00"
        End Select

        Return result
    End Function

    Private Sub BtnUpdatePrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdatePrice.Click
        If BtnUpdatePrice.Enabled = False Then Exit Sub

        If MOD_DATABASEPROC.ExistenceFound("Select * from outbound_tbl where RefNo = '" & TxtRefNo.Text & "'", Nothing, Nothing, Nothing) = False Then
            MessageBox.Show("Pricing Update failed. Transaction Record not existing or was already deleted by another user.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If MOD_DATABASEPROC.ExistenceFound("Select * from Comm_tbl where CommDesc = '" & Trim(CboCommodity.Text) & "'", Nothing, "Pricing", Nothing) Then
            If MessageBox.Show("Are you sure you want to edit pricing?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub
            Dim Saver As New CLS_OLE_DB
            With Saver
                .CONNECTION = OLEDBCONX
                .Source = "Update OutBound_Tbl set Pricing = '" & MOD_DATABASEPROC.ReturnedData & "' where Refno = '" & TxtRefNo.Text & "'"
                .ExecuteCommand()
                TxtPrice.Text = FormatNumber(MOD_DATABASEPROC.ReturnedData, 2, TriState.True, TriState.True, TriState.True)
            End With

            MessageBox.Show("Pricing Update Complete.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub Btnsave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsave.Click

    End Sub

    Private Sub BtnPrint_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click

    End Sub
End Class