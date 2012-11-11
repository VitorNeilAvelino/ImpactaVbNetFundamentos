Public Class TabuadaForm
    Private Sub Calcular()
        tabuadaListBox.Items.Clear()
        Dim tabuada As Integer = Convert.ToInt32(tabuadaTextBox.Text)

        For i As Integer = 0 To 10
            tabuadaListBox.Items.Add(String.Format("{0} x {1} = {2}", tabuada, i, tabuada * i))
        Next

        tabuadaTextBox.Focus()
        tabuadaTextBox.SelectAll()
    End Sub

    Private Sub Limpar()
        tabuadaTextBox.Clear()
        tabuadaListBox.Items.Clear()
        tabuadaTextBox.SelectAll()
    End Sub

    Private Sub tabuadaTextBox_KeyPress(sender As System.Object, e As Windows.Forms.KeyPressEventArgs) Handles tabuadaTextBox.KeyPress
        If e.KeyChar >= "0" AndAlso e.KeyChar <= "9" OrElse e.KeyChar = Convert.ToChar(8) OrElse e.KeyChar = Chr(13) Then
            If e.KeyChar = Chr(13) Then
                Calcular()
            End If
        Else
            'e.KeyChar = Chr(0)
            e.Handled = True
        End If
    End Sub

    Private Sub TabuadaForm_KeyUp(sender As System.Object, e As Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then
            Limpar()
        End If
    End Sub

    'Private Sub tabuadaTextBox_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles tabuadaTextBox.KeyUp, tabuadaTextBox.KeyDown
    '    If e.KeyCode >= Keys.NumPad0 AndAlso e.KeyCode <= Keys.NumPad9 OrElse e.KeyCode = Keys.Back OrElse e.KeyCode = Keys.Enter Then
    '        If e.KeyCode = Keys.Enter Then
    '            Calcular()
    '        End If
    '    Else
    '        'e.Handled = True
    '        e.SuppressKeyPress = True
    '    End If
    'End Sub
End Class
