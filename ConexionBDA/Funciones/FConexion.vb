Imports System.Data.SqlClient

Public Class FConexion
    Protected cnn As SqlConnection

    Public Function FnConectado()
        Try
            cnn = New SqlConnection("Data Source=(Local); Initial Catalog=CLIENTES; Integrated Security=true")
            cnn.Open()
            MsgBox("Se realizo la conexion correctamente")
        Catch ex As Exception
            MsgBox("Error al conectarse" + vbCrLf + ex.Message)
            Return False
        End Try
    End Function

    Public Function FnDesconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox("Error al conectarse" + vbCrLf + ex.Message)
            Return False
        End Try
    End Function
End Class
