<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txbUsuario = New System.Windows.Forms.TextBox()
        Me.txtContra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.lklRegistro = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'btnConectar
        '
        Me.btnConectar.BackColor = System.Drawing.Color.Gold
        Me.btnConectar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConectar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnConectar.FlatAppearance.BorderSize = 0
        Me.btnConectar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnConectar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConectar.ForeColor = System.Drawing.Color.Black
        Me.btnConectar.Location = New System.Drawing.Point(196, 216)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(75, 23)
        Me.btnConectar.TabIndex = 0
        Me.btnConectar.Text = "Conectar"
        Me.btnConectar.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Gold
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.ForeColor = System.Drawing.Color.Black
        Me.btnLogin.Location = New System.Drawing.Point(99, 164)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Usuario"
        '
        'txbUsuario
        '
        Me.txbUsuario.Location = New System.Drawing.Point(83, 42)
        Me.txbUsuario.Name = "txbUsuario"
        Me.txbUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txbUsuario.TabIndex = 3
        '
        'txtContra
        '
        Me.txtContra.Location = New System.Drawing.Point(83, 82)
        Me.txtContra.Name = "txtContra"
        Me.txtContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContra.Size = New System.Drawing.Size(100, 20)
        Me.txtContra.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(100, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(96, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tipo de Usuario"
        '
        'cmbTipoUsuario
        '
        Me.cmbTipoUsuario.FormattingEnabled = True
        Me.cmbTipoUsuario.Items.AddRange(New Object() {"Administrador", "Cliente"})
        Me.cmbTipoUsuario.Location = New System.Drawing.Point(83, 128)
        Me.cmbTipoUsuario.Name = "cmbTipoUsuario"
        Me.cmbTipoUsuario.Size = New System.Drawing.Size(100, 21)
        Me.cmbTipoUsuario.TabIndex = 7
        '
        'lklRegistro
        '
        Me.lklRegistro.AutoSize = True
        Me.lklRegistro.LinkColor = System.Drawing.Color.SaddleBrown
        Me.lklRegistro.Location = New System.Drawing.Point(109, 190)
        Me.lklRegistro.Name = "lklRegistro"
        Me.lklRegistro.Size = New System.Drawing.Size(60, 13)
        Me.lklRegistro.TabIndex = 8
        Me.lklRegistro.TabStop = True
        Me.lklRegistro.Text = "Registrarse"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(278, 244)
        Me.Controls.Add(Me.lklRegistro)
        Me.Controls.Add(Me.cmbTipoUsuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtContra)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txbUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnConectar)
        Me.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Name = "frmLogin"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConectar As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txbUsuario As TextBox
    Friend WithEvents txtContra As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbTipoUsuario As ComboBox
    Friend WithEvents lklRegistro As LinkLabel
End Class
