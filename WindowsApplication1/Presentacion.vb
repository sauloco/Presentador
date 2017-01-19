Public Class Presentacion
    Public WebBrowserBiblia As Boolean = False
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Dim VersiculoEncontrado As Boolean = False

        If WebBrowserBiblia Then
            Dim PageElement As HtmlElementCollection = Me.WebBrowser1.Document.GetElementsByTagName("div")
            For Each CurElement As HtmlElement In PageElement
                If (CurElement.GetAttribute("className") = "results") Then
                    Dim style As String = "<style>
                                              .b{display: none}
                                              a.fn,a.pr{display: none}
                                              .results ul{list-style-type: none!important}
                                              ul.results{List - style: none}
                                              .results.caption{Color: #443;font-size:3em;font-weight:300;padding-top:.5em;padding-bottom:0}
                                              .dir-ltr.results.caption, .results.caption.dir - ltr{padding-left: 0;padding-right:0}
                                              .results.caption.lnk{Color: #4477a1}
                                              .results a{text-decoration: none}
                                              .lang-es, .lang - es.lib - es, .mepslang - S.meps - S.meps_S{font-family: Helvetica, Arial, sans - serif;font-size: 2em}
                                              body{Color: #333;background-color:#f7f7f5;}
                                              p{font-Size:  2em;}
                                            </style>"
                    Dim ToBrowser As String = "<html><head>" + style + "</head><body><div Class= 'results' >" + CurElement.InnerHtml + "</div></body></html>"
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
    Private Sub Presentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.Location = Screen.PrimaryScreen.Bounds.Location + New Point(0, 0) Then
            Me.TopMost = False
            btnCerrar.Visible = True
            CheckScreens.Enabled = True
            ControlPanel.monitorPrincipal = True
            btnCerrar.Left = Screen.PrimaryScreen.WorkingArea.Width - btnCerrar.Width
        Else
            ControlPanel.monitorPrincipal = False
        End If

    End Sub
    Private Sub Presentacion_PermiteCerrar() Handles Me.Move, Me.ResizeEnd
        Try
            If Me.Location = Screen.PrimaryScreen.Bounds.Location + New Point(0, 0) Then
                btnCerrar.Left = Screen.PrimaryScreen.WorkingArea.Width - btnCerrar.Width
                Me.TopMost = False
                btnCerrar.Visible = True
                CheckScreens.Enabled = True
                ControlPanel.monitorPrincipal = True
                Update()
                UpdateBounds()
            Else
                btnCerrar.Visible = False
                Me.TopMost = True
                CheckScreens.Enabled = False
                ControlPanel.monitorPrincipal = False
                Update()
                UpdateBounds()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnCerrarArchivo_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        ControlPanel.tooglePresentacion(Me)
    End Sub

    Private Sub CheckScreens_Tick(sender As Object, e As EventArgs) Handles CheckScreens.Tick
        CheckScreens.Enabled = False
        If Location = Screen.PrimaryScreen.Bounds.Location + New Point(0, 0) Then
            Dim screen As Screen
            If Screen.AllScreens.Length > 1 Then
                For Each tempScreen In Screen.AllScreens
                    If tempScreen Is Screen.PrimaryScreen Then
                        Continue For
                    Else
                        Screen = tempScreen
                    End If
                Next
            Else
                Screen = Screen.PrimaryScreen
            End If
            WindowState = FormWindowState.Normal
            TopMost = True
            StartPosition = FormStartPosition.Manual
            Location = screen.Bounds.Location + New Point(0, 0)
            FormBorderStyle = FormBorderStyle.None
            WindowState = FormWindowState.Maximized
            Update()
            UpdateBounds()
            screen = Nothing

        End If
        CheckScreens.Enabled = True
    End Sub
End Class
