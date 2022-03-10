Imports System.Data.SqlClient

Public Class frmAddResto
    Dim sDT As Date = Now

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EggX_restoDataSet.tbl_eggX_resto' table. You can move, or remove it, as needed.
        ''Me.Tbl_eggX_restoTableAdapter.Fill(Me.EggX_restoDataSet.tbl_eggX_resto)

        txtRestoID.Text = ""
        txtRestoName.Text = ""
        txtRestoBranch.Text = ""
        txtRestoLocation.Text = ""
        txtRestoRating.Text = ""


        txtUserAdd.Text = My.Settings.user.ToString
        txtUserAddDate.Text = sDT

    End Sub

    Private Sub btnAddResto_Click(sender As Object, e As EventArgs) Handles btnAddResto.Click


        Dim strId As String = txtRestoID.Text
        Dim strName As String = txtRestoName.Text
        Dim strLocation As String = txtRestoBranch.Text
        Dim strBranch As String = txtRestoLocation.Text
        Dim strRating As String = txtRestoRating.Text

        Dim strNameTrim As String = LTrim(txtRestoName.Text)
        Dim strBranchTrim As String = LTrim(txtRestoBranch.Text)
        ''Dim strRestoIDcomputed As String

        ''for logging and debugging
        Dim strRestoFrmValue As String = strName & "|" & strBranch & "|" & strLocation & " Added by " & txtUserAdd.Text & " around " & txtUserAddDate.Text



        If (txtRestoName.Text = "") Or (txtRestoBranch.Text = "") Or (txtRestoLocation.Text = "") Or (txtRestoRating.Text = "") Then
            Label7.Text = "text file is empty"
        Else

            txtRestoID.Text = My.Settings.lastIncrement.ToString + strNameTrim.Substring(0, 3) + strBranchTrim.Substring(0, 2)
            txtRestoID.Text.Replace(" ", [String].Empty)


            My.Settings.lastIncrement = My.Settings.lastIncrement + 1
            My.Settings.Save()

            Call restoConn()
            Call restoAdd()

            ''logging and debugging
            Call logRestoAdd("SUCCESS")
            Call writeToLogFile("Restaurant", "SUCCESS", "8/3/2022", strRestoFrmValue)


            Call restoConnClose()

            Me.Refresh()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label6.Text = My.Settings.lastIncrement

        My.Settings.Save()


    End Sub

    Private Sub txtRestoName_KeyUp(sender As Object, e As KeyEventArgs) Handles txtRestoName.KeyUp
        txtRestoID.Text = ""

    End Sub




End Class
