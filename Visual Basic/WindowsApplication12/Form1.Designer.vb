<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.open_btn = New System.Windows.Forms.Button()
        Me.copy_btn = New System.Windows.Forms.Button()
        Me.red_rb = New System.Windows.Forms.RadioButton()
        Me.green_rb = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.blue_rb = New System.Windows.Forms.RadioButton()
        Me.yellow_rb = New System.Windows.Forms.RadioButton()
        Me.magenta_rb = New System.Windows.Forms.RadioButton()
        Me.cyan_rb = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.reset_btn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'open_btn
        '
        Me.open_btn.Location = New System.Drawing.Point(33, 279)
        Me.open_btn.Name = "open_btn"
        Me.open_btn.Size = New System.Drawing.Size(96, 23)
        Me.open_btn.TabIndex = 0
        Me.open_btn.Text = "Buka File"
        Me.open_btn.UseVisualStyleBackColor = True
        '
        'copy_btn
        '
        Me.copy_btn.Location = New System.Drawing.Point(135, 279)
        Me.copy_btn.Name = "copy_btn"
        Me.copy_btn.Size = New System.Drawing.Size(94, 23)
        Me.copy_btn.TabIndex = 1
        Me.copy_btn.Text = "Copy Gambar"
        Me.copy_btn.UseVisualStyleBackColor = True
        '
        'red_rb
        '
        Me.red_rb.AutoSize = True
        Me.red_rb.ForeColor = System.Drawing.Color.Black
        Me.red_rb.Location = New System.Drawing.Point(455, 279)
        Me.red_rb.Name = "red_rb"
        Me.red_rb.Size = New System.Drawing.Size(45, 17)
        Me.red_rb.TabIndex = 2
        Me.red_rb.TabStop = True
        Me.red_rb.Text = "Red"
        Me.red_rb.UseVisualStyleBackColor = True
        '
        'green_rb
        '
        Me.green_rb.AutoSize = True
        Me.green_rb.ForeColor = System.Drawing.Color.Black
        Me.green_rb.Location = New System.Drawing.Point(455, 302)
        Me.green_rb.Name = "green_rb"
        Me.green_rb.Size = New System.Drawing.Size(54, 17)
        Me.green_rb.TabIndex = 3
        Me.green_rb.TabStop = True
        Me.green_rb.Text = "Green"
        Me.green_rb.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(33, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(196, 196)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(246, 61)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(196, 196)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(457, 61)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(196, 196)
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'blue_rb
        '
        Me.blue_rb.AutoSize = True
        Me.blue_rb.ForeColor = System.Drawing.Color.Black
        Me.blue_rb.Location = New System.Drawing.Point(455, 326)
        Me.blue_rb.Name = "blue_rb"
        Me.blue_rb.Size = New System.Drawing.Size(46, 17)
        Me.blue_rb.TabIndex = 7
        Me.blue_rb.TabStop = True
        Me.blue_rb.Text = "Blue"
        Me.blue_rb.UseVisualStyleBackColor = True
        '
        'yellow_rb
        '
        Me.yellow_rb.AutoSize = True
        Me.yellow_rb.ForeColor = System.Drawing.Color.Black
        Me.yellow_rb.Location = New System.Drawing.Point(524, 326)
        Me.yellow_rb.Name = "yellow_rb"
        Me.yellow_rb.Size = New System.Drawing.Size(56, 17)
        Me.yellow_rb.TabIndex = 10
        Me.yellow_rb.TabStop = True
        Me.yellow_rb.Text = "Yellow"
        Me.yellow_rb.UseVisualStyleBackColor = True
        '
        'magenta_rb
        '
        Me.magenta_rb.AutoSize = True
        Me.magenta_rb.ForeColor = System.Drawing.Color.Black
        Me.magenta_rb.Location = New System.Drawing.Point(524, 302)
        Me.magenta_rb.Name = "magenta_rb"
        Me.magenta_rb.Size = New System.Drawing.Size(67, 17)
        Me.magenta_rb.TabIndex = 9
        Me.magenta_rb.TabStop = True
        Me.magenta_rb.Text = "Magenta"
        Me.magenta_rb.UseVisualStyleBackColor = True
        '
        'cyan_rb
        '
        Me.cyan_rb.AutoSize = True
        Me.cyan_rb.ForeColor = System.Drawing.Color.Black
        Me.cyan_rb.Location = New System.Drawing.Point(524, 279)
        Me.cyan_rb.Name = "cyan_rb"
        Me.cyan_rb.Size = New System.Drawing.Size(49, 17)
        Me.cyan_rb.TabIndex = 8
        Me.cyan_rb.TabStop = True
        Me.cyan_rb.Text = "Cyan"
        Me.cyan_rb.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Gambar Asli"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(259, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Hasil Copy Per Pixel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(453, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Hasil Perubahan Warna"
        '
        'reset_btn
        '
        Me.reset_btn.Location = New System.Drawing.Point(33, 308)
        Me.reset_btn.Name = "reset_btn"
        Me.reset_btn.Size = New System.Drawing.Size(96, 23)
        Me.reset_btn.TabIndex = 14
        Me.reset_btn.Text = "Exit"
        Me.reset_btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 361)
        Me.Controls.Add(Me.yellow_rb)
        Me.Controls.Add(Me.magenta_rb)
        Me.Controls.Add(Me.cyan_rb)
        Me.Controls.Add(Me.blue_rb)
        Me.Controls.Add(Me.green_rb)
        Me.Controls.Add(Me.red_rb)
        Me.Controls.Add(Me.reset_btn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.copy_btn)
        Me.Controls.Add(Me.open_btn)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dasar Pengolahan Citra"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents open_btn As System.Windows.Forms.Button
    Friend WithEvents copy_btn As System.Windows.Forms.Button
    Friend WithEvents red_rb As System.Windows.Forms.RadioButton
    Friend WithEvents green_rb As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents blue_rb As System.Windows.Forms.RadioButton
    Friend WithEvents yellow_rb As System.Windows.Forms.RadioButton
    Friend WithEvents magenta_rb As System.Windows.Forms.RadioButton
    Friend WithEvents cyan_rb As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents reset_btn As System.Windows.Forms.Button

End Class
