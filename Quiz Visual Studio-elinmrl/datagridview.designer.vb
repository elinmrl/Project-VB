<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class datagridview
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ListViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableDisableDanFunctionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KalkulatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoopingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(158, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DataGrid "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Umur"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(120, 41)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(120, 74)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(120, 113)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(270, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 76)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(29, 169)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(400, 130)
        Me.DataGridView1.TabIndex = 9
        '
        'Column1
        '
        Me.Column1.HeaderText = "No"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nama"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Umur"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Alamat"
        Me.Column4.Name = "Column4"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListViewToolStripMenuItem, Me.ArrayToolStripMenuItem, Me.EnableDisableDanFunctionToolStripMenuItem, Me.KalkulatorToolStripMenuItem, Me.LoopingToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(226, 114)
        '
        'ListViewToolStripMenuItem
        '
        Me.ListViewToolStripMenuItem.Name = "ListViewToolStripMenuItem"
        Me.ListViewToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.ListViewToolStripMenuItem.Text = "Select Case Timer"
        '
        'ArrayToolStripMenuItem
        '
        Me.ArrayToolStripMenuItem.Name = "ArrayToolStripMenuItem"
        Me.ArrayToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ArrayToolStripMenuItem.Text = "Array"
        '
        'EnableDisableDanFunctionToolStripMenuItem
        '
        Me.EnableDisableDanFunctionToolStripMenuItem.Name = "EnableDisableDanFunctionToolStripMenuItem"
        Me.EnableDisableDanFunctionToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.EnableDisableDanFunctionToolStripMenuItem.Text = "Enable-Disable dan Function"
        '
        'KalkulatorToolStripMenuItem
        '
        Me.KalkulatorToolStripMenuItem.Name = "KalkulatorToolStripMenuItem"
        Me.KalkulatorToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.KalkulatorToolStripMenuItem.Text = "Kalkulator"
        '
        'LoopingToolStripMenuItem
        '
        Me.LoopingToolStripMenuItem.Name = "LoopingToolStripMenuItem"
        Me.LoopingToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.LoopingToolStripMenuItem.Text = "Looping"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(487, 263)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(52, 27)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Menu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'datagridview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 321)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "datagridview"
        Me.Text = "datagridview"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ListViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArrayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnableDisableDanFunctionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KalkulatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoopingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button2 As Button
End Class
