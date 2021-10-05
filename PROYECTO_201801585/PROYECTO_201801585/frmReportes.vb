Imports System.Data.SqlClient
Public Class frmReportes
    Private Sub frmReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            'Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT * FROM Usuario"

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
                Dim apellido = row.ItemArray(2)
                Dim usuario = row.ItemArray(3)
                Dim tipo_usr = row.ItemArray(4)
                Dim nacimiento = row.ItemArray(5)
                Dim contra = row.ItemArray(5)
                dgvGesLibro.Rows.Add(nombre, apellido, usuario, tipo_usr, nacimiento, contra)
            Next

            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message(), , "Algo tronó")
        End Try
    End Sub

    Private Sub btnReporteBackMenu_Click(sender As Object, e As EventArgs) Handles btnReporteBackMenu.Click
        frmBienvenidoAdmin.Show()
        Me.Close()
    End Sub
End Class