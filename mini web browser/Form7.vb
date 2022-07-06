Public Class Form7
    Dim myimages As Array
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FolderBrowserDialog1.ShowDialog()
        If FolderBrowserDialog1.SelectedPath = "" Then
        Else
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
        End If
        myimages = IO.Directory.GetFiles(TextBox1.Text)
        ListBox1.Items.AddRange(myimages)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        PictureBox1.ImageLocation = ListBox1.SelectedItem
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim j As Integer = ListBox1.SelectedIndex
        For I = 0 To ListBox1.Items.Count - 1
            If I = j + 1 Then
                ListBox1.SetSelected(I, True)
            Else
                ListBox1.SetSelected(I, False)
            End If
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim j As Integer = ListBox1.SelectedIndex
        For I = 0 To ListBox1.Items.Count - 1
            If I = j + 1 Then
                ListBox1.SetSelected(I, True)
            Else
                ListBox1.SetSelected(I, False)
            End If
        Next
    End Sub
End Class