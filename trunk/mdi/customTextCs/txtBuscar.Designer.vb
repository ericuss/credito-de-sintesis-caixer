<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class txtBuscar
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.lbEtiqueta = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(69, 7)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 0
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = Global.customTextCs.My.Resources.Resources.filefind
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBuscar.Location = New System.Drawing.Point(175, 0)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(32, 33)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtDesc
        '
        Me.txtDesc.Enabled = False
        Me.txtDesc.Location = New System.Drawing.Point(213, 7)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(191, 20)
        Me.txtDesc.TabIndex = 2
        '
        'lbEtiqueta
        '
        Me.lbEtiqueta.AutoSize = True
        Me.lbEtiqueta.Location = New System.Drawing.Point(3, 10)
        Me.lbEtiqueta.Name = "lbEtiqueta"
        Me.lbEtiqueta.Size = New System.Drawing.Size(42, 13)
        Me.lbEtiqueta.TabIndex = 3
        Me.lbEtiqueta.Text = "Cliente:"
        '
        'txtBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lbEtiqueta)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtId)
        Me.Name = "txtBuscar"
        Me.Size = New System.Drawing.Size(426, 35)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents lbEtiqueta As System.Windows.Forms.Label

End Class
