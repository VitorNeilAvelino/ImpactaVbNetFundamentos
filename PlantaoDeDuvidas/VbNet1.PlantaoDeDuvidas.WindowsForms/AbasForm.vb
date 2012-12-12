Imports Impacta.Infra.Apoio

Public Class AbasForm

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged, CheckBox2.CheckedChanged
        Formulario.ModificarPropriedadesCaixaDeTexto(TabPage1, DirectCast(sender, CheckBox))
    End Sub

    Private Sub AbasForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ImpactaVbNet1DataSet.Cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.ImpactaVbNet1DataSet.Cliente)
        BindingNavigator1.BindingSource = ClienteBindingSource
    End Sub
End Class