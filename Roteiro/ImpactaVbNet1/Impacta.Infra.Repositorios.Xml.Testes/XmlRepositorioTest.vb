Imports Microsoft.VisualStudio.TestTools.UnitTesting
<TestClass()> _
Public Class XmlRepositorioTest

    <TestMethod()> _
    Public Sub ExtrairValorDoNohViaResource()
        Dim repositorio As XmlRepositorio = New XmlRepositorio()
        Dim retorno = repositorio.ExtrairValorDoNoh(XDocument.Parse(My.Resources.XmlParaTesteComDescendants), "http://www.portalfiscal.inf.br/nfe", "vICMS")
        Assert.AreEqual(retorno, "3436.07")
    End Sub

    Public Sub ExtrairValorDoNohViaResourceComParametroIncorreto()
        Dim repositorio As XmlRepositorio = New XmlRepositorio()
        Dim retorno = repositorio.ExtrairValorDoNoh(XDocument.Parse(My.Resources.XmlParaTesteComDescendants), "http://www.portalfiscal.inf.br/nfe", "issoNonEcziste")
        Assert.AreEqual(retorno, Nothing)
    End Sub
    
End Class
