Public Class CustomTextBox
    Inherits System.Windows.Forms.TextBox
    Private _campBD As String
    Private _nomTaula As String
    Private _tipoDato As eTipoDato
    Private _isID As Boolean
    Private _dll As String
    Private _Form As String


    Public Property NomTaula() As String
        Get
            Return _nomTaula
        End Get
        Set(ByVal value As String)
            _nomTaula = value
        End Set
    End Property


    Public Property Form() As String
        Get
            Return _Form
        End Get
        Set(ByVal value As String)
            _Form = value
        End Set
    End Property


    Public Property Dll() As String
        Get
            Return _dll
        End Get
        Set(ByVal value As String)
            _dll = value
        End Set
    End Property


    Public Property isID() As String
        Get
            Return _isID
        End Get
        Set(ByVal value As String)
            _isID = value
        End Set
    End Property

    Public Property CAMPDB() As String
        Get
            Return _campBD
        End Get
        Set(ByVal value As String)
            _campBD = value
        End Set
    End Property

 
    Public Enum eTipoDato
        Numerico
        Caracter
        Fecha
    End Enum


    Public Property TipoDato() As eTipoDato
        Get
            Return _tipoDato
        End Get
        Set(ByVal value As eTipoDato)
            _tipoDato = value
        End Set
    End Property


    Protected Overrides Sub OnGotFocus(e As System.EventArgs)
        Me.BackColor = Drawing.Color.Aqua
        Me.SelectAll()
    End Sub

    Protected Overrides Sub OnLostFocus(e As System.EventArgs)
        Me.BackColor = Drawing.Color.White
    End Sub

    Protected Overrides Sub OnValidating(e As System.ComponentModel.CancelEventArgs)
        Select Case (_tipoDato)
            Case eTipoDato.Caracter

            Case eTipoDato.Fecha
                If Not IsDate(Me.Text) Then
                    Me.BackColor = Drawing.Color.Red
                    ' e.Cancel = True
                End If
            Case eTipoDato.Numerico
                If Not IsNumeric(Me.Text) Then
                    Me.BackColor = Drawing.Color.Red
                    '  e.Cancel = True
                End If
        End Select
    End Sub

End Class
