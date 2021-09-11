Imports System.Data.OleDb
Imports System.IO
Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Clear()
        TextBox2.Clear()


        Dim ctr, i As Integer
        ds.Clear()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Module1.conn()
        cn.Open()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If

            If TextBox1.Text = " " Then
                MessageBox.Show("please enter name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf TextBox2.Text = "" Then
                MessageBox.Show("please enter password ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim str As String

                str = "Insert into Login([Username],[Password])values('" & TextBox1.Text & "','" & TextBox2.Text & "')"

                Dim myinsert1 As New OleDbCommand(str, cn)
                myinsert1.ExecuteNonQuery()
                MessageBox.Show("Record saved successfully")
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class