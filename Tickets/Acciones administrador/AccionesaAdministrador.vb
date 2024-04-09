Public Class frmAccionesAdministrador
    Private Sub frmAcciones_administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Me.Close()
        frmCrearUsuario.Show()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Me.Close()
        frmBorrarUsuario.Show()

    End Sub

    Private Sub btnVerListado_Click(sender As Object, e As EventArgs) Handles btnVerListado.Click
        Me.Close()
        frmListaTickets.Show()

    End Sub

    Private Sub btnOtrosTickets_Click(sender As Object, e As EventArgs) Handles btnOtrosTickets.Click
        Me.Close()
        frmOtrosTicketsAdmin.Show()

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        If MsgBox("¿Esta seguro de que desea volver al menu principal?", MsgBoxStyle.YesNo, "Volver al menu principal") = MsgBoxResult.Yes Then
            Me.Close()
            frmMenu.Show()

        End If
    End Sub
End Class