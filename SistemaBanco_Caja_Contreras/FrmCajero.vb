Public Class FrmCajero

    Private Sub FrmCajero_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmDepositos.Show()
        Me.Close()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Dim usuario As String = " Isaac Navarro"
        MessageBox.Show("Adios Isaac Navarro.Gracias por preferirnos")
        Me.Close()
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        FrmRetiro.Show()
        Me.Close()
    End Sub
End Class