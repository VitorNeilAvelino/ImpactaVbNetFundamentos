Imports Impacta.Dominio
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> _
Public Class FreteRepositorioTest
    <TestMethod()> _
    Public Sub InserirTest()
        Dim freteRepositorio As IFreteRepositorio = New FreteRepositorio()
        Dim frete As Frete = New Frete()

        With frete
            .Cliente = New Cliente()
            .Cliente.Id = 2021
            .Percentual = 0.23
            .UfDestino = "SP"
            .ValorCarga = 2023
        End With

        freteRepositorio.Inserir(frete)
    End Sub
End Class