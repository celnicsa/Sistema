Public Class Escolaridad

    Private Codigo_Escolaridad As String
    Private Nombre_Grado As String
    Private Beneficio_Grado As Decimal

    Public Property P_Codigo_Escolaridad As String
        Get
            Return Codigo_Escolaridad
        End Get
        Set(value As String)
            Codigo_Escolaridad = value
        End Set
    End Property


    Public Property P_Nombre_Grado As String
        Get
            Return Nombre_Grado
        End Get
        Set(value As String)
            Nombre_Grado = value
        End Set
    End Property

    Public Property P_Beneficio_Grado As String
        Get
            Return Beneficio_Grado
        End Get
        Set(value As String)
            Beneficio_Grado = value
        End Set
    End Property

End Class
