Imports Impacta.Infra.Apoio

Public Class AbasForm

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged, CheckBox2.CheckedChanged
        Formulario.ModificarPropriedadesCaixaDeTexto(TabPage1, DirectCast(sender, CheckBox))
    End Sub
End Class