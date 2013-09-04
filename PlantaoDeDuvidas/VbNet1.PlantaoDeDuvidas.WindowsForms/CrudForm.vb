Imports System.Data.SqlClient

Public Class CrudForm

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim conexao As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=ImpactaVbNet1;Integrated Security=True;Pooling=False")
        Dim instrucao = String.Format("Insert into Cliente(Nome, DataNascimento, Email, Endereco) values('{0}', '{1}', '{2}', '{3}')", TextBox1.Text, DateTime.Now, "Email",
                                      "Endereço")
        Dim comando As New SqlCommand(instrucao, conexao)
        conexao.Open()
        comando.ExecuteNonQuery()
        conexao.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ImpressaoForm.Show()
        Call New ImpressaoForm().Show()
    End Sub
End Class