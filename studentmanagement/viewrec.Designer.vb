<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewrec
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StuddbDataSet = New studentmanagement.studdbDataSet()
        Me.StuddbDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StuddetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StuddetailsTableAdapter = New studentmanagement.studdbDataSetTableAdapters.StuddetailsTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RollnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StuddbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StuddbDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StuddetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.StudentnameDataGridViewTextBoxColumn, Me.RollnoDataGridViewTextBoxColumn, Me.ClassDataGridViewTextBoxColumn, Me.PercentageDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StuddetailsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(46, 162)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(374, 251)
        Me.DataGridView1.TabIndex = 0
        '
        'StuddbDataSet
        '
        Me.StuddbDataSet.DataSetName = "studdbDataSet"
        Me.StuddbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StuddbDataSetBindingSource
        '
        Me.StuddbDataSetBindingSource.DataSource = Me.StuddbDataSet
        Me.StuddbDataSetBindingSource.Position = 0
        '
        'StuddetailsBindingSource
        '
        Me.StuddetailsBindingSource.DataMember = "Studdetails"
        Me.StuddetailsBindingSource.DataSource = Me.StuddbDataSetBindingSource
        '
        'StuddetailsTableAdapter
        '
        Me.StuddetailsTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'StudentnameDataGridViewTextBoxColumn
        '
        Me.StudentnameDataGridViewTextBoxColumn.DataPropertyName = "Studentname"
        Me.StudentnameDataGridViewTextBoxColumn.HeaderText = "Studentname"
        Me.StudentnameDataGridViewTextBoxColumn.Name = "StudentnameDataGridViewTextBoxColumn"
        '
        'RollnoDataGridViewTextBoxColumn
        '
        Me.RollnoDataGridViewTextBoxColumn.DataPropertyName = "rollno"
        Me.RollnoDataGridViewTextBoxColumn.HeaderText = "rollno"
        Me.RollnoDataGridViewTextBoxColumn.Name = "RollnoDataGridViewTextBoxColumn"
        '
        'ClassDataGridViewTextBoxColumn
        '
        Me.ClassDataGridViewTextBoxColumn.DataPropertyName = "class"
        Me.ClassDataGridViewTextBoxColumn.HeaderText = "class"
        Me.ClassDataGridViewTextBoxColumn.Name = "ClassDataGridViewTextBoxColumn"
        '
        'PercentageDataGridViewTextBoxColumn
        '
        Me.PercentageDataGridViewTextBoxColumn.DataPropertyName = "percentage"
        Me.PercentageDataGridViewTextBoxColumn.HeaderText = "percentage"
        Me.PercentageDataGridViewTextBoxColumn.Name = "PercentageDataGridViewTextBoxColumn"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(100, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(289, 36)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "VIEW RECORDS"
        '
        'viewrec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 531)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "viewrec"
        Me.Text = "viewrec"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StuddbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StuddbDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StuddetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents StuddbDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StuddbDataSet As studentmanagement.studdbDataSet
    Friend WithEvents StuddetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StuddetailsTableAdapter As studentmanagement.studdbDataSetTableAdapters.StuddetailsTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RollnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PercentageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
