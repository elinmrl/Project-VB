Public Class datagridview
    Private Sub datagridview_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Rows.Add(1)
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0).Value = CStr(DataGridView1.RowCount - 1)
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(1).Value = TextBox1.Text
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(2).Value = TextBox2.Text
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(3).Value = TextBox3.Text
        DataGridView1.Update()

    End Sub

    Private Sub ListViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListViewToolStripMenuItem.Click
        Form7.Show()
        Me.Hide()

    End Sub

    Private Sub ArrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArrayToolStripMenuItem.Click
        Form5.Show()
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

    Private Sub KalkulatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KalkulatorToolStripMenuItem.Click
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()


    End Sub
End Class