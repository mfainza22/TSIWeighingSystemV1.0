Public Class CLS_CRYPTO



    Public Function Encrypt(ByVal Str As String) As String
        Dim CHARSET As String = ""
        Dim CharCode As Integer
        Dim SwappedVal As Integer

        For i = 1 To Str.Length
            CharCode = Asc(Mid(Str, i, 1))
            If CharCode > 128 Then
                SwappedVal = CharCode - 128
                SwappedVal = SwappedVal - 10
            Else
                SwappedVal = CharCode + 128
                SwappedVal = SwappedVal - 10
            End If

            CHARSET = CHARSET & Chr(SwappedVal)
        Next

        Return CHARSET
    End Function


    Public Function Decrypt(ByVal Str As String) As String
        Dim CHARSET As String = ""
        Dim CharCode As Integer
        Dim SwappedVal As Integer
        Dim CurrentChr As String = ""

        For i = 1 To Str.Length
            CurrentChr = Mid(Str, i, 1)
            CharCode = Asc(CurrentChr)
            If CharCode > 128 Then
                SwappedVal = CharCode - 128
                SwappedVal = SwappedVal + 10
            Else
                SwappedVal = CharCode + 128
                SwappedVal = SwappedVal + 10
            End If


            CHARSET = CHARSET & Chr(SwappedVal)
        Next

        Return CHARSET
    End Function
End Class
