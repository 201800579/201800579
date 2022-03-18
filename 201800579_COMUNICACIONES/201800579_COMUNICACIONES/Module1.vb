
Imports System.Math

Module Module1

    'constantes
    Dim PRTablet = 375
    Dim PRDrone = 560
    Dim PRCelular = 1450
    Dim PRTele = 3250
    Dim Comision = 0.055

    'variables
    Dim Incentivo As Double
    Dim SueldoFInall As Double
    Dim ComicionVenta As Double
    'vectores
    Dim Contador = 0
    Dim VNombreEmpleado(7) As String
    Dim VRegistro(7) As String
    Dim VSP(7) As String
    Dim VArticulo(7) As String
    Dim VIncentivo(7) As String
    Dim VComision(7) As String
    Dim VSF(7) As String

    Public Sub Agregar()
        VRegistro(Contador) = Contador
        VNombreEmpleado(Contador) = Form1.TBNomEmpleado.Text
        VSP(Contador) = Form1.TBSalario.Text

        'celular
        If Form1.RBCelular.Checked = True Then
            VArticulo(Contador) = Form1.RBCelular.Text

            If Form1.TBSalario.Text > 0 And Form1.TBSalario.Text < 2000 Then
                Incentivo = Form1.TBSalario.Text * 0.03
                VIncentivo(Contador) = Round(Incentivo, 2)
                ComicionVenta = Form1.TBArticulos.Text * PRCelular * Comision
                VComision(Contador) = Round(ComicionVenta, 2)
                SueldoFInall = Form1.TBSalario.Text + Incentivo + ComicionVenta
                VSF(Contador) = Round(SueldoFInall, 2)
            End If

            If Form1.TBSalario.Text > 2001 And Form1.TBSalario.Text < 5000 Then
                Incentivo = Form1.TBSalario.Text * 0.04
                VIncentivo(Contador) = Round(Incentivo, 2)
                ComicionVenta = Form1.TBArticulos.Text * PRCelular * Comision
                VComision(Contador) = Round(ComicionVenta, 2)
                SueldoFInall = Form1.TBSalario.Text + Incentivo + ComicionVenta
                VSF(Contador) = Round(SueldoFInall, 2)
            End If

            If Form1.TBSalario.Text > 5001 Then
                Incentivo = Form1.TBSalario.Text * 0.05
                VIncentivo(Contador) = Round(Incentivo, 2)
                ComicionVenta = Form1.TBArticulos.Text * PRCelular * Comision
                VComision(Contador) = Round(ComicionVenta, 2)
                SueldoFInall = Form1.TBSalario.Text + Incentivo + ComicionVenta
                VSF(Contador) = Round(SueldoFInall, 2)
            End If

        End If

        If Form1.RBDrone.Checked = True Then
            VArticulo(Contador) = Form1.RBDrone.Text
            If Form1.TBSalario.Text > 0 And Form1.TBSalario.Text < 2000 Then
                Incentivo = Form1.TBSalario.Text * 0.03
                VIncentivo(Contador) = Round(Incentivo, 2)
                ComicionVenta = Form1.TBArticulos.Text * PRDrone * Comision
                VComision(Contador) = Round(ComicionVenta, 2)
                SueldoFInall = Form1.TBSalario.Text + Incentivo + ComicionVenta
                VSF(Contador) = Round(SueldoFInall, 2)
            End If

            If Form1.TBSalario.Text > 2001 And Form1.TBSalario.Text < 5000 Then
                Incentivo = Form1.TBSalario.Text * 0.04
                VIncentivo(Contador) = Round(Incentivo, 2)
                ComicionVenta = Form1.TBArticulos.Text * PRDrone * Comision
                VComision(Contador) = Round(ComicionVenta, 2)
                SueldoFInall = Form1.TBSalario.Text + Incentivo + ComicionVenta
                VSF(Contador) = Round(SueldoFInall, 2)
            End If

            If Form1.TBSalario.Text > 5001 Then
                Incentivo = Form1.TBSalario.Text * 0.05
                VIncentivo(Contador) = Round(Incentivo, 2)
                ComicionVenta = Form1.TBArticulos.Text * PRDrone * Comision
                VComision(Contador) = Round(ComicionVenta, 2)
                SueldoFInall = Form1.TBSalario.Text + Incentivo + ComicionVenta
                VSF(Contador) = Round(SueldoFInall, 2)
            End If

        End If

        If Form1.RBTablet.Checked = True Then
            VArticulo(Contador) = Form1.RBTablet.Text
            If Form1.TBSalario.Text > 0 And Form1.TBSalario.Text < 2000 Then
                Incentivo = Form1.TBSalario.Text * 0.03
                VIncentivo(Contador) = Round(Incentivo, 2)
                ComicionVenta = Form1.TBArticulos.Text * PRTablet * Comision
                VComision(Contador) = Round(ComicionVenta, 2)
                SueldoFInall = Form1.TBSalario.Text + Incentivo + ComicionVenta
                VSF(Contador) = Round(SueldoFInall, 2)
            End If

            If Form1.TBSalario.Text > 2001 And Form1.TBSalario.Text < 5000 Then
                Incentivo = Form1.TBSalario.Text * 0.04
                VIncentivo(Contador) = Round(Incentivo, 2)
                ComicionVenta = Form1.TBArticulos.Text * PRTablet * Comision
                VComision(Contador) = Round(ComicionVenta, 2)
                SueldoFInall = Form1.TBSalario.Text + Incentivo + ComicionVenta
                VSF(Contador) = Round(SueldoFInall, 2)
            End If

            If Form1.TBSalario.Text > 5001 Then
                Incentivo = Form1.TBSalario.Text * 0.05
                VIncentivo(Contador) = Round(Incentivo, 2)
                ComicionVenta = Form1.TBArticulos.Text * PRTablet * Comision
                VComision(Contador) = Round(ComicionVenta, 2)
                SueldoFInall = Form1.TBSalario.Text + Incentivo + ComicionVenta
                VSF(Contador) = Round(SueldoFInall, 2)
            End If

        End If

        If Form1.RBTele.Checked = True Then
            VArticulo(Contador) = Form1.RBTele.Text
            If Form1.TBSalario.Text > 0 And Form1.TBSalario.Text < 2000 Then
                Incentivo = Form1.TBSalario.Text * 0.03
                VIncentivo(Contador) = Round(Incentivo, 2)
                ComicionVenta = Form1.TBArticulos.Text * PRTele * Comision
                VComision(Contador) = Round(ComicionVenta, 2)
                SueldoFInall = Form1.TBSalario.Text + Incentivo + ComicionVenta
                VSF(Contador) = Round(SueldoFInall, 2)
            End If

            If Form1.TBSalario.Text > 2001 And Form1.TBSalario.Text < 5000 Then
                Incentivo = Form1.TBSalario.Text * 0.04
                VIncentivo(Contador) = Round(Incentivo, 2)
                ComicionVenta = Form1.TBArticulos.Text * PRTele * Comision
                VComision(Contador) = Round(ComicionVenta, 2)
                SueldoFInall = Form1.TBSalario.Text + Incentivo + ComicionVenta
                VSF(Contador) = Round(SueldoFInall, 2)
            End If

            If Form1.TBSalario.Text > 5001 Then
                Incentivo = Form1.TBSalario.Text * 0.05
                VIncentivo(Contador) = Round(Incentivo, 2)
                ComicionVenta = Form1.TBArticulos.Text * PRTele * Comision
                VComision(Contador) = Round(ComicionVenta, 2)
                SueldoFInall = Form1.TBSalario.Text + Incentivo + ComicionVenta
                VSF(Contador) = Round(SueldoFInall, 2)
            End If
        End If

        If Contador = 6 Then
            MsgBox("Llego al limite de usuarios registrados  ", MsgBoxStyle.Information, "ADVERTENCIA")

        Else
            Contador = Contador + 1

        End If


    End Sub
    Public Sub Mostrar()
        Dim i = 0
        'con la ayuda de un ciclo while procederemos a mostras los datos del paciente, subtota, descuento, total
        While ((i <= (Contador - 1)))
            Form1.LISTEmpleado.Items.Add(VNombreEmpleado(i))
            Form1.LISTArticulo.Items.Add(VArticulo(i))
            Form1.LISTComision.Items.Add(VComision(i))
            Form1.LISTIncentivo.Items.Add(VIncentivo(i))
            Form1.LISTRegistro.Items.Add(VRegistro(i))
            Form1.LISTSalarioP.Items.Add(VSP(i))
            Form1.LISTSalarioFinal.Items.Add(VSF(i))
            i += 1
        End While
    End Sub

End Module
