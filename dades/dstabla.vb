

Partial Public Class dstabla
    Partial Public Class comandaDataTable
        Private Sub comandaDataTable_comandaRowChanging(sender As Object, e As comandaRowChangeEvent) Handles Me.comandaRowChanging

        End Sub

        Private Sub comandaDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.nombreColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class
End Class
