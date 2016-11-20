Public Class DCurso_Hora
    Dim _idcurhora, _idcurso, _idhora As Integer

    Public Property IDCurHorario
        Get
            Return _idcurhora

        End Get
        Set(ByVal value)
            _idcurhora = value
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
    Public Sub New(ByVal idc As Integer, ByVal desp As Integer)
        IDCurso = idc
        IDHora = desp

    End Sub
End Class
