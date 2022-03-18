Public Class Form1

    'se hacen algunas validaciones para luego ir al proceso de agregar
    Private Sub BTAgregar_Click(sender As Object, e As EventArgs) Handles BTAgregar.Click
        'validamos primero que se ingrese un nombre
        If TBNomEmpleado.Text = "" Then
            MsgBox("Usted no a Ingresado el Nombre del Empleado", MsgBoxStyle.Information, "Advertencia")
            TBNomEmpleado.Focus()

        Else
            'verificamos que se ingrese un salario mayor a 0
            If TBSalario.Text = 0 Then
                MsgBox("Usted no a Ingresado el Salario", MsgBoxStyle.Information, "Advertencia")
                TBSalario.Focus()
                'verificamos que se ingrese la cantidad de articulos vendidos 
            Else
                If TBArticulos.Text = 0 Then
                    MsgBox("Usted no a Ingresado la Cantidad de Articulos", MsgBoxStyle.Information, "Advertencia")
                    TBArticulos.Focus()
                Else
                    'validamos que seleccione algun articulo
                    If ((RBCelular.Checked = True) Or (RBDrone.Checked = True) Or (RBTablet.Checked = True) Or (RBTele.Checked = True)) Then
                        Agregar()

                    Else
                        MsgBox("Usted no a seleccionado un Articulo", MsgBoxStyle.Information, "Advertencia")
                    End If
                End If

            End If
        End If


    End Sub

    'se llama el metodo para limpiar vectores
    Private Sub BTLimpiar_Click(sender As Object, e As EventArgs) Handles BTLimpiar.Click

    End Sub
    'boton salida
    Private Sub BTSalir_Click(sender As Object, e As EventArgs) Handles BTSalir.Click
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Close()
        Else

        End If

    End Sub

    'validamos que se ingresen solo numeros en el textbx de salario
    Private Sub TBSalario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBSalario.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    'validamos que solo se ingresen numeros en el textbox de Articulos
    Private Sub TBArticulos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBArticulos.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BTMostrar_Click(sender As Object, e As EventArgs) Handles BTMostrar.Click
        Mostrar()
    End Sub
End Class
