Imports Impacta.Dominio
Imports Impacta.Infra.Apoio
Imports Impacta.Infra.Repositorios.SistemaDeArquivos
Imports System.IO
Imports System.Configuration

Public Class ClientesForm
    Implements IFormularioComErrorProvider

    Private ReadOnly Property Caminho As String
        Get
            Return ConfigurationManager.AppSettings("caminhoArquivoClientes")
        End Get
    End Property

    Private Sub gravarButton_Click(sender As System.Object, e As EventArgs) Handles gravarButton.Click
        If Not Formulario.ValidarCamposObrigatorios(Me) OrElse Not Formulario.ValidarTipoDosDados(Me, clientesErrorProvider) Then
            Return
        End If

        Dim cliente As New Cliente()
        'Dim pessoa As New Pessoa()

        cliente.DataNascimento = nascimentoMaskedTextBox.Text

        Dim documento = New Documento
        documento.Tipo = TipoDocumento.Cpf
        documento.Numero = cpfMaskedTextBox.Text
        cliente.Documentos.Add(documento)

        cliente.Email = emailTextBox.Text
        cliente.Endereco = enderecoTextBox.Text
        cliente.Nome = nomeTextBox.Text
        cliente.Renda = rendaTextBox.Text

        Try
            cliente.Validar()
            Call New ClienteRepositorio().Gravar(cliente)

            MessageBox.Show("Gravação realizada com sucesso")
            Formulario.Limpar(Me)
        Catch ex As DirectoryNotFoundException
            MessageBox.Show(String.Format("O caminho {0} não foi encontrado. A gravação não foi realizada.", Caminho))
        Catch ex As UnauthorizedAccessException
            MessageBox.Show(String.Format("Desmarque a opção de Somente Leitura do arquivo {0}. A gravação não foi realizada.", Caminho))
        Catch ex As RegraNegocioException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show("Oops! Houve um erro na aplicação e a gravação NÃO foi realizada. Um email foi enviado para a equipe de suporte e em breve teremos uma solução.")
            Logar.PorEmail(ex)
            'Finally
        End Try
    End Sub

    Public ReadOnly Property ProvedorDeErro As System.Windows.Forms.ErrorProvider Implements Impacta.Infra.Apoio.IFormularioComErrorProvider.ProvedorDeErro
        Get
            Return clientesErrorProvider
        End Get
    End Property
End Class