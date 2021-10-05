Imports System.Data.SqlClient
Public Class frmLibrosPrestados
    Private Sub frmLibrosPrestados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Create a Connection object.
        myConn = New SqlConnection("Initial Catalog=BD_201801585;" & "Data Source=DESKTOP-1N8BRMS\SQLEXPRESS;Integrated Security=SSPI;")

        Try
            'Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT * FROM Prestamo WHERE id_usuario = @usuario"
            myCmd.Parameters.AddWithValue("@usuario", id_usuario_sesion)


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
                    Dim usuario = row.ItemArray(1)
                    Dim libro = row.ItemArray(2)
                    Dim estatus = row.ItemArray(3)
                    dgvGesLibro.Rows.Add(usuario, libro, estatus)
                Next

            End If

            myConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message(),, "Error de Data")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmBienvenidoCliente.Show()
        Me.Close()

    End Sub
End Class