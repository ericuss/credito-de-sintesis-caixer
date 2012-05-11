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
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.gbResultado = New System.Windows.Forms.GroupBox()
        Me.gbFiltro = New System.Windows.Forms.GroupBox()
        Me.btnPdf = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbResultado.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(3, 16)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(644, 329)
        Me.dgv.TabIndex = 1
        '
        'txtSalir
        '
        Me.txtSalir.Location = New System.Drawing.Point(388, 78)
        Me.txtSalir.Name = "txtSalir"
        Me.txtSalir.Size = New System.Drawing.Size(112, 23)
        Me.txtSalir.TabIndex = 2
        Me.txtSalir.Text = "Salir"
        Me.txtSalir.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(553, 78)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(112, 23)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Aceptar"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnTodos
        '
        Me.btnTodos.Location = New System.Drawing.Point(40, 78)
        Me.btnTodos.Name = "btnTodos"
        Me.btnTodos.Size = New System.Drawing.Size(119, 23)
        Me.btnTodos.TabIndex = 4
        Me.btnTodos.Text = "Obtener Todos"
        Me.btnTodos.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(186, 78)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(119, 23)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'gbResultado
        '
        Me.gbResultado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbResultado.Controls.Add(Me.dgv)
        Me.gbResultado.Location = New System.Drawing.Point(12, 107)
        Me.gbResultado.Name = "gbResultado"
        Me.gbResultado.Size = New System.Drawing.Size(650, 348)
        Me.gbResultado.TabIndex = 6
        Me.gbResultado.TabStop = False
        Me.gbResultado.Text = "Resultado"
        '
        'gbFiltro
        '
        Me.gbFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbFiltro.Location = New System.Drawing.Point(15, 12)
        Me.gbFiltro.Name = "gbFiltro"
        Me.gbFiltro.Size = New System.Drawing.Size(623, 60)
        Me.gbFiltro.TabIndex = 7
        Me.gbFiltro.TabStop = False
        Me.gbFiltro.Text = "Filtros"
        '
        'btnPdf
        '
        Me.btnPdf.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPdf.Image = Global.Base.My.Resources.Resources.pdf
        Me.btnPdf.Location = New System.Drawing.Point(7, 78)
        Me.btnPdf.Name = "btnPdf"
        Me.btnPdf.Size = New System.Drawing.Size(27, 37)
        Me.btnPdf.TabIndex = 15
        Me.btnPdf.UseVisualStyleBackColor = True
        '
        'Base
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(674, 467)
        Me.Controls.Add(Me.btnPdf)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.gbFiltro)
        Me.Controls.Add(Me.txtSalir)
        Me.Controls.Add(Me.gbResultado)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnTodos)
        Me.Name = "Base"
        Me.Text = "Form1"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbResultado.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents dgv As System.Windows.Forms.DataGridView
    Public WithEvents txtSalir As System.Windows.Forms.Button
    Public WithEvents btnUpdate As System.Windows.Forms.Button
    Public WithEvents btnTodos As System.Windows.Forms.Button
    Public WithEvents btnLimpiar As System.Windows.Forms.Button
    Public WithEvents gbResultado As System.Windows.Forms.GroupBox
    Public WithEvents gbFiltro As System.Windows.Forms.GroupBox
    Public WithEvents btnPdf As System.Windows.Forms.Button

End Class
