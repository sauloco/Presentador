Public Class Presentacion
    Public WebBrowserBiblia As Boolean = False
    Public MostrarCursor As Boolean = True
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Dim VersiculoEncontrado As Boolean = False
        If WebBrowserBiblia Then
            Dim PageElement As HtmlElementCollection = Me.WebBrowser1.Document.GetElementsByTagName("div")
            For Each CurElement As HtmlElement In PageElement
                If (CurElement.GetAttribute("className") = "results") Then
                    Dim style As String = ".results ul{list-style-type:none!important}ul.results{list-style:none}.results .caption{color:#443;font-size:3em;font-weight:300;padding-top:.5em;padding-bottom:0}.dir-ltr .results .caption,.results .caption.dir-ltr{padding-left:0;padding-right:0}.results .caption .lnk{color:#4477a1}.results a{text-decoration:none}.lang-es,.lang-es.lib-es,.mepslang-S.meps-S.meps_S{font-family:Helvetica,Arial,sans-serif;font-size:2em}body{color:#333;background-color:#f7f7f5;}p{font-size: 2em;}"
                    Dim ToBrowser As String = "<html><head><style>" + style + "</style></head><body><div Class= results >" + CurElement.InnerHtml + "</div></body></html>"
                    WebBrowser1.DocumentText = ToBrowser
                    VersiculoEncontrado = True
                End If
            Next
            If Not VersiculoEncontrado Then
                WebBrowser1.DocumentText = "Versículo no encontrado."
            End If
            WebBrowserBiblia = False
        End If
    End Sub

    'Private Sub Form1_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter, PictureBox1.MouseEnter ', AxAcroPDF1.MouseEnter ' ', AxWindowsMediaPlayer1.MouseEnter , WebBrowser1.MouseEnter 
    '    If Not MostrarCursor Then
    '        Cursor.Hide()
    '    Else
    '        Cursor.Show()
    '    End If

    'End Sub

    'Private Sub Form1_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave, PictureBox1.MouseLeave ', AxAcroPDF1.MouseLeave ', AxWindowsMediaPlayer1.MouseLeave ', WebBrowser1.MouseLeave 
    '    If Not MostrarCursor Then
    '        Cursor.Show()
    '    Else
    '        Cursor.Hide()
    '    End If
    'End Sub
End Class
