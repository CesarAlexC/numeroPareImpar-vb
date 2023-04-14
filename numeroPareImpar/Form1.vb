Public Class Form1
    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        Numero.Clear()
        resultadoImpar.Text = ""
        resultadoPar.Text = ""
    End Sub

    Private Sub Evaluar_Click(sender As Object, e As EventArgs) Handles Evaluar.Click
        Dim num As Integer
        num = Val(Numero.Text)


    End Sub
End Class
