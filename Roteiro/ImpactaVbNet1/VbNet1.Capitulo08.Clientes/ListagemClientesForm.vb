Imports Impacta.Infra.Repositorios.SistemaDeArquivos

Public Class ListagemClientesForm

    Private Sub ListagemClientesForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        clientesDataGridView.DataSource = New ClienteRepositorio().Selecionar()
    End Sub
End Class