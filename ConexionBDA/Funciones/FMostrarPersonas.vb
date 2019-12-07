Imports System.Data.SqlClient

Public Class FMostrarPersonas
    Inherits FConexion
    Dim cmd As New SqlCommand

    Public Function FnMostrarPersonas() As DataTable
        Try
            FnConectado()
            cmd = New SqlCommand("mostrar_persona")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            FnDesconectado()
        End Try

    End Function

    Public Function FnInsertarPersonas(ByVal dts As Vpersonas) As Boolean
        Try
            FnConectado()
            cmd = New SqlCommand("insertar_personas")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@apellido", dts.gapellido)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)


            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            FnDesconectado()

        End Try

    End Function
End Class
