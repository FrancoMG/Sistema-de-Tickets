Imports System.Data.Odbc

Public Class frmBorrarUsuario
    Private Sub frmBorrarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()

        sql = "select nombreusuario from usuario where nombreusuario != '" & nombreadmin & "' and Habilitado=1"
        Call ejecutar(sql)

        While rs.Read
            cmbUsuario.Items.Add(rs(0))

        End While

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If cmbUsuario.Text = "" Then
            lblErrorCampos.Text = "Seleccione el usuario que desea eliminar"
            lblErrorCampos.Visible = True

        Else
            If MsgBox("¿Esta seguro de que desea realizar esta operacion?", MsgBoxStyle.YesNo, "Eliminar usuario") = MsgBoxResult.Yes Then

                sql = "update usuario set Habilitado=0 where nombreusuario='" & cmbUsuario.Text & "'"
                Call ejecutar(sql)
                rs.Read()
                MsgBox("El usuario o administrador han sido eliminados correctamente", MsgBoxStyle.Information, "Usuario eliminado")
                Me.Close()
                frmAccionesAdministrador.Show()
                cmbUsuario.Items.Remove(cmbUsuario.Text)
            End If
        End If

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        If MsgBox("¿Esta seguro de que desea volver atras?", MsgBoxStyle.YesNo, "Volver atras") = MsgBoxResult.Yes Then
            Me.Close()
            frmAccionesAdministrador.Show()

        End If
    End Sub

    Private Sub cmbUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUsuario.SelectedIndexChanged
        If cmbUsuario.Text = "" Then
            lblErrorCampos.Text = ""

        End If

    End Sub
End Class