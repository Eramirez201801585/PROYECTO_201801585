Imports System.Data.SqlClient
Public Class frmPrestarLibro
    Private Sub btnPrestarBuscar_Click(sender As Object, e As EventArgs) Handles btnPrestarBuscar.Click
        'Create a Connection object.
        myConn = New SqlConnection("Initial Catalog=BD_201801585;" & "Data Source=DESKTOP-1N8BRMS\SQLEXPRESS;Integrated Security=SSPI;")

        Try
            'Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT * FROM Libro WHERE titulo = @titulo OR genero = @genero"
            myCmd.Parameters.AddWithValue("@titulo", txtGesLibroNombre.Text)
            myCmd.Parameters.AddWithValue("@genero", txtGestLibroGenero.Text)


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
                    Dim editorial = row.ItemArray(1)
                    Dim genero = row.ItemArray(2)
                    Dim titulo = row.ItemArray(3)
                    Dim autor = row.ItemArray(4)
                    Dim cantidad = row.ItemArray(5)
                    dgvGesLibro.Rows.Add(titulo, autor, genero, cantidad, editorial)
                Next

            End If

            myConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message(),, "Error de Data")
        End Try
    End Sub

    Private Sub btnGesLibroBackMenu_Click(sender As Object, e As EventArgs) Handles btnGesLibroBackMenu.Click
        frmBienvenidoCliente.Show()
        txtGesLibroNombre.Text = ""
        txtGestLibroGenero.Text = ""
        Me.Close()

    End Sub

End Class