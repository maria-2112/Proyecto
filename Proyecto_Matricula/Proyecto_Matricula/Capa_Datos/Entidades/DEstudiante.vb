Public Class DEstudiante

    Dim _idest, _idtipo As Integer
    Dim _nombres, _apellidos, _direccion, _telefono, _cedula As String
    Dim _fechaNacimien As Date


    'seeter y getter

    Public Property IDEstudiante
        Get
            Return _idest
        End Get
        Set(ByVal value)
            _idest = value
        End Set
    End Property
    Public Property IDTipoEstudiante
        Get
            Return _idtipo
        End Get
        Set(ByVal value)
            _idtipo = value
        End Set
    End Property

    Public Property Nombres
        Get
            Return _nombres
        End Get
        Set(ByVal value)
            _nombres = value
        End Set
    End Property

    Public Property Apellidos
        Get
            Return _apellidos
        End Get
        Set(ByVal value)
            _apellidos = value
        End Set
    End Property
    Public Property FechaNac
        Get
            Return _fechaNacimien
        End Get
        Set(ByVal value)
            _fechaNacimien = value
        End Set
    End Property


    Public Property Direccion
        Get
            Return _direccion
        End Get
        Set(ByVal value)
            _direccion = value
        End Set
    End Property

    Public Property Telefono
        Get
            Return _telefono
        End Get
        Set(ByVal value)
            _telefono = value
        End Set
    End Property

    Public Property Cedula
        Get
            Return _cedula

        End Get
        Set(ByVal value)
            _cedula = value
        End Set
    End Property

    'constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As Integer, ByVal nom As String, ByVal apel As String, ByVal direc As String, ByVal tel As String, ByVal dni As String)
        'IDcliente = id
        Nombres = nom
        Apellidos = apel
        Direccion = direc
        Telefono = tel
        Cedula = dni

    End Sub



End Class
