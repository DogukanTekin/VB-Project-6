Public Class Form1
    Dim red, green, blue, x, y, picturesayac, px, py, px1, py1 As Integer
    Dim veri1 As New ListViewItem
    Sub view1ekle()
        Dim veri As New ListViewItem()
        veri = New ListViewItem(InputBox("Ad Giriniz"))
        veri.SubItems.Add(InputBox("Soyad Giriniz"))
        veri.SubItems.Add(InputBox("Okul No Giriniz"))
        veri.SubItems.Add(InputBox("Adres Giriniz"))
        ListView1.Items.Add(veri)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaskedTextBox2.Mask = "LLL0000"
        MaskedTextBox1.Mask = "(000) 000 00 00"

        PictureBox2.Width = 150
        PictureBox2.Height = 150
        PictureBox2.Image = Image.FromFile(Application.StartupPath + "\IMG_2858.JPG")
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage

        PictureBox3.Width = 150
        PictureBox3.Height = 150
        PictureBox3.Image = Image.FromFile(Application.StartupPath + "\siyah.jpg")
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage

        PictureBox4.Width = 150
        PictureBox4.Height = 150
        PictureBox4.Image = Image.FromFile(Application.StartupPath + "\siyah.jpg")
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage

        ListView3.GridLines = True
        ListView3.FullRowSelect = True
        ListView3.View = View.Details
        ListView3.Columns.Add("Sayı 1", 50)
        ListView3.Columns.Add("Sayı 2", 50)
        ListView3.Columns.Add("Sayı 3", 50)
        VScrollBar4.Minimum = 600
        VScrollBar4.Maximum = 950
        VScrollBar4.SmallChange = 3
        VScrollBar4.LargeChange = 3
        VScrollBar5.Minimum = 250
        VScrollBar5.Maximum = 500
        VScrollBar5.SmallChange = 3
        VScrollBar5.LargeChange = 3
        x = 600
        y = 250
        red = 0
        green = 0
        blue = 0
        VScrollBar1.Minimum = 0
        VScrollBar2.Minimum = 0
        VScrollBar3.Minimum = 0
        VScrollBar1.Maximum = 255
        VScrollBar2.Maximum = 255
        VScrollBar3.Maximum = 255
        VScrollBar1.SmallChange = 1
        VScrollBar2.SmallChange = 1
        VScrollBar3.SmallChange = 1
        VScrollBar1.LargeChange = 1
        VScrollBar2.LargeChange = 1
        VScrollBar3.LargeChange = 1
        ListView1.View = View.Details 'Kolonların görünmesi için yazılması zorunludur
        ListView1.FullRowSelect = True 'Tek tıkla tüm satırı seçer
        ListView1.GridLines = True 'Altı Çizgili Yapar
        ListView1.Sorting = SortOrder.Ascending 'Verileri Alfabetik sırayla listview'de görüntüler
        ListView1.AllowColumnReorder = True ' Program çalıştığı zaman kolonların yerini değiştirmeye izin verir
        ListView2.View = View.Details
        ListView2.FullRowSelect = True
        ListView2.GridLines = True
        ListView1.Columns.Add("Ad", 100)
        ListView1.Columns.Add("Soyad", 100)
        ListView1.Columns.Add("Okul No", 100)
        ListView1.Columns.Add("Adres", 100)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        view1ekle()
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        TextBox1.Text = VScrollBar1.Value.ToString()
        red = VScrollBar1.Value
        PictureBox1.BackColor = Color.FromArgb(red, green, blue)
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        ListView3.Items.Clear()
        Label15.Text = HScrollBar1.Value.ToString()
        veri1 = New ListViewItem(Label15.Text)
        veri1.SubItems.Add(Label16.Text)
        veri1.SubItems.Add(Label17.Text)
        ListView3.Items.Add(veri1)
    End Sub

    Private Sub HScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar2.Scroll
        ListView3.Items.Clear()
        Label16.Text = HScrollBar2.Value.ToString()
        veri1 = New ListViewItem(Label15.Text)
        veri1.SubItems.Add(Label16.Text)
        veri1.SubItems.Add(Label17.Text)
        ListView3.Items.Add(veri1)
    End Sub

    Private Sub HScrollBar3_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar3.Scroll
        ListView3.Items.Clear()
        Label17.Text = HScrollBar3.Value.ToString()
        veri1 = New ListViewItem(Label15.Text)
        veri1.SubItems.Add(Label16.Text)
        veri1.SubItems.Add(Label17.Text)
        ListView3.Items.Add(veri1)
    End Sub

    Private Sub VScrollBar4_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar4.Scroll
        x = VScrollBar4.Value
        ListView3.Location = New Point(x, y)
    End Sub

    Private Sub VScrollBar5_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar5.Scroll
        y = VScrollBar5.Value
        ListView3.Location = New Point(x, y)
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If (Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_Leave(sender As Object, e As EventArgs) Handles TextBox4.Leave
        Dim para As Integer = CInt(TextBox4.Text)
        MsgBox(para.ToString("N4"))
        MsgBox(para.ToString("C3"))
    End Sub

    Private Sub PictureBox3_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseMove
        PictureBox3.CreateGraphics.DrawLine(Pens.Yellow, e.X, e.Y, e.X + 1, e.Y + 1)
    End Sub

    Private Sub PictureBox4_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseClick
        picturesayac += 1
        If picturesayac = 1 Then
            px = e.X
            py = e.Y
        Else
            px1 = e.X
            py1 = e.Y
            PictureBox4.CreateGraphics.DrawLine(Pens.Red, px, py, px1, py1)
            px = px1
            py = py1
        End If
    End Sub

    Private Sub VScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar2.Scroll
        TextBox2.Text = VScrollBar2.Value.ToString()
        green = VScrollBar2.Value
        PictureBox1.BackColor = Color.FromArgb(red, green, blue)
    End Sub

    Private Sub VScrollBar3_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar3.Scroll
        TextBox3.Text = VScrollBar3.Value.ToString()
        blue = VScrollBar3.Value
        PictureBox1.BackColor = Color.FromArgb(red, green, blue)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim kolon_sayisi As Integer = CInt(InputBox("Kaç Adet Kolon Girilecek"))
        For i = 0 To kolon_sayisi - 1
            ListView2.Columns.Add(InputBox((i + 1).ToString() + ". Kolonun Adı"), CInt(InputBox((i + 1).ToString() + ". Kolonun Genişliği")))
        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim veri As New ListViewItem
        veri = New ListViewItem(InputBox(ListView2.Columns(0).Text + " Kolonu Giriniz"))
        For i = 1 To ListView2.Columns.Count - 1
            veri.SubItems.Add(InputBox(ListView2.Columns(i).Text + " Kolonu Giriniz"))
        Next
        ListView2.Items.Add(veri)
    End Sub
End Class
