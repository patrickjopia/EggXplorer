


Imports System.IO

Module mod_logging


    ''to log any activity for auditing and for troubleshooting issue

    Sub writeToLogFile(modul As String, arg As String, dt As Date, frmValue As String)

        Dim inputString As String = Environment.NewLine + "[" + dt + "] - " + modul + " " + arg + " " + frmValue


        Dim folderPath As String = "C:\Pinoy Labs\"
        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If

        My.Computer.FileSystem.WriteAllText(
          "C:\Pinoy Labs\EggXplorer.log", inputString, True)


        ''logRestoAdd(arg)


    End Sub

    Sub logUserAccess(argsUserAccess As String)

        ''in form logging and debugging
        LoginForm1.txtStatus.Text = "STATUS : " + argsUserAccess




    End Sub



    Sub logRestoAdd(argsRestoAdd As String)

        Dim modul As String = "Restaurant ADD"

        ''in form logging and debugging
        frmAddResto.txtStatus.Text = "STATUS : " + argsRestoAdd

        ''to logfile logging and debugging
        ''writeToLogFile(modul, argsRestoAdd, "11/11/2022", frmValue)


    End Sub











End Module
