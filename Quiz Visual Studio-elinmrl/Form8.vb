Public Class Form8
    Dim hasil As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Berikut Hasil Gaji Anda...")
        ListBox1.Items.Add("---------Gaji anda Adalah------------")
        If Val(TextBox1.Text) = "50" Or Val(TextBox1.Text) = "51" Or Val(TextBox1.Text) = "52" Or Val(TextBox1.Text) = "53" Or Val(TextBox1.Text) = "54" Or Val(TextBox1.Text) = "55" Or Val(TextBox1.Text) = "51" Or Val(TextBox1.Text) = "56" Or Val(TextBox1.Text) = "57" Or Val(TextBox1.Text) = "58" Or Val(TextBox1.Text) = "59" Or Val(TextBox1.Text) = "60" Then
            hasil = Val(TextBox1.Text) * Val(5000)
            ListBox1.Items.Add("TOTAL GAJI MINGGU INI Rp. " & hasil)
        ElseIf Val(TextBox1.Text) >= 60 Then
            ListBox1.Items.Add("Di karenakan anda Memiliki Bonus Karena Lembur!")
            ListBox1.Items.Add("Anda Memiliki Bonus Menjadi 7500/jam kerja perminggu")
            hasil = Val(TextBox1.Text) * Val(7500)
            ListBox1.Items.Add("TOTAL GAJI MINGGU INI Rp. " & hasil)
        ElseIf Val(TextBox1.Text) <= 50 Then
            hasil = Val(TextBox1.Text) * Val(2500)
            ListBox1.Items.Add("Di karenakan anda Kekurangan Jam Kerja!")
            ListBox1.Items.Add("Gaji Anda Dipotong Menjadi 2500/jam kerja perminggu")
            ListBox1.Items.Add("TOTAL GAJI MINGGU INI Rp. " & hasil)
        End If
        TextBox1.Clear()
        ListBox1.Items.Add(" ")
        ListBox1.Items.Add(" ")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Data dihapus")
        ListBox1.Items.Clear()
        TextBox1.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Hide()

    End Sub
End Class
