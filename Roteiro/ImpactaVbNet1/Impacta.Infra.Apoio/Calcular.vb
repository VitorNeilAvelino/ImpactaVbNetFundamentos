Public Class Calcular
    ''' <summary>
    ''' Retorna a quantidade de dias úteis entre duas datas, descontando os feriados.
    ''' </summary>
    ''' <param name="dataInicial">Data inicial - as horas serão desconsideradas.</param>
    ''' <param name="dataFinal">Data final - as horas serão desconsideradas.</param>
    ''' <param name="quantidadeFeriados"></param>
    ''' <returns>Um inteiro representando a quantidade de dias.</returns>
    ''' <remarks></remarks>
    Public Shared Function QuantidadeDeDiasUteisEntreDatas(dataInicial As DateTime, dataFinal As DateTime, quantidadeFeriados As Int32) As Int32
        If dataInicial > dataFinal Then
            Throw New ArgumentOutOfRangeException("A data inicial não pode ser maior que a data final.")
        End If
        If quantidadeFeriados < 0 Then
            Throw New ArgumentOutOfRangeException("A quantidade de feriados não pode ser menor que zero.")
        End If

        Dim quantidadeDeDiasUteis = 0

        While dataInicial.Date <= dataFinal.Date
            If dataInicial.DayOfWeek <> DayOfWeek.Saturday AndAlso dataInicial.DayOfWeek <> DayOfWeek.Sunday Then
                quantidadeDeDiasUteis += 1
            End If
            dataInicial = dataInicial.AddDays(1)
        End While

        Return quantidadeDeDiasUteis - quantidadeFeriados
    End Function
End Class