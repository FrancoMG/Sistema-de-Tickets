Imports System.Data.Common
Imports System.Data.Odbc
Module Module1

    Public cnn As OdbcConnection
    Public cmd As OdbcCommand
    Public rs As OdbcDataReader
    Public rs2 As OdbcDataReader
    Public rs3 As OdbcDataReader
    Public sql As String
    Public nombreadmin As String
    Public nombreusuario As String
    Public codu As Integer
    Public switch As Integer = 1
    Public claseusuario As String

    Public Sub ejecutar(ByVal consulta As String)

        cmd = New OdbcCommand(consulta, cnn)
        cmd.CommandType = CommandType.Text

        If switch = 1 Then
            rs = cmd.ExecuteReader

        ElseIf switch = 2 Then
            rs2 = cmd.ExecuteReader

        ElseIf switch = 3 Then
            rs3 = cmd.ExecuteReader

        End If

        cmd.Dispose()

    End Sub

    Public Sub connection()
Try
            cnn = New OdbcConnection("DSN=TICKETS")
            cnn.Open()

        Catch ex As Exception
            MsgBox("Error al conectarse", MsgBoxStyle.Critical, "Error de conexion")

        End Try

    End Sub

    Public Function llenarGrilla(ByVal sql As String) As DataTable

        Dim ds As DataSet
        Dim adp As OdbcDataAdapter

        ds = New DataSet("Tabla")
        ds.Tables.Add("Tabla")
        adp = New OdbcDataAdapter(sql, cnn)
        adp.Fill(ds.Tables("Tabla"))

        Return ds.Tables("Tabla")

    End Function

    Public Sub onlynum(ByVal e)

        If Char.IsDigit(e.keychar) Then

            e.handled = False

        ElseIf Char.IsControl(e.keychar) Then

            e.handled = False

        Else

            e.handled = True

        End If

    End Sub

End Module
