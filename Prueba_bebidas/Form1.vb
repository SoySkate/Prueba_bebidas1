Public Class Form1

    'La clase creada aqui fuera esta bien o no para poder acceder a ella desde el button_1??  *SUPUESTAMENTE BIENNN

    Dim lista As New Clase_lista

    'Dim vichy As New Clase_comanda With {
    '    .Nombre = "VichyCatala",
    '    .precio_unidad = 2.4,
    '    .unidades = 1
    '    }


    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim vichy As New Clase_comanda With {
        .Nombre = "VichyCatala",
        .precio_unidad = 2.4D
        }

        For Each unabebida As Clase_comanda In lista.lineas
            If unabebida.Nombre = vichy.Nombre Then
                MsgBox("Ya has añadido este objeto en la lista")
                Exit Sub
            End If
        Next

        If lista.lineas.Contains(vichy) Then

            MsgBox("Ya has añadido este objeto en la lista")
        Else
            lista.lineas.Add(vichy)
            ListBox1.Items.Add(vichy.dameCadenaListBox)
        End If



    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cocacola As New Clase_comanda With {
        .Nombre = "Coca_Cola",
        .precio_unidad = 2.1D
        }

        For Each unabebida As Clase_comanda In lista.lineas
            If unabebida.Nombre = cocacola.Nombre Then
                MsgBox("Ya has añadido este objeto en la lista")
                Exit Sub
            End If
        Next

        If lista.lineas.Contains(cocacola) Then

            MsgBox("Ya has añadido este objeto en la lista")
        Else
            lista.lineas.Add(cocacola)
            ListBox1.Items.Add(cocacola.dameCadenaListBox)
        End If


    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim nestea As New Clase_comanda With {
        .Nombre = "Nestea",
        .precio_unidad = 2.1D
        }

        For Each unabebida As Clase_comanda In lista.lineas
            If unabebida.Nombre = nestea.Nombre Then
                MsgBox("Ya has añadido este objeto en la lista")
                Exit Sub
            End If
        Next

        If lista.lineas.Contains(nestea) Then

            MsgBox("Ya has añadido este objeto en la lista")
        Else
            lista.lineas.Add(nestea)
            ListBox1.Items.Add(nestea.dameCadenaListBox)
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim aquarius As New Clase_comanda With {
        .Nombre = "Aquarius",
        .precio_unidad = 2.1D
        }

        For Each unabebida As Clase_comanda In lista.lineas
            If unabebida.Nombre = aquarius.Nombre Then
                MsgBox("Ya has añadido este objeto en la lista")
                Exit Sub
            End If
        Next

        If lista.lineas.Contains(aquarius) Then

            MsgBox("Ya has añadido este objeto en la lista")
        Else
            lista.lineas.Add(aquarius)
            ListBox1.Items.Add(aquarius.dameCadenaListBox)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim i As Integer = ListBox1.SelectedIndex
        If (i >= 0) Then
            ' Me.lista.lineas(i).unidades += 1
            Me.lista.lineas(i).incrementarUd()
            ListBox1.Items.RemoveAt(i) ' Me.lista.lineas(i).dameCadenaListBox
            ListBox1.Items.Insert(i, Me.lista.lineas(i).dameCadenaListBox)
            ListBox1.SelectedIndex = i
        Else
            MsgBox("error: no se ha seleccionado ninguna linea")
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim i As Integer = ListBox1.SelectedIndex
        If (i >= 0) Then
            'Me.lista.lineas(i).unidades -= 1
            Me.lista.lineas(i).reducirUd()
            ListBox1.Items.RemoveAt(i) ' Me.lista.lineas(i).dameCadenaListBox
            ListBox1.Items.Insert(i, Me.lista.lineas(i).dameCadenaListBox)
            ListBox1.SelectedIndex = i
        Else
            MsgBox("error: no se ha seleccionado ninguna linea")
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Panel1.Show()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Panel1.Hide()
        'Panel1.ResetText()  este metodo no está funcionando xd

    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        Dim i As Integer = ListBox1.SelectedIndex
        If (i >= 0) Then
            ListBox1.Items.RemoveAt(i)
            lista.lineas.RemoveAt(i)

        End If

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim nuevoProducto As New Clase_comanda
        nuevoProducto.Nombre = TextBox1.Text
        nuevoProducto.precio_unidad = System.Convert.ToDecimal(TextBox4.Text)

        If lista.lineas.Contains(nuevoProducto) Then

            MsgBox("Ya has añadido este objeto en la lista")
        Else
            lista.lineas.Add(nuevoProducto)
            ListBox1.Items.Add(nuevoProducto.dameCadenaListBox)
        End If

        Panel1.Hide()

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress

        'Restringir letras en el precio
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False  ' Si dígitos
        ElseIf e.KeyChar.IsLetter(e.KeyChar) Then
            e.Handled = True  ' No letras
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = True  ' No espacios
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False  'Si eliminar
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'Otra opcion que será editar nombre y precio de una linea añadida
        TextBox3.Show()
        TextBox4.Show()
        Button12.Show()


        'Me.lista.lineas(i).changeName()

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox3.Hide()
        TextBox4.Hide()
        Button12.Hide()

        Dim i As Integer = ListBox1.SelectedIndex

        If (i >= 0) Then
            Me.lista.lineas(i).changeName(TextBox3.Text)
            Me.lista.lineas(i).changePrice(System.Convert.ToDecimal(TextBox4.Text))
            If Decimal.TryParse(TextBox4.Text, New Decimal) Then

            End If
            ListBox1.Items.RemoveAt(i)
            ListBox1.Items.Insert(i, Me.lista.lineas(i).dameCadenaListBox)
        Else
            MsgBox("Para modificar un producto hay que seleccionarlo previamente")
        End If



    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim a As New Lista()
        a.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
