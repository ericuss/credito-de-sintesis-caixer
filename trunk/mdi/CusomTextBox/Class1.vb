''' <summary>
''' Componente que permite bindear texto el  contenido de una celda de una dataGridView con el texto del componente
''' </summary>
Public Class CustomTextBox
	Inherits System.Windows.Forms.TextBox
	
	#Region "Variables Privadas"
	
	Private _campBD As String
	Private _nomTaula As String
	Private _tipoDato As eTipoDato
	Private _isID As Boolean
	Private _dll As String
	Private _Form As String
	
	Public Enum eTipoDato
		Numerico
		Caracter
		Fecha
	End Enum
	
	
	#End Region
	
	#Region "Propiedades"
	
	''' <summary>
	''' Propiedad que indica la tabla a la cual hace referencia
	''' </summary>
	Public Property NomTaula() As String
		Get
			Return _nomTaula
		End Get
		Set(ByVal value As String)
			_nomTaula = value
		End Set
	End Property
	
	''' <summary>
	''' Propiedad que indica el nombre del Formulario a Abrir 
	''' </summary>
	''' <remarks>Sin Implementar</remarks>
	Public Property Form() As String
		Get
			Return _Form
		End Get
		Set(ByVal value As String)
			_Form = value
		End Set
	End Property
	
	''' <summary>
	''' Propiedad que indica el nombre de la Dll donde Buscar el Formulario
	''' </summary>
	''' <remarks>Sin Implementar</remarks>
	Public Property Dll() As String
		Get
			Return _dll
		End Get
		Set(ByVal value As String)
			_dll = value
		End Set
	End Property
	
	''' <summary>
	''' Propiedad para indicar si el campo al que hace referencia es Identificador
	''' </summary>
	Public Property isID() As String
		Get
			Return _isID
		End Get
		Set(ByVal value As String)
			_isID = value
		End Set
	End Property
	
	
	''' <summary>
	''' Propiedad que indica el nombre del campo al que hace referencia 
	''' </summary>
	Public Property CAMPDB() As String
		Get
			Return _campBD
		End Get
		Set(ByVal value As String)
			_campBD = value
		End Set
	End Property
	
	''' <summary>
	''' propiedad que indica que tipo de dato contiene
	''' </summary>
	Public Property TipoDato() As eTipoDato
		Get
			Return _tipoDato
		End Get
		Set(ByVal value As eTipoDato)
			_tipoDato = value
		End Set
	End Property
	
	#End Region
	
	#Region "Eventos"
	
	''' <summary>
	''' Evento que se ejecuta al obtener el foco.
	''' Cambia el color de fondo del componente a "Aqua"
	''' </summary>
	''' <param name="e">Parametro del Evento</param>
	Protected Overrides Sub OnGotFocus(e As System.EventArgs)
		Me.BackColor = Drawing.Color.Aqua
		Me.SelectAll()
	End Sub
	
	''' <summary>
	''' Evento que se ejecuta al perder el foco.
	''' Cambia el color de fondo del componente a "Blanco"
	''' </summary>
	''' <param name="e">Parametro del evento</param>
	Protected Overrides Sub OnLostFocus(e As System.EventArgs)
		Me.BackColor = Drawing.Color.White
	End Sub
	
	''' <summary>
	''' Evento que se ejecuta al abandonar el foco
	''' Comprueba que el tipo de dato sea el correcto
	''' </summary>
	''' <param name="e">Parametro del evento</param>
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
	#End Region
End Class
