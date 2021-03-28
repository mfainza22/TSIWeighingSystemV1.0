Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class CLS_DBVIEWER
    ' Private Reader_ As System.Data.SqlClient.SqlDataReader = Nothing
    'Private Command_ As System.Data.SqlClient.SqlCommand = Nothing
    'Private databaseclass As New DatabaseClass

    Private ColCount As Integer
    Private DGNAME_ As DataGridView
    Private TABLENAME_ As String
    Private ERRORMSG_ As String
    Public ReadOnly Property Errors As String
        Get
            Return ERRORMSG_
        End Get

    End Property

    Public Property DATAGRIDVIEWNAME As DataGridView
        Get
            DATAGRIDVIEWNAME = DGNAME_
        End Get
        Set(ByVal datagridname As DataGridView)
            DGNAME_ = datagridname
        End Set
    End Property

    Public Property TABLENAME As String
        Get
            TABLENAME = TABLENAME_
        End Get
        Set(ByVal TABLENAME As String)
            TABLENAME_ = TABLENAME
        End Set
    End Property

    ReadOnly Property ColumnCount() As Integer
        Get
            Return ColCount
        End Get
    End Property

    Public Sub POPULATEDG()
        Dim SysSettings As New settings
        SysSettings.Load()
        If SysSettings.ConnectionType = "SQL" Then
            Dim OLECLS As New CLS_SQL_DB
            With OLECLS
                .CONNECTION = MOD_SERVER.SQLCONX
                .OpenTable()
                Dim TotCol As Integer = TotalColumnsSQL(.DATAREADER)
                With .DATAREADER
                    Dim col(TotCol) As DataGridViewTextBoxColumn
                    Dim row(TotCol) As String

                    For i = 0 To TotCol
                        col(i) = New DataGridViewTextBoxColumn
                        col(i).HeaderText = .GetName(i)
                        col(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                        col(i).Name = .GetName(i)
                        DGNAME_.Columns.Insert(i, col(i))
                    Next

                    If .HasRows = False Then
                        ColCount = 0
                    Else

                        While .Read
                            For i = 0 To TotCol
                                row(i) = .Item(i).ToString
                            Next
                            DGNAME_.Rows.Add(row)

                        End While

                        ColCount = DGNAME_.Rows.Count

                    End If
                    .Close()
                End With
            End With
        Else
            Dim OLECLS As New CLS_OLE_DB
            With OLECLS
                .CONNECTION = MOD_SERVER.OLEDBCONX
                .OpenTable()
                Dim TotCol As Integer = TotalColumnsOLE(.DATAREADER)
                With .DATAREADER
                    Dim col(TotCol) As DataGridViewTextBoxColumn
                    Dim row(TotCol) As String

                    For i = 0 To TotCol
                        col(i) = New DataGridViewTextBoxColumn
                        col(i).HeaderText = .GetName(i)
                        col(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                        col(i).Name = .GetName(i)
                        DGNAME_.Columns.Insert(i, col(i))
                    Next

                    If .HasRows = False Then
                        ColCount = 0
                    Else

                        While .Read
                            For i = 0 To TotCol
                                row(i) = .Item(i).ToString
                            Next
                            DGNAME_.Rows.Add(row)

                        End While

                        ColCount = DGNAME_.Rows.Count

                    End If
                    .Close()
                End With
            End With


        End If





    End Sub

    Private Function TotalColumnsOLE(ByVal DATAREADER As OleDb.OleDbDataReader) As Integer
        Dim Col As Integer
        For i = 0 To 45
            Try
                If String.IsNullOrEmpty(DATAREADER.GetName(i)) = True Then

                End If
            Catch ex As Exception
                Col = i - 1
                i = 45
            End Try
        Next
        Return Col

    End Function


    Private Function TotalColumnsSQL(ByVal DATAREADER As SqlClient.SqlDataReader) As Integer
        Dim Col As Integer
        For i = 0 To 45
            Try
                If String.IsNullOrEmpty(DATAREADER.GetName(i)) = True Then

                End If
            Catch ex As Exception
                Col = i - 1
                i = 45
            End Try
        Next
        Return Col

    End Function
End Class
