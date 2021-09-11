
Imports System.Data.OleDb
Public Class addrec

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If

            If TextBox1.Text = " " Then
                MessageBox.Show("please enter name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf TextBox2.Text = "" Then
                MessageBox.Show("please enter roll no ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf TextBox3.Text = "" Then
                MessageBox.Show("please enter class ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf TextBox4.Text = "" Then
                MessageBox.Show("please enter percentage ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                MessageBox.Show("Record saved successfully")

            End If


            Dim str As String

            str = "Insert into Studdetails([Studentname],[rollno],[class],[percentage])values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"

            Dim myinsert1 As New OleDbCommand(str, cn)
            myinsert1.ExecuteNonQuery()
            Me.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub addrec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

        Dim ctr, i As Integer
        ds.Clear()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Module1.conn()
        cn.Open()
    End Sub
End Class