<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISPM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ISPM))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePickerISPM = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBEstimado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.TBCiudadano = New System.Windows.Forms.TextBox()
        Me.TBDia = New System.Windows.Forms.TextBox()
        Me.TBHora = New System.Windows.Forms.TextBox()
        Me.BtnGuardarISPM = New System.Windows.Forms.Button()
        Me.BtnActualizarISPM = New System.Windows.Forms.Button()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(124, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(389, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INVITACION DE SESION DE PRE-MEDIACION"
        '
        'DateTimePickerISPM
        '
        Me.DateTimePickerISPM.Location = New System.Drawing.Point(72, 57)
        Me.DateTimePickerISPM.Name = "DateTimePickerISPM"
        Me.DateTimePickerISPM.Size = New System.Drawing.Size(256, 20)
        Me.DateTimePickerISPM.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Fecha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Estimado(a) Señor(a):"
        '
        'TBEstimado
        '
        Me.TBEstimado.Location = New System.Drawing.Point(161, 114)
        Me.TBEstimado.Name = "TBEstimado"
        Me.TBEstimado.Size = New System.Drawing.Size(287, 20)
        Me.TBEstimado.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 32
        '
        'Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl.Location = New System.Drawing.Point(29, 146)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(554, 354)
        Me.Lbl.TabIndex = 36
        Me.Lbl.Text = resources.GetString("Lbl.Text")
        '
        'TBCiudadano
        '
        Me.TBCiudadano.Location = New System.Drawing.Point(32, 188)
        Me.TBCiudadano.Name = "TBCiudadano"
        Me.TBCiudadano.Size = New System.Drawing.Size(273, 20)
        Me.TBCiudadano.TabIndex = 37
        '
        'TBDia
        '
        Me.TBDia.Location = New System.Drawing.Point(470, 319)
        Me.TBDia.Multiline = True
        Me.TBDia.Name = "TBDia"
        Me.TBDia.Size = New System.Drawing.Size(79, 17)
        Me.TBDia.TabIndex = 38
        '
        'TBHora
        '
        Me.TBHora.Location = New System.Drawing.Point(147, 333)
        Me.TBHora.Multiline = True
        Me.TBHora.Name = "TBHora"
        Me.TBHora.Size = New System.Drawing.Size(44, 20)
        Me.TBHora.TabIndex = 39
        '
        'BtnGuardarISPM
        '
        Me.BtnGuardarISPM.Enabled = False
        Me.BtnGuardarISPM.Location = New System.Drawing.Point(95, 538)
        Me.BtnGuardarISPM.Name = "BtnGuardarISPM"
        Me.BtnGuardarISPM.Size = New System.Drawing.Size(72, 40)
        Me.BtnGuardarISPM.TabIndex = 40
        Me.BtnGuardarISPM.Text = "Guardar"
        Me.BtnGuardarISPM.UseVisualStyleBackColor = True
        '
        'BtnActualizarISPM
        '
        Me.BtnActualizarISPM.Enabled = False
        Me.BtnActualizarISPM.Location = New System.Drawing.Point(473, 538)
        Me.BtnActualizarISPM.Name = "BtnActualizarISPM"
        Me.BtnActualizarISPM.Size = New System.Drawing.Size(72, 40)
        Me.BtnActualizarISPM.TabIndex = 41
        Me.BtnActualizarISPM.Text = "Actualizar"
        Me.BtnActualizarISPM.UseVisualStyleBackColor = True
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=148.234.110.22;Initial Catalog=Mediacion;Persist Security Info=True;U" &
    "ser ID=sa;Password=Facdyc2020"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'ISPM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 590)
        Me.Controls.Add(Me.BtnActualizarISPM)
        Me.Controls.Add(Me.BtnGuardarISPM)
        Me.Controls.Add(Me.TBHora)
        Me.Controls.Add(Me.TBDia)
        Me.Controls.Add(Me.TBCiudadano)
        Me.Controls.Add(Me.Lbl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TBEstimado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePickerISPM)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ISPM"
        Me.Text = "Invitacion de Sesión de Pre-Mediación"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerISPM As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TBEstimado As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Lbl As System.Windows.Forms.Label
    Friend WithEvents TBCiudadano As System.Windows.Forms.TextBox
    Friend WithEvents TBDia As System.Windows.Forms.TextBox
    Friend WithEvents TBHora As System.Windows.Forms.TextBox
    Friend WithEvents BtnGuardarISPM As System.Windows.Forms.Button
    Friend WithEvents BtnActualizarISPM As System.Windows.Forms.Button
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
End Class
