
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Diagnostics
Imports Microsoft.VisualBasic
Imports System.Xml.Serialization
Imports System.Security.Cryptography

<XmlRoot(ElementName:="settings")>
Public Class settings

    <XmlElement(ElementName:="ConnectionType")>
    Public Property ConnectionType As String

    <XmlElement(ElementName:="sql_server_name")>
    Public Property sql_server_name As String

    <XmlElement(ElementName:="sql_server_uid")>
    Public Property sql_server_uid As String

    <XmlElement(ElementName:="sql_server_catalog")>
    Public Property sql_server_catalog As String

    <XmlElement(ElementName:="sql_server_pwd")>
    Public Property sql_server_pwd As String

    <XmlElement(ElementName:="OneTimeConnect")>
    Public Property OneTimeConnect As Boolean

    <XmlElement(ElementName:="access_file_path")>
    Public Property access_file_path As String

    <XmlElement(ElementName:="access_pwd")>
    Public Property access_pwd As String

    <XmlElement(ElementName:="logged_in_user_id")>
    Public Property logged_in_user_id As String

    <XmlElement(ElementName:="logged_in_try_count")>
    Public Property logged_in_try_count As Integer

    <XmlElement(ElementName:="station_code")>
    Public Property station_code As String

    <XmlElement(ElementName:="tscale_code")>
    Public Property tscale_code As String

    <XmlElement(ElementName:="tscale_desc")>
    Public Property tscale_desc As String

    <XmlElement(ElementName:="comm_port")>
    Public Property comm_port As String

    <XmlElement(ElementName:="baud_rate")>
    Public Property baud_rate As String

    <XmlElement(ElementName:="parity")>
    Public Property parity As String

    <XmlElement(ElementName:="data_bits")>
    Public Property data_bits As String

    <XmlElement(ElementName:="stop_bits")>
    Public Property stop_bits As String

    <XmlElement(ElementName:="device")>
    Public Property device As String

    <XmlElement(ElementName:="WeighingType")>
    Public Property WeighingType As String

    <XmlElement(ElementName:="UnitWeight")>
    Public Property UnitWeight As String

    <XmlElement(ElementName:="EnablePricing")>
    Public Property EnablePricing As Boolean

    <XmlElement(ElementName:="UnitPrice")>
    Public Property UnitPrice As String

    <XmlElement(ElementName:="EnableDeduction")>
    Public Property EnableDeduction As Boolean

    <XmlElement(ElementName:="DeductUnit")>
    Public Property DeductUnit As String

    <XmlElement(ElementName:="EnablePrintOut")>
    Public Property EnablePrintOut As Boolean

    <XmlElement(ElementName:="PrintAll")>
    Public Property PrintAll As Boolean

    <XmlElement(ElementName:="IPAddress")>
    Public Property IPAddress As String

    <XmlElement(ElementName:="IPPort")>
    Public Property IPPort As String

    <XmlElement(ElementName:="DeviceConnectionType")>
    Public Property DeviceConnectionType As String

    Private access_path As String = Application.StartupPath & "\c.txt"

    Private settings_path As String = Application.StartupPath & "\sys.file"

    <XmlIgnore>
    Public Property c As cryptor

    Public Sub RestoreDefault()
        sql_server_name = SystemInformation.ComputerName & "\SQLEXPRESS"
        sql_server_catalog = "SYSDB"
        sql_server_uid = "sa"
        sql_server_pwd = "1"
        access_file_path = Application.StartupPath & "\sysdb.mdb"
        WeighingType = "IO"
        UnitWeight = "KG"
        EnablePricing = False
        UnitPrice = "KG"
        EnableDeduction = False
        DeductUnit = "KG"
        ConnectionType = "OLEDB"
        comm_port = "COM1"
        baud_rate = "9600"
        data_bits = "8"
        parity = "None"
        stop_bits = "1"
        device = "GSE460"
        IPAddress = "192.168.1.41"
        IPPort = "1"
        DeviceConnectionType = "COMM"
        OneTimeConnect = False
        Save()
        Load()
    End Sub

    Public Sub Load()
        Dim pwd As String = System.IO.File.ReadAllText(access_path)
        c = New cryptor("JOJO")
        If c.decrypt(pwd) <> "122208" Then Return
        Try
            Dim ms As System.IO.MemoryStream
            Dim exists As Boolean = System.IO.File.Exists(settings_path)
            If exists = False Then RestoreDefault()
            Using rd As System.IO.TextReader = System.IO.File.OpenText(settings_path)
                ms = New System.IO.MemoryStream(System.Text.Encoding.ASCII.GetBytes(c.decrypt(rd.ReadToEnd())))
            End Using

            Dim root_attr = New System.Xml.Serialization.XmlRootAttribute()
            root_attr.ElementName = "settings"
            root_attr.IsNullable = True
            Dim serializer As System.Xml.Serialization.XmlSerializer = New System.Xml.Serialization.XmlSerializer(GetType(settings), root_attr)
            AddHandler serializer.UnknownNode, AddressOf serializer_unkown_node
            AddHandler serializer.UnknownAttribute, AddressOf serializer_unkown_attribute

            Dim settings As settings = CType(serializer.Deserialize(ms), settings)
            sql_server_name = settings.sql_server_name
            sql_server_catalog = settings.sql_server_catalog
            sql_server_uid = settings.sql_server_uid
            sql_server_pwd = settings.sql_server_pwd
            access_file_path = settings.access_file_path
            logged_in_user_id = settings.logged_in_user_id
            logged_in_try_count = settings.logged_in_try_count
            station_code = settings.station_code
            tscale_code = settings.tscale_code
            tscale_desc = settings.tscale_desc
            comm_port = settings.comm_port
            baud_rate = settings.baud_rate
            parity = settings.parity
            stop_bits = settings.stop_bits
            data_bits = settings.data_bits
            device = settings.device
            WeighingType = settings.WeighingType
            UnitWeight = settings.UnitWeight
            EnablePricing = settings.EnablePricing
            UnitPrice = settings.UnitPrice
            EnableDeduction = settings.EnableDeduction
            DeductUnit = settings.DeductUnit
            EnablePrintOut = settings.EnablePrintOut
            PrintAll = settings.PrintAll
            ConnectionType = settings.ConnectionType
            access_pwd = settings.access_pwd
            access_file_path = settings.access_file_path
            IPAddress = settings.IPAddress
            IPPort = settings.IPPort
            DeviceConnectionType = settings.DeviceConnectionType
        Catch ex As Exception
            Throw New Exception(change_error_msg(ex.Message))
        End Try
    End Sub

    Public Sub Save()
        Try
            Dim str_settings As String = ""
            Dim ms As System.IO.MemoryStream
            Dim eRR As StringBuilder = New StringBuilder()
            If System.IO.File.Exists(settings_path) = False Then System.IO.File.Create(settings_path).Close()
            Dim x As XmlSerializer = New System.Xml.Serialization.XmlSerializer(Me.[GetType]())
            ms = New System.IO.MemoryStream()
            x.Serialize(ms, Me)
            ms.Position = 0
            Using reader As System.IO.StreamReader = New System.IO.StreamReader(ms, Encoding.UTF8)
                str_settings = reader.ReadToEnd()
            End Using

            System.IO.File.WriteAllText(settings_path, c.encrypt(str_settings))
        Catch ex As Exception
            Throw New Exception(change_error_msg(ex.Message))
        End Try
    End Sub

    Private Function change_error_msg(ByVal msg As String) As String
        Dim emsg As String = ""
        If msg = "Bad Data." & vbCrLf Then emsg = "Error xBD01"
        Return emsg
    End Function

    Private Shared Sub serializer_unkown_node(ByVal sender As Object, ByVal e As System.Xml.Serialization.XmlNodeEventArgs)
        Console.WriteLine("Unknown node:" & e.Name & vbTab + e.Text)
    End Sub

    Private Shared Sub serializer_unkown_attribute(ByVal sender As Object, ByVal e As System.Xml.Serialization.XmlAttributeEventArgs)
        Dim attr As System.Xml.XmlAttribute = e.Attr
        Console.WriteLine("Unknown node:" & attr.Name & vbTab + attr.Value)
    End Sub

End Class

Public NotInheritable Class cryptor

    Public Sub New(ByVal key As String)
        TripleDes.Key = TruncateHash(key, TripleDes.KeySize / 8)
        TripleDes.IV = TruncateHash("", TripleDes.BlockSize / 8)
    End Sub

    Private TripleDes As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider()

    Private Function TruncateHash(ByVal key As String, ByVal length As Integer) As Byte()
        Dim sha1 As SHA1CryptoServiceProvider = New SHA1CryptoServiceProvider()
        Dim keyBytes As Byte() = System.Text.Encoding.Unicode.GetBytes(key)
        Dim hash As Byte() = sha1.ComputeHash(keyBytes)
        Array.Resize(hash, length)
        Return hash
    End Function

    Public Function encrypt(ByVal str As String) As String
        Dim plaintextBytes As Byte() = System.Text.Encoding.Unicode.GetBytes(str)
        Dim ms As System.IO.MemoryStream = New System.IO.MemoryStream()
        Dim encStream As CryptoStream = New CryptoStream(ms, TripleDes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()
        Return Convert.ToBase64String(ms.ToArray())
    End Function

    Public Function decrypt(ByVal str As String) As String
        Dim encryptedBytes As Byte() = Convert.FromBase64String(str)
        Dim ms As System.IO.MemoryStream = New System.IO.MemoryStream()
        Dim decStream As CryptoStream = New CryptoStream(ms, TripleDes.CreateDecryptor(), System.Security.Cryptography.CryptoStreamMode.Write)
        decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
        decStream.FlushFinalBlock()
        Return System.Text.Encoding.Unicode.GetString(ms.ToArray())
    End Function

    '=======================================================
    'Service provided by Telerik (www.telerik.com)
    'Conversion powered by Refactoring Essentials.
    'Twitter: @telerik
    'Facebook: facebook.com/telerik
    '=======================================================

End Class
