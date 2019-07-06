Public Class Salario
    Private _code As String
    Private _sMensual As Decimal
    Private _sQuincenal As Decimal
    Private _sHora As Decimal

    Public Property Code As String
        Get
            Return _code
        End Get
        Set(value As String)
            _code = value
        End Set
    End Property

    Public Property SMensual As Decimal
        Get
            Return _sMensual
        End Get
        Set(value As Decimal)
            _sMensual = value
        End Set
    End Property

    Public Property SQuincenal As Decimal
        Get
            Return _sQuincenal
        End Get
        Set(value As Decimal)
            _sQuincenal = value
        End Set
    End Property

    Public Property SHora As Decimal
        Get
            Return _sHora
        End Get
        Set(value As Decimal)
            _sHora = value
        End Set
    End Property
End Class
