Imports Capa_Datos

Public Class MapperMatricula


    'Se obtiene por parametro un datable para ser mapeado para la carga del arraylist
    Public Shared Function ObtenerMatriculas(ptable As DataTable) As List(Of DMatricula)

        Dim listaMatriculas As New List(Of DMatricula)

        For Each row As DataRow In ptable.Rows

            Dim matricula As New DMatricula
            matricula.IDMatricula = Convert.ToInt32(row("ID_MATRCULA").ToString())
            matricula.IDSede = Convert.ToInt32(row("ID_SEDE").ToString())
            matricula.IDEstudiante = Convert.ToInt32(row("ID_ESTUD").ToString())
            matricula.IDInscripcion = Convert.ToInt32(row("ID_INSCRIPCION").ToString())
            matricula.IDFormaPago = Convert.ToInt32(row("ID_FORMA_PAGO").ToString())
            matricula.FechaMatricula = Convert.ToDateTime(row("FECHA").ToString())
            matricula.Nombre = row("NOMBRE").ToString()
            matricula.TipoDoc = row("TIPO_DOCUMENTO").ToString()
            matricula.NumDoc = row("NUM_DOCUMENTO").ToString()

            listaMatriculas.Add(matricula)
        Next

        Return listaMatriculas
    End Function

    'Se obtiene por parametro un datable para ser mapeado para la carga del objeto DCurso
    Public Shared Function ObtenerMatricula(ptable As DataTable) As DMatricula

        Dim matricula As New DMatricula

        Dim row As DataRow = ptable.Rows(0)
        matricula.IDMatricula = Convert.ToInt32(row("ID_MATRCULA").ToString())
        matricula.IDSede = Convert.ToInt32(row("ID_SEDE").ToString())
        matricula.IDEstudiante = Convert.ToInt32(row("ID_ESTUD").ToString())
        matricula.IDInscripcion = Convert.ToInt32(row("ID_INSCRIPCION").ToString())
        matricula.IDFormaPago = Convert.ToInt32(row("ID_FORMA_PAGO").ToString())
        matricula.FechaMatricula = Convert.ToDateTime(row("FECHA").ToString())
        matricula.Nombre = row("NOMBRE").ToString()
        matricula.TipoDoc = row("TIPO_DOCUMENTO").ToString()
        matricula.NumDoc = row("NUM_DOCUMENTO").ToString()
        Return matricula
    End Function

End Class
