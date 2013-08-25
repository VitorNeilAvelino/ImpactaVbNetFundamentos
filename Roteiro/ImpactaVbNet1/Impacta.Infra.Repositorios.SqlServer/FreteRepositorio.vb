Imports System.Configuration
Imports Impacta.Dominio
Imports System.Data.SqlClient

Public Class FreteRepositorio
    Implements IFreteRepositorio

    Public Sub Inserir(ByVal frete As Frete) Implements IFreteRepositorio.Inserir
        Dim conexao As New SqlConnection(ConfigurationManager.ConnectionStrings("impactaVbNet1ConnectionString").ConnectionString)
        Dim instrucao = String.Format("Insert Frete(Cliente_Id, ValorCarga, UfDestino, Percentual) values(@Cliente_Id, @ValorCarga, @UfDestino, @Percentual)")
        Dim comando = New SqlCommand(instrucao, conexao)

        comando.Parameters.Add("@Cliente_Id", SqlDbType.Int).Value = frete.Cliente.Id
        comando.Parameters.Add("@ValorCarga", SqlDbType.Decimal).Value = frete.ValorCarga
        comando.Parameters.Add("@UfDestino", SqlDbType.VarChar).Value = frete.UfDestino
        comando.Parameters.Add("@Percentual", SqlDbType.Decimal).Value = frete.Percentual

        conexao.Open()
        comando.ExecuteNonQuery()
        conexao.Close()
    End Sub

    Public Function Selecionar() As List(Of Frete) Implements IFreteRepositorio.Selecionar
        Throw New NotImplementedException()
    End Function

    Public Sub Atualizar(ByVal frete As Frete) Implements IFreteRepositorio.Atualizar
        Throw New NotImplementedException()
    End Sub

    Public Sub Excluir(ByVal freteId As Integer) Implements IFreteRepositorio.Excluir
        Throw New NotImplementedException()
    End Sub
End Class