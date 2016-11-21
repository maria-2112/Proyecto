Public Class DDetalle_Matricula
    Dim _iddMatrcula, _idmatr, _idcurso, _idhora As Integer

    Public Property IDDMatricula
        Get
            Return _iddMatrcula

        End Get
        Set(ByVal value)
            _iddMatrcula = value
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
        IDDMatricula = idc
        IDCurso = desp
        IDMatricula = idm
        IDHora = idh

    End Sub
End Class
