Public Class UserReturn

    Public UserName As String
    Public UserID As Integer
    Public ConsoleID As Integer

    Public Overrides Function ToString() As String
        Dim AddonOutput As String


        AddonOutput = UserName & " " & "<" & CStr(UserID) & ">"

        Return AddonOutput

    End Function
End Class
