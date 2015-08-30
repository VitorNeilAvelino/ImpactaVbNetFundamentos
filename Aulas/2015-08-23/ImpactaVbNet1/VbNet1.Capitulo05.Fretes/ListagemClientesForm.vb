Imports Impacta.Repositorios.SistemaArquivos

Public Class ListagemClientesForm

    Private Sub ListagemClientesForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim repositorio = New ClienteRepositorio()
        clientesDataGridView.DataSource = repositorio.Selecionar()
    End Sub
End Class