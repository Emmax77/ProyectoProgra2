Public Class Duck_Crush
    Dim matEnteros(,) As Integer
    Dim mat(,) As Button
    Dim matAux(19, 19) As Integer
    Private Sub btNuevoJuego_Click(sender As Object, e As EventArgs) Handles btNuevoJuego.Click
        mostrarMat(hacerMatriz(19, 19))
    End Sub

    'Funcion para crear una matriz de botones con numeros random
    Function hacerMatriz(num As Integer, num2 As Integer)
        ReDim mat(num, num2) 'creamos una matriz de tipo button con el tamaño enviado
        ReDim matEnteros(num, num2)
        Dim cont As Integer = 0 'contador para asignar el nombre del boton
        Dim posicionAncho As Integer = 0 'para colocar la posicion de ancho en el panel
        Dim posicionAlto As Integer = 0 'para colocar la posicion de alto en el panel
        'creamos la matriz de botones
        For i = 0 To mat.GetUpperBound(0)
            For j = 0 To mat.GetUpperBound(1)
                cont += 1 'cada vez que cambie le suma un numero al contador
                Dim aleatorio As Integer = CInt((2 * Rnd()) + 1) 'el valor random de 1 a 3 para el boton
                mat(i, j) = New Button 'creamos un boton en el objeto de la matriz
                mat(i, j).Name = CStr("bt" & cont) 'colocamos el nombre al boton
                mat(i, j).Text = aleatorio 'se cambia por la imagen del patito
                matEnteros(i, j) = aleatorio
                mat(i, j).BackgroundImageLayout = ImageLayout.Stretch
                If aleatorio = 1 Then
                    mat(i, j).BackgroundImage = My.Resources.patoA
                ElseIf aleatorio = 2 Then
                    mat(i, j).BackgroundImage = My.Resources.patoR
                Else
                    mat(i, j).BackgroundImage = My.Resources.patoV
                End If
                mat(i, j).Tag = CStr(i) & "," & CStr(j)
                mat(i, j).Width = 40 'ancho del objeto
                mat(i, j).Height = 40 'alto del objeto
                mat(i, j).Left = posicionAncho 'ancho del panel
                mat(i, j).Top = posicionAlto ' alto del panel
                posicionAncho += 40 'espacio entre entre cada boton en una misma fila
                AddHandler mat(i, j).Click, AddressOf Button_Click
            Next
            posicionAncho = 0 'lo ponemos en 0 para que comience en el primer objeto de la linea de abajo
            posicionAlto += 40 'bajamos a la siguiente fila
        Next

        Return mat 'retorna la matriz de botones hecha
    End Function

    'Este metodo muestra la funcion hacerMatriz en el panel
    Sub mostrarMat(mat(,))
        'recorremos la matriz de botones creadas para insertarnla en el panel
        For k = 0 To mat.GetUpperBound(0)
            For l = 0 To mat.GetUpperBound(1)
                plMat.Controls.Add(mat(k, l)) 'esta propiedad inserta en el panel la matriz
            Next
        Next
    End Sub


    Private Sub Button_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim dato As String = ""
        dato = CType(sender, System.Windows.Forms.Button).Tag
        Dim numero As Integer = CType(sender, System.Windows.Forms.Button).Text
        dato.ToArray
        Dim uno As String = ""
        Dim dos As String = ""
        Dim cont As Integer = 0
        For i = 0 To dato.Length - 1
            If cont > 0 Then
                dos += dato(i).ToString
            ElseIf dato(i) = "," Then
                cont += 1
            Else
                uno += dato(i).ToString
            End If

        Next
        'CType(sender, System.Windows.Forms.Button).BackgroundImage = My.Resources.patoV 'aqui debo colocar la imagen en negro
        'eliminarPatosIguales(CInt(uno), CInt(dos), numero)
        mismoPato(CInt(uno), CInt(dos))
    End Sub

    Dim lista As ArrayList
    Sub mismoPato(fila As Integer, columna As Integer)
        Dim numeroPatoElegido As Integer = matEnteros(fila, columna)
        lista = New ArrayList
        lista.Add(New Point(fila, columna))
        'MessageBox.Show(lista(0).ToString) posicion x y y de el boton
        While lista.Count > 0
            examinaPosicionesAlrededor()
        End While

        For i = 0 To matAux.GetUpperBound(0)
            For j = 0 To matAux.GetUpperBound(1)
                If matAux(i, j) > 0 Then
                    mat(i, j).BackgroundImage = My.Resources.color_negro
                    mat(i, j).Text = 0
                End If
            Next
        Next


    End Sub


    Private Sub examinaPosicionesAlrededor()
        Dim localizacion As Point = CType(lista(0), Point)
        Dim numeroDelActual As Integer = matEnteros(localizacion.X, localizacion.Y)
        Dim fila As Integer = localizacion.X
        Dim columna As Integer = localizacion.Y
        lista.RemoveAt(0)

        Dim siguienteFila As Integer
        Dim siguienteColumna As Integer
        Dim numeroSiguientePato As Object

        'abajo
        If fila < matEnteros.GetUpperBound(0) - 1 Then
            siguienteFila = fila + 1
            numeroSiguientePato = matEnteros(siguienteFila, columna)
            verPato(numeroSiguientePato, siguienteFila, columna, numeroDelActual)
        End If

        'arriba
        If fila > 0 Then
            siguienteFila = fila - 1
            numeroSiguientePato = matEnteros(siguienteFila, columna)
            verPato(numeroSiguientePato, siguienteFila, columna, numeroDelActual)
        End If


        'izquierda
        If columna > 0 Then
            siguienteColumna = columna - 1
            numeroSiguientePato = matEnteros(fila, siguienteColumna)
            verPato(numeroSiguientePato, fila, siguienteColumna, numeroDelActual)
        End If

        'derecha
        If columna < matEnteros.GetLength(1) - 1 Then
            siguienteColumna = columna + 1
            numeroSiguientePato = matEnteros(fila, siguienteColumna)
            verPato(numeroSiguientePato, fila, siguienteColumna, numeroDelActual)
        End If

    End Sub

    Private Sub verPato(elegido As Object, f As Integer, c As Integer, numeroDelactual As Integer)
        If Not elegido Is Nothing Then
            If Not matEnteros(f, c) = matAux(f, c) Then
                If elegido = numeroDelactual Then
                    lista.Add(New Point(f, c))
                    matAux(f, c) = matEnteros(f, c)
                End If
            End If
        End If
    End Sub
End Class
