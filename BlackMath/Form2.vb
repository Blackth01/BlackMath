Public Class Form2
    Sub SomBotao()
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton6.CheckedChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        If Not IsNumeric(TextBox1.Text) And TextBox1.Text <> "-" Then
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Not IsNumeric(TextBox1.Text) And TextBox1.Text <> "-" Then
            SomBotao()
            MessageBox.Show("VOCÊ PRECISA DIGITAR UM VALOR", "ATENÇÃO")
        Else
            If RadioButton1.Checked Then
                TextBox2.Text = TextBox1.Text
                TextBox3.Text = CDbl(TextBox1.Text / 1024)
                TextBox4.Text = CDbl(TextBox1.Text / 1048576)
                TextBox5.Text = CDbl(TextBox1.Text / 1073741824)
                TextBox6.Text = CDbl(TextBox1.Text * 8)
                TextBox7.Text = CDbl((TextBox1.Text * 8) / 1024)
                TextBox8.Text = CDbl((TextBox1.Text * 8) / 1048576)
                TextBox9.Text = CDbl((TextBox1.Text * 8) / 1073741824)
            ElseIf RadioButton2.Checked Then
                TextBox2.Text = CDbl(TextBox1.Text * 1024)
                TextBox3.Text = TextBox1.Text
                TextBox4.Text = CDbl(TextBox1.Text / 1024)
                TextBox5.Text = CDbl(TextBox1.Text / 1048576)
                TextBox6.Text = CDbl((TextBox1.Text * 8) * 1024)
                TextBox7.Text = CDbl(TextBox1.Text * 8)
                TextBox8.Text = CDbl((TextBox1.Text * 8) / 1024)
                TextBox9.Text = CDbl((TextBox1.Text * 8) / 1048576)
            ElseIf RadioButton3.Checked Then
                TextBox2.Text = CDbl(TextBox1.Text * 1048576)
                TextBox3.Text = CDbl(TextBox1.Text * 1024)
                TextBox4.Text = TextBox1.Text
                TextBox5.Text = CDbl(TextBox1.Text / 1024)
                TextBox6.Text = CDbl((TextBox1.Text * 8) * 1048576)
                TextBox7.Text = CDbl((TextBox1.Text * 8) * 1024)
                TextBox8.Text = CDbl(TextBox1.Text * 8)
                TextBox9.Text = CDbl((TextBox1.Text * 8) / 1024)
            ElseIf RadioButton4.Checked Then
                TextBox2.Text = CDbl(TextBox1.Text * 1073741824)
                TextBox3.Text = CDbl(TextBox1.Text * 1048576)
                TextBox4.Text = CDbl(TextBox1.Text * 1024)
                TextBox5.Text = TextBox1.Text
                TextBox6.Text = CDbl((TextBox1.Text * 8) * 1073741824)
                TextBox7.Text = CDbl((TextBox1.Text * 8) * 1048576)
                TextBox8.Text = CDbl((TextBox1.Text * 8) * 1024)
                TextBox9.Text = CDbl((TextBox1.Text * 8))
            ElseIf RadioButton5.Checked Then
                TextBox2.Text = CDbl(TextBox1.Text / 8)
                TextBox3.Text = CDbl((TextBox1.Text / 8) / 1024)
                TextBox4.Text = CDbl((TextBox1.Text / 8) / 1048576)
                TextBox5.Text = CDbl((TextBox1.Text / 8) / 1073741824)
                TextBox6.Text = TextBox1.Text
                TextBox7.Text = CDbl(TextBox1.Text / 1024)
                TextBox8.Text = CDbl(TextBox1.Text / 1048576)
                TextBox9.Text = CDbl(TextBox1.Text / 1073741824)
            ElseIf RadioButton6.Checked Then
                TextBox2.Text = CDbl((TextBox1.Text / 8) * 1024)
                TextBox3.Text = CDbl(TextBox1.Text / 8)
                TextBox4.Text = CDbl((TextBox1.Text / 8) / 1024)
                TextBox5.Text = CDbl((TextBox1.Text / 8) / 1048576)
                TextBox6.Text = CDbl(TextBox1.Text * 1024)
                TextBox7.Text = TextBox1.Text
                TextBox8.Text = CDbl(TextBox1.Text / 1024)
                TextBox9.Text = CDbl(TextBox1.Text / 1048576)
            ElseIf RadioButton7.Checked Then
                TextBox2.Text = CDbl((TextBox1.Text / 8) * 1048576)
                TextBox3.Text = CDbl((TextBox1.Text / 8) * 1024)
                TextBox4.Text = CDbl(TextBox1.Text / 8)
                TextBox5.Text = CDbl((TextBox1.Text / 8) / 1024)
                TextBox6.Text = CDbl(TextBox1.Text * 1048576)
                TextBox7.Text = CDbl(TextBox1.Text * 1024)
                TextBox8.Text = TextBox1.Text
                TextBox9.Text = CDbl(TextBox1.Text / 1024)
            ElseIf RadioButton8.Checked Then
                TextBox2.Text = CDbl((TextBox1.Text / 8) * 1073741824)
                TextBox3.Text = CDbl((TextBox1.Text / 8) * 1048576)
                TextBox4.Text = CDbl((TextBox1.Text / 8) * 1024)
                TextBox5.Text = CDbl(TextBox1.Text / 8)
                TextBox6.Text = CDbl(TextBox1.Text * 1073741824)
                TextBox7.Text = CDbl(TextBox1.Text * 1048576)
                TextBox8.Text = CDbl(TextBox1.Text * 1024)
                TextBox9.Text = TextBox1.Text
            End If
        End If
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton5.CheckedChanged

    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton7.CheckedChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label10_Click(sender As System.Object, e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub TextBox8_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class