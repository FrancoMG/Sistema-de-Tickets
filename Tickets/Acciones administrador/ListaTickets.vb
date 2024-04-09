Public Class frmListaTickets

    Dim asunto As String
    Dim usuario As String
    Dim consulta As String
    Dim fecha As Date
    Dim countT As Integer
    Dim cantfilas As Integer
    Dim tickets As Integer

    Private Sub frmListaTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "select codticket from ticket where corregido = 0 group by codticket order by codticket"
        Call ejecutar(sql)

        While rs.Read
            'MsgBox(rs(0))
            switch = 2

            sql = "select concat(nombre, ' ' , apellido) from persona p, usuario u, ticket t where p.codpersona = u.codpersona and u.codusuario = t.codusuario and t.codticket = '" & rs(0) & "'"
            Call ejecutar(sql)
            rs2.Read()
            usuario = rs2(0)

            sql = "select asunto from ticket where codticket = '" & rs(0) & "'"
            Call ejecutar(sql)
            rs2.Read()
            asunto = rs2(0)
            'MsgBox(rs2(0))

            sql = "select consulta from ticket where codticket = '" & rs(0) & "'"
            Call ejecutar(sql)
            rs2.Read()
            consulta = rs2(0)

            sql = "select fechaemitido from ticket where codticket = " & rs(0) & ""
            Call ejecutar(sql)
            rs2.Read()
            fecha = rs2(0)

            dgvTickets.Rows.Add()
            cantfilas = dgvTickets.Rows.Count - 1

            'MsgBox("INSERTO")

            dgvTickets.Item(0, cantfilas).Value = rs(0)
            dgvTickets.Item(1, cantfilas).Value = usuario
            dgvTickets.Item(2, cantfilas).Value = asunto
            dgvTickets.Item(3, cantfilas).Value = consulta
            dgvTickets.Item(4, cantfilas).Value = Format(fecha, "yyyy/MM/dd")

        End While
        switch = 1

    End Sub

    Private Sub dgvTickets_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTickets.CellContentClick
        If dgvTickets.FirstDisplayedScrollingRowIndex >= 0 Then
            If dgvTickets.CurrentRow.SetValues.ToString = "" Then
                btnBorrar.Enabled = False

            Else
                btnBorrar.Enabled = True

            End If
        End If

        frmVerTodosTickets.txtAsunto.Text = dgvTickets.CurrentRow.Cells(2).Value.ToString
        frmVerTodosTickets.txtConsulta.Text = dgvTickets.CurrentRow.Cells(3).Value.ToString
        frmVerTodosTickets.ShowDialog()

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Me.Close()
        frmEliminarTickets.Show()

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Close()
        frmAccionesAdministrador.Show()

    End Sub
End Class