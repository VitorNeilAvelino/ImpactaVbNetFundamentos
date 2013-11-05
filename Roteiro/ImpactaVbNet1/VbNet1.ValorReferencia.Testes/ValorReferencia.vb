Imports Impacta.Dominio

<TestClass()>
Public Class ValorReferencia
    <TestMethod()>
    Public Sub TestarPassagemPorValor()
        Dim x = 1
        Transformar(x)
        Assert.AreEqual(x, 1)

        Dim y = x
        x = 2
        Assert.AreEqual(y, 1)
    End Sub

    <TestMethod()>
    Public Sub TestarPassagemPorReferencia()
        Dim cliente = New Cliente()
        cliente.Nome = "Vítor"
        Transformar(cliente)
        Assert.AreEqual(cliente.Nome, "Avelino")

        Dim cliente2 = cliente
        cliente.Nome = "Outro Nome"
        Assert.AreEqual(cliente2.Nome, "Outro Nome")
    End Sub

    <TestMethod()>
    Public Sub TestarPassagemPorValorUsandoByRef()
        Dim x = 1
        TransformarByRef(x)
        Assert.AreEqual(x, 2)
    End Sub

    <TestMethod()>
    Public Sub TestarPassagemDeVetores()
        Dim meuVetor(4) As String
        meuVetor(0) = "Vítor"

        Transformar(meuVetor)

        Assert.AreEqual(meuVetor(0), "Avelino")
    End Sub

    Private Sub Transformar(ByVal meuVetor As String())
        meuVetor(0) = "Avelino"
    End Sub

    Private Sub TransformarByRef(ByRef x As Integer)
        x += 1
    End Sub

    <TestMethod()>
    Public Sub PassarObjetoByVal()
        Dim cliente As New Cliente
        cliente.Nome = "Vítor"
        TransformarByVal(cliente)
        Assert.AreEqual("Avelino", cliente.Nome)
    End Sub

    <TestMethod()>
    Public Sub PassarObjetoByRef()
        Dim cliente As New Cliente
        cliente.Nome = "Vítor"
        TransformarByRef(cliente)
        Assert.AreEqual("Avelino", cliente.Nome)
    End Sub

    <TestMethod()>
    Public Sub PassarObjetoSemEscolherByValOrByRef()
        Dim cliente As New Cliente
        cliente.Nome = "Vítor"
        Transformar(cliente)
        Assert.AreEqual("Avelino", cliente.Nome)
    End Sub

    Private Sub TransformarByVal(ByVal cliente As Cliente)
        'cliente = New Cliente
        cliente.Nome = "Avelino"
    End Sub

    Private Sub TransformarByRef(ByRef cliente As Cliente)
        cliente = New Cliente
        cliente.Nome = "Avelino"
    End Sub

    Private Sub Transformar(cliente As Cliente)
        cliente = New Cliente
        cliente.Nome = "Avelino"
    End Sub

    Private Sub Transformar(x As Integer)
        x += 1
    End Sub
End Class