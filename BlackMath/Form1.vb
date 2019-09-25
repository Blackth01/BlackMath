Imports WMPLib

Public Class Form1
    Public Player As WindowsMediaPlayer = New WindowsMediaPlayer
    Public tempo_musica As Double
    Public pausou As Boolean = False

    Sub SomBotao()
        My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Question)
    End Sub
    Sub SomBotao2()
        My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Beep)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not IsNumeric(TextBox1.Text) And TextBox1.Text <> "-" Or Not IsNumeric(TextBox2.Text) And TextBox2.Text <> "-" Then
            SomBotao2()
            MessageBox.Show("VOCÊ PRECISA DIGITAR UM VALOR", "ATENÇÃO")
        Else
            Dim A As Double = TextBox1.Text
            Dim B As Double = TextBox2.Text
            Dim C As Object = Button1
            SomBotao()
            TextBox12.Text = A & " + " & B & " = " & CDbl(A + B)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Not IsNumeric(TextBox1.Text) And TextBox1.Text <> "-" Or Not IsNumeric(TextBox2.Text) And TextBox2.Text <> "-" Then
            SomBotao2()
            MessageBox.Show("VOCÊ PRECISA DIGITAR UM VALOR", "ATENÇÃO")
        Else
            Dim A As Double = TextBox1.Text
            Dim B As Double = TextBox2.Text
            Dim C As Object = Button2
            SomBotao()
            TextBox12.Text = A & " - " & B & " = " & CDbl(A - B)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Not IsNumeric(TextBox1.Text) And TextBox1.Text <> "-" Or Not IsNumeric(TextBox2.Text) And TextBox2.Text <> "-" Then
            SomBotao2()
            MessageBox.Show("VOCÊ PRECISA DIGITAR UM VALOR", "ATENÇÃO")
        Else
            Dim A As Double = TextBox1.Text
            Dim B As Double = TextBox2.Text
            Dim C As Object = Button3
            SomBotao()
            TextBox12.Text = A & " X " & B & " = " & CDbl(A * B)
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Not IsNumeric(TextBox1.Text) And TextBox1.Text <> "-" Or Not IsNumeric(TextBox2.Text) And TextBox2.Text <> "-" Then
            SomBotao2()
            MessageBox.Show("VOCÊ PRECISA DIGITAR UM VALOR", "ATENÇÃO")
        Else
            Dim A As Double = TextBox1.Text
            Dim B As Double = TextBox2.Text
            Dim C As Object = Button4
            SomBotao()
            TextBox12.Text = A & " / " & B & " = " & CDbl(A / B)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If Not IsNumeric(TextBox1.Text) And TextBox1.Text <> "-" Then
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Not IsNumeric(TextBox3.Text) And TextBox3.Text <> "-" Or Not IsNumeric(TextBox4.Text) And TextBox4.Text <> "-" Then
            SomBotao2()
            MessageBox.Show("VOCÊ PRECISA DIGITAR UM VALOR", "ATENÇÃO")
        Else
            Dim X As Double = TextBox3.Text
            Dim Y As Double = TextBox4.Text
            Dim C As Object = Button5
            SomBotao()
            MessageBox.Show(X & "% de " & Y & " equivale a: " & (X * Y) / 100, "CALCULAR PORCENTAGEM")
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Not IsNumeric(TextBox5.Text) And TextBox5.Text <> "-" Or Not IsNumeric(TextBox6.Text) And TextBox6.Text <> "-" Then
            SomBotao2()
            MessageBox.Show("VOCÊ PRECISA DIGITAR UM VALOR", "ATENÇÃO")
        Else
            Dim X As Double = TextBox5.Text
            Dim Y As Double = TextBox6.Text
            Dim C As Object = Button6
            SomBotao()
            MessageBox.Show(X & " é " & (X * 100) / Y & "% de " & Y, "CALCULAR PORCENTAGEM")
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim X As String = TextBox7.Text
        ToolTip1.SetToolTip(Button7, "Você deve colocar as músicas em .mp3 dentro da pasta Usuários e em seguida digitar o nome delas na caixa acima")
        Try
            SomBotao()
            If My.Computer.FileSystem.FileExists("C:\Users\" & X & ".mp3") Then
                Player.URL = "C:\Users\" & X & ".mp3"
                Player.controls.play()
                pausou = False
                Button16.Text = "Pausar"
            Else
                MessageBox.Show("O ARQUIVO NÃO FOI ENCONTRADO!", "ERRO")
            End If

        Catch exc As Exception
            MessageBox.Show("O ARQUIVO NÃO FOI ENCONTRADO", "ERRO")
        End Try

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If Not IsNumeric(TextBox8.Text) And TextBox8.Text <> "-" Or Not IsNumeric(TextBox9.Text) And TextBox9.Text <> "-" Then
            SomBotao2()
            MessageBox.Show("VOCÊ PRECISA DIGITAR UM VALOR", "ATENÇÃO")
        Else
            Dim X As Double = TextBox8.Text
            Dim Y As Double = TextBox9.Text
            SomBotao()
            TextBox13.Text = X & " ^ " & Y & " = " & CDbl(X ^ Y)
        End If
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
        If Not IsNumeric(TextBox9.Text) And TextBox9.Text <> "-" Then
            TextBox9.Text = ""
        End If
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If Not IsNumeric(TextBox10.Text) And TextBox10.Text <> "-" Then
            SomBotao2()
            MessageBox.Show("VOCÊ PRECISA DIGITAR UM VALOR", "ATENÇÃO")
        Else
            Dim X As Double = TextBox10.Text
            If X < 0 Then
                SomBotao2()
                MessageBox.Show("NÃO É POSSÍVEL CALCULAR UMA RAIZ DE UM NÚMERO NEGATIVO!", "ATENÇÃO")
            Else
                SomBotao()
                MessageBox.Show("A raiz quadrada de " & X & " equivale a " & Math.Sqrt(X), "CALCULAR RAIZ QUADRADA")
            End If
        End If
    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged
        If Not IsNumeric(TextBox10.Text) And TextBox10.Text <> "-" Then
            TextBox10.Text = ""
        End If
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If Not IsNumeric(TextBox11.Text) And TextBox11.Text <> "-" Then
            SomBotao2()
            MessageBox.Show("VOCÊ PRECISA DIGITAR UM VALOR", "ATENÇÃO")
        Else
            Dim X As Double = TextBox11.Text
            SomBotao()
            MessageBox.Show(CDbl(X * 3.6) & " KM/H", "VELOCIDADE EM KM/H")
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If Not IsNumeric(TextBox11.Text) And TextBox11.Text <> "-" Then
            SomBotao2()
            MessageBox.Show("VOCÊ PRECISA DIGITAR UM VALOR", "ATENÇÃO")
        Else
            Dim X As Double = TextBox11.Text
            SomBotao()
            MessageBox.Show(CDbl(X / 3.6) & " M/S", "VELOCIDADE EM M/S")
        End If
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs)

    End Sub

    Private Sub FolderBrowserDialog1_HelpRequest(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        SomBotao()
        Form2.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub FolderBrowserDialog1_HelpRequest_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub TextBox13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox13.TextChanged

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub Button13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        If RadioButton1.Checked Then
            SomBotao()
            Form3.Show()
        ElseIf RadioButton2.Checked Then
            SomBotao()
            Form4.Show()

        End If
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Process.Start("Explorer", "C:\Users")

    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        SomBotao()
        Form5.Show()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        If Not pausou Then
            tempo_musica = Player.controls.currentPosition
            Player.controls.pause()
            Button16.Text = "Continuar"
            pausou = True
        Else
            Player.controls.currentPosition = tempo_musica
            Player.controls.play()
            Button16.Text = "Pausar"
            pausou = False
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If Not IsNumeric(TextBox2.Text) And TextBox2.Text <> "-" Then
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        If Not IsNumeric(TextBox5.Text) And TextBox5.Text <> "-" Then
            TextBox5.Text = ""
        End If
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        If Not IsNumeric(TextBox6.Text) And TextBox6.Text <> "-" Then
            TextBox6.Text = ""
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If Not IsNumeric(TextBox3.Text) And TextBox3.Text <> "-" Then
            TextBox3.Text = ""
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If Not IsNumeric(TextBox4.Text) And TextBox4.Text <> "-" Then
            TextBox4.Text = ""
        End If
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        If Not IsNumeric(TextBox8.Text) And TextBox8.Text <> "-" Then
            TextBox8.Text = ""
        End If
    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged
        If Not IsNumeric(TextBox11.Text) And TextBox11.Text <> "-" Then
            TextBox11.Text = ""
        End If
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Form6.Show()
    End Sub
End Class
