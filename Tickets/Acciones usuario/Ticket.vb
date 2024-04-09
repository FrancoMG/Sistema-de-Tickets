Public Class frmTicket

    Private Sub frmTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "select nombreusuario from usuario where Habilitado = 1"
        Call ejecutar(sql)

        While rs.Read
            cmbUsuarios.Items.Add(rs(0))

        End While

        sql = "select nombreusuario from usuario where codusuario = " & codu & ""
        Call ejecutar(sql)
        rs.Read()

        cmbUsuarios.Text = rs(0)

    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        If txtAsunto.Text = "" Or txtConsulta.Text = "" Then
            lblErrorCampos.Visible = True

        Else
            If MsgBox("¿Esta seguro de que desea enviar esta consulta?", MsgBoxStyle.YesNo, "Enviar consulta") = MsgBoxResult.Yes Then
                If cmbUsuarios.Text = nombreusuario Then
                    sql = "insert into ticket values('', " & codu & ", null, '" & txtAsunto.Text & "', '" & txtConsulta.Text & "', curdate(), 0)"
                    Call ejecutar(sql)

                    If MsgBox("Se ha guardado su ticket correctamente, se volvera al menu principal", MsgBoxStyle.OkOnly) = MsgBoxResult.Ok Then
                        Me.Close()
                        frmAccionesUsuario.Show()
                    End If

                Else
                    sql = "select codusuario from usuario where nombreusuario = '" & cmbUsuarios.Text & "'"
                    Call ejecutar(sql)
                    rs.Read()
                    sql = "insert into ticket values('', " & codu & ", " & rs(0) & ", '" & txtAsunto.Text & "', '" & txtConsulta.Text & "', curdate(), 0)"
                    Call ejecutar(sql)

                    If MsgBox("Se ha guardado su ticket correctamente, se volvera al menu principal", MsgBoxStyle.OkOnly) = MsgBoxResult.Ok Then
                        Me.Close()
                        frmAccionesUsuario.Show()

                    End If
                End If
            End If
        End If

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        If MsgBox("¿Esta seguro de que desea volver atras?", MsgBoxStyle.YesNo, "Volver atras") = MsgBoxResult.Yes Then
            Me.Close()
            frmAccionesUsuario.Show()

        End If

    End Sub

End Class