Public Class CLS_CLEARMEM
    Public Shared Sub ClearMem(objs As Object())

        GC.Collect()
        GC.Collect()

        For Each obj As Object In objs
            GC.SuppressFinalize(obj)
            If (TypeOf obj Is Form) Then
                Dim mfr As System.Windows.Forms.Form = DirectCast(obj, Form)
                mfr.Dispose()
            End If
        Next



    End Sub
End Class
