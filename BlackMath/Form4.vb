Public Class Form4
    Sub SomBotao()
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Not IsNumeric(TextBox1.Text) And TextBox1.Text <> "-" Or Not IsNumeric(TextBox2.Text) And TextBox2.Text <> "-" Then
            SomBotao()
            MessageBox.Show("VOCÊ PRECISA DIGITAR UM VALOR", "ATENÇÃO")
        Else
            Dim A As Double = TextBox1.Text
            Dim B As Double = TextBox2.Text
            Dim C As Double = (A * A) - (B * B)
            Label4.Text = Math.Sqrt(C)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        If Not IsNumeric(TextBox1.Text) And TextBox1.Text <> "-" Then
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        If Not IsNumeric(TextBox2.Text) And TextBox2.Text <> "-" Then
            TextBox2.Text = ""
        End If
    End Sub
End Class