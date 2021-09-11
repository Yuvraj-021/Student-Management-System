Imports System.Data.OleDb
Public Class deleterec
    Dim str1 As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If

            str1 = "Delete from Studdetails Where [rollno]=" & TextBox2.Text & ""


            Dim myupdate1 As New OleDbCommand(str1, cn)
            myupdate1.ExecuteNonQuery()
            MessageBox.Show("Record deleted successfully")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub deleterec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Clear()


        Dim ctr, i As Integer
        ds.Clear()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Module1.conn()
        cn.Open()
    End Sub
End Class