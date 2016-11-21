Imports System.Data
Imports System.Data.SqlClient

Public Class AccesoHoraCurso
    Inherits Configuracion
    Shared cmd As New SqlCommand
    Public Shared Function ObtenerCursoHora() As DataTable

        Try
            conectado()
            cmd = New SqlCommand("mostrar_curso_hora")
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



    Public Shared Sub InsertarCursoHora(ByVal obj As DCurso_Hora )
        Try
            conectado()
            cmd = New SqlCommand("insertar_curso_hora")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@ID_CURSO", obj.IDCurso)
            cmd.Parameters.AddWithValue("@ID_HORARIO", obj.IDHora)


            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            desconectado()
        End Try
    End Sub

    Public Shared Sub EditarCursoHora(ByVal obj As DCurso_Hora)
        Try
            conectado()
            cmd = New SqlCommand("editar_curso_hora")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@ID_CursoHora", obj.IDCurHorario)
            cmd.Parameters.AddWithValue("@ID_MATRCULA", obj.IDCurso)
            cmd.Parameters.AddWithValue("@ID_HORARIO", obj.IDHora)

            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            desconectado()
        End Try
    End Sub

    Public Shared Sub EliminarCursoHora(ByVal obj As DCurso_Hora)
        Try
            conectado()
            cmd = New SqlCommand("eliminar_curso_hora")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@ID_CursoHora ", SqlDbType.Int).Value = obj.IDCurHorario
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectado()

        End Try
    End Sub

End Class
