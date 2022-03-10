Public Class frmAddUser


    Dim sDT As Date = Now
    Private Sub frmAddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EggX_usersDataSet.tbl_eggXuser' table. You can move, or remove it, as needed.
        ''Me.Tbl_eggXuserTableAdapter.Fill(Me.EggX_usersDataSet.tbl_eggXuser)

        txtUserID.Text = txtUserID.Text & My.Settings.userIDcount + 1


    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click

        txtFullName.Text = ""
        txtFullName.Text = txtFirstName.Text & " " & txtLastName.Text

        My.Settings.userIDcount = My.Settings.userIDcount + 1

        Call usersConn()
        Call UsersAdd()
        Call usersConnClose()


    End Sub



End Class