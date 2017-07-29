Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Network.UploadFile("NITE-PAVITRA-29072017-1-1.ssac", "http://localhost/ssac/upload.php")
        MessageBox.Show("File uploaded.")
    End Sub
End Class
