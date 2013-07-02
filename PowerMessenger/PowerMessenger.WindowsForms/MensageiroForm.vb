Imports PowerMessenger.Dominio
Imports PowerMessenger.Aplicacao

Public Class MensageiroForm

    Private ReadOnly _aplicacao As New ClienteAplicacao()
    Private ReadOnly _eu As New Cliente With {.Login = Environment.UserName}
    Private _destinatario As Cliente
        
    Sub New()
        InitializeComponent()
        AddHandler _aplicacao.ClienteCallback.AoReceberMensagem, AddressOf AoReceberMensagem
        AddHandler _aplicacao.ClienteCallback.AoSelecionarClientesLogados, AddressOf AoSelecionarClientesLogados
        Logar()
    End Sub

    Private Sub AoSelecionarClientesLogados(ByVal clientes As IList(Of Cliente))
        Dim contatos = clientes.Where(Function(x) x.Login <> _eu.Login)

        If Not contatos Is Nothing AndAlso contatos.Count > 0 Then
            ClienteBindingSource.DataSource = contatos
        Else
            ClienteBindingSource.DataSource = Nothing
        End If
    End Sub

    Private Sub Logar()
#If DEBUG Then
        logarButton.Visible = True
        Return
#End If
        _aplicacao.Logar(_eu)
    End Sub

    Private Sub enviarButton_Click(sender As System.Object, e As EventArgs) Handles enviarButton.Click
        'mensageiroBackgroundWorker.RunWorkerAsync()
        Dim mensagem As New Mensagem()
        mensagem.Corpo = mensagemTextBox.Text
        mensagem.Destinatario.Login = _destinatario.Login
        _aplicacao.Enviar(mensagem)
    End Sub

    Private Sub AoReceberMensagem(mensagem As Mensagem)
        conversaTextBox.Text = mensagem.Corpo
    End Sub

    Private Sub mensageiroBackgroundWorker_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles mensageiroBackgroundWorker.RunWorkerCompleted
        ClienteBindingSource.DataSource = DirectCast(e.Result, IList(Of Cliente))
    End Sub

    Private Sub mensageiroBackgroundWorker_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles mensageiroBackgroundWorker.DoWork
        'Dim mensagem As New Mensagem()
        'mensagem.Corpo = mensagemTextBox.Text
        'mensagem.Destinatario.Login = "vavelino"
        '_aplicacao.Enviar(mensagem)
        _aplicacao.Logar(New Cliente With {.Login = mensagemTextBox.Text})
        logarButton.Visible = False
        mensagemTextBox.Text = String.Empty
        mensagemTextBox.Focus()

        ' e.Result = Mensagem
    End Sub

    Private Sub logarButton_Click(sender As System.Object, e As EventArgs) Handles logarButton.Click
        'mensageiroBackgroundWorker.RunWorkerAsync()
        _eu.Login = mensagemTextBox.Text

        _aplicacao.Logar(_eu)
        logarButton.Visible = False
        mensagemTextBox.Text = String.Empty
        mensagemTextBox.Focus()
    End Sub

    Private Sub clientesDataGridView_CellClick(sender As System.Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles clientesDataGridView.CellClick
        _destinatario = DirectCast(clientesDataGridView.Rows(e.RowIndex).DataBoundItem, Cliente)
    End Sub
End Class