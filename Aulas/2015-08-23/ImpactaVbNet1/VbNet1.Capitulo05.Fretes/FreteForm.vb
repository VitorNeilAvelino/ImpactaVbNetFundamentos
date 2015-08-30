Imports System.IO
Imports Impacta.Apoio
Imports Impacta.Dominio
Imports Impacta.Repositorios.SistemaArquivos

Public Class FreteForm
    Private _caminho As String = "C:\Frete.txt"

    Private Sub calcularButton_Click(sender As System.Object, e As System.EventArgs) Handles calcularButton.Click
        'Dim formularioApoio = New Formulario()
        
        If Not Formulario.ValidarCamposObrigatorios(Me, freteErrorProvider) OrElse
            Not Formulario.ValidarTipoDados(Me, freteErrorProvider) Then
            Return
        End If

        Dim frete As New Frete(valorTextBox.Text, ufComboBox.Text)
        frete.Cliente = DirectCast(clienteComboBox.SelectedItem, Cliente)
        'frete.Valor = valorTextBox.Text
        'frete.Uf = ufComboBox.Text
        'frete.Calcular()

        percentualTextBox.Text = frete.Percentual.ToString("P2")
        totalTextBox.Text = frete.Total.ToString("C")

        Try
            Call New FreteRepositorio().Inserir(frete)
            MessageBox.Show("Frete gravado com sucesso!")
            Formulario.Limpar(Me)
            clienteComboBox.Focus()
        Catch ex As DirectoryNotFoundException
            MessageBox.Show(String.Format("O caminho {0} não foi encontrado. A gravação não foi realizada.", _caminho))
        Catch ex As UnauthorizedAccessException
            MessageBox.Show(String.Format("Desmarque a opção de Somente Leitura do arquivo {0}. A gravação não foi realizada.", _caminho))
        Catch ex As Exception
            MessageBox.Show("Oops! Houve um erro na aplicação e a gravação NÃO foi realizada. Um email foi enviado para a equipe de suporte e em breve teremos uma solução.")
            'Logar.PorEmail(ex)
            'Finally
        End Try
    End Sub

    Private Sub limparButton_Click(sender As System.Object, e As System.EventArgs) Handles limparButton.Click

    End Sub

    Private Sub FreteForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PopularControles()
    End Sub

    Private Sub PopularControles()
        clienteComboBox.DisplayMember = "Nome"
        clienteComboBox.ValueMember = "Id"

        'Dim repositorio = New ClienteRepositorio()
        'clienteComboBox.DataSource = repositorio.Selecionar()
        clienteComboBox.DataSource = New ClienteRepositorio().Selecionar()

        clienteComboBox.SelectedIndex = -1
    End Sub
End Class
