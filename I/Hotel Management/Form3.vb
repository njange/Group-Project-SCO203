Imports System.Data.OleDb
Imports System.Runtime.CompilerServices

Public Class Form3
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HP 450 G7\source\repos\Hotel Management\Hotel Management\Hotel Transylvania4.accdb"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim checkInForm As New Form2()
        checkInForm.Show()
        Me.Hide()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Using conn As New OleDbConnection(connString)
                conn.Open()
                Dim query As String = "INSERT INTO Checkin (FirstName, LastName, IDNo, Gender, RoomType, CheckInDate, CheckOutDate) VALUES (@FirstName, @LastName, @IDNo, @Gender, @RoomType, @CheckInDate, @CheckOutDate)"
                Using cmd As New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("@FirstName", TextBox6.Text)
                    cmd.Parameters.AddWithValue("@LastName", TextBox5.Text)
                    cmd.Parameters.AddWithValue("@IDNo", Integer.Parse(TextBox4.Text))
                    cmd.Parameters.AddWithValue("@Gender", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@RoomType", TextBox3.Text)
                    cmd.Parameters.AddWithValue("@CheckInDate", DateTimePicker1.Value.Date)
                    cmd.Parameters.AddWithValue("@CheckOutDate", DateTimePicker2.Value.Date)
                    cmd.ExecuteNonQuery()
                End Using

            End Using
            MessageBox.Show("Data inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class