Public Class Form1

    Private Sub btNuevoJuego_Click(sender As Object, e As EventArgs) Handles btNuevoJuego.Click
        hacerMatriz(19, 14)
    End Sub

    'Metodo para crear una matriz con numeros random
    Sub hacerMatriz(num As Integer, num2 As Integer)
        Dim mat(num, num2) As Button
        Dim cont As Integer = 0 'contador para asignar el nombre del boton
        Dim posicionAncho As Integer = 0 'para colocar la posicion de ancho en el panel
        Dim posicionAlto As Integer = 0 'para colcoar la posicion de alto en el panel

        'recorremos la matriz
        For i = 0 To mat.GetUpperBound(0)
            For j = 0 To mat.GetUpperBound(1)
                cont += 1 'cada vez que cambie le suma un numero al contador
                Dim aleatorio As Integer = CInt((2 * Rnd()) + 1) 'el valor random de 1 a 3 para el boton
                mat(i, j) = New Button 'creamos un boton en el objeto de la matriz
                mat(i, j).Name = CStr("bt" & cont) 'colocamos el nombre al boton
                mat(i, j).Text = aleatorio 'se cambia por l imagen del patito
                mat(i, j).Width = 20 'ancho del objeto
                mat(i, j).Height = 20 'alto del objeto
                mat(i, j).Left = posicionAncho 'ancho del panel
                mat(i, j).Top = posicionAlto ' alto del panel
                posicionAncho += 20 'espacio entre entre cada boton en una misma fila
            Next
            posicionAncho = 0 'lo ponemos en 0 para que comience en el primer objeto de la linea de abajo
            posicionAlto += 20 'bajamos a la siguiente fila
        Next

        'recorremos la matriz de botones creadas para insertarnla en el panel
        For k = 0 To mat.GetUpperBound(0)
            For l = 0 To mat.GetUpperBound(1)
                plMat.Controls.Add(mat(k, l)) 'esta propiedad inserta en el panel la matriz
            Next
        Next

    End Sub
End Class
