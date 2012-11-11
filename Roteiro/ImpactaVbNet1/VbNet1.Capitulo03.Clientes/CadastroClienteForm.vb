'Option Strict On
Imports System.IO
'Namespace x

Public Class CadastroClienteForm
    Inherits BaseForm
    Private Sub gravarButton_Click(sender As System.Object, e As EventArgs) Handles gravarButton.Click
        'Validar
        'If Not ValidarFormulario() Then
        '    Return
        'End If
        If Not ValidarFormulario() Then Return

        'Gravar
        GravarCliente()
        MessageBox.Show("Cliente gravado com sucesso!")
        'GoTo limpar

        'limpar:
        LimparFormulario()
        nomeTextBox.Focus()
    End Sub

    Private Sub GravarCliente()
        Const caminho As String = "C:\CadastroClientes.txt"
        Dim registro = String.Format("{0};{1};{2};{3};{4};{5};{6}",
                                     nomeTextBox.Text,
                                     enderecoTextBox.Text,
                                     If(masculinoRadioButton.Checked, "M", "F"),
                                     estadoCivilComboBox.Text,
                                     If(preferencialCheckBox.Checked, "1", "0"),
                                     paisListBox.Text,
                                     DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"))

        Dim sw As New StreamWriter(caminho, True)
        sw.WriteLine(registro)
        sw.Close()
    End Sub

    Private Function ValidarFormulario() As Boolean
        If nomeTextBox.Text.Trim() = String.Empty Then
            MessageBox.Show("O campo Nome é de preenchimento obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error)
            nomeTextBox.Focus()
            Return False
        End If
        If enderecoTextBox.Text.Trim() = String.Empty Then
            MessageBox.Show("O campo Endereço é de preenchimento obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error)
            enderecoTextBox.Focus()
            Return False
        End If

        If Not masculinoRadioButton.Checked AndAlso Not femininoRadioButton.Checked Then
            MessageBox.Show("Selecione o Sexo do cliente.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If estadoCivilComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Selecione o Estado civil do cliente.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estadoCivilComboBox.Focus()
            SendKeys.Send("{F4}")
            Return False
        End If
        If paisListBox.SelectedIndex = -1 Then
            MessageBox.Show("Selecione o País do cliente.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error)
            paisListBox.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub LimparFormulario()
        nomeTextBox.Clear()
        enderecoTextBox.Text = ""
        masculinoRadioButton.Checked = False
        femininoRadioButton.Checked = False
        estadoCivilComboBox.SelectedIndex = -1
        paisListBox.SelectedIndex = -1
        preferencialCheckBox.Checked = True '0 só com Option strict off
    End Sub

    Private Sub limparButton_Click(sender As System.Object, e As EventArgs) Handles limparButton.Click
        LimparFormulario()
    End Sub

    Private Sub ajudaLinkLabel_LinkClicked(sender As System.Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ajudaLinkLabel.LinkClicked
        Process.Start("www.google.com")
    End Sub

    Private Sub CadastroClienteForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim principalForm = DirectCast(Me.MdiParent, PrincipalForm)

        If Not principalForm.ListagemClienteForm Is Nothing Then
            DirectCast(principalForm.ListagemClienteForm, ListagemCliente).VincularDados()
        End If
    End Sub
End Class
'End Namespace