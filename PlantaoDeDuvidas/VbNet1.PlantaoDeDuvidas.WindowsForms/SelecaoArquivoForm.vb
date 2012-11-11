Imports System.IO

Public Class SelecaoArquivoForm
    Private Sub SelecaoArquivoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        selecaoArquivoOpenFileDialog.InitialDirectory = My.Application.Info.DirectoryPath
    End Sub

    Private Sub abrirArquivoToolStripButton_Click(sender As Object, e As EventArgs) _
        Handles abrirArquivoToolStripButton.Click
        Dim respostaJanela = selecaoArquivoOpenFileDialog.ShowDialog()
        If respostaJanela <> DialogResult.Cancel Then
            arquivoRichTextBox.Text = New StreamReader(selecaoArquivoOpenFileDialog.FileName).ReadToEnd().ToString()
        End If
    End Sub
End Class
