Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO

Public Class ExcelRepositorio
    Public Sub Salvar(caminho As String, registros As IList(Of String), Optional quantidadeMaximaDeRegistrosPorAba As System.Nullable(Of Integer) = Nothing)
        Dim excel = New Excel.Application()
        Dim pastaDeTrabalho = If(File.Exists(caminho), excel.Workbooks.Open(caminho), excel.Workbooks.Add())

        Dim planilha As Excel.Worksheet = pastaDeTrabalho.ActiveSheet

        Dim proximaLinha = If(planilha.Range("A1", "A1").Value2 Is Nothing, 1, planilha.UsedRange.Rows.Count + 1)
        Dim proximaColuna = 1

        For Each registro In registros
            For Each campo In registro.Split(";"c)
                planilha.Cells(proximaLinha, proximaColuna) = campo
                proximaColuna = proximaColuna + 1
            Next
            proximaLinha += 1
            proximaColuna = 1

            If proximaLinha > quantidadeMaximaDeRegistrosPorAba Then
                planilha = DirectCast(excel.Worksheets.Add(), Excel.Worksheet)
                proximaLinha = 1
            End If
        Next

        excel.DisplayAlerts = False

        pastaDeTrabalho.SaveAs(caminho)

        pastaDeTrabalho.Close()
        planilha = Nothing
        pastaDeTrabalho = Nothing
        excel.Quit()
    End Sub
End Class