<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Base
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.txtSalir = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnTodos = New System.Windows.Forms.Button()
        Me.txtC = New CusomTextBox.CustomTextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 107)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(467, 219)
        Me.dgv.TabIndex = 1
        '
        'txtSalir
        '
        Me.txtSalir.Location = New System.Drawing.Point(404, 78)
        Me.txtSalir.Name = "txtSalir"
        Me.txtSalir.Size = New System.Drawing.Size(75, 23)
        Me.txtSalir.TabIndex = 2
        Me.txtSalir.Text = "Salir"
        Me.txtSalir.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(323, 78)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Aceptar"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnTodos
        '
        Me.btnTodos.Location = New System.Drawing.Point(360, 10)
        Me.btnTodos.Name = "btnTodos"
        Me.btnTodos.Size = New System.Drawing.Size(119, 23)
        Me.btnTodos.TabIndex = 4
        Me.btnTodos.Text = "Obtener Todos"
        Me.btnTodos.UseVisualStyleBackColor = True
        '
        'txtC
        '
        Me.txtC.CAMPDB = "nombre"
        Me.txtC.Dll = Nothing
        Me.txtC.Form = Nothing
        Me.txtC.isID = "True"
        Me.txtC.Location = New System.Drawing.Point(12, 12)
        Me.txtC.Name = "txtC"
        Me.txtC.NomTaula = ""
        Me.txtC.Size = New System.Drawing.Size(161, 20)
        Me.txtC.TabIndex = 0
        Me.txtC.Tag = "CustomTXT"
        Me.txtC.TipoDato = CusomTextBox.CustomTextBox.eTipoDato.Caracter
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(360, 39)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(119, 23)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Base
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 338)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnTodos)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtSalir)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.txtC)
        Me.Name = "Base"
        Me.Text = "Form1"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected Friend WithEvents txtC As CusomTextBox.CustomTextBox
    Protected Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents txtSalir As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnTodos As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button

End Class
