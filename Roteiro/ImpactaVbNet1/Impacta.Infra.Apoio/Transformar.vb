Public Class Transformar
    Public Shared Function RemoverAcentuacao(texto As String) As String
        Dim comAcento = "çÇáàâãaªÁÀÂÃÄëéèêËÉÈÊiíïîìÍÏÌÎöóòôõºÖÓÒÔÕüúùûÜÚÙÛ"
        Dim semAcento = "cCaaaaaäAAAAAeeeeEEEEiiiiiIIIIooooooOOOOOuuuuUUUU"

        For i As Integer = 0 To comAcento.Length - 1
            texto = texto.Replace(comAcento(i), semAcento(i))
        Next

        Return texto
    End Function
End Class