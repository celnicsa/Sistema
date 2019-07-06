Public Class Cargo
    Private _code As String
    Private _name As String
    Private _codeArea As String

    Public Property Code As String
        Get
            Return _code
        End Get
        Set(value As String)
            _code = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property CodeArea As String
        Get
            Return _codeArea
        End Get
        Set(value As String)
            _codeArea = value
        End Set
    End Property

End Class
