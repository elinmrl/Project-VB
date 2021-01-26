Public Class Form3
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        With TextBox1
            If ComboBox1.Text = "Penggaris" Then
                TextBox2.Text = 5000
            ElseIf ComboBox1.Text = "Sabun" Then
                TextBox2.Text = 3000
            ElseIf ComboBox1.Text = "Shampo" Then
                TextBox2.Text = 4000
            ElseIf ComboBox1.Text = "Gayung" Then
                TextBox2.Text = 6000
            End If
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = TextBox1.Text * TextBox2.Text
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            TextBox4.Text = 0
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            TextBox4.Text = 5
        End If

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            TextBox4.Text = 20
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            TextBox4.Text = 25
        End If

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            TextBox4.Text = 30

        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked Then
            TextBox4.Text = 50

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox5.Text = TextBox3.Text - (TextBox3.Text * TextBox4.Text / 100)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        With TextBox1
            If ComboBox1.Text = "Rinso" Then
                TextBox2.Text = 6000
            ElseIf ComboBox1.Text = "Pasta Gigi" Then
                TextBox2.Text = 3000
            ElseIf ComboBox1.Text = "Sabun" Then
                TextBox2.Text = 4000
            ElseIf ComboBox1.Text = "Minyak Goreng" Then
                TextBox2.Text = 12000
            End If
        End With
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox8.Text = TextBox6.Text - TextBox5.Text
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox7.Text = 10
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox10.Text = TextBox6.Text - TextBox11.Text

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox9.Text = (TextBox5.Text * 0.1)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox11.Text = Val(TextBox5.Text) + Val(TextBox9.Text)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) 

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        DataGridView1.Rows.Add(1)
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0).Value = CStr(DataGridView1.RowCount - 1)
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(1).Value = ComboBox1.Text
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(2).Value = TextBox1.Text
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(3).Value = TextBox2.Text
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(4).Value = TextBox5.Text
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(5).Value = TextBox6.Text
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(6).Value = TextBox11.Text
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(7).Value = TextBox10.Text
        DataGridView1.Update()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        Form4.Label16.Text = (Me.ComboBox1.Text)
        Form4.Label17.Text = (Me.TextBox1.Text)
        Form4.Label18.Text = (Me.TextBox4.Text)
        Form4.Label19.Text = (Me.TextBox5.Text)
        Form4.Label20.Text = (Me.TextBox6.Text)
        Form4.Label21.Text = (Me.TextBox9.Text)
        Form4.Label22.Text = (Me.TextBox11.Text)
        Form4.Label23.Text = (Me.TextBox10.Text)
        Form4.Show()
        Me.Hide()



    End Sub
End Class