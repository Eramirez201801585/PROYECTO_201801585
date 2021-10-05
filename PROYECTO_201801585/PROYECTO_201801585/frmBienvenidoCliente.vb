Public Class frmBienvenidoCliente
    Private Sub frmBienvenidoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBienvenida.Text = "Bienvenido " + nombre_sesion + " " + apellido_sesion
    End Sub

    Private Sub btnLibrosPrestados_Click(sender As Object, e As EventArgs) Handles btnLibrosPrestados.Click
        frmLibrosPrestados.Show()
        Me.Close()

    End Sub

    Private Sub btnPrestarLibros_Click(sender As Object, e As EventArgs) Handles btnPrestarLibros.Click
        frmPrestarLibro.Show()
        Me.Close()
    End Sub

    Private Sub btnEditarPerfil_Click(sender As Object, e As EventArgs) Handles btnEditarPerfil.Click
        frmMiPerfil.Show()
        Me.Close()
    End Sub

    Private Sub btnCerrarSesionCliente_Click(sender As Object, e As EventArgs) Handles btnCerrarSesionCliente.Click
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