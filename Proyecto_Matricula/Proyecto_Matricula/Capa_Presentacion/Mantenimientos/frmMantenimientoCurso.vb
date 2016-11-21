Imports Capa_Logica
Imports Capa_Datos

Public Class frmMantenimientoCurso
    Private dt As DataTable

    Private Sub llenarcombox()
        dt = GestorSede.ObtenerSede()
        cbmSede.DataSource = dt
        cbmSede.ValueMember = "ID_SEDE"
        cbmSede.DisplayMember = "NOMBRE"
    End Sub
    Private Sub Limpiar()
        btnguardar.Enabled = True
        btneditar.Enabled = False
        txtidCurso.Text = ""

        txtnombre.Text = ""

        txtdesccripcion.Text = ""
        txtcupo.Text = "0"
        txtcosto.Text = "0"
    End Sub
    Private Sub Mostrar()
        Try

            dt = GestorCurso.ObtenerCurso()


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
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Limpiar()
    End Sub

    Private Sub frmMantenimientoCurso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
        llenarcombox()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtnombre.Text <> "" And txtdesccripcion.Text <> "" And txtcupo.Text <> "" And txtcosto.Text <> "" Then
            Try
                Dim obj As New DCurso()
                obj.Nombre = txtnombre.Text
                obj.IDSede = cbmSede.SelectedItem("ID_SEDE").ToString()
                obj.Descripcion = txtdesccripcion.Text
                obj.Cupo = txtcupo.Text
                obj.Costo = txtcosto.Text
                GestorCurso.InsertarCurso(obj)
                MessageBox.Show("curso registrada correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Buscar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea editar los datos del Curso?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtnombre.Text <> "" And txtdesccripcion.Text <> "" And txtcupo.Text <> "" And txtcosto.Text <> "" Then
                Try
                    Dim obj As New DCurso()
                    obj.Nombre = txtnombre.Text
                    obj.IDSede = cbmSede.SelectedItem("ID_SEDE").ToString()
                    obj.Descripcion = txtdesccripcion.Text
                    obj.Cupo = txtcupo.Text
                    obj.Costo = txtcosto.Text
                    GestorCurso.EditarCurso(obj)

                    MessageBox.Show("curso Modificada correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub cbeliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            datalistado.Columns.Item("Eliminar").Visible = True
        Else
            datalistado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        txtidCurso.Text = datalistado.SelectedCells.Item(1).Value
        txtnombre = datalistado.SelectedCells.Item(2).Value
        txtdesccripcion = datalistado.SelectedCells.Item(3).Value
        cbmSede.Text = datalistado.SelectedCells.Item(4).Value
        txtcupo = datalistado.SelectedCells.Item(5).Value
        txtcosto = datalistado.SelectedCells.Item(6).Value
    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea eliminar los cursos seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim obj As New DCurso
                        Dim id As Integer = Convert.ToInt32(row.Cells("idcategoria").Value)
                        obj.IDCurso = id

                        AccesoCurso.EliminarCurso(obj)

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

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        If txtflag.Text = "1" Then
            'mas  tarde
        End If
    End Sub
End Class