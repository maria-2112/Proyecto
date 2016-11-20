Public Class DTipo_Estudiante
    Dim _idtest As Integer
    Dim _desc As String

    Public Property IDTipoEstudiante
        Get
            Return _idtest

        End Get
        Set(ByVal value)
            _idtest = value
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
        IDTipoEstudiante = idc
        Descripcion = des

    End Sub
End Class
