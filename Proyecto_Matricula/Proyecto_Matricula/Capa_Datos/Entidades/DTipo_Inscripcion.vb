Public Class DTipo_Inscripcion
    Dim _idins As Integer
    Dim _desc As String

    Public Property IDTipoInscripcion
        Get
            Return _idins

        End Get
        Set(ByVal value)
            _idins = value
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
    Public Sub New()

    End Sub
    Public Sub New(ByVal idc As Integer, ByVal des As String)
        IDTipoInscripcion = idc
        Descripcion = des

    End Sub
End Class
