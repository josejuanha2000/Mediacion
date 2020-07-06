<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SM
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DateTimePicker_SM = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TBArea_SM = New System.Windows.Forms.TextBox
        Me.TBReferencia_SM = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TBNombre_Solicitante_SM = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.CBEstado_Civil_SM = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TBDomicilio_SM = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TBTel_Casa_SM = New System.Windows.Forms.TextBox
        Me.TBTel_Oficina_SM = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TBTel_Celular_SM = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.CBPrimaria_SM = New System.Windows.Forms.ComboBox
        Me.CBSecundaria_SM = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.CBPosgrado_SM = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.CBSuperior_SM = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.TBOtros_SM = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.TBOtros_SM2 = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.CBPosgrado_SM2 = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.CBSuperior_SM2 = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.CBSecundaria_SM2 = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.CBPrimaria_SM2 = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.TBTel_Celular_SM2 = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.TBTel_Oficina_SM2 = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.TBTel_Casa_SM2 = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.TBDireccion_SM2 = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.CBEstado_Civil_SM2 = New System.Windows.Forms.ComboBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.TBNombre_Solicitado_SM2 = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LblEdoM = New System.Windows.Forms.Label
        Me.TBEdo_SM = New System.Windows.Forms.TextBox
        Me.TBMunicipio_SM = New System.Windows.Forms.TextBox
        Me.LblMunicipioM = New System.Windows.Forms.Label
        Me.LblColoniaM = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.TBHechos = New System.Windows.Forms.TextBox
        Me.TBPeticiones = New System.Windows.Forms.TextBox
        Me.TBResultados = New System.Windows.Forms.TextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.CBProceso_Judicial = New System.Windows.Forms.ComboBox
        Me.TBIndicar_Proceso_Judicial = New System.Windows.Forms.TextBox
        Me.TBAnte_que_autoridad = New System.Windows.Forms.TextBox
        Me.CBhahabido_Mediador_Anterior = New System.Windows.Forms.ComboBox
        Me.TBIndicar_Mediador_Anterior = New System.Windows.Forms.TextBox
        Me.BTNGuardarSM = New System.Windows.Forms.Button
        Me.BtnActualizarSM = New System.Windows.Forms.Button
        Me.TBColonia_SM = New System.Windows.Forms.TextBox
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(256, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SOLICITUD DE MEDIACION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha de Solicitud:"
        '
        'DateTimePicker_SM
        '
        Me.DateTimePicker_SM.Location = New System.Drawing.Point(129, 17)
        Me.DateTimePicker_SM.Name = "DateTimePicker_SM"
        Me.DateTimePicker_SM.Size = New System.Drawing.Size(196, 20)
        Me.DateTimePicker_SM.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(339, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Área:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(472, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Referencia:"
        '
        'TBArea_SM
        '
        Me.TBArea_SM.Location = New System.Drawing.Point(377, 17)
        Me.TBArea_SM.Name = "TBArea_SM"
        Me.TBArea_SM.Size = New System.Drawing.Size(72, 20)
        Me.TBArea_SM.TabIndex = 7
        '
        'TBReferencia_SM
        '
        Me.TBReferencia_SM.Location = New System.Drawing.Point(539, 17)
        Me.TBReferencia_SM.Name = "TBReferencia_SM"
        Me.TBReferencia_SM.Size = New System.Drawing.Size(115, 20)
        Me.TBReferencia_SM.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Nombre de Solicitante:"
        '
        'TBNombre_Solicitante_SM
        '
        Me.TBNombre_Solicitante_SM.Location = New System.Drawing.Point(129, 42)
        Me.TBNombre_Solicitante_SM.Name = "TBNombre_Solicitante_SM"
        Me.TBNombre_Solicitante_SM.Size = New System.Drawing.Size(377, 20)
        Me.TBNombre_Solicitante_SM.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Estado Civil:"
        '
        'CBEstado_Civil_SM
        '
        Me.CBEstado_Civil_SM.FormattingEnabled = True
        Me.CBEstado_Civil_SM.Items.AddRange(New Object() {"Soltero(a)", "Casado(a)", "Divorciado(a)", "Viudo(a)", "Separado(a)"})
        Me.CBEstado_Civil_SM.Location = New System.Drawing.Point(130, 67)
        Me.CBEstado_Civil_SM.Name = "CBEstado_Civil_SM"
        Me.CBEstado_Civil_SM.Size = New System.Drawing.Size(100, 21)
        Me.CBEstado_Civil_SM.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(233, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Domicilio_"
        '
        'TBDomicilio_SM
        '
        Me.TBDomicilio_SM.Location = New System.Drawing.Point(291, 68)
        Me.TBDomicilio_SM.Name = "TBDomicilio_SM"
        Me.TBDomicilio_SM.Size = New System.Drawing.Size(163, 20)
        Me.TBDomicilio_SM.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Telefono Casa:"
        '
        'TBTel_Casa_SM
        '
        Me.TBTel_Casa_SM.Location = New System.Drawing.Point(129, 124)
        Me.TBTel_Casa_SM.Name = "TBTel_Casa_SM"
        Me.TBTel_Casa_SM.Size = New System.Drawing.Size(125, 20)
        Me.TBTel_Casa_SM.TabIndex = 16
        '
        'TBTel_Oficina_SM
        '
        Me.TBTel_Oficina_SM.Location = New System.Drawing.Point(345, 125)
        Me.TBTel_Oficina_SM.Name = "TBTel_Oficina_SM"
        Me.TBTel_Oficina_SM.Size = New System.Drawing.Size(132, 20)
        Me.TBTel_Oficina_SM.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(257, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Telefono Oficina:"
        '
        'TBTel_Celular_SM
        '
        Me.TBTel_Celular_SM.Location = New System.Drawing.Point(525, 126)
        Me.TBTel_Celular_SM.Name = "TBTel_Celular_SM"
        Me.TBTel_Celular_SM.Size = New System.Drawing.Size(148, 20)
        Me.TBTel_Celular_SM.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(479, 129)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Celular:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Estudio:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 186)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Universitaria:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(127, 153)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Primaria:"
        '
        'CBPrimaria_SM
        '
        Me.CBPrimaria_SM.FormattingEnabled = True
        Me.CBPrimaria_SM.Items.AddRange(New Object() {"S", "N"})
        Me.CBPrimaria_SM.Location = New System.Drawing.Point(173, 150)
        Me.CBPrimaria_SM.Name = "CBPrimaria_SM"
        Me.CBPrimaria_SM.Size = New System.Drawing.Size(50, 21)
        Me.CBPrimaria_SM.TabIndex = 24
        '
        'CBSecundaria_SM
        '
        Me.CBSecundaria_SM.FormattingEnabled = True
        Me.CBSecundaria_SM.Items.AddRange(New Object() {"S", "N"})
        Me.CBSecundaria_SM.Location = New System.Drawing.Point(306, 152)
        Me.CBSecundaria_SM.Name = "CBSecundaria_SM"
        Me.CBSecundaria_SM.Size = New System.Drawing.Size(50, 21)
        Me.CBSecundaria_SM.TabIndex = 26
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(239, 155)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 13)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Secundaria:"
        '
        'CBPosgrado_SM
        '
        Me.CBPosgrado_SM.FormattingEnabled = True
        Me.CBPosgrado_SM.Items.AddRange(New Object() {"S", "N"})
        Me.CBPosgrado_SM.Location = New System.Drawing.Point(306, 186)
        Me.CBPosgrado_SM.Name = "CBPosgrado_SM"
        Me.CBPosgrado_SM.Size = New System.Drawing.Size(50, 21)
        Me.CBPosgrado_SM.TabIndex = 30
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(239, 189)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Posgrado:"
        '
        'CBSuperior_SM
        '
        Me.CBSuperior_SM.FormattingEnabled = True
        Me.CBSuperior_SM.Items.AddRange(New Object() {"S", "N"})
        Me.CBSuperior_SM.Location = New System.Drawing.Point(173, 184)
        Me.CBSuperior_SM.Name = "CBSuperior_SM"
        Me.CBSuperior_SM.Size = New System.Drawing.Size(50, 21)
        Me.CBSuperior_SM.TabIndex = 28
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(127, 187)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 13)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Superior:"
        '
        'TBOtros_SM
        '
        Me.TBOtros_SM.Location = New System.Drawing.Point(432, 186)
        Me.TBOtros_SM.Name = "TBOtros_SM"
        Me.TBOtros_SM.Size = New System.Drawing.Size(222, 20)
        Me.TBOtros_SM.TabIndex = 32
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(387, 188)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 13)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Otros:"
        '
        'TBOtros_SM2
        '
        Me.TBOtros_SM2.Location = New System.Drawing.Point(429, 155)
        Me.TBOtros_SM2.Name = "TBOtros_SM2"
        Me.TBOtros_SM2.Size = New System.Drawing.Size(222, 20)
        Me.TBOtros_SM2.TabIndex = 54
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(384, 158)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 13)
        Me.Label18.TabIndex = 53
        Me.Label18.Text = "Otros:"
        '
        'CBPosgrado_SM2
        '
        Me.CBPosgrado_SM2.FormattingEnabled = True
        Me.CBPosgrado_SM2.Items.AddRange(New Object() {"S", "N"})
        Me.CBPosgrado_SM2.Location = New System.Drawing.Point(303, 155)
        Me.CBPosgrado_SM2.Name = "CBPosgrado_SM2"
        Me.CBPosgrado_SM2.Size = New System.Drawing.Size(50, 21)
        Me.CBPosgrado_SM2.TabIndex = 52
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(236, 158)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 13)
        Me.Label19.TabIndex = 51
        Me.Label19.Text = "Posgrado:"
        '
        'CBSuperior_SM2
        '
        Me.CBSuperior_SM2.FormattingEnabled = True
        Me.CBSuperior_SM2.Items.AddRange(New Object() {"S", "N"})
        Me.CBSuperior_SM2.Location = New System.Drawing.Point(170, 153)
        Me.CBSuperior_SM2.Name = "CBSuperior_SM2"
        Me.CBSuperior_SM2.Size = New System.Drawing.Size(50, 21)
        Me.CBSuperior_SM2.TabIndex = 50
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(124, 156)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 13)
        Me.Label20.TabIndex = 49
        Me.Label20.Text = "Superior:"
        '
        'CBSecundaria_SM2
        '
        Me.CBSecundaria_SM2.FormattingEnabled = True
        Me.CBSecundaria_SM2.Items.AddRange(New Object() {"S", "N"})
        Me.CBSecundaria_SM2.Location = New System.Drawing.Point(303, 127)
        Me.CBSecundaria_SM2.Name = "CBSecundaria_SM2"
        Me.CBSecundaria_SM2.Size = New System.Drawing.Size(50, 21)
        Me.CBSecundaria_SM2.TabIndex = 48
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(236, 130)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(64, 13)
        Me.Label21.TabIndex = 47
        Me.Label21.Text = "Secundaria:"
        '
        'CBPrimaria_SM2
        '
        Me.CBPrimaria_SM2.FormattingEnabled = True
        Me.CBPrimaria_SM2.Items.AddRange(New Object() {"S", "N"})
        Me.CBPrimaria_SM2.Location = New System.Drawing.Point(170, 125)
        Me.CBPrimaria_SM2.Name = "CBPrimaria_SM2"
        Me.CBPrimaria_SM2.Size = New System.Drawing.Size(50, 21)
        Me.CBPrimaria_SM2.TabIndex = 46
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(124, 128)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(47, 13)
        Me.Label22.TabIndex = 45
        Me.Label22.Text = "Primaria:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(11, 155)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(68, 13)
        Me.Label23.TabIndex = 44
        Me.Label23.Text = "Universitaria:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(11, 127)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(45, 13)
        Me.Label24.TabIndex = 43
        Me.Label24.Text = "Estudio:"
        '
        'TBTel_Celular_SM2
        '
        Me.TBTel_Celular_SM2.Location = New System.Drawing.Point(522, 100)
        Me.TBTel_Celular_SM2.Name = "TBTel_Celular_SM2"
        Me.TBTel_Celular_SM2.Size = New System.Drawing.Size(129, 20)
        Me.TBTel_Celular_SM2.TabIndex = 44
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(479, 101)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(42, 13)
        Me.Label25.TabIndex = 41
        Me.Label25.Text = "Celular:"
        '
        'TBTel_Oficina_SM2
        '
        Me.TBTel_Oficina_SM2.Location = New System.Drawing.Point(342, 99)
        Me.TBTel_Oficina_SM2.Name = "TBTel_Oficina_SM2"
        Me.TBTel_Oficina_SM2.Size = New System.Drawing.Size(132, 20)
        Me.TBTel_Oficina_SM2.TabIndex = 42
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(254, 101)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(88, 13)
        Me.Label26.TabIndex = 39
        Me.Label26.Text = "Telefono Oficina:"
        '
        'TBTel_Casa_SM2
        '
        Me.TBTel_Casa_SM2.Location = New System.Drawing.Point(126, 97)
        Me.TBTel_Casa_SM2.Name = "TBTel_Casa_SM2"
        Me.TBTel_Casa_SM2.Size = New System.Drawing.Size(125, 20)
        Me.TBTel_Casa_SM2.TabIndex = 40
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(8, 100)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(79, 13)
        Me.Label27.TabIndex = 37
        Me.Label27.Text = "Telefono Casa:"
        '
        'TBDireccion_SM2
        '
        Me.TBDireccion_SM2.Location = New System.Drawing.Point(126, 70)
        Me.TBDireccion_SM2.Name = "TBDireccion_SM2"
        Me.TBDireccion_SM2.Size = New System.Drawing.Size(525, 20)
        Me.TBDireccion_SM2.TabIndex = 38
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(11, 73)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(55, 13)
        Me.Label28.TabIndex = 35
        Me.Label28.Text = "Direccion:"
        '
        'CBEstado_Civil_SM2
        '
        Me.CBEstado_Civil_SM2.FormattingEnabled = True
        Me.CBEstado_Civil_SM2.Items.AddRange(New Object() {"Soltero(a)", "Casado(a)", "Divorciado(a)", "Viudo(a)", "Separado(a)"})
        Me.CBEstado_Civil_SM2.Location = New System.Drawing.Point(127, 44)
        Me.CBEstado_Civil_SM2.Name = "CBEstado_Civil_SM2"
        Me.CBEstado_Civil_SM2.Size = New System.Drawing.Size(100, 21)
        Me.CBEstado_Civil_SM2.TabIndex = 36
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(11, 47)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(65, 13)
        Me.Label29.TabIndex = 33
        Me.Label29.Text = "Estado Civil:"
        '
        'TBNombre_Solicitado_SM2
        '
        Me.TBNombre_Solicitado_SM2.Location = New System.Drawing.Point(127, 20)
        Me.TBNombre_Solicitado_SM2.Name = "TBNombre_Solicitado_SM2"
        Me.TBNombre_Solicitado_SM2.Size = New System.Drawing.Size(377, 20)
        Me.TBNombre_Solicitado_SM2.TabIndex = 34
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(7, 21)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(111, 13)
        Me.Label30.TabIndex = 55
        Me.Label30.Text = "Nombre de Solicitado:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblEdoM)
        Me.GroupBox1.Controls.Add(Me.TBOtros_SM)
        Me.GroupBox1.Controls.Add(Me.TBEdo_SM)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.TBMunicipio_SM)
        Me.GroupBox1.Controls.Add(Me.CBPosgrado_SM)
        Me.GroupBox1.Controls.Add(Me.LblMunicipioM)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.LblColoniaM)
        Me.GroupBox1.Controls.Add(Me.CBSuperior_SM)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.CBSecundaria_SM)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.CBPrimaria_SM)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TBTel_Celular_SM)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TBTel_Oficina_SM)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TBTel_Casa_SM)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TBDomicilio_SM)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.CBEstado_Civil_SM)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TBNombre_Solicitante_SM)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TBReferencia_SM)
        Me.GroupBox1.Controls.Add(Me.TBArea_SM)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker_SM)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(686, 213)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Solicitud:"
        '
        'LblEdoM
        '
        Me.LblEdoM.AutoSize = True
        Me.LblEdoM.Location = New System.Drawing.Point(469, 98)
        Me.LblEdoM.Name = "LblEdoM"
        Me.LblEdoM.Size = New System.Drawing.Size(29, 13)
        Me.LblEdoM.TabIndex = 79
        Me.LblEdoM.Text = "Edo:"
        '
        'TBEdo_SM
        '
        Me.TBEdo_SM.Location = New System.Drawing.Point(508, 97)
        Me.TBEdo_SM.Name = "TBEdo_SM"
        Me.TBEdo_SM.Size = New System.Drawing.Size(165, 20)
        Me.TBEdo_SM.TabIndex = 78
        '
        'TBMunicipio_SM
        '
        Me.TBMunicipio_SM.Location = New System.Drawing.Point(130, 95)
        Me.TBMunicipio_SM.Name = "TBMunicipio_SM"
        Me.TBMunicipio_SM.Size = New System.Drawing.Size(324, 20)
        Me.TBMunicipio_SM.TabIndex = 77
        '
        'LblMunicipioM
        '
        Me.LblMunicipioM.AutoSize = True
        Me.LblMunicipioM.Location = New System.Drawing.Point(14, 98)
        Me.LblMunicipioM.Name = "LblMunicipioM"
        Me.LblMunicipioM.Size = New System.Drawing.Size(33, 13)
        Me.LblMunicipioM.TabIndex = 76
        Me.LblMunicipioM.Text = "Mpio:"
        '
        'LblColoniaM
        '
        Me.LblColoniaM.AutoSize = True
        Me.LblColoniaM.Location = New System.Drawing.Point(460, 71)
        Me.LblColoniaM.Name = "LblColoniaM"
        Me.LblColoniaM.Size = New System.Drawing.Size(45, 13)
        Me.LblColoniaM.TabIndex = 74
        Me.LblColoniaM.Text = "Colonia:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TBNombre_Solicitado_SM2)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.TBOtros_SM2)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.CBPosgrado_SM2)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.CBSuperior_SM2)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.CBSecundaria_SM2)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.CBPrimaria_SM2)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.TBTel_Celular_SM2)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.TBTel_Oficina_SM2)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.TBTel_Casa_SM2)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.TBDireccion_SM2)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.CBEstado_Civil_SM2)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 246)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(683, 198)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Solicitado:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(46, 456)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(47, 13)
        Me.Label31.TabIndex = 57
        Me.Label31.Text = "Hechos:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(32, 507)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(59, 13)
        Me.Label32.TabIndex = 59
        Me.Label32.Text = "Peticiones:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(27, 564)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(63, 13)
        Me.Label33.TabIndex = 60
        Me.Label33.Text = "Resultados:"
        '
        'TBHechos
        '
        Me.TBHechos.Location = New System.Drawing.Point(99, 449)
        Me.TBHechos.Multiline = True
        Me.TBHechos.Name = "TBHechos"
        Me.TBHechos.Size = New System.Drawing.Size(605, 51)
        Me.TBHechos.TabIndex = 61
        '
        'TBPeticiones
        '
        Me.TBPeticiones.Location = New System.Drawing.Point(99, 503)
        Me.TBPeticiones.Multiline = True
        Me.TBPeticiones.Name = "TBPeticiones"
        Me.TBPeticiones.Size = New System.Drawing.Size(605, 51)
        Me.TBPeticiones.TabIndex = 62
        '
        'TBResultados
        '
        Me.TBResultados.Location = New System.Drawing.Point(99, 557)
        Me.TBResultados.Multiline = True
        Me.TBResultados.Name = "TBResultados"
        Me.TBResultados.Size = New System.Drawing.Size(605, 51)
        Me.TBResultados.TabIndex = 63
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(27, 621)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(153, 13)
        Me.Label34.TabIndex = 64
        Me.Label34.Text = "Se ha iniciado proceso judicial:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(235, 623)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(139, 13)
        Me.Label35.TabIndex = 65
        Me.Label35.Text = "En caso afirmativo indicarlo:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(268, 648)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(100, 13)
        Me.Label36.TabIndex = 66
        Me.Label36.Text = "Ante qué autoridad:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(32, 668)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(143, 13)
        Me.Label37.TabIndex = 67
        Me.Label37.Text = "Ha habido mediador anterior:"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(237, 674)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(131, 13)
        Me.Label38.TabIndex = 68
        Me.Label38.Text = "En caso afirmativo indicar:"
        '
        'CBProceso_Judicial
        '
        Me.CBProceso_Judicial.FormattingEnabled = True
        Me.CBProceso_Judicial.Items.AddRange(New Object() {"S", "N"})
        Me.CBProceso_Judicial.Location = New System.Drawing.Point(179, 619)
        Me.CBProceso_Judicial.Name = "CBProceso_Judicial"
        Me.CBProceso_Judicial.Size = New System.Drawing.Size(50, 21)
        Me.CBProceso_Judicial.TabIndex = 67
        '
        'TBIndicar_Proceso_Judicial
        '
        Me.TBIndicar_Proceso_Judicial.Location = New System.Drawing.Point(374, 622)
        Me.TBIndicar_Proceso_Judicial.Name = "TBIndicar_Proceso_Judicial"
        Me.TBIndicar_Proceso_Judicial.Size = New System.Drawing.Size(390, 20)
        Me.TBIndicar_Proceso_Judicial.TabIndex = 68
        '
        'TBAnte_que_autoridad
        '
        Me.TBAnte_que_autoridad.Location = New System.Drawing.Point(374, 648)
        Me.TBAnte_que_autoridad.Name = "TBAnte_que_autoridad"
        Me.TBAnte_que_autoridad.Size = New System.Drawing.Size(390, 20)
        Me.TBAnte_que_autoridad.TabIndex = 69
        '
        'CBhahabido_Mediador_Anterior
        '
        Me.CBhahabido_Mediador_Anterior.FormattingEnabled = True
        Me.CBhahabido_Mediador_Anterior.Items.AddRange(New Object() {"S", "N"})
        Me.CBhahabido_Mediador_Anterior.Location = New System.Drawing.Point(179, 665)
        Me.CBhahabido_Mediador_Anterior.Name = "CBhahabido_Mediador_Anterior"
        Me.CBhahabido_Mediador_Anterior.Size = New System.Drawing.Size(50, 21)
        Me.CBhahabido_Mediador_Anterior.TabIndex = 70
        '
        'TBIndicar_Mediador_Anterior
        '
        Me.TBIndicar_Mediador_Anterior.Location = New System.Drawing.Point(374, 674)
        Me.TBIndicar_Mediador_Anterior.Name = "TBIndicar_Mediador_Anterior"
        Me.TBIndicar_Mediador_Anterior.Size = New System.Drawing.Size(390, 20)
        Me.TBIndicar_Mediador_Anterior.TabIndex = 71
        '
        'BTNGuardarSM
        '
        Me.BTNGuardarSM.Enabled = False
        Me.BTNGuardarSM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGuardarSM.Location = New System.Drawing.Point(711, 270)
        Me.BTNGuardarSM.Name = "BTNGuardarSM"
        Me.BTNGuardarSM.Size = New System.Drawing.Size(78, 49)
        Me.BTNGuardarSM.TabIndex = 72
        Me.BTNGuardarSM.Text = "Guardar"
        Me.BTNGuardarSM.UseVisualStyleBackColor = True
        '
        'BtnActualizarSM
        '
        Me.BtnActualizarSM.Enabled = False
        Me.BtnActualizarSM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizarSM.Location = New System.Drawing.Point(711, 392)
        Me.BtnActualizarSM.Name = "BtnActualizarSM"
        Me.BtnActualizarSM.Size = New System.Drawing.Size(78, 52)
        Me.BtnActualizarSM.TabIndex = 73
        Me.BtnActualizarSM.Text = "Actualizar"
        Me.BtnActualizarSM.UseVisualStyleBackColor = True
        '
        'TBColonia_SM
        '
        Me.TBColonia_SM.Location = New System.Drawing.Point(525, 98)
        Me.TBColonia_SM.Name = "TBColonia_SM"
        Me.TBColonia_SM.Size = New System.Drawing.Size(166, 20)
        Me.TBColonia_SM.TabIndex = 75
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=COLMASQLFDC01\FACDYCDES;Initial Catalog=Mediacion;Integrated Security" & _
            "=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 698)
        Me.Controls.Add(Me.BtnActualizarSM)
        Me.Controls.Add(Me.BTNGuardarSM)
        Me.Controls.Add(Me.TBIndicar_Mediador_Anterior)
        Me.Controls.Add(Me.CBhahabido_Mediador_Anterior)
        Me.Controls.Add(Me.TBAnte_que_autoridad)
        Me.Controls.Add(Me.TBIndicar_Proceso_Judicial)
        Me.Controls.Add(Me.CBProceso_Judicial)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.TBColonia_SM)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.TBResultados)
        Me.Controls.Add(Me.TBPeticiones)
        Me.Controls.Add(Me.TBHechos)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SM"
        Me.Text = "Solicitud de Mediación"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_SM As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBArea_SM As System.Windows.Forms.TextBox
    Friend WithEvents TBReferencia_SM As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TBNombre_Solicitante_SM As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CBEstado_Civil_SM As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TBDomicilio_SM As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TBTel_Casa_SM As System.Windows.Forms.TextBox
    Friend WithEvents TBTel_Oficina_SM As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TBTel_Celular_SM As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CBPrimaria_SM As System.Windows.Forms.ComboBox
    Friend WithEvents CBSecundaria_SM As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CBPosgrado_SM As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CBSuperior_SM As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TBOtros_SM As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TBOtros_SM2 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents CBPosgrado_SM2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents CBSuperior_SM2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents CBSecundaria_SM2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents CBPrimaria_SM2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TBTel_Celular_SM2 As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TBTel_Oficina_SM2 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TBTel_Casa_SM2 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TBDireccion_SM2 As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents CBEstado_Civil_SM2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents TBNombre_Solicitado_SM2 As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents TBHechos As System.Windows.Forms.TextBox
    Friend WithEvents TBPeticiones As System.Windows.Forms.TextBox
    Friend WithEvents TBResultados As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents CBProceso_Judicial As System.Windows.Forms.ComboBox
    Friend WithEvents TBIndicar_Proceso_Judicial As System.Windows.Forms.TextBox
    Friend WithEvents TBAnte_que_autoridad As System.Windows.Forms.TextBox
    Friend WithEvents CBhahabido_Mediador_Anterior As System.Windows.Forms.ComboBox
    Friend WithEvents TBIndicar_Mediador_Anterior As System.Windows.Forms.TextBox
    Friend WithEvents BTNGuardarSM As System.Windows.Forms.Button
    Friend WithEvents BtnActualizarSM As System.Windows.Forms.Button
    Friend WithEvents LblEdoM As System.Windows.Forms.Label
    Friend WithEvents TBEdo_SM As System.Windows.Forms.TextBox
    Friend WithEvents TBMunicipio_SM As System.Windows.Forms.TextBox
    Friend WithEvents LblMunicipioM As System.Windows.Forms.Label
    Friend WithEvents LblColoniaM As System.Windows.Forms.Label
    Friend WithEvents TBColonia_SM As System.Windows.Forms.TextBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
End Class
