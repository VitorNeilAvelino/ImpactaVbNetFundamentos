Imports PowerMessenger.Dominio
Imports PowerMessenger.Aplicacao

Public Class MensageiroForm

    Private ReadOnly _aplicacao As New ClienteAplicacao()

    Sub New()
        InitializeComponent()
        AddHandler _aplicacao.ClienteCallback.ReceberMensagem, AddressOf ReceberMensagem
        _aplicacao.Logar(New Cliente With {.Login = Environment.UserName})
    End Sub

    Private Sub contatosToolStripButton_Click(sender As System.Object, e As EventArgs) Handles contatosToolStripButton.Click
        'Dim contatosForm = New ContatosForm()
        ''contatosForm.MdiParent = Me
        ''contatosForm.Dock = DockStyle.Left
        'mensageiroContentPanel.Controls.Add(contatosForm)
        'contatosForm.Show()
    End Sub

    Private Sub enviarButton_Click(sender As System.Object, e As EventArgs) Handles enviarButton.Click
        'mensageiroBackgroundWorker.RunWorkerAsync()
        Dim mensagem As New Mensagem()
        mensagem.Corpo = mensagemTextBox.Text
        mensagem.Destinatario.Login = "vavelino"
        _aplicacao.Enviar(mensagem)
    End Sub

    Private Sub ReceberMensagem(mensagem As Mensagem)
        conversaTextBox.Text = mensagem.Corpo
    End Sub

    Private Sub mensageiroBackgroundWorker_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles mensageiroBackgroundWorker.RunWorkerCompleted
        Dim mensagem = DirectCast(e.Result, Mensagem)
        conversaTextBox.Text = mensagem.Corpo
    End Sub

    Private Sub mensageiroBackgroundWorker_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles mensageiroBackgroundWorker.DoWork
        'Dim mensagem As New Mensagem()
        'mensagem.Corpo = mensagemTextBox.Text
        'mensagem.Destinatario.Login = "vavelino"
        '_aplicacao.Enviar(mensagem)
        'e.Result = mensagem
    End Sub

    Private Sub logarButton_Click(sender As System.Object, e As System.EventArgs) Handles logarButton.Click
        Dim cliente As New Cliente With {.Login = loginTextBox.Text}

        _aplicacao.Logar(cliente)
    End Sub
End Class
