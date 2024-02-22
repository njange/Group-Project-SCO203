Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
            MsgBox("Welcome to the system", MsgBoxStyle.Information, "Login")
        Else
            MsgBox("Please enter correct username and password", MsgBoxStyle.Critical, "Login")
        End If
    End Sub
End Class

