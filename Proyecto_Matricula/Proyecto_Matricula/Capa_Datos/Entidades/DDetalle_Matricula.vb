Public Class DDetalle_Matricula
    Dim _iddcurso, _idmatr, _idcurso, _idhora As Integer

    Public Property IDDCurso
        Get
            Return _iddcurso

        End Get
        Set(ByVal value)
            _iddcurso = value
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
    Public Property IDCursos
        Get
            Return _idcurso

        End Get
        Set(ByVal value)
            _idcurso = value
        End Set
    End Property
    Public Property IDCurso
        Get
            Return _idcurso

        End Get
        Set(ByVal value)
            _idcurso = value
        End Set
    End Property
    Public Property IDHora
        Get
            Return _idhora

        End Get
        Set(ByVal value)
            _idhora = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(ByVal idc As Integer, ByVal desp As Integer, ByVal idm As Integer, ByVal idh As Integer)
        IDDCurso = idc
        IDCurso = desp
        IDMatricula = idm
        IDHora = idh

    End Sub
End Class
