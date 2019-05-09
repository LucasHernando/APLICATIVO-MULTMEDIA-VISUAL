Public Class Documentos1
    Private Sub AxAcroPDF1_OnError(sender As Object, e As EventArgs) Handles AxAcroPDF1.OnError


    End Sub

    Private Sub Docummentos1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Formini As New Form1
        'Dim ruta As String
        ' ruta = Formini.RetorneRuta + "\Material\Documentos\Guía de actividades y rúbrica de evaluación - Paso 5 - Entorno de desarrollo de Software.pdf"
        ' Label1.Text = ruta
        AxAcroPDF1.LoadFile(Formini.RetorneRuta + "\Material\Documentos\INTRODUCCION INTELIGENCIA ARTIFICIAL.pdf")
    End Sub
End Class