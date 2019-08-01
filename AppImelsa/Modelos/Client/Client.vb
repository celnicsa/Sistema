Public Class Client
    Private _code As String
    Private _name As String
    Private _ruc As String
    Private _addres As String
    Private _perfil As String

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

    Public Property Ruc As String
        Get
            Return _ruc
        End Get
        Set(value As String)
            _ruc = value
        End Set
    End Property

    Public Property Addres As String
        Get
            Return _addres
        End Get
        Set(value As String)
            _addres = value
        End Set
    End Property

    Public Property Perfil As String
        Get
            Return _perfil
        End Get
        Set(value As String)
            _perfil = value
        End Set
    End Property
End Class
