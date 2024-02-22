Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim checkInForm As New Form2()
        checkInForm.Show()
        Me.Hide()
    End Sub
End Class