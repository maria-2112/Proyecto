Imports Capa_Datos

Public Class GestorMatricula

    Public Shared Sub InsertarCurso(pDMatricula As DMatricula)
        Try
            AccesoMatricula.InsertarMatricula(pDMatricula)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Shared Sub EditarCurso(pDMatricula As DMatricula)
        Try
            AccesoMatricula.EditarMatricula(pDMatricula)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Shared Function ObtenerMatriculas() As List(Of DMatricula)
        Try
            Return MapperMatricula.ObtenerMatriculas(AccesoMatricula.ObtenerMatricula())
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ObtenerMatriculaEstudiante(pestudiante As DEstudiante) As DMatricula
        Try
            Return MapperMatricula.ObtenerMatricula(AccesoMatricula.ObtenerMatriculaEstudiante(pestudiante))
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
