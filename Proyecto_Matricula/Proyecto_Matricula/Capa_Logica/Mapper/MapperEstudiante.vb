Imports Capa_Datos

Public Class MapperEstudiante

    'Se obtiene por parametro un datable para ser mapeado para la carga del arraylist
    Public Shared Function ObtenerEstudiantes(ptable As DataTable) As List(Of DEstudiante)

        Dim listaFechas As New List(Of DEstudiante)

        For Each row As DataRow In ptable.Rows

            Dim estudiante As New DEstudiante
            estudiante.IDEstudiante = Convert.ToInt32(row("ID_ESTUD").ToString())
            estudiante.IDTipoEstudiante = row("ID_TIPO_ESTUDIANTE").ToString()
            estudiante.Nombres = row("NOMBRE").ToString()
            estudiante.Apellidos = row("APELLIDO").ToString()
            estudiante.Direccion = row("DIRECCION").ToString()
            estudiante.Telefono = row("TELEFONO").ToString()
            estudiante.Cedula = row("CEDULA").ToString()
            estudiante.FechaNac = Convert.ToDateTime(row("FECHA_NAC").ToString())

            listaFechas.Add(estudiante)
        Next

        Return listaFechas
    End Function

    'Se obtiene por parametro un datable para ser mapeado para la carga del objeto DEstudiante
    Public Shared Function ObtenerEstudiante(ptable As DataTable) As DEstudiante

        Dim estudiante As New DEstudiante

        Dim row As DataRow = ptable.Rows(0)
        estudiante.IDEstudiante = Convert.ToInt32(row("ID_ESTUD").ToString())
        estudiante.IDTipoEstudiante = row("ID_TIPO_ESTUDIANTE").ToString()
        estudiante.Nombres = row("NOMBRE").ToString()
        estudiante.Apellidos = row("APELLIDO").ToString()
        estudiante.Direccion = row("DIRECCION").ToString()
        estudiante.Telefono = row("TELEFONO").ToString()
        estudiante.Cedula = row("CEDULA").ToString()
        estudiante.FechaNac = Convert.ToDateTime(row("FECHA_NAC").ToString())
        Return estudiante
    End Function

End Class
