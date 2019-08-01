Imports System.Text.RegularExpressions

Public Class ValidateInput
    Private Pattern As String
    Private Input As String
    Private Matcher As Match

    Public Function IsEmail(ByVal Input As String) As Boolean
        Me.Input = Input
        Me.Pattern = "^[_a-z0-9-]+(.[_a-z0-9-]+)*@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$"
        Matcher = Regex.Match(Me.Input, Pattern)
        If Matcher.Success Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function IsCedula(ByVal Input As String) As Boolean
        Me.Input = Input
        Me.Pattern = "\b[0-9]{3}-{0,1}[0-9]{6}-{0,1}[0-9]{4}[A-Z]{1}\b"
        Matcher = Regex.Match(Me.Input, Pattern)
        If Matcher.Success Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function IsPhone(ByVal Input As String) As Boolean
        Me.Input = Input
        Me.Pattern = "\b[0-9]{8}\b"
        Matcher = Regex.Match(Me.Input, Pattern)
        If Matcher.Success Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function IsRuc(ByVal Input As String) As Boolean
        Me.Input = Input
        Me.Pattern = "\b[jJ][0-9]{13}\b"
        Matcher = Regex.Match(Me.Input, Pattern)
        If Matcher.Success Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function IsInss(ByVal Input As String) As Boolean
        Me.Input = Input
        Me.Pattern = "[0-9]{7}"
        Matcher = Regex.Match(Me.Input, Pattern)
        If Matcher.Success Then
            Return True
        Else
            Return False
        End If

    End Function

End Class
