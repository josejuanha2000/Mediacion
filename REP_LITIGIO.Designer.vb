<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REP_LITIGIO
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
        Me.CR_LITIGIO = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CR_LITIGIO
        '
        Me.CR_LITIGIO.ActiveViewIndex = -1
        Me.CR_LITIGIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CR_LITIGIO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CR_LITIGIO.Location = New System.Drawing.Point(0, 0)
        Me.CR_LITIGIO.Name = "CR_LITIGIO"
        Me.CR_LITIGIO.SelectionFormula = ""
        Me.CR_LITIGIO.Size = New System.Drawing.Size(796, 592)
        Me.CR_LITIGIO.TabIndex = 0
        Me.CR_LITIGIO.ViewTimeSelectionFormula = ""
        '
        'REP_LITIGIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 592)
        Me.Controls.Add(Me.CR_LITIGIO)
        Me.Name = "REP_LITIGIO"
        Me.Text = "REP_LITIGIO"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CR_LITIGIO As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
