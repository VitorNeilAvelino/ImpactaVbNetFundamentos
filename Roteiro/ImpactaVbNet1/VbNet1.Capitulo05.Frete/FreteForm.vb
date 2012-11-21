Imports Impacta.Infra.Apoio
Imports Impacta.Infra.Repositorios.SistemaDeArquivos

Public Class FreteForm
    Private Sub Calcular()
        Dim frete = New Impacta.Dominio.Frete()

        frete.ValorCarga = Convert.ToDecimal(valorTextBox.Text)
        frete.Calcular(ufComboBox.Text)

        freteLabel.Text = frete.PercentualFrete.ToString("P1")
        totalLabel.Text = frete.ValorTotal.ToString("C2")
    End Sub

    Private Sub gravarButton_Click(sender As System.Object, e As EventArgs) Handles gravarButton.Click
        'Validar
        If Not Formulario.ValidarCamposObrigatorios(Me, freteErrorProvider) OrElse Not Formulario.ValidarTipoDosDados(Me, freteErrorProvider) Then
            Return
        End If

        'Calcular
        'Call Calcular()
        Calcular()

        'Gravar
        Dim registro = String.Format("{0};{1};{2};{3};{4}",
                                     clienteTextBox.Text,
                                     valorTextBox.Text,
                                    ufComboBox.Text,
                                    freteLabel.Text,
                                    totalLabel.Text)
        TextoPuroRepositorio.Inserir(My.MySettings.Default.caminhoArquivoFretes, registro)
        MessageBox.Show("Gravação realizada com sucesso.")

        'Limpar
        Formulario.Limpar(Me)
        freteLabel.Text = "0,0%"
        totalLabel.Text = "0,00"
    End Sub

    Private Sub FreteForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DefinirPropriedadesControles()
    End Sub

    Private Sub DefinirPropriedadesControles()
        clienteBindingSource.DataSource = New ClienteRepositorio().Selecionar()
        clienteComboBox.SelectedIndex = -1
    End Sub
End Class
