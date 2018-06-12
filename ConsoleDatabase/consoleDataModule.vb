Module consoleDataModule
    Public Function nextConsoleID(ByRef consoleList As List(Of ConsoleReturn)) As Integer
        nextConsoleID = 1
        For Each currentConsole As ConsoleReturn In consoleList
            If (currentConsole.ConsoleID >= nextConsoleID) Then
                nextConsoleID = currentConsole.ConsoleID + 1
            End If
        Next
    End Function

    Public Function nextAddonID(ByRef Addonlist As List(Of AddonReturn)) As Integer
        nextAddonID = 1
        For Each currentAddon As AddonReturn In Addonlist
            If (currentAddon.AddonID >= nextAddonID) Then
                nextAddonID = currentAddon.AddonID + 1
            End If
        Next
    End Function
    Public Function nextUserID(ByRef userlist As List(Of UserReturn)) As Integer
        nextUserID = 1
        For Each currentUser As UserReturn In userlist
            If (currentUser.UserID >= nextUserID) Then
                nextUserID = currentUser.UserID + 1
            End If
        Next
    End Function

    Public Function WriteConsoleFile(ByRef consolelist As List(Of ConsoleReturn), ByVal Path As String)
        Dim writeString As String
        Dim FileStream As System.IO.StreamWriter
        Dim Filepath As String = Path

        WriteConsoleFile = False
        FileStream = New System.IO.StreamWriter(Path)
        For Each currentConsole As ConsoleReturn In consolelist
            writeString = currentConsole.ConsoleID & "," & currentConsole.ConsoleMake & "," & currentConsole.ConsoleName & "," & currentConsole.ConsoleReleased & "," & currentConsole.ConsoleReleaseDate & "," & currentConsole.ConsoleIsGood
            FileStream.WriteLine(writeString)
        Next

        FileStream.Close()
        WriteConsoleFile = True
    End Function

    Public Function AddonExport(ByRef AddonList As List(Of AddonReturn), ByVal Path As String, ByVal DirLocation As Integer)
        Dim writeString As String
        Dim FileStream As System.IO.StreamWriter
        Dim Filepath As String = Path
        For i = 1 To Len(Filepath)
            If Mid(Filepath, i, 1) = "\" Then
                DirLocation = i
            End If
        Next
        Filepath = Mid(Filepath, 1, DirLocation)
        Filepath = Filepath & "\addonlist"
        AddonExport = False
        FileStream = New System.IO.StreamWriter(Filepath)
        For Each currentAddon As AddonReturn In AddonList
            writeString = currentAddon.AddonID & "," & currentAddon.AddonName & "," & currentAddon.AddonManufacturer & "," & currentAddon.ConsoleID
            FileStream.WriteLine(writeString)
        Next

        FileStream.Close()
        AddonExport = True
    End Function

    Public Function importConsoleFile(ByRef consolelist As List(Of ConsoleReturn), ByVal filepath As String) As Boolean
        Dim ReadStream As System.IO.StreamReader
        Dim CurrentLine As String
        Dim CurrentData As String
        Dim Consoledata As List(Of String)

        importConsoleFile = False

        consolelist.Clear()

        Consoledata = New List(Of String)

        ReadStream = New System.IO.StreamReader(filepath)

        While (ReadStream.Peek() <> -1)

            CurrentLine = ReadStream.ReadLine
            Consoledata.Clear()

            CurrentData = ""

            For i = 0 To CurrentLine.Length - 1
                If (CurrentLine.Chars(i) = ",") Then
                    Consoledata.Add(CurrentData)
                    CurrentData = ""
                Else
                    CurrentData = CurrentData & CurrentLine.Chars(i)
                End If
            Next

            Consoledata.Add(CurrentData)
            Dim newConsole = New ConsoleReturn()
            newConsole.ConsoleID = Consoledata.Item(0)
            newConsole.ConsoleMake = Consoledata.Item(1)
            newConsole.ConsoleName = Consoledata.Item(2)
            newConsole.ConsoleReleased = Consoledata.Item(3)
            newConsole.ConsoleReleaseDate = Consoledata.Item(4)
            newConsole.ConsoleIsGood = Consoledata.Item(5)
            consolelist.Add(newConsole)
        End While

        ReadStream.Close()

        importConsoleFile = True
    End Function

    Public Function importAddonFile(ByRef Addonlist As List(Of AddonReturn), ByVal filepath As String) As Boolean
        Dim ReadStream As System.IO.StreamReader
        Dim CurrentLine As String
        Dim CurrentData As String
        Dim AddonData As List(Of String)

        Addonlist.Clear()

        importAddonFile = False


        AddonData = New List(Of String)





        ReadStream = New System.IO.StreamReader(filepath)

        While (ReadStream.Peek() <> -1)

            CurrentLine = ReadStream.ReadLine
            AddonData.Clear()

            CurrentData = ""

            For i = 0 To CurrentLine.Length - 1
                If (CurrentLine.Chars(i) = ",") Then
                    AddonData.Add(CurrentData)
                    CurrentData = ""
                Else
                    CurrentData = CurrentData & CurrentLine.Chars(i)
                End If
            Next

            AddonData.Add(CurrentData)
            Dim newAddon = New AddonReturn()
            newAddon.AddonID = AddonData.Item(0)
            newAddon.AddonManufacturer = AddonData.Item(1)
            newAddon.AddonName = AddonData.Item(2)
            newAddon.ConsoleID = AddonData.Item(3)

            Addonlist.Add(newAddon)
        End While

        ReadStream.Close()

        importAddonFile = True
    End Function
End Module
