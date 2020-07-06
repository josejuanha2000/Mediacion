<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Mediacion
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
        Me.BtnMediacion = New System.Windows.Forms.Button
        Me.BtnLitigio = New System.Windows.Forms.Button
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'BtnMediacion
        '
        Me.BtnMediacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMediacion.Image = Global.Mediacion.My.Resources.Resources.Mediacion
        Me.BtnMediacion.Location = New System.Drawing.Point(342, 41)
        Me.BtnMediacion.Name = "BtnMediacion"
        Me.BtnMediacion.Size = New System.Drawing.Size(241, 278)
        Me.BtnMediacion.TabIndex = 0
        Me.BtnMediacion.Text = "Mediación"
        Me.BtnMediacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnMediacion.UseVisualStyleBackColor = True
        '
        'BtnLitigio
        '
        Me.BtnLitigio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLitigio.Image = Global.Mediacion.My.Resources.Resources.litigio
        Me.BtnLitigio.Location = New System.Drawing.Point(54, 41)
        Me.BtnLitigio.Name = "BtnLitigio"
        Me.BtnLitigio.Size = New System.Drawing.Size(230, 278)
        Me.BtnLitigio.TabIndex = 1
        Me.BtnLitigio.Text = "Litigio"
        Me.BtnLitigio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnLitigio.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(256, 396)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(149, 50)
        Me.BtnSalir.TabIndex = 2
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(467, 502)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "FACDYC"
        '
        'Menu_Mediacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 549)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnLitigio)
        Me.Controls.Add(Me.BtnMediacion)
        Me.Name = "Menu_Mediacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mediacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnMediacion As System.Windows.Forms.Button
    Friend WithEvents BtnLitigio As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
