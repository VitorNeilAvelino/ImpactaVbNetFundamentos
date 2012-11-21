'ToDo: OO - herança
Public MustInherit Class Pessoa
    Public Sub New()
        Id = Guid.NewGuid()
        Documentos = New List(Of Documento)
    End Sub

    Public Property Id As New Guid()

    'ToDo: OO - encapsulamento
    Private _nome As String

    Public Property Nome() As String
        Get
            Return _nome
        End Get
        Set(ByVal value As String)
            _nome = value.ToUpper()
        End Set
    End Property

    'Public Property Nome As String
    Public Property Endereco As String
    Public Property Documentos As List(Of Documento)
    Public Property Email As String

    Public MustOverride Sub Validar()
End Class
