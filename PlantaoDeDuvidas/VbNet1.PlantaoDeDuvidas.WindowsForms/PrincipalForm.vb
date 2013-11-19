Public Class PrincipalForm

    Private Sub PrincipalForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Aplicacao.UsuarioLogado Is Nothing Then
            Call New LoginForm().ShowDialog()
        End If
    End Sub
End Class