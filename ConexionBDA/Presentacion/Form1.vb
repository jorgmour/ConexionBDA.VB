Public Class Form1
    Dim dt As New DataTable
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SubconexionBD()
        Mostrar()
    End Sub
    Sub Mostrar()
        Try
            Dim func As New FMostrarPersonas
            dt = func.FnMostrarPersonas
            If dt.Rows.Count <> 0 Then
                DataGridView1.DataSource = dt
            Else
                DataGridView1.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub SubconexionBD()
        Try
            Dim funcion As New FConexion
            funcion.FnConectado()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim funciones As New FMostrarPersonas
            Dim logica As New Vpersonas

            logica.gnombre = Me.TextBox2.Text
            logica.gapellido = Me.TextBox3.Text
            logica.gdireccion = Me.TextBox4.Text
            logica.gtelefono = Me.TextBox5.Text

            If funciones.FnInsertarPersonas(logica) Then
                MsgBox("Datos agregados")
                Mostrar()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
