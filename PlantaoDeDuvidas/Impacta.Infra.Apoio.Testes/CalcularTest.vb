Imports System
Imports Microsoft.VisualStudio.TestTools.UnitTesting
<TestClass()> _
Public Class CalcularTest
    <TestMethod()> _
    Public Sub DiferencaEntreDatasTest()
        'Dim dataInicial As DateTime = DateTime.Now.Date
        Dim dataInicial As DateTime = New DateTime(2013, 2, 4)
        Dim dataFinal As DateTime = New DateTime(2013, 2, 10)
        Dim retorno = Calcular.QuantidadeDeDiasUteisEntreDatas(dataInicial, dataFinal, 0)
        Assert.AreEqual(retorno, 5)
    End Sub
End Class