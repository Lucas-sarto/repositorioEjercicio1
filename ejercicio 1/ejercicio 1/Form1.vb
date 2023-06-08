Public Class Form1

    Private Sub cmdEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEjecutar.Click
        Dim a As Integer
        Dim b As Integer
        a = txta.Text
        b = Txtb.Text

        If a < b Then
            lblsalida.Text = "El mayor es " & b
        Else
            lblsalida.Text = "El mayor es " & a
        End If
    End Sub
End Class
