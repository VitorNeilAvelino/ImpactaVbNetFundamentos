Imports System.IO

Public Class TextoPuroRepositorio
    'Remover o Shared para comparar
    Public Shared Sub Inserir(caminho As String, registro As String)
        Dim sw As New StreamWriter(caminho, True)
        sw.WriteLine(registro)
        sw.Close()
    End Sub
End Class