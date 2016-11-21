Public Class DMatricula
    Dim _idmatr, _idsede, _idest, _idinsc, _idpago As Integer
    Dim _nomb, _tipodoc, _numdoc As String
    Dim _fec As Date

    Public Property IDMatricula
        Get
            Return _idmatr

        End Get
        Set(ByVal value)
            _idmatr = value
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
    Public Property IDEstudiante
        Get
            Return _idest

        End Get
        Set(ByVal value)
            _idest = value
        End Set
    End Property
    Public Property IDInscripcion
        Get
            Return _idinsc

        End Get
        Set(ByVal value)
            _idinsc = value
        End Set
    End Property
    Public Property IDFormaPago
        Get
            Return _idpago

        End Get
        Set(ByVal value)
            _idpago = value
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
    Public Property TipoDoc
        Get
            Return _tipodoc
        End Get
        Set(ByVal value)
            _tipodoc = value
        End Set
    End Property
    Public Property NumDoc
        Get
            Return _numdoc

        End Get
        Set(ByVal value)
            _numdoc = value
        End Set
    End Property
    Public Property FechaMatricula
        Get
            Return _fec

        End Get
        Set(ByVal value)
            _fec = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(ByVal idm As Integer, ByVal ids As Integer, ByVal ide As Integer, ByVal idin As Integer, ByVal idfp As Integer, ByVal nom As String, ByVal tipo As String, ByVal num As String, ByVal fec As Date)
        IDMatricula = idm
        IDSede = ids
        IDEstudiante = ide
        IDInscripcion = idin
        IDFormaPago = idfp
        Nombre = nom
        TipoDoc = tipo
        NumDoc = num
        FechaMatricula = fec

    End Sub
End Class
