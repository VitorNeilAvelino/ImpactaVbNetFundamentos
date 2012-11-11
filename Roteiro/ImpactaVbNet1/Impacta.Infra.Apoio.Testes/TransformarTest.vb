Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()>
Public Class TransformarTest
    <TestMethod()>
    Public Sub RemoverAcentuacaoTest()
        Dim texto As String = "Vítor"
        Dim esperado As String = "Vitor"
        Dim retornado As String
        retornado = Transformar.RemoverAcentuacao(texto)
        Assert.AreEqual(esperado, retornado)
    End Sub
End Class