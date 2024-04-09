Public Class frmConsultaTicketOtrosUsuarios

    Dim codt As Integer
    Dim asunto As String
    Dim consulta As String

    Private Sub frmConsultaTicketOtrosUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "select codticket from ticket where asunto = '" & txtAsunto.Text & "' and consulta = '" & txtConsulta.Text & "' and codusuarioenviado = " & codu & ""
        Call ejecutar(sql)
        rs.Read()
        codt = rs(0)

        sql = "select asunto, consulta from ticket where codticket = " & codt & ""
        Call ejecutar(sql)
        rs.Read()
        asunto = rs(0)
        consulta = rs(1)

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtAsunto.Text = "" Or txtConsulta.Text = "" Then
            MsgBox("Complete los campos vacios para poder continuar", MsgBoxStyle.Exclamation, "Campos vacios")

        Else
            If txtAsunto.Text = asunto And txtConsulta.Text = consulta Then
                MsgBox("Debe hacer cambios en el ticket para poder guardar la nueva configuracion", MsgBoxStyle.Exclamation, "No se detectaron cambios nuevos")

            Else
                sql = "update ticket set asunto = '" & txtAsunto.Text & "' where codticket = " & codt & ""
                Call ejecutar(sql)

                sql = "update ticket set consulta = '" & txtConsulta.Text & "' where codticket = " & codt & ""
                Call ejecutar(sql)

                MsgBox("Se ha guardado los nuevos datos del Ticket correctamente", MsgBoxStyle.Information, "Ticket cambiado correctamente")

            End If
        End If

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        If claseusuario = "Usuario" Then
            Me.Close()
            frmAccionesUsuario.Show()

        ElseIf claseusuario = "Administrador" Then
            Me.Close()
            frmAccionesAdministrador.Show()

        End If

    End Sub
End Class