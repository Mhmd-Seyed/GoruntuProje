using GoruntuProje.Filters_Dev4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoruntuProje
{
    public partial class Form1 : Form
    {
        // Fare ile çizim yapmak için gerekli değişkenler
        bool cizimYapiyorMu = false;
        Point baslangicNoktasi;
        Rectangle kesimDortgeni;
        public Form1()
        {
            InitializeComponent();
        }
        private Bitmap HistogramCiz(int[] histogram, int genislik, int yukseklik)
        {
            Bitmap bmp = new Bitmap(genislik, yukseklik);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                int max = histogram.Max();

                for (int i = 0; i < 256; i++)
                {
                    int h = (int)((histogram[i] / (double)max) * yukseklik);
                    int x = i * genislik / 256;

                    g.DrawLine(Pens.Black, x, yukseklik, x, yukseklik - h);
                }
            }

            return bmp;
        }

        private void HistogramGoster(bool goster)
        {
            pictureBoxHistOrijinal.Visible = goster;
            pictureBoxHistSonuc.Visible = goster;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void resimSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void unsharpFiltresiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistogramGoster(false);
            // İşlem yapılacak resmin varlığını kontrol et
            if (pictureBox1.Image != null)
            {
                // Unsharp filtresini çağır
                GoruntuProje.Filters.Leader.UnsharpFiltresi unsharpFiltresi = new GoruntuProje.Filters.Leader.UnsharpFiltresi();

                // Filtreyi uygula ve sonucu sağdaki kutuda (pictureBox2) göster
                pictureBox2.Image = unsharpFiltresi.ApplyFilter((Bitmap)pictureBox1.Image);
            }
            else
            {
                MessageBox.Show("Lütfen filtre uygulamadan önce bir resim seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Sağdaki kutuda (pictureBox2) kaydedilecek işlenmiş bir resim var mı diye kontrol et
            if (pictureBox2.Image != null)
            {
                // 2. Kaydetme penceresi (SaveFileDialog) için ayarlar
                saveFileDialog1.Filter = "JPEG Resmi|*.jpg|PNG Resmi|*.png|Bitmap Resmi|*.bmp";
                saveFileDialog1.Title = "İşlenmiş Resmi Kaydet";
                saveFileDialog1.FileName = "islenmis_resim"; // Varsayılan dosya adı

                // 3. Kullanıcı pencerede 'Kaydet' butonuna basarsa
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // 4. Resmi seçilen klasöre ve seçilen formatta kaydet
                    pictureBox2.Image.Save(saveFileDialog1.FileName);

                    // 5. Başarı mesajı göster
                    MessageBox.Show("Resim başarıyla kaydedildi!", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // 6. Eğer ortada işlenmiş bir resim yoksa uyarı ver
                MessageBox.Show("Kaydedilecek işlenmiş bir resim bulunamadı. Lütfen önce bir filtre uygulayın!", "Eksik İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void renkUzayıDönüşümleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void histogramGermeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap orijinal = new Bitmap(pictureBox1.Image);

                var filtre = new GoruntuProje.Filters_Dev3.HistogramGerme();
                HistogramGoster(true);

                Bitmap sonuc = filtre.ApplyFilter(orijinal);

                pictureBox2.Image = sonuc;

                // 🔥 Histogramları al (artık filtreden geliyor)
                int[] histOrijinal = filtre.HistogramHesapla(orijinal);
                int[] histSonuc = filtre.HistogramHesapla(sonuc);

                // 🔥 Çiz
                pictureBoxHistOrijinal.Image = HistogramCiz(histOrijinal,
                    pictureBoxHistOrijinal.Width,
                    pictureBoxHistOrijinal.Height);

                pictureBoxHistSonuc.Image = HistogramCiz(histSonuc,
                    pictureBoxHistSonuc.Width,
                    pictureBoxHistSonuc.Height);
            }
        }




        private void meanFiltresiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistogramGoster(false);
            if (pictureBox1.Image != null)
            {
                var filter = new GoruntuProje.Filters_Dev3.MeanFilter();
                pictureBox2.Image = filter.ApplyFilter(new Bitmap(pictureBox1.Image));
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resim seçin!");
            }
        }

        private void filtrelerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void grayeDönüşümToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistogramGoster(false);
            if (pictureBox1.Image != null)
            {
                var filter = new GoruntuProje.Filters_Dev3.RenkUzayiDonusum();
                pictureBox2.Image = filter.ApplyFilter(new Bitmap(pictureBox1.Image));
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resim seçin!");
            }
        }

        private void hSVyeDönüşümToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistogramGoster(false);
            if (pictureBox1.Image != null)
            {
                var filter = new GoruntuProje.Filters_Dev3.RenkUzayiDonusumHSV();
                pictureBox2.Image = filter.ApplyFilter(new Bitmap(pictureBox1.Image));
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resim seçin!");
            }
        }

        private void binaryDönüşümToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistogramGoster(false);
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Lütfen önce bir görüntü yükleyiniz.");
                return;
            }

            Bitmap girisResmi = new Bitmap(pictureBox1.Image);

            BinaryDonusum binaryDonusum = new BinaryDonusum();

            Bitmap cikisResmi = binaryDonusum.ApplyFilter(girisResmi);

            pictureBox2.Image = cikisResmi;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void eşiklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistogramGoster(false);
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Lütfen önce bir görüntü yükleyiniz.");
                return;
            }

            Bitmap girisResmi = new Bitmap(pictureBox1.Image);

            TekEsikleme tekEsikleme = new TekEsikleme();

            Bitmap cikisResmi = tekEsikleme.ApplyFilter(girisResmi);

            pictureBox2.Image = cikisResmi;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void eklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Lütfen önce birinci görüntüyü yükleyiniz.");
                return;
            }

            OpenFileDialog ikinciResimSec = new OpenFileDialog();
            ikinciResimSec.Title = "İkinci resmi seçiniz";
            ikinciResimSec.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";

            if (ikinciResimSec.ShowDialog() == DialogResult.OK)
            {
                Bitmap birinciResim = new Bitmap(pictureBox1.Image);
                Bitmap ikinciResim = new Bitmap(ikinciResimSec.FileName);

                EklemeIslemi eklemeIslemi = new EklemeIslemi();

                Bitmap cikisResmi = eklemeIslemi.ApplyFilter(birinciResim, ikinciResim);

                pictureBox2.Image = cikisResmi;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void bolmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Lütfen önce birinci görüntüyü yükleyiniz.");
                return;
            }

            OpenFileDialog ikinciResimSec = new OpenFileDialog();
            ikinciResimSec.Title = "İkinci resmi seçiniz";
            ikinciResimSec.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";

            if (ikinciResimSec.ShowDialog() == DialogResult.OK)
            {
                Bitmap birinciResim = new Bitmap(pictureBox1.Image);
                Bitmap ikinciResim = new Bitmap(ikinciResimSec.FileName);

                BolmeIslemi bolmeIslemi = new BolmeIslemi();

                Bitmap cikisResmi = bolmeIslemi.ApplyFilter(birinciResim, ikinciResim);

                pictureBox2.Image = cikisResmi;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void görüntüDöndürmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistogramGoster(false);
            if (pictureBox1.Image != null)
            {
                var filtre = new GoruntuProje.Filters_Dev2.GoruntuDondurme();
                pictureBox2.Image = filtre.ApplyFilter(new Bitmap(pictureBox1.Image));
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resim seçin!");
            }
        }

        private void görüntüUzaklaştırmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistogramGoster(false);
            if (pictureBox1.Image != null)
            {
                var filtre = new GoruntuProje.Filters_Dev2.GoruntuUzaklastirma();
                pictureBox2.Image = filtre.ApplyFilter(new Bitmap(pictureBox1.Image));
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resim seçin!");
            }
        }

        private void görüntüYaklaştırmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistogramGoster(false);
            if (pictureBox1.Image != null)
            {
                var filtre = new GoruntuProje.Filters_Dev2.GoruntuYaklastirma();
                pictureBox2.Image = filtre.ApplyFilter(new Bitmap(pictureBox1.Image));
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resim seçin!");
            }
        }

        private void medianFiltresiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistogramGoster(false);
            if (pictureBox1.Image != null)
            {
                var filtre = new GoruntuProje.Filters_Dev2.MedianFiltre();
                pictureBox2.Image = filtre.ApplyFilter(new Bitmap(pictureBox1.Image));
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resim seçin!");
            }
        }

        private void gürültüEkleSaltPepperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistogramGoster(false);
            if (pictureBox1.Image != null)
            {
                var filtre = new GoruntuProje.Filters_Dev2.GurultuEkleme();
                pictureBox2.Image = filtre.ApplyFilter(new Bitmap(pictureBox1.Image));
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resim seçin!");
            }
        }

        private void griDönüşümToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistogramGoster(false);
            if (pictureBox1.Image != null)
            {
                var filtre = new GoruntuProje.Filters_Dev1.GriDonusum();
                pictureBox2.Image = filtre.ApplyFilter(new Bitmap(pictureBox1.Image));
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resim seçin!");
            }
        }

        private void kontrastArtırmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistogramGoster(false);
            if (pictureBox1.Image != null)
            {
                var filtre = new GoruntuProje.Filters_Dev1.KontrastArtirma();
                pictureBox2.Image = filtre.ApplyFilter(new Bitmap(pictureBox1.Image));
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resim seçin!");
            }
        }

        private void kenarBulmaPrewittToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistogramGoster(false);
            if (pictureBox1.Image != null)
            {
                var filtre = new GoruntuProje.Filters_Dev1.KenarBulmaPrewitt();
                pictureBox2.Image = filtre.ApplyFilter(new Bitmap(pictureBox1.Image));
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resim seçin!");
            }
        }

        private void genişlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistogramGoster(false);
            // Öncelikle programa yüklenmiş bir görüntü olduğundan emin ol
            if (pictureBox1.Image != null)
            {
                // 1. Orijinal görüntünün bir kopyasını (Bitmap) al
                Bitmap kaynak = new Bitmap(pictureBox1.Image);

                // 2. Liderin klasöründen Genişleme (Dilation) filtresini çağır
                GoruntuProje.Filters_Leader.GenislemeFiltresi genisleme = new GoruntuProje.Filters_Leader.GenislemeFiltresi();

                // 3. Filtreyi uygula ve sonucu PictureBox2'de (İşlenmiş Görüntü) göster
                pictureBox2.Image = genisleme.ApplyFilter(kaynak);
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resim seçin!");
            }
        }

        private void aşınmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistogramGoster(false);
            if (pictureBox1.Image != null)
            {
                Bitmap kaynak = new Bitmap(pictureBox1.Image);
                GoruntuProje.Filters_Leader.AsinmaFiltresi asinma = new GoruntuProje.Filters_Leader.AsinmaFiltresi();
                pictureBox2.Image = asinma.ApplyFilter(kaynak);
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resim seçin!");
            }
        }

        private void açmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistogramGoster(false);
            if (pictureBox1.Image != null)
            {
                Bitmap kaynak = new Bitmap(pictureBox1.Image);
                GoruntuProje.Filters_Leader.AcmaFiltresi acma = new GoruntuProje.Filters_Leader.AcmaFiltresi();
                pictureBox2.Image = acma.ApplyFilter(kaynak);
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resim seçin!");
            }
        }

        private void kapamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistogramGoster(false);
            if (pictureBox1.Image != null)
            {
                Bitmap kaynak = new Bitmap(pictureBox1.Image);
                GoruntuProje.Filters_Leader.KapamaFiltresi kapama = new GoruntuProje.Filters_Leader.KapamaFiltresi();
                pictureBox2.Image = kapama.ApplyFilter(kaynak);
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resim seçin!");
            }
        }

        private void görüntüKırpmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Görüntü var mı ve fare ile bir alan seçilmiş mi kontrol et
            if (pictureBox1.Image != null && kesimDortgeni.Width > 0 && kesimDortgeni.Height > 0)
            {
                Bitmap kaynak = new Bitmap(pictureBox1.Image);

                GoruntuProje.Filters_Leader.KirpmaFiltresi kirpma = new GoruntuProje.Filters_Leader.KirpmaFiltresi();

                // Çizdiğimiz dikdörtgeni filtreye gönderiyoruz
                kirpma.SeciliAlan = kesimDortgeni;

                // Filtreyi uygula ve sonucu göster
                pictureBox2.Image = kirpma.ApplyFilter(kaynak);

                // İşlem bitince kırmızı çizgiyi temizle
                kesimDortgeni = new Rectangle();
                pictureBox1.Invalidate();
            }
            else
            {
                MessageBox.Show("Lütfen önce fare ile orijinal görüntü üzerinden kırpılacak alanı seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image != null && e.Button == MouseButtons.Left)
            {
                cizimYapiyorMu = true;
                baslangicNoktasi = e.Location;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (cizimYapiyorMu)
            {
                // Fare sürüklendikçe dikdörtgenin boyutlarını hesapla
                int x = Math.Min(baslangicNoktasi.X, e.X);
                int y = Math.Min(baslangicNoktasi.Y, e.Y);
                int width = Math.Abs(e.X - baslangicNoktasi.X);
                int height = Math.Abs(e.Y - baslangicNoktasi.Y);

                kesimDortgeni = new Rectangle(x, y, width, height);

                // --- Otomatik Bilgi Hesaplama Kısmı ---
                if (pictureBox1.Image != null)
                {
                    int imgW = pictureBox1.Image.Width;
                    int imgH = pictureBox1.Image.Height;

                    // Kenarlardan ne kadar kesiliyor? (Piksel bazında hesaplama)
                    int kesilenSol = x;
                    int kesilenUst = y;
                    int kesilenSag = imgW - (x + width);
                    int kesilenAlt = imgH - (y + height);

                    // Bilgileri ekrana yazdır (Türkçe formatta)
                    lblCropInfo.Text = $"--- Kesim Bilgileri ---\n" +
                                       $"Başlangıç: ({x}, {y})\n" +
                                       $"Boyut: {width}x{height} px\n" +
                                       $"-----------------------\n" +
                                       $"Soldan Kesilen: {kesilenSol} px\n" +
                                       $"Sağdan Kesilen: {kesilenSag} px\n" +
                                       $"Üstten Kesilen: {kesilenUst} px\n" +
                                       $"Alttan Kesilen: {kesilenAlt} px";
                }

                pictureBox1.Invalidate(); // Çizimi güncelle
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            cizimYapiyorMu = false;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (kesimDortgeni != null && kesimDortgeni.Width > 0 && kesimDortgeni.Height > 0)
            {
                // Kırmızı ve kesik çizgili bir kalem (Pen) oluştur
                Pen kalem = new Pen(Color.Red, 2);
                kalem.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

                // Dikdörtgeni çiz
                e.Graphics.DrawRectangle(kalem, kesimDortgeni);
            }
        }
    }

}
    

