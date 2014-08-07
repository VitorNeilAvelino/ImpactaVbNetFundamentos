<TestClass()>
Public Class ClienteRepositorioTeste
    <TestMethod()>
    Public Sub InserirTest()
        Dim cliente As New Impacta.Dominio.Cliente()
        cliente.Nome = "Vítor"
        cliente.DataNascimento = Convert.ToDateTime("25/12/1970")
        cliente.Email = "avelino.vitor@gmail.com"

        Dim repositorio = New ClienteRepositorio()
        repositorio.Inserir(cliente)
    End Sub
End Class