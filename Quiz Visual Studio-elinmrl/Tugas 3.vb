Public Class Tugas_3

    Dim hasil As Integer
    Private Sub Tugas_3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
        Button2.Enabled = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Button1.Enabled = True
        Button2.Enabled = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Button1.Enabled = False
        Button2.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Masukkan Jumlah Datanya")
        ListBox1.Items.Add("Total Denda Yang Dibayar")
        hasil = Val(TextBox7.Text) * Val(TextBox8.Text)
        ListBox1.Items.Add(hasil)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Masukkan Jumlah Dendanya")
        ListBox1.Items.Add("Total Denda Yang Dibayar")
        hasil = Val(TextBox7.Text) * Val(TextBox8.Text)
        ListBox1.Items.Add(hasil)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With ListBox1
            .Items.Add(TextBox1.Text)
            .Items.Add(TextBox2.Text)
            .Items.Add(TextBox4.Text)
            .Items.Add(ComboBox1.Text)
            .Items.Add(TextBox4.Text)
            .Items.Add(TextBox5.Text)
            .Items.Add(TextBox6.Text)
            If CheckBox1.Checked Then
                .Items.Add(CheckBox1.Text)
            End If
            If CheckBox2.Checked Then
                .Items.Add(CheckBox2.Text)
            End If
        End With

        Dim na As Integer
        Dim nama As String
        nama = InputBox("nama Anda siapa")
        na = InputBox("Tekan 1 Untuk Melanjutkan")
        ListBox2.Items.Add(nama)
        ListBox2.Items.Add("Anda Berhasil")
        ListBox2.Items.Add(pedoman(na))
        ListBox2.Items.Add("")
    End Sub
    Function pedoman(ByVal nilai As Integer)

        If nilai >= 1 Then
            pedoman = "L O G I N"
        Else pedoman = "G A  L O G I N"
        End If
    End Function





    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        TextBox1.ResetText()
        TextBox2.ResetText()
        TextBox3.ResetText()
        ComboBox1.ResetText()
        TextBox4.ResetText()
        TextBox5.ResetText()
        TextBox6.ResetText()
        TextBox7.ResetText()
        TextBox8.ResetText()

        RadioButton1.Checked = CheckState.Unchecked
        RadioButton2.Checked = CheckState.Unchecked
        CheckBox2.CheckState = CheckState.Unchecked
        CheckBox1.CheckState = CheckState.Unchecked
    End Sub

    Private Sub ListViewToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form7.Show()
        Me.Hide()


    End Sub

    Private Sub DatagridViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatagridViewToolStripMenuItem.Click
        datagridview.Show()
        Me.Hide()

    End Sub

    Private Sub ArrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArrayToolStripMenuItem.Click
        Form5.Show()
        Me.Hide()

    End Sub

    Private Sub LoopingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoopingToolStripMenuItem.Click
        Form10.Show()
        Me.Hide()

    End Sub

    Private Sub KalkulatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KalkulatorToolStripMenuItem.Click
        Form9.Show()
        Me.Hide()

    End Sub

    Private Sub SelectCaseTimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectCaseTimerToolStripMenuItem.Click
        Form7.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class