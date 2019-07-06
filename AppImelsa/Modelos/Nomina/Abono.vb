Public Class Abono
    Private _code As String
    Private _date_Abono As Date
    Private _abono As Double
    Private _prestamo As String

    Public Property Code As String
        Get
            Return _code
        End Get
        Set(value As String)
            _code = value
        End Set
    End Property

    Public Property Date_Abono As Date
        Get
            Return _date_Abono
        End Get
        Set(value As Date)
            _date_Abono = value
        End Set
    End Property

    Public Property Abono As Double
        Get
            Return _abono
        End Get
        Set(value As Double)
            _abono = value
        End Set
    End Property

    Public Property Prestamo As String
        Get
            Return _prestamo
        End Get
        Set(value As String)
            _prestamo = value
        End Set
    End Property
End Class
