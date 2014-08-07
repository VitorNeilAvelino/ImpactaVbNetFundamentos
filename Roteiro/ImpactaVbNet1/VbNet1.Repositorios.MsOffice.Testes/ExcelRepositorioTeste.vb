Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.Reflection
Imports System.IO

<TestClass()> _
Public Class ExcelRepositorioTeste
    <TestMethod()> _
    Public Sub SalvarTeste()
        Dim repositorio = New ExcelRepositorio()
        Dim registro = "1;Vítor;25/12/1970;avelino.vitor@gmail.com"
        Dim registros = New List(Of String) From {registro}

        Dim caminho = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Clientes.xls")

        repositorio.Salvar(caminho, registros)
    End Sub
End Class