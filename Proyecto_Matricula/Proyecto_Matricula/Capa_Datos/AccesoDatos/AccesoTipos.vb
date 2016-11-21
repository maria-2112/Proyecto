Imports System.Data
Imports System.Data.SqlClient
Public Class AccesoTipos
    Inherits Configuracion
    Shared cmd As New SqlCommand
    Public Shared Function ObtenerInscripcion() As DataTable

        Try
            conectado()
            cmd = New SqlCommand("mostrar_tipo_inscripcion")
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

    Public Shared Function ObtenerTipoEstudiante() As DataTable

        Try
            conectado()
            cmd = New SqlCommand("mostrar_tipo_estudiante")
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

    Public Shared Sub InsertarInscripcion(ByVal obj As DTipo_Inscripcion)
        Try
            conectado()
            cmd = New SqlCommand("insertar_tipo_inscripcion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@DESCRIPCION", obj.Descripcion)
           

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            desconectado()
        End Try
    End Sub

    Public Shared Sub EliminarInscripcion(ByVal obj As DTipo_Inscripcion)
        Try
            conectado()
            cmd = New SqlCommand("eliminar_tipo_inscripcion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@ID_INSCRIPCION", SqlDbType.Int).Value = obj.IDTipoInscripcion
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectado()

        End Try
    End Sub

End Class
