Public Class Form10
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim angka_awal, angka_akhir As Integer
        angka_awal = TextBox1.Text
        angka_akhir = TextBox2.Text
        ListBox1.Items.Clear()
        'belajar while
        While angka_awal < (angka_akhir + 1)
            ListBox1.Items.Add(angka_awal)
            angka_awal = angka_awal + 1
        End While
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim angka_awal, angka_akhir As Integer
        angka_awal = TextBox1.Text
        angka_akhir = TextBox2.Text
        ListBox1.Items.Clear()
        ' belajar do while loop
        Do While angka_awal < (angka_akhir + 1)
            ListBox1.Items.Add(angka_awal)
            angka_awal += 1
        Loop
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim angka_awal, angka_akhir As Integer
        angka_awal = TextBox1.Text
        angka_akhir = TextBox2.Text
        ListBox1.Items.Clear()
        ' belajar do loop until
        Do
            ListBox1.Items.Add(angka_awal)
            angka_awal += 1
        Loop Until angka_awal > (angka_akhir)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim angka_awal, angka_akhir As Integer
        angka_awal = TextBox1.Text
        angka_akhir = TextBox2.Text
        ListBox1.Items.Clear()

        For angka_awal = angka_awal To angka_akhir
            ListBox1.Items.Add(angka_awal)
        Next
    End Sub

    

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ArrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArrayToolStripMenuItem.Click
        Form5.Show()
        Me.Hide()


    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs)
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub KalkulatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KalkulatorToolStripMenuItem.Click
        Form9.Show()
        Me.Hide()


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub DisableEnableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisableEnableToolStripMenuItem.Click
        Tugas_3.Show()
        Me.Hide()
    End Sub

    Private Sub SelectCaseDanTimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectCaseDanTimerToolStripMenuItem.Click
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub DatagridviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatagridviewToolStripMenuItem.Click
        datagridview.Show()
        Me.Hide()
    End Sub
End Class



