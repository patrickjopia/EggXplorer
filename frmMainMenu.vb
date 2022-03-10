Public Class frmMainMenu



    Private Sub btnViewResto_Click(sender As Object, e As EventArgs) Handles btnViewResto.Click

        With frmViewResto
            .TopLevel = False
            contentPanel.Controls.Add(frmViewResto)
            .BringToFront()
            .Show()

        End With

        frmViewResto.txtStatus.Text = "STATUS : "
    End Sub

    Private Sub btnAddResto_Click(sender As Object, e As EventArgs) Handles btnAddResto.Click
        With frmAddResto
            .TopLevel = False
            contentPanel.Controls.Add(frmAddResto)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblUserLogged.Text = "You are logged in as " & My.Settings.CurrentUser



    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        With frmAddUser
            .TopLevel = False
            contentPanel.Controls.Add(frmAddUser)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub infoPanel_Paint(sender As Object, e As PaintEventArgs) Handles infoPanel.Paint

    End Sub

    Private Sub btnRestoManage_Click(sender As Object, e As EventArgs) Handles btnRestoManage.Click
        lblMenuShow.Text = "Restaurant Management"
    End Sub

    Private Sub btnAppManage_Click(sender As Object, e As EventArgs) Handles btnAppManage.Click
        lblMenuShow.Text = "Application Management"
    End Sub

    Private Sub btnViewUser_Click(sender As Object, e As EventArgs) Handles btnViewUser.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

        Me.Dispose()

    End Sub
End Class