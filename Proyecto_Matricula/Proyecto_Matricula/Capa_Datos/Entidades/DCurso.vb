Public Class DCurso
    Dim _idcurso, _idsede, _cupo As Integer
    Dim _nombre, _descripcion As String
    Dim _costo As Decimal

    Public Property IDCurso
        Get
            Return _idcurso

        End Get
        Set(ByVal value)
            _idcurso = value
        End Set
    End Property
    Public Property IDSede
        Get
            Return _idsede
        End Get
        Set(ByVal value)
            _idsede = value
        End Set
    End Property

    Public Property Cupo
        Get
            Return _cupo

        End Get
        Set(ByVal value)
            _cupo = value
        End Set
    End Property

    Public Property Nombre
        Get
            Return _nombre
        End Get
        Set(ByVal value)
            _nombre = value
        End Set
    End Property

    Public Property Descripcion
        Get
            Return _descripcion
        End Get
        Set(ByVal value)
            _descripcion = value
        End Set
    End Property

    Public Property Costo
        Get
            Return _costo
        End Get
        Set(ByVal value)
            _costo = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(ByVal idc As Integer, ByVal nom As String, ByVal ids As Integer, ByVal cuo As Integer, ByVal desp As String, ByVal cost As Decimal)
        IDCurso = idc
        Nombre = nom
        IDSede = ids
        Cupo = cuo
        Descripcion = desp
        Costo = cost
    End Sub

End Class
