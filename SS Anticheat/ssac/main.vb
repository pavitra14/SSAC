Imports System
Imports System.IO
Imports Ionic
Public Class main
    Dim SAPI = CreateObject("SAPI.Spvoice")
    Dim zipper As New Ionic.Zip.ZipFile
    Dim filename As String = login.clantag & "-" & login.playerign & Date.Now.ToString("ddMMyyyy") & "M" & login.matchno & "G" & login.gameno & ".ssac"
    Dim filename2 As String = login.clantag & "-" & login.playerign & Date.Now.ToString("ddMMyyyy") & "M" & login.matchno & "G" & login.gameno & "(1).ssac"

    Public Shared Sub screenCapture()
        Dim userName As String = login.clantag & "-" & login.playerign
        Dim savePath As String = Application.StartupPath
        Dim dateString As String = Date.Now.ToString("yyyyMMddHHmmss")
        Dim datestring2 As String = Date.Now.ToString("ddMMyyyy")
        Dim captureSavePath As String = String.Format("{0}\ssac\{1}\{3}\capture_{2}.png", savePath, userName, dateString, datestring2)
        ' This line is modified for multiple screens, also takes into account different screen size (if any)
        Dim bmp As Bitmap = New Bitmap( _
                            Screen.AllScreens.Sum(Function(s As Screen) s.Bounds.Width),
                            Screen.AllScreens.Max(Function(s As Screen) s.Bounds.Height))
        Dim gfx As Graphics = Graphics.FromImage(bmp)
        ' This line is modified to take everything based on the size of the bitmap
        gfx.CopyFromScreen(SystemInformation.VirtualScreen.X,
                           SystemInformation.VirtualScreen.Y,
                           0, 0, SystemInformation.VirtualScreen.Size)
        ' Oh, create the directory if it doesn't exist
        ' Directory.CreateDirectory(Path.GetDirectoryName(captureSavePath))
        System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(captureSavePath))
        bmp.Save(captureSavePath)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        Button1.Enabled = False
        Button2.Enabled = True
        'SAPI.speak("SSAC Started")
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        screenCapture()
        'SAPI.speak("Screenshot")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
        Button2.Enabled = False
        'Button1.Enabled = True
        'SAPI.speak("SSAC Stopped")
        createUploadFile()
        MessageBox.Show("Upload File Created - " & filename & vbCrLf & "Please keep the above file in a safe location as you ll have to give this file to you clan leader , The Program will now restart for new match/game.")
        Application.Restart()

    End Sub

    Private Sub main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        login.Close()
    End Sub
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Enabled = False
    End Sub
    Private Sub createUploadFile()
        Dim userName As String = login.clantag & "-" & login.playerign
        Dim datestring2 As String = Date.Now.ToString("ddMMyyyy")
        Dim folder As String = Application.StartupPath & "\ssac\" & userName & "\" & datestring2
        Dim strFileSize As String = ""
        Dim di As New IO.DirectoryInfo(folder)
        Dim aryFi As IO.FileInfo() = di.GetFiles("*.png")
        Dim fi As IO.FileInfo
        For Each fi In aryFi
            ' Try
            zipper.AddFile(folder & "\" & fi.Name, "ss")
            'Catch e As Exception
            'If (zipper.ContainsEntry(fi.Name) = True) Then
            ''Do nothing
            'End If
            'End Try
        Next
        ' If (checkfileName(filename) = True) Then
        'MessageBox.Show("File Already Exists, Please relocate the file , then press Ok", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'createUploadFile()
        'Else
        Try
            zipper.Save(filename)
        Catch e As Exception
            MessageBox.Show("May be the file exists as you havent relocated the previous file, new file will save as " & filename2 & vbCrLf & "And please be sure to relocate it this time, as this time it wont work, you ll be regarded as a hacker/foul player")
            zipper.Save(filename2)
        End Try
        deleteSS()

        'End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        about.ShowDialog()
    End Sub
    Public Function checkfileName(filename As String) As Boolean
        If (System.IO.File.Exists(filename) = True) Then
            checkfileName = True 'file exists
        Else
            checkfileName = False 'file doesn't exist
        End If
    End Function
    'I ll work on this function afterwards as its gonna take time, alotta time.
    ' Public Function changeFileName(filename As String)
    '    If (filename.Contains("(") = True) Then
    'Dim ary As Array = Split(filename, "(")
    'Dim ary2 As Array = Split(ary(1), ")")
    'Dim fileno As String = ary2(0)
    'Dim newfileno As String = fileno + 1
    'Dim newfilename As String = login.clantag & "-" & login.playerign & Date.Now.ToString("ddMMyyyy") & "M" & login.matchno & "G" & login.gameno & "(" & newfileno & ")" & ".ssac"
    'Return newfilename
    'Else
    'Dim newfilename As String = login.clantag & "-" & login.playerign & Date.Now.ToString("ddMMyyyy") & "M" & login.matchno & "G" & login.gameno & "(1)" & ".ssac"
    'Return newfilename
    'End If
    'End Function
    Sub deleteSS()
        Directory.Delete("ssac", True)
    End Sub
End Class