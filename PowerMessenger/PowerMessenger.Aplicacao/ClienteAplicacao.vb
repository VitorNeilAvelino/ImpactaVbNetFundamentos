Imports PowerMessenger.Dominio.Entidades
Imports System.ServiceModel
Imports PowerMessenger.Aplicacao.ServidorServiceReference

Public Class ClienteAplicacao
    Public Property ClienteCallback() As New ClienteCallback()
    ReadOnly _contexto = New InstanceContext(ClienteCallback)
    ReadOnly _servidor = New ServidorClient(_contexto)

    Public Sub Transmitir(mensagem As Mensagem)
        _servidor.Transmitir(mensagem)
    End Sub

    Public Sub Logar(ByVal contato As Contato)
        _servidor.Logar(contato)
    End Sub

    Public Sub Deslogar(ByVal contato As Contato)
        _servidor.Deslogar(contato)
    End Sub
End Class