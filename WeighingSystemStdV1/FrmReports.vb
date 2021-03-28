Public Class FrmReports

    Private Sub BtnPreview_CLIck(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        GenerateReport()
    End Sub



    Private ReportPath As String = Nothing
    Private Sub GenerateReport()
        Dim SysSettings As New settings
        SysSettings.Load()
        Dim dtf As DateTime = DTFrom.Value.Date
        Dim dtt As DateTime = DTto.Value.Date

        Select Case DateDiff(DateInterval.Minute, dtf, dtt) : Case Is < 0 : MessageBox.Show("Invalid Date range", "", MessageBoxButtons.OK, MessageBoxIcon.Stop) : Exit Sub : End Select

        dtf = dtf.Date + New TimeSpan(0, 0, 0)
        dtt = dtt.Date + New TimeSpan(23, 59, 0)

        Dim SelectionFormula As String = ""
        Select Case True
            Case RdoDateIn.Checked
                SelectionFormula = "{outbound_Tbl.DTIn} = datetime('" & dtf.ToString("dd-MMM-yyyy hh:mm tt") & "') to datetime('" & dtt.ToString("dd-MMM-yyyy hh:mm tt") & "') "
            Case RdoDateOut.Checked
                SelectionFormula = "{outbound_Tbl.DTOut} = datetime('" & dtf.ToString("dd-MMM-yyyy hh:mm tt") & "') to datetime('" & dtt.ToString("dd-MMM-yyyy hh:mm tt") & "') "
        End Select

        SelectionFormula = SelectionFormula & GeneratedSelection()

        Select Case CboReportType.SelectedIndex
            Case -1
            Case 0
                Select Case SysSettings.EnablePricing
                    Case True
                        ReportPath = Application.StartupPath & "\Reports\" & "GenRepWP.rpt"
                    Case False
                        ReportPath = Application.StartupPath & "\Reports\" & "GenRepNP.rpt"
                End Select
            Case 1
                'Dim Cls As New CLS_SQL_DATABASE
                'With Cls
                '    Cls.Conn = SQLConn
                '    Cls.Source = "Delete From TBLDay"
                '    Cls.ExecuteCommand()

                '    For i = DTFrom.Value.Day To DTto.Value.Day
                '        Cls.Source = "Insert into TBLDay (DDAY) values (" & i & ")"
                '        Cls.ExecuteCommand()
                '    Next

                '    Cls.Cmd.Dispose()
                'End With
                ReportPath = Application.StartupPath & "\Reports\" & "MonthlyRep.rpt"
            Case 2
                ReportPath = Application.StartupPath & "\Reports\" & "BillingRep.rpt"
        End Select

        Dim SortField As String = ""
        Select Case CboSort.SelectedIndex
            Case 0
                SortField = "DtIn"
            Case 1
                SortField = "DtOut"
            Case 2
                SortField = "Final_wt"
            Case 3
                SortField = "Refno"
        End Select

        Dim SortOrder As New CrystalDecisions.Shared.SortDirection
        Select Case CboOrder.SelectedIndex
            Case 0
                SortOrder = CrystalDecisions.Shared.SortDirection.AscendingOrder
            Case 1
                SortOrder = CrystalDecisions.Shared.SortDirection.DescendingOrder
            Case 2
                SortOrder = CrystalDecisions.Shared.SortDirection.TopNOrder
        End Select
        'Clipboard.SetText(SelectionFormula)
        ViewReport(CrViewer, ReportPath, SelectionFormula, Nothing, dtf, dtt, FrmLogin.UserDisplayName, _
                   "Outbound_Tbl", SortField, SortOrder, _
                   "DTIn")


    End Sub

    Private Function GeneratedSelection() As String
        Dim Result As String = ""
        If ChkNone.Checked = True Then Return Result

        If ChkTrans.Checked = True Then
            Select Case True
                Case RdoInbound.Checked
                    Result = " and {OutBound_Tbl.Net_Wt} = 0"
                Case RdoOutBound.Checked
                    Result = " and {OutBound_Tbl.Net_Wt} <> 0"
                Case RdoTBoth.Checked
            End Select
        End If

        If ChkPlateNo.Checked = True Then
            Result = Result & " and {OutBound_Tbl.PlateNo}  = '" & Trim(TxtPlateNo.Text) & "'"
        End If

        If ChkClient.Checked = True Then
            Dim ClientCode As String = ""
            Select Case True
                Case RdoCust.Checked
                    If MOD_DATABASEPROC.ExistenceFound("Select CustCode From Cust_tbl where CustName = '" & Trim(CboClient.Text) & "'", Nothing, "CustCode", Nothing) Then
                        Result = Result & " and {Cust_tbl.CustCode} = '" & ReturnedData & "'"
                    Else
                        MessageBox.Show("Client Wasn't found", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    End If
                Case RdoSup.Checked
                    If MOD_DATABASEPROC.ExistenceFound("Select SupCode From Sup_tbl where SupName = '" & Trim(CboClient.Text) & "'", Nothing, "SupCode", Nothing) Then
                        Result = Result & " and {Sup_tbl.SUpCode} = '" & ReturnedData & "'"
                    Else
                        MessageBox.Show("Client Wasn't found", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    End If
            End Select
        End If

        If ChkMaterial.Checked = True Then
            If MOD_DATABASEPROC.ExistenceFound("Select CommCode From Comm_tbl where CommDesc = '" & Trim(CboMaterial.Text) & "'", Nothing, "CommCode", Nothing) Then
                Result = Result & " and {Comm_tbl.CommCode} = '" & ReturnedData & "'"
            Else
                MessageBox.Show("Commodity Wasn't found", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        End If

        If ChkDriver.Checked = True Then
            Result = Result & " and {Outbound_Tbl.DriverName} = '" & Trim(TxtDriver.Text) & "'"
        End If

        If ChkNone.Checked = True Then
            Result = ""
        End If

        Return Result
    End Function

    Private Sub FrmReports_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MDIMAIN.Pnl_MainBtn.Visible = True
    End Sub

    Private Sub FrmReports_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetData()
        MOD_DATABASEPROC.ThrowArrayToControl(CboClient, CustList)
        MOD_DATABASEPROC.ThrowArrayToControl(CboMaterial, CommList)
        MOD_DATABASEPROC.ThrowArrayToControl(TxtDriver, DRVList)

        CboReportType.SelectedIndex = 0
        RdoOutBound.Checked = True
        CboSort.SelectedIndex = 0
        CboOrder.SelectedIndex = 0
        ChkNone.Checked = True

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

    Private Sub ChkNone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkNone.CheckedChanged
        If ChkNone.Checked = True Then
            ChkPlateNo.Enabled = False
            ChkClient.Enabled = False
            ChkTrans.Enabled = False
            ChkMaterial.Enabled = False
            ChkDriver.Enabled = False
            PnlTrans.Enabled = False
            TxtPlateNo.Enabled = False
            PnlClientType.Enabled = False
            CboMaterial.Enabled = False
            TxtDriver.Enabled = False
        Else
            ChkPlateNo.Enabled = True
            ChkClient.Enabled = True
            ChkTrans.Enabled = True
            ChkMaterial.Enabled = True
            ChkDriver.Enabled = True
            PnlTrans.Enabled = True
            TxtPlateNo.Enabled = True
            PnlClientType.Enabled = True
            CboMaterial.Enabled = True
            TxtDriver.Enabled = True
        End If

        ChkPlateNo.Checked = False
        ChkClient.Checked = False
        ChkTrans.Checked = False
        ChkMaterial.Checked = False
        ChkDriver.Checked = False
    End Sub

    Private Sub PushButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PushButton1.Click
        MDIMAIN.Pnl_MainBtn.Visible = True
        Me.Close()
    End Sub

    Private Sub PushButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PushButton3.Click
        CrViewer.PrintReport()

    End Sub

    Private Sub RdoSup_CheckedChanged(sender As Object, e As EventArgs) Handles RdoSup.CheckedChanged

    End Sub

    Private Sub RdoCust_CheckedChanged(sender As Object, e As EventArgs) Handles RdoCust.CheckedChanged
        CboClient.Text = ""
        If RdoCust.Checked = True Then
            MOD_DATABASEPROC.ThrowArrayToControl(CboClient, CustList)
        Else
            MOD_DATABASEPROC.ThrowArrayToControl(CboClient, SupList)
        End If

    End Sub
End Class