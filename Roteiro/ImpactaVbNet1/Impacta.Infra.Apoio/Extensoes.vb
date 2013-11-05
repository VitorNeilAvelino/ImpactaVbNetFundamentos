Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Module Extensoes

    <Extension()>
    Public Function ObterTextoSemMascara(controle As Control) As String
        'Se não for máscara, retorne
        If Not TypeOf controle Is MaskedTextBox Then
            Return controle.Text
        End If

        'Transformar Control em MaskedTexBox
        Dim caixaDeTextoDeMascara = DirectCast(controle, MaskedTextBox)
        'Preservar a máscara inicial
        Dim mascaraInicial = caixaDeTextoDeMascara.TextMaskFormat
        'Excluir os caracteres da máscara
        caixaDeTextoDeMascara.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        'Recuperar o texto sem máscara
        Dim retorno = caixaDeTextoDeMascara.Text
        'Retornar a máscara inicial
        caixaDeTextoDeMascara.TextMaskFormat = mascaraInicial
        'Retornar o texto sem máscara
        Return retorno
    End Function

    <Extension()>
    Public Function SemAcentos(texto As String) As String
        Return Transformar.RemoverAcentuacao(texto)
    End Function
End Module