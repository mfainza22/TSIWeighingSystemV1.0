Public Class FrmLogs



    Private Sub FrmLogs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtELoc.SelectedIndex = 0
        TxtUACt.SelectedIndex = 0
        TxtULoc.SelectedIndex = 0

        Dim VL As New CLS_LOG

        DgUser.Rows.Clear()
        DgUser.Columns(Col_ULimg.Name).DisplayIndex = 0
        VL.ViewUserLog(DgUser, TxtUUser.Text, TxtUACt.Text, TxtULoc.Text, DTUFrom.Text, DTUTo.Text)
        For Each Rw As DataGridViewRow In DgUser.Rows
            Rw.Cells(Col_ULimg.Name).Value = My.Resources.Warning_20px
        Next

        DgError.Rows.Clear()
        DgError.Columns(Col_ELImg.Name).DisplayIndex = 0
        VL.ViewErrorLog(DgError, TxtUUser.Text, TxtULoc.Text, DTEFrom.Text, DTETo.Text)
        For Each Rw As DataGridViewRow In DgError.Rows
            Rw.Cells(Col_ELImg.Name).Value = My.Resources.Warning_20px
        Next
    End Sub



    Private Sub BtnGen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUGen.Click
        Dim VL As New CLS_LOG

        DgUser.Rows.Clear()
        DgUser.Columns(Col_ULimg.Name).DisplayIndex = 0
        VL.ViewUserLog(DgUser, TxtUUser.Text, TxtUACt.Text, TxtULoc.Text, DTUFrom.Text, DTUTo.Text)
        For Each Rw As DataGridViewRow In DgUser.Rows
            Rw.Cells(Col_ULimg.Name).Value = My.Resources.Warning_20px
        Next
    End Sub

    Private Sub BtnEGen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEGen.Click
        Dim VL As New CLS_LOG

        DgError.Rows.Clear()
        DgError.Columns(Col_ELImg.Name).DisplayIndex = 0
        VL.ViewErrorLog(DgError, TxtEUser.Text, TxtELoc.Text, DTEFrom.Text, DTETo.Text)
        For Each Rw As DataGridViewRow In DgError.Rows
            Rw.Cells(Col_ELImg.Name).Value = My.Resources.Warning_20px
        Next

    End Sub


    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnClearUserlogs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClearUserlogs.Click
        If MessageBox.Show("Are you sure you want to clear user logs?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then Exit Sub
        System.IO.File.Delete(UserLogPath)
        DgUser.Rows.Clear()
    End Sub

    Private Sub BtnClearLogs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnErrorClearLogs.Click
        If MessageBox.Show("Are you sure you want to clear Error logs?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then Exit Sub

        System.IO.File.Delete(ErrorLogPath)
        DgError.Rows.Clear()
    End Sub
End Class