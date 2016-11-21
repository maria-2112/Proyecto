Imports Capa_Datos

Public Class GestorUsuario

    Public Shared Function ObtenerUsuario(pusuario As DUsuario) As DUsuario
        Try
            Return MapperUsuario.ObtenerUsuario(AccesoUsuario.ObtenerUsuario(pusuario))
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Shared Function ValidarCampos(psuario As String, ppass As String) As Boolean
        Try
            Return psuario <> String.Empty And ppass <> String.Empty
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
