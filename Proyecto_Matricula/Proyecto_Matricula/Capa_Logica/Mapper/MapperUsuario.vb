Imports Capa_Datos

Public Class MapperUsuario

    Public Shared Function ObtenerUsuario(ptable As DataTable) As DUsuario

        Dim usuario As New DUsuario

        If ptable.Rows.Count > 0 Then

            Dim row As DataRow = ptable.Rows(0)
            usuario.CodUsuario = Convert.ToInt32(row("ID_USUARIO").ToString())
            usuario.Nombre = row("NOMBRE").ToString()
            usuario.Apellido = row("APELLIDOS").ToString()
            usuario.Usuario = row("USUARIO").ToString()
            usuario.Pass = row("PASS").ToString()
            usuario.IdRol = Convert.ToInt32(row("ID_ROL").ToString())
        End If


        Return usuario
    End Function



End Class
