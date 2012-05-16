Imports txtCs
Imports System.Data
Imports System.Windows.Forms

Public Class txtBuscar
#Region "Propiedades"
    Private dt As New DataTable()

    Private idVisible_ As Boolean = False
    Public Property zzIdVisible() As Boolean
        Get
            Return idVisible_
        End Get
        Set(ByVal value As Boolean)
            idVisible_ = value
        End Set
    End Property

    Private widthId_ As String = 100
    Public Property zzWidthId() As String
        Get
            Return widthId_
        End Get
        Set(ByVal value As String)
            widthId_ = value
            txtId.Width = value
        End Set
    End Property
    Private widthDesc_ As String = 160
    Public Property zzWidthDesc() As String
        Get
            Return widthDesc_
        End Get
        Set(ByVal value As String)
            widthDesc_ = value
            txtDesc.Width = value
        End Set
    End Property

    Private idIsNumeric_ As Boolean = False
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
        txtid_LostFocus(Nothing, Nothing)
    End Sub

#End Region
#Region "Metodos"
    Private Function existeId(ByVal strId As String) As DataTable
        Try

            Dim query As New AccDatos.OLEDBCON
            Dim dt As New DataTable
            If zzIdIsNumber Then
                dt = query.LanzarConsultaT("Select " & zzCampoDesc & " from " & zzTabla & " where " & zzCampoId & " = " & txtId.Text)
            Else
                dt = query.LanzarConsultaT("Select " & zzCampoDesc & " from " & zzTabla & " where " & zzCampoId & " = '" & txtId.Text & "'")
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

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        txtId.Visible = True
        txtDesc.Visible = True
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub txtid_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtId.LostFocus
        If Not txtId.Text Is Nothing AndAlso Not txtId.Text.Trim = "" Then
            Dim dt As New DataTable
            If zzIdIsNumber Then
                If IsNumeric(txtId) Then
                    dt = existeId(txtId.Text)
                    If dt Is Nothing OrElse dt.Rows.Count <> 1 Then
                        txtId.Text = ""
                        txtDesc.Text = ""

                    Else
                        txtDesc.Text = ""
                        For Each item As String In dt.Rows(0).ItemArray
                            txtDesc.Text &= item & ""
                        Next

                    End If
                Else
                    txtId.Text = ""
                    txtDesc.Text = ""

                End If
            Else
                dt = existeId(txtId.Text)

                If dt Is Nothing OrElse dt.Rows.Count <> 1 Then
                    txtId.Text = ""
                    txtDesc.Text = ""
                Else
                    txtDesc.Text = ""
                    For Each item As String In dt.Rows(0).ItemArray
                        txtDesc.Text &= item & ""
                    Next

                End If

            End If
        Else
            txtId.Text = ""
            txtDesc.Text = ""
        End If
    End Sub

    Private Function obtenerDt() As DataTable
        Dim query As New AccDatos.OLEDBCON
        Return query.LanzarConsultaT("Select id, " & zzCampoId & ", " & zzCampoDesc & " from " & zzTabla)

    End Function
    Private Function obtenerRegistro(ByVal strid As String) As DataTable
        Dim query As New AccDatos.OLEDBCON
        Return query.LanzarConsultaT("Select " & zzCampoId & ", " & zzCampoDesc & " from " & zzTabla & " where id = " & strid)


    End Function
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        If Not dt Is Nothing Then

            If idVisible_ Then
                Dim frm As New txtCs.frmCs(obtenerDt, "")
                frm.ShowDialog()
                If frm.isAceptar Then
                    Dim dtFrm As DataTable
                    ''dr = frm.dr
                    dtFrm = obtenerRegistro(frm.id)
                    txtId.Text = ""
                    txtDesc.Text = ""
                    If dtFrm.Rows.Count = 1 Then
                        txtId.Text = dtFrm.Rows(0)(zzCampoId).ToString()
                        txtId.Text = dtFrm.Rows(0)(zzCampoId).ToString()
                        For Each strCampo As String In zzCampoDesc.Split(CChar(","))
                            txtDesc.Text &= dtFrm.Rows(0)(strCampo.Trim).ToString()
                        Next
                    End If
                   

                End If
            Else
                Dim frm As New txtCs.frmCs(obtenerDt, zzCampoId)
                frm.ShowDialog()
                If frm.isAceptar Then
                    Dim dtFrm As DataTable
                    ''dr = frm.dr
                    dtFrm = obtenerRegistro(frm.id)
                    txtId.Text = ""
                    txtDesc.Text = ""
                    If dtFrm.Rows.Count = 1 Then
                        txtId.Text = dtFrm.Rows(0)(zzCampoId).ToString()
                        txtId.Text = dtFrm.Rows(0)(zzCampoId).ToString()
                        For Each strCampo As String In zzCampoDesc.Split(CChar(","))
                            txtDesc.Text &= dtFrm.Rows(0)(strCampo.Trim).ToString()
                        Next
                    End If
                   

                End If
            End If

        End If


    End Sub
End Class
