Imports Impacta.Infra.Repositorios.SqlServer

Public Class LoginForm

    Private ReadOnly _usuarioRepositorio = New UsuarioRepositorio()

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Aplicacao.UsuarioLogado = _usuarioRepositorio.Autenticar(UsernameTextBox.Text, PasswordTextBox.Text)

        If Aplicacao.UsuarioLogado Is Nothing Then
            MessageBox.Show("Credenciais incorretas.")
        Else
            Me.Close()
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub
End Class