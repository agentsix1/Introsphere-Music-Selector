Public Class frmSplash
    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub
    Public pubrelease = My.Settings.pubrelase
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = Version

        If pubrelease = False Then
            Try
                System.IO.File.Delete(appPath & "update.bat")
            Catch ex As Exception
            End Try
            Try
                System.IO.File.Delete(appPath & "add.api")
                System.IO.Directory.Delete(appPath & "files")
            Catch ex As Exception
            End Try
            My.Computer.Network.DownloadFile("http://introsphere.ga/intmc/default-add.api", appPath & "add.api")
        End If
        If Timer1.Interval = 3000 Then
            Timer1.Enabled = False
            Label1.Text = "Checking for Updates..."
            verOverride()
            CheckForUpdates()
            Label1.Text = "Checking sound database..."
            CheckSoundDatabase()
            Label1.Text = "Testing for first time user..."
            wait(1500)
            If My.Settings.steam = "" Then
                Timer1.Enabled = False
                setSteam()
                Exit Sub
            End If
            Label1.Text = "Searching for steam folder change requests..."
            wait(1500)
            If steamAPI() Then
                Exit Sub
            End If
            Label1.Text = "Searching for audio file change requests..."
            wait(1500)
            'If deleteAPI() Then
            'Exit Sub
            'End If
            If addAPI() And pubrelease = False Then
                My.Settings.pubrelase = True
                pubrelease = True
                My.Settings.Save()

                Exit Sub
            End If
            'If replaceAPI() Then
            'Exit Sub
            'End If
            Label1.Text = "Setting combo box with updated audio file list..."
            wait(1000)
            If My.Settings.audio_files_details = "" Then
                MsgBox("Could not find audio files to be change. Please download a patch from the forums to add songs to be changed.", vbCritical, "no audio files found")
                Me.Close()
            Else
                song_detail = Split(My.Settings.audio_files_details, "!=!")
                song_filename = Split(My.Settings.audio_files_filename, "!=!")
                song_custom = Split(My.Settings.audio_files_custom, "!=!")
            End If
            Label1.Text = "Setting the list of music in the list box..."
            wait(1000)
            music_list = Split(My.Settings.music, "|")
            Label1.Text = "Launching Program! Please wait..."
            wait(1500)
            Me.Hide()
            frmMain.Show()
            frmMain.ConsoleToolStripMenuItem.Visible = False
            frmMain.ToolStripMenuItem1.Visible = False
            frmMain.PrivateToolStripMenuItem.Visible = False
            frmMain.UsernameHereToolStripMenuItem.Visible = False
            frmMain.SettingsToolStripMenuItem.Visible = False
            Timer1.Enabled = False
        Else
            Label1.Text = "Launching Boot Sequence..."
            Timer1.Interval = 3000
        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    'Move Splash Screen
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Label3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label3.MouseDown
        drag = True
        mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
        mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top

    End Sub

    Private Sub Label3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label3.MouseUp
        drag = False
    End Sub

    Private Sub Label3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label3.MouseMove
        If drag Then
            Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
        End If

    End Sub
    'end of move splash screen
End Class
