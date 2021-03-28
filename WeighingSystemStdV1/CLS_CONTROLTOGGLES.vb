Public Class CLS_CONTROLTOGGLES
    Private _COLLECTED() As Control
    Private _COLLECTEDCTR As Integer

    Public ReadOnly Property CollectedControls() As Control
        Get
            Return _COLLECTED(_COLLECTEDCTR)
        End Get
    End Property


    Public Sub CollectControls(ByRef frm As Form, ByRef collected() As Control, ByRef collectedCtr As Integer)
        Dim Pnl As Panel = Nothing
        Dim PnlChild1 As Panel = Nothing
        Dim PnlChild2 As Panel = Nothing
        Dim PnlChild3 As Panel = Nothing
        Dim PnlChild4 As Panel = Nothing
        Dim PnlChild5 As Panel = Nothing

        For Each Pnl In frm.Controls.OfType(Of Panel)()
            For Each PnlChild1 In Pnl.Controls.OfType(Of Panel)()
                For Each PnlChild2 In PnlChild1.Controls.OfType(Of Panel)()
                    For Each PnlChild3 In PnlChild2.Controls.OfType(Of Panel)()
                        For Each PnlChild4 In PnlChild3.Controls.OfType(Of Panel)()
                            For Each PnlChild5 In PnlChild4.Controls.OfType(Of Panel)()
                                GetControls(PnlChild5, collected, collectedCtr)
                            Next
                            GetControls(PnlChild4, collected, collectedCtr)
                        Next
                        GetControls(PnlChild3, collected, collectedCtr)
                    Next
                    GetControls(PnlChild2, collected, collectedCtr)
                Next
                GetControls(PnlChild1, collected, collectedCtr)
            Next
            GetControls(Pnl, collected, collectedCtr)
        Next

        _COLLECTED = collected
        _COLLECTEDCTR = collectedCtr
    End Sub

    Private Sub GetControls(ByVal Pnl As Panel, ByRef Collected() As Control, ByRef CollectedCtr As Integer)
        For Each ctrl As Control In Pnl.Controls
            Select Case True
                Case (TypeOf ctrl Is Label)
                Case (TypeOf ctrl Is Button)
                Case (TypeOf ctrl Is TextBox)

                    Select Case ctrl.Name.ToLower
                        Case "txtOnline".ToLower
                        Case "txtOffline".ToLower
                        Case "txtunit".ToLower
                        Case "txtweightType".ToLower
                        Case Else
                            Collected(CollectedCtr) = ctrl
                            CollectedCtr += 1
                    End Select
                Case (TypeOf ctrl Is RadioButton)
                    Collected(CollectedCtr) = ctrl
                    CollectedCtr += 1
                Case (TypeOf ctrl Is CheckBox)
                    Collected(CollectedCtr) = ctrl
                    CollectedCtr += 1
                Case (TypeOf ctrl Is ComboBox)
                    Collected(CollectedCtr) = ctrl
                    CollectedCtr += 1
                Case (TypeOf ctrl Is ListBox)
                    Collected(CollectedCtr) = ctrl
                    CollectedCtr += 1
                Case (TypeOf ctrl Is DateTimePicker)
                    Collected(CollectedCtr) = ctrl
                    CollectedCtr += 1
            End Select
        Next
    End Sub

    Public Sub EnableDataControls(ByRef Frm As Form)
        Dim CollectedCtr As Integer = 0
        Dim Collected(1000) As Control
        CollectControls(Frm, Collected, CollectedCtr)
        For i = 0 To CollectedCtr - 1
            Collected(i).Enabled = True
        Next
    End Sub

    Public Sub DisableDataControls(ByRef Frm As Form)
        Dim CollectedCtr As Integer = 0
        Dim Collected(1000) As Control
        CollectControls(Frm, Collected, CollectedCtr)
        For i = 0 To CollectedCtr - 1
            Collected(i).Enabled = False
        Next
    End Sub

    Public Sub ClearDataControls(ByRef Frm As Form)

        Dim CollectedCtr As Integer = 0
        Dim Collected(1000) As Control
        CollectControls(Frm, Collected, CollectedCtr)
        Dim sss As Integer

        For i = 0 To CollectedCtr - 1
            sss = i
            Select Case True
                Case TypeOf (Collected(i)) Is Label
                Case TypeOf (Collected(i)) Is TextBox
                    Dim txt As TextBox = Collected(i)
                    txt.Text = ""
                Case TypeOf (Collected(i)) Is ComboBox
                    Dim Cbo As ComboBox = Collected(i)
                    If Cbo.DropDownStyle = ComboBoxStyle.DropDown Then
                        Cbo.Text = ""
                    Else
                        Cbo.SelectedIndex = -1
                    End If
                Case TypeOf (Collected(i)) Is RadioButton
                    Dim rdo As RadioButton = Collected(i)
                    rdo.Checked = False
                Case TypeOf (Collected(i)) Is CheckBox
                    Dim chk As CheckBox = Collected(i)
                    chk.Checked = False
                Case TypeOf (Collected(i)) Is DateTimePicker
                    Dim DTPicker As DateTimePicker = Collected(i)
                    DTPicker.Value = Now
            End Select

        Next


    End Sub

    Public Function ValidChars(ByVal frm As Form) As Boolean
        Dim Result As Boolean = True
        Dim CollectedCtr As Integer = 0
        Dim Collected(1000) As Control
        CollectControls(frm, Collected, CollectedCtr)

        For i = 0 To CollectedCtr - 1
            Select Case True

                Case TypeOf Collected(i) Is Label

                Case TypeOf Collected(i) Is TextBox

                    For ChrIdx = 1 To Len(Collected(i).Text)
                        If GetChar(Collected(i).Text, ChrIdx) = "'" Then
                            Result = False
                        End If

                        If GetChar(Collected(i).Text, ChrIdx) = "' '" Then
                            Result = False
                        End If
                    Next
                Case TypeOf Collected(i) Is ComboBox
                    For ChrIdx = 1 To Len(Collected(i).Text)
                        If GetChar(Collected(i).Text, ChrIdx) = "'" Then
                            Result = False
                        End If

                        If GetChar(Collected(i).Text, ChrIdx) = "' '" Then
                            Result = False
                        End If
                    Next

            End Select
        Next

        Return Result
    End Function

    Public Sub ChangeFontControls(ByRef Frm As Form)
        Dim FD As New FontDialog
        FD.ShowDialog()
        Dim CollectedCtr As Integer = 0
        Dim Collected(1000) As Control
        CollectControls(Frm, Collected, CollectedCtr)
        For i = 0 To CollectedCtr - 1
            Collected(i).Font = FD.Font
        Next
    End Sub

    Public Function DGRowValueisValid(ByVal rw As DataGridViewRow) As Boolean
        Dim InvalidCharsCtr As Boolean = True
        For Each cl As DataGridViewCell In rw.Cells

            If String.IsNullOrEmpty(cl.Value) = False Then
                For Chridx = 1 To Len(cl.Value.ToString)
                    Select Case GetChar(cl.Value, Chridx)
                        Case Is = "'"
                            InvalidCharsCtr = False
                        Case Is = """"
                            InvalidCharsCtr = False
                    End Select

                Next
            End If
        Next

        Return InvalidCharsCtr
    End Function
End Class
