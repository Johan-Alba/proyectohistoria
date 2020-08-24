Public Class pdf

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        AxAcroPDF1.LoadFile(Application.StartupPath + "\ej1.pdf")
    End Sub

    Private Sub Siguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Siguiente.Click
        Video.Show()
        Me.Close()
    End Sub

    Private Sub AxAcroPDF1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxAcroPDF1.Enter

    End Sub
End Class