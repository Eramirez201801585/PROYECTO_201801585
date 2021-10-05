<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGesLibros
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnGesLibroEliminar = New System.Windows.Forms.Button()
        Me.btnGesLibroModificar = New System.Windows.Forms.Button()
        Me.btnGesLibroAgregar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtGesLibroDirec = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGesLibroNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblGesLibro = New System.Windows.Forms.Label()
        Me.dgvGesLibro = New System.Windows.Forms.DataGridView()
        Me.txtGestLibroGenero = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbGesLibroEditorial = New System.Windows.Forms.ComboBox()
        Me.cTitulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cAutor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cGenero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cEditorial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
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
        Me.btnGesLibroBackMenu.Location = New System.Drawing.Point(540, 88)
        Me.btnGesLibroBackMenu.Name = "btnGesLibroBackMenu"
        Me.btnGesLibroBackMenu.Size = New System.Drawing.Size(105, 23)
        Me.btnGesLibroBackMenu.TabIndex = 9
        Me.btnGesLibroBackMenu.Text = "Regresar a Menú"
        Me.btnGesLibroBackMenu.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnGesLibroEliminar)
        Me.GroupBox2.Controls.Add(Me.btnGesLibroModificar)
        Me.GroupBox2.Controls.Add(Me.btnGesLibroAgregar)
        Me.GroupBox2.Location = New System.Drawing.Point(137, 246)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(527, 60)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gestiones"
        '
        'btnGesLibroEliminar
        '
        Me.btnGesLibroEliminar.BackColor = System.Drawing.Color.Gold
        Me.btnGesLibroEliminar.FlatAppearance.BorderSize = 0
        Me.btnGesLibroEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnGesLibroEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.btnGesLibroEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGesLibroEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnGesLibroEliminar.Location = New System.Drawing.Point(382, 19)
        Me.btnGesLibroEliminar.Name = "btnGesLibroEliminar"
        Me.btnGesLibroEliminar.Size = New System.Drawing.Size(109, 23)
        Me.btnGesLibroEliminar.TabIndex = 2
        Me.btnGesLibroEliminar.Text = "Eliminar"
        Me.btnGesLibroEliminar.UseVisualStyleBackColor = False
        '
        'btnGesLibroModificar
        '
        Me.btnGesLibroModificar.BackColor = System.Drawing.Color.Gold
        Me.btnGesLibroModificar.FlatAppearance.BorderSize = 0
        Me.btnGesLibroModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnGesLibroModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.btnGesLibroModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGesLibroModificar.ForeColor = System.Drawing.Color.Black
        Me.btnGesLibroModificar.Location = New System.Drawing.Point(211, 19)
        Me.btnGesLibroModificar.Name = "btnGesLibroModificar"
        Me.btnGesLibroModificar.Size = New System.Drawing.Size(108, 23)
        Me.btnGesLibroModificar.TabIndex = 1
        Me.btnGesLibroModificar.Text = "Modificar"
        Me.btnGesLibroModificar.UseVisualStyleBackColor = False
        '
        'btnGesLibroAgregar
        '
        Me.btnGesLibroAgregar.BackColor = System.Drawing.Color.Gold
        Me.btnGesLibroAgregar.FlatAppearance.BorderSize = 0
        Me.btnGesLibroAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnGesLibroAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.btnGesLibroAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGesLibroAgregar.ForeColor = System.Drawing.Color.Black
        Me.btnGesLibroAgregar.Location = New System.Drawing.Point(18, 19)
        Me.btnGesLibroAgregar.Name = "btnGesLibroAgregar"
        Me.btnGesLibroAgregar.Size = New System.Drawing.Size(108, 23)
        Me.btnGesLibroAgregar.TabIndex = 0
        Me.btnGesLibroAgregar.Text = "Agregar"
        Me.btnGesLibroAgregar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbGesLibroEditorial)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtGestLibroGenero)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtGesLibroDirec)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtGesLibroNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(137, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 167)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la Editorial"
        '
        'txtGesLibroDirec
        '
        Me.txtGesLibroDirec.Location = New System.Drawing.Point(65, 56)
        Me.txtGesLibroDirec.Name = "txtGesLibroDirec"
        Me.txtGesLibroDirec.Size = New System.Drawing.Size(278, 20)
        Me.txtGesLibroDirec.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Autor"
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
        Me.lblGesLibro.Location = New System.Drawing.Point(142, 40)
        Me.lblGesLibro.Name = "lblGesLibro"
        Me.lblGesLibro.Size = New System.Drawing.Size(220, 29)
        Me.lblGesLibro.TabIndex = 6
        Me.lblGesLibro.Text = "Gestiona los Libros"
        '
        'dgvGesLibro
        '
        Me.dgvGesLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGesLibro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cTitulo, Me.cAutor, Me.cGenero, Me.cCantidad, Me.cEditorial})
        Me.dgvGesLibro.Location = New System.Drawing.Point(32, 328)
        Me.dgvGesLibro.Name = "dgvGesLibro"
        Me.dgvGesLibro.Size = New System.Drawing.Size(734, 150)
        Me.dgvGesLibro.TabIndex = 5
        '
        'txtGestLibroGenero
        '
        Me.txtGestLibroGenero.Location = New System.Drawing.Point(65, 94)
        Me.txtGestLibroGenero.Name = "txtGestLibroGenero"
        Me.txtGestLibroGenero.Size = New System.Drawing.Size(278, 20)
        Me.txtGestLibroGenero.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Género"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Editorial"
        '
        'cmbGesLibroEditorial
        '
        Me.cmbGesLibroEditorial.FormattingEnabled = True
        Me.cmbGesLibroEditorial.Location = New System.Drawing.Point(65, 135)
        Me.cmbGesLibroEditorial.Name = "cmbGesLibroEditorial"
        Me.cmbGesLibroEditorial.Size = New System.Drawing.Size(278, 21)
        Me.cmbGesLibroEditorial.TabIndex = 7
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
        'frmGesLibros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(800, 563)
        Me.Controls.Add(Me.btnGesLibroBackMenu)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblGesLibro)
        Me.Controls.Add(Me.dgvGesLibro)
        Me.Name = "frmGesLibros"
        Me.Text = "frmGesLibros"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvGesLibro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGesLibroBackMenu As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnGesLibroEliminar As Button
    Friend WithEvents btnGesLibroModificar As Button
    Friend WithEvents btnGesLibroAgregar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtGesLibroDirec As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGesLibroNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblGesLibro As Label
    Friend WithEvents dgvGesLibro As DataGridView
    Friend WithEvents cmbGesLibroEditorial As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtGestLibroGenero As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cTitulo As DataGridViewTextBoxColumn
    Friend WithEvents cAutor As DataGridViewTextBoxColumn
    Friend WithEvents cGenero As DataGridViewTextBoxColumn
    Friend WithEvents cCantidad As DataGridViewTextBoxColumn
    Friend WithEvents cEditorial As DataGridViewTextBoxColumn
End Class
