<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REP_MEDIACION
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
        Me.CR_Mediacion = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CR_Mediacion
        '
        Me.CR_Mediacion.ActiveViewIndex = -1
        Me.CR_Mediacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CR_Mediacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.CR_Mediacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CR_Mediacion.Location = New System.Drawing.Point(0, 0)
        Me.CR_Mediacion.Name = "CR_Mediacion"
        Me.CR_Mediacion.SelectionFormula = ""
        Me.CR_Mediacion.Size = New System.Drawing.Size(805, 773)
        Me.CR_Mediacion.TabIndex = 0
        Me.CR_Mediacion.ViewTimeSelectionFormula = ""
        '
        'REP_MEDIACION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 773)
        Me.Controls.Add(Me.CR_Mediacion)
        Me.Name = "REP_MEDIACION"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CR_Mediacion As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
