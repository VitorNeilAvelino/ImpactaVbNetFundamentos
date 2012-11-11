Imports Impacta.Infra.Repositorios.SistemaDeArquivos
Imports Microsoft.Reporting.WinForms

Partial Public Class ListagemCliente
    Inherits BaseForm

    Private _visualizadorRelatorios As New VisualizadorRelatoriosForm()

    Private Sub ListagemCliente_Load(sender As System.Object, e As EventArgs) Handles MyBase.Load
        VincularDados()
    End Sub

    Public Sub VincularDados()
        clientesDataGridView.DataSource = New ClienteRepositorio().Selecionar()
    End Sub

    Private Sub imprimirToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles imprimirToolStripButton.Click
        If _visualizadorRelatorios.geralReportViewer.IsDisposed Then
            _visualizadorRelatorios.geralReportViewer = New ReportViewer()
        End If

        If _visualizadorRelatorios.IsDisposed Then
            _visualizadorRelatorios = New VisualizadorRelatoriosForm()
        End If

        _visualizadorRelatorios.geralReportViewer.LocalReport.ReportEmbeddedResource = "VbNet1.Capitulo03.Clientes.ClientesReport.rdlc"
        _visualizadorRelatorios.geralReportViewer.LocalReport.DataSources.Add(New ReportDataSource("clienteDataSet", New ClienteRepositorio().Selecionar()))
        _visualizadorRelatorios.geralReportViewer.RefreshReport()
        _visualizadorRelatorios.Show()
    End Sub
End Class