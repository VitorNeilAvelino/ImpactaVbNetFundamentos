Imports Microsoft.Reporting.WinForms
Imports Impacta.Infra.Repositorios.SistemaDeArquivos

Public Class RelatorioClientesForm
    Private Sub RelatorioClientesForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        clientesReportViewer.LocalReport.DataSources.Add(New ReportDataSource("clientesDataSet", New ClienteRepositorio().Selecionar()))
        Me.clientesReportViewer.RefreshReport()
    End Sub
End Class