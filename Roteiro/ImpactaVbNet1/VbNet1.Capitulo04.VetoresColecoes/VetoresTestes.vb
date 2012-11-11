<TestClass()>
Public Class VetoresTestes
    <TestMethod()>
    Public Sub InicializacaoDeVetorTeste()
        'Erro!
        'Dim meuVetor(1 To 5) As String 

        'Erro!
        'Dim meuVetor(2) As String = {"Elemento 1", "Elemento 2"}

        'Dim meuVetor(1) As String
        'meuVetor(0) = "Elemento 1"
        'meuVetor(1) = "Elemento 2"
        'meuVetor(2) = "Elemento 3"

        Dim meuVetor() As String = {"Elemento 1", "Elemento 2"}

        For Each elemento As String In meuVetor
            Console.WriteLine(elemento)
        Next

        Console.WriteLine("Tamanho do vetor: {0}", meuVetor.Length)
        Console.WriteLine("Índice máximo do vetor: {0}", UBound(meuVetor))
        'Console.WriteLine("Índice máximo do vetor: {0}", meuVetor.GetUpperBound(0))
    End Sub

    <TestMethod()>
    Public Sub VetorDinamicoTeste()
        Dim meuVetor() As String

        'Try
        '    meuVetor(0) = "Elemento 1"
        'Catch
        '    Console.WriteLine("Ooops! Não é possível usar o vetor dinâmico antes de informar seu tamanho.")
        'End Try

        ReDim meuVetor(5)
        meuVetor(0) = "Elemento 1"

        ReDim meuVetor(10)
        Assert.AreEqual(meuVetor(0), Nothing)

        meuVetor(0) = "Elemento 1"
        ReDim Preserve meuVetor(15)
        Assert.AreEqual(meuVetor(0), "Elemento 1")
    End Sub

    <TestMethod()>
    Public Sub MatrizTeste()
        Dim matriz(2, 3) As Integer
        For linha As Integer = 0 To matriz.GetUpperBound(0)
            For coluna As Integer = 0 To matriz.GetUpperBound(1)
                matriz(linha, coluna) = linha * coluna
                Console.Write("| " & matriz(linha, coluna) & " ")
            Next
            Console.WriteLine()
        Next
    End Sub
End Class