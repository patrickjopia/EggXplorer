Imports System.Data.SqlClient

Module mod_resto
    Dim regDBResto = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Pinoy Labs\EggXplore", "DatabaseResto", Nothing)
    Dim regDS = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Pinoy Labs\EggXplore", "DataSource", Nothing)

    Dim restoConDS As String = My.Settings.eggX_restoConnectionString
    ''Dim connectionResto As New SqlConnection("Data Source=" & regDS & ";Initial Catalog=" & regDBResto & ";Integrated Security=True")


    Dim connectionResto As New SqlConnection("Data Source=PALW3001\SQLEXPRESS;Initial Catalog=eggX_resto;Integrated Security=True")


    ''Dim command As New SqlCommand("insert into tbl_eggX_resto (strId, strName, strLocation, strBranch, strRating ) values('" & TextBox1.Text & "','" & TextBox2.Text & "'," & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & ")", connectionResto)
    ''https://itsourcecode.com/free-projects/vb-net/how-to-use-module-and-its-uses-in-vb-net/



    Sub restoConn()

        connectionResto.Open()
    End Sub

    Sub restoConnClose()

        connectionResto.Close()


    End Sub

    Sub restoAdd()
        Dim Command As New SqlCommand("insert into tbl_eggX_resto (resto_ID, resto_name, resto_location, resto_branch, resto_rating, resto_added_by, resto_added_date ) values(@resto_ID,@resto_name,@resto_location,@resto_branch,@resto_rating, @resto_added_by, @resto_added_date)", connectionResto)


        Command.Parameters.Clear()

        Command.Parameters.Add("@resto_ID", SqlDbType.VarChar).Value = frmAddResto.txtRestoID.Text.Replace(" ", [String].Empty)
        command.Parameters.Add("@resto_name", SqlDbType.VarChar).Value = frmAddResto.txtRestoName.Text
        command.Parameters.Add("@resto_location", SqlDbType.VarChar).Value = frmAddResto.txtRestoLocation.Text
        Command.Parameters.Add("@resto_branch", SqlDbType.VarChar).Value = frmAddResto.txtRestoBranch.Text
        Command.Parameters.Add("@resto_rating", SqlDbType.Float).Value = frmAddResto.txtRestoRating.Text

        Command.Parameters.Add("@resto_added_by", SqlDbType.VarChar).Value = frmAddResto.txtUserAdd.Text
        Command.Parameters.Add("@resto_added_date", SqlDbType.Date).Value = frmAddResto.txtUserAddDate.Text


        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("New Restaurant Added")
        Else
            MessageBox.Show("Restaurant Not Added")
        End If

    End Sub

    Sub restoUpdate()

        Dim Command As New SqlCommand("update tbl_eggX_resto set resto_ID = @resto_ID, resto_name = @resto_name , resto_branch = @resto_branch , resto_location = @resto_location , resto_rating = @resto_rating, resto_added_by = @resto_added_by, resto_added_date = @resto_added_date , resto_modified_by = @resto_modified_by , resto_modified_date = @resto_modified_date, resto_modified_field = @resto_modified_fields", connectionResto)


        Command.Parameters.Clear()

        Command.Parameters.AddWithValue("@resto_ID", SqlDbType.VarChar).Value = frmUpdateResto.txtRestoID.Text.Replace(" ", [String].Empty)
        Command.Parameters.AddWithValue("@resto_name", SqlDbType.VarChar).Value = frmUpdateResto.txtRestoName.Text
        Command.Parameters.AddWithValue("@resto_location", SqlDbType.VarChar).Value = frmUpdateResto.txtRestoLocation.Text
        Command.Parameters.AddWithValue("@resto_branch", SqlDbType.VarChar).Value = frmUpdateResto.txtRestoBranch.Text
        Command.Parameters.AddWithValue("@resto_rating", SqlDbType.Float).Value = frmUpdateResto.txtRestoRating.Text


        Command.Parameters.AddWithValue("@resto_added_by", SqlDbType.VarChar).Value = frmUpdateResto.txtUserAdd.Text
        Command.Parameters.AddWithValue("@resto_added_date", SqlDbType.Date).Value = frmUpdateResto.txtUserAddDate.Text
        Command.Parameters.AddWithValue("@resto_modified_by", SqlDbType.VarChar).Value = frmUpdateResto.txtUserModified.Text
        Command.Parameters.AddWithValue("@resto_modified_date", SqlDbType.Date).Value = frmUpdateResto.txtUserModifiedDate.Text
        Command.Parameters.AddWithValue("@resto_modified_fields", SqlDbType.VarChar).Value = frmUpdateResto.txtModifiedFields.Text

        If Command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Restaurant Updated")
        Else
            MessageBox.Show("Restaurant Not Updated")
        End If



    End Sub



    Function PopulateDataGridViewResto() As DataTable


        Dim searchBy As String
        Dim search As String

        search = frmViewResto.ComboBox1.Text

        If search = "Search By Name" Then
            searchBy = "@resto_name"
        ElseIf search = "Search By Branch" Then
            searchBy = "@resto_branch"
        End If




        Dim query As String = "Select * FROM tbl_eggX_resto"
        query &= " WHERE resto_name Like '%' + @resto_name + '%'"
        query &= " OR @resto_name = ''"
        Dim constr As String = "Data Source=PALW3001\SQLEXPRESS;Initial Catalog=eggX_resto;Integrated Security=True"
        Using con As SqlConnection = New SqlConnection(constr)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@resto_name", frmViewResto.TextBox1.Text.Trim())
                Using sda As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable()
                    sda.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using



    End Function








End Module
