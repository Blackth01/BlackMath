Public Class Form5
    Sub SomBotao()
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
    End Sub


    Private Sub Form5_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.TextChanged
        If Not IsNumeric(TextBox3.Text) And TextBox3.Text <> "-" Then
            TextBox3.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Not IsNumeric(TextBox1.Text) And TextBox1.Text <> "-" Or Not IsNumeric(TextBox2.Text) And TextBox2.Text <> "-" Or _
            Not IsNumeric(TextBox3.Text) And TextBox3.Text <> "-" Then
            SomBotao()
            MessageBox.Show("VOCÊ PRECISA DIGITAR UM VALOR", "ATENÇÃO")
        Else
            Dim A As Integer = TextBox1.Text
            Dim B As Integer = TextBox2.Text
            Dim C As Integer = TextBox3.Text
            Dim Delta As Double = (B * B) - 4 * A * C
            If Delta < 0 Then
                SomBotao()
                MessageBox.Show("NÃO É POSSÍVEL CALCULAR ESSA EQUAÇÃO, POIS A RAIZ É NEGATIVA.", "FÓRMULA DE BHASKARA")
            Else
                Label6.Text = ((-1 * B) + Math.Sqrt(Delta)) / 2 * A
                Label7.Text = ((-1 * B) - Math.Sqrt(Delta)) / 2 * A
                Label9.Text = Delta

            End If
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        If Not IsNumeric(TextBox1.Text) And TextBox1.Text <> "-" Then
            TextBox1.Text = ""
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        If Not IsNumeric(TextBox2.Text) And TextBox2.Text <> "-" Then
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub Label9_Click(sender As System.Object, e As System.EventArgs) Handles Label9.Click

    End Sub
End Class