Imports System.Data
Imports System.Data.SqlClient
Public Class AccesoSede
    Inherits Configuracion
    Shared cmd As New SqlCommand
    Public Shared Function ObtenerSede() As DataTable

        Try
            conectado()
            cmd = New SqlCommand("mostrar_sede")
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

    Public Shared Sub InsertarSede(ByVal obj As DSede)
        Try
            conectado()
            cmd = New SqlCommand("insertar_sede")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@NOMBRE", obj.Nombre)
            cmd.Parameters.AddWithValue("@DIRECCION", obj.Direccion)
            cmd.Parameters.AddWithValue("@TELEFONO", obj.Telefono)
           

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            desconectado()
        End Try
    End Sub
    Public Shared Sub EditarSede(ByVal obj As DSede)
        Try
            conectado()
            cmd = New SqlCommand("editar_sede")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@ID_SEDE", obj.IDSede)
            cmd.Parameters.AddWithValue("@NOMBRE", obj.Nombre)
            cmd.Parameters.AddWithValue("@DIRECCION", obj.Direccion)
            cmd.Parameters.AddWithValue("@TELEFONO", obj.Telefono)

            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            desconectado()
        End Try
    End Sub

    Public Shared Sub EliminarSede(ByVal obj As DSede)
        Try
            conectado()
            cmd = New SqlCommand("eliminar_sede")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@ID_SEDE", SqlDbType.Int).Value = obj.IDSede
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectado()

        End Try
    End Sub


End Class
