Public Class ConsoleReturn
    Public ConsoleName As String
    Public ConsoleMake As String
    Public ConsoleID As Integer
    Public ConsoleReleased As Boolean
    Public ConsoleReleaseDate As Date
    Public ConsoleIsGood As Boolean

    Public Overrides Function ToString() As String
        Dim ConsoleOutput As String

        ConsoleOutput = ConsoleName & " " & "<" & CStr(ConsoleMake) & ">"

        Return ConsoleOutput
    End Function

End Class
