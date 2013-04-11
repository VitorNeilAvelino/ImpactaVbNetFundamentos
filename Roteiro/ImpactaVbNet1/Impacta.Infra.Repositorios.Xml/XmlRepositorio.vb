Public Class XmlRepositorio

    Public Function ExtrairValorDoNoh(caminhoArquivoXml As String, xmlNameSpace As XNamespace, nomeNoh As String) As String
        Dim arquivoXml = XDocument.Load(caminhoArquivoXml)
        Dim nos = arquivoXml.Descendants(xmlNameSpace + nomeNoh)
        Dim retorno = nos.FirstOrDefault()
        Return If(retorno Is Nothing, Nothing, retorno.Value)
    End Function

End Class
