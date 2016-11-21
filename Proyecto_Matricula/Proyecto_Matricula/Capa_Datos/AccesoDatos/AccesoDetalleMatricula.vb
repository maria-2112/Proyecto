Imports System.Data
Imports System.Data.SqlClient

Public Class AccesoDetalleMatricula
    Inherits Configuracion
    Shared cmd As New SqlCommand
    Public Shared Sub ObtenerDetalleMatricula(ByVal obj As DDetalle_Matricula)

        Try
            conectado()
            cmd = New SqlCommand("mostrar_detalles_cuotas_extras")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cnn
            cmd.Parameters.Add("@@ID_DETALLE_MATRICULA", SqlDbType.Int).Value = obj.IDDMatricula
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            desconectado()
        End Try
    End Sub



    Public Shared Sub InsertarDetalleMatricula(ByVal obj As DDetalle_Matricula)
        Try
            conectado()
            cmd = New SqlCommand("insertar_detalle_matricula")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@ID_MATRCULA", obj.IDMatricula)
            cmd.Parameters.AddWithValue("@ID_CURSO", obj.IDCurso)
            cmd.Parameters.AddWithValue("@ID_HORARIO", obj.IDHora)


            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            desconectado()
        End Try
    End Sub

    Public Shared Sub EditarDetalleMatricula(ByVal obj As DDetalle_Matricula)
        Try
            conectado()
            cmd = New SqlCommand("editar_detalle_matricula")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@ID_DETALLE_MATRICULA ", obj.IDDMatricula)
            cmd.Parameters.AddWithValue("@ID_MATRCULA", obj.IDMatricula)
            cmd.Parameters.AddWithValue("@ID_CURSO", obj.IDCurso)
            cmd.Parameters.AddWithValue("@ID_HORARIO", obj.IDHora)

            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            desconectado()
        End Try
    End Sub

    Public Shared Sub EliminarDetalleMatricula(ByVal obj As DDetalle_Matricula)
        Try
            conectado()
            cmd = New SqlCommand("eliminar_detalles_cuotas_extras")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@ID_DETALLE_MATRICULA ", SqlDbType.Int).Value = obj.IDDMatricula
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectado()

        End Try
    End Sub
End Class
