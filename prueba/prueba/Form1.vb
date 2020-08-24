Public Class Form1

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cargando.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 4
            prueba.Text = "Cargando al " & ProgressBar1.Value & "%"
            cargando.Text = "SOFTWARE DE MATEMATICAS"
        Else
            Timer1.Enabled = False

            Me.Visible = False
            Contraseña.Visible = True
        End If
    End Sub
End Class
