<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrestarLibro
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
        Me.btnGesLibroBackMenu = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPrestarBuscar = New System.Windows.Forms.Button()
        Me.txtGestLibroGenero = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGesLibroNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblGesLibro = New System.Windows.Forms.Label()
        Me.dgvGesLibro = New System.Windows.Forms.DataGridView()
        Me.cTitulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cAutor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cGenero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cEditorial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPrestar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvGesLibro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGesLibroBackMenu
        '
        Me.btnGesLibroBackMenu.BackColor = System.Drawing.Color.Gold
        Me.btnGesLibroBackMenu.FlatAppearance.BorderSize = 0
        Me.btnGesLibroBackMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnGesLibroBackMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.btnGesLibroBackMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGesLibroBackMenu.ForeColor = System.Drawing.Color.Black
        Me.btnGesLibroBackMenu.Location = New System.Drawing.Point(541, 54)
        Me.btnGesLibroBackMenu.Name = "btnGesLibroBackMenu"
        Me.btnGesLibroBackMenu.Size = New System.Drawing.Size(105, 23)
        Me.btnGesLibroBackMenu.TabIndex = 14
        Me.btnGesLibroBackMenu.Text = "Regresar a Menú"
        Me.btnGesLibroBackMenu.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPrestarBuscar)
        Me.GroupBox1.Controls.Add(Me.txtGestLibroGenero)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtGesLibroNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(138, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 116)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la Editorial"
        '
        'btnPrestarBuscar
        '
        Me.btnPrestarBuscar.BackColor = System.Drawing.Color.Gold
        Me.btnPrestarBuscar.FlatAppearance.BorderSize = 0
        Me.btnPrestarBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnPrestarBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.btnPrestarBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrestarBuscar.ForeColor = System.Drawing.Color.Black
        Me.btnPrestarBuscar.Location = New System.Drawing.Point(127, 84)
        Me.btnPrestarBuscar.Name = "btnPrestarBuscar"
        Me.btnPrestarBuscar.Size = New System.Drawing.Size(108, 23)
        Me.btnPrestarBuscar.TabIndex = 6
        Me.btnPrestarBuscar.Text = "Buscar"
        Me.btnPrestarBuscar.UseVisualStyleBackColor = False
        '
        'txtGestLibroGenero
        '
        Me.txtGestLibroGenero.Location = New System.Drawing.Point(65, 58)
        Me.txtGestLibroGenero.Name = "txtGestLibroGenero"
        Me.txtGestLibroGenero.Size = New System.Drawing.Size(278, 20)
        Me.txtGestLibroGenero.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Género"
        '
        'txtGesLibroNombre
        '
        Me.txtGesLibroNombre.Location = New System.Drawing.Point(65, 20)
        Me.txtGesLibroNombre.Name = "txtGesLibroNombre"
        Me.txtGesLibroNombre.Size = New System.Drawing.Size(279, 20)
        Me.txtGesLibroNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Título"
        '
        'lblGesLibro
        '
        Me.lblGesLibro.AutoSize = True
        Me.lblGesLibro.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGesLibro.Location = New System.Drawing.Point(143, 6)
        Me.lblGesLibro.Name = "lblGesLibro"
        Me.lblGesLibro.Size = New System.Drawing.Size(220, 29)
        Me.lblGesLibro.TabIndex = 11
        Me.lblGesLibro.Text = "Gestiona los Libros"
        '
        'dgvGesLibro
        '
        Me.dgvGesLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGesLibro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cTitulo, Me.cAutor, Me.cGenero, Me.cCantidad, Me.cEditorial})
        Me.dgvGesLibro.Location = New System.Drawing.Point(35, 161)
        Me.dgvGesLibro.Name = "dgvGesLibro"
        Me.dgvGesLibro.Size = New System.Drawing.Size(734, 150)
        Me.dgvGesLibro.TabIndex = 10
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
        'cCantidad
        '
        Me.cCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cCantidad.HeaderText = "Cantidad"
        Me.cCantidad.Name = "cCantidad"
        '
        'cEditorial
        '
        Me.cEditorial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cEditorial.HeaderText = "Editorial"
        Me.cEditorial.Name = "cEditorial"
        '
        'btnPrestar
        '
        Me.btnPrestar.BackColor = System.Drawing.Color.Gold
        Me.btnPrestar.FlatAppearance.BorderSize = 0
        Me.btnPrestar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnPrestar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.btnPrestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrestar.ForeColor = System.Drawing.Color.Black
        Me.btnPrestar.Location = New System.Drawing.Point(343, 327)
        Me.btnPrestar.Name = "btnPrestar"
        Me.btnPrestar.Size = New System.Drawing.Size(108, 23)
        Me.btnPrestar.TabIndex = 7
        Me.btnPrestar.Text = "Prestar"
        Me.btnPrestar.UseVisualStyleBackColor = False
        '
        'frmPrestarLibro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnPrestar)
        Me.Controls.Add(Me.btnGesLibroBackMenu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblGesLibro)
        Me.Controls.Add(Me.dgvGesLibro)
        Me.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Name = "frmPrestarLibro"
        Me.Text = "frmPrestarLibro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvGesLibro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGesLibroBackMenu As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtGestLibroGenero As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGesLibroNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblGesLibro As Label
    Friend WithEvents dgvGesLibro As DataGridView
    Friend WithEvents btnPrestarBuscar As Button
    Friend WithEvents cTitulo As DataGridViewTextBoxColumn
    Friend WithEvents cAutor As DataGridViewTextBoxColumn
    Friend WithEvents cGenero As DataGridViewTextBoxColumn
    Friend WithEvents cCantidad As DataGridViewTextBoxColumn
    Friend WithEvents cEditorial As DataGridViewTextBoxColumn
    Friend WithEvents btnPrestar As Button
End Class
