Public Class EmailClient
    Private _code As String
    Private _email As String
    Private _codeClient As String

    Public Property Code As String
        Get
            Return _code
        End Get
        Set(value As String)
            _code = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property CodeClient As String
        Get
            Return _codeClient
        End Get
        Set(value As String)
            _codeClient = value
        End Set
    End Property
End Class
