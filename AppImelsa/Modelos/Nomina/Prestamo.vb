Public Class Prestamo
    Private _code As String
    Private _datePres As Date
    Private _monto As Decimal
    Private _cuota As Decimal
    Private _saldo As Decimal
    Private _employed As String

    Public Property Code As String
        Get
            Return _code
        End Get
        Set(value As String)
            _code = value
        End Set
    End Property

    Public Property DatePres As Date
        Get
            Return _datePres
        End Get
        Set(value As Date)
            _datePres = value
        End Set
    End Property

    Public Property Monto As Decimal
        Get
            Return _monto
        End Get
        Set(value As Decimal)
            _monto = value
        End Set
    End Property

    Public Property Cuota As Decimal
        Get
            Return _cuota
        End Get
        Set(value As Decimal)
            _cuota = value
        End Set
    End Property

    Public Property Saldo As Decimal
        Get
            Return _saldo
        End Get
        Set(value As Decimal)
            _saldo = value
        End Set
    End Property

    Public Property Employed As String
        Get
            Return _employed
        End Get
        Set(value As String)
            _employed = value
        End Set
    End Property
End Class
