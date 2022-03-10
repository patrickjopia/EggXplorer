<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewResto
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.resto_added_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RestoaddedbyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RestoIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RestonameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RestolocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RestobranchDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RestoratingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbleggXrestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EggX_restoDataSet = New EggXplorer.eggX_restoDataSet()
        Me.Tbl_eggX_restoTableAdapter = New EggXplorer.eggX_restoDataSetTableAdapters.tbl_eggX_restoTableAdapter()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbleggXrestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EggX_restoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(391, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Restaurant Name"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Search By Name", "Search By Branch"})
        Me.ComboBox1.Location = New System.Drawing.Point(704, 18)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(130, 21)
        Me.ComboBox1.TabIndex = 31
        Me.ComboBox1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(492, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(189, 20)
        Me.TextBox1.TabIndex = 30
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"PDF", "CSV", "EXCEL"})
        Me.ComboBox2.Location = New System.Drawing.Point(213, 17)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(119, 21)
        Me.ComboBox2.TabIndex = 29
        Me.ComboBox2.Text = "PDF"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 30)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Refresh Grid"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'resto_added_date
        '
        Me.resto_added_date.DataPropertyName = "resto_added_date"
        Me.resto_added_date.HeaderText = "resto_added_date"
        Me.resto_added_date.Name = "resto_added_date"
        Me.resto_added_date.Width = 118
        '
        'RestoaddedbyDataGridViewTextBoxColumn
        '
        Me.RestoaddedbyDataGridViewTextBoxColumn.DataPropertyName = "resto_added_by"
        Me.RestoaddedbyDataGridViewTextBoxColumn.HeaderText = "resto_added_by"
        Me.RestoaddedbyDataGridViewTextBoxColumn.Name = "RestoaddedbyDataGridViewTextBoxColumn"
        Me.RestoaddedbyDataGridViewTextBoxColumn.Width = 108
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RestoIDDataGridViewTextBoxColumn, Me.RestonameDataGridViewTextBoxColumn, Me.RestolocationDataGridViewTextBoxColumn, Me.RestobranchDataGridViewTextBoxColumn, Me.RestoratingDataGridViewTextBoxColumn, Me.RestoaddedbyDataGridViewTextBoxColumn, Me.resto_added_date})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataGridView1.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.TbleggXrestoBindingSource, "resto_added_by", True))
        Me.DataGridView1.DataSource = Me.TbleggXrestoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 81)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 30
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.Size = New System.Drawing.Size(822, 475)
        Me.DataGridView1.TabIndex = 26
        '
        'RestoIDDataGridViewTextBoxColumn
        '
        Me.RestoIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RestoIDDataGridViewTextBoxColumn.DataPropertyName = "resto_ID"
        Me.RestoIDDataGridViewTextBoxColumn.HeaderText = "resto_ID"
        Me.RestoIDDataGridViewTextBoxColumn.Name = "RestoIDDataGridViewTextBoxColumn"
        Me.RestoIDDataGridViewTextBoxColumn.Width = 72
        '
        'RestonameDataGridViewTextBoxColumn
        '
        Me.RestonameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RestonameDataGridViewTextBoxColumn.DataPropertyName = "resto_name"
        Me.RestonameDataGridViewTextBoxColumn.HeaderText = "resto_name"
        Me.RestonameDataGridViewTextBoxColumn.Name = "RestonameDataGridViewTextBoxColumn"
        Me.RestonameDataGridViewTextBoxColumn.Width = 87
        '
        'RestolocationDataGridViewTextBoxColumn
        '
        Me.RestolocationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RestolocationDataGridViewTextBoxColumn.DataPropertyName = "resto_location"
        Me.RestolocationDataGridViewTextBoxColumn.HeaderText = "resto_location"
        Me.RestolocationDataGridViewTextBoxColumn.Name = "RestolocationDataGridViewTextBoxColumn"
        Me.RestolocationDataGridViewTextBoxColumn.Width = 98
        '
        'RestobranchDataGridViewTextBoxColumn
        '
        Me.RestobranchDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RestobranchDataGridViewTextBoxColumn.DataPropertyName = "resto_branch"
        Me.RestobranchDataGridViewTextBoxColumn.HeaderText = "resto_branch"
        Me.RestobranchDataGridViewTextBoxColumn.Name = "RestobranchDataGridViewTextBoxColumn"
        Me.RestobranchDataGridViewTextBoxColumn.Width = 94
        '
        'RestoratingDataGridViewTextBoxColumn
        '
        Me.RestoratingDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RestoratingDataGridViewTextBoxColumn.DataPropertyName = "resto_rating"
        Me.RestoratingDataGridViewTextBoxColumn.HeaderText = "resto_rating"
        Me.RestoratingDataGridViewTextBoxColumn.Name = "RestoratingDataGridViewTextBoxColumn"
        Me.RestoratingDataGridViewTextBoxColumn.Width = 87
        '
        'TbleggXrestoBindingSource
        '
        Me.TbleggXrestoBindingSource.DataMember = "tbl_eggX_resto"
        Me.TbleggXrestoBindingSource.DataSource = Me.EggX_restoDataSet
        '
        'EggX_restoDataSet
        '
        Me.EggX_restoDataSet.DataSetName = "eggX_restoDataSet"
        Me.EggX_restoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_eggX_restoTableAdapter
        '
        Me.Tbl_eggX_restoTableAdapter.ClearBeforeFill = True
        '
        'txtStatus
        '
        Me.txtStatus.Enabled = False
        Me.txtStatus.Location = New System.Drawing.Point(6, 55)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(326, 20)
        Me.txtStatus.TabIndex = 33
        Me.txtStatus.Text = "STATUS : "
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(120, 11)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(80, 30)
        Me.btnExport.TabIndex = 34
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'frmViewResto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 583)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmViewResto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Restaurant"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbleggXrestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EggX_restoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EggX_restoDataSet As eggX_restoDataSet
    Friend WithEvents TbleggXrestoBindingSource As BindingSource
    Friend WithEvents Tbl_eggX_restoTableAdapter As eggX_restoDataSetTableAdapters.tbl_eggX_restoTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents resto_added_date As DataGridViewTextBoxColumn
    Friend WithEvents RestoaddedbyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RestoratingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RestobranchDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RestolocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RestonameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RestoIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents btnExport As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
