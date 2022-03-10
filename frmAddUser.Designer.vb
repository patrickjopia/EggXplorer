<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddUser
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
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUserRole = New System.Windows.Forms.TextBox()
        Me.TbleggXuserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EggX_usersDataSet = New EggXplorer.eggX_usersDataSet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.Tbl_eggXuserTableAdapter = New EggXplorer.eggX_usersDataSetTableAdapters.tbl_eggXuserTableAdapter()
        CType(Me.TbleggXuserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EggX_usersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(109, 70)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(106, 20)
        Me.txtFirstName.TabIndex = 1
        Me.txtFirstName.Text = "Patrick"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(109, 120)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(106, 20)
        Me.txtLastName.TabIndex = 3
        Me.txtLastName.Text = "Jopia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last Name"
        '
        'txtUserRole
        '
        Me.txtUserRole.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbleggXuserBindingSource, "user_role", True))
        Me.txtUserRole.Location = New System.Drawing.Point(109, 172)
        Me.txtUserRole.Name = "txtUserRole"
        Me.txtUserRole.Size = New System.Drawing.Size(106, 20)
        Me.txtUserRole.TabIndex = 9
        Me.txtUserRole.Text = "Admin"
        '
        'TbleggXuserBindingSource
        '
        Me.TbleggXuserBindingSource.DataMember = "tbl_eggXuser"
        Me.TbleggXuserBindingSource.DataSource = Me.EggX_usersDataSet
        '
        'EggX_usersDataSet
        '
        Me.EggX_usersDataSet.DataSetName = "eggX_usersDataSet"
        Me.EggX_usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Role"
        '
        'txtpassword
        '
        Me.txtpassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbleggXuserBindingSource, "user_pass", True))
        Me.txtpassword.Location = New System.Drawing.Point(109, 312)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txtpassword.Size = New System.Drawing.Size(106, 20)
        Me.txtpassword.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 315)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "password"
        '
        'txtusername
        '
        Me.txtusername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbleggXuserBindingSource, "user_name", True))
        Me.txtusername.Location = New System.Drawing.Point(109, 257)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(106, 20)
        Me.txtusername.TabIndex = 11
        Me.txtusername.Text = "admin.patrick"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "username"
        '
        'btnAddUser
        '
        Me.btnAddUser.Location = New System.Drawing.Point(109, 364)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(106, 33)
        Me.btnAddUser.TabIndex = 14
        Me.btnAddUser.Text = "Add User"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'txtUserID
        '
        Me.txtUserID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbleggXuserBindingSource, "userID", True))
        Me.txtUserID.Location = New System.Drawing.Point(109, 25)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(105, 20)
        Me.txtUserID.TabIndex = 15
        Me.txtUserID.Text = "userID"
        '
        'txtFullName
        '
        Me.txtFullName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbleggXuserBindingSource, "full_name", True))
        Me.txtFullName.Location = New System.Drawing.Point(257, 95)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(105, 20)
        Me.txtFullName.TabIndex = 16
        Me.txtFullName.Text = "full_name"
        '
        'Tbl_eggXuserTableAdapter
        '
        Me.Tbl_eggXuserTableAdapter.ClearBeforeFill = True
        '
        'frmAddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(875, 550)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUserRole)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add User"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TbleggXuserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EggX_usersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUserRole As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAddUser As Button
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents EggX_usersDataSet As eggX_usersDataSet
    Friend WithEvents TbleggXuserBindingSource As BindingSource
    Friend WithEvents Tbl_eggXuserTableAdapter As eggX_usersDataSetTableAdapters.tbl_eggXuserTableAdapter
End Class
