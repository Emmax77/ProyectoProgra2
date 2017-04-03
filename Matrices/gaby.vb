Public Class Form1
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


    Function eliminar(num As Integer, num2 As Integer, dato As Integer) As Integer

        Dim x, y As Integer
        Dim menor As String
        Dim ver As String = "" 'Lo que debe quedar cuando se elimina un espacio
        Dim espacio As String = " "
        Dim aux As String = -1
        Dim mat2(num, num2) As String
        Dim mat(num) As String

        For i = 0 To mat2.GetUpperBound(0)

            For j = 0 To mat2.GetUpperBound(1)
                Dim aleatorio As Integer = CInt((2 * Rnd()) + 1)
                mat2(i, j) = aleatorio

                If mat2(i, j) = dato Then
                    mat2(i, j) = 0
                    If mat2(i, j) = 0 Then
                        mat2(i, j) = ver
                        If mat2(i, j) = espacio Then
                            For k = 0 To mat.Length - 1 'El primer vector recorre
                                menor = k
                                For L = k + 1 To mat.Length - 1
                                    If mat(menor) > mat(L) Then
                                        menor = k
                                        If mat(k) = 2 Then
                                            mat(k) = ver
                                            If mat(k) = ver Then
                                                aux = aux + mat(k)

                                                'La linea 95 hasta la 101 realiza la funcion de eliminar el espacio 

                                            End If
                                        End If
                                    End If
                                Next
                                aux = mat(menor)
                                mat(menor) = mat(j)
                                mat(j) = aux

                            Next
                        End If
                        mat(j) += 1
                    End If
                End If
             

                ver += mat2(i, j).ToString
            Next

            ver += vbCrLf
        Next
        MessageBox.Show(ver)
    End Function



    'La funcion EliminarValor,
    '    elimina el numero aleatorio que entre y lo elimina y quita el espacio
    Function EliminarValor(datos() As String)
        Dim vector() As String = datos  'Define el vector
        Dim menor As String
        Dim ver As String = "" 'Lo que debe quedar cuando se elimina un espacio
        Dim aux As String = -1

        For i = 0 To vector.Length - 1 'El primer vector recorre
            menor = i
            For j = i + 1 To vector.Length - 1 'verifica el vector que se encuentra en las filas
                If vector(menor) > vector(j) Then 'lo ordena
                    menor = j
                    If vector(j) = 2 Then
                        vector(j) = ver
                        If vector(j) = ver Then
                            aux = aux + vector(j)

                            'La linea 95 hasta la 101 realiza la funcion de eliminar el espacio 

                        End If
                    End If
                End If
            Next
            aux = vector(menor)
            vector(menor) = vector(i)
            vector(i) = aux

        Next
    End Function

    Function quitarBlancos(hilera As String) As Integer
        Dim resp As Integer = -1

        For index = 0 To hilera.Length - 1
            If hilera.Chars(index) <> " " Then
                resp = resp + hilera.Chars(index).ToString
            End If
        Next
        Return resp
    End Function




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'hacerMatriz(19, 14)
        'Dim dato As Integer = 2
        'MsgBox(eliminar(3, 3, 2))
        'Dim s As String = "hola  carlos "
        'Dim o As Integer = 12


        Dim vec() As String = {2, 7, 8, 2, 10, 1}
        EliminarValor(vec)
        Dim str As String = ""

        For i = 0 To vec.Length - 1
            str = str & vec(i).ToString & " "
        Next
        MsgBox(str)


        MsgBox(eliminar(2, 2, 2))


        'Dim mt(,) As Integer = {{1, 2, 3, 4, 5}, {6, 2, 8, 9, 10}, {11, 2, 13, 14, 15}, {16, 2, 18, 19, 20}, {2, 2, 2, 24, 25}}
        'MsgBox(convertir(mt, 6))

    End Sub
End Class
