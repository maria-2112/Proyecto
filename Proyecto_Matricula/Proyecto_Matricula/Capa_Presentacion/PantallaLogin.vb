Imports Capa_Datos
Imports Capa_Logica

Public Class PantallaLogin

    Private Sub PantallaLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click

        If GestorUsuario.ValidarCampos(txtUsuario.Text, txtPass.Text) Then
            Dim user As New DUsuario()
            user.Usuario = txtUsuario.Text
            user.Pass = txtPass.Text
            user = GestorUsuario.ObtenerUsuario(user)

            If (user.CodUsuario = 0) Then
                MessageBox.Show("Usuario o contraseña incorrecta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim frmMenuPrincipal As New MenuPrincipal()
                Me.Hide()
                frmMenuPrincipal.user = user
                frmMenuPrincipal.ShowDialog()
            End If
        Else
            MessageBox.Show("Debe completar los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub
End Class