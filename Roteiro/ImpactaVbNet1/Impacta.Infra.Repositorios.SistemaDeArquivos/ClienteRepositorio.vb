Imports System.Configuration
Imports Impacta.Dominio
Imports System.IO

Public Class ClienteRepositorio
    Implements IClienteRepositorio

    'Dim Caminho As String = ConfigurationManager.AppSettings("caminhoArquivoClientes")

    Private ReadOnly Property Caminho As String
        Get
            Return ConfigurationManager.AppSettings("caminhoArquivoClientes")
        End Get
    End Property

    Public Function Selecionar() As List(Of Cliente) Implements IClienteRepositorio.Selecionar
        Dim retorno As New List(Of Cliente)
        Dim propriedades() As String
        Dim sr As New StreamReader(Caminho)

        Do While Not sr.EndOfStream
            propriedades = sr.ReadLine().Split(";"c)

            Dim cliente As New Cliente()
            cliente.Id = propriedades(0)
            cliente.Nome = propriedades(1)
            cliente.Endereco = propriedades(2)
            cliente.DataNascimento = Convert.ToDateTime(propriedades(3))
            cliente.Cpf = propriedades(4)
            cliente.Email = propriedades(5)
            cliente.Renda = Convert.ToDecimal(propriedades(6))

            retorno.Add(cliente)
        Loop

        Return retorno
    End Function

    Public Function Selecionar(nome As String) As List(Of Cliente) Implements IClienteRepositorio.Selecionar
        'Return Selecionar().Where(Function(x) x.Nome = nome).ToList()
        Dim retorno As New List(Of Cliente)
        Dim propriedades() As String
        Dim sr As New StreamReader(Caminho)

        Do While Not sr.EndOfStream
            propriedades = sr.ReadLine().Split(";"c)

            If propriedades(1).Contains(nome) Then
                Dim cliente As New Cliente()
                cliente.Id = propriedades(0)
                cliente.Nome = propriedades(1)
                cliente.Endereco = propriedades(2)
                cliente.DataNascimento = Convert.ToDateTime(propriedades(3))
                cliente.Cpf = propriedades(4)
                cliente.Email = propriedades(5)
                cliente.Renda = Convert.ToDecimal(propriedades(6))

                retorno.Add(cliente)
            End If
        Loop

        Return retorno
    End Function

    Public Sub Gravar(cliente As Cliente) Implements IClienteRepositorio.Gravar
        Dim registro = String.Format("{0};{1};{2};{3};{4};{5};{6}",
                                    cliente.Id,
                                    cliente.Nome,
                                    cliente.Endereco,
                                    cliente.DataNascimento.ToShortDateString(),
                                    cliente.Cpf,
                                    cliente.Email,
                                    cliente.Renda)
        TextoPuroRepositorio.Inserir(Caminho, registro)
    End Sub

    Public Sub Atualizar(cliente As Cliente) Implements IClienteRepositorio.Atualizar

    End Sub

    Public Sub Excluir(clienteId As String) Implements IClienteRepositorio.Excluir

    End Sub
End Class