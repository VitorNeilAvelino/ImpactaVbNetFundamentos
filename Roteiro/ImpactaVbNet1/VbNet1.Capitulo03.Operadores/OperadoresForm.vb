''' <summary>
''' Tipos de dados estão na página 108 do PDF do aluno.
''' </summary>
''' <remarks></remarks>
Public Class OperadoresForm
    Inherits Windows.Forms.Form

    Dim _a As Integer = 2
    Dim _b As Integer = 6
    Dim _c As Integer = 10
    Dim _d As Integer = 15
    Dim _f = 150

    Private Sub aritmeticosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) _
            Handles aritmeticosToolStripMenuItem.Click
        Dim nome As String = "Vítor"
        Dim valor As Decimal = 22.23 'Double é o queridinho do VB.NET. Se ligar o Strict, quebra.
        Dim opcional As Boolean = True
        Dim dataNascimento As DateTime = New DateTime(1970, 12, 25)

        ExibirValoresVariaveis()

        resultadoListBox.Items.Add(String.Concat("_a * _b = ", _a * _b))
        resultadoListBox.Items.Add(String.Concat("_d / _a = ", _d / _a)) '7,5
        resultadoListBox.Items.Add(String.Concat("_d \ _a = ", _d \ _a)) '7, ou seja, a parte inteira
        resultadoListBox.Items.Add("_c Mod _a = " & _c Mod _a)
        resultadoListBox.Items.Add("_d Mod _a = " & _d Mod _a)
        resultadoListBox.Items.Add("a ^ _c = " & _a ^ _c)
    End Sub

    Private Sub ExibirValoresVariaveis()
        resultadoListBox.Items.Add("a = " & _a)
        resultadoListBox.Items.Add("_b = " & _b)
        resultadoListBox.Items.Add("_c = " & _c)
        resultadoListBox.Items.Add("_d = " + _d.ToString())
        resultadoListBox.Items.Add(New String("-", 100))
    End Sub

    Private Sub ReduzidosToolStripMenuItem_Click(sender As System.Object, e As EventArgs) Handles ReduzidosToolStripMenuItem.Click
        'Call ExibirValoresVariaveis()
        ExibirValoresVariaveis()

        'a = a + 10
        _a += 10

        resultadoListBox.Items.Add("a = " & _a)
    End Sub

    Private Sub BooleanosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BooleanosToolStripMenuItem.Click
        ExibirValoresVariaveis()

        resultadoListBox.Items.Add("a >= _b = " & (_a >= _b)) ' sem os () dá erro de cast.
        resultadoListBox.Items.Add("_c <= _d = " & (_c <= _d))
        resultadoListBox.Items.Add("a <> _c = " & (_a <> _c))
    End Sub

    Private Sub logicosToolStripMenuItem_Click(sender As System.Object, e As EventArgs) Handles logicosToolStripMenuItem.Click
        ExibirValoresVariaveis()

        resultadoListBox.Items.Add("a < _b Or _c = _d = " & (_a < _b Or _c = _d))
        resultadoListBox.Items.Add("a = _b And _c <> _d = " & (_a = _b And _c <> _d))
        resultadoListBox.Items.Add("a < _b OrElse Foobar() = " & (_a < _b OrElse Foobar()))
        resultadoListBox.Items.Add("a = _b AndAlso Foobar() = " & (_a = _b AndAlso Foobar()))
        resultadoListBox.Items.Add("Not(a > _b) = " & Not (_a > _b))

        'Dim zero As Byte = 0
        'resultadoListBox.Items.Add(Not zero) 'Not(00000000) = 11111111 = 255
    End Sub

    Private Function Foobar() As Boolean
        MessageBox.Show("Foobar")
        'Foobar = True
        Return True
    End Function

    Private Sub ternarioToolStripMenuItem_Click(sender As System.Object, e As EventArgs) Handles ternarioToolStripMenuItem.Click
        Dim ano = 2014
        resultadoListBox.Items.Add(String.Format("O ano {0} é bissexto? {1}.", ano, IIf(ano Mod 4 = 0, "Sim", "Não")))

        ano = 2016
        resultadoListBox.Items.Add(String.Format("O ano {0} é bissexto? {1}.", ano, If(DateTime.IsLeapYear(ano), "Sim", "Não")))
    End Sub
End Class
