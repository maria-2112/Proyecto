Imports Capa_Datos

Public Class MapperSede

    'Se obtiene por parametro un datable para ser mapeado para la carga del arraylist
    Public Shared Function ObtenerSedes(ptable As DataTable) As List(Of DSede)

        Dim listaSedes As New List(Of DSede)

        For Each row As DataRow In ptable.Rows
            Dim sede As New DSede
            sede.IDSede = Convert.ToInt32(row("ID_SEDE").ToString())
            sede.Nombre = row("NOMBRE").ToString()
            sede.Direccion = row("DIRECCION").ToString()
            sede.Telefono = row("TELEFONO").ToString()

            listaSedes.Add(sede)
        Next

        Return listaSedes
    End Function

    'Se obtiene por parametro un datable para ser mapeado para la carga del objeto DCurso
    Public Shared Function ObtenerSede(ptable As DataTable) As DSede

        Dim sede As New DSede

        Dim row As DataRow = ptable.Rows(0)
        sede.IDSede = Convert.ToInt32(row("ID_SEDE").ToString())
        sede.Nombre = row("NOMBRE").ToString()
        sede.Direccion = row("DIRECCION").ToString()
        sede.Telefono = row("TELEFONO").ToString()

        Return sede
    End Function

End Class
