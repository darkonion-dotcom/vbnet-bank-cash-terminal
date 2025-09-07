Public Class frmDepositos

   
    Private totalDeposito As Decimal = 0 ' Variable para almacenar la suma total

    Private Sub btn50_Click(sender As Object, e As EventArgs) Handles btn50.Click
        totalDeposito += 50
        txtCantidad.Text = totalDeposito.ToString()
    End Sub

    Private Sub btn500_Click(sender As Object, e As EventArgs) Handles btn500.Click
        totalDeposito += 500
        txtCantidad.Text = totalDeposito.ToString()
    End Sub

    Private Sub btn20_Click(sender As Object, e As EventArgs) Handles btn20.Click
        totalDeposito += 20
        txtCantidad.Text = totalDeposito.ToString()
    End Sub

    Private Sub btn200_Click(sender As Object, e As EventArgs) Handles btn200.Click
        totalDeposito += 200
        txtCantidad.Text = totalDeposito.ToString()
    End Sub

    Private Sub btn1000_Click(sender As Object, e As EventArgs) Handles btn1000.Click
        totalDeposito += 1000
        txtCantidad.Text = totalDeposito.ToString()
    End Sub

    Private Sub btn100_Click(sender As Object, e As EventArgs) Handles btn100.Click
        totalDeposito += 100
        txtCantidad.Text = totalDeposito.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        totalDeposito = 0 ' Reiniciar la suma
        txtCantidad.Clear()
        MessageBox.Show("Ingrese la cantidad nuevamente")
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        FrmCajero.Show()
        Me.Close()
    End Sub

  
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtCantidad.Text = "" Then
            MessageBox.Show("Ingrese la cantidad.Porfavor.")
        Else
            MessageBox.Show("Retiro exitoso,retire su dinero de la maquina")
            txtCantidad.Clear()
        End If
    End Sub
End Class