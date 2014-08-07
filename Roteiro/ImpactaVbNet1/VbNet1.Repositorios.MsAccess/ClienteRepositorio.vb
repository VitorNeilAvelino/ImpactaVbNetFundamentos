Imports System.Data.OleDb

Public Class ClienteRepositorio
    Public Sub Inserir(cliente As Impacta.Dominio.Cliente)

        Dim caminho = "C:\Users\Vitor\Documents\Aulas\Impacta\CSharp\II\Pedido.accdb"

        Using con As New OleDbConnection(String.Format("Provider=Microsoft.ACE.OLEDB.12.0;DataSource={0};", caminho))

            con.Open()

            Using cmd As New OleDbCommand
                cmd.CommandText = "Insert Cliente (Nome, DataNascimento, Email) values(?, ?, ?)"

                cmd.Parameters.AddWithValue("@p1", cliente.Nome)
                cmd.Parameters.AddWithValue("@p2", cliente.DataNascimento)
                cmd.Parameters.AddWithValue("@p3", cliente.Email)

                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class