Imports System.Data.Odbc

Public Class frmCrearUsuario

    Dim codp As Integer

    Private Sub frmCrearUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()

        sql = "select claseusuario from tipousuario"
        Call ejecutar(sql)

        While rs.Read
            cmbTipoUsuario.Items.Add(rs(0))

        End While

    End Sub

    Private Sub btnLista_Click(sender As Object, e As EventArgs) Handles btnLista.Click
        frmLista.Show()

    End Sub

    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        If txtID.Text = "" Then
            lblErrorCampos.Visible = True

        Else
            sql = "select count(codpersona) from persona where codpersona = " & txtID.Text & ""
            Call ejecutar(sql)
            rs.Read()

            If rs(0) = 0 Then
                MsgBox("No existe una persona con ese ID. Por favor, ingrese un ID valido", MsgBoxStyle.Critical, "Persona desconocida")

            Else
                sql = "select count(u.codpersona) from usuario u, persona p where u.codpersona = p.codpersona and u.codpersona = " & txtID.Text & " and u.codpersona in(select codpersona from persona)"
                Call ejecutar(sql)
                rs.Read()

                If rs(0) = 0 Then
                    MsgBox("Esta persona existe y no dispone de un usuario, puede continuar", MsgBoxStyle.Information, "Persona existente")
                    codp = txtID.Text
                    txtID.Text = ""
                    txtID.Enabled = False
                    btnVerificar.Enabled = False
                    lblErrorCampos.Visible = False
                    gbxUsuario.Enabled = True

                Else
                    MsgBox("Esta persona existe pero ya dispone de un usuario", MsgBoxStyle.Exclamation, "Usuario existente")

                End If
            End If
        End If

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If txtNombre.Text = "" Or cmbTipoUsuario.Text = "" Or txtContraseña.Text = "" Or txtConfirmarContraseña.Text = "" Then
            lblErrorCamposR.Visible = True

        Else
            sql = "select count(nombreusuario) from usuario where nombreusuario = '" & txtNombre.Text & "'"
            Call ejecutar(sql)
            rs.Read()

            If rs(0) = 0 Then
                If txtConfirmarContraseña.Text <> txtContraseña.Text Then
                    MsgBox("Las contrseñas no coinciden", MsgBoxStyle.Critical, "Contraseñas distintas")

                Else
                    If cmbTipoUsuario.Text = "Administrador" Then
                        sql = "insert into usuario values('', 1, " & codp & ", '" & txtNombre.Text & "', '" & txtContraseña.Text & "', 1)"
                        Call ejecutar(sql)
                        MsgBox("El administrador ha sido ingresado con exito", MsgBoxStyle.Information, "Usuario creado correctamnete")
                        Me.Close()
                        frmAccionesAdministrador.Show()

                    ElseIf cmbTipoUsuario.Text = "Usuario" Then
                        sql = "insert into usuario values('', 2, " & codp & ", '" & txtNombre.Text & "', '" & txtContraseña.Text & "', 1)"
                        Call ejecutar(sql)
                        MsgBox("El usuario ha sido ingresado con exito", MsgBoxStyle.Information, "Usuario creado correctamnete")
                        Me.Close()
                        frmAccionesAdministrador.Show()

                    End If

                End If

            Else
                MsgBox("El nombre de usuario ingresdo ya existe", MsgBoxStyle.Critical, "Nombre de usuario en uso")

            End If

        End If

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        If MsgBox("¿Esta seguro de que desea volver atras?", MsgBoxStyle.YesNo, "Volver atras") = MsgBoxResult.Yes Then
            Me.Close()
            frmAccionesAdministrador.Show()

        End If

    End Sub

    Private Sub chkVerContraseña_CheckedChanged(sender As Object, e As EventArgs) Handles chkVerContraseña.CheckedChanged
        If chkVerContraseña.Checked = True Then
            txtContraseña.UseSystemPasswordChar = False

        Else
            txtContraseña.UseSystemPasswordChar = True

        End If

    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.KeyPress
        onlynum(e)

    End Sub
End Class