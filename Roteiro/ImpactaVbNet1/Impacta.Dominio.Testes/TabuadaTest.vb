Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> _
Public Class TabuadaTest
    <TestMethod()> _
    <ExpectedException(GetType(TypeInitializationException), "Membro compartilhado foi acessado.")> _
    Public Sub CalcularTest()
        Const valor As Integer = 7
        Tabuada.Calcular(valor)
    End Sub
End Class