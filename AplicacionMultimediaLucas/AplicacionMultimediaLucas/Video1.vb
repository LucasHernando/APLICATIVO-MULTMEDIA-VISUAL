Public Class Video1
    Private Sub Video1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Form1 As New Form1

        AxWindowsMediaPlayer1.URL = Form1.RetorneRuta + "\Material\Videos\Inteligencia artificial  Documental.mp4"
    End Sub
End Class