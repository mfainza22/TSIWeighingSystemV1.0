Module MOD_MAINFORMPROC
    Public Sub SetFormSize(ByVal Frm As Form)
        Frm.Left = 0
        Frm.Top = 0
        Frm.Height = Screen.PrimaryScreen.WorkingArea.Height + (Screen.PrimaryScreen.WorkingArea.Height * 0.055)
        Frm.Width = (Screen.PrimaryScreen.WorkingArea.Width)
        Frm.Size = SystemInformation.PrimaryMonitorSize
        Frm.StartPosition = FormStartPosition.CenterScreen
        '  Me.BackgroundImage = My.Resources.uppc_main_bg
        Frm.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Public Sub GetSystemUserData(ByRef USERTEXT As String, ByRef IDTEXT As String, ByRef CONNTYPETEXT As String)
        Dim SysSettings As New settings
        SysSettings.Load()
        USERTEXT = FrmLogin.UserDisplayName
        IDTEXT = FrmLogin.UserId
        Select Case SysSettings.ConnectionType
            Case "OLEDB"
                CONNTYPETEXT = "ACCESS DATABASE"
            Case "SQL"
                CONNTYPETEXT = SysSettings.sql_server_name
        End Select
    End Sub

    Private _TIMER_LABEL As Control
    Public Property TIMER_LABEL As Control
        Get
            Return _TIMER_LABEL
        End Get
        Set(ByVal value As Control)
            _TIMER_LABEL = value
        End Set
    End Property

    Public Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetDateTime()
    End Sub

    Public Sub SetDateTime()

        Dim Datetime As Date
        Datetime = Now
        FormatDateTime(Datetime, DateFormat.LongTime)
        Dim Hr As String = String.Format("{0:00}", Format(Now, "hh"))
        Dim Min As String = String.Format("{0:00}", Minute(Now))
        Dim Sec As String = String.Format("{0:00}", Second(Now))

        Dim Month As String = Format(Now, "MMM")
        Dim Yr As String = Year(Now)
        Dim DDay As String = Format(Now, "dd")
        Dim tt As String = Format(Now, "tt")

        Select Case True
            Case TypeOf _TIMER_LABEL Is TextBox
            Case TypeOf _TIMER_LABEL Is Label
                _TIMER_LABEL.Text = Month & "  " & DDay & " , " & Yr & "       " & Hr & ":" & Min & ":" & Sec & "  " & tt
        End Select
    End Sub



#Region "NAVIGATION PROCEDURE"
    Public Sub OpenMainBUtton(ByVal Acs As String, ByRef Window As Control, ByRef PB As Control, ByRef MAINFORM As Form)
        Try
            Select Case True
                Case TypeOf (Window) Is Panel
                    Dim Pnl As Panel = Window

                    Pnl.Height = 0
                    For Each BTNS As MykeCtrlEx.PushButton In Pnl.Controls.OfType(Of MykeCtrlEx.PushButton)()
                        Pnl.Height += BTNS.Height
                    Next

                    Dim BTNX As MykeCtrlEx.PushButton = PB
                    If Pnl.Visible = True Then
                        BTNX.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Down16
                        Pnl.Visible = False
                    Else
                        BTNX.GUI_ICONS = MykeCtrlEx.PushButton.Icons.Up16
                        Pnl.Visible = True
                    End If

                Case TypeOf (Window) Is Form
                    If Acs = "N/A" Then
                        MDIMAIN.Pnl_MainBtn.Visible = True
                        MessageBox.Show("You do not have access to open this window.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    If Window.Name <> FrmEditTrans.Name Then
                        If MDIMAIN.HasChildren Then
                            For Each frm As Form In MDIMAIN.MdiChildren
                                frm.Close()
                                frm.Dispose()
                                CLS_CLEARMEM.ClearMem(New Object() {frm})
                            Next
                        End If
                    End If
                    Dim windows As Form = Window
                    If windows.Visible = True Then
                        windows.Focus()
                    Else
                        Try
                            With windows
                                .TopLevel = False
                                .MdiParent = MAINFORM
                                .StartPosition = FormStartPosition.Manual
                                Select Case Window.Name.ToUpper
                                    Case "Frmssystemsettings".ToUpper
                                    Case Else
                                        .Dock = DockStyle.Fill
                                End Select
                                .Show()
                            End With
                        Catch
                        End Try
                    End If
            End Select

        Catch ex As Exception
            Dim CL As New CLS_LOG
            With CL
                .User = FrmLogin.UserDisplayName
                .LogError = ex.Message
                .LogLocation = "Main Window"
                .CreateErrorLog()
            End With
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
End Module
