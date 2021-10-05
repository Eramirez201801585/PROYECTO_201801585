<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGesEditoriales
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
        Me.dgvGesEditorial = New System.Windows.Forms.DataGridView()
        Me.cNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDireccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTelefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblGesEditoriales = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtGesEditorialDirec = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGesEditorialNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnGesEditorialEliminar = New System.Windows.Forms.Button()
        Me.btnGesEditorialModificar = New System.Windows.Forms.Button()
        Me.btnGesEditorialAgregar = New System.Windows.Forms.Button()
        Me.btnGesEditorialBackMenu = New System.Windows.Forms.Button()
        CType(Me.dgvGesEditorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvGesEditorial
        '
        Me.dgvGesEditorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGesEditorial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cNombre, Me.cDireccion, Me.cTelefono})
        Me.dgvGesEditorial.Location = New System.Drawing.Point(12, 243)
        Me.dgvGesEditorial.Name = "dgvGesEditorial"
        Me.dgvGesEditorial.Size = New System.Drawing.Size(528, 150)
        Me.dgvGesEditorial.TabIndex = 0
        '
        'cNombre
        '
        Me.cNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cNombre.HeaderText = "Nombre"
        Me.cNombre.Name = "cNombre"
        '
        'cDireccion
        '
        Me.cDireccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cDireccion.HeaderText = "Nombre"
        Me.cDireccion.Name = "cDireccion"
        '
        'cTelefono
        '
        Me.cTelefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cTelefono.HeaderText = "Telefono"
        Me.cTelefono.Name = "cTelefono"
        '
        'lblGesEditoriales
        '
        Me.lblGesEditoriales.AutoSize = True
        Me.lblGesEditoriales.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGesEditoriales.Location = New System.Drawing.Point(18, 22)
        Me.lblGesEditoriales.Name = "lblGesEditoriales"
        Me.lblGesEditoriales.Size = New System.Drawing.Size(267, 29)
        Me.lblGesEditoriales.TabIndex = 1
        Me.lblGesEditoriales.Text = "Gestiona las Editoriales"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtGesEditorialDirec)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtGesEditorialNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la Editorial"
        '
        'txtGesEditorialDirec
        '
        Me.txtGesEditorialDirec.Location = New System.Drawing.Point(65, 56)
        Me.txtGesEditorialDirec.Name = "txtGesEditorialDirec"
        Me.txtGesEditorialDirec.Size = New System.Drawing.Size(278, 20)
        Me.txtGesEditorialDirec.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dirección"
        '
        'txtGesEditorialNombre
        '
        Me.txtGesEditorialNombre.Location = New System.Drawing.Point(65, 20)
        Me.txtGesEditorialNombre.Name = "txtGesEditorialNombre"
        Me.txtGesEditorialNombre.Size = New System.Drawing.Size(279, 20)
        Me.txtGesEditorialNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnGesEditorialEliminar)
        Me.GroupBox2.Controls.Add(Me.btnGesEditorialModificar)
        Me.GroupBox2.Controls.Add(Me.btnGesEditorialAgregar)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 161)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(527, 60)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gestiones"
        '
        'btnGesEditorialEliminar
        '
        Me.btnGesEditorialEliminar.BackColor = System.Drawing.Color.Gold
        Me.btnGesEditorialEliminar.FlatAppearance.BorderSize = 0
        Me.btnGesEditorialEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnGesEditorialEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.btnGesEditorialEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGesEditorialEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnGesEditorialEliminar.Location = New System.Drawing.Point(382, 19)
        Me.btnGesEditorialEliminar.Name = "btnGesEditorialEliminar"
        Me.btnGesEditorialEliminar.Size = New System.Drawing.Size(109, 23)
        Me.btnGesEditorialEliminar.TabIndex = 2
        Me.btnGesEditorialEliminar.Text = "Eliminar"
        Me.btnGesEditorialEliminar.UseVisualStyleBackColor = False
        '
        'btnGesEditorialModificar
        '
        Me.btnGesEditorialModificar.BackColor = System.Drawing.Color.Gold
        Me.btnGesEditorialModificar.FlatAppearance.BorderSize = 0
        Me.btnGesEditorialModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnGesEditorialModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.btnGesEditorialModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGesEditorialModificar.ForeColor = System.Drawing.Color.Black
        Me.btnGesEditorialModificar.Location = New System.Drawing.Point(211, 19)
        Me.btnGesEditorialModificar.Name = "btnGesEditorialModificar"
        Me.btnGesEditorialModificar.Size = New System.Drawing.Size(108, 23)
        Me.btnGesEditorialModificar.TabIndex = 1
        Me.btnGesEditorialModificar.Text = "Modificar"
        Me.btnGesEditorialModificar.UseVisualStyleBackColor = False
        '
        'btnGesEditorialAgregar
        '
        Me.btnGesEditorialAgregar.BackColor = System.Drawing.Color.Gold
        Me.btnGesEditorialAgregar.FlatAppearance.BorderSize = 0
        Me.btnGesEditorialAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnGesEditorialAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.btnGesEditorialAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGesEditorialAgregar.ForeColor = System.Drawing.Color.Black
        Me.btnGesEditorialAgregar.Location = New System.Drawing.Point(18, 19)
        Me.btnGesEditorialAgregar.Name = "btnGesEditorialAgregar"
        Me.btnGesEditorialAgregar.Size = New System.Drawing.Size(108, 23)
        Me.btnGesEditorialAgregar.TabIndex = 0
        Me.btnGesEditorialAgregar.Text = "Agregar"
        Me.btnGesEditorialAgregar.UseVisualStyleBackColor = False
        '
        'btnGesEditorialBackMenu
        '
        Me.btnGesEditorialBackMenu.BackColor = System.Drawing.Color.Gold
        Me.btnGesEditorialBackMenu.FlatAppearance.BorderSize = 0
        Me.btnGesEditorialBackMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnGesEditorialBackMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.btnGesEditorialBackMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGesEditorialBackMenu.ForeColor = System.Drawing.Color.Black
        Me.btnGesEditorialBackMenu.Location = New System.Drawing.Point(416, 70)
        Me.btnGesEditorialBackMenu.Name = "btnGesEditorialBackMenu"
        Me.btnGesEditorialBackMenu.Size = New System.Drawing.Size(105, 23)
        Me.btnGesEditorialBackMenu.TabIndex = 4
        Me.btnGesEditorialBackMenu.Text = "Regresar a Menú"
        Me.btnGesEditorialBackMenu.UseVisualStyleBackColor = False
        '
        'frmGesEditoriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(558, 411)
        Me.Controls.Add(Me.btnGesEditorialBackMenu)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblGesEditoriales)
        Me.Controls.Add(Me.dgvGesEditorial)
        Me.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Name = "frmGesEditoriales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGesEditoriales"
        CType(Me.dgvGesEditorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvGesEditorial As DataGridView
    Friend WithEvents lblGesEditoriales As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtGesEditorialDirec As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGesEditorialNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnGesEditorialEliminar As Button
    Friend WithEvents btnGesEditorialModificar As Button
    Friend WithEvents btnGesEditorialAgregar As Button
    Friend WithEvents cNombre As DataGridViewTextBoxColumn
    Friend WithEvents cDireccion As DataGridViewTextBoxColumn
    Friend WithEvents cTelefono As DataGridViewTextBoxColumn
    Friend WithEvents btnGesEditorialBackMenu As Button
End Class
