Imports System.Data.SqlClient
Public Class frmLogin
    'Create ADO.NET objects.


    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        'Create a Connection object.
        myConn = New SqlConnection("Initial Catalog=BD_201801585;" & "Data Source=DESKTOP-1N8BRMS\SQLEXPRESS;Integrated Security=SSPI;")

        Try
            myConn.Open()

            If myConn.State() = 1 Then
                MsgBox("La conexión a la base de datos ha sido exitosa.",, "Conectado")
            Else
                MsgBox("La conexión a la base de datos no se ha completado.",, "Error de Conexión")
            End If

            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message(),, "Error de Data")
        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txbUsuario.Text = "" Or txtContra.Text = "" Or cmbTipoUsuario.Text = "" Then
            MsgBox("Por favor llene todos los campos")
            Exit Sub
        End If

        'Create a Connection object.
        myConn = New SqlConnection("Initial Catalog=BD_201801585;" & "Data Source=DESKTOP-1N8BRMS\SQLEXPRESS;Integrated Security=SSPI;")

        Try
            'Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT TOP 1 * FROM Usuario WHERE usuario = @usuario AND contrasenia = @contra AND tipo_usr= @tipo_usr"
            myCmd.Parameters.AddWithValue("@usuario", txbUsuario.Text)
            myCmd.Parameters.AddWithValue("@contra", txtContra.Text)
            myCmd.Parameters.AddWithValue("@tipo_usr", cmbTipoUsuario.Text)

            'Open the connection.
            myConn.Open()
            'Ejecuta el comando SQL
            Dim adapter As New SqlDataAdapter(myCmd)
            'Creamos una tabla que almacenará toda la informacion que la base de datos retorna
            Dim table As New DataTable()
            'Aqui se llena la tabla con el resultado
            adapter.Fill(table)

            If table.Rows.Count() <= 0 Then 'Si las filas es igual a 0 es porque no se encontró nada
                MsgBox("Las credenciales no son validas")
            Else
                For Each row As DataRow In table.Rows 'Por cada de la fila de la tabla, accederemos a su información
                    'guardaremos la info en las variables del módulo
                    id_usuario_sesion = row.ItemArray(0)
                    nombre_sesion = row.ItemArray(1)
                    apellido_sesion = row.ItemArray(2)
                    usuario_sesion = row.ItemArray(3)
                    tipo_usuario_sesion = row.ItemArray(4)
                    nacimiento_sesion = row.ItemArray(5)
                    Exit For 'Solo recibimos una fila, por eso nos salimos del for
                Next
                'Verificar tipo de usuario para redirigir al form correspodiente
                If tipo_usuario_sesion = "Administrador" Then
                    'Mostrar form de Administrador
                    frmBienvenidoAdmin.Show()
                    txbUsuario.Text = ""
                    txtContra.Text = ""
                    cmbTipoUsuario.Text = ""
                    Me.Hide()
                    myConn.Close()
                ElseIf tipo_usuario_sesion = "Cliente" Then
                    'Mostrar form de cliente
                    frmBienvenidoCliente.Show()
                    txbUsuario.Text = ""
                    txtContra.Text = ""
                    cmbTipoUsuario.Text = ""
                    Me.Hide()
                    myConn.Close()
                End If
            End If

            myConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message(),, "Error de Data")
        End Try
    End Sub

    Private Sub lklRegistro_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklRegistro.LinkClicked
        frmRegistro.Show()
        Me.Hide()
    End Sub


End Class
