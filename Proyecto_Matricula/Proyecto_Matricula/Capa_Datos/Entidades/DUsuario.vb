Public Class DUsuario

    Private _usuario As String
    Private _pass As String
    Private _nombre As String
    Private _apellidos As String
    Private _codUsuario As Integer
    Private _idRol As Integer
    Public Property IdRol() As String
        Get
            Return _idRol
        End Get
        Set(ByVal value As String)
            _idRol = value
        End Set
    End Property

    Public Property CodUsuario() As Integer
        Get
            Return _codUsuario
        End Get
        Set(ByVal value As Integer)
            _codUsuario = value
        End Set
    End Property
    Public Property Apellido() As String
        Get
            Return _apellidos
        End Get
        Set(ByVal value As String)
            _apellidos = value
        End Set
    End Property


    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property Pass() As String
        Get
            Return _pass
        End Get
        Set(ByVal value As String)
            _pass = value
        End Set
    End Property
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

End Class
