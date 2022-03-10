<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Me.infoPanel = New System.Windows.Forms.Panel()
        Me.lblMenuShow = New System.Windows.Forms.Label()
        Me.lblUserLogged = New System.Windows.Forms.Label()
        Me.contentPanel = New System.Windows.Forms.Panel()
        Me.logoPanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.sidePanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnViewUser = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.btnAppManage = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnViewResto = New System.Windows.Forms.Button()
        Me.btnAddResto = New System.Windows.Forms.Button()
        Me.btnRestoManage = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.infoPanel.SuspendLayout()
        Me.logoPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sidePanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'infoPanel
        '
        Me.infoPanel.Controls.Add(Me.lblMenuShow)
        Me.infoPanel.Controls.Add(Me.lblUserLogged)
        Me.infoPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.infoPanel.Location = New System.Drawing.Point(276, 0)
        Me.infoPanel.Name = "infoPanel"
        Me.infoPanel.Size = New System.Drawing.Size(958, 91)
        Me.infoPanel.TabIndex = 1
        '
        'lblMenuShow
        '
        Me.lblMenuShow.AutoSize = True
        Me.lblMenuShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuShow.Location = New System.Drawing.Point(364, 19)
        Me.lblMenuShow.Name = "lblMenuShow"
        Me.lblMenuShow.Size = New System.Drawing.Size(102, 39)
        Me.lblMenuShow.TabIndex = 1
        Me.lblMenuShow.Text = "Menu"
        '
        'lblUserLogged
        '
        Me.lblUserLogged.AutoSize = True
        Me.lblUserLogged.Location = New System.Drawing.Point(15, 9)
        Me.lblUserLogged.Name = "lblUserLogged"
        Me.lblUserLogged.Size = New System.Drawing.Size(73, 13)
        Me.lblUserLogged.TabIndex = 0
        Me.lblUserLogged.Text = "Logged In As "
        '
        'contentPanel
        '
        Me.contentPanel.BackColor = System.Drawing.Color.White
        Me.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contentPanel.Location = New System.Drawing.Point(276, 91)
        Me.contentPanel.Name = "contentPanel"
        Me.contentPanel.Size = New System.Drawing.Size(958, 570)
        Me.contentPanel.TabIndex = 2
        '
        'logoPanel
        '
        Me.logoPanel.Controls.Add(Me.PictureBox1)
        Me.logoPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.logoPanel.Location = New System.Drawing.Point(0, 0)
        Me.logoPanel.Name = "logoPanel"
        Me.logoPanel.Size = New System.Drawing.Size(276, 91)
        Me.logoPanel.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.EggXplorer.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(276, 91)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'sidePanel
        '
        Me.sidePanel.Controls.Add(Me.Panel3)
        Me.sidePanel.Controls.Add(Me.Panel2)
        Me.sidePanel.Controls.Add(Me.Panel1)
        Me.sidePanel.Controls.Add(Me.logoPanel)
        Me.sidePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidePanel.Location = New System.Drawing.Point(0, 0)
        Me.sidePanel.Name = "sidePanel"
        Me.sidePanel.Size = New System.Drawing.Size(276, 661)
        Me.sidePanel.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnViewUser)
        Me.Panel2.Controls.Add(Me.btnAddUser)
        Me.Panel2.Controls.Add(Me.btnAppManage)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 263)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(276, 161)
        Me.Panel2.TabIndex = 2
        '
        'btnViewUser
        '
        Me.btnViewUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnViewUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewUser.Location = New System.Drawing.Point(0, 80)
        Me.btnViewUser.Name = "btnViewUser"
        Me.btnViewUser.Size = New System.Drawing.Size(276, 40)
        Me.btnViewUser.TabIndex = 3
        Me.btnViewUser.Text = "View Record"
        Me.btnViewUser.UseVisualStyleBackColor = True
        '
        'btnAddUser
        '
        Me.btnAddUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAddUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUser.Location = New System.Drawing.Point(0, 40)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(276, 40)
        Me.btnAddUser.TabIndex = 2
        Me.btnAddUser.Text = "Add Record"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'btnAppManage
        '
        Me.btnAppManage.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAppManage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAppManage.Location = New System.Drawing.Point(0, 0)
        Me.btnAppManage.Name = "btnAppManage"
        Me.btnAppManage.Size = New System.Drawing.Size(276, 40)
        Me.btnAppManage.TabIndex = 1
        Me.btnAppManage.Text = "Application Management"
        Me.btnAppManage.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnViewResto)
        Me.Panel1.Controls.Add(Me.btnAddResto)
        Me.Panel1.Controls.Add(Me.btnRestoManage)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(276, 172)
        Me.Panel1.TabIndex = 1
        '
        'btnViewResto
        '
        Me.btnViewResto.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnViewResto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewResto.Location = New System.Drawing.Point(0, 80)
        Me.btnViewResto.Name = "btnViewResto"
        Me.btnViewResto.Size = New System.Drawing.Size(276, 40)
        Me.btnViewResto.TabIndex = 2
        Me.btnViewResto.Text = "View Record"
        Me.btnViewResto.UseVisualStyleBackColor = True
        '
        'btnAddResto
        '
        Me.btnAddResto.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAddResto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddResto.Location = New System.Drawing.Point(0, 40)
        Me.btnAddResto.Name = "btnAddResto"
        Me.btnAddResto.Size = New System.Drawing.Size(276, 40)
        Me.btnAddResto.TabIndex = 1
        Me.btnAddResto.Text = "Add Record"
        Me.btnAddResto.UseVisualStyleBackColor = True
        '
        'btnRestoManage
        '
        Me.btnRestoManage.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRestoManage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestoManage.Location = New System.Drawing.Point(0, 0)
        Me.btnRestoManage.Name = "btnRestoManage"
        Me.btnRestoManage.Size = New System.Drawing.Size(276, 40)
        Me.btnRestoManage.TabIndex = 0
        Me.btnRestoManage.Text = "Restaurant Management"
        Me.btnRestoManage.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 424)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(276, 125)
        Me.Panel3.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(276, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Help"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(0, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(276, 43)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "About"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(0, 83)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(276, 42)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 661)
        Me.Controls.Add(Me.contentPanel)
        Me.Controls.Add(Me.infoPanel)
        Me.Controls.Add(Me.sidePanel)
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.infoPanel.ResumeLayout(False)
        Me.infoPanel.PerformLayout()
        Me.logoPanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sidePanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents infoPanel As Panel
    Friend WithEvents contentPanel As Panel
    Friend WithEvents logoPanel As Panel
    Friend WithEvents sidePanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAddResto As Button
    Friend WithEvents btnRestoManage As Button
    Friend WithEvents btnViewResto As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnViewUser As Button
    Friend WithEvents btnAddUser As Button
    Friend WithEvents btnAppManage As Button
    Friend WithEvents lblUserLogged As Label
    Friend WithEvents lblMenuShow As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
