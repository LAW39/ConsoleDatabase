Imports System.Reflection
Imports System.Text
Public Class Form1

    Dim myDateString As String
    Dim storedDateTime As Date
    Dim dateString As String
    Dim createdConsole As ConsoleReturn
    Dim ConsoleList As List(Of ConsoleReturn)
    Dim Addonlist As List(Of AddonReturn)
    Dim UserList As List(Of UserReturn)
    Dim openFileDialog1 As Object



    Private Sub populateConsoleListBox()
        ConsoleListBox.Items.Clear()
        ConsoleList.Sort(Function(x, y) x.ConsoleName.CompareTo(y.ConsoleName))
        For Each Console As ConsoleReturn In ConsoleList
            ConsoleListBox.Items.Add(Console)
        Next
    End Sub



    Private Sub populateAddonListBox()
        Dim SelectedConsole As ConsoleReturn
        SelectedConsole = ConsoleListBox.SelectedItem
        AddonListBox.Items.Clear()
        Addonlist.Sort(Function(x, y) x.AddonName.CompareTo(y.AddonName))
        If (ConsoleListBox.SelectedIndex = -1) Then
            Exit Sub
        End If
        For Each Addon As AddonReturn In Addonlist
            If Addon.ConsoleID = SelectedConsole.ConsoleID Then
                AddonListBox.Items.Add(Addon)
            End If
        Next
    End Sub


    Private Sub GoBtn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoBtn.Click

        Dim NewConsole = New ConsoleReturn()
        Dim NewLBIndex As Integer

        NewConsole.ConsoleName = ConsoleName.Text
        NewConsole.ConsoleMake = MakeName.Text
        NewConsole.ConsoleID = nextConsoleID(ConsoleList)
        NewConsole.ConsoleReleased = IsRelease.Checked
        NewConsole.ConsoleReleaseDate = ReleaseDate.Value
        NewConsole.ConsoleIsGood = IsGood.Checked

        ConsoleList.Add(NewConsole)

        populateConsoleListBox()
        NewLBIndex = ConsoleListBox.Items.IndexOf(NewConsole)
        ConsoleListBox.SelectedIndex = NewLBIndex
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConsoleList = New List(Of ConsoleReturn)
        Addonlist = New List(Of AddonReturn)
        UserList = New List(Of UserReturn)
    End Sub

    Private Sub EditBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditBtn.Click
        If (ConsoleListBox.SelectedIndex = -1) Then
            Exit Sub
        End If
        Dim SavingConsole As ConsoleReturn
        Dim RecordIndex As Integer

        SavingConsole = ConsoleListBox.SelectedItem

        SavingConsole.ConsoleName = ConsoleName.Text
        SavingConsole.ConsoleMake = MakeName.Text
        SavingConsole.ConsoleID = SavingConsole.ConsoleID
        SavingConsole.ConsoleReleased = IsRelease.Checked
        SavingConsole.ConsoleReleaseDate = ReleaseDate.Value
        SavingConsole.ConsoleIsGood = IsGood.Checked

        populateConsoleListBox()
        populateAddonListBox()
        RecordIndex = ConsoleListBox.Items.IndexOf(SavingConsole)

        ConsoleListBox.SelectedIndex = RecordIndex




    End Sub

    Private Sub ImportBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportBtn.Click
        Dim Addonpath As String
        Dim DirLocation As Integer
        openFileDialog1 = New OpenFileDialog()
        openFileDialog1.checkfileexists = True
        openFileDialog1.title = "Select file to import"
        If openFileDialog1.showdialog() = Windows.Forms.DialogResult.OK Then
            For i = 1 To Len(openFileDialog1.filename)
                If Mid(openFileDialog1.filename, i, 1) = "\" Then
                    DirLocation = i
                End If
            Next
            Addonpath = Mid(openFileDialog1.filename, 1, DirLocation)
            importConsoleFile(ConsoleList, openFileDialog1.filename)
            importAddonFile(Addonlist, Addonpath & "\addonlist")
            populateConsoleListBox()
        End If




    End Sub

    Private Sub ExportBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportBtn.Click
        openFileDialog1 = New SaveFileDialog()
        openFileDialog1.overwriteprompt = True
        openFileDialog1.title = "Export Console data to file"
        Dim DirLocation As Integer
        If openFileDialog1.showdialog() = Windows.Forms.DialogResult.OK Then
            
            WriteConsoleFile(ConsoleList, openFileDialog1.filename)
            AddonExport(Addonlist, openFileDialog1.filename, DirLocation)
        End If
    End Sub

    Private Sub ConsoleListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsoleListBox.SelectedIndexChanged
        Dim SelectedConsole As ConsoleReturn
        If (ConsoleListBox.SelectedIndex = -1) Then
            Exit Sub
        End If
        populateAddonListBox()
        SelectedConsole = ConsoleListBox.SelectedItem

        If (SelectedConsole.ConsoleReleased) Then
            IsRelease.Checked = True
        Else
            IsRelease.Checked = False
        End If

        ConsoleName.Text = SelectedConsole.ConsoleName
        MakeName.Text = SelectedConsole.ConsoleMake
        ReleaseDate.Value = SelectedConsole.ConsoleReleaseDate

        If SelectedConsole.ConsoleIsGood Then
            IsGood.Checked = True
            isBad.Checked = False

        Else
            isBad.Checked = True
            IsGood.Checked = False

        End If


        AddonName.Text = ""
        Manufacturer.Text = ""

    End Sub

    Private Sub RemoveBtn_Click(sender As System.Object, e As System.EventArgs) Handles RemoveBtn.Click



        Dim SelectedConsole As ConsoleReturn
        SelectedConsole = ConsoleListBox.SelectedItem
        If (ConsoleListBox.SelectedIndex = -1) Then
            Exit Sub
        End If

        Dim endOfList As Boolean
        Dim loopCounter As Integer = 0

        While endOfList = False
            endOfList = True
            If loopCounter < Addonlist.IndexOf(Addonlist.Last) Then
                Addonlist.Remove(Addonlist(loopCounter))
                endOfList = False
            End If
        End While
        

        Dim RemoveConsole As ConsoleReturn
        If ConsoleListBox.SelectedIndex = -1 Then
            Exit Sub
        End If

        RemoveConsole = ConsoleListBox.SelectedItem


        ClearBTN_Click(e, System.EventArgs.Empty)
        ConsoleList.Remove(RemoveConsole)
        populateConsoleListBox()
        populateAddonListBox()
    End Sub

    Private Sub ClearBTN_Click(sender As System.Object, e As System.EventArgs) Handles ClearBTN.Click
        ConsoleListBox.SelectedIndex = -1
        ReleaseDate.Value = "11/11/2015 12:50"
        ConsoleName.Text = ""
        MakeName.Text = ""
        IsRelease.Checked = False
        IsGood.Checked = False
        isBad.Checked = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub EditAddon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditAddon.Click
        If (ConsoleListBox.SelectedIndex = -1) Then
            Exit Sub
        End If
        If (AddonListBox.SelectedIndex = -1) Then
            Exit Sub
        End If
        Dim SavingAddon As AddonReturn
        Dim RecordIndex As Integer
        Dim SelectedConsole As ConsoleReturn
        SelectedConsole = ConsoleListBox.SelectedItem
        RecordIndex = ConsoleListBox.SelectedIndex
        SavingAddon = AddonListBox.SelectedItem

        SavingAddon.AddonName = AddonName.Text
        SavingAddon.AddonManufacturer = Manufacturer.Text
        SavingAddon.ConsoleID = SelectedConsole.ConsoleID

        populateAddonListBox()
        RecordIndex = ConsoleListBox.Items.IndexOf(SavingAddon)

        ConsoleListBox.SelectedIndex = RecordIndex
    End Sub

    Private Sub RemoveAddon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveAddon.Click
        If (ConsoleListBox.SelectedIndex = -1) Then
            Exit Sub
        End If
        If (AddonListBox.SelectedIndex = -1) Then
            Exit Sub
        End If
        Dim RemoveAddon As AddonReturn
        If AddonListBox.SelectedIndex = -1 Then
            Exit Sub
        End If

        RemoveAddon = AddonListBox.SelectedItem

        Addonlist.Remove(RemoveAddon)

        populateAddonListBox()
    End Sub

    Private Sub AddonListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddonListBox.SelectedIndexChanged
        Dim SelectedAddon As AddonReturn
        If (AddonListBox.SelectedIndex = -1) Then
            Exit Sub
        End If
        SelectedAddon = AddonListBox.SelectedItem


        AddonName.Text = SelectedAddon.AddonName
        Manufacturer.Text = SelectedAddon.AddonManufacturer



    End Sub



    Private Sub AddAddon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddAddon.Click
        If (ConsoleListBox.SelectedIndex = -1) Then
            MsgBox("Please select console you would like to add addon for")
            Exit Sub
        End If
        Dim RecordIndex As Integer
        Dim SelectedConsole As ConsoleReturn
        SelectedConsole = ConsoleListBox.SelectedItem

        Dim SavingAddon = New AddonReturn()

        SavingAddon.AddonName = AddonName.Text
        SavingAddon.AddonManufacturer = Manufacturer.Text
        SavingAddon.ConsoleID = SelectedConsole.ConsoleID

        populateAddonListBox()
        RecordIndex = ConsoleListBox.Items.IndexOf(SavingAddon)

        Addonlist.Add(SavingAddon)
        populateAddonListBox()
        ConsoleListBox.SelectedIndex = RecordIndex
        Me.Close()
    End Sub

End Class
