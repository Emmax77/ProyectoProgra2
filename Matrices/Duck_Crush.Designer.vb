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
        Me.SuspendLayout()
        '
        'btNuevoJuego
        '
        Me.btNuevoJuego.Location = New System.Drawing.Point(852, 39)
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
        Me.btEnteros.Location = New System.Drawing.Point(869, 102)
        Me.btEnteros.Name = "btEnteros"
        Me.btEnteros.Size = New System.Drawing.Size(75, 23)
        Me.btEnteros.TabIndex = 2
        Me.btEnteros.Text = "Ver Enteros"
        Me.btEnteros.UseVisualStyleBackColor = True
        '
        'Duck_Crush
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 703)
        Me.Controls.Add(Me.btEnteros)
        Me.Controls.Add(Me.plMat)
        Me.Controls.Add(Me.btNuevoJuego)
        Me.Name = "Duck_Crush"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Duck Crush"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btNuevoJuego As Button
    Friend WithEvents plMat As Panel
    Friend WithEvents btEnteros As Button
End Class
