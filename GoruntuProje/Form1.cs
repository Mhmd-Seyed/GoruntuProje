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

        private void griDönüşümToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                var filter = new GoruntuProje.Filters_Dev1.GriDonusum();
                pictureBox2.Image = filter.ApplyFilter(new Bitmap(pictureBox1.Image));
            }
            else
            {
                MessageBox.Show("Lütfen önce bir resim seçin!");
            }
        }

        private void kontrastArtırmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var filter = new GoruntuProje.Filters_Dev1.KontrastArtirma();
            pictureBox2.Image = filter.ApplyFilter(new Bitmap(pictureBox1.Image));
        }

        private void kenarBulmaPrewittToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var filter = new GoruntuProje.Filters_Dev1.KenarBulmaPrewitt();
            pictureBox2.Image = filter.ApplyFilter(new Bitmap(pictureBox1.Image));
        }
    }

}
    

