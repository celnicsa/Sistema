Public Class Employed
    Private _code As String
    Private _name As String
    Private _apellido As String
    Private _sexo As String
    Private _dateNaci As Date
    Private _identi As String
    Private _inss As String
    Private _direc As String
    Private _photo As Image
    Private _codeProyect As String
    Private _codeCargo As String
    Private _codeTurno As String
    Private _codeSalario As String
    Private _codigoescolaridad As String
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

    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Public Property DateNaci As Date
        Get
            Return _dateNaci
        End Get
        Set(value As Date)
            _dateNaci = value
        End Set
    End Property

    Public Property Identi As String
        Get
            Return _identi
        End Get
        Set(value As String)
            _identi = value
        End Set
    End Property

    Public Property Inss As String
        Get
            Return _inss
        End Get
        Set(value As String)
            _inss = value
        End Set
    End Property

    Public Property Direc As String
        Get
            Return _direc
        End Get
        Set(value As String)
            _direc = value
        End Set
    End Property

    Public Property CodeProyect As String
        Get
            Return _codeProyect
        End Get
        Set(value As String)
            _codeProyect = value
        End Set
    End Property

    Public Property CodeCargo As String
        Get
            Return _codeCargo
        End Get
        Set(value As String)
            _codeCargo = value
        End Set
    End Property

    Public Property Photo As Image
        Get
            Return _photo
        End Get
        Set(value As Image)
            _photo = value
        End Set
    End Property

    Public Property CodeTurno As String
        Get
            Return _codeTurno
        End Get
        Set(value As String)
            _codeTurno = value
        End Set
    End Property

    Public Property CodeSalario As String
        Get
            Return _codeSalario
        End Get
        Set(value As String)
            _codeSalario = value
        End Set
    End Property

    Public Property Sexo As String
        Get
            Return _sexo
        End Get
        Set(value As String)
            _sexo = value
        End Set
    End Property


    Public Property Escolaridad As String
        Get
            Return _codigoescolaridad
        End Get
        Set(value As String)
            _codigoescolaridad = value
        End Set
    End Property
End Class
