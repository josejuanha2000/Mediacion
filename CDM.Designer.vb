<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CDM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CDM))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbl_CDM = New System.Windows.Forms.Label()
        Me.TBDia_CDM = New System.Windows.Forms.TextBox()
        Me.TBMes_CDM = New System.Windows.Forms.TextBox()
        Me.TBComparece_CDM = New System.Windows.Forms.TextBox()
        Me.TBDomicilio_CDM = New System.Windows.Forms.TextBox()
        Me.TBMunicipio_CDM = New System.Windows.Forms.TextBox()
        Me.TBElector_CDM = New System.Windows.Forms.TextBox()
        Me.TBCcomparece2_CDM = New System.Windows.Forms.TextBox()
        Me.TBCalle_CDM = New System.Windows.Forms.TextBox()
        Me.TBNumero_CDM = New System.Windows.Forms.TextBox()
        Me.TBMunicipio2_cdm = New System.Windows.Forms.TextBox()
        Me.TBElector2_CDM = New System.Windows.Forms.TextBox()
        Me.TBAntecedentes1_CDM = New System.Windows.Forms.TextBox()
        Me.TBAntecedentes2_CDM = New System.Windows.Forms.TextBox()
        Me.TBClausulaSegunda_CDM = New System.Windows.Forms.TextBox()
        Me.TBClausulaPrimera_CDM = New System.Windows.Forms.TextBox()
        Me.TBClausulaTerecera_CDM = New System.Windows.Forms.TextBox()
        Me.TBEnterado1 = New System.Windows.Forms.TextBox()
        Me.TBEnterado2 = New System.Windows.Forms.TextBox()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.BtnGuardar_CDM = New System.Windows.Forms.Button()
        Me.BtnActualizar_CDM = New System.Windows.Forms.Button()
        Me.CrystalOpenFileDialog1 = New CrystalDecisions.[Shared].Interop.CrystalOpenFileDialog()
        Me.BtnImpCDM = New System.Windows.Forms.Button()
        Me.TBFolio_CDM = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(269, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CENTRO DE LITIGACIÓN Y MEDIACIÓN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(312, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CENVENIO DE MEDIACION"
        '
        'Lbl_CDM
        '
        Me.Lbl_CDM.AutoSize = True
        Me.Lbl_CDM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_CDM.Location = New System.Drawing.Point(22, 64)
        Me.Lbl_CDM.Name = "Lbl_CDM"
        Me.Lbl_CDM.Size = New System.Drawing.Size(725, 780)
        Me.Lbl_CDM.TabIndex = 3
        Me.Lbl_CDM.Text = resources.GetString("Lbl_CDM.Text")
        '
        'TBDia_CDM
        '
        Me.TBDia_CDM.Location = New System.Drawing.Point(293, 70)
        Me.TBDia_CDM.Name = "TBDia_CDM"
        Me.TBDia_CDM.Size = New System.Drawing.Size(140, 20)
        Me.TBDia_CDM.TabIndex = 4
        '
        'TBMes_CDM
        '
        Me.TBMes_CDM.Location = New System.Drawing.Point(473, 70)
        Me.TBMes_CDM.Name = "TBMes_CDM"
        Me.TBMes_CDM.Size = New System.Drawing.Size(234, 20)
        Me.TBMes_CDM.TabIndex = 5
        '
        'TBComparece_CDM
        '
        Me.TBComparece_CDM.Location = New System.Drawing.Point(177, 146)
        Me.TBComparece_CDM.Name = "TBComparece_CDM"
        Me.TBComparece_CDM.Size = New System.Drawing.Size(234, 20)
        Me.TBComparece_CDM.TabIndex = 6
        '
        'TBDomicilio_CDM
        '
        Me.TBDomicilio_CDM.Location = New System.Drawing.Point(552, 146)
        Me.TBDomicilio_CDM.Name = "TBDomicilio_CDM"
        Me.TBDomicilio_CDM.Size = New System.Drawing.Size(154, 20)
        Me.TBDomicilio_CDM.TabIndex = 7
        '
        'TBMunicipio_CDM
        '
        Me.TBMunicipio_CDM.Location = New System.Drawing.Point(110, 176)
        Me.TBMunicipio_CDM.Name = "TBMunicipio_CDM"
        Me.TBMunicipio_CDM.Size = New System.Drawing.Size(273, 20)
        Me.TBMunicipio_CDM.TabIndex = 8
        '
        'TBElector_CDM
        '
        Me.TBElector_CDM.Location = New System.Drawing.Point(94, 206)
        Me.TBElector_CDM.Name = "TBElector_CDM"
        Me.TBElector_CDM.Size = New System.Drawing.Size(231, 20)
        Me.TBElector_CDM.TabIndex = 9
        '
        'TBCcomparece2_CDM
        '
        Me.TBCcomparece2_CDM.Location = New System.Drawing.Point(60, 237)
        Me.TBCcomparece2_CDM.Name = "TBCcomparece2_CDM"
        Me.TBCcomparece2_CDM.Size = New System.Drawing.Size(232, 20)
        Me.TBCcomparece2_CDM.TabIndex = 10
        '
        'TBCalle_CDM
        '
        Me.TBCalle_CDM.Location = New System.Drawing.Point(431, 237)
        Me.TBCalle_CDM.Name = "TBCalle_CDM"
        Me.TBCalle_CDM.Size = New System.Drawing.Size(295, 20)
        Me.TBCalle_CDM.TabIndex = 11
        '
        'TBNumero_CDM
        '
        Me.TBNumero_CDM.Location = New System.Drawing.Point(76, 266)
        Me.TBNumero_CDM.Name = "TBNumero_CDM"
        Me.TBNumero_CDM.Size = New System.Drawing.Size(277, 20)
        Me.TBNumero_CDM.TabIndex = 12
        '
        'TBMunicipio2_cdm
        '
        Me.TBMunicipio2_cdm.Location = New System.Drawing.Point(50, 298)
        Me.TBMunicipio2_cdm.Name = "TBMunicipio2_cdm"
        Me.TBMunicipio2_cdm.Size = New System.Drawing.Size(291, 20)
        Me.TBMunicipio2_cdm.TabIndex = 13
        '
        'TBElector2_CDM
        '
        Me.TBElector2_CDM.Location = New System.Drawing.Point(114, 327)
        Me.TBElector2_CDM.Name = "TBElector2_CDM"
        Me.TBElector2_CDM.Size = New System.Drawing.Size(207, 20)
        Me.TBElector2_CDM.TabIndex = 14
        '
        'TBAntecedentes1_CDM
        '
        Me.TBAntecedentes1_CDM.Location = New System.Drawing.Point(25, 427)
        Me.TBAntecedentes1_CDM.Multiline = True
        Me.TBAntecedentes1_CDM.Name = "TBAntecedentes1_CDM"
        Me.TBAntecedentes1_CDM.Size = New System.Drawing.Size(691, 55)
        Me.TBAntecedentes1_CDM.TabIndex = 15
        '
        'TBAntecedentes2_CDM
        '
        Me.TBAntecedentes2_CDM.Location = New System.Drawing.Point(23, 500)
        Me.TBAntecedentes2_CDM.Multiline = True
        Me.TBAntecedentes2_CDM.Name = "TBAntecedentes2_CDM"
        Me.TBAntecedentes2_CDM.Size = New System.Drawing.Size(693, 52)
        Me.TBAntecedentes2_CDM.TabIndex = 16
        '
        'TBClausulaSegunda_CDM
        '
        Me.TBClausulaSegunda_CDM.Location = New System.Drawing.Point(226, 694)
        Me.TBClausulaSegunda_CDM.Multiline = True
        Me.TBClausulaSegunda_CDM.Name = "TBClausulaSegunda_CDM"
        Me.TBClausulaSegunda_CDM.Size = New System.Drawing.Size(490, 22)
        Me.TBClausulaSegunda_CDM.TabIndex = 18
        '
        'TBClausulaPrimera_CDM
        '
        Me.TBClausulaPrimera_CDM.Location = New System.Drawing.Point(25, 635)
        Me.TBClausulaPrimera_CDM.Multiline = True
        Me.TBClausulaPrimera_CDM.Name = "TBClausulaPrimera_CDM"
        Me.TBClausulaPrimera_CDM.Size = New System.Drawing.Size(691, 37)
        Me.TBClausulaPrimera_CDM.TabIndex = 17
        '
        'TBClausulaTerecera_CDM
        '
        Me.TBClausulaTerecera_CDM.Location = New System.Drawing.Point(98, 724)
        Me.TBClausulaTerecera_CDM.Multiline = True
        Me.TBClausulaTerecera_CDM.Name = "TBClausulaTerecera_CDM"
        Me.TBClausulaTerecera_CDM.Size = New System.Drawing.Size(618, 50)
        Me.TBClausulaTerecera_CDM.TabIndex = 19
        '
        'TBEnterado1
        '
        Me.TBEnterado1.Location = New System.Drawing.Point(60, 807)
        Me.TBEnterado1.Multiline = True
        Me.TBEnterado1.Name = "TBEnterado1"
        Me.TBEnterado1.Size = New System.Drawing.Size(281, 22)
        Me.TBEnterado1.TabIndex = 20
        '
        'TBEnterado2
        '
        Me.TBEnterado2.Location = New System.Drawing.Point(406, 807)
        Me.TBEnterado2.Multiline = True
        Me.TBEnterado2.Name = "TBEnterado2"
        Me.TBEnterado2.Size = New System.Drawing.Size(310, 22)
        Me.TBEnterado2.TabIndex = 21
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=148.234.110.22;Initial Catalog=Mediacion;Persist Security Info=True;U" &
    "ser ID=sa;Password=Facdyc2020"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'BtnGuardar_CDM
        '
        Me.BtnGuardar_CDM.Enabled = False
        Me.BtnGuardar_CDM.Location = New System.Drawing.Point(733, 427)
        Me.BtnGuardar_CDM.Name = "BtnGuardar_CDM"
        Me.BtnGuardar_CDM.Size = New System.Drawing.Size(107, 43)
        Me.BtnGuardar_CDM.TabIndex = 22
        Me.BtnGuardar_CDM.Text = "Guardar"
        Me.BtnGuardar_CDM.UseVisualStyleBackColor = True
        '
        'BtnActualizar_CDM
        '
        Me.BtnActualizar_CDM.Enabled = False
        Me.BtnActualizar_CDM.Location = New System.Drawing.Point(733, 500)
        Me.BtnActualizar_CDM.Name = "BtnActualizar_CDM"
        Me.BtnActualizar_CDM.Size = New System.Drawing.Size(107, 39)
        Me.BtnActualizar_CDM.TabIndex = 23
        Me.BtnActualizar_CDM.Text = "Actualizar"
        Me.BtnActualizar_CDM.UseVisualStyleBackColor = True
        '
        'CrystalOpenFileDialog1
        '
        Me.CrystalOpenFileDialog1.FileName = "CrystalOpenFileDialog1"
        '
        'BtnImpCDM
        '
        Me.BtnImpCDM.Location = New System.Drawing.Point(733, 567)
        Me.BtnImpCDM.Name = "BtnImpCDM"
        Me.BtnImpCDM.Size = New System.Drawing.Size(107, 36)
        Me.BtnImpCDM.TabIndex = 24
        Me.BtnImpCDM.Text = "Imprimir"
        Me.BtnImpCDM.UseVisualStyleBackColor = True
        '
        'TBFolio_CDM
        '
        Me.TBFolio_CDM.Enabled = False
        Me.TBFolio_CDM.Location = New System.Drawing.Point(637, 31)
        Me.TBFolio_CDM.Name = "TBFolio_CDM"
        Me.TBFolio_CDM.Size = New System.Drawing.Size(69, 20)
        Me.TBFolio_CDM.TabIndex = 25
        '
        'CDM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 841)
        Me.Controls.Add(Me.TBFolio_CDM)
        Me.Controls.Add(Me.BtnImpCDM)
        Me.Controls.Add(Me.BtnActualizar_CDM)
        Me.Controls.Add(Me.BtnGuardar_CDM)
        Me.Controls.Add(Me.TBEnterado2)
        Me.Controls.Add(Me.TBEnterado1)
        Me.Controls.Add(Me.TBClausulaTerecera_CDM)
        Me.Controls.Add(Me.TBClausulaPrimera_CDM)
        Me.Controls.Add(Me.TBClausulaSegunda_CDM)
        Me.Controls.Add(Me.TBAntecedentes2_CDM)
        Me.Controls.Add(Me.TBAntecedentes1_CDM)
        Me.Controls.Add(Me.TBElector2_CDM)
        Me.Controls.Add(Me.TBMunicipio2_cdm)
        Me.Controls.Add(Me.TBNumero_CDM)
        Me.Controls.Add(Me.TBCalle_CDM)
        Me.Controls.Add(Me.TBCcomparece2_CDM)
        Me.Controls.Add(Me.TBElector_CDM)
        Me.Controls.Add(Me.TBMunicipio_CDM)
        Me.Controls.Add(Me.TBDomicilio_CDM)
        Me.Controls.Add(Me.TBComparece_CDM)
        Me.Controls.Add(Me.TBMes_CDM)
        Me.Controls.Add(Me.TBDia_CDM)
        Me.Controls.Add(Me.Lbl_CDM)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CDM"
        Me.Text = "Convenio de Mediacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_CDM As System.Windows.Forms.Label
    Friend WithEvents TBDia_CDM As System.Windows.Forms.TextBox
    Friend WithEvents TBMes_CDM As System.Windows.Forms.TextBox
    Friend WithEvents TBComparece_CDM As System.Windows.Forms.TextBox
    Friend WithEvents TBDomicilio_CDM As System.Windows.Forms.TextBox
    Friend WithEvents TBMunicipio_CDM As System.Windows.Forms.TextBox
    Friend WithEvents TBElector_CDM As System.Windows.Forms.TextBox
    Friend WithEvents TBCcomparece2_CDM As System.Windows.Forms.TextBox
    Friend WithEvents TBCalle_CDM As System.Windows.Forms.TextBox
    Friend WithEvents TBNumero_CDM As System.Windows.Forms.TextBox
    Friend WithEvents TBMunicipio2_cdm As System.Windows.Forms.TextBox
    Friend WithEvents TBElector2_CDM As System.Windows.Forms.TextBox
    Friend WithEvents TBAntecedentes1_CDM As System.Windows.Forms.TextBox
    Friend WithEvents TBAntecedentes2_CDM As System.Windows.Forms.TextBox
    Friend WithEvents TBClausulaSegunda_CDM As System.Windows.Forms.TextBox
    Friend WithEvents TBClausulaPrimera_CDM As System.Windows.Forms.TextBox
    Friend WithEvents TBClausulaTerecera_CDM As System.Windows.Forms.TextBox
    Friend WithEvents TBEnterado1 As System.Windows.Forms.TextBox
    Friend WithEvents TBEnterado2 As System.Windows.Forms.TextBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents BtnGuardar_CDM As System.Windows.Forms.Button
    Friend WithEvents BtnActualizar_CDM As System.Windows.Forms.Button
    Friend WithEvents CrystalOpenFileDialog1 As CrystalDecisions.Shared.Interop.CrystalOpenFileDialog
    Friend WithEvents BtnImpCDM As System.Windows.Forms.Button
    Friend WithEvents TBFolio_CDM As System.Windows.Forms.TextBox
End Class
