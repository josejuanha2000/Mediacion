<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Litigio
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
        Me.LblNombreSolicitante = New System.Windows.Forms.Label
        Me.TBNombre_Solicitante_Litigio = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.LblFechaAsesoria = New System.Windows.Forms.Label
        Me.TBDomicilio = New System.Windows.Forms.TextBox
        Me.LblDomicilio = New System.Windows.Forms.Label
        Me.TBColonia = New System.Windows.Forms.TextBox
        Me.LblColonia = New System.Windows.Forms.Label
        Me.TBMunicipio = New System.Windows.Forms.TextBox
        Me.LblMunicipio = New System.Windows.Forms.Label
        Me.LblCalle = New System.Windows.Forms.Label
        Me.LblNumero = New System.Windows.Forms.Label
        Me.TBOficina = New System.Windows.Forms.TextBox
        Me.LblTelefono = New System.Windows.Forms.Label
        Me.LblOficina = New System.Windows.Forms.Label
        Me.LblCelular = New System.Windows.Forms.Label
        Me.TBCelular = New System.Windows.Forms.TextBox
        Me.TBE_mail = New System.Windows.Forms.TextBox
        Me.LblEmail = New System.Windows.Forms.Label
        Me.TBOcupacion = New System.Windows.Forms.TextBox
        Me.LblOcupacion = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CBEdo_Civil = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TBEdo = New System.Windows.Forms.TextBox
        Me.TBAsuntoLitigio = New System.Windows.Forms.TextBox
        Me.LblAsunto = New System.Windows.Forms.Label
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.LblFolio = New System.Windows.Forms.Label
        Me.TBFolioLitigio = New System.Windows.Forms.TextBox
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.TBMediadorL = New System.Windows.Forms.TextBox
        Me.LblMediadorL = New System.Windows.Forms.Label
        Me.DataGridViewLitigio = New System.Windows.Forms.DataGridView
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnVerLista = New System.Windows.Forms.Button
        Me.CBFolio_Litigio = New System.Windows.Forms.ComboBox
        Me.LitigioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MediacionDataSet = New Mediacion.MediacionDataSet
        Me.LitigioTableAdapter = New Mediacion.MediacionDataSetTableAdapters.LitigioTableAdapter
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnNuevo = New System.Windows.Forms.Button
        Me.BtnActualizar = New System.Windows.Forms.Button
        Me.BtnImprimir = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewLitigio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LitigioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediacionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblNombreSolicitante
        '
        Me.LblNombreSolicitante.AutoSize = True
        Me.LblNombreSolicitante.Location = New System.Drawing.Point(17, 27)
        Me.LblNombreSolicitante.Name = "LblNombreSolicitante"
        Me.LblNombreSolicitante.Size = New System.Drawing.Size(116, 13)
        Me.LblNombreSolicitante.TabIndex = 0
        Me.LblNombreSolicitante.Text = "Nombre del Solicitante:"
        '
        'TBNombre_Solicitante_Litigio
        '
        Me.TBNombre_Solicitante_Litigio.Location = New System.Drawing.Point(139, 27)
        Me.TBNombre_Solicitante_Litigio.Name = "TBNombre_Solicitante_Litigio"
        Me.TBNombre_Solicitante_Litigio.Size = New System.Drawing.Size(430, 20)
        Me.TBNombre_Solicitante_Litigio.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(193, 9)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(256, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'LblFechaAsesoria
        '
        Me.LblFechaAsesoria.AutoSize = True
        Me.LblFechaAsesoria.Location = New System.Drawing.Point(93, 12)
        Me.LblFechaAsesoria.Name = "LblFechaAsesoria"
        Me.LblFechaAsesoria.Size = New System.Drawing.Size(98, 13)
        Me.LblFechaAsesoria.TabIndex = 3
        Me.LblFechaAsesoria.Text = "Fecha de Asesoria:"
        '
        'TBDomicilio
        '
        Me.TBDomicilio.Location = New System.Drawing.Point(139, 59)
        Me.TBDomicilio.Name = "TBDomicilio"
        Me.TBDomicilio.Size = New System.Drawing.Size(430, 20)
        Me.TBDomicilio.TabIndex = 5
        '
        'LblDomicilio
        '
        Me.LblDomicilio.AutoSize = True
        Me.LblDomicilio.Location = New System.Drawing.Point(81, 62)
        Me.LblDomicilio.Name = "LblDomicilio"
        Me.LblDomicilio.Size = New System.Drawing.Size(52, 13)
        Me.LblDomicilio.TabIndex = 4
        Me.LblDomicilio.Text = "Domicilio:"
        '
        'TBColonia
        '
        Me.TBColonia.Location = New System.Drawing.Point(140, 110)
        Me.TBColonia.Name = "TBColonia"
        Me.TBColonia.Size = New System.Drawing.Size(429, 20)
        Me.TBColonia.TabIndex = 7
        '
        'LblColonia
        '
        Me.LblColonia.AutoSize = True
        Me.LblColonia.Location = New System.Drawing.Point(88, 110)
        Me.LblColonia.Name = "LblColonia"
        Me.LblColonia.Size = New System.Drawing.Size(45, 13)
        Me.LblColonia.TabIndex = 6
        Me.LblColonia.Text = "Colonia:"
        '
        'TBMunicipio
        '
        Me.TBMunicipio.Location = New System.Drawing.Point(140, 146)
        Me.TBMunicipio.Name = "TBMunicipio"
        Me.TBMunicipio.Size = New System.Drawing.Size(429, 20)
        Me.TBMunicipio.TabIndex = 9
        '
        'LblMunicipio
        '
        Me.LblMunicipio.AutoSize = True
        Me.LblMunicipio.Location = New System.Drawing.Point(100, 149)
        Me.LblMunicipio.Name = "LblMunicipio"
        Me.LblMunicipio.Size = New System.Drawing.Size(33, 13)
        Me.LblMunicipio.TabIndex = 8
        Me.LblMunicipio.Text = "Mpio:"
        '
        'LblCalle
        '
        Me.LblCalle.AutoSize = True
        Me.LblCalle.Location = New System.Drawing.Point(180, 83)
        Me.LblCalle.Name = "LblCalle"
        Me.LblCalle.Size = New System.Drawing.Size(33, 13)
        Me.LblCalle.TabIndex = 10
        Me.LblCalle.Text = "Calle:"
        '
        'LblNumero
        '
        Me.LblNumero.AutoSize = True
        Me.LblNumero.Location = New System.Drawing.Point(258, 83)
        Me.LblNumero.Name = "LblNumero"
        Me.LblNumero.Size = New System.Drawing.Size(47, 13)
        Me.LblNumero.TabIndex = 11
        Me.LblNumero.Text = "Numero:"
        '
        'TBOficina
        '
        Me.TBOficina.Location = New System.Drawing.Point(210, 215)
        Me.TBOficina.Name = "TBOficina"
        Me.TBOficina.Size = New System.Drawing.Size(359, 20)
        Me.TBOficina.TabIndex = 13
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(78, 236)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.LblTelefono.TabIndex = 12
        Me.LblTelefono.Text = "Telefono:"
        '
        'LblOficina
        '
        Me.LblOficina.AutoSize = True
        Me.LblOficina.Location = New System.Drawing.Point(146, 218)
        Me.LblOficina.Name = "LblOficina"
        Me.LblOficina.Size = New System.Drawing.Size(43, 13)
        Me.LblOficina.TabIndex = 14
        Me.LblOficina.Text = "Oficina:"
        '
        'LblCelular
        '
        Me.LblCelular.AutoSize = True
        Me.LblCelular.Location = New System.Drawing.Point(145, 253)
        Me.LblCelular.Name = "LblCelular"
        Me.LblCelular.Size = New System.Drawing.Size(42, 13)
        Me.LblCelular.TabIndex = 16
        Me.LblCelular.Text = "Celular:"
        '
        'TBCelular
        '
        Me.TBCelular.Location = New System.Drawing.Point(209, 250)
        Me.TBCelular.Name = "TBCelular"
        Me.TBCelular.Size = New System.Drawing.Size(360, 20)
        Me.TBCelular.TabIndex = 15
        '
        'TBE_mail
        '
        Me.TBE_mail.Location = New System.Drawing.Point(140, 290)
        Me.TBE_mail.Name = "TBE_mail"
        Me.TBE_mail.Size = New System.Drawing.Size(429, 20)
        Me.TBE_mail.TabIndex = 18
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Location = New System.Drawing.Point(89, 297)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(41, 13)
        Me.LblEmail.TabIndex = 17
        Me.LblEmail.Text = "E_mail:"
        '
        'TBOcupacion
        '
        Me.TBOcupacion.Location = New System.Drawing.Point(140, 364)
        Me.TBOcupacion.Name = "TBOcupacion"
        Me.TBOcupacion.Size = New System.Drawing.Size(429, 20)
        Me.TBOcupacion.TabIndex = 23
        '
        'LblOcupacion
        '
        Me.LblOcupacion.AutoSize = True
        Me.LblOcupacion.Location = New System.Drawing.Point(68, 365)
        Me.LblOcupacion.Name = "LblOcupacion"
        Me.LblOcupacion.Size = New System.Drawing.Size(62, 13)
        Me.LblOcupacion.TabIndex = 19
        Me.LblOcupacion.Text = "Ocupacion:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBEdo_Civil)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TBEdo)
        Me.GroupBox1.Controls.Add(Me.TBAsuntoLitigio)
        Me.GroupBox1.Controls.Add(Me.LblAsunto)
        Me.GroupBox1.Controls.Add(Me.TBOcupacion)
        Me.GroupBox1.Controls.Add(Me.LblOcupacion)
        Me.GroupBox1.Controls.Add(Me.TBE_mail)
        Me.GroupBox1.Controls.Add(Me.LblEmail)
        Me.GroupBox1.Controls.Add(Me.LblCelular)
        Me.GroupBox1.Controls.Add(Me.TBCelular)
        Me.GroupBox1.Controls.Add(Me.LblOficina)
        Me.GroupBox1.Controls.Add(Me.TBOficina)
        Me.GroupBox1.Controls.Add(Me.LblTelefono)
        Me.GroupBox1.Controls.Add(Me.LblNumero)
        Me.GroupBox1.Controls.Add(Me.LblCalle)
        Me.GroupBox1.Controls.Add(Me.TBMunicipio)
        Me.GroupBox1.Controls.Add(Me.LblMunicipio)
        Me.GroupBox1.Controls.Add(Me.TBColonia)
        Me.GroupBox1.Controls.Add(Me.LblColonia)
        Me.GroupBox1.Controls.Add(Me.TBDomicilio)
        Me.GroupBox1.Controls.Add(Me.LblDomicilio)
        Me.GroupBox1.Controls.Add(Me.TBNombre_Solicitante_Litigio)
        Me.GroupBox1.Controls.Add(Me.LblNombreSolicitante)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(624, 522)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales:"
        '
        'CBEdo_Civil
        '
        Me.CBEdo_Civil.FormattingEnabled = True
        Me.CBEdo_Civil.Items.AddRange(New Object() {"Soltero", "Casado", "Divorciado", "Viudo", "Separado"})
        Me.CBEdo_Civil.Location = New System.Drawing.Point(141, 330)
        Me.CBEdo_Civil.Name = "CBEdo_Civil"
        Me.CBEdo_Civil.Size = New System.Drawing.Size(91, 21)
        Me.CBEdo_Civil.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 332)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Edo Civil:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Edo:"
        '
        'TBEdo
        '
        Me.TBEdo.Location = New System.Drawing.Point(139, 177)
        Me.TBEdo.Name = "TBEdo"
        Me.TBEdo.Size = New System.Drawing.Size(430, 20)
        Me.TBEdo.TabIndex = 11
        '
        'TBAsuntoLitigio
        '
        Me.TBAsuntoLitigio.Location = New System.Drawing.Point(139, 400)
        Me.TBAsuntoLitigio.Multiline = True
        Me.TBAsuntoLitigio.Name = "TBAsuntoLitigio"
        Me.TBAsuntoLitigio.Size = New System.Drawing.Size(430, 64)
        Me.TBAsuntoLitigio.TabIndex = 25
        '
        'LblAsunto
        '
        Me.LblAsunto.AutoSize = True
        Me.LblAsunto.Location = New System.Drawing.Point(90, 403)
        Me.LblAsunto.Name = "LblAsunto"
        Me.LblAsunto.Size = New System.Drawing.Size(43, 13)
        Me.LblAsunto.TabIndex = 21
        Me.LblAsunto.Text = "Asunto:"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.Location = New System.Drawing.Point(671, 225)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(96, 52)
        Me.BtnGuardar.TabIndex = 22
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'LblFolio
        '
        Me.LblFolio.AutoSize = True
        Me.LblFolio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFolio.Location = New System.Drawing.Point(483, 15)
        Me.LblFolio.Name = "LblFolio"
        Me.LblFolio.Size = New System.Drawing.Size(73, 13)
        Me.LblFolio.TabIndex = 24
        Me.LblFolio.Text = "Folio Litigo:"
        '
        'TBFolioLitigio
        '
        Me.TBFolioLitigio.Enabled = False
        Me.TBFolioLitigio.Location = New System.Drawing.Point(573, 12)
        Me.TBFolioLitigio.Name = "TBFolioLitigio"
        Me.TBFolioLitigio.Size = New System.Drawing.Size(75, 20)
        Me.TBFolioLitigio.TabIndex = 25
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=COLMASQLFDC01\FACDYCDES;Initial Catalog=Mediacion;Integrated Security" & _
            "=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'TBMediadorL
        '
        Me.TBMediadorL.Location = New System.Drawing.Point(88, 525)
        Me.TBMediadorL.Name = "TBMediadorL"
        Me.TBMediadorL.Size = New System.Drawing.Size(375, 20)
        Me.TBMediadorL.TabIndex = 27
        '
        'LblMediadorL
        '
        Me.LblMediadorL.AutoSize = True
        Me.LblMediadorL.Location = New System.Drawing.Point(16, 526)
        Me.LblMediadorL.Name = "LblMediadorL"
        Me.LblMediadorL.Size = New System.Drawing.Size(53, 13)
        Me.LblMediadorL.TabIndex = 26
        Me.LblMediadorL.Text = "Abogado:"
        '
        'DataGridViewLitigio
        '
        Me.DataGridViewLitigio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewLitigio.Location = New System.Drawing.Point(10, 570)
        Me.DataGridViewLitigio.Name = "DataGridViewLitigio"
        Me.DataGridViewLitigio.Size = New System.Drawing.Size(782, 150)
        Me.DataGridViewLitigio.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Folio Litigo:"
        '
        'BtnVerLista
        '
        Me.BtnVerLista.Location = New System.Drawing.Point(695, 536)
        Me.BtnVerLista.Name = "BtnVerLista"
        Me.BtnVerLista.Size = New System.Drawing.Size(72, 28)
        Me.BtnVerLista.TabIndex = 31
        Me.BtnVerLista.Text = " Ver lista"
        Me.BtnVerLista.UseVisualStyleBackColor = True
        '
        'CBFolio_Litigio
        '
        Me.CBFolio_Litigio.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LitigioBindingSource, "Folio_Litigio", True))
        Me.CBFolio_Litigio.DataSource = Me.LitigioBindingSource
        Me.CBFolio_Litigio.DisplayMember = "Folio_Litigio"
        Me.CBFolio_Litigio.FormattingEnabled = True
        Me.CBFolio_Litigio.Location = New System.Drawing.Point(31, 44)
        Me.CBFolio_Litigio.Name = "CBFolio_Litigio"
        Me.CBFolio_Litigio.Size = New System.Drawing.Size(96, 21)
        Me.CBFolio_Litigio.TabIndex = 32
        Me.CBFolio_Litigio.ValueMember = "Folio_Litigio"
        '
        'LitigioBindingSource
        '
        Me.LitigioBindingSource.DataMember = "Litigio"
        Me.LitigioBindingSource.DataSource = Me.MediacionDataSet
        '
        'MediacionDataSet
        '
        Me.MediacionDataSet.DataSetName = "MediacionDataSet"
        Me.MediacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LitigioTableAdapter
        '
        Me.LitigioTableAdapter.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CBFolio_Litigio)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(640, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(152, 90)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar:"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(671, 160)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(96, 48)
        Me.BtnNuevo.TabIndex = 34
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Enabled = False
        Me.BtnActualizar.Location = New System.Drawing.Point(671, 300)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(96, 52)
        Me.BtnActualizar.TabIndex = 35
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Enabled = False
        Me.BtnImprimir.Location = New System.Drawing.Point(671, 389)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(96, 52)
        Me.BtnImprimir.TabIndex = 36
        Me.BtnImprimir.Text = "Imprimir"
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'Litigio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 734)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnVerLista)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.DataGridViewLitigio)
        Me.Controls.Add(Me.TBMediadorL)
        Me.Controls.Add(Me.LblMediadorL)
        Me.Controls.Add(Me.LblFolio)
        Me.Controls.Add(Me.TBFolioLitigio)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblFechaAsesoria)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "Litigio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Litigio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewLitigio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LitigioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediacionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblNombreSolicitante As System.Windows.Forms.Label
    Friend WithEvents TBNombre_Solicitante_Litigio As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFechaAsesoria As System.Windows.Forms.Label
    Friend WithEvents TBDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents LblDomicilio As System.Windows.Forms.Label
    Friend WithEvents TBColonia As System.Windows.Forms.TextBox
    Friend WithEvents LblColonia As System.Windows.Forms.Label
    Friend WithEvents TBMunicipio As System.Windows.Forms.TextBox
    Friend WithEvents LblMunicipio As System.Windows.Forms.Label
    Friend WithEvents LblCalle As System.Windows.Forms.Label
    Friend WithEvents LblNumero As System.Windows.Forms.Label
    Friend WithEvents TBOficina As System.Windows.Forms.TextBox
    Friend WithEvents LblTelefono As System.Windows.Forms.Label
    Friend WithEvents LblOficina As System.Windows.Forms.Label
    Friend WithEvents LblCelular As System.Windows.Forms.Label
    Friend WithEvents TBCelular As System.Windows.Forms.TextBox
    Friend WithEvents TBE_mail As System.Windows.Forms.TextBox
    Friend WithEvents LblEmail As System.Windows.Forms.Label
    Friend WithEvents TBOcupacion As System.Windows.Forms.TextBox
    Friend WithEvents LblOcupacion As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents TBAsuntoLitigio As System.Windows.Forms.TextBox
    Friend WithEvents LblAsunto As System.Windows.Forms.Label
    Friend WithEvents LblFolio As System.Windows.Forms.Label
    Friend WithEvents TBFolioLitigio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBEdo As System.Windows.Forms.TextBox
    Friend WithEvents CBEdo_Civil As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents TBMediadorL As System.Windows.Forms.TextBox
    Friend WithEvents LblMediadorL As System.Windows.Forms.Label
    Friend WithEvents DataGridViewLitigio As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnVerLista As System.Windows.Forms.Button
    Friend WithEvents CBFolio_Litigio As System.Windows.Forms.ComboBox
    Friend WithEvents MediacionDataSet As Mediacion.MediacionDataSet
    Friend WithEvents LitigioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LitigioTableAdapter As Mediacion.MediacionDataSetTableAdapters.LitigioTableAdapter
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents BtnImprimir As System.Windows.Forms.Button
End Class
