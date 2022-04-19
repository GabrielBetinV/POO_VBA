Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration




Module ConexionMaestravb

    Public conexion As New SqlConnection("Server=DESKTOP-T66SHUD;Database=DatabaseContinente;Trusted_Connection=True; MultipleActiveResultSets=True;")



    Sub Abrir_Conexion()

        If conexion.State = 0 Then
            conexion.Open()

        End If

    End Sub


    Sub Cerrar_Conexion()

        If conexion.State = 1 Then
            conexion.Close()

        End If

    End Sub

End Module


Lo podemos probar asi:


Public Sub create_bodega()

        Dim cmd As New SqlCommand


        Try

            Abrir_Conexion()
            cmd = New SqlCommand("CREATE_BODEGA", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@codigo", codigo)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@direccion", direccion)
            cmd.Parameters.AddWithValue("@contacto", contacto)
            cmd.Parameters.AddWithValue("@fechaCreacion", fechaCreacion)
            cmd.ExecuteNonQuery()
            Cerrar_Conexion()

        Catch ex As Exception


        End Try




    End Sub

