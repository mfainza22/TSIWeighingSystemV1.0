Imports System.Windows.Forms
Imports System.IO
Imports System.Threading

Public Class MDIMAIN



#Region "FORM ELEMENT"
#End Region

#Region "PROCEDURES"

    Private Sub SetFormSize()
        Me.Size = SystemInformation.PrimaryMonitorSize
        Me.StartPosition = FormStartPosition.CenterScreen
        '  Me.BackgroundImage = My.Resources.uppc_main_bg
        Me.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub GetSystemUserData()
        Dim SysSettings As New settings
        SysSettings.Load()
        LblName.Text = FrmLogin.UserDisplayName
        LblUserId.Text = FrmLogin.UserId
        Select Case SysSettings.ConnectionType
            Case "OLEDB"
                LblServer.Text = "ACCESS DATABASE"
            Case "SQL"
                LblServer.Text = SysSettings.sql_server_name
        End Select
    End Sub

#Region "STATUS OPERATION / TIME"
    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        SetDateTime()
    End Sub

    Private Sub SetDateTime()
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

        LblTimer.Text = Month & "  " & DDay & " , " & Yr & "       " & Hr & ":" & Min & ":" & Sec & "  " & tt
    End Sub


#End Region

#End Region


#Region "FORM PROCEDURES"
 
    Private Sub MDIMAIN_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim Logger As New CLS_LOG
        Logger.User = FrmLogin.UserDisplayName
        Logger.LogActivity = "Log-Out"
        Logger.LogLocation = "Main Window"
        Logger.CreateUserLog()
        If logoutonly = True Then

            FrmLogin.Visible = True
        Else
            FrmLogin.Dispose()
            Me.Dispose()
        End If
    End Sub
    Private Sub MDIMAIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            MOD_MAINFORMPROC.SetFormSize(Me)
            MOD_MAINFORMPROC.GetSystemUserData(LblName.Text, LblUserId.Text, LblServer.Text)
            LblH.Text = "Welcome |  " & FrmLogin.UserDisplayName

            AddHandler Timer.Tick, AddressOf MOD_MAINFORMPROC.Timer_Tick


            For Each Pnl As Panel In Pnl_MainBtn.Controls.OfType(Of Panel)()
                Pnl.Visible = False
            Next

        Catch ex As Exception
            Dim logger As New CLS_LOG
            logger.LogSummary = ex.Message
            logger.LogLocation = "Main Window"
            logger.User = FrmLogin.UserDisplayName
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

    Private Sub BtnOperation_OnButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnOperation.Click, _
        BtnTrans.Click, _
        BtnManagement.Click, _
        BtnDatabase.Click, _
        BtnCust.Click, _
        BtnSUp.Click, _
        BtnHauler.Click, _
        BtnMaterials.Click, _
        BtnTrucks.Click, _
        BtnDriver.Click, _
        BtnReports.Click, _
        BtnTransReport.Click, _
        BtnLogs.Click, _
        BtnAdmin.Click, _
        BtnUser.Click, _
        BtnSettings.Click, _
        BtnSystemSettings.Click


        Select Case sender.name
            Case BtnOperation.Name
                OpenMainBUtton(Nothing, PnlOperation, sender, Me)
            Case BtnTrans.Name
                Pnl_MainBtn.Visible = False
                OpenMainBUtton(FrmLogin.WeighingTransaction, FrmTrans, sender, Me)
            Case BtnManagement.Name
                Pnl_MainBtn.Visible = False
                OpenMainBUtton(FrmLogin.WeighingModule, FrmManagement, sender, Me)
            Case BtnDatabase.Name
                OpenMainBUtton(Nothing, PnlDatabase, sender, Me)
            Case BtnCust.Name
                OpenMainBUtton(FrmLogin.DBMaintenance, FrmCust, sender, Me)
            Case BtnSUp.Name
                OpenMainBUtton(FrmLogin.DBMaintenance, FrmSup, sender, Me)
            Case BtnHauler.Name
                OpenMainBUtton(FrmLogin.DBMaintenance, FrmHauler, sender, Me)
            Case BtnMaterials.Name
                OpenMainBUtton(FrmLogin.DBMaintenance, FrmCommodity, sender, Me)
            Case BtnTrucks.Name
                OpenMainBUtton(FrmLogin.DBMaintenance, Frmtrucks, sender, Me)
            Case BtnDriver.Name
                OpenMainBUtton(FrmLogin.DBMaintenance, FrmDrivers, sender, Me)
            Case BtnReports.Name
                OpenMainBUtton(Nothing, PnlReports, sender, Me)
            Case BtnTransReport.Name
                Pnl_MainBtn.Visible = False
                OpenMainBUtton(FrmLogin.SummaryReport, FrmReports, sender, Me)
            Case BtnLogs.Name
                OpenMainBUtton(FrmLogin.ViewLogs, FrmLogs, sender, Me)
            Case BtnAdmin.Name
                OpenMainBUtton(Nothing, PnlAdmin, sender, Me)
            Case BtnUser.Name
                OpenMainBUtton(FrmLogin.UserControl, FrmUsersAccounts, sender, Me)
            Case BtnSettings.Name
                OpenMainBUtton(Nothing, PnlUtilities, sender, Me)
            Case BtnSystemSettings.Name
                OpenMainBUtton(FrmLogin.Settings, FrmSystemSettings, sender, Me)
        End Select

    End Sub

    Private Sub BtnDB_OnButtonClick(ByVal sender As Object, ByVal e As System.EventArgs)
        OpenMainBUtton("Trans", PnlDatabase, sender, Me)
    End Sub

    Private Sub BtnMaintenance_OnButtonClick(ByVal sender As Object, ByVal e As System.EventArgs)
        ' OpenMainBUtton("Maintenance", Nothing, PnlMaintenance, BtnMaintenance)
    End Sub

    Private Sub BtnUtilities_OnButtonClick(ByVal sender As Object, ByVal e As System.EventArgs)
        '  OpenMainBUtton("Utilities", Nothing, PnlUtilities, BtnUtilities)
    End Sub

#Region "DATABASE BUTTONS"


#End Region

#Region "MAINTENANCE BUTTONS"
  
    Private Sub BtnUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OpenMainBUtton("", FrmUsersAccounts, BtnUser, Me)
    End Sub
#End Region

#Region "SERVER BUTTON ACCESS"
    Private Sub BtnSys_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        With FrmSystemSettings
            If .Visible = True Then
                .Focus()
            Else
                FrmSystemSettings = New FrmSystemSettings
                '   ViewForm("SystemSettings", "SS", Frmsystemsettings)
                FrmSystemSettings.ShowDialog()
            End If
        End With
    End Sub

#End Region

#Region "OPERAITON BUTTONS"

    Private Sub BtnOnline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Dim frmtransaction As New FrmTransaction2
        'With frmtransaction
        '    If .Visible = True Then
        '        .Focus()
        '    Else
        '        frmtransaction = New FrmTransaction2

        '        If Me.HasChildren Then
        '            For Each mdichld As Form In Me.MdiChildren
        '                mdichld.Close()
        '            Next
        '        End If
        '        .StartPosition = FormStartPosition.Manual
        '        .TopLevel = False
        '        .MdiParent = Me
        '        .Dock = DockStyle.Fill

        '        .Show()
        '    End If
        'End With

    End Sub

    Private Sub BtnModule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'With Frmmodule
        '    If .Visible = True Then
        '        .Focus()
        '    Else

        '        ' Frmmodule = New FrmModule
        '        ViewForm("Module", "Mod", Frmmodule)
        '    End If
        'End With
    End Sub

    Private Sub BtnBalesInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim FrmBalesInv2 As New FrmBalesInv2
        'With FrmBalesInv2
        '    If .Visible = True Then
        '        .Focus()
        '    Else
        '        FrmBalesInv2 = New FrmBalesInv2

        '        .StartPosition = FormStartPosition.Manual
        '        .TopLevel = False
        '        .MdiParent = Me
        '        .Dock = DockStyle.Fill

        '        .Show()
        '    End If
        'End With
    End Sub
#End Region



    Private logoutonly As Boolean = False
    Public Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        logoutonly = True
        Me.Close()
    End Sub

End Class
