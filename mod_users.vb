Imports System.Data.OleDb
Imports System.Data.SqlClient


Module mod_users

    Dim regDBUsers = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Pinoy Labs\EggXplore", "DatabaseUsers", Nothing)
    Dim regDS = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Pinoy Labs\EggXplore", "DataSource", Nothing)

    Dim userConDS As String = My.Settings.eggX_usersConnectionString

    Dim constr As String = String.Concat(""" , userConDS + """)
    ''Dim connectionUsers As New SqlConnection(constr)


    Dim connectionUsers As New SqlConnection("Data Source=PALW3001\SQLEXPRESS;Initial Catalog=eggX_users;Integrated Security=True")

    ''Data Source=PALW3001\SQLEXPRESS;Initial Catalog=eggX_resto;Integrated Security=True
    ''Dim command As New SqlCommand("insert into tbl_eggX_resto (strId, strName, strLocation, strBranch, strRating ) values('" & TextBox1.Text & "','" & TextBox2.Text & "'," & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & ")", connectionResto)
    ''https://itsourcecode.com/free-projects/vb-net/how-to-use-module-and-its-uses-in-vb-net/


    Sub usersConn()

        connectionUsers.Open()
    End Sub

    Sub usersConnClose()

        connectionUsers.Close()
    End Sub
    Sub usersConnDispose()

        connectionUsers.Dispose()
    End Sub


    Sub UsersAdd()
        Dim Command As New SqlCommand("insert into tbl_eggXuser (userID, full_name, user_role, user_name, user_pass) values(@userID, @full_name, @user_role, @user_name, @user_pass)", connectionUsers)


        Command.Parameters.Clear()

        Command.Parameters.Add("@userID", SqlDbType.Char).Value = frmAddUser.txtUserID.Text.Replace(" ", [String].Empty)
        Command.Parameters.Add("@full_name", SqlDbType.VarChar).Value = frmAddUser.txtFullName.Text
        Command.Parameters.Add("@user_role", SqlDbType.Char).Value = frmAddUser.txtUserRole.Text
        Command.Parameters.Add("@user_name", SqlDbType.VarChar).Value = frmAddUser.txtusername.Text
        Command.Parameters.Add("@user_pass", SqlDbType.VarChar).Value = frmAddUser.txtpassword.Text



        If Command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("New User Added")

        Else
            MessageBox.Show("User Not Added")
        End If

    End Sub


    Sub LoginSystem()

        Dim dt As Date

        dt = (Now.ToString)

        ' Open the database.
        Call usersConn()


        ' Fetch the saved hashed password.
        Dim query As String
        Dim cmd As New SqlCommand
        query = "SELECT user_pass FROM tbl_eggXuser WHERE " &
        "user_name=@user_name"
        cmd = New SqlCommand(query, connectionUsers)
        cmd.Parameters.Add(New SqlParameter("user_name", LoginForm1.UsernameTextBox.Text))

        Dim queryCurUser As String
        Dim cmdCurUser As New SqlCommand
        queryCurUser = "SELECT full_name FROM tbl_eggXuser WHERE " &
            "user_name=@user_name"
        cmdCurUser = New SqlCommand(queryCurUser, connectionUsers)
        cmdCurUser.Parameters.Add(New SqlParameter("user_name", LoginForm1.UsernameTextBox.Text))


        Dim fullnameStr As String = cmdCurUser.ExecuteScalar()


        Dim saved_hash As String = cmd.ExecuteScalar()

        ' Hash the password entered by the user.
        Dim test_hash As String = (LoginForm1.PasswordTextBox.Text)

        ' Close the connection.
        Call usersConnClose()

        Dim strRestoFrmValue As String = " USER : " & fullnameStr & " around " & dt

        ' Compare the two hashed passwords.
        If test_hash = saved_hash Then
            My.Settings.CurrentUser = fullnameStr
            My.Settings.Save()



            ''MessageBox.Show("Access Granted : " & fullnameStr & "!   " & "DBusers : " & regDBUsers & "Datasource : " & regDS)
            frmMainMenu.Show()
            writeToLogFile("Login", "GRANTED", dt, strRestoFrmValue)

            LoginForm1.Hide()

        Else

            writeToLogFile("Login", "DENIED", dt, strRestoFrmValue)

            MessageBox.Show("Access Denied! Username and Password are incorrect. Please contact administrator!")
        End If
    End Sub


    ' Return the hashed password.
    ' Note that this is just a simple example that shifts
    ' the password's characters. In a real program, you should
    ' do something stronger such as using the Crypto namespace.
    Function HashPassword(ByVal password As String) As _
    String
        Dim hash As String = ""
        Dim i As Integer
        For i = 0 To password.Length - 1
            hash &= Chr(Asc(password.Substring(i, 1)) + 1)
        Next i
        Return hash
    End Function



    Function PopulateDataGridViewUser() As DataTable


        Dim searchBy As String
        Dim search As String

        ''search = frmViewUser.ComboBox1.Text
        search = ""

        If search = "Search By Name" Then
            searchBy = "@full_name"
        ElseIf search = "Search By Branch" Then
            searchBy = "@resto_branch"
        End If




        Dim query As String = "Select * FROM tbl_eggX_user"
        query &= " WHERE full_name Like '%' + @full_name + '%'"
        query &= " OR @full_name = ''"
        Dim constr As String = "Data Source=" & regDS & ";Initial Catalog=" & regDBUsers & ";Integrated Security=True"
        Using con As SqlConnection = New SqlConnection(constr)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@full_name", frmAddUser)
                Using sda As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable()
                    sda.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using



    End Function




End Module
