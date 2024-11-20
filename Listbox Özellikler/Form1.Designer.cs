namespace Listbox_Döndürme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxDeneme = new System.Windows.Forms.ListBox();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.textBoxEkle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxYan = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAktar = new System.Windows.Forms.Button();
            this.buttonCokluAktar = new System.Windows.Forms.Button();
            this.buttonTümünüAktar = new System.Windows.Forms.Button();
            this.buttonTemizle_1 = new System.Windows.Forms.Button();
            this.buttonTemizle_2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonMulti = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonMultiS = new System.Windows.Forms.Button();
            this.buttonSecilenKaldir = new System.Windows.Forms.Button();
            this.buttonSirala_1 = new System.Windows.Forms.Button();
            this.buttonSirala_2 = new System.Windows.Forms.Button();
            this.buttonAra = new System.Windows.Forms.Button();
            this.textBoxAra = new System.Windows.Forms.TextBox();
            this.buttonSiradaki = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonTekliAra = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxDeneme
            // 
            this.listBoxDeneme.FormattingEnabled = true;
            this.listBoxDeneme.ItemHeight = 16;
            this.listBoxDeneme.Items.AddRange(new object[] {
            "den1",
            "den2",
            "den3",
            "den1",
            "den4",
            "den5",
            "den1",
            "den6",
            "den7",
            "den1",
            "den8",
            "den9",
            "den1"});
            this.listBoxDeneme.Location = new System.Drawing.Point(12, 38);
            this.listBoxDeneme.Name = "listBoxDeneme";
            this.listBoxDeneme.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxDeneme.Size = new System.Drawing.Size(239, 420);
            this.listBoxDeneme.TabIndex = 0;
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(257, 96);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(141, 23);
            this.buttonEkle.TabIndex = 1;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // textBoxEkle
            // 
            this.textBoxEkle.Location = new System.Drawing.Point(257, 40);
            this.textBoxEkle.Name = "textBoxEkle";
            this.textBoxEkle.Size = new System.Drawing.Size(227, 22);
            this.textBoxEkle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Eklenecek metni giriniz.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ekleneceği sırayı giriniz.\r\n";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(257, 68);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(227, 22);
            this.numericUpDown1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ana Liste";
            // 
            // listBoxYan
            // 
            this.listBoxYan.FormattingEnabled = true;
            this.listBoxYan.ItemHeight = 16;
            this.listBoxYan.Location = new System.Drawing.Point(930, 43);
            this.listBoxYan.Name = "listBoxYan";
            this.listBoxYan.Size = new System.Drawing.Size(239, 420);
            this.listBoxYan.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1076, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Yan Liste";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Seçileni aktarır. (Tekli Seçime Alın)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(425, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Seçilenleri aktarır. (Çoklu Seçim veya Sürükleyerek Çoklu Seçime Alın)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tümünü aktarır.";
            // 
            // buttonAktar
            // 
            this.buttonAktar.Location = new System.Drawing.Point(257, 125);
            this.buttonAktar.Name = "buttonAktar";
            this.buttonAktar.Size = new System.Drawing.Size(141, 23);
            this.buttonAktar.TabIndex = 9;
            this.buttonAktar.Text = "Aktar";
            this.buttonAktar.UseVisualStyleBackColor = true;
            this.buttonAktar.Click += new System.EventHandler(this.buttonAktar_Click);
            // 
            // buttonCokluAktar
            // 
            this.buttonCokluAktar.Location = new System.Drawing.Point(257, 150);
            this.buttonCokluAktar.Name = "buttonCokluAktar";
            this.buttonCokluAktar.Size = new System.Drawing.Size(141, 31);
            this.buttonCokluAktar.TabIndex = 10;
            this.buttonCokluAktar.Text = "Çoklu Aktar";
            this.buttonCokluAktar.UseVisualStyleBackColor = true;
            this.buttonCokluAktar.Click += new System.EventHandler(this.buttonCokluAktar_Click);
            // 
            // buttonTümünüAktar
            // 
            this.buttonTümünüAktar.Location = new System.Drawing.Point(258, 186);
            this.buttonTümünüAktar.Name = "buttonTümünüAktar";
            this.buttonTümünüAktar.Size = new System.Drawing.Size(141, 34);
            this.buttonTümünüAktar.TabIndex = 11;
            this.buttonTümünüAktar.Text = "Hepsini Aktar";
            this.buttonTümünüAktar.UseVisualStyleBackColor = true;
            this.buttonTümünüAktar.Click += new System.EventHandler(this.buttonTümünüAktar_Click);
            // 
            // buttonTemizle_1
            // 
            this.buttonTemizle_1.Location = new System.Drawing.Point(12, 465);
            this.buttonTemizle_1.Name = "buttonTemizle_1";
            this.buttonTemizle_1.Size = new System.Drawing.Size(239, 23);
            this.buttonTemizle_1.TabIndex = 12;
            this.buttonTemizle_1.Text = "Ana Listeyi Temizle";
            this.buttonTemizle_1.UseVisualStyleBackColor = true;
            this.buttonTemizle_1.Click += new System.EventHandler(this.buttonTemizle_1_Click);
            // 
            // buttonTemizle_2
            // 
            this.buttonTemizle_2.Location = new System.Drawing.Point(930, 464);
            this.buttonTemizle_2.Name = "buttonTemizle_2";
            this.buttonTemizle_2.Size = new System.Drawing.Size(239, 23);
            this.buttonTemizle_2.TabIndex = 13;
            this.buttonTemizle_2.Text = "Yan Listeyi Temizle";
            this.buttonTemizle_2.UseVisualStyleBackColor = true;
            this.buttonTemizle_2.Click += new System.EventHandler(this.buttonTemizle_2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.buttonMultiS);
            this.groupBox1.Controls.Add(this.buttonOne);
            this.groupBox1.Controls.Add(this.buttonMulti);
            this.groupBox1.Location = new System.Drawing.Point(257, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 128);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selection Mode";
            // 
            // buttonMulti
            // 
            this.buttonMulti.Location = new System.Drawing.Point(7, 50);
            this.buttonMulti.Name = "buttonMulti";
            this.buttonMulti.Size = new System.Drawing.Size(141, 23);
            this.buttonMulti.TabIndex = 0;
            this.buttonMulti.Text = "Çoklu Seçim";
            this.buttonMulti.UseVisualStyleBackColor = true;
            this.buttonMulti.Click += new System.EventHandler(this.buttonMulti_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.Location = new System.Drawing.Point(7, 21);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(141, 23);
            this.buttonOne.TabIndex = 1;
            this.buttonOne.Text = "Tekli Seçim";
            this.buttonOne.UseVisualStyleBackColor = true;
            this.buttonOne.Click += new System.EventHandler(this.buttonOne_Click);
            // 
            // buttonMultiS
            // 
            this.buttonMultiS.Location = new System.Drawing.Point(7, 78);
            this.buttonMultiS.Name = "buttonMultiS";
            this.buttonMultiS.Size = new System.Drawing.Size(141, 44);
            this.buttonMultiS.TabIndex = 2;
            this.buttonMultiS.Text = "Sürükleyerek Çoklu Seçim";
            this.buttonMultiS.UseVisualStyleBackColor = true;
            this.buttonMultiS.Click += new System.EventHandler(this.buttonMultiS_Click);
            // 
            // buttonSecilenKaldir
            // 
            this.buttonSecilenKaldir.Location = new System.Drawing.Point(265, 356);
            this.buttonSecilenKaldir.Name = "buttonSecilenKaldir";
            this.buttonSecilenKaldir.Size = new System.Drawing.Size(141, 23);
            this.buttonSecilenKaldir.TabIndex = 15;
            this.buttonSecilenKaldir.Text = "Seçilenleri Kaldır";
            this.buttonSecilenKaldir.UseVisualStyleBackColor = true;
            this.buttonSecilenKaldir.Click += new System.EventHandler(this.buttonSecilenKaldir_Click);
            // 
            // buttonSirala_1
            // 
            this.buttonSirala_1.Location = new System.Drawing.Point(12, 494);
            this.buttonSirala_1.Name = "buttonSirala_1";
            this.buttonSirala_1.Size = new System.Drawing.Size(239, 23);
            this.buttonSirala_1.TabIndex = 16;
            this.buttonSirala_1.Text = "Ana Listeyi Sırala";
            this.buttonSirala_1.UseVisualStyleBackColor = true;
            this.buttonSirala_1.Click += new System.EventHandler(this.buttonSirala_1_Click);
            // 
            // buttonSirala_2
            // 
            this.buttonSirala_2.Location = new System.Drawing.Point(930, 493);
            this.buttonSirala_2.Name = "buttonSirala_2";
            this.buttonSirala_2.Size = new System.Drawing.Size(239, 23);
            this.buttonSirala_2.TabIndex = 17;
            this.buttonSirala_2.Text = "Yan Listeyi Sırala";
            this.buttonSirala_2.UseVisualStyleBackColor = true;
            this.buttonSirala_2.Click += new System.EventHandler(this.buttonSirala_2_Click);
            // 
            // buttonAra
            // 
            this.buttonAra.Location = new System.Drawing.Point(265, 469);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(91, 47);
            this.buttonAra.TabIndex = 18;
            this.buttonAra.Text = "Tümünü Ara";
            this.buttonAra.UseVisualStyleBackColor = true;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // textBoxAra
            // 
            this.textBoxAra.Location = new System.Drawing.Point(265, 385);
            this.textBoxAra.Name = "textBoxAra";
            this.textBoxAra.Size = new System.Drawing.Size(191, 22);
            this.textBoxAra.TabIndex = 19;
            // 
            // buttonSiradaki
            // 
            this.buttonSiradaki.Location = new System.Drawing.Point(265, 440);
            this.buttonSiradaki.Name = "buttonSiradaki";
            this.buttonSiradaki.Size = new System.Drawing.Size(91, 23);
            this.buttonSiradaki.TabIndex = 20;
            this.buttonSiradaki.Text = "Sıradaki";
            this.buttonSiradaki.UseVisualStyleBackColor = true;
            this.buttonSiradaki.Click += new System.EventHandler(this.buttonSiradaki_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(462, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Aramak istedğinizi buraya giriniz.";
            // 
            // buttonTekliAra
            // 
            this.buttonTekliAra.Location = new System.Drawing.Point(264, 413);
            this.buttonTekliAra.Name = "buttonTekliAra";
            this.buttonTekliAra.Size = new System.Drawing.Size(91, 23);
            this.buttonTekliAra.TabIndex = 21;
            this.buttonTekliAra.Text = "Tekli Ara";
            this.buttonTekliAra.UseVisualStyleBackColor = true;
            this.buttonTekliAra.Click += new System.EventHandler(this.buttonTekliAra_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(361, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(270, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Sadece bir tane en küçük insili olanı gösterir.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(362, 484);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(443, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Hepsini bulur ve gösterir. (Düzgün çalışması için çoklu seçim moduna alın)\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(361, 443);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Baştan sona sırayla gösterir.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1181, 528);
            this.Controls.Add(this.buttonTekliAra);
            this.Controls.Add(this.buttonSiradaki);
            this.Controls.Add(this.textBoxAra);
            this.Controls.Add(this.buttonAra);
            this.Controls.Add(this.buttonSirala_2);
            this.Controls.Add(this.buttonSirala_1);
            this.Controls.Add(this.buttonSecilenKaldir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonTemizle_2);
            this.Controls.Add(this.buttonTemizle_1);
            this.Controls.Add(this.buttonTümünüAktar);
            this.Controls.Add(this.buttonCokluAktar);
            this.Controls.Add(this.buttonAktar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxYan);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEkle);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.listBoxDeneme);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hepsini bulur ve gösterir.";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDeneme;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.TextBox textBoxEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxYan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAktar;
        private System.Windows.Forms.Button buttonCokluAktar;
        private System.Windows.Forms.Button buttonTümünüAktar;
        private System.Windows.Forms.Button buttonTemizle_1;
        private System.Windows.Forms.Button buttonTemizle_2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonMulti;
        private System.Windows.Forms.Button buttonMultiS;
        private System.Windows.Forms.Button buttonSecilenKaldir;
        private System.Windows.Forms.Button buttonSirala_1;
        private System.Windows.Forms.Button buttonSirala_2;
        private System.Windows.Forms.Button buttonAra;
        private System.Windows.Forms.TextBox textBoxAra;
        private System.Windows.Forms.Button buttonSiradaki;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonTekliAra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

