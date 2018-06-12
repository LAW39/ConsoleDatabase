Public Class AddonReturn
    Public AddonName As String
    Public AddonManufacturer As String
    Public AddonID As Integer
    Public ConsoleID As Integer
    Public AddonPrice As Boolean

    Public Overrides Function ToString() As String
        Dim AddonOutput As String


        AddonOutput = AddonName & " " & "<" & CStr(AddonManufacturer) & ">"

        Return AddonOutput

    End Function
End Class
