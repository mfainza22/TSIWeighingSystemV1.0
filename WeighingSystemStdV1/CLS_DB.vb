Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class CLS_SQL_DB
    Public Sub New()
        SysSettings = New settings()
        SysSettings.Load()
    End Sub
    Private SysSettings As settings
    Private SOURCE_ As String
    Public Property Source As String
        Get
            Return SOURCE_
        End Get
        Set(ByVal value As String)
            SOURCE_ = value
        End Set
    End Property

    Private TBL_ As String
    Public Property Table As String
        Get
            Return TBL_
        End Get
        Set(ByVal value As String)
            TBL_ = value
        End Set
    End Property

    Private FIELDNAME_ As String
    Public Property FieldName As String
        Get
            Return FIELDNAME_
        End Get
        Set(ByVal value As String)
            FIELDNAME_ = value
        End Set
    End Property

    Private TEXT_ As String
    Public Property Text As String
        Get
            Return TEXT_
        End Get
        Set(ByVal value As String)
            TEXT_ = value
        End Set
    End Property

    Private ERRORMSG_ As String
    Public ReadOnly Property Errors As String
        Get
            Return ERRORMSG_
        End Get

    End Property

    Private CONNECTION_ As SqlConnection
    Public Property CONNECTION As SqlConnection
        Get
            Return CONNECTION_
        End Get
        Set(ByVal value As SqlConnection)
            CONNECTION_ = value
        End Set
    End Property

    Private CMD_ As SqlCommand
    Public Property CMD As SqlCommand
        Get
            Return CMD_
        End Get
        Set(ByVal value As SqlCommand)
            CMD_ = value
        End Set
    End Property

    Private DATAREADER_ As SqlDataReader
    Public Property DATAREADER As SqlDataReader
        Get
            Return DATAREADER_
        End Get
        Set(ByVal value As SqlDataReader)
            DATAREADER_ = value
        End Set
    End Property

#Region "DATABASE BASIC PROCEDURE"
    Private Sub CONNECT_SERVER()
        Dim CLS_SVR As New CLS_SERVERPROC

        With CLS_SVR
            .Password = SysSettings.sql_server_pwd
            .Uid = SysSettings.sql_server_uid
            .Server = SysSettings.sql_server_name
            .DatabaseName = SysSettings.sql_server_catalog
            .ConnectionType = "SQL"
            .SqlConn = CONNECTION
            .Connect_Server()
        End With

    End Sub

    Public Sub ExecuteCommand()
        Try
            If SysSettings.OneTimeConnect = False Then CONNECT_SERVER()
            CMD = New SqlCommand(Source, CONNECTION)
            CMD.ExecuteNonQuery()
            CMD.Dispose()
        Catch ex As Exception
            CMD.Dispose()
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Public Sub OpenSource()
        Try
            If SysSettings.OneTimeConnect = False Then CONNECT_SERVER()
            CMD = New SqlCommand(Source, CONNECTION)
            DATAREADER = CMD.ExecuteReader
        Catch ex As Exception
            If IsNothing(DATAREADER) = False Then DATAREADER.Close()
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Public Sub OpenTable()
        Try
            If SysSettings.OneTimeConnect = False Then CONNECT_SERVER()

            CMD = New SqlCommand("Select * from " & Table & "", CONNECTION)
            DATAREADER = CMD.ExecuteReader
        Catch ex As Exception
            If IsNothing(DATAREADER) = False Then DATAREADER.Close()
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Public Sub SearchTable()
        Try
            If SysSettings.OneTimeConnect = False Then CONNECT_SERVER()
            CMD = New SqlCommand("Select * from " & Table & " where " & FieldName & " = '" & Text & "'", CONNECTION)
            DATAREADER = CMD.ExecuteReader
        Catch ex As Exception
            If IsNothing(DATAREADER) = False Then DATAREADER.Close()
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Public Sub DeleteRecord()
        Try
            If SysSettings.OneTimeConnect = False Then CONNECT_SERVER()
            CMD = New SqlCommand("Delete From " & Table & " Where " & FieldName & " = '" & Text & "'", CONNECTION)
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            CMD.Dispose()
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Public Sub DeleteMultiple(ByVal Dg As DataGridView, ByVal CellNo As Integer, ByVal txt As TextBox)
        Try
            Dim DGClass As New CLS_DATAGRID
            Dim L As Integer = Dg.Rows.Count
            Dim Sel_No As Integer = 0
            Dim Sel(Dg.SelectedRows.Count) As String

            For i = 0 To Dg.Rows.Count - 1
                If Dg.Rows(i).Selected = True Then
                    Sel(Sel_No) = Dg.Rows(i).Cells(0).Value
                    Sel_No = Sel_No + 1
                End If
            Next

            For i = 0 To Sel.Count - 2
                Text = Sel(i)
                Source = "Delete From " & Table & " where " & FieldName & " = '" & Text & "'"
                ExecuteCommand()

                DGClass.SearchGrid(Dg, Sel(i), 0)
                If IsNothing(txt) = False Then
                    txt.AutoCompleteCustomSource.Remove(Dg.CurrentRow.Cells(CellNo).Value)
                End If


                If Dg.CurrentRow.IsNewRow = False Then
                    If Dg.AllowUserToDeleteRows = False Then
                        Dg.Rows.Remove(Dg.CurrentRow)
                    End If

                End If
            Next

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub


#End Region

#Region "Identification Procedure"

    Public Function GeneratedId() As String
        Try
            If SysSettings.OneTimeConnect = False Then CONNECT_SERVER()
            Dim Result As String = Nothing
            CMD = New SqlCommand("Select * from " & Table & "", CONNECTION)
            DATAREADER = CMD.ExecuteReader
            DATAREADER.Read()
            Result = DATAREADER.Item(FieldName).ToString
            DATAREADER.Close()
            Return Result
        Catch ex As Exception
            DATAREADER.Close()
            Throw New Exception(ex.Message, ex)
            Return Nothing
        End Try
    End Function

    Public Sub UpdateId()
        Try
            If SysSettings.OneTimeConnect = False Then CONNECT_SERVER()

            Dim NewId As String

            NewId = Val(Text) + 1
            NewId = String.Format("{0:00000000}", Val(NewId))

            Source = "Update " & Table & " set " & FieldName & " = '" & NewId & "'"
            CMD = New SqlCommand(Source, CONNECTION)
            CMD.ExecuteNonQuery()
            CMD.Dispose()
        Catch ex As Exception
            CMD.Dispose()
            ERRORMSG_ = ex.Message
        End Try
    End Sub
#End Region



#Region "EXTRAS W/ VESSEL CONNECTION (MACAI PROJECT)"
    Private Sub DeleteVesselConnection(ByVal rw As DataGridViewRow)
        If rw.Cells("Col_OnShip").Value = True Then
            Dim TruckNo As Integer = 0
            Dim VesselLoad As Integer = 0

            Dim Updater As New CLS_SQL_DB
            With Updater
                .CONNECTION = CONNECTION
                .Table = "Vessels"
                .FieldName = "V_Name"
                .Text = rw.Cells("Col_Vessel").Value
                .SearchTable()
                If .DATAREADER.HasRows Then
                    .DATAREADER.Read()
                    TruckNo = .DATAREADER.Item("NoOfTrucks")
                    VesselLoad = .DATAREADER.Item("VesselLoad")
                End If
                .DATAREADER.Close()
                .CMD.Dispose()
            End With

            TruckNo = TruckNo - 1
            If TruckNo < 0 Then TruckNo = 0

            VesselLoad = VesselLoad - Val(rw.Cells("Col_Gross").Value)
            If VesselLoad < 0 Then VesselLoad = 0

            With Updater
                .CONNECTION = CONNECTION
                .Table = "Vessels"
                .FieldName = "V_Name"
                .Text = rw.Cells("Col_Vessel").Value
                .Source = "Update " & .Table & " set VesselLoad = '" & VesselLoad & "', NoOfTrucks = '" & TruckNo & "'" & _
                    " where " & .FieldName & " = '" & .Text & "'"
                .ExecuteCommand()
                .CMD.Dispose()
            End With
        End If
    End Sub

    Public Sub DeleteMultipleMOD(ByVal Dg As DataGridView, ByVal CellNo As Integer, ByVal Cell_id As Integer, ByVal txt As TextBox)
        Try
            Dim UniqueId(Dg.SelectedRows.Count - 1) As String
            Dim UniqueIdIdx As Integer = 0

            For i = 0 To Dg.Rows.Count - 1
                If Dg.Rows(i).Selected = True Then
                    UniqueId(UniqueIdIdx) = Dg.Rows(i).Cells(Cell_id).Value
                    UniqueIdIdx = UniqueIdIdx + 1
                End If
            Next

            For UniqueIdIdx = 0 To UniqueId.Count - 1
                Text = UniqueId(UniqueIdIdx)
                DeleteRecord()
            Next

            For UniqueIdIdx = 0 To UniqueId.Count - 1
                Text = UniqueId(UniqueIdIdx)
                DeleteRecord()
            Next

            For UniqueIdIdx = 0 To UniqueId.Count - 1
                For DGIdx = 0 To Dg.Rows.Count - 1
                    If Dg.Rows(DGIdx).Cells(Cell_id).Value = UniqueId(UniqueIdIdx) Then
                        Text = UniqueId(UniqueIdIdx)
                        DeleteRecord()
                        DeleteVesselConnection(Dg.Rows(DGIdx))

                        If IsNothing(txt) = False Then
                            txt.AutoCompleteCustomSource.Remove(Dg.CurrentRow.Cells(CellNo).Value)
                        End If

                        If Dg.Rows(DGIdx).IsNewRow = False Then
                            Dg.Rows.Remove(Dg.Rows(DGIdx))
                        End If
                        Exit For
                    End If
                Next

            Next

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub
#End Region

End Class

Public Class CLS_OLE_DB

    Private SOURCE_ As String
    Public Property Source As String
        Get
            Return SOURCE_
        End Get
        Set(ByVal value As String)
            SOURCE_ = value
        End Set
    End Property

    Private TBL_ As String
    Public Property Table As String
        Get
            Return TBL_
        End Get
        Set(ByVal value As String)
            TBL_ = value
        End Set
    End Property

    Private FIELDNAME_ As String
    Public Property FieldName As String
        Get
            Return FIELDNAME_
        End Get
        Set(ByVal value As String)
            FIELDNAME_ = value
        End Set
    End Property

    Private TEXT_ As String
    Public Property Text As String
        Get
            Return TEXT_
        End Get
        Set(ByVal value As String)
            TEXT_ = value
        End Set
    End Property

    Private ERRORMSG_ As String
    Public ReadOnly Property Errors As String
        Get
            Return ERRORMSG_
        End Get

    End Property

    Private CONNECTION_ As OleDbConnection
    Public Property CONNECTION As OleDbConnection
        Get
            Return CONNECTION_
        End Get
        Set(ByVal value As OleDbConnection)
            CONNECTION_ = value
        End Set
    End Property

    Private CMD_ As OleDbCommand
    Public Property CMD As OleDbCommand
        Get
            Return CMD_
        End Get
        Set(ByVal value As OleDbCommand)
            CMD_ = value
        End Set
    End Property

    Private DATAREADER_ As OleDbDataReader
    Public Property DATAREADER As OleDbDataReader
        Get
            Return DATAREADER_
        End Get
        Set(ByVal value As OleDbDataReader)
            DATAREADER_ = value
        End Set
    End Property

    Private Sub CONNECT_SERVER()
        Dim CLS_SVR As New CLS_SERVERPROC
        Dim SysSettings As New settings
        SysSettings.Load()
        With CLS_SVR
            .Password = SysSettings.access_pwd
            .DatabaseName = SysSettings.access_file_path
            .ConnectionType = "OLEDB"
            .OleDbConn = CONNECTION
            .Connect_Server()
        End With

    End Sub
#Region "DATABASE BASIC PROCEDURE"
    Public Sub ExecuteCommand()
        Try
            Dim SysSettings As New settings
            SysSettings.Load()
            If SysSettings.OneTimeConnect = False Then CONNECT_SERVER()
            CMD = New OleDbCommand(Source, CONNECTION)
            CMD.ExecuteNonQuery()
            CMD.Dispose()
        Catch ex As Exception
            CMD.Dispose()
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Public Sub OpenSource()
        Try
            Dim SysSettings As New settings
            SysSettings.Load()
            If SysSettings.OneTimeConnect = False Then CONNECT_SERVER()
            CMD = New OleDbCommand(Source, CONNECTION)
            DATAREADER = CMD.ExecuteReader
        Catch ex As Exception
            If IsNothing(DATAREADER) = False Then DATAREADER.Close()
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Public Sub OpenTable()
        Try
            Dim SysSettings As New settings
            SysSettings.Load()
            If SysSettings.OneTimeConnect = False Then CONNECT_SERVER()
            CMD = New OleDbCommand("Select * from " & Table & "", CONNECTION)
            DATAREADER = CMD.ExecuteReader
        Catch ex As Exception
            If IsNothing(DATAREADER) = False Then DATAREADER.Close()
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Public Sub SearchTable()
        Try
            Dim SysSettings As New settings
            SysSettings.Load()
            If SysSettings.OneTimeConnect = False Then CONNECT_SERVER()
            CMD = New OleDbCommand("Select * from " & Table & " where " & FieldName & " = '" & Text & "'", CONNECTION)
            DATAREADER = CMD.ExecuteReader
        Catch ex As Exception
            If IsNothing(DATAREADER) = False Then DATAREADER.Close()
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Public Sub DeleteRecord()
        Try
            Dim SysSettings As New settings
            SysSettings.Load()
            If SysSettings.OneTimeConnect = False Then CONNECT_SERVER()
            CMD = New OleDbCommand("Delete From " & Table & " Where " & FieldName & " = '" & Text & "'", CONNECTION)
            DATAREADER = CMD.ExecuteReader
        Catch ex As Exception
            CMD.Dispose()
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Public Sub DeleteMultiple(ByVal Dg As DataGridView, ByVal CellNo As Integer, ByVal txt As TextBox)
        Try
            Dim DGClass As New CLS_DATAGRID
            Dim L As Integer = Dg.Rows.Count
            Dim Sel_No As Integer = 0
            Dim Sel(Dg.SelectedRows.Count) As String

            For i = 0 To Dg.Rows.Count - 1
                If Dg.Rows(i).Selected = True Then
                    Sel(Sel_No) = Dg.Rows(i).Cells(0).Value
                    Sel_No = Sel_No + 1
                End If
            Next

            For i = 0 To Sel.Count - 2
                Text = Sel(i)
                Source = "Delete From " & Table & " where " & FieldName & " = '" & Text & "'"
                ExecuteCommand()

                DGClass.SearchGrid(Dg, Sel(i), 0)
                If IsNothing(txt) = False Then
                    txt.AutoCompleteCustomSource.Remove(Dg.CurrentRow.Cells(CellNo).Value)
                End If


                If Dg.CurrentRow.IsNewRow = False Then
                    If Dg.AllowUserToDeleteRows = False Then
                        Dg.Rows.Remove(Dg.CurrentRow)
                    End If

                End If
            Next

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub


#End Region

#Region "Identification Procedure"

    Public Function GeneratedId() As String
        Try
            Dim SysSettings As New settings
            SysSettings.Load()
            If SysSettings.OneTimeConnect = False Then CONNECT_SERVER()
            Dim Result As String = Nothing
            CMD = New OleDbCommand("Select * from " & Table & "", CONNECTION)
            DATAREADER = CMD.ExecuteReader
            DATAREADER.Read()
            Result = DATAREADER.Item(FieldName).ToString
            DATAREADER.Close()
            Return Result
        Catch ex As Exception
            If IsNothing(DATAREADER) = False Then DATAREADER.Close()
            Throw New Exception(ex.Message, ex)
            Return Nothing
        End Try
    End Function

    Public Sub UpdateId()
        Try
            Dim SysSettings As New settings
            SysSettings.Load()
            If SysSettings.OneTimeConnect = False Then CONNECT_SERVER()
            Dim NewId As String

            NewId = Val(Text) + 1
            NewId = String.Format("{0:00000000}", Val(NewId))

            Source = "Update " & Table & " set " & FieldName & " = '" & NewId & "'"

            CMD = New OleDbCommand(Source, CONNECTION)
            CMD.ExecuteNonQuery()
            CMD.Dispose()
        Catch ex As Exception
            CMD.Dispose()
            ERRORMSG_ = ex.Message
        End Try
    End Sub
#End Region

#Region "EXTRAS W/ VESSEL CONNECTION (MACAI PROJECT)"
    Private Sub DeleteVesselConnection(ByVal rw As DataGridViewRow)
        '  If SysSettings.OneTimeConnect = False Then CONNECT_SERVER()
        If rw.Cells("Col_OnShip").Value = True Then
            Dim TruckNo As Integer = 0
            Dim VesselLoad As Integer = 0

            Dim Updater As New CLS_SQL_DB
            With Updater
                .CONNECTION = SQLCONX
                .Table = "Vessels"
                .FieldName = "V_Name"
                .Text = rw.Cells("Col_Vessel").Value
                .SearchTable()
                If .DATAREADER.HasRows Then
                    .DATAREADER.Read()
                    TruckNo = .DATAREADER.Item("NoOfTrucks")
                    VesselLoad = .DATAREADER.Item("VesselLoad")
                End If
                .DATAREADER.Close()
                .CMD.Dispose()
            End With

            TruckNo = TruckNo - 1
            If TruckNo < 0 Then TruckNo = 0

            VesselLoad = VesselLoad - Val(rw.Cells("Col_Gross").Value)
            If VesselLoad < 0 Then VesselLoad = 0

            With Updater
                .CONNECTION = SQLCONX
                .Table = "Vessels"
                .FieldName = "V_Name"
                .Text = rw.Cells("Col_Vessel").Value
                .Source = "Update " & .Table & " set VesselLoad = '" & VesselLoad & "', NoOfTrucks = '" & TruckNo & "'" & _
                    " where " & .FieldName & " = '" & .Text & "'"
                .ExecuteCommand()
                .CMD.Dispose()
            End With
        End If
    End Sub

    Public Sub DeleteMultipleMOD(ByVal Dg As DataGridView, ByVal CellNo As Integer, ByVal Cell_id As Integer, ByVal txt As TextBox)
        Try
            Dim UniqueId(Dg.SelectedRows.Count - 1) As String
            Dim UniqueIdIdx As Integer = 0

            For i = 0 To Dg.Rows.Count - 1
                If Dg.Rows(i).Selected = True Then
                    UniqueId(UniqueIdIdx) = Dg.Rows(i).Cells(Cell_id).Value
                    UniqueIdIdx = UniqueIdIdx + 1
                End If
            Next

            For UniqueIdIdx = 0 To UniqueId.Count - 1
                Text = UniqueId(UniqueIdIdx)
                DeleteRecord()
            Next

            For UniqueIdIdx = 0 To UniqueId.Count - 1
                Text = UniqueId(UniqueIdIdx)
                DeleteRecord()
            Next

            For UniqueIdIdx = 0 To UniqueId.Count - 1
                For DGIdx = 0 To Dg.Rows.Count - 1
                    If Dg.Rows(DGIdx).Cells(Cell_id).Value = UniqueId(UniqueIdIdx) Then
                        Text = UniqueId(UniqueIdIdx)
                        DeleteRecord()
                        DeleteVesselConnection(Dg.Rows(DGIdx))

                        If IsNothing(txt) = False Then
                            txt.AutoCompleteCustomSource.Remove(Dg.CurrentRow.Cells(CellNo).Value)
                        End If

                        If Dg.Rows(DGIdx).IsNewRow = False Then
                            Dg.Rows.Remove(Dg.Rows(DGIdx))
                        End If
                        Exit For
                    End If
                Next

            Next

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub
#End Region




End Class

Public Module MOD_DATABASEPROC
    Public Sub ThrowArrayToControl(ByRef Ctrl As Control, ByVal Lst As List(Of String))
        Select Case True
            Case TypeOf (Ctrl) Is ComboBox
                Dim Cbo As ComboBox = Ctrl
                Cbo.Items.Clear()
                Cbo.AutoCompleteSource = AutoCompleteSource.ListItems
                Cbo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                For Each Str As String In Lst
                    Cbo.Items.Add(Str)
                Next
            Case TypeOf (Ctrl) Is TextBox
                Dim txt As TextBox = Ctrl
                txt.AutoCompleteCustomSource.Clear()
                txt.AutoCompleteSource = AutoCompleteSource.CustomSource
                txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                For Each Str As String In Lst
                    txt.AutoCompleteCustomSource.Add(Str)
                Next
        End Select
    End Sub

    Public Sub ListDataToArray(ByRef LstStr As List(Of String), ByVal ArrStr As String(,), ByVal src As String, ByVal fldname1 As String, ByVal fldname2 As String)
        Dim SysSettings As New settings
        SysSettings.Load()
        If SysSettings.ConnectionType = "SQL" Then
            Dim DBCLASS As New CLS_SQL_DB

            Try
                DBCLASS.CONNECTION = SQLCONX
                DBCLASS.Source = src


                DBCLASS.OpenSource()
                Dim arrIdx As Integer = 0
                While DBCLASS.DATAREADER.Read
                    If IsNothing(LstStr) = False Then
                        LstStr.Add(DBCLASS.DATAREADER.Item(fldname1))
                    End If

                    If IsNothing(ArrStr) = False Then
                        ArrStr(arrIdx, 0) = DBCLASS.DATAREADER.Item(fldname1)
                        ArrStr(arrIdx, 1) = DBCLASS.DATAREADER.Item(fldname2)
                        arrIdx += 1
                    End If

                End While

                DBCLASS.DATAREADER.Close()

            Catch ex As Exception
                If IsNothing(DBCLASS.DATAREADER) = False Then
                    If DBCLASS.DATAREADER.IsClosed = False Then
                        DBCLASS.DATAREADER.Close()
                    End If
                End If
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Dim DBCLASS As New CLS_OLE_DB
            Try

                DBCLASS.CONNECTION = OLEDBCONX
                DBCLASS.Source = src
                DBCLASS.OpenSource()
                Dim arrIdx As Integer = 0

                While DBCLASS.DATAREADER.Read
                    If IsNothing(LstStr) = False Then
                        LstStr.Add(DBCLASS.DATAREADER.Item(fldname1))
                    End If

                    If IsNothing(ArrStr) = False Then
                        ArrStr(arrIdx, 0) = DBCLASS.DATAREADER.Item(fldname1)
                        ArrStr(arrIdx, 1) = DBCLASS.DATAREADER.Item(fldname2)
                        arrIdx += 1
                    End If

                End While
                DBCLASS.DATAREADER.Close()

            Catch ex As Exception
                If IsNothing(DBCLASS.DATAREADER) = False Then
                    If DBCLASS.DATAREADER.IsClosed = False Then
                        DBCLASS.DATAREADER.Close()
                    End If
                End If
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub
    Public Sub ListDataToControl(ByRef Ctrl() As Control, ByVal SRC As String, ByVal FldName As String)
        Dim SysSettings As New settings
        SysSettings.Load()
        If SysSettings.ConnectionType = "SQL" Then
            Dim DBCLASS As New CLS_SQL_DB

            Try
                DBCLASS.CONNECTION = SQLCONX
                DBCLASS.Source = SRC

                For Each ctrlV As Control In Ctrl
                    Select Case True
                        Case TypeOf ctrlV Is ComboBox
                            Dim Cbo As ComboBox = ctrlV
                            Cbo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                            DBCLASS.OpenSource()
                            While DBCLASS.DATAREADER.Read
                                Cbo.Items.Add(DBCLASS.DATAREADER.Item(FldName))
                            End While
                            DBCLASS.DATAREADER.Close()
                        Case TypeOf ctrlV Is TextBox
                            Dim txt As TextBox = ctrlV
                            txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                            txt.AutoCompleteSource = AutoCompleteSource.CustomSource
                            DBCLASS.OpenSource()
                            While DBCLASS.DATAREADER.Read
                                txt.AutoCompleteCustomSource.Add(DBCLASS.DATAREADER.Item(FldName))
                            End While
                            DBCLASS.DATAREADER.Close()
                        Case TypeOf ctrlV Is ListBox
                            Dim Lst As ListBox = ctrlV
                            Lst.Items.Add(DBCLASS.DATAREADER.Item(FldName))
                            DBCLASS.DATAREADER.Close()
                    End Select
                Next


            Catch ex As Exception
                If IsNothing(DBCLASS.DATAREADER) = False Then
                    If DBCLASS.DATAREADER.IsClosed = False Then
                        DBCLASS.DATAREADER.Close()
                    End If
                End If
                Throw New Exception(ex.Message, ex)
            End Try
        Else
            Dim DBCLASS As New CLS_OLE_DB
            Try

                DBCLASS.CONNECTION = OLEDBCONX
                DBCLASS.Source = SRC

                For Each ctrlV As Control In Ctrl
                    Select Case True
                        Case TypeOf ctrlV Is ComboBox
                            Dim Cbo As ComboBox = ctrlV
                            Cbo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                            DBCLASS.OpenSource()
                            While DBCLASS.DATAREADER.Read
                                Cbo.Items.Add(DBCLASS.DATAREADER.Item(FldName))
                            End While
                            DBCLASS.DATAREADER.Close()
                        Case TypeOf ctrlV Is TextBox
                            Dim txt As TextBox = ctrlV
                            txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                            txt.AutoCompleteSource = AutoCompleteSource.CustomSource
                            DBCLASS.OpenSource()
                            While DBCLASS.DATAREADER.Read
                                txt.AutoCompleteCustomSource.Add(DBCLASS.DATAREADER.Item(FldName))
                            End While
                            DBCLASS.DATAREADER.Close()
                        Case TypeOf ctrlV Is ListBox
                            Dim Lst As ListBox = ctrlV
                            Lst.Items.Add(DBCLASS.DATAREADER.Item(FldName))
                            DBCLASS.DATAREADER.Close()
                    End Select
                Next

            Catch ex As Exception
                If IsNothing(DBCLASS.DATAREADER) = False Then
                    If DBCLASS.DATAREADER.IsClosed = False Then
                        DBCLASS.DATAREADER.Close()
                    End If
                End If
                Throw New Exception(ex.Message, ex)
            End Try
        End If

    End Sub

#Region "SEARCH EXISTING WITH RETURNED DATA"
    Public ReturnedData As String

    Public Function ExistenceFound(ByVal Src As String, ByVal ReturnedMessage As String, ByVal FldToReturn As String, ByVal txt As TextBox) As Boolean
        Dim Result As Boolean = False
        Dim SysSettings As New settings
        SysSettings.Load()
        If SysSettings.ConnectionType.ToLower = "SQL".ToLower Then
            Dim DBClass As New CLS_SQL_DB
            Try
                DBClass.CONNECTION = MOD_SERVER.SQLCONX
                DBClass.Source = Src
                DBClass.OpenSource()
                DBClass.DATAREADER.Read()
                If DBClass.DATAREADER.HasRows = True Then
                    If IsNothing(ReturnedMessage) = False Then MessageBox.Show(ReturnedMessage, _
                                       "", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                    If IsNothing(FldToReturn) = False Then
                        If IsDBNull(DBClass.DATAREADER.Item(FldToReturn)) Then ReturnedData = 0 Else ReturnedData = DBClass.DATAREADER.Item(FldToReturn)
                    End If

                    If IsNothing(txt) = False Then
                        txt.Focus()
                        txt.SelectAll()
                    End If
                    Result = True
                End If
                DBClass.DATAREADER.Close()
                Return Result
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        Else
            Dim DBClass As New CLS_OLE_DB
            Try
                DBClass.CONNECTION = MOD_SERVER.OLEDBCONX
                DBClass.Source = Src
                DBClass.OpenSource()
                DBClass.DATAREADER.Read()
                If DBClass.DATAREADER.HasRows = True Then
                    If IsNothing(ReturnedMessage) = False Then MessageBox.Show(ReturnedMessage, _
                                       "", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                    If IsNothing(FldToReturn) = False Then
                        If IsDBNull(DBClass.DATAREADER.Item(FldToReturn)) Then ReturnedData = 0 Else ReturnedData = DBClass.DATAREADER.Item(FldToReturn)
                    End If

                    If IsNothing(txt) = False Then
                        txt.Focus()
                        txt.SelectAll()
                    End If
                    Result = True
                End If
                DBClass.DATAREADER.Close()
                Return Result
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End If

    End Function

#End Region

#Region "SEARCH EXISTING WITH RETURNED GRID ROW"


    Public Function RecordFound(ByVal Src As String, ByVal ReturnedMessage As String, ByVal txt As TextBox, ByVal DG As DataGridView) As Boolean
        Dim Result As Boolean = False
        Dim SysSettings As New settings
        SysSettings.Load()
        If SysSettings.ConnectionType.ToLower = "SQL".ToLower Then
            Dim DBClass As New CLS_SQL_DB
            DG.Rows.Clear()
            DG.Columns.Clear()
            Try
                DBClass.CONNECTION = SQLCONX
                DBClass.Source = Src
                DBClass.OpenSource()

                If DBClass.DATAREADER.HasRows = True Then
                    If IsNothing(ReturnedMessage) = False Then MessageBox.Show(ReturnedMessage, _
                                       "", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                    For i = 0 To DBClass.DATAREADER.FieldCount - 1
                        Dim col As New DataGridViewTextBoxColumn
                        col.Name = DBClass.DATAREADER.GetName(i)
                        DG.Columns.Add(col)
                    Next

                    While DBClass.DATAREADER.Read
                        Dim rows(DBClass.DATAREADER.FieldCount - 1) As String
                        For i = 0 To DBClass.DATAREADER.FieldCount - 1
                            If IsDBNull(DBClass.DATAREADER.Item(i)) Then rows(i) = "" Else rows(i) = DBClass.DATAREADER.Item(i)
                        Next
                        DG.Rows.Add(rows)
                    End While

                    Result = True
                End If

                DBClass.DATAREADER.Close()
                Return Result
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
                Return False
            End Try
        Else
            Dim DBClass As New CLS_OLE_DB
            DG.Rows.Clear()
            DG.Columns.Clear()
            Try
                DBClass.CONNECTION = OLEDBCONX
                DBClass.Source = Src
                DBClass.OpenSource()

                If DBClass.DATAREADER.HasRows = True Then
                    If IsNothing(ReturnedMessage) = False Then MessageBox.Show(ReturnedMessage, _
                                       "", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                    For i = 0 To DBClass.DATAREADER.FieldCount - 1
                        Dim col As New DataGridViewTextBoxColumn
                        col.Name = DBClass.DATAREADER.GetName(i)
                        DG.Columns.Add(col)
                    Next

                    While DBClass.DATAREADER.Read
                        Dim rows(DBClass.DATAREADER.FieldCount - 1) As String
                        For i = 0 To DBClass.DATAREADER.FieldCount - 1
                            If IsDBNull(DBClass.DATAREADER.Item(i)) Then rows(i) = "" Else rows(i) = DBClass.DATAREADER.Item(i)
                        Next
                        DG.Rows.Add(rows)
                    End While

                    Result = True
                End If

                DBClass.DATAREADER.Close()
                Return Result
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
                Return False
            End Try
        End If

    End Function



#End Region
End Module