Imports System.IO
Public Class login
    Public clantag As String
    Public playerign As String
    Public matchno As String
    Public gameno As String
    Dim config As String
    Dim configFile As String = "config.ssac"
    Private Sub cmd_login_Click(sender As Object, e As EventArgs) Handles cmd_login.Click
        If (clntag.Text = "" Or ign.Text = "" Or Match.Text = "" Or Game.Text = "") Then
            MessageBox.Show("Error, You cannot leave name/clan tag/Match no./Game no. empty", "Error")
            Application.Restart()
        Else
            clantag = clntag.Text
            playerign = ign.Text
            matchno = Match.Text
            gameno = Game.Text
            saveConfig(clantag, playerign)
            main.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (checkConfig() = True) Then
            loadConfig()
        End If
    End Sub
    Sub loadConfig()
        Try
            Dim configarray As Array
            config = My.Computer.FileSystem.ReadAllText(configFile, System.Text.Encoding.ASCII)
            configarray = Split(config, "#")
            clntag.Text = configarray(0)
            ign.Text = configarray(1)
        Catch e As Exception
            MessageBox.Show("Config File Damaged, please delete config.ssac and start this program again")
        End Try
    End Sub
    Sub saveConfig(cln As String, name As String)
        Dim savedata As String = String.Format("{0}#{1}", cln, name)
        'initiate the save process
        My.Computer.FileSystem.WriteAllText(configFile, savedata, False, System.Text.Encoding.ASCII)
    End Sub
    Function checkConfig() As Boolean
        If (File.Exists(configFile) = True) Then
            checkConfig = True
        Else
            checkConfig = False
        End If
    End Function

End Class
