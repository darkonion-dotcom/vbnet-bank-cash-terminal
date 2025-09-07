Public Class frmTarjetaIngreso

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtNIP.Text &= "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtNIP.Text &= "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtNIP.Text &= "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtNIP.Text &= "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtNIP.Text &= "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtNIP.Text &= "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtNIP.Text &= "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtNIP.Text &= "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtNIP.Text &= "9"
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        MessageBox.Show("Operacion Cancelada")
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNIP.Clear()
        MessageBox.Show("Ingrese el Numero de Tarjeta de nuevo")
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        MessageBox.Show("Numero de tarjeta VERIFICADO")
        FrmNIP.Show()
        Me.Close()
    End Sub

    Private Sub frmTarjetaIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
