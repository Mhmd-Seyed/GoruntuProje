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
        public Form1()
        {
            InitializeComponent();
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
                var filter = new GoruntuProje.Filters_Dev3.HistogramGerme();
                pictureBox2.Image = filter.ApplyFilter(new Bitmap(pictureBox1.Image));
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resim seçin!");
            }
        }




        private void meanFiltresiToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("Lütfen önce bir görüntü yükleyiniz.");
                return;
            }

            Bitmap girisResmi = new Bitmap(pictureBox1.Image);

            EklemeIslemi eklemeIslemi = new EklemeIslemi();

            Bitmap cikisResmi = eklemeIslemi.ApplyFilter(girisResmi);

            pictureBox2.Image = cikisResmi;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void bolmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Lütfen önce bir görüntü yükleyiniz.");
                return;
            }

            Bitmap girisResmi = new Bitmap(pictureBox1.Image);

            BolmeIslemi bolmeIslemi = new BolmeIslemi();

            Bitmap cikisResmi = bolmeIslemi.ApplyFilter(girisResmi);

            pictureBox2.Image = cikisResmi;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void görüntüDöndürmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
    }

}
    

