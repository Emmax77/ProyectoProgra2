Public Class Duck_Crush
    'Variables globales
    Dim matEnteros(,) As Integer
    Dim mat(,) As Button
    Dim matAux(,) As Integer
    Dim lista As ArrayList
    Dim acumPermanente As Integer = 0
    Dim acumBolitas As Integer = 0

    'Botones
    Private Sub btNuevoJuego_Click(sender As Object, e As EventArgs) Handles btNuevoJuego.Click
        mostrarMat(hacerMatriz(19, 19))
    End Sub

    Private Sub btEnteros_Click(sender As Object, e As EventArgs) Handles btEnteros.Click
        enteros()
    End Sub

    Private Sub btDificil_Click(sender As Object, e As EventArgs) Handles btDificil.Click
        mostrarMat(hacerMatriz(19, 14))
    End Sub

    Private Sub btMedio_Click(sender As Object, e As EventArgs) Handles btMedio.Click
        mostrarMat(hacerMatriz(14, 14))
    End Sub

    Private Sub btFacil_Click(sender As Object, e As EventArgs) Handles btFacil.Click
        mostrarMat(hacerMatriz(14, 9))
    End Sub



    'Funcion para crear una matriz de botones con numeros random
    Function hacerMatriz(num As Integer, num2 As Integer)
        ReDim mat(num, num2) 'creamos una matriz de tipo button con el tamaño enviado
        ReDim matEnteros(num, num2)
        ReDim matAux(num, num2)
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
                mat(i, j).Width = 34 'ancho del objeto
                mat(i, j).Height = 34 'alto del objeto
                mat(i, j).Left = posicionAncho 'ancho del panel
                mat(i, j).Top = posicionAlto ' alto del panel
                posicionAncho += 34 'espacio entre entre cada boton en una misma fila
                AddHandler mat(i, j).Click, AddressOf Button_Click
            Next
            posicionAncho = 0 'lo ponemos en 0 para que comience en el primer objeto de la linea de abajo
            posicionAlto += 34 'bajamos a la siguiente fila
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
        If numero <> 0 Then
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

            mismoPato(CInt(uno), CInt(dos))
        End If

    End Sub


    Sub mismoPato(fila As Integer, columna As Integer)
        Dim numeroPatoElegido As Integer = matEnteros(fila, columna)
        lista = New ArrayList
        lista.Add(New Point(fila, columna))
        'MessageBox.Show(lista(0).ToString)
        While lista.Count > 0
            examinaPosicionesAlrededor()
        End While


        'coloca el texto en 0 de cada boton que sea igual alrededor y una imagen color negro y reinicia la matriz matAux
        textoCeroYReinicioAux()


        'Repite varias veces el Metodo que ordena toda la matriz de arriba a abajo
        For l = 0 To matEnteros.GetUpperBound(0)
            For m = 0 To matEnteros.GetUpperBound(1)
                If (l - 1) >= 0 Then
                    If matEnteros(l - 1, m) = 0 Then
                        ordenar(matEnteros)
                    End If
                End If
            Next
        Next

        'Repite varias veces el Metodo que ordena toda la matriz de izquierda a derecha
        For a = 0 To matEnteros.GetUpperBound(0)
            For b = 0 To matEnteros.GetUpperBound(1)
                If (b + 1) <= matEnteros.GetUpperBound(1) Then
                    If matEnteros(a, b + 1) = 0 Then
                        ordenarB(matEnteros)
                    End If
                End If
            Next
        Next


        'Metodo que refresca la matriz de botones validando la de enteros
        reducirMatriz(matEnteros)

        'formula que calcula la cantidad de puntos ganados
        acumPermanente += Math.Pow(2, (acumBolitas / 2))
        lbPatitosComidos.Text = acumBolitas
        lbPuntos.Text = acumPermanente
        acumBolitas = 0
    End Sub

    Sub textoCeroYReinicioAux()
        For i = 0 To matAux.GetUpperBound(0)
            For j = 0 To matAux.GetUpperBound(1)
                If matAux(i, j) > 0 Then
                    mat(i, j).BackgroundImage = My.Resources.color_negro
                    mat(i, j).Text = 0
                    matEnteros(i, j) = 0
                End If
            Next
        Next

        For i = 0 To matAux.GetUpperBound(0)
            For j = 0 To matAux.GetUpperBound(1)
                matAux(i, j) = 0
            Next
        Next

    End Sub

    Sub reducirMatriz(matEnteros(,) As Integer)
        For y = 0 To matEnteros.GetUpperBound(0)
            For z = 0 To matEnteros.GetUpperBound(1)
                If matEnteros(y, z) > 0 Then
                    If matEnteros(y, z) = 1 Then
                        mat(y, z).BackgroundImage = My.Resources.patoA
                        mat(y, z).Text = 1
                    ElseIf matEnteros(y, z) = 2 Then
                        mat(y, z).BackgroundImage = My.Resources.patoR
                        mat(y, z).Text = 2
                    ElseIf matEnteros(y, z) = 3 Then
                        mat(y, z).BackgroundImage = My.Resources.patoV
                        mat(y, z).Text = 3
                    End If
                Else
                    mat(y, z).BackgroundImage = My.Resources.color_negro
                    mat(y, z).Text = 0
                End If
            Next
        Next
    End Sub

    'ordena la matriz de abajo para arriba
    Sub ordenar(mate(,) As Integer)
        Dim pivote As Integer
        Dim dos As Integer
        For i = mate.GetUpperBound(1) To 0 Step -1
            Dim cont As Integer = 0
            While cont <= mate.GetUpperBound(0)
                For k = mate.GetUpperBound(0) To 0 Step -1
                    pivote = mate(k, i)
                    If k <> 0 Then
                        dos = mate(k - 1, i)

                        If pivote = 0 Then
                            If pivote < dos Then
                                If pivote <> dos Then
                                    If k > 0 Then
                                        Dim tmp As Integer = mate(k - 1, i)
                                        mate(k - 1, i) = pivote
                                        mate(k, i) = tmp
                                    End If
                                End If
                            End If
                        End If
                        cont += 1
                    End If
                Next
            End While
        Next

    End Sub

    'ordena la matriz de izquierda a derecha 
    Sub ordenarB(mate(,) As Integer)
        Dim pivote As Integer
        Dim dos As Integer
        For i = 0 To mate.GetUpperBound(0)
            Dim cont As Integer = 0
            While cont <= mate.GetUpperBound(0)
                For k = 0 To mate.GetUpperBound(1)
                    pivote = mate(i, k)
                    If k <> mate.GetUpperBound(1) Then
                        dos = mate(i, k + 1)
                        If pivote = 0 Then
                            If pivote < dos Then
                                If pivote <> dos Then
                                    If k < mate.GetUpperBound(1) Then
                                        Dim tmp As Integer = mate(i, k + 1)
                                        mate(i, k + 1) = pivote
                                        mate(i, k) = tmp
                                    End If
                                End If
                            End If
                        End If
                        cont += 1
                    End If
                Next
            End While
        Next

    End Sub


    Sub enteros()
        Dim pruebas As String = ""
        For x = 0 To matEnteros.GetUpperBound(0)
            For z = 0 To matEnteros.GetUpperBound(1)
                pruebas += matEnteros(x, z) & " "
            Next
            pruebas += vbCrLf
        Next

        MessageBox.Show(pruebas)
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
        If fila < matEnteros.GetLength(0) - 1 Then
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
                    acumBolitas += 1
                End If
            End If
        End If
    End Sub


End Class
