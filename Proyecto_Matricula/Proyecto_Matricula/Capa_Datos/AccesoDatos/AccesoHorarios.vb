Imports System.Data
Imports System.Data.SqlClient

Public Class AccesoHorarios
    Inherits Configuracion
    Shared cmd As New SqlCommand
    Public Shared Function ObtenerHorarios() As DataTable

        Try
            conectado()
            cmd = New SqlCommand("mostrar_horarios")
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

    Public Shared Sub InsertarHorarios(ByVal obj As DHorario)
        Try
            conectado()
            cmd = New SqlCommand("insertar_horarios")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue(" @HORARIO", obj.Fecha)
            cmd.Parameters.AddWithValue("@DESCRIP", obj.Descripcion)
            

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            desconectado()
        End Try
    End Sub
    Public Shared Sub EditarHorarios(ByVal obj As DHorario)
        Try
            conectado()
            cmd = New SqlCommand("editar_horarios")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@ID_HORARIO", obj.IDHorario)
             cmd.Parameters.AddWithValue(" @HORARIO", obj.Fecha)
            cmd.Parameters.AddWithValue("@DESCRIP", obj.Descripcion)

            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            desconectado()
        End Try
    End Sub

    Public Shared Sub EliminarHorarios(ByVal obj As DHorario)
        Try
            conectado()
            cmd = New SqlCommand("eliminar_horarios")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@ID_HORARIO", SqlDbType.Int).Value = obj.IDHorario
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectado()

        End Try
    End Sub

End Class
