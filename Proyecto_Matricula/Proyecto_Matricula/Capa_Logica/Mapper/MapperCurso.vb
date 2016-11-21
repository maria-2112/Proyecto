Imports Capa_Datos

Public Class MapperCurso

    'Se obtiene por parametro un datable para ser mapeado para la carga del arraylist
    Public Shared Function ObtenerCursos(ptable As DataTable) As List(Of DCurso)

        Dim listaFechas As New List(Of DCurso)

        For Each row As DataRow In ptable.Rows
            Dim curso As New DCurso
            curso.IDCurso = Convert.ToInt32(row("ID_CURSO").ToString())
            curso.IDSede = row("ID_SEDE").ToString()
            curso.Cupo = Convert.ToInt32(row("CUPO").ToString())
            curso.Nombre = Convert.ToInt32(row("NOMBRE").ToString())
            curso.Descripcion = Convert.ToInt32(row("DESCRIPCION").ToString())
            curso.Costo = Convert.ToDecimal(row("COSTO").ToString())

            listaFechas.Add(curso)
        Next

        Return listaFechas
    End Function

    'Se obtiene por parametro un datable para ser mapeado para la carga del objeto DCurso
    Public Shared Function ObtenerCurso(ptable As DataTable) As DCurso

        Dim curso As New DCurso

        Dim row As DataRow = ptable.Rows(0)
        curso.IDCurso = Convert.ToInt32(row("ID_CURSO").ToString())
        curso.IDSede = row("ID_SEDE").ToString()
        curso.Cupo = Convert.ToInt32(row("CUPO").ToString())
        curso.Nombre = Convert.ToInt32(row("NOMBRE").ToString())
        curso.Descripcion = Convert.ToInt32(row("DESCRIPCION").ToString())
        curso.Costo = Convert.ToDecimal(row("COSTO").ToString())
        Return curso
    End Function
End Class
