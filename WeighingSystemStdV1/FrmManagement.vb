Public Class FrmManagement
    Private Sub Frmmanagement_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MDIMAIN.Pnl_MainBtn.Visible = True
    End Sub

    Private Sub FrmManagement_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
  
        If e.Alt Or e.Shift = True Then Exit Sub
        If e.Control = True Then
            Select Case e.KeyCode
                Case Keys.P
                    BtnPrint_Click(sender, e)
            End Select
        Else
            Select Case e.KeyCode
                Case Keys.F1
                    BtnView_Click(sender, e)
                Case Keys.Delete
                    BtnDelete_Click(sender, e)
                Case Keys.Escape
                    BtnExit_Click(sender, e)
            End Select
        End If
    End Sub

    Private Sub FrmManagement_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        DTFrom.CustomFormat = "MM-dd-yyyy"
        DTto.CustomFormat = "MM-dd-yyyy"
        ListOutBound()
        CboSearchBy.SelectedIndex = 0
        RdoInbound.Width = Me.Width / 2
        RdoOutbound.Width = RdoInbound.Width
        Dg.Focus()

        AddHandler BtnDelete.Click, AddressOf BtnDelete_Click
        '   AddHandler BtnPrint.Click, AddressOf BtnPrint_Click
        AddHandler BtnExit.Click, AddressOf BtnExit_Click
    End Sub


    Private Sub BtnGen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGen.Click
        ListOutBound()
    End Sub

   
    Public Sub ListOutBound()
        Dim SysSettings As New settings
        SysSettings.Load()
        Dim From_Val As String = Nothing
        Dim To_val As String = Nothing

        From_Val = DTFrom.Text & " 12:00 AM"
        To_val = DTto.Text & " 11:59 PM"

        Dim FromVal As String = Nothing
        Dim ToVal As String = Nothing

        FromVal = String.Format("{0:00}", Year(DTFrom.Value))
        FromVal = FromVal & String.Format("{0:00}", Month(DTFrom.Value))
        FromVal = FromVal & String.Format("{0:00}", DTFrom.Value.Day)

        ToVal = String.Format("{0:00}", Year(DTto.Value))
        ToVal = ToVal & String.Format("{0:00}", Month(DTto.Value))
        ToVal = ToVal & String.Format("{0:00}", DTto.Value.Day)

        If FromVal > ToVal Then
            MessageBox.Show("Invalid Date range", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        FromVal = DTFrom.Text & " 12:00 AM"
        ToVal = DTto.Text & " 11:59 PM"

        Dg.Rows.Clear()
        Dim Src As String = _
            "SELECT " & _
            "(SELECT CUSTNAME FROM CUST_TBL WHERE CUSTCODE = CustomerCode)" & _
",(SELECT SUPNAME FROM SUP_TBL WHERE SUPCODE =SupplierCode)" & _
",(SELECT COMMDESC FROM COMM_TBL WHERE COMMCODE = CommodityCode)" & _
",(SELECT USER_DISPLAYNAME FROM USERACCOUNTS WHERE User_id = WeigherIn)" & _
",(SELECT USER_DISPLAYNAME FROM USERACCOUNTS WHERE User_id = WeigherOUt)" & _
",* FROM OUTBOUND_TBL "

        Select Case True
            Case RdoInbound.Checked
                Src = Src & "where DTIN between  #" & FromVal & "# and #" & ToVal & "# and DTOUT is Null order by REFNO ASC "
            Case RdoOutbound.Checked
                Src = Src & "where DTOut between #" & FromVal & "# and #" & ToVal & "# order by REFNO ASC "
        End Select
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

                    If IsDBNull(.Item("DTIn")) Then Rw.Cells(Col_DateTimeIn.Name).Value = "" Else Rw.Cells(Col_DateTimeIn.Name).Value = Format(.Item("DTIn"), "MM-dd-yyyy hh:mm tt")
                    If IsDBNull(.Item("DTOUt")) Then Rw.Cells(Col_DateTimeOut.Name).Value = "" Else Rw.Cells(Col_DateTimeOut.Name).Value = Format(.Item("DTOUt"), "MM-dd-yyyy hh:mm tt")
                    If IsDBNull(.Item("PlateNo")) Then Rw.Cells(Col_PlateNo.Name).Value = "" Else Rw.Cells(Col_PlateNo.Name).Value = Trim(.Item("PlateNo").ToString)
                    Select Case True
                        Case IsDBNull(.item(0))
                            If IsDBNull(.Item(1)) Then Rw.Cells(Col_Client.Name).Value = "" Else Rw.Cells(Col_Client.Name).Value = .item(1)
                        Case IsDBNull(.item(1))
                            If IsDBNull(.Item(0)) Then Rw.Cells(Col_Client.Name).Value = "" Else Rw.Cells(Col_Client.Name).Value = .item(0)
                        Case Else
                            Rw.Cells(Col_Client.Name).Value = ""
                    End Select

                    If IsDBNull(.Item(2)) Then Rw.Cells(Col_Comm.Name).Value = "" Else Rw.Cells(Col_Comm.Name).Value = .item(2)
                    If IsDBNull(.Item("pricing")) Then Rw.Cells(Col_Pricing.Name).Value = "" Else _
           Rw.Cells(Col_Pricing.Name).Value = FormatNumber(Trim(.Item("Pricing")), 2, TriState.True, TriState.True, TriState.True) _
           & "/" & .item("UnitPerPrice")
                    If IsDBNull(.Item("DrNO")) Then Rw.Cells(Col_Dr.Name).Value = "" Else Rw.Cells(Col_Dr.Name).Value = .item("DRNO")
                    If IsDBNull(.Item("TicketNo")) Then Rw.Cells(Col_TktNO.Name).Value = "" Else Rw.Cells(Col_TktNO.Name).Value = .item("TicketNo")
                    If IsDBNull(.Item("Gross_wt")) Then Rw.Cells(Col_Gross.Name).Value = "" Else Rw.Cells(Col_Gross.Name).Value = .item("Gross_wt")
                    If IsDBNull(.Item("Tare_wt")) Then Rw.Cells(Col_Tare.Name).Value = "" Else Rw.Cells(Col_Tare.Name).Value = .item("Tare_wt")
                    If IsDBNull(.Item("Net_wt")) Then Rw.Cells(Col_Net.Name).Value = "" Else Rw.Cells(Col_Net.Name).Value = .item("Net_wt")
                    If IsDBNull(.Item("DriverName")) Then Rw.Cells(Col_Driver.Name).Value = "" Else Rw.Cells(Col_Driver.Name).Value = .item("DriverName")
                    If IsDBNull(.Item("remarks")) Then Rw.Cells(Col_remarks.Name).Value = "" Else Rw.Cells(Col_remarks.Name).Value = .item("remarks")
                    If IsDBNull(.Item(3)) Then Rw.Cells(Col_Weigher.Name).Value = "" Else Rw.Cells(Col_Weigher.Name).Value = .Item(3).ToString
                    If IsDBNull(.Item(4)) Then Rw.Cells(Col_WeigherOut.Name).Value = "" Else Rw.Cells(Col_WeigherOut.Name).Value = .Item(4).ToString
                End While
            End If
            .Close()
        End With

        LblRecord.Text = Dg.Rows.Count
    End Sub


    Private Sub TxtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearch.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
        End Select
    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSearch.TextChanged
        Dim Gridclass As New CLS_DATAGRID
        Select Case CboSearchBy.SelectedIndex
            Case -1
            Case 0
                Gridclass.SearchGrid(Dg, TxtSearch.Text, 3)
            Case 1
                Gridclass.SearchGrid(Dg, TxtSearch.Text, 0)
            Case 2
                Gridclass.SearchGrid(Dg, TxtSearch.Text, 4)
        End Select

    End Sub


    Private Sub BtnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnView.Click
        If Dg.Rows.Count = 0 Then Exit Sub
        If IsNothing(Dg.CurrentRow) Then Exit Sub

        MOD_MAINFORMPROC.OpenMainBUtton(FrmLogin.WeighingModule, FrmEditTrans, Nothing, MDIMAIN)
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim SysSettings As New settings
            SysSettings.Load()
            If BtnDelete.Enabled = False Then Exit Sub

            If Dg.Rows.Count = 0 Then Exit Sub
            If IsNothing(Dg.CurrentRow) Then Exit Sub


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
                Remover.Text = Dg.CurrentRow.Cells(0).Value
                Remover.Source = "Delete From " & Remover.Table & " where RefNo = '" & Remover.Text & "'"
                Remover.ExecuteCommand()

                Dg.Rows.Remove(Dg.CurrentRow)
                LblRecord.Text = Dg.Rows.Count
                MessageBox.Show("Deleting Complete...", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "An error occured while deleting data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        If BtnPrint.Enabled = False Then Exit Sub
        If Dg.Rows.Count = 0 Then Exit Sub
        If IsNothing(Dg.CurrentRow) Then Exit Sub

        If MessageBox.Show("Re print selected record?", "Re-Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub


        If RdoInbound.Checked = True Then
            MOD_REPORTING.PrintToPrinter(Application.StartupPath & "\Reports\" & "TcktIn.rpt", "{OutBound_tbl.Refno} = '" & Dg.CurrentRow.Cells(0).Value & "'", Nothing, Dg.CurrentRow.Cells(0).Value)
        Else
            MOD_REPORTING.PrintToPrinter(Application.StartupPath & "\Reports\" & "TcktInOutAll.rpt", "{OutBound_tbl.Refno} = '" & Dg.CurrentRow.Cells(0).Value & "'", Nothing, Dg.CurrentRow.Cells(0).Value)

        End If

      
  
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

  
    Private Sub BtnDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click

    End Sub

    Private Sub RdoOutbound_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RdoOutbound.CheckedChanged
        BtnGen_Click(sender, e)
    End Sub


    Private Sub RdoInbound_CheckedChanged(sender As Object, e As EventArgs) Handles RdoInbound.CheckedChanged

    End Sub
End Class