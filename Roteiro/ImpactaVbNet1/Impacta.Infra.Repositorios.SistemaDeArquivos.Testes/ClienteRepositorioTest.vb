Imports Impacta.Dominio
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Impacta.Infra.Repositorios.SistemaDeArquivos

<TestClass()> _
Public Class ClienteRepositorioTest
    <TestMethod()> _
    Public Sub GravarTest()
        Dim caminho As String = "C:\CadastroDeClientesTestes.txt"

        Dim cliente As Cliente = New Cliente()
        With cliente
            Dim documento As New Documento()
            With documento
                .Numero = "12845662858"
                .Tipo = TipoDocumento.Cpf
            End With
            .Documentos.Add(documento)

            .DataNascimento = Convert.ToDateTime("25/12/1970")
            .Email = "avelino.vitor@gmail.com"
            .Endereco = "R. Tal"
            .Nome = "Vítor"
            .Renda = 123
        End With

        Call New ClienteRepositorio().Gravar(cliente)
    End Sub
End Class