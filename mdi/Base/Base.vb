''' <summary>
''' Clase utilizada para ser heredada en los demas formularios.
''' </summary>
Public Class Base
#Region "Propiedades"
    ''' <summary>
    ''' Propiedad para indicar a que tabla de la BBDD se va a conectar
    ''' </summary>
    Protected Friend tablaBBDD As String

    ''' <summary>
    ''' Propiedad para guardar los datos de la DataGridView
    ''' </summary>
    Protected Friend dts As DataSet

    ''' <summary>
    ''' Titulo para la impresion del PDF
    ''' </summary>
    Public strTitulo As String = ""

    ''' <summary>
    ''' Propiedad para indicar datos adicionales al PDF
    ''' </summary>
    ''' <remarks></remarks>
    Protected Friend strOpcional As String

    ''' <summary>
    ''' Propiedad para sobreescrivir la consulta de sql para rellenar la DataGridView
    ''' </summary>
    ''' <remarks></remarks>
    Protected Friend strQuery As String = ""
#End Region

#Region "Eventes"

    ''' <summary>
    ''' Evento que carga cuando se muestra el Formulario, qui cargamos la DataGridView vacia.
    ''' </summary>
    ''' <param name="sender">Objeto del evento</param>
    ''' <param name="e">Objeto del evento</param>
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim conn As New AccDatos.OLEDBCON
        If strQuery = "" Then
            dts = conn.ObtenerTablaVacia(tablaBBDD)
        Else
            dts = conn.LanzarQueryT(strQuery + " and 1 = 0")
        End If

        bindearDTS()
        ocultarId()
        KeyPreview = True
    End Sub

    ''' <summary>
    ''' Evento que cierra el formulario.
    ''' </summary>
    ''' <param name="sender">Objeto del evento</param>
    ''' <param name="e">Objeto del evento</param>
    Private Sub txtSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSalir.Click
        Me.Dispose()
    End Sub

    ''' <summary>
    ''' Evento que ejecuta un update de los cambios realizados en la DataGridView
    ''' </summary>
    ''' <param name="sender">Objeto del evento</param>
    ''' <param name="e">Objeto del evento</param>
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim conn As New AccDatos.OLEDBCON
        If strQuery = "" Then
            conn.UpdateDB(dts, "select * from " + tablaBBDD)
        Else
            conn.UpdateDB(dts, strQuery)
        End If
    End Sub

    ''' <summary>
    ''' Metodo que obtiene todos los datos de la tabla indicada
    ''' </summary>
    ''' <param name="sender">Objeto del evento</param>
    ''' <param name="e">Objeto del evento</param>
    Private Sub btnTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTodos.Click
        Dim conn As New AccDatos.OLEDBCON
        If strQuery = "" Then
            dts = conn.ObtenerTabla(tablaBBDD)
        Else
            dts = conn.LanzarQueryT(strQuery)
        End If
        limpiarBinding()
        bindearDTS()
        ocultarId()
    End Sub

    ''' <summary>
    ''' Metodo que limpia la DataGridView, lanzando una consulta nueva, obteniendo solo el nombre de los campos
    ''' </summary>
    ''' <param name="sender">Objeto del evento</param>
    ''' <param name="e">Objeto del evento</param>
    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        limpiarBinding()
        Dim conn As New AccDatos.OLEDBCON
        dts = conn.ObtenerTablaVacia(tablaBBDD)
        bindearDTS()
        ocultarId()
    End Sub

    ''' <summary>
    ''' Metodo que genera el pdf a partir de la DataGridView
    ''' </summary>
    ''' <param name="sender">Objeto del evento</param>
    ''' <param name="e">Objeto del evento</param>
    Private Sub btnPdf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPdf.Click
        tools.clsTools.imprimirDataTableEnPdf(dts, strTitulo, strOpcional)
    End Sub

    ''' <summary>
    ''' Evento que al pulsar la tecla F3 filtra los resultados de la DaaGridView
    ''' </summary>
    ''' <param name="sender">Objeto del evento</param>
    ''' <param name="e">Objeto del evento</param>
    Private Sub Base_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = 114 Then
            filtrarGrid()
        End If

    End Sub

    ''' <summary>
    ''' Evento que limpia los filtros
    ''' </summary>
    ''' <param name="sender">Objeto del evento</param>
    ''' <param name="e">Objeto del evento</param>
    Public Sub btnLimpiarControles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarControles.Click
        Try

            For Each txt In Me.Controls

                If txt.GetType().ToString() = "System.Windows.Forms.GroupBox" Then

                    For Each objTxt In txt.controls
                        If objTxt.GetType().ToString() = "CustomValidatorTextBox.CustomValidatorTextBox" Or objTxt.GetType().ToString() = "System.Windows.Forms.TextBox" Then
                            objTxt.text = ""
                        End If

                        If objTxt.GetType().ToString() = "customTextCs.txtBuscar" Then
                            objTxt.zzTxtId = ""
                            objTxt.zzTxtDesc = ""
                        End If

                    Next

                ElseIf txt.GetType().ToString() = "CustomValidatorTextBox.CustomValidatorTextBox" Or txt.GetType().ToString() = "System.Windows.Forms.TextBox" Then
                    txt.text = ""
                ElseIf txt.GetType().ToString() = "customTextCs.txtBuscar" Then
                    txt.zzTxtId = ""
                    txt.zzTxtDesc = ""
                End If
            Next
            Dim conn As New AccDatos.OLEDBCON
            If strQuery = "" Then
                dts = conn.ObtenerTabla(tablaBBDD)
            Else
                dts = conn.LanzarQueryT(strQuery)
            End If
            limpiarBinding()
            bindearDTS()
            ocultarId()
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Metodos"
    Protected Friend Sub loadfirst()
        Dim conn As New AccDatos.OLEDBCON
        dts = conn.ObtenerTablaVacia(tablaBBDD)
        ocultarId()
        bindearDTS()
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
#End Region

#Region "Overriable"
    ''' <summary>
    ''' Metodo sobreescrivible que oculta las IDs de la DataGridView
    ''' </summary>
    Public Overridable Sub ocultarId()

    End Sub

    ''' <summary>
    ''' Metodo sobreescrivible que filtra los resultados de la DataGridView
    ''' </summary>
    ''' <remarks></remarks>
    Public Overridable Sub filtrarGrid()

    End Sub
#End Region

End Class
