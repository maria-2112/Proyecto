Imports System.Data
Imports System.Data.SqlClient
Public Class AccesoUsuario
    Inherits Configuracion
    Shared cmd As New SqlCommand
    Public Shared Function ObtenerUsuario(pusuario As DUsuario) As DataTable

        Try
            conectado()
            cmd = New SqlCommand("mostrar_usuario")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@USUARIO", pusuario.Usuario)
            cmd.Parameters.AddWithValue("@PASS", pusuario.Pass)


            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function


End Class
