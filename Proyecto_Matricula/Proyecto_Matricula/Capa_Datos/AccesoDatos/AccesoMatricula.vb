Imports System.Data
Imports System.Data.SqlClient
Public Class AccesoMatricula
    Inherits Configuracion
    Shared cmd As New SqlCommand
    Public Shared Function ObtenerMatricula() As DataTable

        Try
            conectado()
            cmd = New SqlCommand("mostrar_matricula")
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


    Public Shared Function ObtenerMatriculaEstudiante(pestudiante As DEstudiante) As DataTable

        Try
            conectado()
            cmd = New SqlCommand("mostrar_matriculaXEstudiante")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@@ID_ESTUDIANTE", pestudiante.IDEstudiante)

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

    Public Shared Sub InsertarMatricula(ByVal obj As DMatricula)
        Try
            conectado()
            cmd = New SqlCommand("insertar_matricula")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@ID_SEDE", obj.IDSede)
            cmd.Parameters.AddWithValue("@ID_ESTUD ", obj.IDEstudiante)
            cmd.Parameters.AddWithValue("@ID_INSCRIPCION", obj.IDInscripcion)
            cmd.Parameters.AddWithValue("@ID_FORMA_PAGO", obj.IDFormaPago)
            cmd.Parameters.AddWithValue("@FECHA", obj.FechaMatricula)
            cmd.Parameters.AddWithValue("@NOMBRE", obj.Nombre)
            cmd.Parameters.AddWithValue("@TIPO_DOCUMENTO", obj.TipoDoc)
            cmd.Parameters.AddWithValue("@NUM_DOCUMENTO", obj.NumDoc)


            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            desconectado()
        End Try
    End Sub
    Public Shared Sub EditarMatricula(ByVal obj As DMatricula)
        Try
            conectado()
            cmd = New SqlCommand("editar_matricula")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            '-----------------*
            cmd.Parameters.AddWithValue("@ID_MATRICULA", obj.IDMatricula)
            cmd.Parameters.AddWithValue("@ID_SEDE", obj.IDSede)
            cmd.Parameters.AddWithValue("@ID_ESTUD ", obj.IDEstudiante)
            cmd.Parameters.AddWithValue("@ID_INSCRIPCION", obj.IDInscripcion)
            cmd.Parameters.AddWithValue("@ID_FORMA_PAGO", obj.IDFormaPago)
            cmd.Parameters.AddWithValue("@FECHA", obj.FechaMatricula)
            cmd.Parameters.AddWithValue("@NOMBRE", obj.Nombre)
            cmd.Parameters.AddWithValue("@TIPO_DOCUMENTO", obj.TipoDoc)
            cmd.Parameters.AddWithValue("@NUM_DOCUMENTO", obj.NumDoc)

            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            desconectado()
        End Try
    End Sub

    Public Shared Sub EliminarMatricula(ByVal obj As DMatricula)
        Try
            conectado()
            cmd = New SqlCommand("eliminar_matricula")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@ID_MATRICULA ", SqlDbType.Int).Value = obj.IDMatricula
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectado()

        End Try
    End Sub

End Class
