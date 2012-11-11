''' <summary>
''' Operadores estão na página 151
''' </summary>
''' <remarks></remarks>
Public Class OperadoresForm
    Inherits Windows.Forms.Form
    Dim _a As Integer = 2, _b As Integer = 6, _c As Integer = 10, _d As Integer = 13

    Private Sub aritmeticosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles aritmeticosToolStripMenuItem.Click
        'Dim a1 = 2, b1 = 6, c1 As Decimal = 10.3, d1 = 13
        'Dim 1bimestre as Decimal

        'Implicit type: none - se trocar para Error, a linha abaixo não compila
        'Dim a, _b, _c, _d
        'a1 = 10

        'Dim a, _b, _c, _d As Integer, minhaVariavelDecimal As Decimal
        'Dim a = 10, _b = 6, _c = 10, _d As Integer = 13

        'Use variable prior to assignment - se trocar para Error, a linha abaixo não compila
        'a = 10

        'a = 10
        '_b = 6
        '_c = 10
        '_d = 13

        'Option Explicit - se trocar para off, a linha abaixo é permitida
        'x = 25
        'Dim A As Integer

        ExibirValoresVariaveis()

        resultadoListBox.Items.Add(String.Format("_a * _b = {0}", _a * _b))
        resultadoListBox.Items.Add(String.Format("_c / _d = {0}", _c / _d))
        resultadoListBox.Items.Add(String.Format("_c \ _d = {0}", _c \ _d)) ' = 0, ou seja, a parte inteira
        'resultadoListBox.Items.Add(String.Format("_c / _d = {0}", CInt(_c / _d)))    ' = 1
        resultadoListBox.Items.Add(String.Format("_c / _d = {0}", Convert.ToInt32(_c / _d)))    ' = 1
        resultadoListBox.Items.Add("a Mod _c = " & _a Mod _c)
        resultadoListBox.Items.Add("a ^ _d = " & _a ^ _d)
        'resultadoListBox.Items.Add("a ^ _d = " & Math.Pow(a, _d))
    End Sub

    Private Sub ExibirValoresVariaveis()
        resultadoListBox.Items.Add("a = " & _a)
        resultadoListBox.Items.Add("_b = " & _b)
        resultadoListBox.Items.Add("_c = " & _c)
        resultadoListBox.Items.Add("_d = " & _d)
        'resultadoListBox.Items.Add(New String("-", 50))
        'resultadoListBox.Items.Add(New String(CChar("-"), 100))
        resultadoListBox.Items.Add(New String(Convert.ToChar("-"), 50))
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

        resultadoListBox.Items.Add(String.Format("a >= _b = {0}", _a >= _b))
        resultadoListBox.Items.Add(String.Format("_c <= _d = {0}", _c <= _d))
        resultadoListBox.Items.Add(String.Format("a <> _c = {0}", _a <> _c))
    End Sub

    Private Sub logicosToolStripMenuItem_Click(sender As System.Object, e As EventArgs) Handles logicosToolStripMenuItem.Click
        ExibirValoresVariaveis()

        resultadoListBox.Items.Add(String.Format("a < _b Or _c = _d = {0}", _a < _b Or _c = _d))
        resultadoListBox.Items.Add(String.Format("a = _b And _c <> _d = {0}", _a = _b And _c <> _d))
        resultadoListBox.Items.Add(String.Format("Not(a > _b) = {0}", Not (_a > _b)))
        resultadoListBox.Items.Add(String.Format("a < _b OrElse Foobar() = {0}", _a < _b OrElse Foobar()))
        resultadoListBox.Items.Add(String.Format("a = _b AndAlso Foobar() = {0}", _a = _b AndAlso Foobar()))
        'resultadoListBox.Items.Add(CBool(Foobar()))
    End Sub

    Private Function Foobar() As Boolean
        MessageBox.Show("Foobar")
        'Foobar = True
        Return True
    End Function

    Private Sub ternarioToolStripMenuItem_Click(sender As System.Object, e As EventArgs) Handles ternarioToolStripMenuItem.Click
        Dim ano = 2014
        resultadoListBox.Items.Add(String.Format("O ano {0} é bissexto? {1}.", ano, If(ano Mod 4 = 0, "Sim", "Não")))

        ano = 2016
        resultadoListBox.Items.Add(String.Format("O ano {0} é bissexto? {1}.", ano, IIf(DateTime.IsLeapYear(ano), "Sim", "Não")))

        'resultadoListBox.Items.Add((Not 23) > 14)
        'resultadoListBox.Items.Add(Not 23 > 67)
    End Sub

    Private Sub precedenciaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles precedenciaToolStripMenuItem.Click
        ExibirValoresVariaveis()

        resultadoListBox.Items.Add(String.Format("_a < _c OrElse _b <> _a AndAlso _a = _b = {0}", _a < _c OrElse _b <> _a AndAlso _a = _b))
    End Sub
End Class
