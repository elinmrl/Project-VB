Public Class Form7

    Dim Waktu As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Timer1.Start()
        Call soal()
    End Sub
    Sub soal()
        If Waktu = 0 Then
            Dim pertanyaan As String
            pertanyaan = Int(Rnd() * 3)
            Select Case pertanyaan
                Case 0
                    Me.TextBox1.Text = "12312-34-4555-Aj889″"
                Case 1
                    Me.TextBox1.Text = "555-ZAweR-9999-CXXhhuI"
                Case 2
                    Me.TextBox1.Text = "ssss-cccc-zzzz-loPPN"
                Case 3
                    Me.TextBox1.Text = "ooooo-oooo-4555-RtyuxD"
            End Select
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Waktu = Waktu + 1
        Me.Label4.Text = Waktu
        If Waktu = 120 Then
            Waktu = 0
            Me.Timer1.Stop()
            MsgBox("maaf waktu anda maka serial number akan otomatis berubah")
            Me.TextBox1.Text = ""
            Me.TextBox2.Text = ""
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Timer1.Stop()
        If Me.TextBox1.Text = Me.TextBox2.Text Then
            MsgBox(" serial sama, anda dapat mencrack softwarenya")

        Else
            MsgBox("serial salah, maka otomatis aplikasi keluar")
            Me.Close()
        End If

    End Sub

    Private Sub Tugas1ToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs)
        TextBox1.Copy()

    End Sub

    Private Sub CopyToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PasteToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        TextBox2.Paste()

    End Sub

    Private Sub KalkulatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KalkulatorToolStripMenuItem.Click
        Form9.Show()
        Me.Hide()
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
        Form10.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Hide()

    End Sub
End Class


