Imports System
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Impacta.Infra.Apoio

<TestClass()> _
Public Class LogarTest
    <TestMethod()> _
    Public Sub PorEmailTest()
        Dim ex As New Exception("Teste")
        Logar.PorEmail(ex)
    End Sub
End Class
