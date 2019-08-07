Public Class Articulo
    Private _articulo As String
    Private _categoria As String
    Private _proyecto As String
    Private _name As String
    Private _descripcion As String
    Private _stock As String


    Public Property Articulo As String
        Get
            Return _articulo
        End Get
        Set(value As String)
            _articulo = value
        End Set
    End Property
    Public Property Categoria As String
        Get
            Return _categoria
        End Get
        Set(value As String)
            _categoria = value
        End Set
    End Property

    Public Property Proyecto As String
        Get
            Return _proyecto
        End Get
        Set(value As String)
            _proyecto = value
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

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property
    Public Property Stock As String
        Get
            Return _stock
        End Get
        Set(value As String)
            _stock = value
        End Set
    End Property


End Class


