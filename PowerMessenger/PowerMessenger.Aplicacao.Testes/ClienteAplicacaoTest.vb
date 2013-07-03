Imports PowerMessenger.Dominio.Interfaces
Imports PowerMessenger.Dominio.Entidades
Imports PowerMessenger.Dominio
Imports Microsoft.VisualStudio.TestTools.UnitTesting
<TestClass()> _
Public Class ClienteAplicacaoTest
    ReadOnly _aplicacao As ClienteAplicacao = New ClienteAplicacao()

    <TestMethod()> _
    Public Sub EnviarTest()
        Dim cliente As New Contato With {.Login = "vavelino"}
        Dim mensagem As New Mensagem With {.Corpo = DateTime.Now.ToString(), .Destinatario = cliente}

        _aplicacao.Enviar(mensagem)
    End Sub

    <TestMethod()> _
    Public Sub LogarTest()
        Dim cliente As New Contato With {.Login = "teste"}

        _aplicacao.Logar(cliente)
    End Sub
End Class