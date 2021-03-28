Public Class FrmCommodity
    Private EnableValidation As Boolean = True



    Private Sub Load_Form(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If FrmLogin.DBMaintenance = "RO" Then Dg.EditMode = DataGridViewEditMode.EditProgrammatically

        ListData()
    End Sub

    Private Sub ListData()
        Try
            Dim SysSettings As New settings
            SysSettings.Load()
            Dim Cls_Crypt As New CLS_CRYPTO
            Dg.Rows.Clear()
            Dim cls
            If SysSettings.ConnectionType = "OLEDB" Then
                cls = New CLS_OLE_DB
                cls.connection = OLEDBCONX
            Else
                cls = New CLS_SQL_DB
                cls.connection = SQLCONX
            End If

            With cls
                .Table = "Comm_tbl"
                .OpenTable()
            End With
            With cls.DataReader
                If .HasRows Then
                    Dim Rw As DataGridViewRow
                    While .Read
                        Dg.Rows.Add(.Item("CommId"))
                        Dg.Rows(Dg.Rows.Count - 2).Selected = True
                        Dg.FirstDisplayedScrollingRowIndex = Dg.Rows.Count - 2
                        Dg.CurrentCell = Dg.Rows.Item(Dg.Rows.Count - 2).Cells(0)
                        Rw = Dg.CurrentRow

                        If IsDBNull(.Item("CommCode")) Then Rw.Cells(Col_Code.Name).Value = "" Else Rw.Cells(Col_Code.Name).Value = Trim(.Item("CommCode").ToString)
                        If IsDBNull(.Item("CommDesc")) Then Rw.Cells(Col_Desc.Name).Value = "" Else Rw.Cells(Col_Desc.Name).Value = Trim(.Item("CommDesc").ToString)
                        If IsDBNull(.Item("Pricing")) Then Rw.Cells(Col_Pricing.Name).Value = "0.00" Else Rw.Cells(Col_Pricing.Name).Value = FormatNumber(Trim(.Item("Pricing")), 2, TriState.True, TriState.True, TriState.True)
                        If IsDBNull(.Item("Active")) Then Rw.Cells(Col_active.Name).Value = False Else Rw.Cells(Col_active.Name).Value = CBool(Trim(.Item("Active").ToString))

                        TxtSearch.AutoCompleteCustomSource.Add(Rw.Cells(Col_Desc.Name).Value)
                    End While
                End If
                .Close()
            End With
            BtnFirst_Click(Nothing, Nothing)
            Dg.Columns(0).Visible = False

            EnableValidation = False

        Catch ex As Exception
            Dim CL As New CLS_LOG
            With CL
                .User = FrmLogin.UserDisplayName
                .LogError = ex.Message
                .Remarks = "An error encountered while listing data."
                .LogLocation = "Commodity Maintenance Window"
                .CreateErrorLog()
            End With
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#Region "CELL VALIDATING AND SAVING"
    Private AddSwitch As Boolean = False
    Private EditSwitch As Boolean = False
    Private BeginEdit As Boolean = False
    Private EndEdit As Boolean = False
    Private EnableSaving As Boolean = True
    Private PreviousVal As String = ""


    Private Sub Dg_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles Dg.CellBeginEdit
        If Dg.CurrentRow.IsNewRow Then
            AddSwitch = True
            Dg.CurrentRow.Cells(Col_active.Name).Value = True
        Else
            EditSwitch = True
            PreviousVal = Dg.CurrentRow.Cells(2).Value
        End If
        BeginEdit = True
    End Sub

    Private _SelectedRowValue As DataGridViewRow
    Dim _DescFVal As String
    Private Sub StoreRowValue()
        If IsNothing(_SelectedRowValue) Then _SelectedRowValue = Dg.CurrentRow
        _SelectedRowValue = Dg.CurrentRow
    End Sub

    Private Sub Dg_RowsRemov2ed(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) 'Handles Dg.RowsRemoved
        BeginEdit = False
        EnableValidation = False
    End Sub

    Private Sub Dg_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles Dg.RowValidating
        Try
            If BeginEdit = False Then Exit Sub
            Dim SysSettings As New settings
            SysSettings.Load()
            Dim ErrorText As String = Nothing
            If Dg.Rows(e.RowIndex).IsNewRow Then
                Dg.Rows(e.RowIndex).ErrorText = Nothing
                Exit Sub
            End If

            If Dg.Rows(e.RowIndex).Cells(0).Value = Nothing Then
                AddSwitch = True
                EditSwitch = False
            Else
                AddSwitch = False
                EditSwitch = True
            End If

            Dim Cellvalue As String
            Cellvalue = Dg.Rows(e.RowIndex).Cells(1).Value
            If String.IsNullOrEmpty(Cellvalue) Then
                ErrorText = ErrorText & Environment.NewLine & "Commodity Code is required."
            Else
                Select Case True
                    Case AddSwitch
                        If MOD_DATABASEPROC.ExistenceFound("Select * from Comm_tbl where CommCode = '" & Trim(Cellvalue) & "'", Nothing, Nothing, Nothing) Then
                            ErrorText = ErrorText & Environment.NewLine & "Specified Code is already in the database."
                        End If
                    Case EditSwitch
                        If MOD_DATABASEPROC.ExistenceFound("select * From Comm_Tbl where CommId = " & Dg.CurrentRow.Cells(0).Value & "", Nothing, "CommCode", Nothing) Then
                            If Trim(ReturnedData) <> Trim(Cellvalue) Then
                                If MOD_DATABASEPROC.ExistenceFound("select * From Outbound_Tbl where CommodityCode = '" & ReturnedData & "'", Nothing, Nothing, Nothing) Then
                                    ErrorText = ErrorText & Environment.NewLine & "* Code cannot cannot be edited because it is being used by another table."
                                End If
                            End If
                        Else
                            If MOD_DATABASEPROC.ExistenceFound("Select * from Comm_tbl where CommCode= '" & Trim(Cellvalue) & "' and CommId <>" & Dg.CurrentRow.Cells(0).Value & "", Nothing, Nothing, Nothing) Then
                                ErrorText = ErrorText & Environment.NewLine & "Specified Code is already in the database."
                            End If
                        End If
                End Select
            End If

            Cellvalue = Dg.Rows(e.RowIndex).Cells(2).Value
            If String.IsNullOrEmpty(Trim(Cellvalue)) Then
                ErrorText = ErrorText & Environment.NewLine & "Commodity Description is required."
            Else
                Select Case True
                    Case AddSwitch
                        If MOD_DATABASEPROC.ExistenceFound("Select * from Comm_tbl where CommDesc = '" & Trim(Cellvalue) & "'", Nothing, Nothing, Nothing) Then
                            ErrorText = ErrorText & Environment.NewLine & "Specified Descrition is already in the database."
                        End If
                    Case EditSwitch
                        If MOD_DATABASEPROC.ExistenceFound("Select * from Comm_tbl where CommDesc= '" & Trim(Cellvalue) & "' and CommId <>" & Dg.CurrentRow.Cells(0).Value & "", Nothing, Nothing, Nothing) Then
                            ErrorText = ErrorText & Environment.NewLine & "Specified Description is already in the database."
                        End If
                End Select
            End If

            Dim pricing As String = _
        Replace(Dg.Rows(e.RowIndex).Cells(Col_Pricing.Name).Value, ",", "")
            If String.IsNullOrEmpty(pricing) Then pricing = 0.0
            If IsNumeric(pricing) = False Then
                ErrorText = ErrorText & Environment.NewLine & "Price should be numeric."
            End If

            Dim Active As Boolean = Dg.Rows(e.RowIndex).Cells(Col_active.Name).Value
            Dg.Rows(e.RowIndex).ErrorText = ErrorText

            If IsNothing(ErrorText) = False Then
                e.Cancel = True
                Exit Sub
            Else
                e.Cancel = False
            End If

            If e.Cancel = False Then
                '  Dg.Rows.Clear()

                Dim Saver
                If SysSettings.ConnectionType = "OLEDB" Then
                    Saver = New CLS_OLE_DB
                    Saver.connection = OLEDBCONX
                Else
                    Saver = New CLS_SQL_DB
                    Saver.connection = SQLCONX
                End If


                If AddSwitch = True Then
                    If Dg.CurrentRow.ErrorText = Nothing Then
                        ' Dim Cls_Crypt As New CLS_CRYPTO
                        With Saver
                            Saver.Table = "Comm_tbl"
                            Saver.Source = "Insert into " & Saver.Table & " (CommCode,Commdesc,Pricing,Active) values (" & _
                                "'" & Trim(Dg.Rows(e.RowIndex).Cells(Col_Code.Name).Value) & "'" & _
                                  ",'" & Trim(Dg.Rows(e.RowIndex).Cells(Col_Desc.Name).Value) & "'" & _
                                    ",'" & pricing & "'" & _
                                 "," & Active & ")"
                            Saver.ExecuteCommand()
                            Saver.Cmd.Dispose()
                        End With

                        '//////////////// RECOVER ID
                        If ExistenceFound("Select * from Comm_tbl where CommCode = '" & Trim(Dg.Rows(e.RowIndex).Cells(Col_Code.Name).Value) & "'", Nothing, "CommId", Nothing) = True Then
                            Dg.Rows(e.RowIndex).Cells(0).Value = ReturnedData
                        End If

                        TxtSearch.AutoCompleteCustomSource.Add(Trim(Dg.Rows(e.RowIndex).Cells(2).Value))
                        '  MDIMAIN.FrmProducts.CboBrand.Items.Add(Trim(e.FormattedValue))
                    End If
                End If

                If EditSwitch = True Then
                    If Dg.CurrentRow.ErrorText = Nothing Then
                        Saver.Table = "Comm_tbl"
                        Saver.Source = "Update " & Saver.Table & " Set CommCode = '" & Trim(Dg.Rows(e.RowIndex).Cells(Col_Code.Name).Value) & "'" & _
                            ",CommDesc = '" & Trim(Dg.Rows(e.RowIndex).Cells(Col_Desc.Name).Value) & "'" & _
                            ",Pricing= '" & pricing & "'" & _
                            ",Active =" & Active & "" & _
                              " where CommId = " & Dg.CurrentRow.Cells(0).Value & ""

                        Saver.ExecuteCommand()
                        Saver.Cmd.Dispose()
                        TxtSearch.AutoCompleteCustomSource.Remove(PreviousVal)
                        TxtSearch.AutoCompleteCustomSource.Add(Trim(Dg.Rows(e.RowIndex).Cells(2).Value))

                    End If
                End If

                '/////////////////RESET VALIDATION
                BeginEdit = False
            End If

            BeginEdit = False
            AddSwitch = False
            EditSwitch = False

        Catch ex As Exception
            Dim CL As New CLS_LOG
            With CL
                .User = FrmLogin.UserDisplayName
                .LogError = ex.Message
                .LogLocation = "Commodity Maintenance Window"
                .Remarks = "An error encountered while validating entry"
                .CreateErrorLog()
            End With
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Dg_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles Dg.CellFormatting
        If e.ColumnIndex.Equals(Col_Pricing.Index) = False Then Exit Sub
        If EnableValidation = True Then Exit Sub

        Dim Pricing As String = Replace(Dg.Rows(e.RowIndex).Cells(e.ColumnIndex).Value, ",", "")
        If String.IsNullOrEmpty(Pricing) = True Then
            Dg.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "0.00"
        Else
            If IsNumeric(Pricing) = False Then Exit Sub
            Dg.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = FormatNumber(Pricing, 2, TriState.True, TriState.True, TriState.True)
        End If
    End Sub
#End Region

#Region "DELETING"
    Private Sub Dg_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles Dg.UserDeletingRow
        Try
            Dim SysSettings As New settings
            SysSettings.Load()
            If AddSwitch = True Then
                If BeginEdit = False Then
                    e.Cancel = True
                    Exit Sub
                End If
                Dg.CurrentRow.ErrorText = Nothing
            Else

                If Dg.Rows.Count = 0 Then Exit Sub
                If Dg.Enabled = False Then Exit Sub


                If MOD_DATABASEPROC.ExistenceFound("select * From Outbound_Tbl where CommodityCode = '" & Dg.CurrentRow.Cells(1).Value & "'", Nothing, Nothing, Nothing) Then
                    MessageBox.Show("* Code cannot cannot be deleted because it is being used by another table.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    e.Cancel = True
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
                    Remover.Table = "Comm_tbl"
                    Remover.FieldName = "CommCode"
                    Remover.Text = e.Row.Cells(1).Value
                    Remover.DeleteRecord()
                    TxtSearch.AutoCompleteCustomSource.Remove(e.Row.Cells(2).Value)


                    '   Dim Tmp As String = MDIMAIN.FrmProducts.CboBrand.Text
                    ' ListCombo(SQLConn, "ItemBrand", "BrandName", MDIMAIN.FrmProducts.CboBrand)
                    '  MDIMAIN.FrmProducts.CboBrand.Text = Tmp

                    MessageBox.Show("Deleting Complete...", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    e.Cancel = True
                End If
            End If


        Catch ex As Exception
            Dim CL As New CLS_LOG
            With CL
                .User = FrmLogin.UserDisplayName
                .LogError = ex.Message
                .LogLocation = "Commodity Maintenance Window"
                .Remarks = "An error encountered while deleting entry"
                .CreateErrorLog()
            End With
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Dg_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles Dg.RowsRemoved
        BeginEdit = False
        AddSwitch = False
        EditSwitch = False
    End Sub
#End Region

#Region "SEARCH BOX"

    Private Sub TxtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearch.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim Gridclass As New CLS_DATAGRID
                Gridclass.SearchGrid(Dg, TxtSearch.Text, 2)
        End Select
    End Sub

#End Region

    Private Sub Dg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Dg.KeyDown
        Try
            Dim SysSettings As New settings
            SysSettings.Load()
            If e.KeyCode = Keys.Escape Then
                Select Case True
                    Case AddSwitch
                        EnableValidation = False
                        Dg.CurrentRow.ErrorText = ""
                        Dg.Rows.Remove(Dg.CurrentRow)
                    Case EditSwitch
                        Dim Restoration
                        If SysSettings.ConnectionType = "OLEDB" Then
                            Restoration = New CLS_OLE_DB
                            Restoration.connection = OLEDBCONX
                        Else
                            Restoration = New CLS_SQL_DB
                            Restoration.connection = SQLCONX
                        End If

                        With Restoration
                            .source = "Select * from Comm_tbl where Commid = " & Trim(Dg.CurrentRow.Cells(Col_Id.Name).Value) & ""
                            .opensource()
                        End With

                        With Restoration.DATAREADER
                            .Read()
                            Dim Rw As DataGridViewRow = Dg.CurrentRow
                            If IsDBNull(.Item("CommCode")) Then Rw.Cells(Col_Code.Name).Value = "" Else Rw.Cells(Col_Code.Name).Value = Trim(.Item("CommCode").ToString)
                            If IsDBNull(.Item("CommDesc")) Then Rw.Cells(Col_Desc.Name).Value = "" Else Rw.Cells(Col_Desc.Name).Value = Trim(.Item("CommDesc").ToString)
                            If IsDBNull(.Item("Pricing")) Then Rw.Cells(Col_Pricing.Name).Value = "0.00" Else Rw.Cells(Col_Pricing.Name).Value = FormatNumber(Trim(.Item("Pricing")), 2, TriState.True, TriState.True, TriState.True)
                            If IsDBNull(.Item("Active")) Then Rw.Cells(Col_active.Name).Value = False Else Rw.Cells(Col_active.Name).Value = CBool(Trim(.Item("Active").ToString))
                            .Close()
                        End With

                        Dg.CurrentRow.ErrorText = Nothing

                        BeginEdit = False
                        EditSwitch = False
                        Dg.CancelEdit()
                End Select
            End If
        Catch ex As Exception
            Dim CL As New CLS_LOG
            With CL
                .User = FrmLogin.UserDisplayName
                .LogError = ex.Message
                .LogLocation = "Commodity Maintenance Window"
                .Remarks = "An error encountered while refreshing entry"
                .CreateErrorLog()
            End With
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    Private Sub Dg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dg.Click
        If Dg.Rows(Dg.Rows.Count - 1).IsNewRow Then
            LblRecord.Text = Dg.CurrentRow.Index + 1 & " OF " & Dg.Rows.Count - 1
        Else
            LblRecord.Text = Dg.CurrentRow.Index + 1 & " OF " & Dg.Rows.Count
        End If

        'If Dg.CurrentRow.IsNewRow Then
        '    LblRecord.Text = "-- Of --"
        'End If


    End Sub

    Private Sub Dg_EditingControlShowing(ByVal sender As Object, _
                                                    ByVal e As DataGridViewEditingControlShowingEventArgs) Handles Dg.EditingControlShowing
        With DirectCast(e.Control, TextBox)
            'If Me.Dg.CurrentCellAddress.X = 1 Then
            .CharacterCasing = CharacterCasing.Upper
            'Else
            '    .CharacterCasing = CharacterCasing.Normal
            'End If
        End With
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Dg_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg.CellContentClick

    End Sub
End Class