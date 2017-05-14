Imports System
Imports System.IO
Module Module1
    Public title As String = "Introsphere Music Selector " & shorVersion & " - By: [INT] Agentsix1"
    Public ver As Boolean = False
    Public Version = "v1.0 4-30-17"
    Public shorVersion = Split(Version, " ")(0)
    Public song_detail()
    Public song_filename()
    Public song_custom()
    Public music_list()
    Public sound_list_database = ""
    Public appPath As String = Application.StartupPath() & "\"
    Public Function steamAPI()
        If System.IO.File.Exists(appPath & "gmod.api") Then
            setSteam()
            System.IO.File.Delete(appPath & "gmod.api")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function addAPI()
        If System.IO.File.Exists(appPath & "add.api") Then
            addFiles()
            System.IO.File.Delete(appPath & "add.api")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function deleteAPI()
        If System.IO.File.Exists(appPath & "delete.api") Then
            delFiles()
            System.IO.File.Delete(appPath & "delete.api")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function replaceAPI()
        If System.IO.File.Exists(appPath & "replace.api") Then
            repFiles()
            System.IO.File.Delete(appPath & "replace.api")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function verOverride()
        If System.IO.File.Exists(appPath & "vertrue.api") Then
            System.IO.File.Delete(appPath & "vertrue.api")
            My.Settings.ver = True
            My.Settings.Save()
            Return True
        ElseIf System.IO.File.Exists(appPath & "verfalse.api") Then
            System.IO.File.Delete(appPath & "verfalse.api")
            My.Settings.ver = False
            My.Settings.Save()
            Return True
        Else
            Return False
        End If
    End Function

    Public Function CheckForUpdates()
        frmSplash.Label1.Text = "Checking For Updates..."
        Dim client As Net.WebClient = New Net.WebClient()
        Dim reader As IO.StreamReader = New IO.StreamReader(client.OpenRead("https://pastebin.com/dgzKDERx"))
        Dim info As String() = Split(reader.ReadToEnd, vbCrLf)
        Dim filename As String = info(2)
        Dim LatestVer = info(0)
        If LatestVer = Version And Not ver Then
            frmSplash.Label1.Text = "You appear to be up to date..."
            wait(1000)
        Else
            Dim Result As DialogResult = MessageBox.Show("You are needing to update as you are currently out of date. Would you like to be redirect to the latest version?", "Needs Updating", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If Result = System.Windows.Forms.DialogResult.Yes Then
                Try
                    System.IO.File.Delete(Application.StartupPath & "\" & filename)
                    My.Computer.Network.DownloadFile(info(1), Application.StartupPath & "\" & filename)
                Catch ex As Exception
                    MsgBox("The update server may be offline try again later" & info(1), vbInformation, "Error")
                End Try

                If System.IO.File.Exists(Application.StartupPath & "\" & filename) Then
                    MsgBox("We now need you to restart your program. Another program will breifly open and your updated program will launch. Lets do this", vbInformation, "Important Info")
                    System.IO.File.WriteAllText(Application.StartupPath & "\update.bat", "" & "
                                                @echo off
                                                del /F ""Introsphere Music Selector.exe.pre " & info(0) & """
                                                ren """ & Application.ExecutablePath & """ ""Introsphere Music Selector v" & Version & ".exe.bak""""
                                                del /F ""Introsphere Music Selector.exe""" & vbCrLf & "
                                                ren """ & filename & """ """ & Application.ExecutablePath & """
                                                start """" """ & Application.ExecutablePath & """")
                    frmSplash.Close()
                    frmMain.Close()
                    frmSteam.Close()
                    Process.Start(Application.StartupPath & "\update.bat")
                    wait(1000)
                End If
            End If

        End If
    End Function

    Public Function CheckSoundDatabase()
        wait(5000)
        Dim wbCFU As New WebBrowser
        wbCFU.Navigate(New Uri("https://pastebin.com/raw/QPbFTnmr"))
        While wbCFU.IsBusy
            wait(100)
        End While
        wait(2000)
        Try
            sound_list_database = Split(Split(wbCFU.DocumentText, "<PRE>")(1), "</PRE>")(0)
        Catch ex As Exception
            MsgBox("The sound database server may be offline try again later", vbInformation, "Error")
        End Try

    End Function

    Public Sub addFiles()
        If My.Settings.audio_files_details = "" Then
            Dim addFile() = System.IO.File.ReadAllLines(appPath & "add.api")
            For Each ln In addFile
                Dim a() = Split(ln, "|")
                If My.Settings.audio_files_details = "" Then
                    My.Settings.audio_files_details = a(0)
                    My.Settings.audio_files_filename = a(1)
                    My.Settings.audio_files_custom = a(2)
                Else
                    Dim temp_song_detail() = Split(My.Settings.audio_files_details, "!=!")
                    If Not temp_song_detail.Contains(a(0)) Then
                        My.Settings.audio_files_details = My.Settings.audio_files_details & "!=!" & a(0) & "!=!"
                        My.Settings.audio_files_filename = My.Settings.audio_files_filename & "!=!" & a(1) & "!=!"
                        My.Settings.audio_files_custom = My.Settings.audio_files_custom & "!=!" & a(2) & "!=!"
                        My.Settings.Save()
                    End If
                End If
            Next
        Else
            Dim addFile() = System.IO.File.ReadAllLines(appPath & "add.api")
            For Each ln In addFile
                Dim temp_song_detail() = Split(My.Settings.audio_files_details, "!=!")
                Dim a() = Split(ln, "|")
                If Not temp_song_detail.Contains(a(0)) Then
                    My.Settings.audio_files_details = My.Settings.audio_files_details & "!=!" & a(0) & "!=!"
                    My.Settings.audio_files_filename = My.Settings.audio_files_filename & "!=!" & a(1) & "!=!"
                    My.Settings.audio_files_custom = My.Settings.audio_files_custom & "!=!" & a(2) & "!=!"
                    My.Settings.Save()
                End If
            Next


        End If
        System.IO.File.Delete(appPath & "add.api")
        frmSplash.Timer1.Enabled = True
    End Sub

    Public Sub delFiles()

        Dim songdetail() = Split(My.Settings.audio_files_details, "!=!")
        Dim songcustom() = Split(My.Settings.audio_files_custom, "!=!")
        Dim songfilename() = Split(My.Settings.audio_files_filename, "!=!")
        Dim songs = File.ReadAllLines(appPath & "delete.api")
        Dim i = 0
        For Each it In songdetail
            For Each s In songs
                If s = it Then
                    My.Settings.audio_files_custom = My.Settings.audio_files_custom.Replace(songcustom(i) & "!=!", "")
                    My.Settings.audio_files_details = My.Settings.audio_files_details.Replace(songdetail(i) & "!=!", "")
                    My.Settings.audio_files_filename = My.Settings.audio_files_filename.Replace(songfilename(i) & "!=!", "")
                    My.Settings.Save()
                End If
            Next
            i += 1
        Next
        System.IO.File.Delete(appPath & "delete.api")
        frmSplash.Timer1.Enabled = True
    End Sub

    Public Sub repFiles()
    End Sub

    Public Sub setSteam()
        Dim yNSelect As Boolean = False
        Dim out = MsgBox("Would you like to manually select your steam folder or scan your computer to find all the steam folders on your computer. WARNING: Scanning can some times take up to 3 hours to complete. Depending on how many harddrives and files/folders you have on your computer", vbYesNoCancel, "Manually find Steam Folder?")
        If (out = DialogResult.Yes) Then
            yNSelect = True
        ElseIf (out = DialogResult.Cancel) Then
            frmSplash.Close()
        End If
        If yNSelect Then
            frmSteam.Show()
            frmSteam.ListBox1.Visible = False
            frmSteam.Label3.Visible = False
        Else
            frmSplash.Label1.Text = "Scanning computer to find possible steam folders..."
            wait(1)
            frmSplash.Timer1.Enabled = False
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
            frmSplash.Label1.Text = "Scan is complete. Select 1 of the folders or choose your own folder to use."
            frmSteam.Show()
            frmSteam.Hide()
            Dim steamLines() = Split(lines, vbCrLf)
            For Each ln In steamLines
                If System.IO.Directory.Exists(ln & "\garrysmod\download") Then
                    frmSteam.ListBox1.Items.Add(ln)
                End If
            Next
            If frmSteam.ListBox1.Items.Count > 0 Then
                frmSteam.Show()
            Else
                frmSteam.Show()
                MsgBox("We could not find your steam folder. Please select a steam folder for the program to read.", vbInformation, "No Steam Folder Found")
            End If
        End If


    End Sub

    Public Sub wait(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            ' Allows UI to remain responsive
            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub
End Module
