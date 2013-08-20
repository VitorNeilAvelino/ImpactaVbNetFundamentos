Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> _
Public Class ClienteTest
    <TestMethod()> _
    Public Sub ClienteConstructorTest()
        Dim cliente As Cliente = New Cliente()

        cliente.Nome = "Vítor"
        Dim cpf = New Documento()

        cpf.Numero = "128.456.628-58"
        cpf.Tipo = TipoDocumento.Cpf
        cliente.Documentos.Add(cpf)

        Assert.AreEqual(cliente.ToString(), String.Format("{0} - {1}", cliente.Nome, cliente.Documentos(0).Numero))
    End Sub
    <TestMethod()> _
    Public Sub ToStringTest()
        Dim cliente As New Cliente()
        Console.WriteLine(cliente.ToString())
        'Assert.AreEqual(cliente.ToString(), cliente.GetType().FullName)
    End Sub
End Class