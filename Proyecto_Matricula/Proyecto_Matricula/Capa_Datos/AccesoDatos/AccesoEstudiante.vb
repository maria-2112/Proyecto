Imports System.Data
Imports System.Data.SqlClient
Public Class AccesoEstudiante
    Inherits Configuracion
    Shared cmd As New SqlCommand
    Public Shared Function ObtenerEstudiante() As DataTable

        Try
            conectado()
            cmd = New SqlCommand("mostrar_estudiante")
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

    Public Shared Sub InsertarEstudiante(ByVal obj As DEstudiante)
        Try
            conectado()
            cmd = New SqlCommand("insertar_estudiante")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@NOMBRE", obj.Nombres)
            cmd.Parameters.AddWithValue("@APELLIDO", obj.Apellidos)
            cmd.Parameters.AddWithValue("@DIRECCION", obj.Direccion)
            cmd.Parameters.AddWithValue("@TELEFONO", obj.Telefono)
            cmd.Parameters.AddWithValue("@CEDULA", obj.Cedula)
            cmd.Parameters.AddWithValue("@FECHA_NAC", obj.FechaNac)
            cmd.Parameters.AddWithValue("@ID_TIPO_ESTUDIANTE", obj.IDTipoEstudiante)

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            desconectado()
        End Try
    End Sub
    Public Shared Sub EditarEstudiante(ByVal obj As DEstudiante)
        Try
            conectado()
            cmd = New SqlCommand("editar_estudiante")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@ID_ESTUD", obj.IDEstudiante)
            cmd.Parameters.AddWithValue("@NOMBRE", obj.Nombres)
            cmd.Parameters.AddWithValue("@APELLIDO", obj.Apellidos)
            cmd.Parameters.AddWithValue("@DIRECCION", obj.Direccion)
            cmd.Parameters.AddWithValue("@TELEFONO", obj.Telefono)
            cmd.Parameters.AddWithValue("@CEDULA", obj.Cedula)
            cmd.Parameters.AddWithValue("@FECHA_NAC", obj.FechaNac)
            cmd.Parameters.AddWithValue("@ID_TIPO_ESTUDIANTE", obj.IDTipoEstudiante)

            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            desconectado()
        End Try
    End Sub

    Public Shared Sub EliminarEstudiante(ByVal obj As DEstudiante)
        Try
            conectado()
            cmd = New SqlCommand("eliminar_estudiante")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@ID_ESTUD", SqlDbType.Int).Value = obj.IDEstudiante
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectado()

        End Try
    End Sub

End Class
