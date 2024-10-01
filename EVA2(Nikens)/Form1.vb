Imports MySql.Data.MySqlClient

Public Class Form1
    ' Crear la conexión a MySQL
    Dim connectionString As String = "Server=localhost;Database=RegistroPersonas;User ID=root;Password=Hola.,123;SslMode=None;AllowPublicKeyRetrieval=True;"

    Dim connection As New MySqlConnection(connectionString)

    ' Evento al cargar el formulario
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Bloquear todos los campos excepto RUT y botón Buscar
        BloquearCampos(True)
        ' Llenar el ComboBox de Comunas
        LlenarComboBoxComunas()
    End Sub


    ' Función para bloquear o desbloquear los campos
    Private Sub BloquearCampos(ByVal bloquear As Boolean)
        TextBoxNombre.Enabled = Not bloquear
        TextBoxApellido.Enabled = Not bloquear
        RadioButtonMasculino.Enabled = Not bloquear
        RadioButtonFemenino.Enabled = Not bloquear
        RadioButtonNoEspecifica.Enabled = Not bloquear
        ComboBoxComuna.Enabled = Not bloquear
        TextBoxCiudad.Enabled = Not bloquear
        TextBoxObservacion.Enabled = Not bloquear
        ButtonGuardar.Enabled = Not bloquear
        ' El botón Buscar debe estar siempre habilitado
        ButtonBuscar.Enabled = True
    End Sub



    ' Función para llenar el ComboBox de Comuna
    Private Sub LlenarComboBoxComunas()
        Try
            ' Verificar si la conexión ya está abierta antes de intentar abrirla
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim query As String = "SELECT NombreComuna FROM comuna"
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ComboBoxComuna.Items.Clear() ' Limpiar el ComboBox antes de llenarlo
            ComboBoxComuna.Items.Add("Seleccione una comuna") ' Agregar opción por defecto

            While reader.Read()
                ComboBoxComuna.Items.Add(reader("NombreComuna").ToString())
            End While

            reader.Close() ' Cerrar el DataReader después de usarlo

            ' Seleccionar la opción por defecto
            ComboBoxComuna.SelectedIndex = 0

        Catch ex As MySqlException
            MessageBox.Show("Error al cargar comunas: " & ex.Message)
        Finally
            ' Asegurarse de que la conexión se cierra siempre
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub



    ' Función para buscar por RUT
    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Try
            connection.Open()
            Dim query As String = "SELECT * FROM personas WHERE RUT = @RUT"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@RUT", TextBoxRUT.Text)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                ' Si se encuentra el RUT, se muestran los datos
                TextBoxNombre.Text = reader("Nombre").ToString()
                TextBoxApellido.Text = reader("Apellido").ToString()
                SeleccionarSexo(reader("Sexo").ToString())
                ComboBoxComuna.Text = reader("Comuna").ToString()
                TextBoxCiudad.Text = reader("Ciudad").ToString()
                TextBoxObservacion.Text = reader("Observacion").ToString()
                ' Seleccionar la comuna en el ComboBox
                Dim comuna As String = reader("Comuna").ToString()
                If ComboBoxComuna.Items.Contains(comuna) Then
                    ComboBoxComuna.SelectedItem = comuna
                Else
                    ComboBoxComuna.SelectedIndex = 0 ' O manejar el caso donde la comuna no está en la lista
                End If

                ' Desbloquear los campos para permitir edición
                BloquearCampos(False)

            Else
                ' Si no se encuentra el RUT, preguntar si desea agregar un nuevo registro
                Dim respuesta As DialogResult = MessageBox.Show("Datos no encontrados. ¿Quieres agregar un nuevo registro?", "Agregar nuevo", MessageBoxButtons.YesNo)
                If respuesta = DialogResult.Yes Then
                    ' Desbloquear campos para agregar un nuevo registro
                    LimpiarFormulario()
                    BloquearCampos(False)
                Else
                    ' Si el usuario elige No, no hacer nada
                    BloquearCampos(True)
                End If
            End If

            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show("Error al buscar: " & ex.Message)
        End Try
    End Sub



    ' Función para guardar datos en la base de datos
    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        Try
            ' Verificar que se haya seleccionado una comuna válida
            If ComboBoxComuna.SelectedIndex = 0 Then
                MessageBox.Show("Por favor, seleccione una comuna.")
                Return
            End If

            connection.Open()
            Dim query As String = "INSERT INTO personas (RUT, Nombre, Apellido, Sexo, Comuna, Ciudad, Observacion) VALUES (@RUT, @Nombre, @Apellido, @Sexo, @Comuna, @Ciudad, @Observacion)"
            Dim cmd As New MySqlCommand(query, connection)

            cmd.Parameters.AddWithValue("@RUT", TextBoxRUT.Text)
            cmd.Parameters.AddWithValue("@Nombre", TextBoxNombre.Text)
            cmd.Parameters.AddWithValue("@Apellido", TextBoxApellido.Text)
            cmd.Parameters.AddWithValue("@Sexo", ObtenerSexoSeleccionado())
            cmd.Parameters.AddWithValue("@Comuna", ComboBoxComuna.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@Ciudad", TextBoxCiudad.Text)
            cmd.Parameters.AddWithValue("@Observacion", TextBoxObservacion.Text)

            cmd.ExecuteNonQuery()
            connection.Close()

            MessageBox.Show("Guardado exitosamente.")
            LimpiarFormulario()
            BloquearCampos(True)

        Catch ex As MySqlException
            MessageBox.Show("Error al guardar datos: " & ex.Message)
        End Try
    End Sub




    ' Función para limpiar el formulario después de guardar o buscar
    Private Sub LimpiarFormulario()
        TextBoxRUT.Clear()
        TextBoxNombre.Clear()
        TextBoxApellido.Clear()
        ComboBoxComuna.SelectedIndex = 0 ' Restablecer al valor por defecto
        TextBoxCiudad.Clear()
        TextBoxObservacion.Clear()
        RadioButtonMasculino.Checked = False
        RadioButtonFemenino.Checked = False
        RadioButtonNoEspecifica.Checked = False
    End Sub



    ' Obtener el sexo seleccionado
    Private Function ObtenerSexoSeleccionado() As String
        If RadioButtonMasculino.Checked Then
            Return "Masculino"
        ElseIf RadioButtonFemenino.Checked Then
            Return "Femenino"
        Else
            Return "No especifica"
        End If
    End Function




    ' Seleccionar el sexo en el formulario
    Private Sub SeleccionarSexo(ByVal sexo As String)
        If sexo = "Masculino" Then
            RadioButtonMasculino.Checked = True
        ElseIf sexo = "Femenino" Then
            RadioButtonFemenino.Checked = True
        Else
            RadioButtonNoEspecifica.Checked = True
        End If
    End Sub
End Class
