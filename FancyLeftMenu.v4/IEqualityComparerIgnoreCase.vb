


Friend Class IEqualityComparerIgnoreCase
    Implements IEqualityComparer(Of String)

#Region "IEquality Comparer - Ignore Case"
    Public Function Equals1(x As String, y As String) As Boolean Implements IEqualityComparer(Of String).Equals
        Return equalsIgnoreCase(x, y)
    End Function

    Public Function GetHashCode1(obj As String) As Integer Implements IEqualityComparer(Of String).GetHashCode
        Return obj.GetHashCode()
    End Function



    ''' <summary>
    ''' Checks if String1 equals String2 Ignoring the Case Sensitivity
    ''' </summary>
    ''' <param name="str1"></param>
    ''' <param name="str2"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function equalsIgnoreCase(ByVal str1 As String, ByVal str2 As String) As Boolean
        If str1 Is Nothing AndAlso str2 Is Nothing Then Return True
        If str1 Is Nothing OrElse str2 Is Nothing Then Return False


        Return str1.ToLower().Equals(str2.ToLower())
    End Function

#End Region

End Class

