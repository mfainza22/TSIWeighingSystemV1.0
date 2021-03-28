Public Class FrmConnProgress
    Public Timer As Timer
    Public ConnStat As Boolean = Nothing
    Public ConnErrorMessage As String


    Private Sub FrmConnProgress_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If FrmLogin.Opening = True Then
            If MOD_SERVER.SQLCONX.State = ConnectionState.Connecting = True Then
                If FrmLogin.Opening = True Then
                    FrmLogin.Dispose()
                End If

            End If
        End If


    End Sub



    Private SysSettings As settings
    Private Sub FrmConnProgress_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' BgWrker_DoWork(sender, Nothing)
        SysSettings = New settings
        SysSettings.Load()
        BgWrker.RunWorkerAsync()
        BgWrker.ReportProgress(100)

        Timer = New Timer
        Timer.Interval = 643

        Me.UseWaitCursor = True

        AddHandler Timer.Tick, AddressOf TM_Tick
        Timer.Start()

        BgWrker_DoWork(sender, Nothing)

    End Sub

    Private Sub TM_Tick()
        If SysSettings.ConnectionType = "OLEDB" Then
            Select Case MOD_SERVER.OLEDBCONX.State
                Case ConnectionState.Connecting
                    Select Case LblThread.Text
                        Case "."
                            LblThread.Text = ".."
                        Case ".."
                            LblThread.Text = "..."
                        Case "..."
                            LblThread.Text = "...."
                        Case "...."
                            LblThread.Text = "."
                    End Select

                Case ConnectionState.Open
                    ConnStat = True
                    ConnErrorMessage = Nothing
                    Timer.Stop()
                    Me.Close()
                Case ConnectionState.Closed
                    Timer.Stop()
                    ConnStat = False
                    Me.Close()
            End Select
        Else
            Select Case MOD_SERVER.SQLCONX.State
                Case ConnectionState.Connecting
                    Select Case LblThread.Text
                        Case "."
                            LblThread.Text = ".."
                        Case ".."
                            LblThread.Text = "..."
                        Case "..."
                            LblThread.Text = "...."
                        Case "...."
                            LblThread.Text = "."
                    End Select

                Case ConnectionState.Open
                    ConnStat = True
                    ConnErrorMessage = Nothing
                    Timer.Stop()
                    Me.Close()
                Case ConnectionState.Closed
                    Timer.Stop()
                    ConnStat = False
                    Me.Close()
            End Select
        End If
       
    End Sub

    Private Sub BgWrker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgWrker.DoWork
        ConnectServer()
    End Sub


#Region "SERVER CONNECTION "
    ' Dim TRD As New System.Threading.Thread(AddressOf ConnectServer)

    Public ConnMsg As String
    Public cONNpROGRESS As Integer

    Private Sub ConnectServer()

        Try
            Select Case SysSettings.ConnectionType
                Case "OLEDB"
                    Dim CLSOLE As New CLS_SERVERPROC

                    With CLSOLE
                        '  .Server = SysSettings.sql_server_name
                        .DatabaseName = SysSettings.access_file_path
                        '.Uid = SysSettings.sql_server_nameUid
                        .Password = SysSettings.access_pwd
                        .ConnectionType = SysSettings.ConnectionType
                        .OleDbConn = MOD_SERVER.OLEDBCONX
                        If .Connect_Server() = True Then
                            ConnStat = True
                        Else
                            ConnStat = False
                        End If
                    End With
                Case "SQL"
                    Dim CLSSQL As New CLS_SERVERPROC
                    With CLSSQL
                        .Server = SysSettings.sql_server_name
                        .DatabaseName = SysSettings.sql_server_catalog
                        .Uid = SysSettings.sql_server_uid
                        .Password = SysSettings.sql_server_pwd
                        .ConnectionType = SysSettings.ConnectionType
                        .SqlConn = MOD_SERVER.SQLCONX
                        If .Connect_Server() = True Then
                            ConnStat = True
                        Else
                            ConnStat = False
                        End If
                    End With
            End Select

        Catch ex As Exception
            ConnStat = False
            ConnErrorMessage = ex.Message
        End Try


    End Sub


#End Region


   
End Class