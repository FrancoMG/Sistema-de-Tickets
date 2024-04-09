Public Class frmEliminarTickets

    Dim personat As String

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtTicket.Text = "" Then
            MsgBox("Complete los campos vacios para poder continuar", MsgBoxStyle.Exclamation, "Campos vacios")

        Else
            sql = "select count(*) from ticket where codticket = " & txtTicket.Text & ""
            Call ejecutar(sql)
            rs.Read()

            If rs(0) = 0 Then
                MsgBox("El Codigo de Ticket ingresado no existe", MsgBoxStyle.Critical, "Ticket inexistente")

            Else
                sql = "select corregido from ticket where codticket = " & txtTicket.Text & ""
                Call ejecutar(sql)
                rs.Read()

                If rs(0) = 1 Then
                    MsgBox("Este Ticket ya fue corregido anteriormente", MsgBoxStyle.Exclamation, "Ticket ya corregido")

                Else
                    sql = "select concat(nombre, ' ', apellido) from persona p, usuario u, ticket t where p.codpersona = u.codpersona and u.codusuario = t.codusuario and t.codticket = " & txtTicket.Text & ""
                    Call ejecutar(sql)
                    rs.Read()
                    personat = rs(0)

                    If MsgBox("Este Codigo de Ticket corresponde a " & personat & ". ¿Esta seguro de que desea eliminar este Ticket de la lista?", MsgBoxStyle.YesNo, "Eliminar Ticket") = MsgBoxResult.Yes Then
                        sql = "update ticket set corregido = 1 where codticket = " & txtTicket.Text & ""
                        Call ejecutar(sql)
                        MsgBox("Se ha eliminado el Ticket de " & personat & " correctamente", MsgBoxStyle.Information, "Ticket eliminado de la lista correctamente")
                        txtTicket.Text = ""

                    End If
                End If
            End If
        End If

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        frmListaTickets.Show()

    End Sub

    Private Sub txtContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtTicket.KeyPress
        onlynum(e)

    End Sub
End Class