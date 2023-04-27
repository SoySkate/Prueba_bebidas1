Public Class Lista

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Lista_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Aixo es el mateix que fa el sql ala tabla
        'Dstabla.comanda.AddcomandaRow(NombreTextBox.Text, Integer.Parse(UnidadesTextBox.Text), Decimal.Parse(Precio_unidadTextBox.Text), Decimal.Parse(TotalTextBox.Text))


        ComandaBindingSource.AddNew()

        'Veig que per afegir alguna cosa el que he de fer es clicar 2 cops el button de add, un al inicia y unaltre al haber acabat





    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Comprobar si el fa el endedit.
        ComandaBindingSource.EndEdit()
        ComandaBindingSource.ResetBindings(False)
        Dstabla.WriteXml("C:\Users\formacio3\source\repos\Prueba_bebidas\datosguardados.xml")
        'Me.Dstabla.ReadXml("C:\Users\formacio3\source\repos\Prueba_bebidas\datosguardados.xml")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub


    Private Sub UnidadesTextBox_LostFocus(sender As Object, e As EventArgs) Handles UnidadesTextBox.LostFocus

        Dim s1, s2 As String
        Dim Total As Decimal
        s1 = UnidadesTextBox.Text.Trim
        s2 = Precio_unidadTextBox.Text.Trim

        Total = Multiplicar(s1, s2)
        TotalTextBox.Text = Total.ToString()


        'Dim x, y, total As Decimal

        'Dim s1, s2 As String
        's1 = UnidadesTextBox.Text.Trim
        's2 = Precio_unidadTextBox.Text.Trim

        'If s1 <> "" AndAlso s2 <> "" Then
        '    x = Decimal.Parse(s1)
        '    y = Decimal.Parse(s2)
        '    total = x * y
        '    TotalTextBox.Text = total.ToString()

        'End If


        'If (x <> 0 And y > 0) Then
        '    x = Decimal.Parse(UnidadesTextBox.Text)
        '    y = Decimal.Parse(Precio_unidadTextBox.Text)
        '    total = x * y



        '    TotalTextBox.Text = total.ToString()
        'End If
    End Sub

    Private Sub Precio_unidadTextBox_LostFocus(sender As Object, e As EventArgs) Handles Precio_unidadTextBox.LostFocus


        Dim s1, s2 As String
        Dim Total As Decimal
        s1 = UnidadesTextBox.Text.Trim
        s2 = Precio_unidadTextBox.Text.Trim

        Total = Multiplicar(s1, s2)
        TotalTextBox.Text = Total.ToString()

        'Dim x, y, total As Decimal

        'Dim s1, s2 As String
        's1 = UnidadesTextBox.Text.Trim
        's2 = Precio_unidadTextBox.Text.Trim

        'If s1 <> "" AndAlso s2 <> "" Then
        '    x = Decimal.Parse(s1)
        '    y = Decimal.Parse(s2)
        '    total = x * y
        '    TotalTextBox.Text = total.ToString()

        'End If



        'Dim x, y, total As Decimal
        'If (x > 0 And y > 0) Then
        '    x = Decimal.Parse(UnidadesTextBox.Text)
        '    y = Decimal.Parse(Precio_unidadTextBox.Text)
        '    total = x * y


        '    TotalTextBox.Text = total.ToString()

        'End If
    End Sub

    Private Function Multiplicar(ByVal s1 As String, ByVal s2 As String) As Decimal

        Dim x, y, total As Decimal

        If s1 <> "" AndAlso s2 <> "" Then
            x = Decimal.Parse(s1)
            y = Decimal.Parse(s2)
            total = x * y
            Return total

        Else
            Return 0
        End If


    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        RandomNums()
        'Quiero que no se repitan los numsss

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        OrdenarLista()


    End Sub

    Private Function RandomNums() As Integer
        Dim r As Integer


        Do

            r = CInt((10 * Rnd()) + 1)

            ListBox1.Items.Add(r)

            'If CInt(ListBox1.Items(r)) = r Then

            '    r = CInt((10 * Rnd()) + 1)
            '    ListBox1.Items.Add(r)
            'Else ListBox1.Items.Add(r)
            'End If

        Loop While (ListBox1.Items.Count <= 9)

    End Function

    Private Function OrdenarLista() As Integer

        Dim i, j As Integer
        Dim a(0) As Integer
        Dim n As Integer

        n = ListBox1.Items.Count
        ReDim Preserve a(n - 1)

        'Lista1 --> a()
        For i = 0 To n - 1
            a(i) = CInt(ListBox1.Items(i))
        Next

        'Aplicar burbuja
        Dim aux As Integer

        For i = 0 To n - 2
            For j = 0 To n - i - 2

                If a(j) > a(j + 1) Then

                    aux = a(j)
                    a(j) = a(j + 1)
                    a(j + 1) = aux

                End If
            Next
        Next


        'a() --> Lista2

        For i = 0 To n - 1
            ListBox2.Items.Add(a(i))
        Next



        'Primera burbuja de prueba

        'For i = 0 To ListBox1.Items.Count - 2
        '    For j = 0 To ListBox1.Items.Count - i - 2

        '        a = CInt(ListBox1.Items(i))
        '        amasuno = CInt(ListBox1.Items(i + 1))

        '        If a > amasuno Then
        '            min = a
        '            ListBox1.Items(i) = amasuno
        '            ListBox1.Items(i + 1) = min
        '        End If

        '    Next

        'Next



        'min = 0
        'Do

        '    For i = 0 To ListBox1.Items.Count - 1

        '        indice = 0
        '        x = CInt(ListBox1.Items(i))
        '        If min = 0 Then
        '            min = x
        '            indice = i
        '        End If
        '        If (x < min) Then
        '            indice = i
        '            min = x
        '        End If

        '    Next

        '    ListBox2.Items.Add(min)
        '    ListBox1.Items.RemoveAt(indice)

        'Loop While (ListBox1.Items.Count <> 0)


    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        TextBox1.BackColor = Color.Red
        'changebackcolor(TextBox1)

    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        TextBox1.BackColor = Color.White
    End Sub
End Class