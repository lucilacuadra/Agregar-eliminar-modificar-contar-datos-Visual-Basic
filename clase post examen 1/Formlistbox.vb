Public Class formlistbox



    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click

        If listbox.SelectedIndex = -1 Then
            MsgBox("Debe seleccionaer un item", vbCritical)
            listbox.Focus()
            Exit Sub

        End If
        lblcantidad.Text = listbox.Items.Count
        txtdato.Focus()

        listbox.Items.Remove(listbox.SelectedItem.ToString)

        txtdato.Text = listbox.SelectedItem.ToString()
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click

        If listbox.SelectedIndex = -1 Then
            MsgBox("Debe seleccionaer un item", vbCritical)
            listbox.Focus()
            Exit Sub

        End If
        lblcantidad.Text = listbox.Items.Count
        txtdato.Focus()

        listbox.Items.Remove(listbox.SelectedItem.ToString)


    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Dim opc As Integer
        opc = MsgBox("Está seguro de que quiere limpiar el contenido?", vbYesNo)
        If opc = vbYes Then
            listbox.Items.Clear()
        End If
        lblcantidad.Text = listbox.Items.Count
        txtdato.Focus()
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click

        If txtdato.Text = "" Then
            MsgBox("Debe contener un nombre", vbCritical)
            txtdato.Focus()

        End If
        listbox.Items.Add(txtdato.Text)
        lblcantidad.Text = listbox.Items.Count
        txtdato.Focus()
        txtdato.Text = ""

    End Sub

    Private Sub formlistbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblcantidad.Text = listbox.Items.Count

    End Sub


    Private Sub lblcantidad_TextChanged(sender As Object, e As EventArgs) Handles lblcantidad.TextChanged

        If Val(lblcantidad.Text) > 0 Then
            btnLimpiar.Enabled = True
            btneliminar.Enabled = True
            btnmodificar.Enabled = True


        Else
            btnLimpiar.Enabled = False
            btneliminar.Enabled = False
            btnmodificar.Enabled = False


        End If

    End Sub
End Class
