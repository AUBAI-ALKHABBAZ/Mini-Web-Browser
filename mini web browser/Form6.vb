Public Class form6

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x, y, z As Double
        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)
        z = x + y
        TextBox3.Text = z.ToString

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim x, y, z As Double
        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)
        z = x - y
        TextBox3.Text = z.ToString
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim x, y, z As Double
        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)
        z = x * y
        TextBox3.Text = z.ToString
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim x, y, z As Double
        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)
        z = x / y
        TextBox3.Text = z.ToString
    End Sub

    Private Sub form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim x, y, z As Double
        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)
        z = x * x
        z = y * y

        TextBox3.Text = z.ToString
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim x, y, z As Double
        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)
        z = x * 3.14
        z = y * 3.14
    End Sub
End Class