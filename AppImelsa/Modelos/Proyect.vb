Public Class Proyect
    Private _code As String
    Private _name As String
    Private _presupuesto As Decimal
    Private _dateStar As Date
    Private _dateEnd As Date
    Private _descripcion As String
    Private _ubicacion As String
    Private _estado As Int16
    Private _cliente As String

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

    Public Property Presupuesto As Decimal
        Get
            Return _presupuesto
        End Get
        Set(value As Decimal)
            _presupuesto = value
        End Set
    End Property

    Public Property DateStar As Date
        Get
            Return _dateStar
        End Get
        Set(value As Date)
            _dateStar = value
        End Set
    End Property

    Public Property DateEnd As Date
        Get
            Return _dateEnd
        End Get
        Set(value As Date)
            _dateEnd = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Ubicacion As String
        Get
            Return _ubicacion
        End Get
        Set(value As String)
            _ubicacion = value
        End Set
    End Property

    Public Property Estado As Short
        Get
            Return _estado
        End Get
        Set(value As Short)
            _estado = value
        End Set
    End Property

    Public Property Cliente As String
        Get
            Return _cliente
        End Get
        Set(value As String)
            _cliente = value
        End Set
    End Property
End Class
