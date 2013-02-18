Imports Microsoft.VisualStudio.TestTools.UnitTesting
<TestClass()> _
Public Class ValidarTest
    <TestMethod()> _
    Public Sub EmailTest()
        Assert.IsTrue(Validar.Email("vitor.avelino@r7.com"))
        Assert.IsTrue(Validar.Email("vitor-avelino@r7.com"))
        Assert.IsTrue(Validar.Email("vitor_avelino@r7.com"))
        Assert.IsTrue(Validar.Email("vitor_avelino@r7.com.br"))
        Assert.IsTrue(Validar.Email("vitor_avelino@r-7.com.br"))

        Assert.IsFalse(Validar.Email("vitor_avelino.r7.com"))
        Assert.IsFalse(Validar.Email("vitor_avelino@r7.combustivel"))
    End Sub
End Class
