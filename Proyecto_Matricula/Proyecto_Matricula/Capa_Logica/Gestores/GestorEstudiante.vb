Imports Capa_Datos

Public Class GestorEstudiante
    Public Shared Sub InsertarEstudiante(pDEstudiante As DEstudiante)
        Try
            AccesoEstudiante.InsertarEstudiante(pDEstudiante)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Shared Sub EditarEstudiante(pDEstudiante As DEstudiante)
        Try
            AccesoEstudiante.EditarEstudiante(pDEstudiante)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Shared Function ObtenerEstudiante() As List(Of DEstudiante)
        Try
            Return MapperEstudiante.ObtenerEstudiantes(AccesoEstudiante.ObtenerEstudiante())
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ValidarCampos(pdescripcion As String, ppresupuesto As String) As Boolean
        Try
            Return pdescripcion <> String.Empty And ppresupuesto <> String.Empty
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
