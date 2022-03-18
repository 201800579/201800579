<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GBEmpleado = New System.Windows.Forms.GroupBox()
        Me.TBArticulos = New System.Windows.Forms.TextBox()
        Me.LBSalario = New System.Windows.Forms.Label()
        Me.TBSalario = New System.Windows.Forms.TextBox()
        Me.LBNomEmpleado = New System.Windows.Forms.Label()
        Me.TBNomEmpleado = New System.Windows.Forms.TextBox()
        Me.LBCantidad = New System.Windows.Forms.Label()
        Me.LISTEmpleado = New System.Windows.Forms.ListBox()
        Me.GBResultados = New System.Windows.Forms.GroupBox()
        Me.LBNombre = New System.Windows.Forms.Label()
        Me.LBRSueldoFinal = New System.Windows.Forms.Label()
        Me.LISTSalarioFinal = New System.Windows.Forms.ListBox()
        Me.LBComision = New System.Windows.Forms.Label()
        Me.LISTComision = New System.Windows.Forms.ListBox()
        Me.LBIncentivo = New System.Windows.Forms.Label()
        Me.LISTIncentivo = New System.Windows.Forms.ListBox()
        Me.LBRArticulo = New System.Windows.Forms.Label()
        Me.LISTArticulo = New System.Windows.Forms.ListBox()
        Me.LBRSalarioParcial = New System.Windows.Forms.Label()
        Me.LISTSalarioP = New System.Windows.Forms.ListBox()
        Me.BTAgregar = New System.Windows.Forms.Button()
        Me.BTLimpiar = New System.Windows.Forms.Button()
        Me.BTSalir = New System.Windows.Forms.Button()
        Me.GPArticulos = New System.Windows.Forms.GroupBox()
        Me.RBTele = New System.Windows.Forms.RadioButton()
        Me.RBCelular = New System.Windows.Forms.RadioButton()
        Me.RBDrone = New System.Windows.Forms.RadioButton()
        Me.RBTablet = New System.Windows.Forms.RadioButton()
        Me.LBRegistro = New System.Windows.Forms.Label()
        Me.LISTRegistro = New System.Windows.Forms.ListBox()
        Me.BTMostrar = New System.Windows.Forms.Button()
        Me.GBEmpleado.SuspendLayout()
        Me.GBResultados.SuspendLayout()
        Me.GPArticulos.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBEmpleado
        '
        Me.GBEmpleado.Controls.Add(Me.TBArticulos)
        Me.GBEmpleado.Controls.Add(Me.LBSalario)
        Me.GBEmpleado.Controls.Add(Me.TBSalario)
        Me.GBEmpleado.Controls.Add(Me.LBNomEmpleado)
        Me.GBEmpleado.Controls.Add(Me.TBNomEmpleado)
        Me.GBEmpleado.Controls.Add(Me.LBCantidad)
        Me.GBEmpleado.Location = New System.Drawing.Point(54, 33)
        Me.GBEmpleado.Name = "GBEmpleado"
        Me.GBEmpleado.Size = New System.Drawing.Size(418, 176)
        Me.GBEmpleado.TabIndex = 1
        Me.GBEmpleado.TabStop = False
        Me.GBEmpleado.Text = "Datos del Empleado"
        '
        'TBArticulos
        '
        Me.TBArticulos.Location = New System.Drawing.Point(182, 138)
        Me.TBArticulos.Name = "TBArticulos"
        Me.TBArticulos.Size = New System.Drawing.Size(225, 25)
        Me.TBArticulos.TabIndex = 4
        Me.TBArticulos.Text = "0"
        '
        'LBSalario
        '
        Me.LBSalario.AutoSize = True
        Me.LBSalario.Location = New System.Drawing.Point(6, 103)
        Me.LBSalario.Name = "LBSalario"
        Me.LBSalario.Size = New System.Drawing.Size(164, 17)
        Me.LBSalario.TabIndex = 3
        Me.LBSalario.Text = "Salario del Empleado"
        '
        'TBSalario
        '
        Me.TBSalario.Location = New System.Drawing.Point(182, 100)
        Me.TBSalario.Name = "TBSalario"
        Me.TBSalario.Size = New System.Drawing.Size(225, 25)
        Me.TBSalario.TabIndex = 2
        Me.TBSalario.Text = "0"
        '
        'LBNomEmpleado
        '
        Me.LBNomEmpleado.AutoSize = True
        Me.LBNomEmpleado.Location = New System.Drawing.Point(6, 54)
        Me.LBNomEmpleado.Name = "LBNomEmpleado"
        Me.LBNomEmpleado.Size = New System.Drawing.Size(170, 17)
        Me.LBNomEmpleado.TabIndex = 1
        Me.LBNomEmpleado.Text = "Nombre del Empleado"
        '
        'TBNomEmpleado
        '
        Me.TBNomEmpleado.Location = New System.Drawing.Point(182, 51)
        Me.TBNomEmpleado.Name = "TBNomEmpleado"
        Me.TBNomEmpleado.Size = New System.Drawing.Size(225, 25)
        Me.TBNomEmpleado.TabIndex = 0
        '
        'LBCantidad
        '
        Me.LBCantidad.AutoSize = True
        Me.LBCantidad.Location = New System.Drawing.Point(5, 141)
        Me.LBCantidad.Name = "LBCantidad"
        Me.LBCantidad.Size = New System.Drawing.Size(165, 17)
        Me.LBCantidad.TabIndex = 5
        Me.LBCantidad.Text = "Cantidad de Articulos"
        '
        'LISTEmpleado
        '
        Me.LISTEmpleado.Enabled = False
        Me.LISTEmpleado.FormattingEnabled = True
        Me.LISTEmpleado.ItemHeight = 17
        Me.LISTEmpleado.Location = New System.Drawing.Point(109, 64)
        Me.LISTEmpleado.Name = "LISTEmpleado"
        Me.LISTEmpleado.Size = New System.Drawing.Size(165, 157)
        Me.LISTEmpleado.TabIndex = 2
        '
        'GBResultados
        '
        Me.GBResultados.Controls.Add(Me.LBRegistro)
        Me.GBResultados.Controls.Add(Me.LBNombre)
        Me.GBResultados.Controls.Add(Me.LBRSueldoFinal)
        Me.GBResultados.Controls.Add(Me.LISTRegistro)
        Me.GBResultados.Controls.Add(Me.LISTSalarioFinal)
        Me.GBResultados.Controls.Add(Me.LBComision)
        Me.GBResultados.Controls.Add(Me.LISTComision)
        Me.GBResultados.Controls.Add(Me.LBIncentivo)
        Me.GBResultados.Controls.Add(Me.LISTIncentivo)
        Me.GBResultados.Controls.Add(Me.LBRArticulo)
        Me.GBResultados.Controls.Add(Me.LISTArticulo)
        Me.GBResultados.Controls.Add(Me.LBRSalarioParcial)
        Me.GBResultados.Controls.Add(Me.LISTSalarioP)
        Me.GBResultados.Controls.Add(Me.LISTEmpleado)
        Me.GBResultados.Location = New System.Drawing.Point(3, 264)
        Me.GBResultados.Name = "GBResultados"
        Me.GBResultados.Size = New System.Drawing.Size(1192, 245)
        Me.GBResultados.TabIndex = 3
        Me.GBResultados.TabStop = False
        Me.GBResultados.Text = "Registros"
        '
        'LBNombre
        '
        Me.LBNombre.AutoSize = True
        Me.LBNombre.Location = New System.Drawing.Point(109, 30)
        Me.LBNombre.Name = "LBNombre"
        Me.LBNombre.Size = New System.Drawing.Size(81, 17)
        Me.LBNombre.TabIndex = 16
        Me.LBNombre.Text = "Empleado"
        '
        'LBRSueldoFinal
        '
        Me.LBRSueldoFinal.AutoSize = True
        Me.LBRSueldoFinal.Location = New System.Drawing.Point(1018, 30)
        Me.LBRSueldoFinal.Name = "LBRSueldoFinal"
        Me.LBRSueldoFinal.Size = New System.Drawing.Size(101, 17)
        Me.LBRSueldoFinal.TabIndex = 15
        Me.LBRSueldoFinal.Text = "Salario Final"
        '
        'LISTSalarioFinal
        '
        Me.LISTSalarioFinal.Enabled = False
        Me.LISTSalarioFinal.FormattingEnabled = True
        Me.LISTSalarioFinal.ItemHeight = 17
        Me.LISTSalarioFinal.Location = New System.Drawing.Point(1018, 64)
        Me.LISTSalarioFinal.Name = "LISTSalarioFinal"
        Me.LISTSalarioFinal.Size = New System.Drawing.Size(165, 157)
        Me.LISTSalarioFinal.TabIndex = 14
        '
        'LBComision
        '
        Me.LBComision.AutoSize = True
        Me.LBComision.Location = New System.Drawing.Point(836, 30)
        Me.LBComision.Name = "LBComision"
        Me.LBComision.Size = New System.Drawing.Size(76, 17)
        Me.LBComision.TabIndex = 13
        Me.LBComision.Text = "Comision"
        '
        'LISTComision
        '
        Me.LISTComision.Enabled = False
        Me.LISTComision.FormattingEnabled = True
        Me.LISTComision.ItemHeight = 17
        Me.LISTComision.Location = New System.Drawing.Point(836, 64)
        Me.LISTComision.Name = "LISTComision"
        Me.LISTComision.Size = New System.Drawing.Size(165, 157)
        Me.LISTComision.TabIndex = 12
        '
        'LBIncentivo
        '
        Me.LBIncentivo.AutoSize = True
        Me.LBIncentivo.Location = New System.Drawing.Point(654, 30)
        Me.LBIncentivo.Name = "LBIncentivo"
        Me.LBIncentivo.Size = New System.Drawing.Size(76, 17)
        Me.LBIncentivo.TabIndex = 11
        Me.LBIncentivo.Text = "Incentivo"
        '
        'LISTIncentivo
        '
        Me.LISTIncentivo.Enabled = False
        Me.LISTIncentivo.FormattingEnabled = True
        Me.LISTIncentivo.ItemHeight = 17
        Me.LISTIncentivo.Location = New System.Drawing.Point(654, 64)
        Me.LISTIncentivo.Name = "LISTIncentivo"
        Me.LISTIncentivo.Size = New System.Drawing.Size(165, 157)
        Me.LISTIncentivo.TabIndex = 10
        '
        'LBRArticulo
        '
        Me.LBRArticulo.AutoSize = True
        Me.LBRArticulo.Location = New System.Drawing.Point(472, 30)
        Me.LBRArticulo.Name = "LBRArticulo"
        Me.LBRArticulo.Size = New System.Drawing.Size(130, 17)
        Me.LBRArticulo.TabIndex = 9
        Me.LBRArticulo.Text = "Articulo Vendido"
        '
        'LISTArticulo
        '
        Me.LISTArticulo.Enabled = False
        Me.LISTArticulo.FormattingEnabled = True
        Me.LISTArticulo.ItemHeight = 17
        Me.LISTArticulo.Location = New System.Drawing.Point(472, 64)
        Me.LISTArticulo.Name = "LISTArticulo"
        Me.LISTArticulo.Size = New System.Drawing.Size(165, 157)
        Me.LISTArticulo.TabIndex = 8
        '
        'LBRSalarioParcial
        '
        Me.LBRSalarioParcial.AutoSize = True
        Me.LBRSalarioParcial.Location = New System.Drawing.Point(292, 30)
        Me.LBRSalarioParcial.Name = "LBRSalarioParcial"
        Me.LBRSalarioParcial.Size = New System.Drawing.Size(116, 17)
        Me.LBRSalarioParcial.TabIndex = 7
        Me.LBRSalarioParcial.Text = "Salario Parcial"
        '
        'LISTSalarioP
        '
        Me.LISTSalarioP.Enabled = False
        Me.LISTSalarioP.FormattingEnabled = True
        Me.LISTSalarioP.ItemHeight = 17
        Me.LISTSalarioP.Location = New System.Drawing.Point(292, 64)
        Me.LISTSalarioP.Name = "LISTSalarioP"
        Me.LISTSalarioP.Size = New System.Drawing.Size(165, 157)
        Me.LISTSalarioP.TabIndex = 6
        '
        'BTAgregar
        '
        Me.BTAgregar.Location = New System.Drawing.Point(820, 33)
        Me.BTAgregar.Name = "BTAgregar"
        Me.BTAgregar.Size = New System.Drawing.Size(230, 46)
        Me.BTAgregar.TabIndex = 4
        Me.BTAgregar.Text = "Agregar"
        Me.BTAgregar.UseVisualStyleBackColor = True
        '
        'BTLimpiar
        '
        Me.BTLimpiar.Location = New System.Drawing.Point(820, 149)
        Me.BTLimpiar.Name = "BTLimpiar"
        Me.BTLimpiar.Size = New System.Drawing.Size(230, 46)
        Me.BTLimpiar.TabIndex = 5
        Me.BTLimpiar.Text = "Limpiar Registros"
        Me.BTLimpiar.UseVisualStyleBackColor = True
        '
        'BTSalir
        '
        Me.BTSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTSalir.Location = New System.Drawing.Point(820, 201)
        Me.BTSalir.Name = "BTSalir"
        Me.BTSalir.Size = New System.Drawing.Size(230, 46)
        Me.BTSalir.TabIndex = 6
        Me.BTSalir.Text = "Salir"
        Me.BTSalir.UseVisualStyleBackColor = False
        '
        'GPArticulos
        '
        Me.GPArticulos.Controls.Add(Me.RBTele)
        Me.GPArticulos.Controls.Add(Me.RBCelular)
        Me.GPArticulos.Controls.Add(Me.RBDrone)
        Me.GPArticulos.Controls.Add(Me.RBTablet)
        Me.GPArticulos.Location = New System.Drawing.Point(518, 33)
        Me.GPArticulos.Name = "GPArticulos"
        Me.GPArticulos.Size = New System.Drawing.Size(203, 176)
        Me.GPArticulos.TabIndex = 4
        Me.GPArticulos.TabStop = False
        Me.GPArticulos.Text = "Articulos"
        '
        'RBTele
        '
        Me.RBTele.AutoSize = True
        Me.RBTele.Location = New System.Drawing.Point(36, 124)
        Me.RBTele.Name = "RBTele"
        Me.RBTele.Size = New System.Drawing.Size(94, 21)
        Me.RBTele.TabIndex = 3
        Me.RBTele.TabStop = True
        Me.RBTele.Text = "Televisor"
        Me.RBTele.UseVisualStyleBackColor = True
        '
        'RBCelular
        '
        Me.RBCelular.AutoSize = True
        Me.RBCelular.Location = New System.Drawing.Point(36, 97)
        Me.RBCelular.Name = "RBCelular"
        Me.RBCelular.Size = New System.Drawing.Size(78, 21)
        Me.RBCelular.TabIndex = 2
        Me.RBCelular.TabStop = True
        Me.RBCelular.Text = "Celular"
        Me.RBCelular.UseVisualStyleBackColor = True
        '
        'RBDrone
        '
        Me.RBDrone.AutoSize = True
        Me.RBDrone.Location = New System.Drawing.Point(36, 70)
        Me.RBDrone.Name = "RBDrone"
        Me.RBDrone.Size = New System.Drawing.Size(69, 21)
        Me.RBDrone.TabIndex = 1
        Me.RBDrone.TabStop = True
        Me.RBDrone.Text = "Drone"
        Me.RBDrone.UseVisualStyleBackColor = True
        '
        'RBTablet
        '
        Me.RBTablet.AutoSize = True
        Me.RBTablet.Location = New System.Drawing.Point(36, 43)
        Me.RBTablet.Name = "RBTablet"
        Me.RBTablet.Size = New System.Drawing.Size(73, 21)
        Me.RBTablet.TabIndex = 0
        Me.RBTablet.TabStop = True
        Me.RBTablet.Text = "Tablet"
        Me.RBTablet.UseVisualStyleBackColor = True
        '
        'LBRegistro
        '
        Me.LBRegistro.AutoSize = True
        Me.LBRegistro.Location = New System.Drawing.Point(9, 30)
        Me.LBRegistro.Name = "LBRegistro"
        Me.LBRegistro.Size = New System.Drawing.Size(70, 17)
        Me.LBRegistro.TabIndex = 18
        Me.LBRegistro.Text = "Registro"
        '
        'LISTRegistro
        '
        Me.LISTRegistro.Enabled = False
        Me.LISTRegistro.FormattingEnabled = True
        Me.LISTRegistro.ItemHeight = 17
        Me.LISTRegistro.Location = New System.Drawing.Point(6, 64)
        Me.LISTRegistro.Name = "LISTRegistro"
        Me.LISTRegistro.Size = New System.Drawing.Size(81, 157)
        Me.LISTRegistro.TabIndex = 17
        '
        'BTMostrar
        '
        Me.BTMostrar.Location = New System.Drawing.Point(820, 90)
        Me.BTMostrar.Name = "BTMostrar"
        Me.BTMostrar.Size = New System.Drawing.Size(230, 46)
        Me.BTMostrar.TabIndex = 7
        Me.BTMostrar.Text = "Mostrar"
        Me.BTMostrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientSize = New System.Drawing.Size(1200, 588)
        Me.Controls.Add(Me.BTMostrar)
        Me.Controls.Add(Me.GPArticulos)
        Me.Controls.Add(Me.BTSalir)
        Me.Controls.Add(Me.BTLimpiar)
        Me.Controls.Add(Me.BTAgregar)
        Me.Controls.Add(Me.GBResultados)
        Me.Controls.Add(Me.GBEmpleado)
        Me.Font = New System.Drawing.Font("HP Simplified Hans", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GBEmpleado.ResumeLayout(False)
        Me.GBEmpleado.PerformLayout()
        Me.GBResultados.ResumeLayout(False)
        Me.GBResultados.PerformLayout()
        Me.GPArticulos.ResumeLayout(False)
        Me.GPArticulos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GBEmpleado As GroupBox
    Friend WithEvents TBArticulos As TextBox
    Friend WithEvents LBSalario As Label
    Friend WithEvents TBSalario As TextBox
    Friend WithEvents LBNomEmpleado As Label
    Friend WithEvents TBNomEmpleado As TextBox
    Friend WithEvents LBCantidad As Label
    Friend WithEvents LISTEmpleado As ListBox
    Friend WithEvents GBResultados As GroupBox
    Friend WithEvents LBNombre As Label
    Friend WithEvents LBRSueldoFinal As Label
    Friend WithEvents LISTSalarioFinal As ListBox
    Friend WithEvents LBComision As Label
    Friend WithEvents LISTComision As ListBox
    Friend WithEvents LBIncentivo As Label
    Friend WithEvents LISTIncentivo As ListBox
    Friend WithEvents LBRArticulo As Label
    Friend WithEvents LISTArticulo As ListBox
    Friend WithEvents LBRSalarioParcial As Label
    Friend WithEvents LISTSalarioP As ListBox
    Friend WithEvents BTAgregar As Button
    Friend WithEvents BTLimpiar As Button
    Friend WithEvents BTSalir As Button
    Friend WithEvents GPArticulos As GroupBox
    Friend WithEvents RBTele As RadioButton
    Friend WithEvents RBCelular As RadioButton
    Friend WithEvents RBDrone As RadioButton
    Friend WithEvents RBTablet As RadioButton
    Friend WithEvents LBRegistro As Label
    Friend WithEvents LISTRegistro As ListBox
    Friend WithEvents BTMostrar As Button
End Class
