<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.



    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ReleaseDate = New System.Windows.Forms.DateTimePicker()
        Me.ConsoleListBox = New System.Windows.Forms.ListBox()
        Me.GoBtn = New System.Windows.Forms.Button()
        Me.IsRelease = New System.Windows.Forms.CheckBox()
        Me.ConsoleName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CNameLabel = New System.Windows.Forms.Label()
        Me.MakeName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IsGood = New System.Windows.Forms.RadioButton()
        Me.isBad = New System.Windows.Forms.RadioButton()
        Me.RemoveBtn = New System.Windows.Forms.Button()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.ExportBtn = New System.Windows.Forms.Button()
        Me.ImportBtn = New System.Windows.Forms.Button()
        Me.ClearBTN = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AddonListBox = New System.Windows.Forms.ListBox()
        Me.RemoveAddon = New System.Windows.Forms.Button()
        Me.EditAddon = New System.Windows.Forms.Button()
        Me.Manufacturer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AddonName = New System.Windows.Forms.TextBox()
        Me.AddAddon = New System.Windows.Forms.Button()
        Me.GamesListBox = New System.Windows.Forms.ListBox()
        Me.GameManufacturer = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GameName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ReleaseDate
        '
        Me.ReleaseDate.Location = New System.Drawing.Point(166, 87)
        Me.ReleaseDate.Name = "ReleaseDate"
        Me.ReleaseDate.Size = New System.Drawing.Size(197, 20)
        Me.ReleaseDate.TabIndex = 0
        Me.ReleaseDate.Value = New Date(2015, 11, 11, 12, 50, 0, 0)
        '
        'ConsoleListBox
        '
        Me.ConsoleListBox.FormattingEnabled = True
        Me.ConsoleListBox.Location = New System.Drawing.Point(391, 28)
        Me.ConsoleListBox.Name = "ConsoleListBox"
        Me.ConsoleListBox.Size = New System.Drawing.Size(225, 238)
        Me.ConsoleListBox.TabIndex = 1
        '
        'GoBtn
        '
        Me.GoBtn.Location = New System.Drawing.Point(166, 210)
        Me.GoBtn.Name = "GoBtn"
        Me.GoBtn.Size = New System.Drawing.Size(108, 25)
        Me.GoBtn.TabIndex = 2
        Me.GoBtn.Text = "Add Console"
        Me.GoBtn.UseVisualStyleBackColor = True
        '
        'IsRelease
        '
        Me.IsRelease.AutoSize = True
        Me.IsRelease.Location = New System.Drawing.Point(166, 113)
        Me.IsRelease.Name = "IsRelease"
        Me.IsRelease.Size = New System.Drawing.Size(77, 17)
        Me.IsRelease.TabIndex = 3
        Me.IsRelease.Text = "Released?"
        Me.IsRelease.UseVisualStyleBackColor = True
        '
        'ConsoleName
        '
        Me.ConsoleName.Location = New System.Drawing.Point(166, 31)
        Me.ConsoleName.Name = "ConsoleName"
        Me.ConsoleName.Size = New System.Drawing.Size(197, 20)
        Me.ConsoleName.TabIndex = 4
        Me.ConsoleName.Tag = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Manufacturer"
        '
        'CNameLabel
        '
        Me.CNameLabel.AutoSize = True
        Me.CNameLabel.Location = New System.Drawing.Point(57, 31)
        Me.CNameLabel.Name = "CNameLabel"
        Me.CNameLabel.Size = New System.Drawing.Size(76, 13)
        Me.CNameLabel.TabIndex = 7
        Me.CNameLabel.Text = "Console Name"
        '
        'MakeName
        '
        Me.MakeName.Location = New System.Drawing.Point(166, 61)
        Me.MakeName.Name = "MakeName"
        Me.MakeName.Size = New System.Drawing.Size(197, 20)
        Me.MakeName.TabIndex = 8
        Me.MakeName.Tag = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ReleaseDate"
        '
        'IsGood
        '
        Me.IsGood.AutoSize = True
        Me.IsGood.Location = New System.Drawing.Point(166, 136)
        Me.IsGood.Name = "IsGood"
        Me.IsGood.Size = New System.Drawing.Size(51, 17)
        Me.IsGood.TabIndex = 10
        Me.IsGood.Text = "Good"
        Me.IsGood.UseVisualStyleBackColor = True
        '
        'isBad
        '
        Me.isBad.AutoSize = True
        Me.isBad.Location = New System.Drawing.Point(166, 159)
        Me.isBad.Name = "isBad"
        Me.isBad.Size = New System.Drawing.Size(44, 17)
        Me.isBad.TabIndex = 11
        Me.isBad.Text = "Bad"
        Me.isBad.UseVisualStyleBackColor = True
        '
        'RemoveBtn
        '
        Me.RemoveBtn.Location = New System.Drawing.Point(166, 241)
        Me.RemoveBtn.Name = "RemoveBtn"
        Me.RemoveBtn.Size = New System.Drawing.Size(108, 25)
        Me.RemoveBtn.TabIndex = 12
        Me.RemoveBtn.Text = "Remove Console"
        Me.RemoveBtn.UseVisualStyleBackColor = True
        '
        'EditBtn
        '
        Me.EditBtn.Location = New System.Drawing.Point(166, 272)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(108, 25)
        Me.EditBtn.TabIndex = 13
        Me.EditBtn.Text = "Edit Console"
        Me.EditBtn.UseVisualStyleBackColor = True
        '
        'ExportBtn
        '
        Me.ExportBtn.Location = New System.Drawing.Point(166, 303)
        Me.ExportBtn.Name = "ExportBtn"
        Me.ExportBtn.Size = New System.Drawing.Size(51, 25)
        Me.ExportBtn.TabIndex = 14
        Me.ExportBtn.Text = "Export"
        Me.ExportBtn.UseVisualStyleBackColor = True
        '
        'ImportBtn
        '
        Me.ImportBtn.Location = New System.Drawing.Point(223, 303)
        Me.ImportBtn.Name = "ImportBtn"
        Me.ImportBtn.Size = New System.Drawing.Size(51, 25)
        Me.ImportBtn.TabIndex = 15
        Me.ImportBtn.Text = "Import"
        Me.ImportBtn.UseVisualStyleBackColor = True
        '
        'ClearBTN
        '
        Me.ClearBTN.Location = New System.Drawing.Point(166, 182)
        Me.ClearBTN.Name = "ClearBTN"
        Me.ClearBTN.Size = New System.Drawing.Size(108, 25)
        Me.ClearBTN.TabIndex = 16
        Me.ClearBTN.Text = "Clear"
        Me.ClearBTN.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Is good or bad?"
        '
        'AddonListBox
        '
        Me.AddonListBox.FormattingEnabled = True
        Me.AddonListBox.Location = New System.Drawing.Point(167, 353)
        Me.AddonListBox.Name = "AddonListBox"
        Me.AddonListBox.Size = New System.Drawing.Size(450, 95)
        Me.AddonListBox.TabIndex = 18
        '
        'RemoveAddon
        '
        Me.RemoveAddon.Location = New System.Drawing.Point(479, 454)
        Me.RemoveAddon.Name = "RemoveAddon"
        Me.RemoveAddon.Size = New System.Drawing.Size(137, 25)
        Me.RemoveAddon.TabIndex = 20
        Me.RemoveAddon.Text = "Remove Addon"
        Me.RemoveAddon.UseVisualStyleBackColor = True
        '
        'EditAddon
        '
        Me.EditAddon.Location = New System.Drawing.Point(318, 454)
        Me.EditAddon.Name = "EditAddon"
        Me.EditAddon.Size = New System.Drawing.Size(156, 25)
        Me.EditAddon.TabIndex = 21
        Me.EditAddon.Text = "Edit Addon"
        Me.EditAddon.UseVisualStyleBackColor = True
        '
        'Manufacturer
        '
        Me.Manufacturer.Location = New System.Drawing.Point(318, 525)
        Me.Manufacturer.Name = "Manufacturer"
        Me.Manufacturer.Size = New System.Drawing.Size(197, 20)
        Me.Manufacturer.TabIndex = 25
        Me.Manufacturer.Tag = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(205, 499)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Addon Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(205, 525)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Manufacturer"
        '
        'AddonName
        '
        Me.AddonName.Location = New System.Drawing.Point(318, 499)
        Me.AddonName.Name = "AddonName"
        Me.AddonName.Size = New System.Drawing.Size(197, 20)
        Me.AddonName.TabIndex = 22
        Me.AddonName.Tag = "Name"
        '
        'AddAddon
        '
        Me.AddAddon.Location = New System.Drawing.Point(167, 454)
        Me.AddAddon.Name = "AddAddon"
        Me.AddAddon.Size = New System.Drawing.Size(145, 25)
        Me.AddAddon.TabIndex = 26
        Me.AddAddon.Text = "Add Addon"
        Me.AddAddon.UseVisualStyleBackColor = True
        '
        'GamesListBox
        '
        Me.GamesListBox.FormattingEnabled = True
        Me.GamesListBox.Location = New System.Drawing.Point(622, 28)
        Me.GamesListBox.Name = "GamesListBox"
        Me.GamesListBox.Size = New System.Drawing.Size(225, 420)
        Me.GamesListBox.TabIndex = 27
        '
        'GameManufacturer
        '
        Me.GameManufacturer.Location = New System.Drawing.Point(732, 511)
        Me.GameManufacturer.Name = "GameManufacturer"
        Me.GameManufacturer.Size = New System.Drawing.Size(197, 20)
        Me.GameManufacturer.TabIndex = 31
        Me.GameManufacturer.Tag = "Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(619, 485)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Game Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(619, 511)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Manufacturer"
        '
        'GameName
        '
        Me.GameName.Location = New System.Drawing.Point(732, 485)
        Me.GameName.Name = "GameName"
        Me.GameName.Size = New System.Drawing.Size(197, 20)
        Me.GameName.TabIndex = 28
        Me.GameName.Tag = "Name"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 674)
        Me.Controls.Add(Me.GameManufacturer)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GameName)
        Me.Controls.Add(Me.GamesListBox)
        Me.Controls.Add(Me.AddAddon)
        Me.Controls.Add(Me.Manufacturer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AddonName)
        Me.Controls.Add(Me.EditAddon)
        Me.Controls.Add(Me.RemoveAddon)
        Me.Controls.Add(Me.AddonListBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ClearBTN)
        Me.Controls.Add(Me.ImportBtn)
        Me.Controls.Add(Me.ExportBtn)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.RemoveBtn)
        Me.Controls.Add(Me.isBad)
        Me.Controls.Add(Me.IsGood)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MakeName)
        Me.Controls.Add(Me.CNameLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ConsoleName)
        Me.Controls.Add(Me.IsRelease)
        Me.Controls.Add(Me.GoBtn)
        Me.Controls.Add(Me.ConsoleListBox)
        Me.Controls.Add(Me.ReleaseDate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Form1 As System.Windows.Forms.Form
    Friend WithEvents ReleaseDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ConsoleListBox As System.Windows.Forms.ListBox
    Friend WithEvents GoBtn As System.Windows.Forms.Button
    Friend WithEvents IsRelease As System.Windows.Forms.CheckBox
    Friend WithEvents ConsoleName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CNameLabel As System.Windows.Forms.Label
    Friend WithEvents MakeName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IsGood As System.Windows.Forms.RadioButton
    Friend WithEvents isBad As System.Windows.Forms.RadioButton
    Friend WithEvents RemoveBtn As System.Windows.Forms.Button
    Friend WithEvents EditBtn As System.Windows.Forms.Button
    Friend WithEvents ExportBtn As System.Windows.Forms.Button
    Friend WithEvents ImportBtn As System.Windows.Forms.Button
    Friend WithEvents ClearBTN As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AddonListBox As System.Windows.Forms.ListBox
    Friend WithEvents RemoveAddon As System.Windows.Forms.Button
    Friend WithEvents EditAddon As System.Windows.Forms.Button
    Friend WithEvents Manufacturer As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AddonName As System.Windows.Forms.TextBox
    Friend WithEvents AddAddon As System.Windows.Forms.Button
    Friend WithEvents GamesListBox As System.Windows.Forms.ListBox
    Friend WithEvents GameManufacturer As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GameName As System.Windows.Forms.TextBox

End Class
