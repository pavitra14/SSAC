Imports System
Imports Ionic.Zip.ZipFile
Imports System.ComponentModel

Public Class main

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .FileName = "*.ssac"
            .Title = "Choose the ssac file"
            .Filter = "All ssac Files (*.ssac) | *.ssac"

            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                TextBox1.Text = .FileName
                TextBox1.ReadOnly = True
                Button2.Enabled = True
            End If
        End With
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim filename As String = TextBox1.Text
        With fbd
            .Description = "Choose the Folder Where you want to extract the ssac file"
            .ShowNewFolderButton = True

            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                TextBox2.Text = .SelectedPath
            Else
                Application.Exit()
            End If
        End With

        Using zip1 As Ionic.Zip.ZipFile = Ionic.Zip.ZipFile.Read(filename)
            zip1.Password = "ae56929f9bc01b3f029f11ce9b3eba43" 'Password used to encrypt the package.
            Dim extract As Ionic.Zip.ZipEntry
            ' here, we extract every entry, but we could extract    
            ' based on entry name, size, date, etc.   
            For Each extract In zip1
                extract.Extract(TextBox2.Text, Ionic.Zip.ExtractExistingFileAction.OverwriteSilently)
            Next

        End Using
        MessageBox.Show("Extracted at " & TextBox2.Text, "Done")
    End Sub
End Class
