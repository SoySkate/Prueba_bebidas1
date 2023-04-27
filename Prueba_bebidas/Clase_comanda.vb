Public Class Clase_comanda
    Property Nombre As String = ""

    Private mUnidades As Integer = 1

    Public ReadOnly Property unidades As Integer
        Get
            Return mUnidades
        End Get
    End Property

    Property precio_unidad As Decimal = 0
    ReadOnly Property total As Decimal
        Get

            Return precio_unidad * unidades

        End Get

    End Property

    Function dameCadenaListBox() As String
        'Return String.Format("{0:0000.00}", total)'
        Return $"Cantidad: {unidades} ud    {Nombre}    Precio_Ud: {precio_unidad:####.00}€    Total: {total:####.00}€"

    End Function

    Sub incrementarUd()
        If unidades >= 0 Then
            mUnidades += 1
        End If
    End Sub

    Sub reducirUd()
        If unidades <> 0 Then
            mUnidades -= 1
        End If
    End Sub
    Function changeName(text As Integer) As String
        Nombre = text.ToString

    End Function

    Function changeName(text As String) As String
        Nombre = text

    End Function

    Function changePrice(text As Decimal) As Decimal
        precio_unidad = text
    End Function

End Class
