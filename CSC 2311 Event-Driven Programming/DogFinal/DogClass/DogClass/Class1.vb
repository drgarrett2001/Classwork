Option Strict On
Public Class Dog
    Private strName As String
    Private strBreed As String
    Private intAge As Integer

    Public Sub New(ByVal bvstrName As String, ByVal bvstrBreed As String, ByVal bvintAge As Integer)
        Me.prpName = bvstrName
        Me.prpBreed = bvstrBreed
        Me.prpAge = bvintAge
    End Sub

    Public Sub New()
        Me.prpName = ""
        Me.prpBreed = ""
        Me.prpAge = 0
    End Sub

    Public Property prpName() As String
        Get
            Return strName
        End Get
        Set(value As String)
            strName = value
        End Set
    End Property

    Public Property prpBreed() As String
        Get
            Return strBreed
        End Get
        Set(value As String)
            strBreed = value
        End Set
    End Property

    Public Property prpAge() As Integer
        Get
            Return intAge
        End Get
        Set(value As Integer)
            intAge = value
        End Set
    End Property

    Public ReadOnly Property IsOld() As Boolean
        Get
            Dim old As Boolean
            If intAge > 10 Then
                old = True
            Else
                old = False
            End If
            Return old
        End Get
    End Property

    Public Overridable Function funReturnClassAttributes() As String
        Return Me.prpName & ", " & Me.prpBreed & ", " & Me.prpAge.ToString()
    End Function

End Class
