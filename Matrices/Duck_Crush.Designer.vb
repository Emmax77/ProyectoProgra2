<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Duck_Crush
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btNuevoJuego = New System.Windows.Forms.Button()
        Me.plMat = New System.Windows.Forms.Panel()
        Me.btEnteros = New System.Windows.Forms.Button()
        Me.lbPuntaje = New System.Windows.Forms.Label()
        Me.lbPuntos = New System.Windows.Forms.Label()
        Me.lbPatitos = New System.Windows.Forms.Label()
        Me.lbPatitosComidos = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btNuevoJuego
        '
        Me.btNuevoJuego.Location = New System.Drawing.Point(854, 183)
        Me.btNuevoJuego.Name = "btNuevoJuego"
        Me.btNuevoJuego.Size = New System.Drawing.Size(102, 23)
        Me.btNuevoJuego.TabIndex = 0
        Me.btNuevoJuego.Text = "Nuevo Juego"
        Me.btNuevoJuego.UseVisualStyleBackColor = True
        '
        'plMat
        '
        Me.plMat.Location = New System.Drawing.Point(12, 12)
        Me.plMat.Name = "plMat"
        Me.plMat.Size = New System.Drawing.Size(810, 679)
        Me.plMat.TabIndex = 1
        '
        'btEnteros
        '
        Me.btEnteros.Location = New System.Drawing.Point(870, 230)
        Me.btEnteros.Name = "btEnteros"
        Me.btEnteros.Size = New System.Drawing.Size(75, 23)
        Me.btEnteros.TabIndex = 2
        Me.btEnteros.Text = "Ver Enteros"
        Me.btEnteros.UseVisualStyleBackColor = True
        '
        'lbPuntaje
        '
        Me.lbPuntaje.AutoSize = True
        Me.lbPuntaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPuntaje.Location = New System.Drawing.Point(841, 27)
        Me.lbPuntaje.Name = "lbPuntaje"
        Me.lbPuntaje.Size = New System.Drawing.Size(115, 25)
        Me.lbPuntaje.TabIndex = 3
        Me.lbPuntaje.Text = "PUNTAJE"
        Me.lbPuntaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbPuntos
        '
        Me.lbPuntos.AutoSize = True
        Me.lbPuntos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPuntos.Location = New System.Drawing.Point(849, 76)
        Me.lbPuntos.Name = "lbPuntos"
        Me.lbPuntos.Size = New System.Drawing.Size(25, 25)
        Me.lbPuntos.TabIndex = 4
        Me.lbPuntos.Text = "0"
        Me.lbPuntos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbPatitos
        '
        Me.lbPatitos.AutoSize = True
        Me.lbPatitos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPatitos.Location = New System.Drawing.Point(986, 27)
        Me.lbPatitos.Name = "lbPatitos"
        Me.lbPatitos.Size = New System.Drawing.Size(221, 25)
        Me.lbPatitos.TabIndex = 5
        Me.lbPatitos.Text = "PATITOS COMIDOS"
        Me.lbPatitos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbPatitosComidos
        '
        Me.lbPatitosComidos.AutoSize = True
        Me.lbPatitosComidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPatitosComidos.Location = New System.Drawing.Point(1079, 76)
        Me.lbPatitosComidos.Name = "lbPatitosComidos"
        Me.lbPatitosComidos.Size = New System.Drawing.Size(25, 25)
        Me.lbPatitosComidos.TabIndex = 6
        Me.lbPatitosComidos.Text = "0"
        '
        'Duck_Crush
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1231, 703)
        Me.Controls.Add(Me.lbPatitosComidos)
        Me.Controls.Add(Me.lbPatitos)
        Me.Controls.Add(Me.lbPuntos)
        Me.Controls.Add(Me.lbPuntaje)
        Me.Controls.Add(Me.btEnteros)
        Me.Controls.Add(Me.plMat)
        Me.Controls.Add(Me.btNuevoJuego)
        Me.Name = "Duck_Crush"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Duck Crush"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btNuevoJuego As Button
    Friend WithEvents plMat As Panel
    Friend WithEvents btEnteros As Button
    Friend WithEvents lbPuntaje As Label
    Friend WithEvents lbPuntos As Label
    Friend WithEvents lbPatitos As Label
    Friend WithEvents lbPatitosComidos As Label
End Class
