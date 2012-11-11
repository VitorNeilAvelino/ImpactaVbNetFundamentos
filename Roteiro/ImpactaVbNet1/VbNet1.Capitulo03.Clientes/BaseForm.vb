Public Class BaseForm
    Private Sub fecharToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles fecharToolStripButton.Click
        'Dim resposta = MessageBox.Show("Deseja realmente fechar esta janela?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If resposta = Windows.Forms.DialogResult.Yes Then
        Close()
        'End If
    End Sub
End Class