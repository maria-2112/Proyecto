Imports System.Data
Imports System.Data.SqlClient

Public Class AccesoDetalleCuota
    Inherits Configuracion
    Shared cmd As New SqlCommand
    Public Shared Sub ObtenerDetalleCuota(ByVal obj As DDetalle_Cuotas_Extras)

        Try
            conectado()
            cmd = New SqlCommand("mostrar_detalles_cuotas_extras")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cnn
            cmd.Parameters.Add("@ID_DETALLE_EXTRA", SqlDbType.Int).Value = obj.IDDCuotaExt
            cmd.ExecuteNonQuery 
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            desconectado()
        End Try
    End Sub

   

    Public Shared Sub InsertarDetalleCuota(ByVal obj As DDetalle_Cuotas_Extras)
        Try
            conectado()
            cmd = New SqlCommand("insertar_detalles_cuotas_extras")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@ID_MATRCULA", obj.IDMatricula)
            cmd.Parameters.AddWithValue("@ID_EXTRA", obj.IDExtra)


            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            desconectado()
        End Try
    End Sub

    Public Shared Sub EditarDetalleCuota(ByVal obj As DDetalle_Cuotas_Extras)
        Try
            conectado()
            cmd = New SqlCommand("editar_detalles_cuotas_extras")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@ID_DETALLE_EXTRA", obj.IDDCuotaExt)
            cmd.Parameters.AddWithValue("@ID_MATRCULA", obj.IDMatricula)
            cmd.Parameters.AddWithValue("@ID_EXTRA", obj.IDExtra)

            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            desconectado()
        End Try
    End Sub

    Public Shared Sub EliminarDetalleCuota(ByVal obj As DDetalle_Cuotas_Extras)
        Try
            conectado()
            cmd = New SqlCommand("eliminar_detalles_cuotas_extras")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@ID_DETALLE_EXTRA", SqlDbType.Int).Value = obj.IDDCuotaExt
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectado()

        End Try
    End Sub
End Class
