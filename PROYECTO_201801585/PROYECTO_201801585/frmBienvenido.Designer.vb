<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBienvenidoAdmin
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
        Me.btnGesEditoriales = New System.Windows.Forms.Button()
        Me.btnGesLibros = New System.Windows.Forms.Button()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.btnCerrarSesionAdmin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblBienvenida
        '
        Me.lblBienvenida.AutoSize = True
        Me.lblBienvenida.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenida.Location = New System.Drawing.Point(12, 27)
        Me.lblBienvenida.Name = "lblBienvenida"
        Me.lblBienvenida.Size = New System.Drawing.Size(148, 31)
        Me.lblBienvenida.TabIndex = 0
        Me.lblBienvenida.Text = "Bienvenido"
        '
        'btnGesEditoriales
        '
        Me.btnGesEditoriales.BackColor = System.Drawing.Color.Gold
        Me.btnGesEditoriales.FlatAppearance.BorderSize = 0
        Me.btnGesEditoriales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnGesEditoriales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.btnGesEditoriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGesEditoriales.ForeColor = System.Drawing.Color.Black
        Me.btnGesEditoriales.Location = New System.Drawing.Point(12, 100)
        Me.btnGesEditoriales.Name = "btnGesEditoriales"
        Me.btnGesEditoriales.Size = New System.Drawing.Size(131, 23)
        Me.btnGesEditoriales.TabIndex = 1
        Me.btnGesEditoriales.Text = "Gestionar Editoriales"
        Me.btnGesEditoriales.UseVisualStyleBackColor = False
        '
        'btnGesLibros
        '
        Me.btnGesLibros.BackColor = System.Drawing.Color.Gold
        Me.btnGesLibros.FlatAppearance.BorderSize = 0
        Me.btnGesLibros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnGesLibros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.btnGesLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGesLibros.ForeColor = System.Drawing.Color.Black
        Me.btnGesLibros.Location = New System.Drawing.Point(149, 100)
        Me.btnGesLibros.Name = "btnGesLibros"
        Me.btnGesLibros.Size = New System.Drawing.Size(131, 23)
        Me.btnGesLibros.TabIndex = 2
        Me.btnGesLibros.Text = "Gestionar Libros"
        Me.btnGesLibros.UseVisualStyleBackColor = False
        '
        'btnReportes
        '
        Me.btnReportes.BackColor = System.Drawing.Color.Gold
        Me.btnReportes.FlatAppearance.BorderSize = 0
        Me.btnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportes.ForeColor = System.Drawing.Color.Black
        Me.btnReportes.Location = New System.Drawing.Point(286, 100)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(131, 23)
        Me.btnReportes.TabIndex = 3
        Me.btnReportes.Text = "Reportes"
        Me.btnReportes.UseVisualStyleBackColor = False
        '
        'btnCerrarSesionAdmin
        '
        Me.btnCerrarSesionAdmin.BackColor = System.Drawing.Color.Gold
        Me.btnCerrarSesionAdmin.FlatAppearance.BorderSize = 0
        Me.btnCerrarSesionAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnCerrarSesionAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.btnCerrarSesionAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesionAdmin.ForeColor = System.Drawing.Color.Black
        Me.btnCerrarSesionAdmin.Location = New System.Drawing.Point(149, 147)
        Me.btnCerrarSesionAdmin.Name = "btnCerrarSesionAdmin"
        Me.btnCerrarSesionAdmin.Size = New System.Drawing.Size(131, 23)
        Me.btnCerrarSesionAdmin.TabIndex = 4
        Me.btnCerrarSesionAdmin.Text = "Cerrar sesión"
        Me.btnCerrarSesionAdmin.UseVisualStyleBackColor = False
        '
        'frmBienvenidoAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(432, 182)
        Me.Controls.Add(Me.btnCerrarSesionAdmin)
        Me.Controls.Add(Me.btnReportes)
        Me.Controls.Add(Me.btnGesLibros)
        Me.Controls.Add(Me.btnGesEditoriales)
        Me.Controls.Add(Me.lblBienvenida)
        Me.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Name = "frmBienvenidoAdmin"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BIENVENIDO ADMINISTRADOR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBienvenida As Label
    Friend WithEvents btnGesEditoriales As Button
    Friend WithEvents btnGesLibros As Button
    Friend WithEvents btnReportes As Button
    Friend WithEvents btnCerrarSesionAdmin As Button
End Class
