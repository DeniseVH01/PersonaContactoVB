Public Class Contacto
    Inherits Persona

    Protected Telefono As String
    Protected CorreoElect As String

    Public Property TelefonoP() As String
        Get

            Return Telefono
        End Get
        Set(value As String)
            Telefono = value
        End Set
    End Property

    Public Property CorreoElectP() As String
        Get

            Return CorreoElect

        End Get
        Set(value As String)
            CorreoElect = value
        End Set
    End Property

    Public Sub Contacto(ByVal Nombre1 As String, ByVal APPat1 As String, ByVal APMat1 As String, ByVal FechaN1 As Date, ByVal RFC1 As String, ByVal Telef1 As String, ByVal correoelect1 As String)
        Nombre = Nombre1
        ApellidoPP = APPat1
        ApellidoM = APMat1
        FechaN = FechaN1
        RFC = RFC1
        TelefonoP = Telef1
        CorreoElect = correoelect1
    End Sub

    Public ReadOnly Property Info() As String
        Get
            Dim Cadena As String
            Cadena = "NOMBRE: " + NombreP() + " " + ApellidoPP() + " " + ApellidoPM() & vbCrLf + "FECHA NACIMIENTO: " + FechaNP().ToShortDateString & vbCrLf + "TELEFONO: " + TelefonoP.ToString & vbCrLf + "CORREO ELECTRONICO: " + CorreoElectP.ToString & vbCrLf + "RFC: " + RFCP().ToString & vbCrLf
            Return Cadena
        End Get

    End Property
End Class
