Imports System.Runtime.InteropServices
Imports System.Drawing.Printing

Public Class CLS_DOSPRINTER

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Ansi)>
    Public Class DOCINFOA

        <MarshalAs(UnmanagedType.LPStr)>
        Public pDocName As String

        <MarshalAs(UnmanagedType.LPStr)>
        Public pOutputFile As String

        <MarshalAs(UnmanagedType.LPStr)>
        Public pDataType As String
    End Class

    <DllImport("winspool.Drv", EntryPoint:="OpenPrinterA", SetLastError:=True, CharSet:=CharSet.Ansi, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function OpenPrinter(<MarshalAs(UnmanagedType.LPStr)> ByVal szPrinter As String, <Out> ByRef hPrinter As IntPtr, ByVal pd As IntPtr) As Boolean
    End Function

    <DllImport("winspool.Drv", EntryPoint:="ClosePrinter", SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function ClosePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function

    <DllImport("winspool.Drv", EntryPoint:="StartDocPrinterA", SetLastError:=True, CharSet:=CharSet.Ansi, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function StartDocPrinter(ByVal hPrinter As IntPtr, ByVal level As Int32, <[In], MarshalAs(UnmanagedType.LPStruct)> ByVal di As DOCINFOA) As Boolean
    End Function

    <DllImport("winspool.Drv", EntryPoint:="EndDocPrinter", SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function EndDocPrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function

    <DllImport("winspool.Drv", EntryPoint:="StartPagePrinter", SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function StartPagePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function

    <DllImport("winspool.Drv", EntryPoint:="EndPagePrinter", SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function EndPagePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function

    <DllImport("winspool.Drv", EntryPoint:="WritePrinter", SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function WritePrinter(ByVal hPrinter As IntPtr, ByVal pBytes As IntPtr, ByVal dwCount As Int32, <Out> ByRef dwWritten As Int32) As Boolean
    End Function

    Private HandlePrinter As IntPtr

    Private ps As PrinterSettings

    Public Sub DosPrinter()
        HandlePrinter = IntPtr.Zero
        ps = New PrinterSettings()
    End Sub

    Public Property PrinterName As String
        Get
            Return ps.PrinterName
        End Get

        Set(ByVal value As String)
            ps.PrinterName = value
        End Set
    End Property

    Public Function ChoosePrinter() As Boolean
        Dim pd As PrintDialog = New PrintDialog()
        pd.UseEXDialog = True
        pd.PrinterSettings = ps
        If pd.ShowDialog() = DialogResult.OK Then
            ps = pd.PrinterSettings
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Open(ByVal DocName As String) As Boolean
        If HandlePrinter <> IntPtr.Zero Then Return False
        Dim risp As Boolean = OpenPrinter(ps.PrinterName, HandlePrinter, IntPtr.Zero)
        If risp = False Then Return False
        Dim MyDocInfo As DOCINFOA = New DOCINFOA()
        MyDocInfo.pDocName = DocName
        MyDocInfo.pOutputFile = Nothing
        MyDocInfo.pDataType = "RAW"
        If StartDocPrinter(HandlePrinter, 1, MyDocInfo) Then
            StartPagePrinter(HandlePrinter)
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Close() As Boolean
        If HandlePrinter = IntPtr.Zero Then Return False
        If Not EndPagePrinter(HandlePrinter) Then Return False
        If Not EndDocPrinter(HandlePrinter) Then Return False
        If Not ClosePrinter(HandlePrinter) Then Return False
        HandlePrinter = IntPtr.Zero
        Return True
    End Function

    Public Function Print(ByVal outputstring As String) As Boolean
        If HandlePrinter = IntPtr.Zero Then Return False
        Dim buf As IntPtr = Marshal.StringToCoTaskMemAnsi(outputstring)
        Dim done As Int32 = 0
        Dim ok As Boolean = WritePrinter(HandlePrinter, buf, outputstring.Length, done)
        Marshal.FreeCoTaskMem(buf)
        If Not ok Then Return False Else Return True
    End Function

    '=======================================================
    'Service provided by Telerik (www.telerik.com)
    'Conversion powered by Refactoring Essentials.
    'Twitter: @telerik
    'Facebook: facebook.com/telerik
    '=======================================================

End Class
