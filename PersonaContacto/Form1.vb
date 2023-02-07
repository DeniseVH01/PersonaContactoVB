Public Class Form1
    Private Sub BTNlimpiar_Click(sender As Object, e As EventArgs) Handles BTNlimpiar.Click
        TXTnombre.Clear()
        TXTapp.Clear()
        TXTapm.Clear()
        TXTtelef.Clear()
        TXTcorreoe.Clear()
        DTPfn.ResetText()

    End Sub

    Private Sub BTNmostrar_Click(sender As Object, e As EventArgs) Handles BTNmostrar.Click
        Dim Nombre = TXTnombre.Text
        Dim ApellidoP = TXTapp.Text
        Dim ApellidoM = TXTapm.Text
        Dim Telefono = TXTtelef.Text
        Dim CorreoE = TXTcorreoe.Text
        Dim FechaN = DTPfn.Value
        Dim RFC As String
        Dim Contacto1 As Contacto
        Contacto1 = New Contacto()
        Contacto1.Contacto(Nombre, ApellidoP, ApellidoM, FechaN, RFC, Telefono, CorreoE)
        MessageBox.Show(Contacto1.Info, "Contacto")
    End Sub
End Class
