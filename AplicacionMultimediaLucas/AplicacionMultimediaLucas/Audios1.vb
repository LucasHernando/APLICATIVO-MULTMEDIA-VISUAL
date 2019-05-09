Public Class Audios1
    Private Sub Audios1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FormP As New Form1

        AxWindowsMediaPlayer1.URL = FormP.RetorneRuta + "\Material\Audio\ITAL.mp3"
    End Sub
End Class