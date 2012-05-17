
Public Class Base

    Protected Friend tablaBBDD As String
    Protected Friend dts As DataSet
    Protected Friend strOpcional As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conn As New AccDatos.OLEDBCON
        dts = conn.ObtenerTablaVacia(tablaBBDD)
        bindearDTS()
        ocultarId()
        KeyPreview = True
    End Sub
    Public Overridable Sub ocultarId()

    End Sub
    Public Overridable Sub filtrarGrid()

    End Sub

    Protected Friend Sub loadfirst()
        Dim conn As New AccDatos.OLEDBCON
        dts = conn.ObtenerTablaVacia(tablaBBDD)
        ocultarId()
        bindearDTS()
    End Sub
    Private Sub txtSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSalir.Click
        Me.Dispose()
    End Sub


    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim conn As New AccDatos.OLEDBCON
        conn.UpdateDB(dts, "select * from " + tablaBBDD)
    End Sub



    Private Sub btnTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTodos.Click
        Dim conn As New AccDatos.OLEDBCON
        dts = conn.ObtenerTabla(tablaBBDD)
        limpiarBinding()
        bindearDTS()
        ocultarId()
    End Sub

    Private Sub bindearDTS()
        Try
            For Each txt In Me.Controls

                If txt.tag = "CustomTXT" Then
                    txt.DataBindings.Add("Text", dts.Tables(0), txt.CAMPDB)
                    AddHandler DirectCast(txt, System.Windows.Forms.TextBox).Validated, _
                    AddressOf validartext
                End If
            Next

            dgv.DataSource = dts.Tables(0)
        Catch ex As Exception
            'MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub validartext(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, Windows.Forms.Control).DataBindings(0) _
        .BindingManagerBase.EndCurrentEdit()
    End Sub

    Private Sub limpiarBinding()
        Try

            For Each txt In Me.Controls

                If txt.tag = "CustomTXT" Then
                    txt.DataBindings.removeAt(0)
                    txt.text() = ""
                End If
            Next
            dgv.DataSource = Nothing
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click

        limpiarBinding()
        Dim conn As New AccDatos.OLEDBCON
        dts = conn.ObtenerTablaVacia(tablaBBDD)
        bindearDTS()
        ocultarId()
    End Sub

    Private Sub btnPdf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPdf.Click

        tools.clsTools.imprimirDataTableEnPdf(dts, strOpcional)
    End Sub

    Private Sub Base_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = 114 Then
            filtrarGrid()
        End If

    End Sub
End Class
