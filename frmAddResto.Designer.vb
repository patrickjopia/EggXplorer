<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddResto
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
        Me.txtRestoID = New System.Windows.Forms.TextBox()
        Me.TbleggXrestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EggX_restoDataSet = New EggXplorer.eggX_restoDataSet()
        Me.txtRestoName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRestoBranch = New System.Windows.Forms.TextBox()
        Me.txtRestoLocation = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAddResto = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRestoRating = New System.Windows.Forms.TextBox()
        Me.Tbl_eggX_restoTableAdapter = New EggXplorer.eggX_restoDataSetTableAdapters.tbl_eggX_restoTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUserAdd = New System.Windows.Forms.TextBox()
        Me.txtUserAddDate = New System.Windows.Forms.TextBox()
        Me.txtUserModifiedDate = New System.Windows.Forms.TextBox()
        Me.txtUserModified = New System.Windows.Forms.TextBox()
        Me.txtModifiedFields = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        CType(Me.TbleggXrestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EggX_restoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Restaurant ID"
        '
        'txtRestoID
        '
        Me.txtRestoID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbleggXrestoBindingSource, "resto_ID", True))
        Me.txtRestoID.Enabled = False
        Me.txtRestoID.Location = New System.Drawing.Point(153, 63)
        Me.txtRestoID.Name = "txtRestoID"
        Me.txtRestoID.Size = New System.Drawing.Size(112, 20)
        Me.txtRestoID.TabIndex = 1
        Me.txtRestoID.Text = "resto1"
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
        'txtRestoName
        '
        Me.txtRestoName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbleggXrestoBindingSource, "resto_name", True))
        Me.txtRestoName.Location = New System.Drawing.Point(153, 112)
        Me.txtRestoName.Name = "txtRestoName"
        Me.txtRestoName.Size = New System.Drawing.Size(111, 20)
        Me.txtRestoName.TabIndex = 2
        Me.txtRestoName.Text = "mcdodo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Restaurant "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Restaurant Branch"
        '
        'txtRestoBranch
        '
        Me.txtRestoBranch.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbleggXrestoBindingSource, "resto_location", True))
        Me.txtRestoBranch.Location = New System.Drawing.Point(153, 166)
        Me.txtRestoBranch.Name = "txtRestoBranch"
        Me.txtRestoBranch.Size = New System.Drawing.Size(113, 20)
        Me.txtRestoBranch.TabIndex = 3
        Me.txtRestoBranch.Text = "ortigas"
        '
        'txtRestoLocation
        '
        Me.txtRestoLocation.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbleggXrestoBindingSource, "resto_branch", True))
        Me.txtRestoLocation.Location = New System.Drawing.Point(151, 220)
        Me.txtRestoLocation.Name = "txtRestoLocation"
        Me.txtRestoLocation.Size = New System.Drawing.Size(112, 20)
        Me.txtRestoLocation.TabIndex = 4
        Me.txtRestoLocation.Text = "ortigas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Restaurant Location"
        '
        'btnAddResto
        '
        Me.btnAddResto.Location = New System.Drawing.Point(151, 382)
        Me.btnAddResto.Name = "btnAddResto"
        Me.btnAddResto.Size = New System.Drawing.Size(113, 32)
        Me.btnAddResto.TabIndex = 8
        Me.btnAddResto.Text = "Add Restaurant"
        Me.btnAddResto.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 276)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Rating"
        '
        'txtRestoRating
        '
        Me.txtRestoRating.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbleggXrestoBindingSource, "resto_rating", True))
        Me.txtRestoRating.Location = New System.Drawing.Point(151, 269)
        Me.txtRestoRating.Name = "txtRestoRating"
        Me.txtRestoRating.Size = New System.Drawing.Size(113, 20)
        Me.txtRestoRating.TabIndex = 5
        Me.txtRestoRating.Text = "1"
        '
        'Tbl_eggX_restoTableAdapter
        '
        Me.Tbl_eggX_restoTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(435, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(435, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Label7"
        '
        'txtUserAdd
        '
        Me.txtUserAdd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbleggXrestoBindingSource, "resto_added_by", True))
        Me.txtUserAdd.Location = New System.Drawing.Point(441, 172)
        Me.txtUserAdd.Name = "txtUserAdd"
        Me.txtUserAdd.Size = New System.Drawing.Size(121, 20)
        Me.txtUserAdd.TabIndex = 13
        Me.txtUserAdd.Text = "user"
        '
        'txtUserAddDate
        '
        Me.txtUserAddDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbleggXrestoBindingSource, "resto_added_date", True))
        Me.txtUserAddDate.Location = New System.Drawing.Point(568, 172)
        Me.txtUserAddDate.Name = "txtUserAddDate"
        Me.txtUserAddDate.Size = New System.Drawing.Size(121, 20)
        Me.txtUserAddDate.TabIndex = 14
        Me.txtUserAddDate.Text = "date"
        '
        'txtUserModifiedDate
        '
        Me.txtUserModifiedDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbleggXrestoBindingSource, "resto_added_date", True))
        Me.txtUserModifiedDate.Location = New System.Drawing.Point(568, 242)
        Me.txtUserModifiedDate.Name = "txtUserModifiedDate"
        Me.txtUserModifiedDate.Size = New System.Drawing.Size(121, 20)
        Me.txtUserModifiedDate.TabIndex = 16
        Me.txtUserModifiedDate.Text = "date"
        '
        'txtUserModified
        '
        Me.txtUserModified.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbleggXrestoBindingSource, "resto_added_by", True))
        Me.txtUserModified.Location = New System.Drawing.Point(441, 242)
        Me.txtUserModified.Name = "txtUserModified"
        Me.txtUserModified.Size = New System.Drawing.Size(121, 20)
        Me.txtUserModified.TabIndex = 15
        Me.txtUserModified.Text = "user"
        '
        'txtModifiedFields
        '
        Me.txtModifiedFields.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbleggXrestoBindingSource, "resto_added_date", True))
        Me.txtModifiedFields.Location = New System.Drawing.Point(568, 289)
        Me.txtModifiedFields.Name = "txtModifiedFields"
        Me.txtModifiedFields.Size = New System.Drawing.Size(121, 20)
        Me.txtModifiedFields.TabIndex = 17
        Me.txtModifiedFields.Text = "date"
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(438, 339)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(123, 20)
        Me.txtStatus.TabIndex = 18
        Me.txtStatus.Text = "STATUS : "
        '
        'frmAddResto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 550)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.txtModifiedFields)
        Me.Controls.Add(Me.txtUserModifiedDate)
        Me.Controls.Add(Me.txtUserModified)
        Me.Controls.Add(Me.txtUserAddDate)
        Me.Controls.Add(Me.txtUserAdd)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRestoRating)
        Me.Controls.Add(Me.btnAddResto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRestoBranch)
        Me.Controls.Add(Me.txtRestoLocation)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRestoName)
        Me.Controls.Add(Me.txtRestoID)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddResto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Restaurant"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TbleggXrestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EggX_restoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtRestoID As TextBox
    Friend WithEvents txtRestoName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRestoBranch As TextBox
    Friend WithEvents txtRestoLocation As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents EggX_restoDataSet As eggX_restoDataSet
    Friend WithEvents TbleggXrestoBindingSource As BindingSource
    Friend WithEvents Tbl_eggX_restoTableAdapter As eggX_restoDataSetTableAdapters.tbl_eggX_restoTableAdapter
    Friend WithEvents btnAddResto As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRestoRating As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtUserAdd As TextBox
    Friend WithEvents txtUserAddDate As TextBox
    Friend WithEvents txtUserModifiedDate As TextBox
    Friend WithEvents txtUserModified As TextBox
    Friend WithEvents txtModifiedFields As TextBox
    Friend WithEvents txtStatus As TextBox
End Class
