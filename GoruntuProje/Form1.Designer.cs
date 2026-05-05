namespace GoruntuProje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resimSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noktasalİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griDönüşümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontrastArtırmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryDönüşümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eşiklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkUzayıDönüşümleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayeDönüşümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hSVyeDönüşümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramGermeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geometrikİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görüntüKırpmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görüntüDöndürmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görüntüYaklaştırmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görüntüUzaklaştırmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gürültüEkleSaltPepperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meanFiltresiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianFiltresiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unsharpFiltresiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kenarBulmaPrewittToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aritmetikİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bolmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.morfolojikİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genişlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aşınmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxHistOrijinal = new System.Windows.Forms.PictureBox();
            this.pictureBoxHistSonuc = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistOrijinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistSonuc)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.noktasalİşlemlerToolStripMenuItem,
            this.geometrikİşlemlerToolStripMenuItem,
            this.filtrelerToolStripMenuItem,
            this.morfolojikİşlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1106, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resimSeçToolStripMenuItem,
            this.kaydetToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // resimSeçToolStripMenuItem
            // 
            this.resimSeçToolStripMenuItem.Name = "resimSeçToolStripMenuItem";
            this.resimSeçToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.resimSeçToolStripMenuItem.Text = "Resim Seç";
            this.resimSeçToolStripMenuItem.Click += new System.EventHandler(this.resimSeçToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // noktasalİşlemlerToolStripMenuItem
            // 
            this.noktasalİşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.griDönüşümToolStripMenuItem,
            this.kontrastArtırmaToolStripMenuItem,
            this.binaryDönüşümToolStripMenuItem,
            this.eşiklemeToolStripMenuItem,
            this.renkUzayıDönüşümleriToolStripMenuItem,
            this.histogramGermeToolStripMenuItem});
            this.noktasalİşlemlerToolStripMenuItem.Name = "noktasalİşlemlerToolStripMenuItem";
            this.noktasalİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.noktasalİşlemlerToolStripMenuItem.Text = "Noktasal İşlemler";
            // 
            // griDönüşümToolStripMenuItem
            // 
            this.griDönüşümToolStripMenuItem.Name = "griDönüşümToolStripMenuItem";
            this.griDönüşümToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.griDönüşümToolStripMenuItem.Text = "Gri Dönüşüm";
            this.griDönüşümToolStripMenuItem.Click += new System.EventHandler(this.griDönüşümToolStripMenuItem_Click);
            // 
            // kontrastArtırmaToolStripMenuItem
            // 
            this.kontrastArtırmaToolStripMenuItem.Name = "kontrastArtırmaToolStripMenuItem";
            this.kontrastArtırmaToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.kontrastArtırmaToolStripMenuItem.Text = "Kontrast Artırma";
            this.kontrastArtırmaToolStripMenuItem.Click += new System.EventHandler(this.kontrastArtırmaToolStripMenuItem_Click);
            // 
            // binaryDönüşümToolStripMenuItem
            // 
            this.binaryDönüşümToolStripMenuItem.Name = "binaryDönüşümToolStripMenuItem";
            this.binaryDönüşümToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.binaryDönüşümToolStripMenuItem.Text = "Binary Dönüşüm";
            this.binaryDönüşümToolStripMenuItem.Click += new System.EventHandler(this.binaryDönüşümToolStripMenuItem_Click);
            // 
            // eşiklemeToolStripMenuItem
            // 
            this.eşiklemeToolStripMenuItem.Name = "eşiklemeToolStripMenuItem";
            this.eşiklemeToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.eşiklemeToolStripMenuItem.Text = "Eşikleme";
            this.eşiklemeToolStripMenuItem.Click += new System.EventHandler(this.eşiklemeToolStripMenuItem_Click);
            // 
            // renkUzayıDönüşümleriToolStripMenuItem
            // 
            this.renkUzayıDönüşümleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayeDönüşümToolStripMenuItem,
            this.hSVyeDönüşümToolStripMenuItem});
            this.renkUzayıDönüşümleriToolStripMenuItem.Name = "renkUzayıDönüşümleriToolStripMenuItem";
            this.renkUzayıDönüşümleriToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.renkUzayıDönüşümleriToolStripMenuItem.Text = "Renk Uzayı Dönüşümleri";
            this.renkUzayıDönüşümleriToolStripMenuItem.Click += new System.EventHandler(this.renkUzayıDönüşümleriToolStripMenuItem_Click);
            // 
            // grayeDönüşümToolStripMenuItem
            // 
            this.grayeDönüşümToolStripMenuItem.Name = "grayeDönüşümToolStripMenuItem";
            this.grayeDönüşümToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.grayeDönüşümToolStripMenuItem.Text = "Gray\'e dönüşüm";
            this.grayeDönüşümToolStripMenuItem.Click += new System.EventHandler(this.grayeDönüşümToolStripMenuItem_Click);
            // 
            // hSVyeDönüşümToolStripMenuItem
            // 
            this.hSVyeDönüşümToolStripMenuItem.Name = "hSVyeDönüşümToolStripMenuItem";
            this.hSVyeDönüşümToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.hSVyeDönüşümToolStripMenuItem.Text = "HSV\'ye dönüşüm";
            this.hSVyeDönüşümToolStripMenuItem.Click += new System.EventHandler(this.hSVyeDönüşümToolStripMenuItem_Click);
            // 
            // histogramGermeToolStripMenuItem
            // 
            this.histogramGermeToolStripMenuItem.Name = "histogramGermeToolStripMenuItem";
            this.histogramGermeToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.histogramGermeToolStripMenuItem.Text = "Histogram Germe";
            this.histogramGermeToolStripMenuItem.Click += new System.EventHandler(this.histogramGermeToolStripMenuItem_Click);
            // 
            // geometrikİşlemlerToolStripMenuItem
            // 
            this.geometrikİşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.görüntüKırpmaToolStripMenuItem,
            this.görüntüDöndürmeToolStripMenuItem,
            this.görüntüYaklaştırmaToolStripMenuItem,
            this.görüntüUzaklaştırmaToolStripMenuItem});
            this.geometrikİşlemlerToolStripMenuItem.Name = "geometrikİşlemlerToolStripMenuItem";
            this.geometrikİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.geometrikİşlemlerToolStripMenuItem.Text = "Geometrik İşlemler";
            // 
            // görüntüKırpmaToolStripMenuItem
            // 
            this.görüntüKırpmaToolStripMenuItem.Name = "görüntüKırpmaToolStripMenuItem";
            this.görüntüKırpmaToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.görüntüKırpmaToolStripMenuItem.Text = "Görüntü Kırpma";
            this.görüntüKırpmaToolStripMenuItem.Click += new System.EventHandler(this.görüntüKırpmaToolStripMenuItem_Click);
            // 
            // görüntüDöndürmeToolStripMenuItem
            // 
            this.görüntüDöndürmeToolStripMenuItem.Name = "görüntüDöndürmeToolStripMenuItem";
            this.görüntüDöndürmeToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.görüntüDöndürmeToolStripMenuItem.Text = "Görüntü Döndürme";
            this.görüntüDöndürmeToolStripMenuItem.Click += new System.EventHandler(this.görüntüDöndürmeToolStripMenuItem_Click);
            // 
            // görüntüYaklaştırmaToolStripMenuItem
            // 
            this.görüntüYaklaştırmaToolStripMenuItem.Name = "görüntüYaklaştırmaToolStripMenuItem";
            this.görüntüYaklaştırmaToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.görüntüYaklaştırmaToolStripMenuItem.Text = "Görüntü Yaklaştırma";
            this.görüntüYaklaştırmaToolStripMenuItem.Click += new System.EventHandler(this.görüntüYaklaştırmaToolStripMenuItem_Click);
            // 
            // görüntüUzaklaştırmaToolStripMenuItem
            // 
            this.görüntüUzaklaştırmaToolStripMenuItem.Name = "görüntüUzaklaştırmaToolStripMenuItem";
            this.görüntüUzaklaştırmaToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.görüntüUzaklaştırmaToolStripMenuItem.Text = "Görüntü Uzaklaştırma";
            this.görüntüUzaklaştırmaToolStripMenuItem.Click += new System.EventHandler(this.görüntüUzaklaştırmaToolStripMenuItem_Click);
            // 
            // filtrelerToolStripMenuItem
            // 
            this.filtrelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gürültüEkleSaltPepperToolStripMenuItem,
            this.meanFiltresiToolStripMenuItem,
            this.medianFiltresiToolStripMenuItem,
            this.unsharpFiltresiToolStripMenuItem,
            this.kenarBulmaPrewittToolStripMenuItem,
            this.aritmetikİşlemlerToolStripMenuItem});
            this.filtrelerToolStripMenuItem.Name = "filtrelerToolStripMenuItem";
            this.filtrelerToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.filtrelerToolStripMenuItem.Text = "Filtreler";
            this.filtrelerToolStripMenuItem.Click += new System.EventHandler(this.filtrelerToolStripMenuItem_Click);
            // 
            // gürültüEkleSaltPepperToolStripMenuItem
            // 
            this.gürültüEkleSaltPepperToolStripMenuItem.Name = "gürültüEkleSaltPepperToolStripMenuItem";
            this.gürültüEkleSaltPepperToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.gürültüEkleSaltPepperToolStripMenuItem.Text = "Gürültü Ekle (Salt&Pepper)";
            this.gürültüEkleSaltPepperToolStripMenuItem.Click += new System.EventHandler(this.gürültüEkleSaltPepperToolStripMenuItem_Click);
            // 
            // meanFiltresiToolStripMenuItem
            // 
            this.meanFiltresiToolStripMenuItem.Name = "meanFiltresiToolStripMenuItem";
            this.meanFiltresiToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.meanFiltresiToolStripMenuItem.Text = "Mean Filtresi";
            this.meanFiltresiToolStripMenuItem.Click += new System.EventHandler(this.meanFiltresiToolStripMenuItem_Click);
            // 
            // medianFiltresiToolStripMenuItem
            // 
            this.medianFiltresiToolStripMenuItem.Name = "medianFiltresiToolStripMenuItem";
            this.medianFiltresiToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.medianFiltresiToolStripMenuItem.Text = "Median Filtresi";
            this.medianFiltresiToolStripMenuItem.Click += new System.EventHandler(this.medianFiltresiToolStripMenuItem_Click);
            // 
            // unsharpFiltresiToolStripMenuItem
            // 
            this.unsharpFiltresiToolStripMenuItem.Name = "unsharpFiltresiToolStripMenuItem";
            this.unsharpFiltresiToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.unsharpFiltresiToolStripMenuItem.Text = "Unsharp Filtresi";
            this.unsharpFiltresiToolStripMenuItem.Click += new System.EventHandler(this.unsharpFiltresiToolStripMenuItem_Click);
            // 
            // kenarBulmaPrewittToolStripMenuItem
            // 
            this.kenarBulmaPrewittToolStripMenuItem.Name = "kenarBulmaPrewittToolStripMenuItem";
            this.kenarBulmaPrewittToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.kenarBulmaPrewittToolStripMenuItem.Text = "Kenar Bulma (Prewitt)";
            this.kenarBulmaPrewittToolStripMenuItem.Click += new System.EventHandler(this.kenarBulmaPrewittToolStripMenuItem_Click);
            // 
            // aritmetikİşlemlerToolStripMenuItem
            // 
            this.aritmetikİşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eklemeToolStripMenuItem,
            this.bolmeToolStripMenuItem});
            this.aritmetikİşlemlerToolStripMenuItem.Name = "aritmetikİşlemlerToolStripMenuItem";
            this.aritmetikİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.aritmetikİşlemlerToolStripMenuItem.Text = "Aritmetik İşlemler";
            // 
            // eklemeToolStripMenuItem
            // 
            this.eklemeToolStripMenuItem.Name = "eklemeToolStripMenuItem";
            this.eklemeToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.eklemeToolStripMenuItem.Text = "ekleme";
            this.eklemeToolStripMenuItem.Click += new System.EventHandler(this.eklemeToolStripMenuItem_Click);
            // 
            // bolmeToolStripMenuItem
            // 
            this.bolmeToolStripMenuItem.Name = "bolmeToolStripMenuItem";
            this.bolmeToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.bolmeToolStripMenuItem.Text = "bolme";
            this.bolmeToolStripMenuItem.Click += new System.EventHandler(this.bolmeToolStripMenuItem_Click);
            // 
            // morfolojikİşlemlerToolStripMenuItem
            // 
            this.morfolojikİşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genişlemeToolStripMenuItem,
            this.aşınmaToolStripMenuItem,
            this.açmaToolStripMenuItem,
            this.kapamaToolStripMenuItem});
            this.morfolojikİşlemlerToolStripMenuItem.Name = "morfolojikİşlemlerToolStripMenuItem";
            this.morfolojikİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.morfolojikİşlemlerToolStripMenuItem.Text = "Morfolojik İşlemler";
            // 
            // genişlemeToolStripMenuItem
            // 
            this.genişlemeToolStripMenuItem.Name = "genişlemeToolStripMenuItem";
            this.genişlemeToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.genişlemeToolStripMenuItem.Text = "Genişleme";
            this.genişlemeToolStripMenuItem.Click += new System.EventHandler(this.genişlemeToolStripMenuItem_Click);
            // 
            // aşınmaToolStripMenuItem
            // 
            this.aşınmaToolStripMenuItem.Name = "aşınmaToolStripMenuItem";
            this.aşınmaToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.aşınmaToolStripMenuItem.Text = "Aşınma";
            this.aşınmaToolStripMenuItem.Click += new System.EventHandler(this.aşınmaToolStripMenuItem_Click);
            // 
            // açmaToolStripMenuItem
            // 
            this.açmaToolStripMenuItem.Name = "açmaToolStripMenuItem";
            this.açmaToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.açmaToolStripMenuItem.Text = "Açma";
            this.açmaToolStripMenuItem.Click += new System.EventHandler(this.açmaToolStripMenuItem_Click);
            // 
            // kapamaToolStripMenuItem
            // 
            this.kapamaToolStripMenuItem.Name = "kapamaToolStripMenuItem";
            this.kapamaToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.kapamaToolStripMenuItem.Text = "Kapama";
            this.kapamaToolStripMenuItem.Click += new System.EventHandler(this.kapamaToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(39, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(457, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(566, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(457, 400);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(138, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Orjinal Görüntü";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(570, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(429, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Işlem Uygulanmış Görüntü";
            // 
            // pictureBoxHistOrijinal
            // 
            this.pictureBoxHistOrijinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxHistOrijinal.Location = new System.Drawing.Point(39, 517);
            this.pictureBoxHistOrijinal.Name = "pictureBoxHistOrijinal";
            this.pictureBoxHistOrijinal.Size = new System.Drawing.Size(457, 99);
            this.pictureBoxHistOrijinal.TabIndex = 4;
            this.pictureBoxHistOrijinal.TabStop = false;
            // 
            // pictureBoxHistSonuc
            // 
            this.pictureBoxHistSonuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxHistSonuc.Location = new System.Drawing.Point(566, 517);
            this.pictureBoxHistSonuc.Name = "pictureBoxHistSonuc";
            this.pictureBoxHistSonuc.Size = new System.Drawing.Size(457, 99);
            this.pictureBoxHistSonuc.TabIndex = 4;
            this.pictureBoxHistSonuc.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 628);
            this.Controls.Add(this.pictureBoxHistSonuc);
            this.Controls.Add(this.pictureBoxHistOrijinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistOrijinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistSonuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resimSeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noktasalİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griDönüşümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontrastArtırmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryDönüşümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eşiklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkUzayıDönüşümleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramGermeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geometrikİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görüntüKırpmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görüntüDöndürmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görüntüYaklaştırmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gürültüEkleSaltPepperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meanFiltresiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianFiltresiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unsharpFiltresiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kenarBulmaPrewittToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aritmetikİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem morfolojikİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genişlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aşınmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapamaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem grayeDönüşümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hSVyeDönüşümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bolmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görüntüUzaklaştırmaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxHistOrijinal;
        private System.Windows.Forms.PictureBox pictureBoxHistSonuc;
    }
}

