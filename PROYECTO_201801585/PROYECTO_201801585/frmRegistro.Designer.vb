<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegistro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.lblBienvenida = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRegistrarCuenta = New System.Windows.Forms.Button()
        Me.txtContraseñaRegistro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
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
        Me.btnMenu.Location = New System.Drawing.Point(236, 32)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(112, 23)
        Me.btnMenu.TabIndex = 36
        Me.btnMenu.Text = "Regresar a Menú"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'lblBienvenida
        '
        Me.lblBienvenida.AutoSize = True
        Me.lblBienvenida.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenida.Location = New System.Drawing.Point(91, 32)
        Me.lblBienvenida.Name = "lblBienvenida"
        Me.lblBienvenida.Size = New System.Drawing.Size(116, 31)
        Me.lblBienvenida.TabIndex = 34
        Me.lblBienvenida.Text = "Registro"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(97, 156)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 33
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(97, 103)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Apellido"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(97, 77)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Nacimiento"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(97, 129)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Usuario"
        '
        'btnRegistrarCuenta
        '
        Me.btnRegistrarCuenta.BackColor = System.Drawing.Color.Gold
        Me.btnRegistrarCuenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrarCuenta.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnRegistrarCuenta.FlatAppearance.BorderSize = 0
        Me.btnRegistrarCuenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnRegistrarCuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.btnRegistrarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarCuenta.ForeColor = System.Drawing.Color.Black
        Me.btnRegistrarCuenta.Location = New System.Drawing.Point(85, 234)
        Me.btnRegistrarCuenta.Name = "btnRegistrarCuenta"
        Me.btnRegistrarCuenta.Size = New System.Drawing.Size(112, 23)
        Me.btnRegistrarCuenta.TabIndex = 25
        Me.btnRegistrarCuenta.Text = "Registrar Cuenta"
        Me.btnRegistrarCuenta.UseVisualStyleBackColor = False
        '
        'txtContraseñaRegistro
        '
        Me.txtContraseñaRegistro.Location = New System.Drawing.Point(97, 182)
        Me.txtContraseñaRegistro.Name = "txtContraseñaRegistro"
        Me.txtContraseñaRegistro.Size = New System.Drawing.Size(100, 20)
        Me.txtContraseñaRegistro.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Contraseña"
        '
        'frmRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(360, 314)
        Me.Controls.Add(Me.txtContraseñaRegistro)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.lblBienvenida)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRegistrarCuenta)
        Me.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Name = "frmRegistro"
        Me.Text = "Registro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMenu As Button
    Friend WithEvents lblBienvenida As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRegistrarCuenta As Button
    Friend WithEvents txtContraseñaRegistro As TextBox
    Friend WithEvents Label3 As Label
End Class
