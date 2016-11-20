Imports System.Data
Imports System.Data.SqlClient
Public Class AccesoCurso
    Inherits Configuracion
    Shared cmd As New SqlCommand
    Public Shared Function ObtenerCursos() As DataTable

        Try
            conectado()
            cmd = New SqlCommand("mostrar_curso")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cnn

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

    Public Shared Sub InsertarCurso(ByVal obj As DCurso)
        Try
            conectado()
            cmd = New SqlCommand("insertar_curso")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@NOMBRE", obj.Nombre)
            cmd.Parameters.AddWithValue("@DESCRIPCION", obj.Descripcion)
            cmd.Parameters.AddWithValue("@ID_SEDE", obj.IDSede)
            cmd.Parameters.AddWithValue("@CUPO", obj.Cupo)
            cmd.Parameters.AddWithValue("@COSTO", obj.Costo)

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            desconectado()
        End Try
    End Sub
    Public Shared Sub EditarCurso(ByVal obj As DCurso)
        Try
            conectado()
            cmd = New SqlCommand("editar_curso")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idcurso", obj.IDCurso)
            cmd.Parameters.AddWithValue("@NOMBRE", obj.Nombre)
            cmd.Parameters.AddWithValue("@DESCRIPCION", obj.Descripcion)
            cmd.Parameters.AddWithValue("@ID_SEDE", obj.IDSede)
            cmd.Parameters.AddWithValue("@CUPO", obj.Cupo)
            cmd.Parameters.AddWithValue("@COSTO", obj.Costo)

            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            desconectado()
        End Try
    End Sub

    Public Shared Sub EliminarCurso(ByVal obj As DCurso)
        Try
            conectado()
            cmd = New SqlCommand("eliminar_curso")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idcurso", SqlDbType.Int).Value = obj.IDCurso
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectado()

        End Try
    End Sub

End Class
