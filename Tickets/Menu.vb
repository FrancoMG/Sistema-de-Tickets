Public Class frmMenu

    Dim errorU As Boolean = False
    Dim errorC As Boolean = False
    Dim codp As Integer
    Dim nombrep As String
    Dim apellidop As String

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If txtUsuario.Text = "" Or txtContraseña.Text = "" Then
            MsgBox("Complete los campos vacios para poder continuar", MsgBoxStyle.Exclamation, "Campos vacios")

        Else

            sql = "select count(*) from usuario where contrasena = '" & txtContraseña.Text & "' and nombreusuario = '" & txtUsuario.Text & "' and habilitado = 1"
            Call ejecutar(sql)
            rs.Read()

            If rs(0) = 0 Then
                errorC = True

            Else
                errorC = False

            End If

            If errorC = True Then
                lblErrorC.Text = "El usuario/administrador o la contraeña ingresada no es valida"
                lblErrorC.Visible = True

            Else
                sql = "select codpersona from usuario where nombreusuario = '" & txtUsuario.Text & "'"
                Call ejecutar(sql)
                rs.Read()
                codp = rs(0)
                sql = "select nombre, apellido from persona where codpersona = " & codp & ""
                Call ejecutar(sql)
                rs.Read()
                nombrep = rs(0)
                apellidop = rs(1)

                MsgBox("Bienvenido al sistema " & nombrep & " " & apellidop & "", MsgBoxStyle.Information, "Bienvenido")

                sql = "select codusuario from usuario where nombreusuario = '" & txtUsuario.Text & "'"
                Call ejecutar(sql)
                rs.Read()
                codu = rs(0)

                sql = "select claseusuario from tipousuario t, usuario u where t.codtipousuario = u.codtipousuario and u.nombreusuario = '" & txtUsuario.Text & "'"
                Call ejecutar(sql)
                rs.Read()
                claseusuario = rs(0)

                If claseusuario = "Usuario" Then
                    sql = "select nombreusuario from usuario where codusuario = " & codu & ""
                    Call ejecutar(sql)
                    rs.Read()
                    nombreusuario = rs(0)
                    txtContraseña.Text = ""
                    txtUsuario.Text = ""
                    Me.Hide()
                    frmAccionesUsuario.Show()

                ElseIf claseusuario = "Administrador" Then
                    sql = "select nombreusuario from usuario where codusuario = " & codu & ""
                    Call ejecutar(sql)
                    rs.Read()
                    nombreadmin = rs(0)
                    txtContraseña.Text = ""
                    txtUsuario.Text = ""
                    Me.Hide()
                    frmAccionesAdministrador.Show()

                End If
            End If
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿Esta seguro de que desea salir?", MsgBoxStyle.YesNo, "Salir del sistema") = MsgBoxResult.Yes Then
            End

        End If

    End Sub

    Private Sub chkContraseña_CheckedChange(sender As Object, e As EventArgs) Handles chkContraseña.CheckedChanged
        If chkContraseña.Checked = True Then
            txtContraseña.UseSystemPasswordChar = False

        Else
            txtContraseña.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub txtContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged
        If txtContraseña.Text = "" Then
            lblErrorC.Text = ""

        End If

    End Sub
End Class
