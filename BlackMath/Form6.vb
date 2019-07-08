Public Class Form6

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Label2.Text = "An"
        Label3.Text = "N"
        Label4.Text = "A1"
    End Sub

    Private Sub Form6_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Label2.Text = "A1"
        Label3.Text = "N"
        Label4.Text = "R"
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Label2.Text = "An"
        Label3.Text = "N"
        Label4.Text = "R"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Label2.Text = "An"
        Label3.Text = "R"
        Label4.Text = "A1"
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MessageBox.Show("VOCÊ PRECISA DIGITAR UM VALOR!!", "ATENÇÃO")
        Else
            If RadioButton1.Checked Then
                Dim A1 As Double = TextBox1.Text
                Dim N As Double = TextBox2.Text
                Dim R As Double = TextBox3.Text
                TextBox4.Text = A1 + (N - 1) * R
            End If
            If RadioButton2.Checked Then
                Dim An As Double = TextBox1.Text
                Dim N As Double = TextBox2.Text
                Dim A1 As Double = TextBox3.Text
                TextBox4.Text = (An - A1) / (N - 1)
            End If
            If RadioButton3.Checked Then
                Dim An As Double = TextBox1.Text
                Dim R As Double = TextBox2.Text
                Dim A1 As Double = TextBox3.Text
                TextBox4.Text = ((R * -1) - An + A1) / R * -1
            End If
            If RadioButton4.Checked Then
                Dim An As Double = TextBox1.Text
                Dim N As Double = TextBox2.Text
                Dim R As Double = TextBox3.Text
                TextBox4.Text = (((N - 1) * R) * -1) + An
            End If
            If RadioButton5.Checked Then
                Dim A1 As Double = TextBox1.Text
                Dim An As Double = TextBox2.Text
                Dim N As Double = TextBox3.Text
                TextBox4.Text = ((A1 + An) * N) / 2
            End If
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton5.CheckedChanged
        Label2.Text = "A1"
        Label3.Text = "An"
        Label4.Text = "N"

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        If Not IsNumeric(TextBox1.Text) And TextBox1.Text <> "-" Then
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        If Not IsNumeric(TextBox2.Text) And TextBox1.Text <> "-" Then
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.TextChanged
        If Not IsNumeric(TextBox3.Text) And TextBox1.Text <> "-" Then
            TextBox3.Text = ""
        End If
    End Sub
End Class