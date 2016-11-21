Imports Capa_Datos
Imports Capa_Logica

Public Class frmEstudiante
    Private dt As DataTable
    Private Sub Limpiar()
        btnguardar.Enabled = True
        btneditar.Enabled = False
        txtidestudiante.Text = ""
        txtnombre.Text = ""
        txtapellidos.Text = ""
        txtcedula.Text = ""
        txttelefono.Text = " "
        txtdireccion.Text = " "
        txtfechanac.Text = ""
        txtemail.Text = ""
    End Sub
    Private Sub Mostrar()
        Try

            dt = GestorEstudiante.ObtenerEstudiantes()
            datalistado.Columns.Item("Eliminar").Visible = False


            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtbuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                datalistado.DataSource = Nothing
                txtbuscar.Enabled = False
                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        btnnuevo.Enabled = True
        btneditar.Enabled = False

        Buscar()

    End Sub
    Private Sub Buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = cbocampo.Text & " like '" & txtbuscar.Text & "%'"

            If dv.Count <> 0 Then
                inexistente.Visible = False
                datalistado.DataSource = dv
                Ocultar_Columnas()

            Else
                inexistente.Visible = True
                datalistado.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub Ocultar_Columnas()
        datalistado.Columns(1).Visible = False

    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs)
        Buscar()

    End Sub
    Private Sub btneliminar_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub cbeliminar_CheckedChanged(sender As Object, e As EventArgs)
        If cbeliminar.CheckState = CheckState.Checked Then
            datalistado.Columns.Item("Eliminar").Visible = True
        Else
            datalistado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub frmEstudiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Limpiar()
        Mostrar()

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtnombre.Text <> "" And txtapellidos.Text <> "" And txtcedula.Text <> "" And txtemail.Text <> "" And txttelefono.Text <> "" And txtdireccion.Text <> "" Then
            Try
                Dim obj As New DEstudiante
                obj.Nombres = txtnombre.Text
                obj.Apellidos = txtapellidos.Text
                obj.Cedula = txtcedula.Text
                obj.FechaNac = txtfechanac.Text
                obj.Email = txtemail.Text
                obj.Telefono = txttelefono.Text
                txtdireccion.Text = txtdireccion.Text

                GestorEstudiante.InsertarEstudiante(obj)
                MessageBox.Show("estudiante registrado correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
                Mostrar()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea editar los datos del Estudiantes?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            If Me.ValidateChildren = True And txtnombre.Text <> "" And txtapellidos.Text <> "" And txtcedula.Text <> "" And txtemail.Text <> "" And txttelefono.Text <> "" And txtdireccion.Text <> "" Then
                Try
                    Dim obj As New DEstudiante
                    obj.IDEstudiante = txtidestudiante.Text
                    obj.Nombres = txtnombre.Text
                    obj.Apellidos = txtapellidos.Text
                    obj.Cedula = txtcedula.Text
                    obj.FechaNac = txtfechanac.Text
                    obj.Email = txtemail.Text
                    obj.Telefono = txttelefono.Text
                    GestorEstudiante.InsertarEstudiante(obj)
                    MessageBox.Show("Estudiante Modificada correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Mostrar()
                    Limpiar()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Falta ingresar algunos datos", "MOdificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        
    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        txtidestudiante.Text = datalistado.SelectedCells.Item(1).Value
        txtnombre.Text = datalistado.SelectedCells.Item(2).Value
        txtapellidos.Text = datalistado.SelectedCells.Item(3).Value
        txtcedula.Text = datalistado.SelectedCells.Item(4).Value
        txtfechanac.Text = datalistado.SelectedCells.Item(5).Value
        txttelefono.Text = datalistado.SelectedCells.Item(6).Value
        txtemail.Text = datalistado.SelectedCells.Item(7).Value
        txtdireccion.Text = datalistado.SelectedCells.Item(8).Value

    End Sub

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick

    End Sub

    Private Sub cbeliminar_CheckedChanged_1(sender As Object, e As EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            datalistado.Columns.Item("Eliminar").Visible = True
        Else
            datalistado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub btneliminar_Click_1(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea eliminar los Estudiantes seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim obj As New DEstudiante
                        Dim id As Integer = Convert.ToInt32(row.Cells("ID_ESTUD").Value)
                        obj.IDEstudiante = id

                        AccesoEstudiante.EliminarEstudiante(obj)

                    End If

                Next
                Call Mostrar()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Mostrar()
        End If

        Call Limpiar()

    End Sub

    Private Sub txtbuscar_TextChanged_1(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Buscar()

    End Sub
End Class