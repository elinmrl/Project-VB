Public Class Form5
    Private Sub Nim_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arr(3, 1) As String
        arr(0, 0) = "NIM"
        arr(0, 1) = "Nama"
        arr(1, 0) = "Jenis Kelamin"
        arr(1, 1) = "Status"
        arr(2, 0) = "Laki-laki"
        arr(2, 1) = "Perempuan"
        arr(3, 0) = "Menikah"
        arr(3, 1) = "Belum Menikah"

        For baris = 0 To 1
            For kolom = 0 To 1
                ListView1.Columns.Add(arr(baris, kolom), 100)
            Next
        Next

        For baris = 2 To 2
            For kolom = 0 To 1
                ComboBox1.Items.Add(arr(baris, kolom))
            Next
        Next

        For baris = 3 To 3
            For kolom = 0 To 1
                ComboBox2.Items.Add(arr(baris, kolom))
            Next
        Next
        TextBox1.ReadOnly = True
        TextBox1.Text = "1"
        TextBox2.Focus()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim arr(4) As String
        arr(0) = TextBox1.Text
        arr(1) = TextBox2.Text
        arr(2) = ComboBox1.Text
        arr(3) = ComboBox2.Text

        Dim list As New ListViewItem
        list = ListView1.Items.Add(arr(0))
        list.SubItems.Add(arr(1))
        list.SubItems.Add(arr(2))
        list.SubItems.Add(arr(3))

        TextBox1.Text = TextBox1.Text + 1
        TextBox2.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox2.Focus()

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub ListViewToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form7.Show()
        Me.Hide()

    End Sub

    Private Sub DatagridViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatagridViewToolStripMenuItem.Click
        datagridview.Show()
        Me.Hide()


    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub KalkulatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KalkulatorToolStripMenuItem.Click
        Form9.Show()
        Me.Hide()

    End Sub

    Private Sub EnableDisableDanFunctionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnableDisableDanFunctionToolStripMenuItem.Click
        Tugas_3.Show()
        Me.Hide()
    End Sub

    Private Sub LoopingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoopingToolStripMenuItem.Click
        Form10.Show()
        Me.Hide()
    End Sub

    Private Sub SelectCaseTImerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectCaseTImerToolStripMenuItem.Click
        Form7.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()

    End Sub
End Class