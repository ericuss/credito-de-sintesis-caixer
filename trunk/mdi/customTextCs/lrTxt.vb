Public Class lrTxt
#Region "Propiedades"
    Private widthId_ As String
    Public Property zzWidthId() As String
        Get
            Return widthId_
        End Get
        Set(ByVal value As String)
            widthId_ = value
            txtId.Width = value
        End Set
    End Property
    Private widthDesc_ As String
    Public Property zzWidthDesc() As String
        Get
            Return widthDesc_
        End Get
        Set(ByVal value As String)
            widthDesc_ = value
            txtDesc.Width = value
        End Set
    End Property

    Private idIsNumeric_ As Boolean
    Public Property zzIdIsNumber() As Boolean
        Get
            Return idIsNumeric_
        End Get
        Set(ByVal value As Boolean)
            idIsNumeric_ = value
        End Set
    End Property


    Private campoId_ As String
    Public Property zzCampoId() As String
        Get
            Return campoId_
        End Get
        Set(ByVal value As String)
            campoId_ = value
        End Set
    End Property

    Private campoDesc_ As String
    Public Property zzCampoDesc() As String
        Get
            Return campoDesc_
        End Get
        Set(ByVal value As String)
            campoDesc_ = value
        End Set
    End Property


    Private tabla_ As String
    Public Property zzTabla() As String
        Get
            Return tabla_
        End Get
        Set(ByVal value As String)
            tabla_ = value
        End Set
    End Property

#End Region
#Region "Eventos"

    Private Sub txtId_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtId.GotFocus
        BackColor = Drawing.Color.Yellow
    End Sub
    Private Sub txtId_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtId.Leave
        BackColor = Drawing.Color.White
        txtBuscar_LostFocus(Nothing, Nothing)
    End Sub

#End Region
#Region "Metodos"
    Private Function existeId(ByVal strId As String) As DataTable
        Try

            Dim query As New AccDatos.OLEDBCON
            Dim dt As New DataTable
            If zzIdIsNumber Then
                dt = query.LanzarConsultaT("Select " & zzCampoDesc & ", " & zzCampoId & " from " & zzTabla & " where " & zzCampoId & " = " & txtId.Text)
            Else
                dt = query.LanzarConsultaT("Select " & zzCampoDesc & ", " & zzCampoId & " from " & zzTabla & " where " & zzCampoId & " = '" & txtId.Text & "'")
            End If
            If dt.Rows.Count <= 0 Then
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            Return Nothing
        End Try
    End Function
#End Region



    Private Sub txtBuscar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        If Not txtId.Text Is Nothing AndAlso Not txtId.Text.Trim = "" Then
            Dim dt As New DataTable
            If zzIdIsNumber Then
                If IsNumeric(txtId) Then
                    dt = existeId(txtId.Text)
                Else
                    txtId.Text = ""
                    txtDesc.Text = ""

                End If
            Else
                dt = existeId(txtId.Text)
            End If
        Else
            txtId.Text = ""
            txtDesc.Text = ""
        End If
    End Sub
  
End Class
