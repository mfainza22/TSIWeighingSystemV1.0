Public Class CLS_DATAGRID

    Public Sub SearchGrid(ByVal DG As DataGridView, ByVal Text As String, ByVal Cell As Integer)
        On Error Resume Next
        Dim ColVal As String = Nothing
        Dim IntCount As Integer = 0
        For Each row As DataGridViewRow In DG.Rows
            If row.IsNewRow = False Then
                ColVal = (DG.Rows(IntCount).Cells(Cell).Value).ToString()
                If ColVal.Contains(Text) Then
                    DG.Rows(IntCount).Selected = True
                    DG.FirstDisplayedScrollingRowIndex = IntCount
                    DG.CurrentCell = DG.Rows.Item(IntCount).Cells(Cell)

                    Exit Sub
                End If
                IntCount = IntCount + 1
            End If
        Next
    End Sub

    Public Sub RefreshAutoCompleteSource(ByVal Dg As DataGridView, ByVal ColNum As Integer, ByRef Ctr As Control)
        Select Case True
            Case TypeOf (Ctr) Is ComboBox
                Dim Ctrl As New ComboBox
                Ctrl.Items.Clear()

                For i = 0 To Dg.Rows.Count - 1
                    Ctrl.Items.Add(Dg.Rows(i).Cells(ColNum).Value)
                Next
            Case TypeOf (Ctr) Is TextBox
                Dim Ctrl As New TextBox
                Ctrl.AutoCompleteCustomSource.Clear()

                For i = 0 To Dg.Rows.Count - 1
                    Ctrl.AutoCompleteCustomSource.Add(Dg.Rows(i).Cells(ColNum).Value)
                Next
        End Select
    End Sub

End Class
