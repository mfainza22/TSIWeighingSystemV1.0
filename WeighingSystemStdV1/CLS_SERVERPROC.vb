Module MOD_SERVER
    Public SQLCONX As New System.Data.SqlClient.SqlConnection
    Public OLEDBCONX As New System.Data.OleDb.OleDbConnection

End Module



Public Class CLS_SERVERPROC
    Private Server_ As String
    Private DBName_ As String
    Private Pwd_ As String
    Private Uid_ As String
    Private SQLCONN_ As System.Data.SqlClient.SqlConnection
    Private OLEDBCONN_ As System.Data.OleDb.OleDbConnection
    Private CONNTYPE_ As String

    Public Property Server As String
        Get
            Return Server_
        End Get
        Set(ByVal value As String)
            Server_ = value
        End Set
    End Property

    Public Property DatabaseName As String
        Get
            Return DBName_
        End Get
        Set(ByVal value As String)
            DBName_ = value
        End Set
    End Property

    Public Property Uid As String
        Get
            Return Uid_
        End Get
        Set(ByVal value As String)
            Uid_ = value
        End Set
    End Property


    Public Property Password As String
        Get
            Return Pwd_
        End Get
        Set(ByVal value As String)
            Pwd_ = value
        End Set
    End Property

    Public Property ConnectionType As String
        Get
            Return CONNTYPE_
        End Get
        Set(ByVal value As String)
            CONNTYPE_ = value
        End Set
    End Property

    Public Function Connect_Server() As Boolean
        Try
            ' Server_ = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SYSTEM\Extras\MAF\Svr", "ServerName", Nothing)
            ' DBName_ = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SYSTEM\Extras\MAF\Svr", "DBName", Nothing)
            'Uid_ = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SYSTEM\Extras\MAF\Svr", "Unme", Nothing)
            ' Pwd_ = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SYSTEM\Extras\MAF\Svr", "Pwrd", Nothing)
            Dim SysSettings As New settings
            SysSettings.Load()
            Dim ConnectionString As String = ""
            Select Case SysSettings.ConnectionType.ToLower
                Case "OLEDB".ToLower

                    '                    ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & DBName_ & ";" &
                    '"               Jet OLEDB:Database Password=" & Pwd_ & ";"

                    ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBName_ & ";" &
                        "Jet OLEDB:Database Password= " & Pwd_ & ";"


                    '  OleDbConn = New System.Data.OleDb.OleDbConnection(ConnectionString)
                    If OleDbConn.State = ConnectionState.Open Then OleDbConn.Close()
                    OleDbConn.ConnectionString = ConnectionString
                    OleDbConn.Open()


                Case "SQL".ToLower
                    ConnectionString = "Data Source= " & Server_ & " ;Initial Catalog= " & DBName_ & ";User Id= " & Uid_ & " ;Password=" & Pwd_

                    ' SqlConn = New System.Data.SqlClient.SqlConnection
                    If SqlConn.State = ConnectionState.Open Then SqlConn.Close()
                    SqlConn.ConnectionString = ConnectionString
                    SqlConn.Open()

                Case Else
                    Throw New Exception("Error detecting connetion type")
            End Select
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
            Return False
        End Try
    End Function

    Public Property SqlConn As System.Data.SqlClient.SqlConnection
        Get
            Return SQLCONN_
        End Get
        Set(ByVal value As System.Data.SqlClient.SqlConnection)
            SQLCONN_ = value
        End Set
    End Property

    Public Property OleDbConn As System.Data.OleDb.OleDbConnection
        Get
            Return OLEDBCONN_
        End Get
        Set(ByVal value As System.Data.OleDb.OleDbConnection)
            OLEDBCONN_ = value
        End Set
    End Property
End Class
