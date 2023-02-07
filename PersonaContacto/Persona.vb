Public Class Persona
    Protected Nombre As String
    Protected ApellidoP As String
    Protected ApellidoM As String
    Protected FechaN As Date
    Protected RFC As String

    Public Property NombreP() As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property

    Public Property ApellidoPP() As String
        Get
            Return ApellidoP
        End Get
        Set(value As String)
            ApellidoP = value
        End Set
    End Property

    Public Property ApellidoPM() As String
        Get
            Return ApellidoM
        End Get
        Set(value As String)
            ApellidoM = value
        End Set
    End Property

    Public Property FechaNP() As Date
        Get
            Return FechaN
        End Get
        Set(value As Date)
            FechaN = value
        End Set
    End Property

    Public ReadOnly Property RFCP() As String
        Get
            RFC = UCase(Mid(ApellidoP, 1, 2) + Mid(ApellidoM, 1, 1) + Mid(Nombre, 1, 1)) + Mid(FechaN, 9, 2) + Mid(FechaN, 4, 2) + Mid(FechaN, 1, 2)
            Return RFC
        End Get

    End Property

    Public Sub Persona(ByVal Nombre1 As String, ByVal APPat1 As String, ByVal APMat1 As String, ByVal FechaN1 As Date, ByVal RFC1 As String)
        Nombre = Nombre1
        ApellidoPP = APPat1
        ApellidoM = APMat1
        FechaN = FechaN1
        RFC = RFC1
    End Sub


End Class
