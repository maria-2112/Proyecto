Public Class DDetalle_Cuotas_Extras
    Dim _iddcuotaext, _idext, _idmatr As Integer

    Public Property IDDCuotaExt
        Get
            Return _iddcuotaext

        End Get
        Set(ByVal value)
            _iddcuotaext = value
        End Set
    End Property

    Public Property IDExtra
        Get
            Return _idext

        End Get
        Set(ByVal value)
            _idext = value
        End Set
    End Property

    Public Property IDMatricula
        Get
            Return _idmatr

        End Get
        Set(ByVal value)
            _idmatr = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(ByVal idc As Integer, ByVal desp As Integer, ByVal desps As Integer)
        IDDCuotaExt = idc
        IDExtra = desp
        IDMatricula = desps


    End Sub
End Class
