Imports System.Data.SqlClient
Imports System.Configuration

Public Class RepositorioBase
    Private _conexao As SqlConnection

    Public ReadOnly Property Conexao As SqlConnection
        'As New SqlConnection(ConfigurationManager.ConnectionStrings("impactaVbNet1ConnectionString").ConnectionString)
        Get
            If _conexao Is Nothing Then
                _conexao =
                    New SqlConnection(
                        ConfigurationManager.ConnectionStrings("impactaVbNet1ConnectionString").ConnectionString)
            End If
            Return _conexao
        End Get
    End Property
End Class
