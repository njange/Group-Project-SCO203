Imports System.Data.OleDb
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form5
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HP 450 G7\source\repos\Hotel Management\Hotel Management\Hotel Transylvania4.accdb"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim checkInForm As New Form2()
        checkInForm.Show()
        Me.Hide()
    End Sub

    Private Sub TextBoxID_TextChanged(sender As Object, e As EventArgs) Handles TextBoxID.TextChanged

        Me.Controls.Add(TextBoxID)
        Me.Controls.Add(ButtonCheckOut)
    End Sub

    Private Sub ButtonCheckOut_Click(sender As Object, e As EventArgs) Handles ButtonCheckOut.Click
        Try

            If Integer.TryParse(TextBoxID.Text, Nothing) Then
                Dim idNo As Integer = Integer.Parse(TextBoxID.Text)

                Using conn As New OleDbConnection(connString)
                    conn.Open()
                    Dim query As String = "DELETE FROM Checkin WHERE IDNo = @IDNo"

                    Using cmd As New OleDbCommand(query, conn)
                        cmd.Parameters.AddWithValue("@IDNo", idNo)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Checkout successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Please enter a valid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class