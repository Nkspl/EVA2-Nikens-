<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label8 = New Label()
        Panel2 = New Panel()
        Label7 = New Label()
        RadioButtonNoEspecifica = New RadioButton()
        RadioButtonFemenino = New RadioButton()
        RadioButtonMasculino = New RadioButton()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        ComboBoxComuna = New ComboBox()
        TextBoxNombre = New TextBox()
        TextBoxApellido = New TextBox()
        TextBoxObservacion = New TextBox()
        TextBoxCiudad = New TextBox()
        TextBoxRUT = New TextBox()
        ButtonGuardar = New Button()
        ButtonBuscar = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(ComboBoxComuna)
        Panel1.Controls.Add(TextBoxNombre)
        Panel1.Controls.Add(TextBoxApellido)
        Panel1.Controls.Add(TextBoxObservacion)
        Panel1.Controls.Add(TextBoxCiudad)
        Panel1.Controls.Add(TextBoxRUT)
        Panel1.Controls.Add(ButtonGuardar)
        Panel1.Controls.Add(ButtonBuscar)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(523, 768)
        Panel1.TabIndex = 0
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(230, 24)
        Label8.Name = "Label8"
        Label8.Size = New Size(91, 28)
        Label8.TabIndex = 16
        Label8.Text = "Registro"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(RadioButtonNoEspecifica)
        Panel2.Controls.Add(RadioButtonFemenino)
        Panel2.Controls.Add(RadioButtonMasculino)
        Panel2.Location = New Point(31, 281)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(465, 87)
        Panel2.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(3, 2)
        Label7.Name = "Label7"
        Label7.Size = New Size(41, 20)
        Label7.TabIndex = 16
        Label7.Text = "Sexo"
        ' 
        ' RadioButtonNoEspecifica
        ' 
        RadioButtonNoEspecifica.AutoSize = True
        RadioButtonNoEspecifica.Location = New Point(321, 35)
        RadioButtonNoEspecifica.Name = "RadioButtonNoEspecifica"
        RadioButtonNoEspecifica.Size = New Size(120, 24)
        RadioButtonNoEspecifica.TabIndex = 2
        RadioButtonNoEspecifica.TabStop = True
        RadioButtonNoEspecifica.Text = "No especifica"
        RadioButtonNoEspecifica.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonFemenino
        ' 
        RadioButtonFemenino.AutoSize = True
        RadioButtonFemenino.Location = New Point(162, 35)
        RadioButtonFemenino.Name = "RadioButtonFemenino"
        RadioButtonFemenino.Size = New Size(95, 24)
        RadioButtonFemenino.TabIndex = 1
        RadioButtonFemenino.TabStop = True
        RadioButtonFemenino.Text = "Femenino"
        RadioButtonFemenino.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonMasculino
        ' 
        RadioButtonMasculino.AutoSize = True
        RadioButtonMasculino.Location = New Point(0, 35)
        RadioButtonMasculino.Name = "RadioButtonMasculino"
        RadioButtonMasculino.Size = New Size(97, 24)
        RadioButtonMasculino.TabIndex = 0
        RadioButtonMasculino.TabStop = True
        RadioButtonMasculino.Text = "Masculino"
        RadioButtonMasculino.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(31, 563)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 20)
        Label6.TabIndex = 14
        Label6.Text = "Obsevacion"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(31, 501)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 20)
        Label5.TabIndex = 13
        Label5.Text = "Ciudad"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(31, 441)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 20)
        Label4.TabIndex = 12
        Label4.Text = "Comuna"
        ' 
        ' ComboBoxComuna
        ' 
        ComboBoxComuna.FormattingEnabled = True
        ComboBoxComuna.Location = New Point(137, 441)
        ComboBoxComuna.Name = "ComboBoxComuna"
        ComboBoxComuna.Size = New Size(353, 28)
        ComboBoxComuna.TabIndex = 11
        ' 
        ' TextBoxNombre
        ' 
        TextBoxNombre.Location = New Point(137, 112)
        TextBoxNombre.Name = "TextBoxNombre"
        TextBoxNombre.Size = New Size(359, 27)
        TextBoxNombre.TabIndex = 10
        ' 
        ' TextBoxApellido
        ' 
        TextBoxApellido.Location = New Point(137, 165)
        TextBoxApellido.Name = "TextBoxApellido"
        TextBoxApellido.Size = New Size(359, 27)
        TextBoxApellido.TabIndex = 9
        ' 
        ' TextBoxObservacion
        ' 
        TextBoxObservacion.Location = New Point(137, 556)
        TextBoxObservacion.Name = "TextBoxObservacion"
        TextBoxObservacion.Size = New Size(359, 27)
        TextBoxObservacion.TabIndex = 8
        ' 
        ' TextBoxCiudad
        ' 
        TextBoxCiudad.Location = New Point(137, 494)
        TextBoxCiudad.Name = "TextBoxCiudad"
        TextBoxCiudad.Size = New Size(359, 27)
        TextBoxCiudad.TabIndex = 7
        ' 
        ' TextBoxRUT
        ' 
        TextBoxRUT.Location = New Point(137, 66)
        TextBoxRUT.Name = "TextBoxRUT"
        TextBoxRUT.Size = New Size(238, 27)
        TextBoxRUT.TabIndex = 5
        ' 
        ' ButtonGuardar
        ' 
        ButtonGuardar.Location = New Point(230, 639)
        ButtonGuardar.Name = "ButtonGuardar"
        ButtonGuardar.Size = New Size(94, 29)
        ButtonGuardar.TabIndex = 4
        ButtonGuardar.Text = "Guardar"
        ButtonGuardar.UseVisualStyleBackColor = True
        ' 
        ' ButtonBuscar
        ' 
        ButtonBuscar.Location = New Point(402, 66)
        ButtonBuscar.Name = "ButtonBuscar"
        ButtonBuscar.Size = New Size(94, 29)
        ButtonBuscar.TabIndex = 3
        ButtonBuscar.Text = "Buscar"
        ButtonBuscar.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(31, 112)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 20)
        Label3.TabIndex = 2
        Label3.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 172)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 20)
        Label2.TabIndex = 1
        Label2.Text = "Apellidos"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(31, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(31, 20)
        Label1.TabIndex = 0
        Label1.Text = "Rut"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(526, 765)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxRUT As TextBox
    Friend WithEvents ButtonGuardar As Button
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxComuna As ComboBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxApellido As TextBox
    Friend WithEvents TextBoxObservacion As TextBox
    Friend WithEvents TextBoxCiudad As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RadioButtonNoEspecifica As RadioButton
    Friend WithEvents RadioButtonFemenino As RadioButton
    Friend WithEvents RadioButtonMasculino As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label

End Class
