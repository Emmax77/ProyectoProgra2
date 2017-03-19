Public Class Form1

    Private Sub btNuevoJuego_Click(sender As Object, e As EventArgs) Handles btNuevoJuego.Click
        hacerMatriz(19, 14)
    End Sub

    'Metodo para crear una matriz con numeros random
    Sub hacerMatriz(num As Integer, num2 As Integer)
        Dim mat(num, num2) As Button
        Dim cont As Integer = 0
        Dim posicionAncho As Integer = 0
        Dim posicionAlto As Integer = 0

        For i = 0 To mat.GetUpperBound(0)
            For j = 0 To mat.GetUpperBound(1)
                cont += 1
                Dim aleatorio As Integer = CInt((2 * Rnd()) + 1)
                mat(i, j) = New Button
                mat(i, j).Name = CStr("bt" & cont)
                mat(i, j).Text = aleatorio 'se cambia por l imagen del patito
                mat(i, j).Width = 20
                mat(i, j).Height = 20
                mat(i, j).Left = posicionAncho
                mat(i, j).Top = posicionAlto
                posicionAncho += 20
            Next
            posicionAncho = 0
            posicionAlto += 20
        Next
        For k = 0 To mat.GetUpperBound(0)
            For l = 0 To mat.GetUpperBound(1)
                plMat.Controls.Add(mat(k, l))
            Next
        Next

    End Sub
End Class
