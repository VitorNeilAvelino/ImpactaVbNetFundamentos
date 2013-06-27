Imports System.Runtime.Serialization

<Serializable()>
<DataContract()>
Public Enum SituacaoConectividade
    <EnumMember()>
    NaoDefinida = 0
    <EnumMember()>
    Conectado = 1
    <EnumMember()>
    Desconectado = 2
    <EnumMember()>
    Ausente = 3
End Enum