<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportes
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
        Me.dgvGesLibro = New System.Windows.Forms.DataGridView()
        Me.cNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTipoUsr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cContra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReporteBackMenu = New System.Windows.Forms.Button()
        CType(Me.dgvGesLibro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvGesLibro
        '
        Me.dgvGesLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGesLibro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cNombre, Me.cApellido, Me.cUsuario, Me.cTipoUsr, Me.cNacimiento, Me.cContra})
        Me.dgvGesLibro.Location = New System.Drawing.Point(31, 97)
        Me.dgvGesLibro.Name = "dgvGesLibro"
        Me.dgvGesLibro.Size = New System.Drawing.Size(734, 150)
        Me.dgvGesLibro.TabIndex = 6
        '
        'cNombre
        '
        Me.cNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cNombre.HeaderText = "Nombre"
        Me.cNombre.Name = "cNombre"
        '
        'cApellido
        '
        Me.cApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cApellido.HeaderText = "Apellido"
        Me.cApellido.Name = "cApellido"
        '
        'cUsuario
        '
        Me.cUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cUsuario.HeaderText = "Usuario"
        Me.cUsuario.Name = "cUsuario"
        '
        'cTipoUsr
        '
        Me.cTipoUsr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cTipoUsr.HeaderText = "Tipo Usuario"
        Me.cTipoUsr.Name = "cTipoUsr"
        '
        'cNacimiento
        '
        Me.cNacimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cNacimiento.HeaderText = "Nacimiento"
        Me.cNacimiento.Name = "cNacimiento"
        '
        'cContra
        '
        Me.cContra.HeaderText = "Contraseña"
        Me.cContra.Name = "cContra"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Reporte de Ususarios"
        '
        'btnReporteBackMenu
        '
        Me.btnReporteBackMenu.BackColor = System.Drawing.Color.Gold
        Me.btnReporteBackMenu.FlatAppearance.BorderSize = 0
        Me.btnReporteBackMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnReporteBackMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.btnReporteBackMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporteBackMenu.ForeColor = System.Drawing.Color.Black
        Me.btnReporteBackMenu.Location = New System.Drawing.Point(634, 36)
        Me.btnReporteBackMenu.Name = "btnReporteBackMenu"
        Me.btnReporteBackMenu.Size = New System.Drawing.Size(105, 23)
        Me.btnReporteBackMenu.TabIndex = 10
        Me.btnReporteBackMenu.Text = "Regresar a Menú"
        Me.btnReporteBackMenu.UseVisualStyleBackColor = False
        '
        'frmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnReporteBackMenu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvGesLibro)
        Me.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Name = "frmReportes"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReportes"
        CType(Me.dgvGesLibro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvGesLibro As DataGridView
    Friend WithEvents cNombre As DataGridViewTextBoxColumn
    Friend WithEvents cApellido As DataGridViewTextBoxColumn
    Friend WithEvents cUsuario As DataGridViewTextBoxColumn
    Friend WithEvents cTipoUsr As DataGridViewTextBoxColumn
    Friend WithEvents cNacimiento As DataGridViewTextBoxColumn
    Friend WithEvents cContra As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReporteBackMenu As Button
End Class
