Public Class Fornecedor
    Inherits Pessoa

    Public Property RamoAtividade As RamoAtividade

    Public Overrides Sub Validar()
        Throw New NotImplementedException
    End Sub
End Class
