<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBienvenidoCliente
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
        Me.lblBienvenida = New System.Windows.Forms.Label()
        Me.btnLibrosPrestados = New System.Windows.Forms.Button()
        Me.btnPrestarLibros = New System.Windows.Forms.Button()
        Me.btnEditarPerfil = New System.Windows.Forms.Button()
        Me.btnCerrarSesionCliente = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblBienvenida
        '
        Me.lblBienvenida.AutoSize = True
        Me.lblBienvenida.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenida.Location = New System.Drawing.Point(12, 25)
        Me.lblBienvenida.Name = "lblBienvenida"
        Me.lblBienvenida.Size = New System.Drawing.Size(134, 29)
        Me.lblBienvenida.TabIndex = 0
        Me.lblBienvenida.Text = "Bienvenido"
        '
        'btnLibrosPrestados
        '
        Me.btnLibrosPrestados.BackColor = System.Drawing.Color.Gold
        Me.btnLibrosPrestados.FlatAppearance.BorderSize = 0
        Me.btnLibrosPrestados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnLibrosPrestados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.btnLibrosPrestados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLibrosPrestados.ForeColor = System.Drawing.Color.Black
        Me.btnLibrosPrestados.Location = New System.Drawing.Point(13, 83)
        Me.btnLibrosPrestados.Name = "btnLibrosPrestados"
        Me.btnLibrosPrestados.Size = New System.Drawing.Size(124, 23)
        Me.btnLibrosPrestados.TabIndex = 1
        Me.btnLibrosPrestados.Text = "Ver Libros Prestados"
        Me.btnLibrosPrestados.UseVisualStyleBackColor = False
        '
        'btnPrestarLibros
        '
        Me.btnPrestarLibros.BackColor = System.Drawing.Color.Gold
        Me.btnPrestarLibros.FlatAppearance.BorderSize = 0
        Me.btnPrestarLibros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnPrestarLibros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.btnPrestarLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrestarLibros.ForeColor = System.Drawing.Color.Black
        Me.btnPrestarLibros.Location = New System.Drawing.Point(143, 83)
        Me.btnPrestarLibros.Name = "btnPrestarLibros"
        Me.btnPrestarLibros.Size = New System.Drawing.Size(124, 23)
        Me.btnPrestarLibros.TabIndex = 2
        Me.btnPrestarLibros.Text = "Prestar Libros"
        Me.btnPrestarLibros.UseVisualStyleBackColor = False
        '
        'btnEditarPerfil
        '
        Me.btnEditarPerfil.BackColor = System.Drawing.Color.Gold
        Me.btnEditarPerfil.FlatAppearance.BorderSize = 0
        Me.btnEditarPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnEditarPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.btnEditarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarPerfil.ForeColor = System.Drawing.Color.Black
        Me.btnEditarPerfil.Location = New System.Drawing.Point(273, 83)
        Me.btnEditarPerfil.Name = "btnEditarPerfil"
        Me.btnEditarPerfil.Size = New System.Drawing.Size(124, 23)
        Me.btnEditarPerfil.TabIndex = 3
        Me.btnEditarPerfil.Text = "Editar Perfil"
        Me.btnEditarPerfil.UseVisualStyleBackColor = False
        '
        'btnCerrarSesionCliente
        '
        Me.btnCerrarSesionCliente.BackColor = System.Drawing.Color.Gold
        Me.btnCerrarSesionCliente.FlatAppearance.BorderSize = 0
        Me.btnCerrarSesionCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnCerrarSesionCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.btnCerrarSesionCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesionCliente.ForeColor = System.Drawing.Color.Black
        Me.btnCerrarSesionCliente.Location = New System.Drawing.Point(143, 130)
        Me.btnCerrarSesionCliente.Name = "btnCerrarSesionCliente"
        Me.btnCerrarSesionCliente.Size = New System.Drawing.Size(124, 23)
        Me.btnCerrarSesionCliente.TabIndex = 4
        Me.btnCerrarSesionCliente.Text = "Cerrar Sesión"
        Me.btnCerrarSesionCliente.UseVisualStyleBackColor = False
        '
        'frmBienvenidoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(407, 165)
        Me.Controls.Add(Me.btnCerrarSesionCliente)
        Me.Controls.Add(Me.btnEditarPerfil)
        Me.Controls.Add(Me.btnPrestarLibros)
        Me.Controls.Add(Me.btnLibrosPrestados)
        Me.Controls.Add(Me.lblBienvenida)
        Me.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Name = "frmBienvenidoCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenido"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBienvenida As Label
    Friend WithEvents btnLibrosPrestados As Button
    Friend WithEvents btnPrestarLibros As Button
    Friend WithEvents btnEditarPerfil As Button
    Friend WithEvents btnCerrarSesionCliente As Button
End Class
