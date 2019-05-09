Public Class Form1
    Public Carpeta As String


    Public Function RetorneRuta()
        Carpeta = My.Computer.FileSystem.CurrentDirectory

        Return Carpeta
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Documentos1.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Label8.Text = Carpeta
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Video1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Imagenes1.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Audios1.Show()
    End Sub
End Class
