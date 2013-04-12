Public Class XmlRepositorio

    Public Function ExtrairValorDoNoh(caminhoArquivoXml As String, xmlNameSpace As XNamespace, nomeNoh As String) As String
        Return ExtrairValorDoNoh(XDocument.Load(caminhoArquivoXml), xmlNameSpace, nomeNoh)
    End Function

    Public Function ExtrairValorDoNoh(xDocument As XDocument, xmlNameSpace As XNamespace, nomeNoh As String) As String
        Dim nos = xDocument.Descendants(xmlNameSpace + nomeNoh)
        Dim retorno = nos.FirstOrDefault()
        Return If(retorno Is Nothing, Nothing, retorno.Value)
    End Function

End Class
