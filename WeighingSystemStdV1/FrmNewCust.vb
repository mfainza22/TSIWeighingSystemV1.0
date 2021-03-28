Public Class FrmNewCust
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
        Dim errortext As String = ""
        Dim SysSettings As New settings
        SysSettings.Load()
        Dim Validator As New CLS_CONTROLTOGGLES
        If Validator.ValidChars(Me) = False Then
            errortext = "Using of quote/s is invalid"
            MessageBox.Show(errortext, "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        Select Case FrmTrans.RdoCust.Checked
            Case True
                Dim Cellvalue As String
                Cellvalue = Trim(TxtCode.Text)
                If String.IsNullOrEmpty(Cellvalue) Then
                    errortext = errortext & Environment.NewLine & "Code is required."
                Else
                    Select Case True
                        Case Addswitch
                            If MOD_DATABASEPROC.ExistenceFound("Select * from Cust_tbl where CustCode = '" & Trim(Cellvalue) & "'", Nothing, Nothing, Nothing) Then
                                errortext = errortext & Environment.NewLine & "* Specified Code is already in the database."
                            End If
                    End Select
                End If

                Cellvalue = Trim(TxtName.Text)
                If String.IsNullOrEmpty(Trim(Cellvalue)) Then
                    errortext = errortext & Environment.NewLine & "Customer name is required."
                Else
                    Select Case True
                        Case Addswitch
                            If MOD_DATABASEPROC.ExistenceFound("Select * from cust_tbl where Custname = '" & Trim(Cellvalue) & "'", Nothing, Nothing, Nothing) Then
                                errortext = errortext & Environment.NewLine & "Specified name is already in the database."
                            End If
                    End Select
                End If

            Case False
                Dim Cellvalue As String
                Cellvalue = Trim(TxtCode.Text)
                If String.IsNullOrEmpty(Cellvalue) Then
                    errortext = errortext & Environment.NewLine & "Code is required."
                Else
                    Select Case True
                        Case Addswitch
                            If MOD_DATABASEPROC.ExistenceFound("Select * from Sup_tbl where SupCode = '" & Trim(Cellvalue) & "'", Nothing, Nothing, Nothing) Then
                                errortext = errortext & Environment.NewLine & "Specified Code is already in the database."
                            End If
                    End Select
                End If

                Cellvalue = Trim(TxtName.Text)
                If String.IsNullOrEmpty(Trim(Cellvalue)) Then
                    errortext = errortext & Environment.NewLine & "Supplier name is required."
                Else
                    Select Case True
                        Case Addswitch
                            If MOD_DATABASEPROC.ExistenceFound("Select * from Sup_tbl where Supname = '" & Trim(Cellvalue) & "'", Nothing, Nothing, Nothing) Then
                                errortext = errortext & Environment.NewLine & "Specified name is already in the database."
                            End If
                    End Select
                End If
        End Select

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
     
        Select Case True
            Case FrmTrans.RdoCust.Checked
                With Saver
                    Saver.Table = "Cust_tbl"
                    Saver.Source = "Insert into " & Saver.Table & " (CustCode,CustName,CustAddr,CActive) values (" & _
                        "'" & Trim(TxtCode.Text) & "'" & _
                          ",'" & Trim(TxtName.Text) & "'" & _
                           ",'" & Trim(TxtAddress.Text) & "'" & _
                         "," & True & ")"
                    Saver.ExecuteCommand()
                    Saver.Cmd.Dispose()
                End With
                FrmTrans.CustList.Add(TxtName.Text)
                FrmTrans.CboClient.Items.Clear()
                MOD_DATABASEPROC.ThrowArrayToControl(FrmTrans.CboClient, FrmTrans.CustList)
            Case FrmTrans.RdoSup.Checked
                With Saver
                    Saver.Table = "Sup_tbl"
                    Saver.Source = "Insert into " & Saver.Table & " (SupCode,SupName,SupAddr,SActive) values (" & _
                        "'" & Trim(TxtCode.Text) & "'" & _
                          ",'" & Trim(TxtName.Text) & "'" & _
                           ",'" & Trim(TxtAddress.Text) & "'" & _
                         "," & True & ")"
                    Saver.ExecuteCommand()
                    Saver.Cmd.Dispose()
                End With
                FrmTrans.SupList.Add(TxtName.Text)
                FrmTrans.CboClient.Items.Clear()
                MOD_DATABASEPROC.ThrowArrayToControl(FrmTrans.CboClient, FrmTrans.SupList)
        End Select

        FrmTrans.CboClient.Text = Trim(TxtName.Text)
        FrmTrans.TxtAddress.Text = Trim(TxtAddress.Text)
        MessageBox.Show("Adding Successful. Press any key to close", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Dispose()
    End Sub

    Private Sub Btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncancel.Click
        Me.Close()
    End Sub

    Private Sub FrmNewCust_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class