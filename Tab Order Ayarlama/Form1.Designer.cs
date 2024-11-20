namespace Tab_Order_Ayarlama
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelSonuc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxKomponentler = new System.Windows.Forms.ListBox();
            this.listBoxTabOrder = new System.Windows.Forms.ListBox();
            this.buttonAktar = new System.Windows.Forms.Button();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.buttonTabAyarla = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(385, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(385, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 22);
            this.textBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Toplama",
            "Çıkarma",
            "Çarpma",
            "Bölme"});
            this.comboBox1.Location = new System.Drawing.Point(385, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelSonuc
            // 
            this.labelSonuc.AutoSize = true;
            this.labelSonuc.Location = new System.Drawing.Point(439, 135);
            this.labelSonuc.Name = "labelSonuc";
            this.labelSonuc.Size = new System.Drawing.Size(16, 16);
            this.labelSonuc.TabIndex = 3;
            this.labelSonuc.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "2.Sayı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "İşlem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "1.Sayı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sonuç :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tab Order";
            // 
            // listBoxKomponentler
            // 
            this.listBoxKomponentler.FormattingEnabled = true;
            this.listBoxKomponentler.ItemHeight = 16;
            this.listBoxKomponentler.Items.AddRange(new object[] {
            "1.Sayı textBox",
            "2.Sayı textBox",
            "İşlem comboBox",
            "Komponentler listBox",
            "Tab Sırası listBox",
            "Aktar button",
            "Temizle button",
            "Tab Ayarla button"});
            this.listBoxKomponentler.Location = new System.Drawing.Point(15, 55);
            this.listBoxKomponentler.Name = "listBoxKomponentler";
            this.listBoxKomponentler.Size = new System.Drawing.Size(167, 276);
            this.listBoxKomponentler.TabIndex = 5;
            // 
            // listBoxTabOrder
            // 
            this.listBoxTabOrder.FormattingEnabled = true;
            this.listBoxTabOrder.ItemHeight = 16;
            this.listBoxTabOrder.Location = new System.Drawing.Point(188, 55);
            this.listBoxTabOrder.Name = "listBoxTabOrder";
            this.listBoxTabOrder.Size = new System.Drawing.Size(158, 276);
            this.listBoxTabOrder.TabIndex = 6;
            // 
            // buttonAktar
            // 
            this.buttonAktar.Location = new System.Drawing.Point(12, 337);
            this.buttonAktar.Name = "buttonAktar";
            this.buttonAktar.Size = new System.Drawing.Size(87, 28);
            this.buttonAktar.TabIndex = 7;
            this.buttonAktar.Text = "Aktar";
            this.buttonAktar.UseVisualStyleBackColor = true;
            this.buttonAktar.Click += new System.EventHandler(this.buttonAktar_Click);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Location = new System.Drawing.Point(167, 337);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(87, 28);
            this.buttonTemizle.TabIndex = 8;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // buttonTabAyarla
            // 
            this.buttonTabAyarla.Location = new System.Drawing.Point(55, 371);
            this.buttonTabAyarla.Name = "buttonTabAyarla";
            this.buttonTabAyarla.Size = new System.Drawing.Size(149, 28);
            this.buttonTabAyarla.TabIndex = 9;
            this.buttonTabAyarla.Text = "Tab Sırasını Ayarla";
            this.buttonTabAyarla.UseVisualStyleBackColor = true;
            this.buttonTabAyarla.Click += new System.EventHandler(this.buttonTabAyarla_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(641, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Not: Tab tuşuna bastığınızda hangi sırayla seçilmesini istiyorsanız ona göre sağ " +
    "taraftaki listboxTabOrder\'a \r\nistediğiniz sıraya göre aktarın ardından tab order" +
    " ayarla butonuna basarak ayarlayın.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tüm Komponentler";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tab Sırası";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(404, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(653, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonTabAyarla);
            this.Controls.Add(this.buttonTemizle);
            this.Controls.Add(this.buttonAktar);
            this.Controls.Add(this.listBoxTabOrder);
            this.Controls.Add(this.listBoxKomponentler);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSonuc);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelSonuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxKomponentler;
        private System.Windows.Forms.ListBox listBoxTabOrder;
        private System.Windows.Forms.Button buttonAktar;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Button buttonTabAyarla;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

