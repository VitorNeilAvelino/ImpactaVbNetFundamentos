Imports PowerMessenger.Dominio
Imports PowerMessenger.Aplicacao

Public Class MensageiroForm

    Private _aplicacao As New ClienteAplicacao()

    Sub New()
        InitializeComponent()
        AddHandler _aplicacao.ClienteCallback.ReceberMensagem, AddressOf ReceberMensagem
    End Sub

    Private Sub contatosToolStripButton_Click(sender As System.Object, e As EventArgs) Handles contatosToolStripButton.Click
        'Dim contatosForm = New ContatosForm()
        ''contatosForm.MdiParent = Me
        ''contatosForm.Dock = DockStyle.Left
        'mensageiroContentPanel.Controls.Add(contatosForm)
        'contatosForm.Show()
    End Sub

    Private Sub enviarButton_Click(sender As System.Object, e As EventArgs) Handles enviarButton.Click
        Dim mensagem As New Mensagem()
        mensagem.Corpo = mensagemTextBox.Text
        mensagem.Destinatario.Login = "vavelino"
        _aplicacao.Enviar(mensagem)
    End Sub

    Private Sub ReceberMensagem(mensagem As Mensagem)
        conversaTextBox.Text = mensagem.Corpo
    End Sub
End Class
