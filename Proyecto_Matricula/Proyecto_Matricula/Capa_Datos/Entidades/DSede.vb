Public Class DSede
    Dim _idsede As Integer
    Dim _nomb, _dic, _telf As String
    Public Property IDSede
        Get
            Return _idsede

        End Get
        Set(ByVal value)
            _idsede = value
        End Set
    End Property

    Public Property Nombre
        Get
            Return _nomb

        End Get
        Set(ByVal value)
            _nomb = value
        End Set
    End Property

    Public Property Direccion
        Get
            Return _dic

        End Get
        Set(ByVal value)
            _dic = value
        End Set
    End Property
    Public Property Telefono
        Get
            Return _telf

        End Get
        Set(ByVal value)
            _telf = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(ByVal idc As Integer, ByVal nom As String, ByVal drec As String, ByVal telef As String)
        IDSede = idc
        Nombre = nom
        Direccion = drec
        Telefono = telef

    End Sub

End Class
