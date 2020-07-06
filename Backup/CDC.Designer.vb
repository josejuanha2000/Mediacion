<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CDC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CDC))
        Me.Label1 = New System.Windows.Forms.Label
        Me.LlCDV = New System.Windows.Forms.Label
        Me.CBDia = New System.Windows.Forms.ComboBox
        Me.CBMes = New System.Windows.Forms.ComboBox
        Me.CBAño = New System.Windows.Forms.ComboBox
        Me.TBNombre_M1 = New System.Windows.Forms.TextBox
        Me.TBNombre_M2 = New System.Windows.Forms.TextBox
        Me.TBSolicitante = New System.Windows.Forms.TextBox
        Me.TBSolicitado = New System.Windows.Forms.TextBox
        Me.TBMediador = New System.Windows.Forms.TextBox
        Me.BtnGuardarCDC = New System.Windows.Forms.Button
        Me.BtnActualizarCDC = New System.Windows.Forms.Button
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.TBNombre_M3 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(164, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CONVENIO DE CONFIDENCIALIDAD"
        '
        'LlCDV
        '
        Me.LlCDV.AutoSize = True
        Me.LlCDV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LlCDV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LlCDV.Location = New System.Drawing.Point(33, 66)
        Me.LlCDV.Name = "LlCDV"
        Me.LlCDV.Size = New System.Drawing.Size(609, 530)
        Me.LlCDV.TabIndex = 2
        Me.LlCDV.Text = resources.GetString("LlCDV.Text")
        '
        'CBDia
        '
        Me.CBDia.FormattingEnabled = True
        Me.CBDia.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.CBDia.Location = New System.Drawing.Point(361, 91)
        Me.CBDia.Name = "CBDia"
        Me.CBDia.Size = New System.Drawing.Size(52, 21)
        Me.CBDia.TabIndex = 3
        '
        'CBMes
        '
        Me.CBMes.FormattingEnabled = True
        Me.CBMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.CBMes.Location = New System.Drawing.Point(431, 90)
        Me.CBMes.Name = "CBMes"
        Me.CBMes.Size = New System.Drawing.Size(103, 21)
        Me.CBMes.TabIndex = 4
        '
        'CBAño
        '
        Me.CBAño.FormattingEnabled = True
        Me.CBAño.Items.AddRange(New Object() {"2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.CBAño.Location = New System.Drawing.Point(568, 91)
        Me.CBAño.Name = "CBAño"
        Me.CBAño.Size = New System.Drawing.Size(55, 21)
        Me.CBAño.TabIndex = 5
        '
        'TBNombre_M1
        '
        Me.TBNombre_M1.Location = New System.Drawing.Point(38, 204)
        Me.TBNombre_M1.Name = "TBNombre_M1"
        Me.TBNombre_M1.Size = New System.Drawing.Size(257, 20)
        Me.TBNombre_M1.TabIndex = 6
        '
        'TBNombre_M2
        '
        Me.TBNombre_M2.Location = New System.Drawing.Point(308, 204)
        Me.TBNombre_M2.Name = "TBNombre_M2"
        Me.TBNombre_M2.Size = New System.Drawing.Size(253, 20)
        Me.TBNombre_M2.TabIndex = 7
        '
        'TBSolicitante
        '
        Me.TBSolicitante.Location = New System.Drawing.Point(42, 442)
        Me.TBSolicitante.Name = "TBSolicitante"
        Me.TBSolicitante.Size = New System.Drawing.Size(272, 20)
        Me.TBSolicitante.TabIndex = 9
        '
        'TBSolicitado
        '
        Me.TBSolicitado.Location = New System.Drawing.Point(361, 441)
        Me.TBSolicitado.Name = "TBSolicitado"
        Me.TBSolicitado.Size = New System.Drawing.Size(269, 20)
        Me.TBSolicitado.TabIndex = 10
        '
        'TBMediador
        '
        Me.TBMediador.Location = New System.Drawing.Point(216, 522)
        Me.TBMediador.Name = "TBMediador"
        Me.TBMediador.Size = New System.Drawing.Size(292, 20)
        Me.TBMediador.TabIndex = 11
        '
        'BtnGuardarCDC
        '
        Me.BtnGuardarCDC.Enabled = False
        Me.BtnGuardarCDC.Location = New System.Drawing.Point(68, 612)
        Me.BtnGuardarCDC.Name = "BtnGuardarCDC"
        Me.BtnGuardarCDC.Size = New System.Drawing.Size(112, 32)
        Me.BtnGuardarCDC.TabIndex = 12
        Me.BtnGuardarCDC.Text = "Guardar"
        Me.BtnGuardarCDC.UseVisualStyleBackColor = True
        '
        'BtnActualizarCDC
        '
        Me.BtnActualizarCDC.Enabled = False
        Me.BtnActualizarCDC.Location = New System.Drawing.Point(509, 612)
        Me.BtnActualizarCDC.Name = "BtnActualizarCDC"
        Me.BtnActualizarCDC.Size = New System.Drawing.Size(112, 32)
        Me.BtnActualizarCDC.TabIndex = 13
        Me.BtnActualizarCDC.Text = "Actualizar"
        Me.BtnActualizarCDC.UseVisualStyleBackColor = True
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=COLMASQLFDC01\FACDYCDES;Initial Catalog=Mediacion;Integrated Security" & _
            "=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'TBNombre_M3
        '
        Me.TBNombre_M3.Location = New System.Drawing.Point(231, 226)
        Me.TBNombre_M3.Name = "TBNombre_M3"
        Me.TBNombre_M3.Size = New System.Drawing.Size(330, 20)
        Me.TBNombre_M3.TabIndex = 8
        '
        'CDC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 661)
        Me.Controls.Add(Me.TBNombre_M3)
        Me.Controls.Add(Me.BtnActualizarCDC)
        Me.Controls.Add(Me.BtnGuardarCDC)
        Me.Controls.Add(Me.TBMediador)
        Me.Controls.Add(Me.TBSolicitado)
        Me.Controls.Add(Me.TBSolicitante)
        Me.Controls.Add(Me.TBNombre_M2)
        Me.Controls.Add(Me.TBNombre_M1)
        Me.Controls.Add(Me.CBAño)
        Me.Controls.Add(Me.CBMes)
        Me.Controls.Add(Me.CBDia)
        Me.Controls.Add(Me.LlCDV)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CDC"
        Me.Text = "CDC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LlCDV As System.Windows.Forms.Label
    Friend WithEvents CBDia As System.Windows.Forms.ComboBox
    Friend WithEvents CBMes As System.Windows.Forms.ComboBox
    Friend WithEvents CBAño As System.Windows.Forms.ComboBox
    Friend WithEvents TBNombre_M1 As System.Windows.Forms.TextBox
    Friend WithEvents TBNombre_M2 As System.Windows.Forms.TextBox
    Friend WithEvents TBSolicitante As System.Windows.Forms.TextBox
    Friend WithEvents TBSolicitado As System.Windows.Forms.TextBox
    Friend WithEvents TBMediador As System.Windows.Forms.TextBox
    Friend WithEvents BtnGuardarCDC As System.Windows.Forms.Button
    Friend WithEvents BtnActualizarCDC As System.Windows.Forms.Button
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents TBNombre_M3 As System.Windows.Forms.TextBox
End Class
