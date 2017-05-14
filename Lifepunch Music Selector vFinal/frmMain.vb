Public Class frmMain
    Public selected As Integer = -1
    Private Sub frmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmSplash.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (System.IO.File.Exists(appPath & "Introsphere_Music_Selector_update.exe")) Then
            If (System.IO.File.Exists(appPath & "Introsphere_Music_Selector_update.exe")) Then
                If (System.IO.File.Exists(appPath & "Introsphere Music Selector.exe")) Then
                    System.IO.File.Delete(appPath & "Introsphere Music Selector.exe")
                    System.IO.File.WriteAllText(appPath & "update.bat", "" &
                                                "@Echo Off" & vbCrLf &
                                                "ren Introsphere_Music_Selector_update.exe ""Introsphere Music Selector.exe""" & vbCrLf &
                                                "start ""Introsphere Music Selector.exe""")
                End If
            End If
        End If

        Me.Text = title
        'Set Picturebox Image
        Dim currentDate As DateTime = DateTime.Now
        Dim Year
        If currentDate.Month = "12" Then
            Year = "0001"
        Else
            Year = "0002"
        End If
        Dim startDate As Date = #12/1/0001#
        Dim endDate As Date = #1/15/0002#
        Dim edate = currentDate.Month & "/" & currentDate.Day & "/" & Year
        Dim testDate As Date = Date.ParseExact(edate, "M/d/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
        'If testDate > startDate AndAlso testDate < endDate Then
        'pbLogo.Image = My.Resources.lp_christmas_logo
        'End If
        'Image Set!

        'Add Audio Files
        For Each item In song_custom
            If Not item = "" Then
                ComboBox1.Items.Add(item)
            End If
        Next
        For Each item In music_list
            If Not item = "" Then
                ListBox1.Items.Add(item)
            End If

        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            If ListBox1.Items.Item(ListBox1.SelectedIndex) = "" Then
                MsgBox("You need to select a audio file that you would like to change.")
            Else
                For Each pre As String In Split(sound_list_database, vbCrLf)
                    Dim files() = Split(My.Settings.audio_files_custom, "!=!")
                    Dim i As Integer = 0
                    For Each file In files
                        Dim sound() = Split(pre, "|")
                        If (ComboBox1.Text.Equals(file) And sound(0).Equals(Split(My.Settings.audio_files_filename, "!=!")(i))) Then
                            System.IO.File.Copy(ListBox1.Items.Item(ListBox1.SelectedIndex), gmod & Split(My.Settings.audio_files_details, "!=!")(i), True)
                            MsgBox("Done!")
                        End If
                        i = i + 1
                    Next
                Next


            End If
        Catch ex As Exception
            MsgBox("You need to select a audio file that you would like to change.")
        End Try

    End Sub
    Public gmod = My.Settings.steam & "\garrysmod\"
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If ComboBox1.Text = "" Then
            MsgBox("You need to select a audio file that you would like to restore.")
        Else
            Dim sound_loc = ""
            For Each pre As String In Split(sound_list_database, vbCrLf)
                Dim sound() = Split(pre, "|")
                Dim files() = Split(My.Settings.audio_files_custom, "!=!")
                Dim i As Integer = 0
                For Each file In files
                    ''MsgBox(ComboBox1.Text & " = " & file & " | " & sound(0) & " = " & Split(My.Settings.audio_files_filename, "!=!")(i))
                    If (ComboBox1.Text.Equals(file) And sound(0).Equals(Split(My.Settings.audio_files_filename, "!=!")(i))) Then
                        If (System.IO.File.Exists(appPath & "files\" & Split(My.Settings.audio_files_filename, "!=!")(i))) Then
                            If ComboBox1.Text = "" Then
                                MsgBox("You need to select a audio file that you would like to restore.")
                            Else
                                System.IO.File.Copy(appPath & "files\" & Split(My.Settings.audio_files_filename, "!=!")(i), gmod & Split(My.Settings.audio_files_details, "!=!")(i), True)
                                MsgBox("Done!")
                            End If
                        Else
                            Dim out = MsgBox("It appears you have not already downloaded the file for this sound. Would you like to download the sound now to continue this process?", vbYesNo, "No file")
                            If out = DialogResult.Yes Then
                                My.Computer.Network.DownloadFile(sound(1), appPath & "files\" & Split(My.Settings.audio_files_filename, "!=!")(i))
                                System.IO.File.Copy(appPath & "files\" & Split(My.Settings.audio_files_filename, "!=!")(i), gmod & Split(My.Settings.audio_files_details, "!=!")(i), True)
                                MsgBox("Done!")
                                Exit For
                            End If
                        End If
                    End If
                    i = i + 1
                Next

            Next
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result As System.Windows.Forms.DialogResult = ofdBrowse.ShowDialog()
        If result = System.Windows.Forms.DialogResult.OK Then
            If Not ListBox1.Items.Contains(ofdBrowse.FileName) Then
                ListBox1.Items.Add(ofdBrowse.FileName)
                Dim temp_list
                Dim stuff = Split(My.Settings.music, "|")
                Dim i = 0
                For Each song In stuff
                    If i = 0 Then
                        temp_list = song
                        i += 1
                    Else
                        temp_list = temp_list & "|" & song
                    End If
                Next
                temp_list = temp_list & "|" & ofdBrowse.FileName
                My.Settings.music = temp_list
                My.Settings.Save()
            End If
        ElseIf result = System.Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex = 0 Or ListBox1.SelectedIndex = 1 Then
            ListBox1.SetSelected(1, False)
            ListBox1.SetSelected(0, False)
        Else
            If Not System.IO.File.Exists(ListBox1.SelectedItem) And Not ListBox1.SelectedItem = "" Then
                My.Settings.music = My.Settings.music.Replace(ListBox1.SelectedItem, "")
                My.Settings.Save()
                ListBox1.Items.Remove(ListBox1.SelectedItem)
                MsgBox("The file you clicked does not appear to be at the location provided. This has been removed from this list.", vbCritical, "Missing")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedIndex < ListBox1.Items.Count - 1 Then
            Dim I = ListBox1.SelectedIndex + 2
            ListBox1.Items.Insert(I, ListBox1.SelectedItem)
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            ListBox1.SelectedIndex = I - 1
        End If
        Dim b = 0
        My.Settings.music = ""
        For Each ln In ListBox1.Items
            If b > 1 Then
                My.Settings.music = My.Settings.music & "|" & ln
            End If
            b += 1
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedIndex > 2 Then
            Dim I = ListBox1.SelectedIndex - 1
            ListBox1.Items.Insert(I, ListBox1.SelectedItem)
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            ListBox1.SelectedIndex = I
        End If
        Dim b = 0
        My.Settings.music = ""
        For Each ln In ListBox1.Items
            If b > 1 Then
                My.Settings.music = My.Settings.music & "|" & ln
            End If
            b += 1
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListBox1.SelectedIndex > 1 Then
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            Dim b = 0
            My.Settings.music = ""
            For Each ln In ListBox1.Items
                If b > 1 Then
                    My.Settings.music = My.Settings.music & "|" & ln
                End If
                b += 1
            Next
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Label2.Visible Then
            Label2.Visible = False
            TextBox1.Visible = True
            Button7.Text = "Close Full Log"
        Else
            Label2.Visible = True
            TextBox1.Visible = False
            Button7.Text = "View Full Log"
        End If
    End Sub

    Private Sub ConsoleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsoleToolStripMenuItem.Click
        If Not Me.Height = 628 Then
            Me.Height = 628
        Else
            Me.Height = 449
        End If

    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        CheckForUpdates()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        selected = ComboBox1.SelectedIndex
        'MsgBox(selected)


    End Sub
End Class