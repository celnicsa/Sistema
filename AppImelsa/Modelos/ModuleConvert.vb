Imports System.IO

Module ModuleConvert

    Public Function ImageToBytes(ByVal Foto As Image) As Byte()
        Dim Array As Byte() = Nothing
        Try
            If Not Foto Is Nothing Then
                Dim Bin As New MemoryStream
                Foto.Save(Bin, Imaging.ImageFormat.Jpeg)
                Array = Bin.GetBuffer
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Convertision a Byte Termino en Error: " + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return Array
    End Function

    Public Function BytesToImage(ByVal Foto As Byte()) As Image
        Dim Array As Byte() = Nothing
        Try
            If Not Foto Is Nothing Then
                Dim Bin As New MemoryStream(Foto)
                Dim Result As Image = Image.FromStream(Bin)
                Return Result
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function BytesToString(ByVal Array As Byte()) As String
        Dim Salida As String = ""
        Dim Count As Integer = 0
        Try
            For Count = 0 To Array.Length - 1
                Salida += Array(Count).ToString + ","
            Next
        Catch ex As Exception
        End Try
        Return Salida
    End Function



End Module
