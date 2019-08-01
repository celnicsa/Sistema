Public Class Turno
    Private _code As String
    Private _name As String
    Private _hsStart As String
    Private _hsEnd As String

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

    Public Property HsStart As String
        Get
            Return HsStart1
        End Get
        Set(value As String)
            HsStart1 = value
        End Set
    End Property

    Public Property HsStart1 As String
        Get
            Return _hsStart
        End Get
        Set(value As String)
            _hsStart = value
        End Set
    End Property

    Public Property HsEnd As String
        Get
            Return _hsEnd
        End Get
        Set(value As String)
            _hsEnd = value
        End Set
    End Property
End Class
