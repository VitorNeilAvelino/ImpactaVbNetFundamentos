Imports Impacta.Dominio
Imports System.Data.SqlClient

Public Class ClienteRepositorio
    Inherits RepositorioBase
    Implements IClienteRepositorio

    'Public Sub New()
    '    AbrirConexao()
    'End Sub

    Private Sub AbrirConexao()
        If Conexao.State <> ConnectionState.Open Then
            Conexao.Open()
        End If
    End Sub

    ''' <summary>
    ''' Método Selecionar usando ADO.NET. A instrução a ser executada foi "chumbada" dentro do próprio método.
    ''' </summary>
    Public Function Selecionar() As List(Of Cliente) Implements IClienteRepositorio.Selecionar
        Dim retorno As New List(Of Cliente)

        Const instrucao As String = "Select * from Cliente Order by Nome"

        Dim comando As New SqlCommand(instrucao, Conexao)

        For Each registro In comando.ExecuteReader
            Dim cliente As New Cliente
            cliente.Id = registro("Id")
            cliente.Nome = registro("Nome")
            cliente.Endereco = registro("Endereco")
            cliente.Email = registro("Email")

            retorno.Add(cliente)
        Next

        If Conexao.State = ConnectionState.Open Then
            Conexao.Close()
        End If

        Return retorno
    End Function

    Function Selecionar(nome As String) As List(Of Cliente) Implements IClienteRepositorio.Selecionar
    End Function

    ''' <summary>
    ''' Método Gravar usando ADO.NET. As instruções para a gravação estão dentro da procedure spGravarCliente.
    ''' </summary>
    Sub Gravar(cliente As Cliente) Implements IClienteRepositorio.Gravar
        AbrirConexao()

        Dim comando As New SqlCommand("spGravarCliente", Conexao)

        Try
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = cliente.Nome
            comando.Parameters.Add("@DataNascimento", SqlDbType.Date).Value = cliente.DataNascimento
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = cliente.Email
            comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = cliente.Endereco
            comando.ExecuteNonQuery()
        Finally
            FecharConexao()
        End Try
    End Sub

    Private Sub FecharConexao()
        If Conexao IsNot Nothing AndAlso Conexao.State <> ConnectionState.Closed Then
            Conexao.Close()
        End If
    End Sub

    Sub Atualizar(cliente As Cliente) Implements IClienteRepositorio.Atualizar
        Dim comando As New SqlCommand("spAtualizarCliente", Conexao)

        Try
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@Id", SqlDbType.VarChar).Value = cliente.Id
            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = cliente.Nome
            comando.Parameters.Add("@DataNascimento", SqlDbType.Date).Value = cliente.DataNascimento
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = cliente.Email
            comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = cliente.Endereco
            comando.ExecuteNonQuery()
        Finally
            If comando IsNot Nothing Then comando.Dispose()
            If Conexao IsNot Nothing AndAlso Conexao.State <> ConnectionState.Closed Then Conexao.Close()
        End Try
    End Sub

    Sub Excluir(clienteId As String) Implements IClienteRepositorio.Excluir
        Dim comando As New SqlCommand("spExcluirCliente", Conexao)

        Try
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@Id", SqlDbType.VarChar).Value = clienteId
            comando.ExecuteNonQuery()
        Finally
            If comando IsNot Nothing Then comando.Dispose()
            If Conexao IsNot Nothing AndAlso Conexao.State <> ConnectionState.Closed Then Conexao.Close()
        End Try
    End Sub
End Class