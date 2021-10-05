Imports System.Data.SqlClient
Public Class frmGesEditoriales

    Private Sub frmGesEditoriales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Create a Connection object.
        myConn = New SqlConnection("Initial Catalog=BD_201801585;" & "Data Source=DESKTOP-1N8BRMS\SQLEXPRESS;Integrated Security=SSPI;")
        Try

            'Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT * FROM Editorial"

            'Open the connection.
            myConn.Open()

            'Ejecuta el comando SQL
            Dim adapter As New SqlDataAdapter(myCmd)
            'Creamos una tabla que almacenará toda la informacion que la base de datos retorna
            Dim table As New DataTable()
            'Aqui se llena la tabla con el resultado
            adapter.Fill(table)

            For Each row As DataRow In table.Rows 'Por cada de la fila de la tabla, accederemos a su información
                'guardaremos la info en las variables del módulo
                Dim nombre = row.ItemArray(1)
                Dim direccion = row.ItemArray(2)
                Dim telefono = row.ItemArray(3)
                dgvGesEditorial.Rows.Add(nombre, direccion, telefono)
            Next

            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message(), , "Algo tronó")
        End Try

    End Sub


    Private Sub btnGesEditorialBackMenu_Click(sender As Object, e As EventArgs) Handles btnGesEditorialBackMenu.Click
        frmBienvenidoAdmin.Show()
        Me.Close()
    End Sub
End Class