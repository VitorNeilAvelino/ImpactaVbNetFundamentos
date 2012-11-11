Imports System.Windows.Forms

Public Class Formulario
    Public Shared Sub Redimensionar(pictureBox As PictureBox)
        'If pictureBox.Image Is Nothing Then Return
        If pictureBox.Image.Width > pictureBox.Width OrElse pictureBox.Image.Height > pictureBox.Height Then
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom
        Else
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage
        End If
    End Sub

    Public Shared Function ValidarCamposObrigatorios(ByVal formulario As Form, provedorDeErro As ErrorProvider) As Boolean
        Dim validacao As Boolean = True

        For Each controle As Control In formulario.Controls
            If controle.Tag <> Nothing AndAlso controle.Tag.ToString().Contains("*") Then
                provedorDeErro.SetError(controle, String.Empty)
                If controle.Text.Trim() = String.Empty OrElse
                    (TypeOf controle Is MaskedTextBox AndAlso
                     DirectCast(controle, MaskedTextBox).ObterTextoSemMascara() = String.Empty) Then
                    validacao = False
                    provedorDeErro.SetError(controle, "Campo obrigatório.")
                    controle.Focus()
                End If
            End If
        Next

        Return validacao
    End Function

    Public Shared Function ValidarTipoDosDados(formulario As Form, provedorDeErro As ErrorProvider) As Boolean
        Dim validacao As Boolean = True

        For Each controle As Control In formulario.Controls
            provedorDeErro.SetError(controle, String.Empty)

            If controle.Tag = Nothing Then Continue For

            Try
                If controle.Tag.ToString().ToUpper().Contains("DECIMAL") Then
                    Convert.ToDecimal(controle.Text)
                ElseIf controle.Tag.ToString().ToUpper().Contains("DATETIME") Then
                    Convert.ToDateTime(controle.Text)
                ElseIf controle.Tag.ToString().ToUpper().Contains("CPF") Then
                    If Not Validar.Cpf(controle.Text) Then
                        Throw New Exception()
                    End If
                ElseIf controle.Tag.ToString().ToUpper().Contains("EMAIL") Then
                    If Not Validar.Email(controle.Text) Then
                        Throw New Exception()
                    End If
                End If
            Catch
                validacao = False
                provedorDeErro.SetError(controle, "Valor inválido.")
                controle.Focus()
            End Try
        Next

        Return validacao
    End Function

    Public Shared Sub Limpar(formulario As Form)
        'Control = Fruta
        For Each controle As Control In formulario.Controls
            'TextBox = Maçã
            If TypeOf controle Is TextBox Then
                controle.Text = String.Empty
                'ComboBox = Pera
            ElseIf TypeOf controle Is ComboBox Then
                DirectCast(controle, ComboBox).SelectedIndex = -1
            End If
        Next
    End Sub

    Shared Function ValidarCamposObrigatorios(formulario As IFormularioComErrorProvider) As Boolean
        Return ValidarCamposObrigatorios(formulario, formulario.ProvedorDeErro)
    End Function
End Class
