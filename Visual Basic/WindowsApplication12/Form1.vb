Public Class Form1

    Private Property Tot_Pix As Object

    Private Sub OpenImage(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles open_btn.Click
        ' membuat objek OpenFileDialog dengan nama ofd
        Dim ofd As New OpenFileDialog

        ' set initial directory, directory awal saat browse file
        ofd.InitialDirectory = "c:\"
        ofd.Filter = "Image files (*.bmp, *.jpg,*.png)|*.bmp;*.jpg;*.png"



        ' jika file telah valid dan user menekan tombol OK
        ' maka citra akan di load ke dalam picture box
        If ofd.ShowDialog() = DialogResult.OK Then
            ' load citra ke dalam picture box
            PictureBox1.Image = New Bitmap(ofd.FileName)

            ' mode untuk menampilkan ukuran citra pada picture box
            ' Stretch : ukuran tidak sesuai dengan citra asli, hanya berupa tampilan
            ' sehingga saat citra diambil dari picture box, user tetap mendapatkan
            ' citra ukuran yang asli
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox2.Image = Nothing
            PictureBox3.Image = Nothing
        End If
    End Sub

    Private Sub CopyImage(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles copy_btn.Click
        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("Please open the image first!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim source As New Bitmap(PictureBox1.Image) ' membuat variabel dengan tipe data bitmap pada picturebox1
            Dim red, green, blue As Integer ' membuat variabel red, green, blue dengan tipe data integer
            For y As Integer = 0 To source.Height - 1 'menghitung nilai y (tinggi) 
                For x As Integer = 0 To source.Width - 1 'menghitung nilai x (lebar) 
                    red = source.GetPixel(x, y).R 'mengambil nilai x dan y berwarna merah 
                    green = source.GetPixel(x, y).G 'mengambil nilai x dan y berwarna hijau
                    blue = source.GetPixel(x, y).B 'mengambil nilai x dan y berwarna biru

                    source.SetPixel(x, y, Color.FromArgb(red, green, blue)) 'set pixel x dan y berdasarkan warna rgb pada gambar yang dibuka 
                Next
            Next

            PictureBox2.Image = source 'picturebox3 diisi hasil variabel source
            PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage 'untuk menyesuaikan gambar dengan ukuran picturebox
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ChangedToRed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles red_rb.CheckedChanged
        If PictureBox2.Image Is Nothing Then
            MessageBox.Show("Please copy the image first!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim source As New Bitmap(PictureBox1.Image)
            Dim red, green, blue As Integer
            For y As Integer = 0 To source.Height - 1
                For x As Integer = 0 To source.Width - 1
                    red = source.GetPixel(x, y).R
                    green = source.GetPixel(x, y).G
                    blue = source.GetPixel(x, y).B

                    source.SetPixel(x, y, Color.FromArgb(red, 0, 0)) 'set pixel x dan y berdasarkan warna merah pada gambar yang dibuka 
                Next
            Next

            PictureBox3.Image = source
            PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub ChangeToGreen(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles green_rb.CheckedChanged
        If PictureBox2.Image Is Nothing Then
            MessageBox.Show("Please copy the image first!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim source As New Bitmap(PictureBox1.Image)
            Dim red, green, blue As Integer
            For y As Integer = 0 To source.Height - 1
                For x As Integer = 0 To source.Width - 1
                    red = source.GetPixel(x, y).R
                    green = source.GetPixel(x, y).G
                    blue = source.GetPixel(x, y).B

                    source.SetPixel(x, y, Color.FromArgb(0, green, 0)) 'set pixel x dan y berdasarkan warna hijau pada gambar yang dibuka 
                Next
            Next

            PictureBox3.Image = source
            PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        End If


    End Sub

    Private Sub ChangedToBlue(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blue_rb.CheckedChanged
        If PictureBox2.Image Is Nothing Then
            MessageBox.Show("Please copy the image first!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim source As New Bitmap(PictureBox1.Image)
            Dim red, green, blue As Integer
            For y As Integer = 0 To source.Height - 1
                For x As Integer = 0 To source.Width - 1
                    red = source.GetPixel(x, y).R
                    green = source.GetPixel(x, y).G
                    blue = source.GetPixel(x, y).B

                    source.SetPixel(x, y, Color.FromArgb(50, 0, 0, blue)) 'set pixel x dan y berdasarkan warna biru pada gambar yang dibuka 
                Next
            Next

            PictureBox3.Image = source
            PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        End If

    End Sub

    Private Sub ChangedToCyan(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cyan_rb.CheckedChanged
        If PictureBox2.Image Is Nothing Then
            MessageBox.Show("Please copy the image first!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim source As New Bitmap(PictureBox1.Image)
            Dim red, green, blue As Integer
            For y As Integer = 0 To source.Height - 1
                For x As Integer = 0 To source.Width - 1
                    red = source.GetPixel(x, y).R
                    green = source.GetPixel(x, y).G
                    blue = source.GetPixel(x, y).B

                    source.SetPixel(x, y, Color.FromArgb(0, green, blue)) 'set pixel x dan y berdasarkan warna hijau dan biru pada gambar yang dibuka 
                Next
            Next

            PictureBox3.Image = source
            PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        End If

    End Sub

    Private Sub ChangedToMagenta(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles magenta_rb.CheckedChanged
        If PictureBox2.Image Is Nothing Then
            MessageBox.Show("Please copy the image first!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim source As New Bitmap(PictureBox1.Image)
            Dim red, green, blue As Integer
            For y As Integer = 0 To source.Height - 1
                For x As Integer = 0 To source.Width - 1
                    red = source.GetPixel(x, y).R
                    green = source.GetPixel(x, y).G
                    blue = source.GetPixel(x, y).B

                    source.SetPixel(x, y, Color.FromArgb(red, 0, blue)) 'set pixel x dan y berdasarkan warna merah dan biru pada gambar yang dibuka 
                Next
            Next

            PictureBox3.Image = source
            PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        End If

    End Sub

    Private Sub ChangedToYellow(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yellow_rb.CheckedChanged
        If PictureBox2.Image Is Nothing Then
            MessageBox.Show("Please copy the image first!", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim source As New Bitmap(PictureBox1.Image)
            Dim red, green, blue As Integer
            For y As Integer = 0 To source.Height - 1
                For x As Integer = 0 To source.Width - 1
                    red = source.GetPixel(x, y).R
                    green = source.GetPixel(x, y).G
                    blue = source.GetPixel(x, y).B

                    source.SetPixel(x, y, Color.FromArgb(red, green, 0)) 'set pixel x dan y berdasarkan warna merah dan hijau pada gambar yang dibuka 
                Next
            Next

            PictureBox3.Image = source
            PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        End If

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub ExitProgram(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset_btn.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
