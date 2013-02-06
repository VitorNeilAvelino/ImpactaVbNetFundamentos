Imports Microsoft.VisualStudio.TestTools.UnitTesting
<TestClass()> _
Public Class ValidarTest
    <TestMethod()> _
    Public Sub EmailTest()
        Dim endereco As String = "vitor.avelino@hotmail.r7"
        Dim expected As Boolean = True
        Dim actual As Boolean
        actual = Validar.Email(endereco)
        Assert.AreEqual(expected, actual)
    End Sub
End Class
