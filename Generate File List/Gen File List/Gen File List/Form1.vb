Public Class frmMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fbdLocation.ShowDialog()
        Label1.Text = fbdLocation.SelectedPath
    End Sub

    Private Sub btnPastebin_Click(sender As Object, e As EventArgs) Handles btnPastebin.Click
        For Each Files As String In System.IO.Directory.GetFiles(Label1.Text)
            txtList.Text = txtList.Text & vbCrLf & Files.Replace(Label1.Text & "\", "")
        Next
        For Each Dir As String In System.IO.Directory.GetDirectories(Label1.Text)
            If containsDirectories(Dir) Then
                For Each Files As String In System.IO.Directory.GetFiles(Dir)
                    txtList.Text = txtList.Text & vbCrLf & Files.Replace(Label1.Text & "\", "")
                Next
                continueSearch(Dir)
            Else
                For Each Files As String In System.IO.Directory.GetFiles(Dir)
                    txtList.Text = txtList.Text & vbCrLf & Files.Replace(Label1.Text & "\", "")
                Next
            End If
        Next
        MsgBox("Complete")
    End Sub

    Public Sub continueSearch(path As String)
        For Each Dir As String In System.IO.Directory.GetDirectories(path)
            If containsDirectories(Dir) Then
                For Each Files As String In System.IO.Directory.GetFiles(Dir)
                    txtList.Text = txtList.Text & vbCrLf & Files.Replace(Label1.Text & "\", "")
                Next
                continueSearch(Dir)
            Else
                For Each Files As String In System.IO.Directory.GetFiles(Dir)
                    txtList.Text = txtList.Text & vbCrLf & Files.Replace(Label1.Text & "\", "")
                Next
            End If
        Next
    End Sub

    Public Function containsDirectories(path As String)
        For Each Dir As String In System.IO.Directory.GetDirectories(path)
            Return True
        Next
        Return False
    End Function
End Class
