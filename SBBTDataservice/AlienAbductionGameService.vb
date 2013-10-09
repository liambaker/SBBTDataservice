Public Class AlienAbductionGameService
    Implements IAlienAbductionGameService

    Public Function GetData(ByVal value As Integer) As String Implements IAlienAbductionGameService.GetData
        Return String.Format("You entered: {0}", value)
    End Function

    Public Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType Implements IAlienAbductionGameService.GetDataUsingDataContract
        If composite Is Nothing Then
            Throw New ArgumentNullException("composite")
        End If
        If composite.BoolValue Then
            composite.StringValue &= "Suffix"
        End If
        Return composite
    End Function

End Class
