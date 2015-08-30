Imports System.IO

Public Class ClientesForm

    Private Sub gravarButton_Click(sender As System.Object, e As System.EventArgs) Handles gravarButton.Click
        '1. Validar
        If Not ValidarFormulario() Then
            Return
            'Dim x = 42
        End If

        '2. Gravar
        GravarCliente()
        MessageBox.Show("Cliente gravado com sucesso!")
        '3. Limpar
        LimparFormulario()
        nomeTextBox.Focus()
    End Sub

    Private Function ValidarFormulario() As Boolean
        If nomeTextBox.Text.Trim() = "" Then
            MessageBox.Show("O campo Nome é obrigatório.", "Validação",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            nomeTextBox.Focus()
            Return False
        End If

        If enderecoTextBox.Text.Trim() = String.Empty Then
            MessageBox.Show("O campo Endereço é obrigatório.", "Validação",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            enderecoTextBox.Focus()
            Return False
        End If

        If Not masculinoRadioButton.Checked AndAlso _
            Not femininoRadioButton.Checked Then
            MessageBox.Show("Selecione o Sexo.", "Validação",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If estadoCivilComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Selecione o Estado Civil.", "Validação",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            estadoCivilComboBox.Focus()
            SendKeys.Send("{F4}")
            Return False
        End If

        If paisListBox.SelectedIndex = -1 Then
            MessageBox.Show("Selecione o País.", "Validação",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            paisListBox.Focus()
            'SendKeys.Send("{F4}")
            Return False
        End If

        Return True
    End Function

    Private Sub GravarCliente()
        Dim caminho As String = "C:\Cliente.txt"
        Dim registro = String.Format("{0};{1};{2};{3};{4};{5};{6}",
                                        nomeTextBox.Text,
                                        enderecoTextBox.Text.Replace(";", ","),
                                        If(masculinoRadioButton.Checked, "M", "F"),
                                        estadoCivilComboBox.Text,
                                        If(preferencialCheckBox.Checked, "1", "0"),
                                        paisListBox.Text,
                                        DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"))

        'Dim arquivoTexto as New StreamWriter()
        Using arquivoTexto = New StreamWriter(caminho, True)
            arquivoTexto.WriteLine(registro)
            'arquivoTexto.Close()
        End Using
    End Sub

    Private Sub LimparFormulario()
        nomeTextBox.Text = ""
        nomeTextBox.Text = Nothing
        enderecoTextBox.Text = String.Empty
        enderecoTextBox.Clear()

        masculinoRadioButton.Checked = False
        femininoRadioButton.Checked = False
        preferencialCheckBox.Checked = False

        estadoCivilComboBox.SelectedIndex = -1
        paisListBox.SelectedIndex = -1
        'paisListBox.Text = "" ' não funciona
    End Sub

    Private Sub limparButton_Click(sender As System.Object, e As System.EventArgs) Handles limparButton.Click
        LimparFormulario()
    End Sub

    Private Sub ajudaLinkLabel_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ajudaLinkLabel.LinkClicked
        Process.Start("www.google.com")
        'Process.GetProcessesByName("").First().Kill()
    End Sub
End Class
