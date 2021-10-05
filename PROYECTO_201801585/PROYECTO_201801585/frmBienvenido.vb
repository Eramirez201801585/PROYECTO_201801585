Public Class frmBienvenidoAdmin
    Private Sub frmBienvenidoAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBienvenida.Text = "Bienvenido " + nombre_sesion + " " + apellido_sesion
    End Sub

    Private Sub btnGesEditoriales_Click(sender As Object, e As EventArgs) Handles btnGesEditoriales.Click
        frmGesEditoriales.Show()
        Me.Close()
    End Sub

    Private Sub btnGesLibros_Click(sender As Object, e As EventArgs) Handles btnGesLibros.Click
        frmGesLibros.Show()
        Me.Close()
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        frmReportes.Show()
        Me.Close()
    End Sub

    Private Sub btnCerrarSesionAdmin_Click(sender As Object, e As EventArgs) Handles btnCerrarSesionAdmin.Click
        frmLogin.Show()
        id_usuario_sesion = ""
        nombre_sesion = ""
        apellido_sesion = ""
        usuario_sesion = ""
        tipo_usuario_sesion = ""
        nacimiento_sesion = Nothing
        Me.Close()
    End Sub
End Class