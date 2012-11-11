Public Class PrincipalForm
    Public ReadOnly Property ListagemClienteForm As ListagemCliente
        Get
            For Each formulario In Me.MdiChildren
                If TypeOf formulario Is ListagemCliente Then
                    Return DirectCast(formulario, ListagemCliente)
                End If
            Next
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property CadastroClienteForm As CadastroClienteForm
        Get
            Return DirectCast(Me.MdiChildren.FirstOrDefault(Function(formulario) TypeOf formulario Is CadastroClienteForm), CadastroClienteForm)
        End Get
    End Property

    Private Sub clientesToolStripSplitButton_ButtonClick(sender As System.Object, e As System.EventArgs) Handles clientesToolStripSplitButton.ButtonClick
        If Not ListagemClienteForm Is Nothing Then
            ListagemClienteForm.BringToFront()
            Return
        End If

        ExibirFormularioFilho(New ListagemCliente())
    End Sub

    Private Sub NovoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NovoToolStripMenuItem.Click
        If Not CadastroClienteForm Is Nothing Then
            CadastroClienteForm.BringToFront()
            Return
        End If

        ExibirFormularioFilho(New CadastroClienteForm())
    End Sub

    Private Sub ExibirFormularioFilho(formulario As Form)
        formulario.MdiParent = Me
        formulario.Dock = DockStyle.Fill
        formulario.Show()
    End Sub
End Class