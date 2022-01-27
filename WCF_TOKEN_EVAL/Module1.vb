Imports System
Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.IO
Imports System.Runtime.Serialization
Imports System.ServiceModel.Web
Imports System.ServiceModel.Description
Imports System.ServiceModel
Imports System.ServiceModel.Activation

<ServiceContract>
Public Interface IService

    <OperationContract()>
    <WebGet(UriTemplate:="SeekToken/{DataToMerge}", ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)>
    Function SeekToken(ByVal DataToMerge As String) As List(Of token_eval)

End Interface
Public Class Service
    Implements IService

    Public Function SeekToken(ByVal DataToMerge As String) As List(Of token_eval) Implements IService.SeekToken
        Dim TokenCollection As New List(Of token_eval)()

        TokenCollection.Add(New token_eval(1, DataToMerge & "Arnold29", "Daimon*/"))
        TokenCollection.Add(New token_eval(2, "Eminnem60", "Mendez-*/"))
        TokenCollection.Add(New token_eval(3, "Silvester889", "Stallone*@1"))
        TokenCollection.Add(New token_eval(4, "Scarlet_J7", "johanson19998"))
        Return TokenCollection
    End Function
End Class
Module Module1
    Sub Main()
        Dim SetupWCF As WebServiceHost = New WebServiceHost(GetType(Service),
                                         New Uri("http://localhost:8000/"))
        SetupWCF.Open()
        Console.WriteLine("Press <ENTER> to stop the WCF Self-Hosted")
        Console.ReadLine()
    End Sub

End Module
