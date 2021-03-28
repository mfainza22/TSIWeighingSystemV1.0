Public Class FrmTransOK
    Private _MSGSTR
    Public Property MsgSTr As String
        Get
            Return _MSGSTR
        End Get
        Set(ByVal value As String)
            _MSGSTR = value
        End Set
    End Property

    Private _ReceiptNo As String
    Public Property ReceiptNo As String
        Get
            Return _ReceiptNo
        End Get
        Set(ByVal value As String)
            _ReceiptNo = value
        End Set
    End Property
    Private Sub FrmTransOK_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub FrmTransOK_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Control = True Then Exit Sub
        If e.Shift = True Then Exit Sub
        If e.Alt = True Then Exit Sub

        Select Case e.KeyCode
            Case Keys.Enter
                Me.Close()
            Case Keys.Escape
                Me.Close()
            Case Else
                Me.Close()
        End Select
    End Sub
    Private Sub FrmTransOK_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Beep()
        Beep()

        TxtMsg.Text = _MSGSTR
        BtnClose.Focus()
    End Sub

    Private Sub BtnReprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReprint.Click
        Dim SysSettings As New settings
        SysSettings.Load()
        If SysSettings.WeighingType = "S" Then
            If MessageBox.Show("Continue re-printing of ticket?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then Exit Sub
            MOD_REPORTING.PrintToPrinter(Application.StartupPath & "\Reports\" & "TcktAll.rpt", "{OutBound_tbl.Refno} = '" & ReceiptNo & "'", Nothing, ReceiptNo)

            Exit Sub
        End If
        If SysSettings.EnablePrintOut = False Then Exit Sub

        Select Case True
            Case FrmTrans.WeighIn
                If SysSettings.PrintAll = False Then
                    If MessageBox.Show("Continue re-printing of ticket?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then Exit Sub
                    MOD_REPORTING.PrintToPrinter(Application.StartupPath & "\Reports\" & "TcktIN.rpt", "{OutBound_tbl.Refno} = '" & ReceiptNo & "'", Nothing, ReceiptNo)
                End If
            Case FrmTrans.Weighout
                If SysSettings.PrintAll = False Then
                    If MessageBox.Show("Continue re-printing of ticket?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then Exit Sub
                    MOD_REPORTING.PrintToPrinter(Application.StartupPath & "\Reports\" & "TcktOut.rpt", "{OutBound_tbl.Refno} = '" & FrmTrans.LastOutRefNo & "'", Nothing, FrmTrans.RefNO_Tmp)
                Else
                    MOD_REPORTING.PrintToPrinter(Application.StartupPath & "\Reports\" & "TcktInOutAll.rpt", "{OutBound_tbl.Refno} = '" & ReceiptNo & "'", Nothing, ReceiptNo)
                End If
        End Select
    End Sub


    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub PushButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclosing.Click
        Dim SysSettings As New settings
        SysSettings.Load()
        If SysSettings.WeighingType = "S" Then
            If MessageBox.Show("Continue re-printing of ticket?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then Exit Sub
            MOD_REPORTING.PrintToPrinter(Application.StartupPath & "\Reports\" & "TcktAll.rpt", "{OutBound_tbl.Refno} = '" & FrmTrans.LastOutRefNo & "'", Nothing)

            Exit Sub
        End If
        If SysSettings.EnablePrintOut = False Then Exit Sub

        If MessageBox.Show("Continue re-printing of ticket?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then Exit Sub
        MOD_REPORTING.PrintToPrinter(Application.StartupPath & "\Reports\" & "Tcktclosing.rpt", "{OutBound_tbl.Refno} = '" & FrmTrans.TxtRefNo.Text & "'", Nothing)

    End Sub
End Class