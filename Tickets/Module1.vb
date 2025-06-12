'Imports System.Data.Odbc
'Imports System.Data.Common
Imports System.Data.SQLite
Module Module1

    Public cnn As SQLiteConnection
    Public cmd As SQLiteCommand
    Public rs As SQLiteDataReader
    Public rs2 As SQLiteDataReader
    Public rs3 As SQLiteDataReader
    Public sql As String
    Public nombreadmin As String
    Public nombreusuario As String
    Public codu As Integer
    Public switch As Integer = 1
    Public claseusuario As String

    Public Sub ejecutar(ByVal consulta As String)

        cmd = New SQLiteCommand(consulta, cnn)
        cmd.CommandType = CommandType.Text

        If switch = 1 Then
            rs = cmd.ExecuteReader()

        ElseIf switch = 2 Then
            rs2 = cmd.ExecuteReader()

        ElseIf switch = 3 Then
            rs3 = cmd.ExecuteReader()

        End If

        cmd.Dispose()

    End Sub

    Public Sub connection()
        Try
            cnn = New SQLiteConnection("Data Source=Base Tickets.db;Version=3;")
            cnn.Open()

        Catch ex As Exception
            MsgBox("Error al conectarse", MsgBoxStyle.Critical, "Error de conexion")

        End Try

    End Sub

    Public Function llenarGrilla(ByVal sql As String) As DataTable

        Dim ds As DataSet
        Dim adp As SQLiteDataAdapter

        ds = New DataSet("Tabla")
        ds.Tables.Add("Tabla")
        adp = New SQLiteDataAdapter(sql, cnn)
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
