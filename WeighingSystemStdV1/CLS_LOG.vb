Imports System.IO
Public Module LOGS
    Public UserLogPath As String = "C:\TRILog\UserLog.txt"
    Public ErrorLogPath As String = "C:\TRILog\ErrLog.txt"

End Module
Public Class CLS_LOG

    Private HeaderLabel As String


    Private Datetime As String

    Private _LOGACTIVITY As String
    Private _LOGSUMMARY As String
    Private _LOGLOCATION As String
    Private _USER As String
    Private _REMARKS As String
    Private _ERRORLOG As String


    Public Property LogError As String
        Get
            Return _ERRORLOG
        End Get
        Set(ByVal value As String)
            _ERRORLOG = value
        End Set
    End Property

    Public Property LogActivity As String
        Get
            Return _LOGACTIVITY
        End Get
        Set(ByVal value As String)
            _LOGACTIVITY = value
        End Set
    End Property

    Public Property LogSummary As String
        Get
            Return _LOGSUMMARY
        End Get
        Set(ByVal value As String)
            _LOGSUMMARY = value
        End Set
    End Property

    Public Property LogLocation As String
        Get
            Return _LOGLOCATION
        End Get
        Set(ByVal value As String)
            _LOGLOCATION = value
        End Set
    End Property

    Public Property User As String
        Get
            Return _USER
        End Get
        Set(ByVal value As String)
            _USER = value
        End Set
    End Property

    Public Property Remarks As String
        Get
            Return _REMARKS
        End Get
        Set(ByVal value As String)
            _REMARKS = value
        End Set
    End Property

    Public Sub CreateUserLog()
        Try
            Dim Lg As System.IO.TextWriter = Nothing
            '   Dim ss As String = Mid(UserLogPath, 1, UserLogPath.Length - 11)
            If IO.File.Exists(UserLogPath) = False Then

                System.IO.Directory.CreateDirectory(Mid(UserLogPath, 1, UserLogPath.Length - 11))
                SetAttr(Mid(UserLogPath, 1, UserLogPath.Length - 11), FileAttribute.Hidden)
                Lg = System.IO.File.CreateText(UserLogPath)
            Else
                Lg = File.AppendText(UserLogPath)
            End If

            Datetime = Format(Now, "MM-dd-yyyy hh:mm tt")

            _USER = Replace(_USER, "&&", " ")
            _LOGACTIVITY = Replace(_LOGACTIVITY, "&&", " ")
            _LOGLOCATION = Replace(_LOGLOCATION, "&&", " ")
            _REMARKS = Replace(_REMARKS, "&&", " ")

            Dim Rw As String = ""
            Rw = Rw & _USER & "&&" & _LOGACTIVITY & "&&" & _LOGLOCATION & "&&" & Format(Now, "MM-dd-yyyy hh:mm tt") & "&&" & _REMARKS

            Lg.WriteLine(Rw)
            Lg.Flush()
            Lg.Close()
        Catch ex As Exception
            Throw New Exception(HideLogPathInError(ex.Message), ex)
        End Try
    End Sub

    Public Sub CreateErrorLog()
        Try
            Dim Lg As System.IO.TextWriter = Nothing

            If IO.File.Exists(ErrorLogPath) = False Then

                System.IO.Directory.CreateDirectory(Mid(UserLogPath, 1, UserLogPath.Length - 11))
                SetAttr(Mid(ErrorLogPath, 1, ErrorLogPath.Length - 11), FileAttribute.Hidden)
                Lg = System.IO.File.CreateText(ErrorLogPath)
            Else
                Lg = File.AppendText(ErrorLogPath)
            End If

            Datetime = Format(Now, "MM-dd-yyyy hh:mm tt")
            If _ERRORLOG = Nothing Then
                _ERRORLOG = "Unknown Error"
            Else
                _ERRORLOG = Replace(_ERRORLOG, "&&", " ")
                _ERRORLOG = _ERRORLOG.Replace(vbCrLf, " ")
            End If

            _LOGLOCATION = Replace(_LOGLOCATION, "&&", " ")
            _USER = Replace(_USER, "&&", " ")
            _REMARKS = Replace(_REMARKS, "&&", " ")

            Dim Rw As String = ""
            Rw = _ERRORLOG & "&&" & _LOGLOCATION & "&&" & Format(Now, "MM-dd-yyyy hh:mm tt") & "&&" & _USER & "&&" & _REMARKS

            Lg.WriteLine(Rw)
            Lg.Flush()
            Lg.Close()
        Catch ex As Exception
            Throw New Exception(HideLogPathInError(ex.Message), ex)
        End Try
    End Sub

    Public Sub ViewUserLog(ByVal dg As DataGridView, _
                       ByVal UserFilter As String, ByVal ActFilter As String, _
                       ByVal LocFilter As String, ByVal DTFFilter As String, ByVal DTTFilter As String)
        Try
            If File.Exists(UserLogPath) = False Then Exit Sub

            Dim Txt As New TextBox
            Dim TR As System.IO.TextReader = Nothing

            TR = File.OpenText(UserLogPath)

            While TR.Peek >= 0
                Txt.Text = TR.ReadToEnd
            End While
            TR.Close()

            Dim UserMatched As Boolean = True
            Dim ActMatched As Boolean = True
            Dim LocMatched As Boolean = True
            Dim DTMatched As Boolean = True

            Dim LnNum As Integer = 0
            Dim Rw() As String
            For Each Str As String In Txt.Lines
                If Str.Length.Equals(0) = False Then
                    Rw = Split(Str, "&&")
                    If String.IsNullOrEmpty(UserFilter) = False Then
                        If Rw(0).ToUpper = UserFilter.ToUpper Then
                            UserMatched = True
                        Else
                            UserMatched = False
                        End If
                    Else
                        UserMatched = True
                    End If

                    If String.IsNullOrEmpty(ActFilter) = False Then
                        If ActFilter = "..." = False Then
                            If Rw(1).ToUpper = ActFilter.ToUpper Then
                                ActMatched = True
                            Else
                                ActMatched = False
                            End If
                        Else
                            ActMatched = True
                        End If
                    Else
                        ActMatched = True
                    End If


                    If String.IsNullOrEmpty(LocFilter) = False Then
                        If LocFilter = "..." = False Then
                            If Rw(2).ToUpper = LocFilter.ToUpper Then
                                LocMatched = True
                            Else
                                LocMatched = False
                            End If
                        Else
                            LocMatched = True
                        End If
                    Else
                        LocMatched = True
                    End If

                    Dim DTFF As String = ""
                    If String.IsNullOrEmpty(DTFFilter) = False Then


                        Dim DTF As String = GetNumericChar(DTFFilter)
                        Dim DTT As String = GetNumericChar(DTTFilter)
                        Dim RWDTVAL As String = GetNumericChar(Rw(3))

                        If DTF > DTT Then
                            MessageBox.Show("Invalid Date filter.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        End If

                        If Val(RWDTVAL) >= Val(DTF) Then
                            If Val(RWDTVAL) <= (DTT) Then
                                DTMatched = True
                            Else
                                DTMatched = False
                            End If
                        Else
                            DTMatched = False
                        End If
                    Else
                        DTMatched = True
                    End If

                    If UserMatched = True Then
                        If ActMatched = True Then
                            If LocMatched = True Then
                                If DTMatched = True Then
                                    dg.Rows.Add(Rw)
                                End If
                            End If
                        End If
                    End If

                End If
            Next

        Catch ex As Exception
            Throw New Exception(HideLogPathInError(ex.Message), ex)
        End Try
    End Sub

    Private Function GetNumericChar(ByVal STr As String) As String
        Dim ReturnedVal As String = ""
        For Each cr As Char In STr
            If IsNumeric(cr) Then
                ReturnedVal = ReturnedVal & cr
            End If
        Next
        Return ReturnedVal
    End Function
    Public Sub ViewErrorLog(ByVal dg As DataGridView, _
                     ByVal UserFilter As String, _
                     ByVal LocFilter As String, ByVal DTFFilter As String, ByVal DTTFilter As String)
        Try
            If File.Exists(ErrorLogPath) = False Then Exit Sub

            Dim Txt As New TextBox
            Dim TR As System.IO.TextReader = Nothing

            TR = File.OpenText(ErrorLogPath)
            While TR.Peek >= 0
                Txt.Text = TR.ReadToEnd
            End While
            TR.Close()


            Dim UserMatched As Boolean = True
            Dim ActMatched As Boolean = True
            Dim LocMatched As Boolean = True
            Dim DTMatched As Boolean = True

            Dim LnNum As Integer = 0
            Dim Rw() As String
            For Each Str As String In Txt.Lines
                If Str.Length.Equals(0) = False Then
                    Rw = Split(Str, "&&")
                    If String.IsNullOrEmpty(UserFilter) = False Then
                        If Rw(3).ToUpper = UserFilter.ToUpper Then
                            UserMatched = True
                        Else
                            UserMatched = False
                        End If
                    Else
                        UserMatched = True
                    End If


                    If String.IsNullOrEmpty(LocFilter) = False Then
                        If LocFilter = "..." = False Then
                            If Rw(1).ToUpper = LocFilter.ToUpper Then
                                LocMatched = True
                            Else
                                LocMatched = False
                            End If
                        Else
                            LocMatched = True
                        End If
                    Else
                        LocMatched = True
                    End If


                    Dim DTF As String = GetNumericChar(DTFFilter)
                    Dim DTT As String = GetNumericChar(DTTFilter)
                    Dim RWDTVAL As String = GetNumericChar(Rw(2))

                    If DTF > DTT Then
                        MessageBox.Show("Invalid Date filter.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Exit Sub
                    End If

                    If Val(RWDTVAL) >= Val(DTF) Then
                        If Val(RWDTVAL) <= (DTT) Then
                            DTMatched = True
                        Else
                            DTMatched = False
                        End If
                    Else
                        DTMatched = False
                    End If


                    If UserMatched = True Then
                        If LocMatched = True Then
                            If DTMatched = True Then
                                dg.Rows.Add(Rw)
                            End If
                        End If
                    End If
                End If
            Next



        Catch ex As Exception
            Throw New Exception(HideLogPathInError(ex.Message), ex)
        End Try
    End Sub

    Private Function HideLogPathInError(ByVal Newerror As String) As String
        Dim ReturmedError As String = ""
        Dim LgPath As String = (Mid(UserLogPath, 1, UserLogPath.Length - 11))

        Select Case True
            Case Newerror.Contains(LgPath)
                ReturmedError = Replace(Newerror, LgPath, "P***")
            Case Newerror.Contains(UserLogPath)
                ReturmedError = Replace(Newerror, UserLogPath, "U***")
            Case Newerror.Contains(ErrorLogPath)
                ReturmedError = Replace(Newerror, ErrorLogPath, "E***")
            Case Else
                ReturmedError = Newerror
        End Select

        Return ReturmedError
    End Function

    Public Sub ClearFilteredLogs(ByVal dg As DataGridView, _
                          ByVal UserFilter As String, ByVal ActFilter As String, _
                          ByVal LocFilter As String, ByVal DTFFilter As String, ByVal DTTFilter As String)
        Try
            If File.Exists(UserLogPath) = False Then Exit Sub

            Dim Txt As New TextBox
            Dim TR As System.IO.TextReader = Nothing

            TR = File.OpenText(UserLogPath)

            While TR.Peek >= 0
                Txt.Text = TR.ReadToEnd
            End While
            TR.Close()

            Dim UserMatched As Boolean = True
            Dim ActMatched As Boolean = True
            Dim LocMatched As Boolean = True
            Dim DTMatched As Boolean = True

            Dim LnNum As Integer = 0
            Dim Rw() As String
            For Each Str As String In Txt.Lines
                If Str.Length.Equals(0) = False Then
                    Rw = Split(Str, "&&")
                    If String.IsNullOrEmpty(UserFilter) = False Then
                        If Rw(0).ToUpper = UserFilter.ToUpper Then
                            UserMatched = True
                        Else
                            UserMatched = False
                        End If
                    Else
                        UserMatched = True
                    End If

                    If String.IsNullOrEmpty(ActFilter) = False Then
                        If ActFilter = "..." = False Then
                            If Rw(1).ToUpper = ActFilter.ToUpper Then
                                ActMatched = True
                            Else
                                ActMatched = False
                            End If
                        Else
                            ActMatched = True
                        End If
                    Else
                        ActMatched = True
                    End If


                    If String.IsNullOrEmpty(LocFilter) = False Then
                        If LocFilter = "..." = False Then
                            If Rw(2).ToUpper = LocFilter.ToUpper Then
                                LocMatched = True
                            Else
                                LocMatched = False
                            End If
                        Else
                            LocMatched = True
                        End If
                    Else
                        LocMatched = True
                    End If

                    Dim DTFF As String = ""
                    If String.IsNullOrEmpty(DTFFilter) = False Then


                        Dim DTF As String = GetNumericChar(DTFFilter)
                        Dim DTT As String = GetNumericChar(DTTFilter)
                        Dim RWDTVAL As String = GetNumericChar(Rw(3))

                        If DTF > DTT Then
                            MessageBox.Show("Invalid Date filter.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        End If

                        If Val(RWDTVAL) >= Val(DTF) Then
                            If Val(RWDTVAL) <= (DTT) Then
                                DTMatched = True
                            Else
                                DTMatched = False
                            End If
                        Else
                            DTMatched = False
                        End If
                    Else
                        DTMatched = True
                    End If

                    If UserMatched = True Then
                        If ActMatched = True Then
                            If LocMatched = True Then
                                If DTMatched = True Then
                                    dg.Rows.Add(Rw)
                                End If
                            End If
                        End If
                    End If
                End If
            Next

        Catch ex As Exception
            Throw New Exception(HideLogPathInError(ex.Message), ex)
        End Try
    End Sub

End Class
