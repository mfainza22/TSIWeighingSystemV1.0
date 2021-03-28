Imports WeightDev

Public Class FrmTrans


#Region "COMMON VARIABLES"
    Public WeighIn As Boolean = False
    Public Weighout As Boolean = False
    Private ONProcess As Boolean = False
    Private OnDevice As Boolean = True

#End Region
#Region "FORM EVENTS"
    Private SysSettings As New settings

    Private Sub FrmTrans_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MDIMAIN.Pnl_MainBtn.Visible = True
        Try
            TxtOnline.Stop()
            TxtOnline.Dispose()
            CLS_CLEARMEM.ClearMem(New Object() {TxtOnline})
        Catch ex As Exception
            ' TxtOnline.Stop_Tm()

        End Try

    End Sub

    Private EnablePricing As Boolean = SysSettings.EnablePricing
    Private UnitPerPrice As String = SysSettings.UnitPrice
    Private UnitWeight As String = SysSettings.UnitWeight
    Private DeductUnit As String = SysSettings.DeductUnit
    Private EnableDeduction As Boolean = SysSettings.EnableDeduction
    Private Sub GrabSettings()
        'TxtOnline.WeighingDevice = SysSettings.WeighingType

        UnitWeight = SysSettings.UnitWeight
        LblFinalNetUnit.Text = UnitWeight

        If EnablePricing = True Then
            LblPriceLabel.Visible = True
            TxtPrice.Visible = True
            LblPriceUnit.Visible = True
            LblPriceUnit.Visible = False
            UnitPerPrice = SysSettings.UnitPrice
            LblPriceUnit.Text = "Php/" & UnitPerPrice
        Else
            LblPriceLabel.Visible = False
            TxtPrice.Visible = False
            LblPriceUnit.Visible = False
            UnitPerPrice = SysSettings.UnitPrice
            LblPriceUnit.Text = "Php/" & UnitPerPrice
        End If

        If EnableDeduction = True Then
            PnlWeightStat.Enabled = True
            LblFinalNetUnit.Text = UnitWeight
            LblDedUnit.Text = "(" & DeductUnit & ")"
        Else
            PnlWeightStat.Enabled = False
        End If

    End Sub

    Private Sub SetPort(ByRef Txt As WeightDev.WeightIndicator)
        Try
            Txt.CommPortName = SysSettings.comm_port
            Txt.CommBaudRate = SysSettings.baud_rate
            Txt.CommParity = SysSettings.parity
            Txt.CommDataBits = SysSettings.data_bits
            Txt.CommStopBits = SysSettings.stop_bits
            Txt.DiscardOutBuffer = True
            Txt.ReadingInterval = 100
            Txt.CommReadTimeout = 3000
            Txt.WeighingDevice = SysSettings.device
            Txt.IPAddress = SysSettings.IPAddress
            Txt.IPPort = SysSettings.IPPort
            Txt.IPReadTimeOut = 3000
            Txt.ConnectionType = SysSettings.DeviceConnectionType.ToString()
            Txt.WeighingDevice = SysSettings.device
            Txt.Start()
            LblError.Visible = False
        Catch ex As Exception
            TxtOnline.BackColor = Color.Red
            LblError.Text = "       " & ex.Message
            LblError.Visible = True
        End Try
    End Sub
    'Private Sub SetupDBGRID(ByVal src As String)
    '    Dim Rd As New CLS_OLE_DB
    '    Rd.CONNECTION = OLEDBCONX
    '    Rd.Source = src
    '    Rd.OpenSource()
    '    If Rd.DATAREADER.HasRows Then
    '        For i = 0 To Rd.DATAREADER.FieldCount - 1
    '            Dim Col As New DataGridViewTextBoxColumn
    '            Col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    '            Col.Name = Rd.DATAREADER.GetName(i)
    '            DGDB.Columns.Add(Col)
    '        Next

    '        While Rd.DATAREADER.Read
    '            Dim rw(Rd.DATAREADER.FieldCount - 1) As String
    '            For i = 0 To rw.Count - 1
    '                rw(i) = Rd.DATAREADER.Item(i)
    '            Next
    '            DGDB.Rows.Add(rw)
    '        End While
    '        Rd.DATAREADER.Close()
    '    End If
    'End Sub

    Private Sub FrmProducts_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Alt Or e.Control Or e.Shift = False Then
            If e.KeyCode = Keys.Enter Then
                If TypeOf Me.ActiveControl Is MykeCtrlEx.PushButton Then Exit Sub
                SelectNextControl(Me.ActiveControl, True, True, True, True)
            End If
        End If

        If e.Shift = True Then
            Select Case e.KeyCode
                Case Keys.F1
                    If OnDevice = True Then Exit Sub
                    OnDevice = True
                    Change_WeightSource()
                    If WeighIn = True Then
                        TxtGross.Text = TxtOnline.Text
                    End If

                Case Keys.F2
                    If OnDevice = False Then Exit Sub
                    Select Case FrmLogin.ManualWeighing
                        Case "RO"
                            OnDevice = False
                            Change_WeightSource()
                            TxtOffline_TextChanged(sender, e)
                        Case "RW"
                            OnDevice = False
                            Change_WeightSource()
                            TxtOffline_TextChanged(sender, e)
                        Case "N/A"
                        Case Nothing
                    End Select
            End Select
        End If


        If e.Alt Or e.Shift = True Then Exit Sub
        If e.Control = True Then

            Select Case e.KeyCode
                Case Keys.S
                    Btnsave_Click(sender, e)
            End Select
        Else
            Select Case e.KeyCode
                Case Keys.F1
                    BtnIn_Click(sender, e)
                Case Keys.F2
                    BtnOUt_Click(sender, e)
                Case Keys.F3
                    Btnsave_Click(sender, e)
                Case Keys.Delete
                    BtnDelete_Click(sender, e)
                Case Keys.Escape
                    Btncancel_Click(sender, e)
            End Select
        End If
    End Sub


    Private Sub Change_WeightSource()
        If OnDevice = True Then
            ' Pnl_indicator.Visible = True
            TxtOffline.Visible = False
            TxtOnline.Visible = True
            DTPicker.Visible = False
            TxtOnline_TextChanged(Nothing, Nothing)
        Else
            'Pnl_indicator.Visible = False
            TxtOffline.Visible = True
            TxtOnline.Visible = False
            DTPicker.Visible = True
            TxtOffline_TextChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub FrmTrans_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave

    End Sub

    Private Sub FrmTrans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SysSettings = New settings
        SysSettings.Load()
        EnablePricing = SysSettings.EnablePricing
        EnablePricing = SysSettings.EnablePricing
        UnitPerPrice = SysSettings.UnitPrice
        UnitWeight = SysSettings.UnitWeight
        DeductUnit = SysSettings.DeductUnit
        EnableDeduction = SysSettings.EnableDeduction

        GrabSettings()

        SetPort(TxtOnline)


        ' Dg.Columns(Col_Pricing.Index).HeaderText += "(" & UnitPerPrice & ")"
        Me.Left = 0
        Me.Top = 0
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height + (Screen.PrimaryScreen.WorkingArea.Height * 0.055)
        Me.Width = (Screen.PrimaryScreen.WorkingArea.Width)

        AddHandler Btnsave.Click, AddressOf Btnsave_Click
        AddHandler Btncancel.Click, AddressOf Btncancel_Click
        AddHandler BtnIn.Click, AddressOf BtnIn_Click
        AddHandler BtnOUt.Click, AddressOf BtnOUt_Click
        AddHandler BtnDelete.Click, AddressOf BtnDelete_Click
        AddHandler BtnPrintIN.Click, AddressOf BtnPrintIn_Click
        AddHandler BtnPrintOut.Click, AddressOf BtnPrintOut_Click
        AddHandler BtnExit.Click, AddressOf BtnExit_Click
        AddHandler BtnSetup.Click, AddressOf BtnSetup_Click
        AddHandler Dg.Click, AddressOf Dg_Click
        AddHandler Dg.DoubleClick, AddressOf Dg_DoubleClick
        AddHandler CboCommodity.KeyPress, AddressOf UPPERCASE_KeyPress
        AddHandler CboClient.KeyPress, AddressOf UPPERCASE_KeyPress

        SetData()
        MOD_DATABASEPROC.ThrowArrayToControl(CboClient, CustList)
        MOD_DATABASEPROC.ThrowArrayToControl(CboCommodity, CommList)
        MOD_DATABASEPROC.ThrowArrayToControl(TxtDriver, DRVList)

        ClearData()
        DisableData()

        LIstGrid()
        Dg_Click(sender, e)

    End Sub
#End Region


#Region "SETTINGS DATA VARIABLES"
    Public SupList As New List(Of String)
    Public CustList As New List(Of String)
    Public CommList As New List(Of String)
    Private DRVList As New List(Of String)
    Private Sub SetData()
        MOD_DATABASEPROC.ListDataToArray(CustList, Nothing, "Select CustName From Cust_Tbl where Cactive = true", "CustName", Nothing)
        MOD_DATABASEPROC.ListDataToArray(SupList, Nothing, "Select SupName From Sup_Tbl where SActive = true", "SupName", Nothing)
        MOD_DATABASEPROC.ListDataToArray(CommList, Nothing, "Select CommDesc from Comm_tbl where active = true", "CommDesc", Nothing)
        MOD_DATABASEPROC.ListDataToArray(DRVList, Nothing, "Select DriverName from Drv_tbl", "DriverName", Nothing)
    End Sub
#End Region

    Private Sub LIstGrid()
        If Dg.Enabled = False Then Exit Sub
        Dg.Rows.Clear()
        Dim Src As String =
            "SELECT " &
            "(SELECT CUSTNAME FROM CUST_TBL WHERE CUSTCODE = CustomerCode)" &
",(SELECT SUPNAME FROM SUP_TBL WHERE SUPCODE =SupplierCode)" &
",(SELECT COMMDESC FROM COMM_TBL WHERE COMMCODE = CommodityCode)" &
",(SELECT USER_DISPLAYNAME FROM USERACCOUNTS WHERE User_id = WeigherIn),* FROM OUTBOUND_TBL where DTOUT is null"
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
                Dim Rw As DataGridViewRow
                While .Read
                    Dg.Rows.Add(.Item("RefNo"))
                    Dg.Rows(Dg.Rows.Count - 1).Selected = True
                    Dg.FirstDisplayedScrollingRowIndex = Dg.Rows.Count - 1
                    Dg.CurrentCell = Dg.Rows.Item(Dg.Rows.Count - 1).Cells(0)
                    Rw = Dg.CurrentRow

                    If IsDBNull(.Item("DTIn")) Then Rw.Cells(Col_DateTime.Name).Value = "" Else Rw.Cells(Col_DateTime.Name).Value = Format(.Item("DTIn"), "MM-dd-yyyy hh:mm tt")
                    If IsDBNull(.Item("PlateNo")) Then Rw.Cells(Col_PlateNo.Name).Value = "" Else Rw.Cells(Col_PlateNo.Name).Value = Trim(.Item("PlateNo").ToString)
                    If IsDBNull(.Item("Inbound_Wt")) Then Rw.Cells(Col_InboundWt.Name).Value = "" Else Rw.Cells(Col_InboundWt.Name).Value = .item("Inbound_Wt")

                    Select Case UnitWeight
                        Case "KG"
                            Rw.Cells(Col_InboundWt.Name).Value = FormatNumber(Rw.Cells(Col_InboundWt.Name).Value, 0, TriState.True, TriState.True, TriState.True)
                        Case "TONS"
                            Rw.Cells(Col_InboundWt.Name).Value = FormatNumber(Rw.Cells(Col_InboundWt.Name).Value, 2, TriState.True, TriState.True, TriState.True)
                    End Select

                    Select Case True
                        Case IsDBNull(.item(0))
                            Rw.Cells(Col_Client.Name).Value = .item(1)
                        Case IsDBNull(.item(1))
                            Rw.Cells(Col_Client.Name).Value = .item(0)
                        Case Else
                            Rw.Cells(Col_Client.Name).Value = ""
                    End Select
                    If IsDBNull(.Item(2)) Then Rw.Cells(Col_Comm.Name).Value = "" Else Rw.Cells(Col_Comm.Name).Value = .item(2)
                    If IsDBNull(.Item("pricing")) Then Rw.Cells(Col_Pricing.Name).Value = "" Else _
           Rw.Cells(Col_Pricing.Name).Value = FormatNumber(Trim(.Item("Pricing")), 2, TriState.True, TriState.True, TriState.True) _
           & "/" & .item("UnitPerPrice")
                    If IsDBNull(.Item("DrNO")) Then Rw.Cells(Col_Dr.Name).Value = "" Else Rw.Cells(Col_Dr.Name).Value = .item("DRNO")
                    If IsDBNull(.Item("TicketNo")) Then Rw.Cells(Col_TktNO.Name).Value = "" Else Rw.Cells(Col_TktNO.Name).Value = .item("TicketNo")
                    If IsDBNull(.Item("DriverName")) Then Rw.Cells(Col_Driver.Name).Value = "" Else Rw.Cells(Col_Driver.Name).Value = .item("DriverName")
                    If IsDBNull(.Item("remarks")) Then Rw.Cells(Col_remarks.Name).Value = "" Else Rw.Cells(Col_remarks.Name).Value = .item("remarks")
                    If IsDBNull(.Item(3)) Then Rw.Cells(Col_Weigher.Name).Value = False Else Rw.Cells(Col_Weigher.Name).Value = .Item(3).ToString
                    TxtSearch.AutoCompleteCustomSource.Add(Rw.Cells(Col_PlateNo.Name).Value)
                End While
            End If
            .Close()
        End With

        LblRecord.Text = Dg.Rows.Count
    End Sub

#Region "DATA VIEWEING PROCEDURE"


    Private PLATENO_Tmp As String = ""
    Private INBOUNDWT_Tmp As Double = 0
    Private DTIN_Tmp As String = ""
    Private WEIGHERIN_Tmp As String = ""
    Public RefNO_Tmp As String = ""
    Private Sub Viewdata()

        If ONProcess = True Then Exit Sub
        ClearData()
        If Dg.Rows.Count = 0 Then Exit Sub
        Dim Src As String =
            "SELECT " &
            "(SELECT CUSTNAME FROM CUST_TBL WHERE CUSTCODE = CustomerCode)" &
              ",(SELECT CUSTAddr FROM CUST_TBL WHERE CUSTCODE = CustomerCode)" &
",(SELECT SUPNAME FROM SUP_TBL WHERE SUPCODE =SupplierCode)" &
",(SELECT SupAddr FROM SUP_TBL WHERE SUPCODE =SupplierCode)" &
",(SELECT COMMDESC FROM COMM_TBL WHERE COMMCODE = CommodityCode)" &
",(SELECT PRICING FROM COMM_TBL WHERE COMMCODE = CommodityCode)" &
",(SELECT USER_DISPLAYNAME FROM USERACCOUNTS WHERE User_id = WeigherIn),* FROM OUTBOUND_TBL where RefNo = '" & Dg.CurrentRow.Cells(0).Value & "'"
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
                    If IsDBNull(.Item("DTIn")) Then DTIN_Tmp = "" Else DTIN_Tmp = Format(.Item("DTIn"), "MM-dd-yyyy hh:mm tt")
                    If IsDBNull(.Item("PlateNo")) Then TxtPlateNo.Text = "" Else TxtPlateNo.Text = Trim(.Item("PlateNo").ToString)
                    If IsDBNull(.Item("Inbound_Wt")) Then INBOUNDWT_Tmp = 0 Else INBOUNDWT_Tmp = .item("Inbound_Wt")

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


                    If IsDBNull(.Item("DedReason")) Then TxtReasons.Text = "" Else TxtReasons.Text = .item("DedReason")
                    If IsDBNull(.Item(5)) Then TxtPrice.Text = "0.00" Else _
                 TxtPrice.Text = FormatNumber(.Item("pricing"), 2, TriState.True, TriState.True, TriState.True)
                    If String.IsNullOrEmpty(.item("pricing")) Then
                        TxtPrice.Text = ("0.00")
                    Else
                        FormatNumber(TxtPrice.Text = .item(5), 2, TriState.False, TriState.False, TriState.False)
                    End If
                    If IsDBNull(.Item(4)) Then CboCommodity.Text = "" Else CboCommodity.Text = .item(4)

                    If IsDBNull(.Item("MC")) Then TxtDeduct.Text = "0.00" Else
                    If String.IsNullOrEmpty(.item("MC").ToString) Then
                        TxtDeduct.Text = ("0.00")
                    Else
                        TxtDeduct.Text = (FormatNumber(.item("MC"), 2, TriState.False, TriState.False, TriState.False))
                    End If


                    If IsDBNull(.Item("DrNO")) Then TxtDrNo.Text = "" Else TxtDrNo.Text = .item("DRNO")
                    If IsDBNull(.Item("TicketNo")) Then TxtTicketNo.Text = "" Else TxtTicketNo.Text = .item("TicketNo")
                    If IsDBNull(.Item("DriverName")) Then TxtDriver.Text = "" Else TxtDriver.Text = .item("DriverName")
                    If IsDBNull(.Item("remarks")) Then TxtRemarks.Text = "" Else TxtRemarks.Text = .item("remarks")
                    If IsDBNull(.item("WeigherIn")) Then WEIGHERIN_Tmp = "" Else WEIGHERIN_Tmp = .item("WeigherIn")
                    '    If IsDBNull(.Item(6)) Then Rw.Cells(Col_Weigher.Name).Value = False Else Rw.Cells(Col_Weigher.Name).Value = .Item(6).ToString
                End While
            End If
            .Close()
        End With
    End Sub

#End Region
#Region "VALIDATION PROCEDURE"

    Private CustCode As String = ""
    Private SupCode As String = ""
    Private CommCode As String = ""
    Private Pricing As String = "0.00"
    Private DT As DateTime = DateTime.Now

    Private Mc As String = 0.0

    Private Function Validation() As Boolean
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

        Select Case OnDevice
            Case True
                If IsNumeric(TxtOnline.Text) = False Then
                    MessageBox.Show("Invalid Weight from device....", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Return False
                    Exit Function
                End If

                If Val(TxtOnline.Text) <= 0 Then
                    MessageBox.Show("Invalid Weight from device....", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Return False
                    Exit Function
                End If
            Case False
                If IsNumeric(TxtOffline.Text) = False Then
                    MessageBox.Show("Invalid Weight from device....", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Return False
                    Exit Function
                End If

                If Val(TxtOffline.Text) <= 0 Then
                    MessageBox.Show("Invalid Weight....", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Return False
                    Exit Function
                End If
        End Select


        If Weighout = True Then
            If Val(TxtNet.Text) <= 0 Then
                MessageBox.Show("Invalid Net Weight....", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Return False
                Exit Function
            End If
        End If


        Dim DataValue As String
        DataValue = Trim(TxtPlateNo.Text)
        If String.IsNullOrEmpty(DataValue) Then
            Errortext = Errortext & Environment.NewLine & "* Plate Number is required."
        Else
            Select Case True
                Case WeighIn
                    If MOD_DATABASEPROC.ExistenceFound("Select * from Outbound_Tbl where PlateNo = '" & Trim(DataValue) & "' and DTOut is null", Nothing, Nothing, Nothing) Then
                        Errortext = Errortext & Environment.NewLine & "* Plate number already registered for inbound weighing."
                    End If
                Case Weighout
                    If MOD_DATABASEPROC.ExistenceFound("Select * from OUTBOUND_Tbl where PlateNo = '" & Trim(DataValue) & "' and DTOut is null and RefNo <> '" & RefNO_Tmp & "'", Nothing, Nothing, Nothing) Then
                        Errortext = Errortext & Environment.NewLine & "* Plate number already registered for inbound weighing."
                    End If
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
                '  MOD_DATABASEPROC.ExistenceFound("Select pricing from Comm_Tbl where CommDesc = '" & Trim(DataValue) & "'", Nothing, "pricing", Nothing)
                '  Pricing = ReturnedData
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
                            Errortext = Errortext & Environment.NewLine & "* Reason for deduction is required."
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
                                'Errortext = Errortext & Environment.NewLine & "* Reason for deduction is required."
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
    Private Sub SaveSingleWeighingData()
        Try
            If Btnsave.Enabled = False Then Exit Sub

            Dim FinalNet As Double = 0.0
            If EnableDeduction = True Then FinalNet = TxtFINAL.Text
            If EnableDeduction = False Then FinalNet = TxtNet.Text

            Dim Saver
            If SysSettings.ConnectionType = "OLEDB" Then
                Saver = New CLS_OLE_DB
                Saver.CONNECTION = OLEDBCONX
            Else
                Saver = New CLS_SQL_DB
                Saver.CONNECTION = SQLCONX
            End If
            Saver.Table = "RefNo"
            Saver.FieldName = "Outbound_Id"
            INBOUND_REFNO = Saver.GeneratedId


            Dim DT As String = Now

            Dim Src As String = "INSERT INTO OUTBOUND_Tbl " &
    "([RefNo],[DTIn],[DTOut],[PlateNo],[CustomerCode],[SupplierCode]" &
    ",[CommodityCode],[Pricing],[UnitPerPrice],[DRNo],[TicketNo]" &
    ",[UnitWeight],[Gross_Wt],[Gross_DT],[Tare_Wt],[Tare_Dt],[Net_Wt],[Final_wt]" &
    ",[Inbound_Wt],[MC],[DedReason],[Remarks],[WeigherIn],[WeigherOut],[DriverName])" &
     "VALUES " &
    "('" & INBOUND_REFNO & "','" & DT & "','" & DT & "','" & TxtPlateNo.Text.Trim & "','" & CustCode & "','" & SupCode & "'" &
    ",'" & CommCode & "','" & Pricing & "','" & UnitPerPrice & "','" & TxtDrNo.Text.Trim & "','" & TxtTicketNo.Text.Trim & "'" &
",'" & UnitWeight & "','" & TxtGross.Text & "','" & DT & "','" & TxtTare.Text & "','" & DT & "','" & TxtNet.Text & "','" & TxtFINAL.Text & "'" &
 ",'" & TxtGross.Text & "','" & Mc & "','" & Trim(TxtReasons.Text) & "','" & TxtRemarks.Text.Trim & "','" & FrmLogin.UserId & "','" & FrmLogin.UserId & "','" & (TxtDriver.Text) & "')"
            Saver.source = Src
            ' MessageBox.Show(Src)
            Saver.executecommand()

            Saver.Table = "RefNo"
            Saver.FieldName = "Outbound_Id"
            Saver.Text = INBOUND_REFNO
            Saver.UpdateId()

            SaveDriverName()

            LastOutRefNo = INBOUND_REFNO
            '  If My.Settings.EnablePrintIn = True Then _
            'MOD_REPORTING.PrintToPrinter(Application.StartupPath & "\Reports\" & "TcktIn.rpt", "{OutBound_tbl.Refno} = '" & INBOUND_REFNO & "'", Nothing)

            MOD_REPORTING.PrintToPrinter(Application.StartupPath & "\Reports\" & "Tcktinoutall.rpt", "{OutBound_tbl.Refno} = '" & INBOUND_REFNO & "'", Nothing)


            Dim frm As New FrmTransOK
            frm.MsgSTr = " Weighing Complete..." & vbNewLine & _
         "Press Close to exit window."
            frm.ShowDialog()

            MessageBox.Show("Weighing Complete.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'UpdateList()
        'Dim Gd As New CLS_DATAGRID
        'Gd.SearchGrid(Dg, TxtPlateNo.Text, 2)

        Btncancel_Click(Nothing, Nothing)
    End Sub

    Private INBOUND_REFNO As String
    Private Sub SaveInboundData()
        Try
            If Btnsave.Enabled = False Then Exit Sub
            Dim Saver
            If SysSettings.ConnectionType = "OLEDB" Then
                Saver = New CLS_OLE_DB
                Saver.CONNECTION = OLEDBCONX
            Else
                Saver = New CLS_SQL_DB
                Saver.CONNECTION = SQLCONX
            End If
            Saver.Table = "RefNo"
            Saver.FieldName = "Outbound_Id"
            INBOUND_REFNO = Saver.GeneratedId

            Dim Src As String = "INSERT INTO OUTBOUND_Tbl " &
    "([RefNo],[DTIn],[PlateNo],[CustomerCode],[SupplierCode]" &
    ",[pricing],[CommodityCode],[DRNo],[TicketNo]" &
    ",[Inbound_Wt],[MC],[Remarks],[WeigherIn],[DriverName])" &
     "VALUES " &
    "('" & INBOUND_REFNO & "','" & DT & "','" & TxtPlateNo.Text.Trim & "','" & CustCode & "','" & SupCode & "'" &
    ",'" & Pricing & "','" & CommCode & "','" & TxtDrNo.Text.Trim & "','" & TxtTicketNo.Text.Trim & "'" &
    ",'" & TxtGross.Text & "','" & Mc & "','" & TxtRemarks.Text.Trim & "','" & FrmLogin.UserId & "','" & Trim(TxtDriver.Text) & "')"
            Saver.source = Src

            Saver.executecommand()

            Saver.Table = "RefNo"
            Saver.FieldName = "Outbound_Id"
            Saver.Text = INBOUND_REFNO
            Saver.UpdateId()

            SaveDriverName()
            SaveTrucks()

            TxtRefNo.Text = INBOUND_REFNO
            LastOutRefNo = TxtRefNo.Text
            '  If My.Settings.EnablePrintIn = True Then _
            'MOD_REPORTING.PrintToPrinter(Application.StartupPath & "\Reports\" & "TcktIn.rpt", "{OutBound_tbl.Refno} = '" & INBOUND_REFNO & "'", Nothing)
            If SysSettings.EnablePrintOut = True Then
                Select Case SysSettings.PrintAll
                    Case True
                    Case False
                        Threading.Thread.Sleep(100)
                        MOD_REPORTING.PrintToPrinter(Application.StartupPath & "\Reports\" & "TcktIN.rpt", "{OutBound_tbl.Refno} = '" & INBOUND_REFNO & "'", Nothing, INBOUND_REFNO)
                End Select
            End If

            Dim frm As New FrmTransOK
            frm.ReceiptNo = LastOutRefNo
            frm.MsgSTr = "Inbound Weighing Complete..." & vbNewLine & _
         "Press Close to exit window."
            frm.ShowDialog(MDIMAIN)
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try

        UpdateList()
        Dim Gd As New CLS_DATAGRID
        Gd.SearchGrid(Dg, TxtPlateNo.Text, 2)

        LblRecord.Text = Dg.Rows.Count
        Btncancel_Click(Nothing, Nothing)
    End Sub

    Public LastOutRefNo As String = Nothing
    Private Sub SaveOutboundData()
        Try
            Dim DTOUT As DateTime = DT
            Dim GR_Time As String = ""
            Dim TR_Time As String = ""
            Dim WT_TMP As Integer
            If OnDevice = True Then WT_TMP = TxtOnline.Text
            If OnDevice = False Then WT_TMP = TxtOffline.Text
            If INBOUNDWT_Tmp <= WT_TMP Then
                GR_Time = DTOUT
                TR_Time = DTIN_Tmp
            Else
                GR_Time = DTIN_Tmp
                TR_Time = DTOUT
            End If

            Dim Saver
            If SysSettings.ConnectionType = "OLEDB" Then
                Saver = New CLS_OLE_DB
                Saver.CONNECTION = OLEDBCONX
            Else
                Saver = New CLS_SQL_DB
                Saver.CONNECTION = SQLCONX
            End If
            'Saver.Table = "RefNo"
            'Saver.FieldName = "Outbound_Id"
            'Dim refno As String = Saver.GeneratedId

            Dim FinalNet As Double = 0.0
            If EnableDeduction = True Then FinalNet = TxtFINAL.Text
            If EnableDeduction = False Then FinalNet = TxtNet.Text


            Dim Src As String
            Src = "UPDATE Outbound_Tbl SET" & _
" [DTOut] = '" & DTOUT & "'" & _
",[PlateNo] = '" & TxtPlateNo.Text.Trim & "'" & _
",[CustomerCode] = '" & CustCode & "'" & _
",[SupplierCode] = '" & SupCode & "'" & _
",[CommodityCode] = '" & CommCode & "'" & _
",[Pricing] = '" & Pricing & "'" & _
",[UnitPerPrice] = = '" & UnitPerPrice & "'" & _
",[DRNo] = '" & TxtDrNo.Text.Trim & "'" & _
",[TicketNo] = '" & TxtTicketNo.Text.Trim & "'" & _
",[UnitWeight] = '" & UnitWeight & "'" & _
",[Gross_Wt]= '" & Val(TxtGross.Text) & "'" & _
",[Gross_DT] = '" & GR_Time & "'" & _
",[Tare_Wt]= '" & Val(TxtTare.Text) & "'" & _
",[Tare_Dt]= '" & TR_Time & "'" & _
",[Net_Wt] = '" & Val(TxtNet.Text) & "'" & _
",[Final_wt] = '" & FinalNet & "'" & _
",[MC] = '" & Mc & "'" & _
",[DedReason] = '" & Trim(TxtReasons.Text) & "'" & _
",[Remarks] = '" & TxtRemarks.Text.Trim & "'" & _
",[WeigherOut] = '" & FrmLogin.UserId & "'" & _
",[DriverName] = '" & Trim(TxtDriver.Text) & "'" & _
 " where RefNo = '" & RefNO_Tmp & "'"
            Saver.source = Src
            Saver.executecommand()

            'Saver.Table = "RefNo"
            'Saver.FieldName = "Outbound_Id"
            'Saver.Text = refno
            'Saver.UpdateId()

            'Saver.table = "Inbound_Tbl"
            'Saver.fieldname = "refno"
            'Saver.text = RefNO_Tmp
            'Saver.deleterecord()
            Dg.Rows.Remove(Dg.CurrentRow)

            SaveDriverName()

            Threading.Thread.Sleep(100)
            If SysSettings.EnablePrintOut = True Then
                Select Case SysSettings.PrintAll
                    Case True
                        MOD_REPORTING.PrintToPrinter(Application.StartupPath & "\Reports\" & "TcktInOutAll.rpt", "{OutBound_tbl.Refno} = '" & RefNO_Tmp & "'", Nothing, RefNO_Tmp)
                    Case False
                        MOD_REPORTING.PrintToPrinter(Application.StartupPath & "\Reports\" & "TcktOut.rpt", "{OutBound_tbl.Refno} = '" & RefNO_Tmp & "'", Nothing, RefNO_Tmp)
                End Select
            End If

            LastOutRefNo = TxtRefNo.Text




            RemoveHandler TxtOnline.TextChanged, AddressOf TxtOnline_TextChanged
            Dim frm As New FrmTransOK
            frm.MsgSTr = "Outbound Weighing Complete..." & vbNewLine & _
                "Press Close to exit window."
            frm.ReceiptNo = TxtRefNo.Text
            frm.ShowDialog(Me)
            AddHandler TxtOnline.TextChanged, AddressOf TxtOnline_TextChanged
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        LblRecord.Text = Dg.Rows.Count
        Btncancel_Click(Nothing, Nothing)

    End Sub
    Private lockWeighing As Boolean = False

    Private Sub SaveDriverName()
        Try
            Dim Saver
            If SysSettings.ConnectionType = "OLEDB" Then
                Saver = New CLS_OLE_DB
                Saver.CONNECTION = OLEDBCONX
            Else
                Saver = New CLS_SQL_DB
                Saver.CONNECTION = SQLCONX
            End If

            If (String.IsNullOrEmpty(TxtDriver.Text.Trim()) = False) Then
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
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "An error encountered while saving driver data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SaveTrucks()
        Try
            Dim Saver
            If SysSettings.ConnectionType = "OLEDB" Then
                Saver = New CLS_OLE_DB
                Saver.CONNECTION = OLEDBCONX
            Else
                Saver = New CLS_SQL_DB
                Saver.CONNECTION = SQLCONX
            End If
            If MOD_DATABASEPROC.ExistenceFound("Select * from Vehicle_Tbl where PlateNo = '" & Trim(TxtPlateNo.Text) & "'", Nothing, Nothing, Nothing) Then
                Dim Src As String
                Src = "UPDate Vehicle_Tbl set DriverName= '" & Trim(TxtDriver.Text) & "'" & _
                    ",CustCode = '" & CustCode & "'" & _
                ",SupCode = '" & SupCode & "'" & _
               " where PlateNo = '" & Trim(TxtPlateNo.Text) & "'"
                Saver.source = Src
                Saver.executecommand()
            Else
                Saver.Source = "Insert into Vehicle_Tbl (PlateNo,DriverName) values (" & _
                            "'" & Trim(TxtPlateNo.Text) & "'" & _
                                ",'" & Trim(TxtDriver.Text) & "')"
                Saver.executecommand()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "An error encountered while saving driver data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateList()
        Dim Src As String = _
          "SELECT " & _
          "(SELECT CUSTNAME FROM CUST_TBL WHERE CUSTCODE = CustomerCode)" & _
",(SELECT SUPNAME FROM SUP_TBL WHERE SUPCODE =SupplierCode)" & _
",(SELECT COMMDESC FROM COMM_TBL WHERE COMMCODE = CommodityCode)" & _
",(SELECT USER_DISPLAYNAME FROM USERACCOUNTS WHERE User_id = WeigherIn),* FROM OUTBOUND_TBL WHERE Refno = '" & INBOUND_REFNO & "'"
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
                Dim Rw As DataGridViewRow
                While .Read

                    Dg.Rows.Add(.Item("RefNo"))
                    Dg.Rows(Dg.Rows.Count - 1).Selected = True
                    Dg.FirstDisplayedScrollingRowIndex = Dg.Rows.Count - 1
                    Dg.CurrentCell = Dg.Rows.Item(Dg.Rows.Count - 1).Cells(0)
                    Rw = Dg.CurrentRow

                    If IsDBNull(.Item("DTIn")) Then Rw.Cells(Col_DateTime.Name).Value = "" Else Rw.Cells(Col_DateTime.Name).Value = Format(.Item("DTIn"), "MM-dd-yyyy hh:mm tt")
                    If IsDBNull(.Item("PlateNo")) Then Rw.Cells(Col_PlateNo.Name).Value = "" Else Rw.Cells(Col_PlateNo.Name).Value = Trim(.Item("PlateNo").ToString)
                    If IsDBNull(.Item("Inbound_Wt")) Then INBOUNDWT_Tmp = 0 Else INBOUNDWT_Tmp = .item("Inbound_Wt")
                    Rw.Cells(Col_InboundWt.Name).Value = INBOUNDWT_Tmp

                    Select Case UnitWeight
                        Case "KG"
                            Rw.Cells(Col_InboundWt.Name).Value = FormatNumber(Rw.Cells(Col_InboundWt.Name).Value, 0, TriState.True, TriState.True, TriState.True)
                        Case "TONS"
                            Rw.Cells(Col_InboundWt.Name).Value = FormatNumber(Rw.Cells(Col_InboundWt.Name).Value, 2, TriState.True, TriState.True, TriState.True)
                    End Select

                    Select Case True
                        Case IsDBNull(.item(0))
                            Rw.Cells(Col_Client.Name).Value = .item(1)
                        Case IsDBNull(.item(1))
                            Rw.Cells(Col_Client.Name).Value = .item(0)
                        Case Else
                            Rw.Cells(Col_Client.Name).Value = ""
                    End Select
                    If IsDBNull(.Item(2)) Then Rw.Cells(Col_Comm.Name).Value = "" Else Rw.Cells(Col_Comm.Name).Value = .item(2)
                    '         If IsDBNull(.Item("pricing")) Then Rw.Cells(Col_Pricing.Name).Value = "" Else _
                    'Rw.Cells(Col_Pricing.Name).Value = FormatNumber(Trim(.Item("Pricing")), 2, TriState.True, TriState.True, TriState.True) _
                    '& "/" & .item("UnitPerPrice")
                    If IsDBNull(.Item("DrNO")) Then Rw.Cells(Col_Dr.Name).Value = "" Else Rw.Cells(Col_Dr.Name).Value = .item("DRNO")
                    If IsDBNull(.Item("TicketNo")) Then Rw.Cells(Col_TktNO.Name).Value = "" Else Rw.Cells(Col_TktNO.Name).Value = .item("TicketNo")
                    If IsDBNull(.Item("remarks")) Then Rw.Cells(Col_remarks.Name).Value = "" Else Rw.Cells(Col_remarks.Name).Value = .item("remarks")
                    If IsDBNull(.Item(3)) Then Rw.Cells(Col_Weigher.Name).Value = False Else Rw.Cells(Col_Weigher.Name).Value = .Item(3).ToString
                    TxtSearch.AutoCompleteCustomSource.Add(Rw.Cells(Col_PlateNo.Name).Value)
                End While
            End If
            .Close()
        End With
    End Sub


    Private Sub BtnIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If BtnIn.Enabled = False Then Exit Sub
        WeighIn = True
        Weighout = False
        ONProcess = True
        ClearData()
        RdoCust.Checked = True
        PnlWeightStat.Enabled = False

        If SysSettings.WeighingType = "S" Then
            PnlWeightStat.Enabled = True
            INBOUNDWT_Tmp = "0"
            WeighIn = False
            Weighout = True
        End If


        If OnDevice = True Then
            TxtOnline_TextChanged(sender, e)
        Else
            TxtOffline_TextChanged(sender, e)
        End If



        TxtDeduct_LostFocus(sender, e)
        EnableData()
        GrabSettings()
    End Sub

    Private Sub BtnOUt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If BtnOUt.Enabled = False Then Exit Sub
        If Dg.Rows.Count = 0 Then Exit Sub

        Dg_Click(sender, e)

        WeighIn = False
        Weighout = True
        ONProcess = True
        PnlWeightStat.Enabled = True

        If OnDevice = True Then
            TxtOnline_TextChanged(sender, e)
        Else
            TxtOffline_TextChanged(sender, e)
        End If




        SearchClient()
        SearchCOmmodity()
        TxtDeduct_LostFocus(sender, e)
        EnableData()
        GrabSettings()
        TxtPlateNo.Focus()
    End Sub

    Private Sub Btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Btnsave.Enabled = False Then Exit Sub
        Try
            If Validation() = False Then Exit Sub

            If MessageBox.Show("Are entries correct?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub

            If (OnDevice = True) Then DT = Now Else DT = DTPicker.Value

            Select Case SysSettings.WeighingType
                Case "S"
                    SaveSingleWeighingData()
                Case "IO"
                    Select Case True
                        Case WeighIn
                            SaveInboundData()
                        Case Weighout
                            SaveOutboundData()
                    End Select
            End Select


        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Btncancel.Enabled = False Then Exit Sub
        ONProcess = False
        WeighIn = False
        Weighout = False
        TxtWeightType.Text = "Gross"
        DisableData()
        Viewdata()
    End Sub

    Private Sub BtnPrintIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If BtnPrintIN.Enabled = False Then Exit Sub
        If Dg.Rows.Count = 0 Then Exit Sub
        If SysSettings.EnablePrintOut = True Then
            Select Case SysSettings.PrintAll
                Case False
                Case False
                    If MessageBox.Show("Re-print inbound ticket?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub
                    MOD_REPORTING.PrintToPrinter(Application.StartupPath & "\Reports\" & "TcktIN.rpt", "{OutBound_tbl.Refno} = '" & INBOUND_REFNO & "'", Nothing)
            End Select
        End If
    End Sub

    Private Sub BtnPrintOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If BtnPrintOut.Enabled = False Then Exit Sub
        If LastOutRefNo = Nothing Then Exit Sub

        Try
            Me.Cursor = Cursors.AppStarting
            If SysSettings.PrintAll = True Then
                If SysSettings.EnablePrintOut = True Then
                    MOD_REPORTING.PrintToPrinter(Application.StartupPath & "\Reports\" & "TcktOut.rpt", "{OutBound_tbl.Refno} = '" & LastOutRefNo & "'", Nothing)
                End If
            Else
                If SysSettings.PrintAll = True Then
                    MOD_REPORTING.PrintToPrinter(Application.StartupPath & "\Reports\" & "TcktAll.rpt", "{OutBound_tbl.Refno} = '" & LastOutRefNo & "'", Nothing)
                End If
            End If
        Catch ex As Exception

        End Try
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub BtnSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If BtnSetup.Enabled = False Then Exit Sub
        FrmSystemSettings.ShowDialog()
    End Sub

    Private Sub Dg_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Viewdata()
    End Sub

    Private Sub Dg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        BtnOUt_Click(sender, e)
    End Sub


#Region "BUTTON TOGGLES"


    Private Sub ClearData()
        Dim CLS_TOGGLES As New CLS_CONTROLTOGGLES
        CLS_TOGGLES.ClearDataControls(Me)

    End Sub

    Private Sub EnableData()
        Dim cls_toggles As New CLS_CONTROLTOGGLES
        cls_toggles.EnableDataControls(Me)

        BtnIn.Enabled = False
        BtnOUt.Enabled = False
        BtnDelete.Enabled = False
        Btnsave.Enabled = True
        Btncancel.Enabled = True
        BtnPrintIN.Enabled = False
        TxtSearch.Enabled = False
        BtnAddCust.Enabled = True
        BtnAddComm.Enabled = True
        BtnAddComm.Enabled = True

        Dg.Enabled = False
    End Sub

    Private Sub DisableData()
        Dim cls_toggles As New CLS_CONTROLTOGGLES
        cls_toggles.DisableDataControls(Me)

        BtnIn.Enabled = True
        BtnOUt.Enabled = True
        BtnDelete.Enabled = True
        Btnsave.Enabled = False
        Btncancel.Enabled = False
        BtnPrintIN.Enabled = True
        TxtSearch.Enabled = True
        BtnAddCust.Enabled = False
        BtnAddComm.Enabled = False

        Dg.Enabled = True
    End Sub

#End Region


    Private Sub SearchClient()
        Try

            Dim cls
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

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SearchCOmmodity()
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

        Dim tbl As New DataTable
        tbl.Load(cls.datareader)
        If tbl.Rows.Count > 0 Then
            Dim price As Decimal = 0
            Decimal.TryParse(TxtPrice.Text, price)
            If (price = 0) Then
                If IsDBNull(tbl.Rows(0).Item("Pricing")) Then TxtPrice.Text = "" Else TxtPrice.Text = tbl.Rows(0).Item("Pricing")

            End If
        End If

        tbl = Nothing

    End Sub

    Private Sub UPPERCASE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.KeyChar = Convert.ToChar(e.KeyChar.ToString.ToUpper)
    End Sub

    Private Sub RdoCust_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RdoCust.CheckedChanged, RdoSup.CheckedChanged
        CboClient.Items.Clear()
        CboClient.Text = ""
        Select Case RdoCust.Checked
            Case True
                MOD_DATABASEPROC.ThrowArrayToControl(CboClient, CustList)
            Case False
                MOD_DATABASEPROC.ThrowArrayToControl(CboClient, SupList)
        End Select
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

#Region "WEIGHING PROCEDURE"

    Private Sub TxtOnline_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtOnline.KeyDown

    End Sub

    Private Sub TxtOnline_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtOnline.KeyPress

    End Sub

    Private Sub TxtOnline_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtOnline.KeyUp

    End Sub

    Public Sub TxtOnline_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtOnline.TextChanged
        On Error Resume Next
        If OnDevice = False Then Exit Sub
        '  GetDeviceVal(Val(FormatNumber((Val(TxtOnline.Text) / 1000), 2, TriState.False, TriState.False)))
        GetDeviceVal(Val(FormatNumber((Val(TxtOnline.Text)), 0, TriState.False, TriState.False, TriState.False)))
    End Sub

    Public Sub TxtOffline_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtOffline.TextChanged
        On Error Resume Next
        If OnDevice = True Then Exit Sub
        If IsNumeric(TxtOffline.Text) = False Then
            If String.IsNullOrWhiteSpace(TxtOffline.Text) = False Then
                MessageBox.Show("Weight be should be numeric..")
                Exit Sub
            End If
        End If


        'GetDeviceVal(Val(FormatNumber((TxtOffline.Text), 0, TriState.False, TriState.False)))
        GetDeviceVal(Val(FormatNumber((Val(TxtOffline.Text)), 0, TriState.False, TriState.False, TriState.False)))
    End Sub


    Public Sub GetDeviceVal(ByVal Weight As String)
        If ONProcess = False Then Exit Sub

        Dim ReturnedInWeight As String = INBOUNDWT_Tmp
        Dim ReturnedDevWeight As String = Replace(Weight, ",", "")

        If String.IsNullOrEmpty(ReturnedDevWeight) Then ReturnedDevWeight = 0
        If IsNumeric(ReturnedDevWeight) = False Then ReturnedDevWeight = 0

        Select Case UnitWeight
            Case "KG"
                ReturnedDevWeight = ReturnedDevWeight
                ReturnedInWeight = ReturnedInWeight
            Case "TONS"
                ReturnedInWeight = FormatNumber(ReturnedInWeight, 2, TriState.False, TriState.False, TriState.False)
                ReturnedDevWeight = FormatNumber(ReturnedDevWeight / 1000, 2, TriState.False, TriState.False, TriState.False)
        End Select

        Select Case True
            Case WeighIn
                TxtGross.Text = ReturnedDevWeight
                TxtWeightType.Text = "Gross"
            Case Weighout
                Select Case Val(ReturnedInWeight)
                    Case Is >= Val(ReturnedDevWeight)
                        TxtGross.Text = ReturnedInWeight
                        TxtTare.Text = ReturnedDevWeight
                        TxtWeightType.Text = "Tare"
                    Case Is < Val(ReturnedDevWeight)
                        TxtGross.Text = ReturnedDevWeight
                        TxtTare.Text = ReturnedInWeight
                        TxtWeightType.Text = "Gross"
                End Select

                Select Case UnitWeight
                    Case "KG"
                        TxtNet.Text = Val(FormatNumber((TxtGross.Text) - Val(TxtTare.Text), 0, TriState.False, TriState.False, TriState.False))
                        TxtFINAL.Text = FormatNumber(DeductWeight(TxtDeduct.Text, TxtNet.Text), 0, TriState.False, TriState.False, TriState.False)
                    Case "TONS"
                        TxtNet.Text = (FormatNumber((TxtGross.Text) - Val(TxtTare.Text), 2, TriState.False, TriState.False, TriState.False))
                        TxtFINAL.Text = FormatNumber(DeductWeight(TxtDeduct.Text, TxtNet.Text), 2, TriState.False, TriState.False, TriState.False)
                End Select
        End Select

    End Sub
#End Region

    Private Sub CboClient_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboClient.GotFocus
        If ONProcess = False Then Exit Sub
        If CboClient.Enabled = False Then Exit Sub
        '  SetupDBGRID("select CustCode,CustName From Cust_Tbl")

    End Sub
    Private Sub CboClient_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboClient.TextChanged
        If ONProcess = False Then Exit Sub
        If CboClient.Enabled = False Then Exit Sub
    End Sub


    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If BtnDelete.Enabled = False Then Exit Sub

            If Dg.Rows.Count = 0 Then Exit Sub
            If Dg.Enabled = False Then Exit Sub

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
                Remover.Table = "OUtbound_Tbl"
                Remover.FieldName = "RefNo"
                Remover.Text = TxtRefNo.Text
                Remover.Source = "Delete From " & Remover.Table & " where refno = '" & Remover.Text & "'"
                Remover.ExecuteCommand()
                ' TxtSearch.AutoCompleteCustomSource.Remove(e.Row.Cells(1).Value)
                Dg.Rows.Remove(Dg.CurrentRow)
                Dg_Click(Nothing, Nothing)
                '   Dim Tmp As String = MDIMAIN.FrmProducts.CboBrand.Text
                ' ListCombo(SQLConn, "ItemBrand", "BrandName", MDIMAIN.FrmProducts.CboBrand)
                '  MDIMAIN.FrmProducts.CboBrand.Text = Tmp
                LblRecord.Text = Dg.Rows.Count
                MessageBox.Show("Deleting Complete...", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "An error occured while deleting data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TxtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearch.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim Gridclass As New CLS_DATAGRID
                Gridclass.SearchGrid(Dg, TxtSearch.Text, 1)

        End Select
    End Sub



    Private Sub TxtDeduct_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDeduct.LostFocus
        Dim TMP As String = (Replace(TxtDeduct.Text, ",", ""))
        If String.IsNullOrEmpty(TMP) = True Then TMP = "0.00"
        If IsNumeric(TMP) = False Then Exit Sub

        Dim DMC As Double = Replace(TMP, ",", "")
        Select Case DeductUnit
            Case "KG"
                TxtDeduct.Text = FormatNumber(DMC, 0, TriState.True, TriState.True, TriState.True)
            Case "%"
                TxtDeduct.Text = FormatNumber(DMC, 2, TriState.True, TriState.True, TriState.True)
        End Select

    End Sub
    Private Sub TxtDeduct_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDeduct.TextChanged
        If Weighout = False Then Exit Sub
        TxtFINAL.Text = DeductWeight(TxtDeduct.Text, Val(TxtNet.Text))
    End Sub

    Private Function DeductWeight(ByVal Deduction As String, ByVal NetWeight As Double) As String

        Dim result As String = NetWeight
        Deduction = (Replace(Deduction, ",", ""))
        If String.IsNullOrEmpty(Deduction) = True Then Deduction = "0.00"
        If IsNumeric(Deduction) = False Then
            Return result
            Exit Function
        End If

        Select Case UnitWeight
            Case "KG"
                Select Case DeductUnit
                    Case "KG"
                        result = NetWeight - Deduction
                    Case "%"
                        Deduction = CDbl(Deduction * 0.01)
                        result = NetWeight - (Deduction * NetWeight)
                End Select
                result = FormatNumber(result, 0, TriState.True, TriState.True, TriState.True)
            Case "TONS"
                Select Case DeductUnit
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




    Private Sub PushButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddCust.Click
        Dim Frm As New FrmNewCust
        Frm.ShowDialog(Me)
    End Sub

    Private Sub BtnAddComm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddComm.Click
        Dim Frm As New FrmnewComm
        Frm.ShowDialog(Me)

    End Sub

    Private Sub CboClient_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboClient.SelectedIndexChanged
        Try
            If ONProcess = False Then Exit Sub
            If CboClient.Enabled = False Then Exit Sub

            SearchClient()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CboCommodity_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboCommodity.SelectedIndexChanged
        If ONProcess = False Then Exit Sub
        If CboCommodity.Enabled = False Then Exit Sub
        SearchCOmmodity()
    End Sub

    Private Sub CboCommodity_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboCommodity.TextChanged
        If ONProcess = False Then Exit Sub
        If CboCommodity.Enabled = False Then Exit Sub
        SearchCOmmodity()
    End Sub

    Private Sub Btnsave_Click_1(sender As Object, e As EventArgs) Handles Btnsave.Click

    End Sub
End Class