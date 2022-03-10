Public Class frmUpdateResto


    Dim sDT As Date = Now
    Private Sub btnAddResto_Click(sender As Object, e As EventArgs) Handles btnUpdateResto.Click


        Dim strId As String = txtRestoID.Text
        Dim strName As String = txtRestoName.Text
        Dim strLocation As String = txtRestoBranch.Text
        Dim strBranch As String = txtRestoLocation.Text
        Dim strRating As String = txtRestoRating.Text

        Dim strNameTrim As String = LTrim(txtRestoName.Text)
        Dim strBranchTrim As String = LTrim(txtRestoBranch.Text)
        ''Dim strRestoIDcomputed As String


        Call restoConn()

        Call restoUpdate()

        ''for logging and debugging
        Dim strRestoFrmValue As String = strName & "|" & strBranch & "|" & strLocation & " Modified by " & txtUserAdd.Text & " around " & txtUserAddDate.Text

        Call restoConnClose()

    End Sub

    Private Sub frmUpdateResto_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        txtUserModified.Text = My.Settings.user.ToString
        txtUserModifiedDate.Text = sDT

    End Sub
End Class