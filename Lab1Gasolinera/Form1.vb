Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim d As Double
        Dim g As Integer
        Dim f As Integer

        a = TextBox1.Text
        b = TextBox2.Text
        c = a + b
        TextBox3.Text = c

        d = a / b
        TextBox4.Text = d

        g = a - b
        TextBox5.Text = g

        f = a * b
        TextBox6.Text = f

    End Sub
End Class
