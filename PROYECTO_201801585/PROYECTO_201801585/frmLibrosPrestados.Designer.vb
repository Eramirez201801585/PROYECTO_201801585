<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLibrosPrestados
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
        Me.btnLibroPrestadoDevolver = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvGesLibro = New System.Windows.Forms.DataGridView()
        Me.cTitulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cAutor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cGenero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvGesLibro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLibroPrestadoDevolver
        '
        Me.btnLibroPrestadoDevolver.BackColor = System.Drawing.Color.Gold
        Me.btnLibroPrestadoDevolver.FlatAppearance.BorderSize = 0
        Me.btnLibroPrestadoDevolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnLibroPrestadoDevolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.btnLibroPrestadoDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLibroPrestadoDevolver.ForeColor = System.Drawing.Color.Black
        Me.btnLibroPrestadoDevolver.Location = New System.Drawing.Point(341, 325)
        Me.btnLibroPrestadoDevolver.Name = "btnLibroPrestadoDevolver"
        Me.btnLibroPrestadoDevolver.Size = New System.Drawing.Size(105, 23)
        Me.btnLibroPrestadoDevolver.TabIndex = 13
        Me.btnLibroPrestadoDevolver.Text = "Devolver Libro"
        Me.btnLibroPrestadoDevolver.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 24)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Reporte de Ususarios"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(663, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Regresar a Menú"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dgvGesLibro
        '
        Me.dgvGesLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGesLibro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cTitulo, Me.cAutor, Me.cGenero})
        Me.dgvGesLibro.Location = New System.Drawing.Point(34, 85)
        Me.dgvGesLibro.Name = "dgvGesLibro"
        Me.dgvGesLibro.Size = New System.Drawing.Size(734, 179)
        Me.dgvGesLibro.TabIndex = 15
        '
        'cTitulo
        '
        Me.cTitulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cTitulo.HeaderText = "Título"
        Me.cTitulo.Name = "cTitulo"
        '
        'cAutor
        '
        Me.cAutor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cAutor.HeaderText = "Autor"
        Me.cAutor.Name = "cAutor"
        '
        'cGenero
        '
        Me.cGenero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cGenero.HeaderText = "Género"
        Me.cGenero.Name = "cGenero"
        '
        'frmLibrosPrestados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvGesLibro)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnLibroPrestadoDevolver)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Name = "frmLibrosPrestados"
        Me.Text = "frmLibrosPrestados"
        CType(Me.dgvGesLibro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLibroPrestadoDevolver As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvGesLibro As DataGridView
    Friend WithEvents cTitulo As DataGridViewTextBoxColumn
    Friend WithEvents cAutor As DataGridViewTextBoxColumn
    Friend WithEvents cGenero As DataGridViewTextBoxColumn
End Class
