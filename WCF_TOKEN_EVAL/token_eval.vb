Imports System.Runtime.Serialization
<DataContract>
Public Class token_eval

    Private m_IdToken As Integer
    Private m_Username As String
    Private m_Password As String
    <DataMember>
    Public Property IdToken() As Integer
        Get
            Return m_IdToken
        End Get
        Set(ByVal value As Integer)
            m_IdToken = value
        End Set
    End Property
    <DataMember>
    Public Property Username() As String
        Get
            Return m_Username
        End Get
        Set(ByVal value As String)
            m_Username = value
        End Set
    End Property
    <DataMember>
    Public Property Password() As String
        Get
            Return m_Password
        End Get
        Set(ByVal value As String)
            m_Password = value
        End Set
    End Property

    Public Sub New(ByVal IdToken As Integer, ByVal Username As String, ByVal Password As String)
        Me.m_IdToken = IdToken
        Me.m_Username = Username
        Me.m_Password = Password
    End Sub
End Class
