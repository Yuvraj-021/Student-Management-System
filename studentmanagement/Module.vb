

Imports System.Data.OleDb

Module Module1

    Public cn As New OleDb.OleDbConnection
    Public cmd As New OleDbCommand
    Public da As New OleDbDataAdapter
    Public ds As New DataSet
    Public ds1 As New DataSet
    Public ds2 As New DataSet
    Public dt As New DataTable
    Public str As String
    Public adapt As New OleDbDataAdapter("select * from studdb", cn)

    Public Sub conn()

        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=D:\db\studdb.accdb "


    End Sub




End Module

