Imports System.Text.RegularExpressions

Public Class Validar
    Public Shared Function Cpf(ByVal numeroCpf As String) As Boolean
        Dim cpfsInvalidos() As String = {"11111111111", "22222222222", "33333333333", "44444444444", _
                                              "55555555555", "66666666666", "77777777777", "88888888888", "99999999999"}
        Dim i, x, n1, n2 As Integer
        numeroCpf = numeroCpf.Trim

        For i = 0 To cpfsInvalidos.Length - 1
            If numeroCpf.Length <> 11 Or cpfsInvalidos(i).Equals(numeroCpf) Then
                Return False
            End If
        Next
        '
        For x = 0 To 1
            n1 = 0
            For i = 0 To 8 + x
                n1 = n1 + Val(numeroCpf.Substring(i, 1)) * (10 + x - i)
            Next
            n2 = 11 - (n1 - (Int(n1 / 11) * 11))
            If n2 = 10 Or n2 = 11 Then n2 = 0
            If n2 <> Val(numeroCpf.Substring(9 + x, 1)) Then
                Return False
            End If
        Next
        Return True
    End Function

    Shared Function Email(endereco As String) As Boolean
        Return Regex.IsMatch(endereco, "^[a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$")
    End Function
End Class