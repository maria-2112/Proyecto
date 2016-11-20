Public Class DHorario
    Dim _idhora As Integer
    Dim _desc As String
    Dim _fecha As Date

    Public Property IDHorario
        Get
            Return _idhora

        End Get
        Set(ByVal value)
            _idhora = value
        End Set
    End Property

    Public Property Descripcion
        Get
            Return _desc

        End Get
        Set(ByVal value)
            _desc = value
        End Set
    End Property

    Public Property Fecha
        Get
            Return _fecha

        End Get
        Set(ByVal value)
            _fecha = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(ByVal idc As Integer, ByVal desp As String,ByVal fec As Date)
        IDHorario = idc
        Descripcion = desp
        Fecha = fec


    End Sub

End Class
