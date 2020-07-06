<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mediar
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
        Me.components = New System.ComponentModel.Container
        Me.LblFolioM = New System.Windows.Forms.Label
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.TBFolioMediacion = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CBEdo_CivilM = New System.Windows.Forms.ComboBox
        Me.LblEdoCivil = New System.Windows.Forms.Label
        Me.LblEdoM = New System.Windows.Forms.Label
        Me.TBEdoM = New System.Windows.Forms.TextBox
        Me.TBAsuntoMediacionM = New System.Windows.Forms.TextBox
        Me.LblAsuntoM = New System.Windows.Forms.Label
        Me.TBOcupacionM = New System.Windows.Forms.TextBox
        Me.LblOcupacionM = New System.Windows.Forms.Label
        Me.TBE_mailM = New System.Windows.Forms.TextBox
        Me.LblEmailM = New System.Windows.Forms.Label
        Me.LblCelularM = New System.Windows.Forms.Label
        Me.TBCelularM = New System.Windows.Forms.TextBox
        Me.LblOficinaM = New System.Windows.Forms.Label
        Me.TBOficinaM = New System.Windows.Forms.TextBox
        Me.LblTelefono = New System.Windows.Forms.Label
        Me.LblNumero = New System.Windows.Forms.Label
        Me.LblCalle = New System.Windows.Forms.Label
        Me.TBMunicipioM = New System.Windows.Forms.TextBox
        Me.LblMunicipioM = New System.Windows.Forms.Label
        Me.TBColoniaM = New System.Windows.Forms.TextBox
        Me.LblColoniaM = New System.Windows.Forms.Label
        Me.TBDomicilioM = New System.Windows.Forms.TextBox
        Me.LblDomicilioM = New System.Windows.Forms.Label
        Me.TBNombre_SolicitanteM = New System.Windows.Forms.TextBox
        Me.LblNombreSolicitanteM = New System.Windows.Forms.Label
        Me.LblFechaAsesoria = New System.Windows.Forms.Label
        Me.DateTimePickerMediacion = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CBEdoCivilI = New System.Windows.Forms.ComboBox
        Me.LblEdoCivilI = New System.Windows.Forms.Label
        Me.LblEdoI = New System.Windows.Forms.Label
        Me.TBEdoI = New System.Windows.Forms.TextBox
        Me.TBOcupacionI = New System.Windows.Forms.TextBox
        Me.LblOcupacionI = New System.Windows.Forms.Label
        Me.TBEmailI = New System.Windows.Forms.TextBox
        Me.LblEmailI = New System.Windows.Forms.Label
        Me.LblCelularI = New System.Windows.Forms.Label
        Me.TBCelularI = New System.Windows.Forms.TextBox
        Me.LblOficinaI = New System.Windows.Forms.Label
        Me.TBOficinaI = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.TBMpioI = New System.Windows.Forms.TextBox
        Me.LblMpioI = New System.Windows.Forms.Label
        Me.TBColoniaI = New System.Windows.Forms.TextBox
        Me.LblColoniaI = New System.Windows.Forms.Label
        Me.TBDomicilioI = New System.Windows.Forms.TextBox
        Me.LblDomicilioI = New System.Windows.Forms.Label
        Me.TBNombreInvitado = New System.Windows.Forms.TextBox
        Me.LblSolicitanteI = New System.Windows.Forms.Label
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.TBMediadorM = New System.Windows.Forms.TextBox
        Me.LblMediadorM = New System.Windows.Forms.Label
        Me.DataGridViewMediacion = New System.Windows.Forms.DataGridView
        Me.BtnNuevo = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.CBFolio_Mediacion = New System.Windows.Forms.ComboBox
        Me.MediacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MediacionDataSet2 = New Mediacion.MediacionDataSet2
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnVerLista = New System.Windows.Forms.Button
        Me.MediacionTableAdapter = New Mediacion.MediacionDataSet2TableAdapters.MediacionTableAdapter
        Me.BtnActualizacionM = New System.Windows.Forms.Button
        Me.BtnSDM = New System.Windows.Forms.Button
        Me.BtnISPM = New System.Windows.Forms.Button
        Me.BtnCDC = New System.Windows.Forms.Button
        Me.BtnADM = New System.Windows.Forms.Button
        Me.BtnCNCP = New System.Windows.Forms.Button
        Me.BtnCNCPS = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnCDM = New System.Windows.Forms.Button
        Me.Btn_Imprimir = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewMediacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.MediacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediacionDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblFolioM
        '
        Me.LblFolioM.AutoSize = True
        Me.LblFolioM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFolioM.Location = New System.Drawing.Point(655, 18)
        Me.LblFolioM.Name = "LblFolioM"
        Me.LblFolioM.Size = New System.Drawing.Size(123, 16)
        Me.LblFolioM.TabIndex = 30
        Me.LblFolioM.Text = "Folio Mediacion:"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Location = New System.Drawing.Point(929, 163)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(95, 34)
        Me.BtnGuardar.TabIndex = 29
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'TBFolioMediacion
        '
        Me.TBFolioMediacion.Enabled = False
        Me.TBFolioMediacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBFolioMediacion.Location = New System.Drawing.Point(786, 15)
        Me.TBFolioMediacion.Multiline = True
        Me.TBFolioMediacion.Name = "TBFolioMediacion"
        Me.TBFolioMediacion.Size = New System.Drawing.Size(75, 29)
        Me.TBFolioMediacion.TabIndex = 31
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBEdo_CivilM)
        Me.GroupBox1.Controls.Add(Me.LblEdoCivil)
        Me.GroupBox1.Controls.Add(Me.LblEdoM)
        Me.GroupBox1.Controls.Add(Me.TBEdoM)
        Me.GroupBox1.Controls.Add(Me.TBAsuntoMediacionM)
        Me.GroupBox1.Controls.Add(Me.LblAsuntoM)
        Me.GroupBox1.Controls.Add(Me.TBOcupacionM)
        Me.GroupBox1.Controls.Add(Me.LblOcupacionM)
        Me.GroupBox1.Controls.Add(Me.TBE_mailM)
        Me.GroupBox1.Controls.Add(Me.LblEmailM)
        Me.GroupBox1.Controls.Add(Me.LblCelularM)
        Me.GroupBox1.Controls.Add(Me.TBCelularM)
        Me.GroupBox1.Controls.Add(Me.LblOficinaM)
        Me.GroupBox1.Controls.Add(Me.TBOficinaM)
        Me.GroupBox1.Controls.Add(Me.LblTelefono)
        Me.GroupBox1.Controls.Add(Me.LblNumero)
        Me.GroupBox1.Controls.Add(Me.LblCalle)
        Me.GroupBox1.Controls.Add(Me.TBMunicipioM)
        Me.GroupBox1.Controls.Add(Me.LblMunicipioM)
        Me.GroupBox1.Controls.Add(Me.TBColoniaM)
        Me.GroupBox1.Controls.Add(Me.LblColoniaM)
        Me.GroupBox1.Controls.Add(Me.TBDomicilioM)
        Me.GroupBox1.Controls.Add(Me.LblDomicilioM)
        Me.GroupBox1.Controls.Add(Me.TBNombre_SolicitanteM)
        Me.GroupBox1.Controls.Add(Me.LblNombreSolicitanteM)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 436)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales:"
        '
        'CBEdo_CivilM
        '
        Me.CBEdo_CivilM.FormattingEnabled = True
        Me.CBEdo_CivilM.Items.AddRange(New Object() {"Soltero", "Casado", "Divorciado", "Viudo", "Separado"})
        Me.CBEdo_CivilM.Location = New System.Drawing.Point(80, 299)
        Me.CBEdo_CivilM.Name = "CBEdo_CivilM"
        Me.CBEdo_CivilM.Size = New System.Drawing.Size(91, 21)
        Me.CBEdo_CivilM.TabIndex = 21
        '
        'LblEdoCivil
        '
        Me.LblEdoCivil.AutoSize = True
        Me.LblEdoCivil.Location = New System.Drawing.Point(21, 301)
        Me.LblEdoCivil.Name = "LblEdoCivil"
        Me.LblEdoCivil.Size = New System.Drawing.Size(51, 13)
        Me.LblEdoCivil.TabIndex = 25
        Me.LblEdoCivil.Text = "Edo Civil:"
        '
        'LblEdoM
        '
        Me.LblEdoM.AutoSize = True
        Me.LblEdoM.Location = New System.Drawing.Point(40, 183)
        Me.LblEdoM.Name = "LblEdoM"
        Me.LblEdoM.Size = New System.Drawing.Size(29, 13)
        Me.LblEdoM.TabIndex = 24
        Me.LblEdoM.Text = "Edo:"
        '
        'TBEdoM
        '
        Me.TBEdoM.Location = New System.Drawing.Point(78, 180)
        Me.TBEdoM.Name = "TBEdoM"
        Me.TBEdoM.Size = New System.Drawing.Size(352, 20)
        Me.TBEdoM.TabIndex = 11
        '
        'TBAsuntoMediacionM
        '
        Me.TBAsuntoMediacionM.Location = New System.Drawing.Point(78, 362)
        Me.TBAsuntoMediacionM.Multiline = True
        Me.TBAsuntoMediacionM.Name = "TBAsuntoMediacionM"
        Me.TBAsuntoMediacionM.Size = New System.Drawing.Size(352, 64)
        Me.TBAsuntoMediacionM.TabIndex = 25
        '
        'LblAsuntoM
        '
        Me.LblAsuntoM.AutoSize = True
        Me.LblAsuntoM.Location = New System.Drawing.Point(29, 365)
        Me.LblAsuntoM.Name = "LblAsuntoM"
        Me.LblAsuntoM.Size = New System.Drawing.Size(43, 13)
        Me.LblAsuntoM.TabIndex = 21
        Me.LblAsuntoM.Text = "Asunto:"
        '
        'TBOcupacionM
        '
        Me.TBOcupacionM.Location = New System.Drawing.Point(79, 331)
        Me.TBOcupacionM.Name = "TBOcupacionM"
        Me.TBOcupacionM.Size = New System.Drawing.Size(351, 20)
        Me.TBOcupacionM.TabIndex = 23
        '
        'LblOcupacionM
        '
        Me.LblOcupacionM.AutoSize = True
        Me.LblOcupacionM.Location = New System.Drawing.Point(7, 332)
        Me.LblOcupacionM.Name = "LblOcupacionM"
        Me.LblOcupacionM.Size = New System.Drawing.Size(62, 13)
        Me.LblOcupacionM.TabIndex = 19
        Me.LblOcupacionM.Text = "Ocupacion:"
        '
        'TBE_mailM
        '
        Me.TBE_mailM.Location = New System.Drawing.Point(79, 270)
        Me.TBE_mailM.Name = "TBE_mailM"
        Me.TBE_mailM.Size = New System.Drawing.Size(351, 20)
        Me.TBE_mailM.TabIndex = 18
        '
        'LblEmailM
        '
        Me.LblEmailM.AutoSize = True
        Me.LblEmailM.Location = New System.Drawing.Point(28, 277)
        Me.LblEmailM.Name = "LblEmailM"
        Me.LblEmailM.Size = New System.Drawing.Size(41, 13)
        Me.LblEmailM.TabIndex = 17
        Me.LblEmailM.Text = "E_mail:"
        '
        'LblCelularM
        '
        Me.LblCelularM.AutoSize = True
        Me.LblCelularM.Location = New System.Drawing.Point(84, 243)
        Me.LblCelularM.Name = "LblCelularM"
        Me.LblCelularM.Size = New System.Drawing.Size(42, 13)
        Me.LblCelularM.TabIndex = 16
        Me.LblCelularM.Text = "Celular:"
        '
        'TBCelularM
        '
        Me.TBCelularM.Location = New System.Drawing.Point(148, 240)
        Me.TBCelularM.Name = "TBCelularM"
        Me.TBCelularM.Size = New System.Drawing.Size(263, 20)
        Me.TBCelularM.TabIndex = 15
        '
        'LblOficinaM
        '
        Me.LblOficinaM.AutoSize = True
        Me.LblOficinaM.Location = New System.Drawing.Point(85, 212)
        Me.LblOficinaM.Name = "LblOficinaM"
        Me.LblOficinaM.Size = New System.Drawing.Size(43, 13)
        Me.LblOficinaM.TabIndex = 14
        Me.LblOficinaM.Text = "Oficina:"
        '
        'TBOficinaM
        '
        Me.TBOficinaM.Location = New System.Drawing.Point(149, 209)
        Me.TBOficinaM.Name = "TBOficinaM"
        Me.TBOficinaM.Size = New System.Drawing.Size(262, 20)
        Me.TBOficinaM.TabIndex = 13
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(17, 230)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.LblTelefono.TabIndex = 12
        Me.LblTelefono.Text = "Telefono:"
        '
        'LblNumero
        '
        Me.LblNumero.AutoSize = True
        Me.LblNumero.Location = New System.Drawing.Point(271, 95)
        Me.LblNumero.Name = "LblNumero"
        Me.LblNumero.Size = New System.Drawing.Size(47, 13)
        Me.LblNumero.TabIndex = 11
        Me.LblNumero.Text = "Numero:"
        '
        'LblCalle
        '
        Me.LblCalle.AutoSize = True
        Me.LblCalle.Location = New System.Drawing.Point(119, 95)
        Me.LblCalle.Name = "LblCalle"
        Me.LblCalle.Size = New System.Drawing.Size(33, 13)
        Me.LblCalle.TabIndex = 10
        Me.LblCalle.Text = "Calle:"
        '
        'TBMunicipioM
        '
        Me.TBMunicipioM.Location = New System.Drawing.Point(79, 150)
        Me.TBMunicipioM.Name = "TBMunicipioM"
        Me.TBMunicipioM.Size = New System.Drawing.Size(351, 20)
        Me.TBMunicipioM.TabIndex = 9
        '
        'LblMunicipioM
        '
        Me.LblMunicipioM.AutoSize = True
        Me.LblMunicipioM.Location = New System.Drawing.Point(39, 153)
        Me.LblMunicipioM.Name = "LblMunicipioM"
        Me.LblMunicipioM.Size = New System.Drawing.Size(33, 13)
        Me.LblMunicipioM.TabIndex = 8
        Me.LblMunicipioM.Text = "Mpio:"
        '
        'TBColoniaM
        '
        Me.TBColoniaM.Location = New System.Drawing.Point(79, 118)
        Me.TBColoniaM.Name = "TBColoniaM"
        Me.TBColoniaM.Size = New System.Drawing.Size(351, 20)
        Me.TBColoniaM.TabIndex = 7
        '
        'LblColoniaM
        '
        Me.LblColoniaM.AutoSize = True
        Me.LblColoniaM.Location = New System.Drawing.Point(27, 121)
        Me.LblColoniaM.Name = "LblColoniaM"
        Me.LblColoniaM.Size = New System.Drawing.Size(45, 13)
        Me.LblColoniaM.TabIndex = 6
        Me.LblColoniaM.Text = "Colonia:"
        '
        'TBDomicilioM
        '
        Me.TBDomicilioM.Location = New System.Drawing.Point(78, 72)
        Me.TBDomicilioM.Name = "TBDomicilioM"
        Me.TBDomicilioM.Size = New System.Drawing.Size(352, 20)
        Me.TBDomicilioM.TabIndex = 5
        '
        'LblDomicilioM
        '
        Me.LblDomicilioM.AutoSize = True
        Me.LblDomicilioM.Location = New System.Drawing.Point(20, 75)
        Me.LblDomicilioM.Name = "LblDomicilioM"
        Me.LblDomicilioM.Size = New System.Drawing.Size(52, 13)
        Me.LblDomicilioM.TabIndex = 4
        Me.LblDomicilioM.Text = "Domicilio:"
        '
        'TBNombre_SolicitanteM
        '
        Me.TBNombre_SolicitanteM.Location = New System.Drawing.Point(78, 44)
        Me.TBNombre_SolicitanteM.Name = "TBNombre_SolicitanteM"
        Me.TBNombre_SolicitanteM.Size = New System.Drawing.Size(352, 20)
        Me.TBNombre_SolicitanteM.TabIndex = 1
        '
        'LblNombreSolicitanteM
        '
        Me.LblNombreSolicitanteM.AutoSize = True
        Me.LblNombreSolicitanteM.Location = New System.Drawing.Point(75, 25)
        Me.LblNombreSolicitanteM.Name = "LblNombreSolicitanteM"
        Me.LblNombreSolicitanteM.Size = New System.Drawing.Size(116, 13)
        Me.LblNombreSolicitanteM.TabIndex = 0
        Me.LblNombreSolicitanteM.Text = "Nombre del Solicitante:"
        '
        'LblFechaAsesoria
        '
        Me.LblFechaAsesoria.AutoSize = True
        Me.LblFechaAsesoria.Location = New System.Drawing.Point(44, 15)
        Me.LblFechaAsesoria.Name = "LblFechaAsesoria"
        Me.LblFechaAsesoria.Size = New System.Drawing.Size(98, 13)
        Me.LblFechaAsesoria.TabIndex = 27
        Me.LblFechaAsesoria.Text = "Fecha de Asesoria:"
        '
        'DateTimePickerMediacion
        '
        Me.DateTimePickerMediacion.Location = New System.Drawing.Point(144, 12)
        Me.DateTimePickerMediacion.Name = "DateTimePickerMediacion"
        Me.DateTimePickerMediacion.Size = New System.Drawing.Size(256, 20)
        Me.DateTimePickerMediacion.TabIndex = 26
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CBEdoCivilI)
        Me.GroupBox2.Controls.Add(Me.LblEdoCivilI)
        Me.GroupBox2.Controls.Add(Me.LblEdoI)
        Me.GroupBox2.Controls.Add(Me.TBEdoI)
        Me.GroupBox2.Controls.Add(Me.TBOcupacionI)
        Me.GroupBox2.Controls.Add(Me.LblOcupacionI)
        Me.GroupBox2.Controls.Add(Me.TBEmailI)
        Me.GroupBox2.Controls.Add(Me.LblEmailI)
        Me.GroupBox2.Controls.Add(Me.LblCelularI)
        Me.GroupBox2.Controls.Add(Me.TBCelularI)
        Me.GroupBox2.Controls.Add(Me.LblOficinaI)
        Me.GroupBox2.Controls.Add(Me.TBOficinaI)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TBMpioI)
        Me.GroupBox2.Controls.Add(Me.LblMpioI)
        Me.GroupBox2.Controls.Add(Me.TBColoniaI)
        Me.GroupBox2.Controls.Add(Me.LblColoniaI)
        Me.GroupBox2.Controls.Add(Me.TBDomicilioI)
        Me.GroupBox2.Controls.Add(Me.LblDomicilioI)
        Me.GroupBox2.Controls.Add(Me.TBNombreInvitado)
        Me.GroupBox2.Controls.Add(Me.LblSolicitanteI)
        Me.GroupBox2.Location = New System.Drawing.Point(461, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(445, 337)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos  Invitado"
        '
        'CBEdoCivilI
        '
        Me.CBEdoCivilI.FormattingEnabled = True
        Me.CBEdoCivilI.Items.AddRange(New Object() {"Soltero", "Casado", "Divorciado", "Viudo", "Separado"})
        Me.CBEdoCivilI.Location = New System.Drawing.Point(80, 282)
        Me.CBEdoCivilI.Name = "CBEdoCivilI"
        Me.CBEdoCivilI.Size = New System.Drawing.Size(91, 21)
        Me.CBEdoCivilI.TabIndex = 21
        '
        'LblEdoCivilI
        '
        Me.LblEdoCivilI.AutoSize = True
        Me.LblEdoCivilI.Location = New System.Drawing.Point(21, 284)
        Me.LblEdoCivilI.Name = "LblEdoCivilI"
        Me.LblEdoCivilI.Size = New System.Drawing.Size(51, 13)
        Me.LblEdoCivilI.TabIndex = 25
        Me.LblEdoCivilI.Text = "Edo Civil:"
        '
        'LblEdoI
        '
        Me.LblEdoI.AutoSize = True
        Me.LblEdoI.Location = New System.Drawing.Point(40, 169)
        Me.LblEdoI.Name = "LblEdoI"
        Me.LblEdoI.Size = New System.Drawing.Size(29, 13)
        Me.LblEdoI.TabIndex = 24
        Me.LblEdoI.Text = "Edo:"
        '
        'TBEdoI
        '
        Me.TBEdoI.Location = New System.Drawing.Point(78, 166)
        Me.TBEdoI.Name = "TBEdoI"
        Me.TBEdoI.Size = New System.Drawing.Size(352, 20)
        Me.TBEdoI.TabIndex = 11
        '
        'TBOcupacionI
        '
        Me.TBOcupacionI.Location = New System.Drawing.Point(79, 311)
        Me.TBOcupacionI.Name = "TBOcupacionI"
        Me.TBOcupacionI.Size = New System.Drawing.Size(351, 20)
        Me.TBOcupacionI.TabIndex = 23
        '
        'LblOcupacionI
        '
        Me.LblOcupacionI.AutoSize = True
        Me.LblOcupacionI.Location = New System.Drawing.Point(7, 312)
        Me.LblOcupacionI.Name = "LblOcupacionI"
        Me.LblOcupacionI.Size = New System.Drawing.Size(62, 13)
        Me.LblOcupacionI.TabIndex = 19
        Me.LblOcupacionI.Text = "Ocupacion:"
        '
        'TBEmailI
        '
        Me.TBEmailI.Location = New System.Drawing.Point(79, 252)
        Me.TBEmailI.Name = "TBEmailI"
        Me.TBEmailI.Size = New System.Drawing.Size(351, 20)
        Me.TBEmailI.TabIndex = 18
        '
        'LblEmailI
        '
        Me.LblEmailI.AutoSize = True
        Me.LblEmailI.Location = New System.Drawing.Point(28, 259)
        Me.LblEmailI.Name = "LblEmailI"
        Me.LblEmailI.Size = New System.Drawing.Size(41, 13)
        Me.LblEmailI.TabIndex = 17
        Me.LblEmailI.Text = "E_mail:"
        '
        'LblCelularI
        '
        Me.LblCelularI.AutoSize = True
        Me.LblCelularI.Location = New System.Drawing.Point(84, 222)
        Me.LblCelularI.Name = "LblCelularI"
        Me.LblCelularI.Size = New System.Drawing.Size(42, 13)
        Me.LblCelularI.TabIndex = 16
        Me.LblCelularI.Text = "Celular:"
        '
        'TBCelularI
        '
        Me.TBCelularI.Location = New System.Drawing.Point(148, 222)
        Me.TBCelularI.Name = "TBCelularI"
        Me.TBCelularI.Size = New System.Drawing.Size(263, 20)
        Me.TBCelularI.TabIndex = 15
        '
        'LblOficinaI
        '
        Me.LblOficinaI.AutoSize = True
        Me.LblOficinaI.Location = New System.Drawing.Point(85, 198)
        Me.LblOficinaI.Name = "LblOficinaI"
        Me.LblOficinaI.Size = New System.Drawing.Size(43, 13)
        Me.LblOficinaI.TabIndex = 14
        Me.LblOficinaI.Text = "Oficina:"
        '
        'TBOficinaI
        '
        Me.TBOficinaI.Location = New System.Drawing.Point(149, 195)
        Me.TBOficinaI.Name = "TBOficinaI"
        Me.TBOficinaI.Size = New System.Drawing.Size(262, 20)
        Me.TBOficinaI.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 209)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Telefono:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(249, 87)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Numero:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(171, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Calle:"
        '
        'TBMpioI
        '
        Me.TBMpioI.Location = New System.Drawing.Point(79, 135)
        Me.TBMpioI.Name = "TBMpioI"
        Me.TBMpioI.Size = New System.Drawing.Size(351, 20)
        Me.TBMpioI.TabIndex = 9
        '
        'LblMpioI
        '
        Me.LblMpioI.AutoSize = True
        Me.LblMpioI.Location = New System.Drawing.Point(39, 138)
        Me.LblMpioI.Name = "LblMpioI"
        Me.LblMpioI.Size = New System.Drawing.Size(33, 13)
        Me.LblMpioI.TabIndex = 8
        Me.LblMpioI.Text = "Mpio:"
        '
        'TBColoniaI
        '
        Me.TBColoniaI.Location = New System.Drawing.Point(79, 105)
        Me.TBColoniaI.Name = "TBColoniaI"
        Me.TBColoniaI.Size = New System.Drawing.Size(351, 20)
        Me.TBColoniaI.TabIndex = 7
        '
        'LblColoniaI
        '
        Me.LblColoniaI.AutoSize = True
        Me.LblColoniaI.Location = New System.Drawing.Point(27, 105)
        Me.LblColoniaI.Name = "LblColoniaI"
        Me.LblColoniaI.Size = New System.Drawing.Size(45, 13)
        Me.LblColoniaI.TabIndex = 6
        Me.LblColoniaI.Text = "Colonia:"
        '
        'TBDomicilioI
        '
        Me.TBDomicilioI.Location = New System.Drawing.Point(78, 66)
        Me.TBDomicilioI.Name = "TBDomicilioI"
        Me.TBDomicilioI.Size = New System.Drawing.Size(352, 20)
        Me.TBDomicilioI.TabIndex = 5
        '
        'LblDomicilioI
        '
        Me.LblDomicilioI.AutoSize = True
        Me.LblDomicilioI.Location = New System.Drawing.Point(20, 69)
        Me.LblDomicilioI.Name = "LblDomicilioI"
        Me.LblDomicilioI.Size = New System.Drawing.Size(52, 13)
        Me.LblDomicilioI.TabIndex = 4
        Me.LblDomicilioI.Text = "Domicilio:"
        '
        'TBNombreInvitado
        '
        Me.TBNombreInvitado.Location = New System.Drawing.Point(78, 37)
        Me.TBNombreInvitado.Name = "TBNombreInvitado"
        Me.TBNombreInvitado.Size = New System.Drawing.Size(352, 20)
        Me.TBNombreInvitado.TabIndex = 1
        '
        'LblSolicitanteI
        '
        Me.LblSolicitanteI.AutoSize = True
        Me.LblSolicitanteI.Location = New System.Drawing.Point(75, 21)
        Me.LblSolicitanteI.Name = "LblSolicitanteI"
        Me.LblSolicitanteI.Size = New System.Drawing.Size(102, 13)
        Me.LblSolicitanteI.TabIndex = 0
        Me.LblSolicitanteI.Text = "Nombre del Invitado"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=COLMASQLFDC01\FACDYCDES;Initial Catalog=Mediacion;Integrated Security" & _
            "=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'TBMediadorM
        '
        Me.TBMediadorM.Location = New System.Drawing.Point(540, 410)
        Me.TBMediadorM.Name = "TBMediadorM"
        Me.TBMediadorM.Size = New System.Drawing.Size(351, 20)
        Me.TBMediadorM.TabIndex = 27
        '
        'LblMediadorM
        '
        Me.LblMediadorM.AutoSize = True
        Me.LblMediadorM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMediadorM.Location = New System.Drawing.Point(666, 395)
        Me.LblMediadorM.Name = "LblMediadorM"
        Me.LblMediadorM.Size = New System.Drawing.Size(63, 13)
        Me.LblMediadorM.TabIndex = 26
        Me.LblMediadorM.Text = "Mediador:"
        '
        'DataGridViewMediacion
        '
        Me.DataGridViewMediacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMediacion.Location = New System.Drawing.Point(10, 492)
        Me.DataGridViewMediacion.Name = "DataGridViewMediacion"
        Me.DataGridViewMediacion.Size = New System.Drawing.Size(1013, 225)
        Me.DataGridViewMediacion.TabIndex = 32
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(929, 123)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(93, 35)
        Me.BtnNuevo.TabIndex = 37
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CBFolio_Mediacion)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(913, 49)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(125, 69)
        Me.GroupBox3.TabIndex = 36
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Buscar:"
        '
        'CBFolio_Mediacion
        '
        Me.CBFolio_Mediacion.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MediacionBindingSource, "Folio_Mediacion", True))
        Me.CBFolio_Mediacion.DataSource = Me.MediacionBindingSource
        Me.CBFolio_Mediacion.DisplayMember = "Folio_Mediacion"
        Me.CBFolio_Mediacion.FormattingEnabled = True
        Me.CBFolio_Mediacion.Location = New System.Drawing.Point(16, 41)
        Me.CBFolio_Mediacion.Name = "CBFolio_Mediacion"
        Me.CBFolio_Mediacion.Size = New System.Drawing.Size(96, 21)
        Me.CBFolio_Mediacion.TabIndex = 32
        Me.CBFolio_Mediacion.ValueMember = "Folio_Mediacion"
        '
        'MediacionBindingSource
        '
        Me.MediacionBindingSource.DataMember = "Mediacion"
        Me.MediacionBindingSource.DataSource = Me.MediacionDataSet2
        '
        'MediacionDataSet2
        '
        Me.MediacionDataSet2.DataSetName = "MediacionDataSet2"
        Me.MediacionDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Folio Mediacion:"
        '
        'BtnVerLista
        '
        Me.BtnVerLista.Location = New System.Drawing.Point(834, 458)
        Me.BtnVerLista.Name = "BtnVerLista"
        Me.BtnVerLista.Size = New System.Drawing.Size(72, 28)
        Me.BtnVerLista.TabIndex = 35
        Me.BtnVerLista.Text = " Ver lista"
        Me.BtnVerLista.UseVisualStyleBackColor = True
        '
        'MediacionTableAdapter
        '
        Me.MediacionTableAdapter.ClearBeforeFill = True
        '
        'BtnActualizacionM
        '
        Me.BtnActualizacionM.Enabled = False
        Me.BtnActualizacionM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizacionM.Location = New System.Drawing.Point(929, 200)
        Me.BtnActualizacionM.Name = "BtnActualizacionM"
        Me.BtnActualizacionM.Size = New System.Drawing.Size(97, 35)
        Me.BtnActualizacionM.TabIndex = 38
        Me.BtnActualizacionM.Text = "Actualizacion"
        Me.BtnActualizacionM.UseVisualStyleBackColor = True
        '
        'BtnSDM
        '
        Me.BtnSDM.Enabled = False
        Me.BtnSDM.Location = New System.Drawing.Point(931, 237)
        Me.BtnSDM.Name = "BtnSDM"
        Me.BtnSDM.Size = New System.Drawing.Size(92, 32)
        Me.BtnSDM.TabIndex = 39
        Me.BtnSDM.Text = "SDM"
        Me.ToolTip1.SetToolTip(Me.BtnSDM, "Solicitud de Mediación")
        Me.BtnSDM.UseVisualStyleBackColor = True
        '
        'BtnISPM
        '
        Me.BtnISPM.Enabled = False
        Me.BtnISPM.Location = New System.Drawing.Point(931, 271)
        Me.BtnISPM.Name = "BtnISPM"
        Me.BtnISPM.Size = New System.Drawing.Size(92, 32)
        Me.BtnISPM.TabIndex = 40
        Me.BtnISPM.Text = "ISPM"
        Me.ToolTip1.SetToolTip(Me.BtnISPM, "Invitación de Sesión de Pre_Mediación")
        Me.BtnISPM.UseVisualStyleBackColor = True
        '
        'BtnCDC
        '
        Me.BtnCDC.Enabled = False
        Me.BtnCDC.Location = New System.Drawing.Point(931, 306)
        Me.BtnCDC.Name = "BtnCDC"
        Me.BtnCDC.Size = New System.Drawing.Size(92, 32)
        Me.BtnCDC.TabIndex = 41
        Me.BtnCDC.Text = "CDC"
        Me.ToolTip1.SetToolTip(Me.BtnCDC, "Convenio de Confidencialidad")
        Me.BtnCDC.UseVisualStyleBackColor = True
        '
        'BtnADM
        '
        Me.BtnADM.Enabled = False
        Me.BtnADM.Location = New System.Drawing.Point(931, 340)
        Me.BtnADM.Name = "BtnADM"
        Me.BtnADM.Size = New System.Drawing.Size(92, 32)
        Me.BtnADM.TabIndex = 42
        Me.BtnADM.Text = "ASM"
        Me.BtnADM.UseVisualStyleBackColor = True
        '
        'BtnCNCP
        '
        Me.BtnCNCP.Enabled = False
        Me.BtnCNCP.Location = New System.Drawing.Point(931, 375)
        Me.BtnCNCP.Name = "BtnCNCP"
        Me.BtnCNCP.Size = New System.Drawing.Size(92, 32)
        Me.BtnCNCP.TabIndex = 43
        Me.BtnCNCP.Text = "CNCP"
        Me.BtnCNCP.UseVisualStyleBackColor = True
        '
        'BtnCNCPS
        '
        Me.BtnCNCPS.Enabled = False
        Me.BtnCNCPS.Location = New System.Drawing.Point(931, 410)
        Me.BtnCNCPS.Name = "BtnCNCPS"
        Me.BtnCNCPS.Size = New System.Drawing.Size(92, 32)
        Me.BtnCNCPS.TabIndex = 44
        Me.BtnCNCPS.Text = "CNCP'S"
        Me.BtnCNCPS.UseVisualStyleBackColor = True
        '
        'BtnCDM
        '
        Me.BtnCDM.Enabled = False
        Me.BtnCDM.Location = New System.Drawing.Point(932, 446)
        Me.BtnCDM.Name = "BtnCDM"
        Me.BtnCDM.Size = New System.Drawing.Size(92, 32)
        Me.BtnCDM.TabIndex = 45
        Me.BtnCDM.Text = "CDM"
        Me.BtnCDM.UseVisualStyleBackColor = True
        '
        'Btn_Imprimir
        '
        Me.Btn_Imprimir.Enabled = False
        Me.Btn_Imprimir.Location = New System.Drawing.Point(753, 458)
        Me.Btn_Imprimir.Name = "Btn_Imprimir"
        Me.Btn_Imprimir.Size = New System.Drawing.Size(75, 28)
        Me.Btn_Imprimir.TabIndex = 46
        Me.Btn_Imprimir.Text = "Imprimir"
        Me.Btn_Imprimir.UseVisualStyleBackColor = True
        '
        'Mediar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 731)
        Me.Controls.Add(Me.Btn_Imprimir)
        Me.Controls.Add(Me.BtnCDM)
        Me.Controls.Add(Me.BtnCNCPS)
        Me.Controls.Add(Me.BtnCNCP)
        Me.Controls.Add(Me.BtnADM)
        Me.Controls.Add(Me.BtnCDC)
        Me.Controls.Add(Me.BtnISPM)
        Me.Controls.Add(Me.BtnSDM)
        Me.Controls.Add(Me.BtnActualizacionM)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BtnVerLista)
        Me.Controls.Add(Me.DataGridViewMediacion)
        Me.Controls.Add(Me.TBMediadorM)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LblMediadorM)
        Me.Controls.Add(Me.LblFolioM)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.TBFolioMediacion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblFechaAsesoria)
        Me.Controls.Add(Me.DateTimePickerMediacion)
        Me.Name = "Mediar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mediacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridViewMediacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.MediacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediacionDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblFolioM As System.Windows.Forms.Label
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents TBFolioMediacion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CBEdo_CivilM As System.Windows.Forms.ComboBox
    Friend WithEvents LblEdoCivil As System.Windows.Forms.Label
    Friend WithEvents LblEdoM As System.Windows.Forms.Label
    Friend WithEvents TBEdoM As System.Windows.Forms.TextBox
    Friend WithEvents TBAsuntoMediacionM As System.Windows.Forms.TextBox
    Friend WithEvents LblAsuntoM As System.Windows.Forms.Label
    Friend WithEvents TBOcupacionM As System.Windows.Forms.TextBox
    Friend WithEvents LblOcupacionM As System.Windows.Forms.Label
    Friend WithEvents TBE_mailM As System.Windows.Forms.TextBox
    Friend WithEvents LblEmailM As System.Windows.Forms.Label
    Friend WithEvents LblCelularM As System.Windows.Forms.Label
    Friend WithEvents TBCelularM As System.Windows.Forms.TextBox
    Friend WithEvents LblOficinaM As System.Windows.Forms.Label
    Friend WithEvents TBOficinaM As System.Windows.Forms.TextBox
    Friend WithEvents LblTelefono As System.Windows.Forms.Label
    Friend WithEvents LblNumero As System.Windows.Forms.Label
    Friend WithEvents LblCalle As System.Windows.Forms.Label
    Friend WithEvents TBMunicipioM As System.Windows.Forms.TextBox
    Friend WithEvents LblMunicipioM As System.Windows.Forms.Label
    Friend WithEvents TBColoniaM As System.Windows.Forms.TextBox
    Friend WithEvents LblColoniaM As System.Windows.Forms.Label
    Friend WithEvents TBDomicilioM As System.Windows.Forms.TextBox
    Friend WithEvents LblDomicilioM As System.Windows.Forms.Label
    Friend WithEvents TBNombre_SolicitanteM As System.Windows.Forms.TextBox
    Friend WithEvents LblNombreSolicitanteM As System.Windows.Forms.Label
    Friend WithEvents LblFechaAsesoria As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerMediacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CBEdoCivilI As System.Windows.Forms.ComboBox
    Friend WithEvents LblEdoCivilI As System.Windows.Forms.Label
    Friend WithEvents LblEdoI As System.Windows.Forms.Label
    Friend WithEvents TBEdoI As System.Windows.Forms.TextBox
    Friend WithEvents TBOcupacionI As System.Windows.Forms.TextBox
    Friend WithEvents LblOcupacionI As System.Windows.Forms.Label
    Friend WithEvents TBEmailI As System.Windows.Forms.TextBox
    Friend WithEvents LblEmailI As System.Windows.Forms.Label
    Friend WithEvents LblCelularI As System.Windows.Forms.Label
    Friend WithEvents TBCelularI As System.Windows.Forms.TextBox
    Friend WithEvents LblOficinaI As System.Windows.Forms.Label
    Friend WithEvents TBOficinaI As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TBMpioI As System.Windows.Forms.TextBox
    Friend WithEvents LblMpioI As System.Windows.Forms.Label
    Friend WithEvents TBColoniaI As System.Windows.Forms.TextBox
    Friend WithEvents LblColoniaI As System.Windows.Forms.Label
    Friend WithEvents TBDomicilioI As System.Windows.Forms.TextBox
    Friend WithEvents LblDomicilioI As System.Windows.Forms.Label
    Friend WithEvents TBNombreInvitado As System.Windows.Forms.TextBox
    Friend WithEvents LblSolicitanteI As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents TBMediadorM As System.Windows.Forms.TextBox
    Friend WithEvents LblMediadorM As System.Windows.Forms.Label
    Friend WithEvents DataGridViewMediacion As System.Windows.Forms.DataGridView
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CBFolio_Mediacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnVerLista As System.Windows.Forms.Button
    Friend WithEvents MediacionDataSet2 As Mediacion.MediacionDataSet2
    Friend WithEvents MediacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MediacionTableAdapter As Mediacion.MediacionDataSet2TableAdapters.MediacionTableAdapter
    Friend WithEvents BtnActualizacionM As System.Windows.Forms.Button
    Friend WithEvents BtnSDM As System.Windows.Forms.Button
    Friend WithEvents BtnISPM As System.Windows.Forms.Button
    Friend WithEvents BtnCDC As System.Windows.Forms.Button
    Friend WithEvents BtnADM As System.Windows.Forms.Button
    Friend WithEvents BtnCNCP As System.Windows.Forms.Button
    Friend WithEvents BtnCNCPS As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BtnCDM As System.Windows.Forms.Button
    Friend WithEvents Btn_Imprimir As System.Windows.Forms.Button
End Class
