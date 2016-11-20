Public Class DCuotas_Extras
    Dim _idcursoext As Integer
    Dim _descripcion As String
    Dim _costo As Decimal

    Public Property IDCursoExtra
        Get
            Return _idcursoext

        End Get
        Set(ByVal value)
            _idcursoext = value
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
    Public Sub New(ByVal idc As Integer, ByVal desp As String, ByVal cost As Decimal)
        IDCursoExtra = idc
        Descripcion = desp
        Costo = cost

    End Sub
End Class
