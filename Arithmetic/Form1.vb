﻿Public Class Form1
//simple aithmatic operations
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, c As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        c = a + b
        TextBox3.Text = c
    End Sub
End Class
