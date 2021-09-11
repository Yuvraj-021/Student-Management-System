Imports System.Data.OleDb

Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ctr, i As Integer
        Dim che As Integer = 0
        Dim emp As String = ""
        ds.Clear()
        'cn.Open()
        str = "select * from Login"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "Login")
        ctr = ds.Tables("Login").Rows.Count - 1
        For i = 0 To ctr
            If ds.Tables("Login").Rows(i)(1).ToString = TextBox1.Text And ds.Tables("Login").Rows(i)(2).ToString = TextBox2.Text Then
                MsgBox("Login SuccessFull")
                Me.Hide()
                main_menu.Show()
            End If
        Next
    End Sub
End Class
