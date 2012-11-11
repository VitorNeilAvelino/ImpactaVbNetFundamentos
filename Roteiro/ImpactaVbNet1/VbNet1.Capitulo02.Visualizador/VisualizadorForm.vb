Imports Impacta.Infra.Apoio

Public Class VisualizadorForm
    Private Sub abrirToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles abrirToolStripButton.Click
        visualizadorOpenFileDialog.Filter = "Arquivos de imagens|*.jpg;*.gif;*.png|Arquivos bmp|*.bmp|Arquivos jpg|*.jpg"

        If visualizadorOpenFileDialog.ShowDialog() = DialogResult.OK Then
            imagemPictureBox.ImageLocation = visualizadorOpenFileDialog.FileName
        End If
    End Sub

    Private Sub imagemPictureBox_LoadCompleted(sender As System.Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles imagemPictureBox.LoadCompleted
        Formulario.Redimensionar(imagemPictureBox)
    End Sub
End Class