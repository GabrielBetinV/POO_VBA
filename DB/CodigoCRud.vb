=> Create

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


=> Read

'Funcion Mostrar'

    Function mostrar()

        'Creamos un objeto  datatable'

        Dim dt As New DataTable

        'Creamos un objeto SqlDataAdapter'

        Dim da As SqlDataAdapter


        Try

            Abrir_Conexion()

            'Guardamos la informacion en el objeto SqlDataAdapter'
            da = New SqlDataAdapter("READ_BODEGA", conexion)


            'Guardamos el objeto  da en el datatable para luego llenar la tabla del formulario'
            da.Fill(dt)

            Return dt


            Cerrar_Conexion()

        Catch ex As Exception


        End Try



    End Function




En el load del formulario para que se cargue automaticamente

   Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim tBodegas = New Bodega()
        DataGridBodegas.DataSource = tBodegas.mostrar()




    End Sub


=> Buscar por nombre


  'Mostrar por codigo o nombre'


    Function mostrarInd(busq As String)

        'Creamos un objeto  datatable'

        Dim dt As New DataTable

        'Creamos un objeto SqlDataAdapter'

        Dim da As SqlDataAdapter


        Try

            Abrir_Conexion()

            'Guardamos la informacion en el objeto SqlDataAdapter'
            da = New SqlDataAdapter("READ_BODEGA_NOMBRE", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@Busqueda", busq)


            'Guardamos el objeto  da en el datatable para luego llenar la tabla del formulario'
            da.Fill(dt)

            Return dt


            Cerrar_Conexion()

        Catch ex As Exception


        End Try




En el controlador del boton



=> Buscar por nombre o codigo pero con un filtro en untexbox

Solo se da doble click en elñ texbox, luego dentro del metodo changed se coloca el medtodo creado anteriormente

Private Sub TextBoxFiltroBodegas_TextChanged(sender As Object, e As EventArgs) Handles TextBoxFiltroBodegas.TextChanged


        Dim tBodegas = New Bodega()
        DataGridBodegas.DataSource = tBodegas.mostrarInd(TextBoxFiltroBodegas.Text.ToString)



    End Sub


=> Actualizar registros


Primero cambiamos la propiedad SelectioMode a = FullRowSelect

Luego agregamos este codigo al metodo CellContentDoubleClick para que cuando se de doble click
se pasen los datos al textbox

  Private Sub DataGridBodegas_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridBodegas.CellContentDoubleClick


        Try

            TextBoxCodigoBodega.Text = DataGridBodegas.SelectedCells.Item(0).Value
            TextBoxNmbreBodega.Text = DataGridBodegas.SelectedCells.Item(1).Value
            TextBoxDireccionBodega.Text = DataGridBodegas.SelectedCells.Item(2).Value
            TextBoxContactoBodega.Text = DataGridBodegas.SelectedCells.Item(3).Value
            ButtonCrearProducto.Enabled = False

        Catch ex As Exception

        End Try



    End Sub



Agregamos unboton para limpiar los texbox y habilitar el boton de crear

    Private Sub ButtonBorrarBodegas_Click(sender As Object, e As EventArgs) Handles ButtonBorrarBodegas.Click

        TextBoxCodigoBodega.Text = ""
        TextBoxNmbreBodega.Text = ""
        TextBoxDireccionBodega.Text = ""
        TextBoxContactoBodega.Text = ""
        ButtonCrearProducto.Enabled = True

    End Sub



Creamos el metodo editar


   Public Sub edit_bodega()

        Dim cmd As New SqlCommand


        Try

            Abrir_Conexion()
            cmd = New SqlCommand("EDIT_BODEGA", conexion)
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





Programamos el boton editar



        If TextBoxCodigoBodega.Text <> "" And TextBoxNmbreBodega.Text <> "" And TextBoxDireccionBodega.Text <> "" And TextBoxContactoBodega.Text <> "" Then

            Dim nBodega As Bodega
            Dim fecha As Date

            fecha = Date.Now

            nBodega = New Bodega(TextBoxCodigoBodega.Text.ToString, TextBoxNmbreBodega.Text.ToString, TextBoxDireccionBodega.Text.ToString, TextBoxContactoBodega.Text.ToString, fecha)
            nBodega.edit_bodega()
            MsgBox("Bodega editada")
            Dim tBodegas = New Bodega()
            DataGridBodegas.DataSource = tBodegas.mostrar()

            TextBoxCodigoBodega.Text = ""
            TextBoxNmbreBodega.Text = ""
            TextBoxDireccionBodega.Text = ""
            TextBoxContactoBodega.Text = ""
            ButtonCrearProducto.Enabled = True


        Else

            MsgBox("Debe llenar todos los campos")


        End If



Modificamos el procedimiento almacenado en para que busque la conincidencia con el codigo del producto


=> Eliminar


Creamos el metodo eliminar

 Public Sub delete_bodega()

        Dim cmd As New SqlCommand


        Try

            Abrir_Conexion()
            cmd = New SqlCommand("DELETE_BODEGA", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@codigo", codigo)

            cmd.ExecuteNonQuery()
            Cerrar_Conexion()

        Catch ex As Exception


        End Try


    End Sub '



=> programamos el boton


 Private Sub ButtonEliminarProducto_Click(sender As Object, e As EventArgs) Handles ButtonEliminarProducto.Click

        If TextBoxCodigoBodega.Text <> "" And TextBoxNmbreBodega.Text <> "" And TextBoxDireccionBodega.Text <> "" And TextBoxContactoBodega.Text <> "" Then

            Dim nBodega As Bodega
            Dim fecha As Date

            fecha = Date.Now

            nBodega = New Bodega(TextBoxCodigoBodega.Text.ToString, TextBoxNmbreBodega.Text.ToString, TextBoxDireccionBodega.Text.ToString, TextBoxContactoBodega.Text.ToString, fecha)
            nBodega.delete_bodega()
            MsgBox("Bodega eliminada")
            Dim tBodegas = New Bodega()
            DataGridBodegas.DataSource = tBodegas.mostrar()

            TextBoxCodigoBodega.Text = ""
            TextBoxNmbreBodega.Text = ""
            TextBoxDireccionBodega.Text = ""
            TextBoxContactoBodega.Text = ""
            ButtonCrearProducto.Enabled = True


        Else

            MsgBox("Debe llenar todos los campos")


        End If


    End Sub




