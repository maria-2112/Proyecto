Imports System.Data.SqlClient

Public Class Configuracion
    Public Shared cnn As New SqlConnection
    Shared _cadenaConexion As String = "Data Source=(local);Initial Catalog=DBMATRICULA;Integrated Security=True"
    Public Shared ReadOnly Property CadenaConexion() As String
        Get
            Return _cadenaConexion
        End Get
    End Property
    Protected Shared Function conectado()
        Try
            Dim _cadenaConexion = CadenaConexion

            cnn.ConnectionString = _cadenaConexion
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Protected Shared Function desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
