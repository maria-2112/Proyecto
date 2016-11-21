Imports Capa_Datos

Public Class MapperHorario

    'Se obtiene por parametro un datable para ser mapeado para la carga del arraylist
    Public Shared Function ObtenerHorarios(ptable As DataTable) As List(Of DHorario)

        Dim lstHorarios As New List(Of DHorario)

        For Each row As DataRow In ptable.Rows
            Dim horario As New DHorario
            horario.IDHorario = Convert.ToInt32(row("ID_HORARIO").ToString())
            horario.Descripcion = Convert.ToInt32(row("DESCRIP").ToString())
            horario.IDHorario = Convert.ToDateTime(row("HORARIO").ToString())

            lstHorarios.Add(horario)
        Next

        Return lstHorarios
    End Function

    'Se obtiene por parametro un datable para ser mapeado para la carga del objeto DHorario
    Public Shared Function ObtenerHorario(ptable As DataTable) As DHorario

        Dim horario As New DHorario

        Dim row As DataRow = ptable.Rows(0)
        horario.IDHorario = Convert.ToInt32(row("ID_HORARIO").ToString())
        horario.Descripcion = Convert.ToInt32(row("DESCRIP").ToString())
        horario.IDHorario = Convert.ToDateTime(row("HORARIO").ToString())

        Return horario
    End Function

End Class
