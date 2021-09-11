Public Class viewrec

    Private Sub viewrec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StuddbDataSet.Studdetails' table. You can move, or remove it, as needed.
        Me.StuddetailsTableAdapter.Fill(Me.StuddbDataSet.Studdetails)

    End Sub
End Class