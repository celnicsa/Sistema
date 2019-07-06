Public Class CelEmployed
    Private _code As String
    Private _tel As String
    Private _codeEmployed As String

    Public Property Code As String
        Get
            Return _code
        End Get
        Set(value As String)
            _code = value
        End Set
    End Property

    Public Property Tel As String
        Get
            Return _tel
        End Get
        Set(value As String)
            _tel = value
        End Set
    End Property

    Public Property CodeEmployed As String
        Get
            Return _codeEmployed
        End Get
        Set(value As String)
            _codeEmployed = value
        End Set
    End Property

End Class
