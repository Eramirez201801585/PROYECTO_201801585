Imports System.Data.SqlClient
Module Module1
    'Variables de la sesion
    Public myConn As SqlConnection
    Public myCmd As SqlCommand
    Public myReader As SqlDataReader
    Public results As String

    Public id_usuario_sesion As String
    Public nombre_sesion As String
    Public apellido_sesion As String
    Public usuario_sesion As String
    Public tipo_usuario_sesion As String
    Public nacimiento_sesion As Date
End Module
