Public Class Pokemon
    Private strName As String
    Private intHP, intAtk, intDef, intSpA, intSpD, intSpe, intStatTotal As Integer

    Public Sub New(ByVal bvstrName As String, ByVal bvintHP As Integer, ByVal bvintAtk As Integer, ByVal bvintDef As Integer, ByVal bvintSpA As Integer, ByVal bvintSpD As Integer, ByVal bvintSpe As Integer)
        Me.prpName = bvstrName
        Me.prpHP = bvintHP
        Me.prpAtk = bvintAtk
        Me.prpDef = bvintDef
        Me.prpSpA = bvintSpA
        Me.prpSpD = bvintSpD
        Me.prpSpe = bvintSpe
        Me.intStatTotal = bvintHP + bvintAtk + bvintDef + bvintSpA + bvintSpD + bvintSpe
    End Sub

    Public Property prpName() As String
        Get
            Return strName
        End Get
        Set(value As String)
            strName = value
        End Set
    End Property

    Public Property prpHP() As Integer
        Get
            Return intHP
        End Get
        Set(value As Integer)
            intHP = value
        End Set
    End Property

    Public Property prpAtk() As Integer
        Get
            Return intAtk
        End Get
        Set(value As Integer)
            intAtk = value
        End Set
    End Property

    Public Property prpDef() As Integer
        Get
            Return intDef
        End Get
        Set(value As Integer)
            intDef = value
        End Set
    End Property

    Public Property prpSpA() As Integer
        Get
            Return intSpA
        End Get
        Set(value As Integer)
            intSpA = value
        End Set
    End Property

    Public Property prpSpD() As Integer
        Get
            Return intSpD
        End Get
        Set(value As Integer)
            intSpD = value
        End Set
    End Property

    Public Property prpSpe() As Integer
        Get
            Return intSpe
        End Get
        Set(value As Integer)
            intSpe = value
        End Set
    End Property

    Public ReadOnly Property prpStatTotal() As Integer
        Get
            Return intStatTotal
        End Get
    End Property

End Class