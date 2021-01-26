Public Class Form9
    Dim hasil As Integer

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox3.ReadOnly = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Datanya masukin dulu")
            TextBox1.Focus()
        End If
        If TextBox2.Text = "" Then
            MsgBox("Datanya masukin dulu")
            TextBox2.Focus()
        End If
        If RadioButton1.Checked = True Then
            Label1.Text = "+"
            TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
        End If
        If RadioButton2.Checked = True Then
            Label1.Text = "-"
            TextBox3.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
        End If
        If RadioButton3.Checked = True Then
            Label1.Text = "x"
            TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
        End If
        If RadioButton4.Checked = True Then
            Label1.Text = "/"
            TextBox3.Text = Val(TextBox1.Text) / Val(TextBox2.Text)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        Label1.ResetText()
        RadioButton1.Checked = CheckState.Unchecked
        RadioButton2.Checked = CheckState.Unchecked
        RadioButton3.Checked = CheckState.Unchecked
        RadioButton4.Checked = CheckState.Unchecked
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub ArrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArrayToolStripMenuItem.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataGridViewToolStripMenuItem.Click
        datagridview.Show()
        Me.Hide()


    End Sub

    Private Sub EnableDisableDanFunctionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnableDisableDanFunctionToolStripMenuItem.Click
        Tugas_3.Show()
        Me.Hide()


    End Sub

    Private Sub LoopingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoopingToolStripMenuItem.Click
        Form7.Show()
        Me.Hide()

    End Sub

    Private Sub SelectCaseTimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectCaseTimerToolStripMenuItem.Click
        Form10.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.Show()
        Me.Hide()

    End Sub
End Class