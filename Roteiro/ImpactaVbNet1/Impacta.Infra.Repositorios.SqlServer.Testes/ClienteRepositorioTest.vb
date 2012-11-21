Imports Impacta.Dominio

<TestClass()>
Public Class ClienteRepositorioTest
    Private ReadOnly _clienteRepositorio As IClienteRepositorio = New ClienteRepositorio()

    <TestMethod()>
    Public Sub SelecionarTest()
        Dim retorno As List(Of Cliente)
        retorno = _clienteRepositorio.Selecionar()
        Assert.AreNotEqual(retorno.Count, 0)
    End Sub

    <TestMethod()>
    Public Sub GravarTest()
        Dim cliente As Cliente = New Cliente()
        cliente.Nome = "Vítor"
        cliente.DataNascimento = Convert.ToDateTime("25/12/1970")
        cliente.Email = "avelino.vitor@gmail.com"
        cliente.Endereco = "R. Tal, 40"
        _clienteRepositorio.Gravar(cliente)
    End Sub

    <TestMethod()>
    Public Sub AtualizarTest()
        Dim cliente As Cliente = New Cliente()
        cliente.Id = Guid.NewGuid()
        cliente.Nome = "Vítor Editado"
        cliente.DataNascimento = Convert.ToDateTime("25/12/1970")
        cliente.Email = "avelino.vitor@gmail.com"
        cliente.Endereco = "R. Tal, 40"
        _clienteRepositorio.Atualizar(cliente)
    End Sub

    <TestMethod()>
    Public Sub ExcluirTest()
        Dim clienteId As String = "2"
        _clienteRepositorio.Excluir(clienteId)
    End Sub
End Class