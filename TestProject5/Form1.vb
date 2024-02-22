Public Class Form1
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        If Username.Text = "admin" And Password.Text = "admin" Then
            MsgBox("Login Successful")
        Else
            MsgBox("Login Failed")
        End If
    End Sub
End Class
