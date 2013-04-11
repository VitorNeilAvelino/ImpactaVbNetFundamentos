Imports Microsoft.VisualStudio.TestTools.UnitTesting
<TestClass()> _
Public Class XmlRepositorioTest
    <TestMethod()> _
    Public Sub ExtrairValordoNohTest()
        Dim repositorio As XmlRepositorio = New XmlRepositorio()
        Dim retorno = repositorio.ExtrairValorDoNoh("C:\Users\vavelino\Desktop\1.xml", "http://www.portalfiscal.inf.br/nfe", "vICMS")
        Assert.AreEqual(retorno, "3436.07")
    End Sub
End Class
