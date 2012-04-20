Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim de As dellEntities = New dellEntities()
        Dim lista As IEnumerable(Of iva) = From v In de.iva
                                          Select v


        Dim i As Integer = 0


    End Sub
End Class
