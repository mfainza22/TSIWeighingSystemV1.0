Public Class FrmnewComm
    Private Addswitch As Boolean = True

    Private Sub FrmProducts_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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
            End Select
        Else
            Select Case e.KeyCode
                Case Keys.Escape
                    Btncancel_Click(sender, e)
            End Select
        End If
    End Sub


    Private Sub Btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsave.Click
        Dim SysSettings As New settings
        SysSettings.Load()
        Dim errortext As String = ""

        Dim Validator As New CLS_CONTROLTOGGLES
        If Validator.ValidChars(Me) = False Then
            errortext = "Using of quote/s is invalid"
            MessageBox.Show(errortext, "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        Dim Cellvalue As String
        Cellvalue = TxtCode.Text
        If String.IsNullOrEmpty(Cellvalue) Then
            errortext = errortext & Environment.NewLine & "Commodity Code is required."
        Else
            Select Case True
                Case Addswitch
                    If MOD_DATABASEPROC.ExistenceFound("Select * from Comm_tbl where CommCode = '" & Trim(Cellvalue) & "'", Nothing, Nothing, Nothing) Then
                        errortext = errortext & Environment.NewLine & "Specified Code is already in the database."
                    End If
            End Select
        End If


        Cellvalue = TxtName.Text
        If String.IsNullOrEmpty(Trim(Cellvalue)) Then
            errortext = errortext & Environment.NewLine & "Commodity Description is required."
        Else
            Select Case True
                Case Addswitch
                    If MOD_DATABASEPROC.ExistenceFound("Select * from Comm_tbl where CommDesc = '" & Trim(Cellvalue) & "'", Nothing, Nothing, Nothing) Then
                        errortext = errortext & Environment.NewLine & "Specified Descrition is already in the database."
                    End If
            End Select
        End If

        Dim pricing As String = _
    Replace(TxtPrice.Text, ",", "")
        If String.IsNullOrEmpty(pricing) Then pricing = 0.0
        If IsNumeric(pricing) = False Then
            errortext = errortext & Environment.NewLine & "Price should be numeric."
        End If


        If String.IsNullOrEmpty(errortext) = False Then
            MessageBox.Show(errortext, "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        Dim Saver As New Object
        If SysSettings.ConnectionType = "OLEDB" Then
            Saver = New CLS_OLE_DB
            Saver.connection = OLEDBCONX
        End If

        If SysSettings.ConnectionType = "SQL" Then
            Saver = New CLS_SQL_DB
            Saver.connection = SQLCONX
        End If


        With Saver
            Saver.Table = "Comm_tbl"
            Saver.Source = "Insert into " & Saver.Table & " (CommCode,CommDesc,Pricing,Active) values (" & _
                        "'" & Trim(TxtCode.Text) & "'" & _
                          ",'" & Trim(TxtName.Text) & "'" & _
                             ",'" & pricing & "'" & _
                         "," & True & ")"
            Saver.ExecuteCommand()
            Saver.Cmd.Dispose()
        End With

        FrmTrans.CommList.Add(Trim(TxtName.Text))
        FrmTrans.CboCommodity.Items.Clear()
        MOD_DATABASEPROC.ThrowArrayToControl(FrmTrans.CboCommodity, FrmTrans.CommList)
        FrmTrans.CboCommodity.Text = Trim(TxtName.Text)
        FrmTrans.TxtPrice.Text = TxtPrice.Text
        MessageBox.Show("Adding Successful. Press any key to close", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Dispose()
    End Sub

    Private Sub Btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncancel.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class