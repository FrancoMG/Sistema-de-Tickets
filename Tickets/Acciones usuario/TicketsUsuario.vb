Public Class frmTicketsUsuario

    Dim asunto As String
    Dim consulta As String
    Dim fecha As Date
    Dim cantfilas As Integer

    Private Sub frmTicketsUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "select codticket from ticket where codusuario = " & codu & " group by codticket order by codticket"
        Call ejecutar(sql)

        While rs.Read
            'MsgBox(rs(0))
            switch = 2

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
            dgvTickets.Item(1, cantfilas).Value = asunto
            dgvTickets.Item(2, cantfilas).Value = consulta
            dgvTickets.Item(3, cantfilas).Value = Format(fecha, "yyyy/MM/dd")

        End While
        switch = 1

    End Sub

    Private Sub dgvTickets_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTickets.CellContentClick
        frmConsultaTicketUsuario.txtAsunto.Text = dgvTickets.CurrentRow.Cells(1).Value.ToString
        frmConsultaTicketUsuario.txtConsulta.Text = dgvTickets.CurrentRow.Cells(2).Value.ToString
        frmConsultaTicketUsuario.ShowDialog()

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Close()
        frmAccionesUsuario.Show()

    End Sub
End Class