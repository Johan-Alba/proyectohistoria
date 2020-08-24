Public Class Principal

    Private Sub aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aceptar.Click
        WebBrowser1.Navigate(Application.StartupPath + "\sumas.htm")
    End Sub

    Private Sub siguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles siguiente.Click
        pdf.Show()
        Me.Close()

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub
End Class