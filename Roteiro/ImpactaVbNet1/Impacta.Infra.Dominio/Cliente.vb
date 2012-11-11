'Friend = internal
'Todo: OO - Abstração (classes de negócio - entidades)
Public Class Cliente
    Inherits Pessoa
    'Public Nome As String
    'property tab

    Const idadeMinima As Integer = 18

    Public Property Renda As Decimal
    Public Property DataNascimento As DateTime
    'Nullable(Of DateTime)

    ''' <summary>
    ''' Propriedade não mapeada no banco de dados
    ''' </summary>
    Public Property Cpf() As String
        Get
            Return (From x In Documentos
                Where x.Tipo = TipoDocumento.Cpf
                Select x.Numero).FirstOrDefault
        End Get
        Set(value As String)
            Dim documento = New Documento()
            documento.Tipo = TipoDocumento.Cpf
            documento.Numero = value
            Documentos.Add(documento)
        End Set
    End Property

    Public Property Sexo As String
    Public Property EstadoCivil As String
    Public Property Preferencial As Boolean
    Public Property Pais As String

    'ToDo: OO - polimorfismo por substituição - sobrescrita
    Public Overrides Sub Validar()
        If DataNascimento > DateTime.Now.AddYears(- idadeMinima) Then
            Throw New RegraNegocioException(String.Format("O cliente deve ter no mínimo {0} anos.", idadeMinima))
        End If
    End Sub
End Class