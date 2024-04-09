Public Class frmLista

    Dim nombre As String
    Dim apellido As String
    Dim dni As Integer
    Dim direccion As String
    Dim telefono As Integer
    Dim email As String
    Dim cantfilas As Integer

    Private Sub frmLista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "select codpersona from persona where codpersona not in(select codpersona from usuario) group by codpersona order by codpersona"
        Call ejecutar(sql)

        While rs.Read
            'MsgBox(rs(0))
            switch = 2

            sql = "select nombre from persona where codpersona = '" & rs(0) & "'"
            Call ejecutar(sql)
            rs2.Read()
            nombre = rs2(0)
            'MsgBox(rs2(0))

            sql = "select apellido from persona where codpersona = '" & rs(0) & "'"
            Call ejecutar(sql)
            rs2.Read()
            apellido = rs2(0)

            sql = "select dni from persona where codpersona = " & rs(0) & ""
            Call ejecutar(sql)
            rs2.Read()
            dni = rs2(0)

            sql = "select direccion from persona where codpersona = " & rs(0) & ""
            Call ejecutar(sql)
            rs2.Read()
            direccion = rs2(0)

            sql = "select telefono from persona where codpersona = " & rs(0) & ""
            Call ejecutar(sql)
            rs2.Read()
            telefono = rs2(0)

            sql = "select email from persona where codpersona = " & rs(0) & ""
            Call ejecutar(sql)
            rs2.Read()
            email = rs2(0)

            dgvPersonas.Rows.Add()
            cantfilas = dgvPersonas.Rows.Count - 1

            'MsgBox("INSERTO")

            dgvPersonas.Item(0, cantfilas).Value = rs(0)
            dgvPersonas.Item(1, cantfilas).Value = nombre
            dgvPersonas.Item(2, cantfilas).Value = apellido
            dgvPersonas.Item(3, cantfilas).Value = dni
            dgvPersonas.Item(4, cantfilas).Value = direccion
            dgvPersonas.Item(5, cantfilas).Value = telefono
            dgvPersonas.Item(6, cantfilas).Value = email

        End While

        switch = 1

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Close()
        frmCrearUsuario.Show()

    End Sub
End Class