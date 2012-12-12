Public Class CursorAEsquerdaMaskedTextBoxUserControl
    Public Property Texto As String
        Get
            Return cursorAEsquerdaMaskedTextBox.Text
        End Get
        Set(value As String)
            cursorAEsquerdaMaskedTextBox.Text = value
        End Set
    End Property
    Public Property Mascara As String
        Get
            Return cursorAEsquerdaMaskedTextBox.Mask
        End Get
        Set(value As String)
            cursorAEsquerdaMaskedTextBox.Mask = value
        End Set
    End Property

    Private Sub cursorAEsquerdaMaskedTextBox_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles cursorAEsquerdaMaskedTextBox.MouseClick
        cursorAEsquerdaMaskedTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals

        If cursorAEsquerdaMaskedTextBox.Text.Trim() = String.Empty Then
            cursorAEsquerdaMaskedTextBox.SelectionStart = 0
        End If

        cursorAEsquerdaMaskedTextBox.TextMaskFormat = MaskFormat.IncludeLiterals
    End Sub
End Class
