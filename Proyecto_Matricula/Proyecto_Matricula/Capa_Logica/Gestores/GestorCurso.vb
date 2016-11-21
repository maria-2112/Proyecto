Imports Capa_Datos


Public Class GestorCurso


    Public Shared Sub InsertarCurso(pDCurso As DCurso)
        Try
            AccesoCurso.InsertarCurso(pDCurso)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Shared Sub EditarCurso(pDCurso As DCurso)
        Try
            AccesoCurso.EditarCurso(pDCurso)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Shared Function ObtenerCursos() As DataTable
        Return AccesoCurso.ObtenerCursos()

    End Function
    'Public Shared Function ObtenerCursos() As List(Of DCurso)
    '    Try
    '        Return MapperCurso.ObtenerCursos(AccesoCurso.ObtenerCursos())
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    Public Shared Function ValidarCampos(pdescripcion As String, ppresupuesto As String) As Boolean
        Try
            Return pdescripcion <> String.Empty And ppresupuesto <> String.Empty
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
