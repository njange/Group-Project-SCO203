Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Login.Click
        ' Check if the username is at least 3 characters long
        If Username.Text.Length < 3 Then
            MsgBox("Username must be at least 3 characters long.")
            Return
        End If
        ' Check if the password is at least 8 characters long
        If Password.Text.Length < 8 Then
            MsgBox("Password must be at least 8 characters long.")
            Return
        End If
        ' Check if the password contains at least one digit
        If Not Password.Text.Any(Function(c) Char.IsDigit(c)) Then
            MsgBox("Password must contain at least one digit.")
            Return
        End If
        ' Check if the password contains at least one special character
        If Not Password.Text.Any(Function(c) Not Char.IsLetterOrDigit(c)) Then
            MsgBox("Password must contain at least one special character.")
            Return
        End If
        ' If all checks pass, show a success message
        MsgBox("Login successful!")
    End Sub

    Private Sub SeePassword_CheckedChanged(sender As Object, e As EventArgs) Handles SeePassword.CheckedChanged
        ' Toggle password visibility based on the state of the checkbox
        Password.UseSystemPasswordChar = Not SeePassword.Checked
    End Sub

    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged
        ' Ensure password remains visible if user is typing in it while checkbox is checked
        If SeePassword.Checked Then
            Password.UseSystemPasswordChar = False
        Else
            ' If checkbox is not checked, always hide the password
            Password.UseSystemPasswordChar = True
        End If
    End Sub


End Class
