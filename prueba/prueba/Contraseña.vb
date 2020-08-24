Public Class Contraseña

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (TextBox1.Text = "PRUEBA") And TextBox2.Text = "PRUEBA" Then

            MsgBox("CORRECTO")
            Principal.Show()
            Me.Close()

        Else
            MsgBox("USUARIO O CONTRASEÑA INCORRECTA")


        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class