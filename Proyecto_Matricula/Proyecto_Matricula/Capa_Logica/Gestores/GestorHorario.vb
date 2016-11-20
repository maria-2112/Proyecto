Imports Capa_Datos

Public Class GestorHorario

    Public Shared Sub InsertarHorarios(pDHorario As DHorario)
        Try
            AccesoHorarios.InsertarHorarios(pDHorario)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Shared Sub EditarHorarios(pDHorario As DHorario)
        Try
            AccesoHorarios.EditarHorarios(pDHorario)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Shared Function ObtenerCursos() As List(Of DHorario)
        Try
            Return MapperHorario.ObtenerHorarios(AccesoHorarios.ObtenerHorarios())
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
