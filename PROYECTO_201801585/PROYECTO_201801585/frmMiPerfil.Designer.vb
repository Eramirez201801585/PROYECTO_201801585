<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMiPerfil
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMiPerfilActualizar = New System.Windows.Forms.Button()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblBienvenida = New System.Windows.Forms.Label()
        Me.btnEliminarMiPerfil = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nacimiento"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(96, 117)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Usuario"
        '
        'btnMiPerfilActualizar
        '
        Me.btnMiPerfilActualizar.BackColor = System.Drawing.Color.Gold
        Me.btnMiPerfilActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMiPerfilActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnMiPerfilActualizar.FlatAppearance.BorderSize = 0
        Me.btnMiPerfilActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnMiPerfilActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.btnMiPerfilActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMiPerfilActualizar.ForeColor = System.Drawing.Color.Black
        Me.btnMiPerfilActualizar.Location = New System.Drawing.Point(84, 170)
        Me.btnMiPerfilActualizar.Name = "btnMiPerfilActualizar"
        Me.btnMiPerfilActualizar.Size = New System.Drawing.Size(112, 23)
        Me.btnMiPerfilActualizar.TabIndex = 9
        Me.btnMiPerfilActualizar.Text = "Actualizar Datos"
        Me.btnMiPerfilActualizar.UseVisualStyleBackColor = False
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(96, 91)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Apellido"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(96, 65)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Nombre"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(96, 144)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 21
        '
        'lblBienvenida
        '
        Me.lblBienvenida.AutoSize = True
        Me.lblBienvenida.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenida.Location = New System.Drawing.Point(106, 20)
        Me.lblBienvenida.Name = "lblBienvenida"
        Me.lblBienvenida.Size = New System.Drawing.Size(76, 31)
        Me.lblBienvenida.TabIndex = 22
        Me.lblBienvenida.Text = "Perfil"
        '
        'btnEliminarMiPerfil
        '
        Me.btnEliminarMiPerfil.BackColor = System.Drawing.Color.Gold
        Me.btnEliminarMiPerfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarMiPerfil.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnEliminarMiPerfil.FlatAppearance.BorderSize = 0
        Me.btnEliminarMiPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnEliminarMiPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.btnEliminarMiPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarMiPerfil.ForeColor = System.Drawing.Color.Black
        Me.btnEliminarMiPerfil.Location = New System.Drawing.Point(84, 213)
        Me.btnEliminarMiPerfil.Name = "btnEliminarMiPerfil"
        Me.btnEliminarMiPerfil.Size = New System.Drawing.Size(112, 23)
        Me.btnEliminarMiPerfil.TabIndex = 23
        Me.btnEliminarMiPerfil.Text = "Eliminar Cuenta"
        Me.btnEliminarMiPerfil.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.Gold
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.ForeColor = System.Drawing.Color.Black
        Me.btnMenu.Location = New System.Drawing.Point(239, 30)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(112, 23)
        Me.btnMenu.TabIndex = 24
        Me.btnMenu.Text = "Regresar a Menú"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'frmMiPerfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(366, 284)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnEliminarMiPerfil)
        Me.Controls.Add(Me.lblBienvenida)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMiPerfilActualizar)
        Me.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Name = "frmMiPerfil"
        Me.Text = "Mi Perfil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMiPerfilActualizar As Button
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblBienvenida As Label
    Friend WithEvents btnEliminarMiPerfil As Button
    Friend WithEvents btnMenu As Button
End Class
