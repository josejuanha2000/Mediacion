Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports System
Imports System.ComponentModel

Public Class FOR_CDM
    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Dim FORMA_CDM As New CRCDM
        CrystalReportViewer1.ReportSource = FORMA_CDM
        CrystalReportViewer1.RefreshReport()
    End Sub
End Class