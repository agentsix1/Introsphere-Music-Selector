Imports System.IO

Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text.Equals("Auto Find") Then
            Label4.Visible = True
            Dim yNSelect As Boolean = False
            Dim out = MsgBox("Would you like to manually select your steam folder or scan your computer to find all the steam folders on your computer. WARNING: Scanning can some times take up to 3 hours to complete. Depending on how many harddrives and files/folders you have on your computer", vbYesNoCancel, "Manually find Steam Folder?")
            If (out = DialogResult.Yes) Then
                yNSelect = True
            ElseIf (out = DialogResult.Cancel) Then
                Return
            End If
            If yNSelect Then
                Label4.Visible = False
            Else
                Dim preSteamFolders As String()
                Dim steamFolders As String()
                Dim steam As String()
                Dim allDrives() As DriveInfo = DriveInfo.GetDrives()
                Dim lines
                For Each d In allDrives
                    If d.DriveType.ToString = "Fixed" Then
                        preSteamFolders = Directory.GetDirectories(d.Name.ToString)
                        steam = Directory.GetDirectories(d.Name.ToString, "Steam")
                        For Each line In steam
                            lines = line & vbCrLf & lines
                        Next
                        For Each folder In preSteamFolders
                            Try
                                steamFolders = Directory.GetDirectories(folder, "GarrysMod", SearchOption.AllDirectories)
                                For Each line In steamFolders
                                    lines = line & vbCrLf & lines
                                Next
                            Catch ex As Exception

                            End Try
                        Next

                    End If


                Next
                Dim steamLines() = Split(lines, vbCrLf)
                For Each ln In steamLines
                    ListBox1.Enabled = True
                    If System.IO.Directory.Exists(ln & "\garrysmod\sound") Then
                        ListBox1.Items.Add(ln)
                    End If
                Next
                If ListBox1.Items.Count > 0 Then
                Else
                    MsgBox("We could not find your steam folder. Please select a steam folder for the program to read.", vbInformation, "No Steam Folder Found")
                End If
            End If
            Label4.Visible = False
            Button2.Text = "Set Steam Folder"
        Else
            My.Settings.steam = ListBox1.SelectedItem
            My.Settings.Save()
            Label1.Text = ListBox1.SelectedItem
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = My.Settings.steam
        If (Label1.Text.Equals("")) Then
            Button3.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As System.Windows.Forms.DialogResult = fbdSteam.ShowDialog()
        If result = System.Windows.Forms.DialogResult.OK Then
            If Not System.IO.Directory.Exists(fbdSteam.SelectedPath & "\garrysmod\sound") Then
                MsgBox("That location is not a valid garrys mod install location.", , "Invalid Location")
            Else
                Label1.Text = fbdSteam.SelectedPath
                My.Settings.steam = fbdSteam.SelectedPath
                My.Settings.Save()
            End If
        ElseIf result = System.Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
    End Sub

    Private Sub Label1_TextChanged(sender As Object, e As EventArgs) Handles Label1.TextChanged
        If (Not Label1.Text.Equals("")) Then
            Button3.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim client As Net.WebClient = New Net.WebClient()
        Dim reader As IO.StreamReader = New IO.StreamReader(client.OpenRead("https://pastebin.com/raw/qMc2HnMU"))
        Dim info As String() = Split(reader.ReadToEnd, vbCrLf)
        reader = New IO.StreamReader(client.OpenRead("https://pastebin.com/raw/dWSBtjua"))
        Dim dateContent As String = reader.ReadToEnd
        For Each Files In info
            If System.IO.File.Exists(Label1.Text & "\garrysmod\" & Files) Then
                System.IO.File.Delete(Label1.Text & "\garrysmod\" & Files)
            End If
            'MsgBox("http://introsphere.ga/content_packs/" & dateContent & "/" & Files.Replace("\", "/") & "   -   " & Label1.Text & "\garrysmod\" & Files)
            My.Computer.Network.DownloadFile("http://introsphere.ga/content_packs/" & dateContent & "/" & Files.Replace("\", "/"), Label1.Text & "\garrysmod\" & Files)
        Next
        MsgBox("Complete!")
    End Sub
End Class
