Public Class frmSteam
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As System.Windows.Forms.DialogResult = fbdSteam.ShowDialog()
        If result = System.Windows.Forms.DialogResult.OK Then
            If Not System.IO.Directory.Exists(fbdSteam.SelectedPath & "\garrysmod\download") Then
                MsgBox("That location is not a valid garrys mod install location.", , "Invalid Location")
            Else
                Label1.Text = fbdSteam.SelectedPath
            End If
        ElseIf result = System.Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not Label1.Text = "" Then
            My.Settings.steam = Label1.Text
            My.Settings.Save()
            frmSplash.Label1.Text = "A steam folder has been selected!"
            frmSplash.Timer1.Enabled = True
            Me.Close()
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If Not ListBox1.SelectedItem = "" Then
            Label1.Text = ListBox1.Items(ListBox1.SelectedIndex)
        End If
    End Sub

    Private Sub frmSteam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = title
    End Sub
End Class