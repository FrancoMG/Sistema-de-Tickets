Public Class frmAccionesUsuario
    Private Sub btnCrearTicket_Click(sender As Object, e As EventArgs) Handles btnCrearTicket.Click
        Me.Hide()
        frmTicketsUsuario.Show()

    End Sub

    Private Sub btnVerTickets_Click(sender As Object, e As EventArgs) Handles btnVerTickets.Click
        Me.Hide()
        frmTicket.Show()

    End Sub

    Private Sub btnOtrosTickets_Click(sender As Object, e As EventArgs) Handles btnOtrosTickets.Click
        frmOtrosTicketsUsuario.Show()
        Me.Close()

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        If MsgBox("¿Esta seguro de que desea volver al menu principal?", MsgBoxStyle.YesNo, "Volver al menu principal") = MsgBoxResult.Yes Then
            frmMenu.Show()
            Me.Close()

        End If

    End Sub
End Class