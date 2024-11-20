namespace Çılgın_Buton
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
            this.buttonSonic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSonic
            // 
            this.buttonSonic.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonSonic.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSonic.Image = ((System.Drawing.Image)(resources.GetObject("buttonSonic.Image")));
            this.buttonSonic.Location = new System.Drawing.Point(417, 186);
            this.buttonSonic.Name = "buttonSonic";
            this.buttonSonic.Size = new System.Drawing.Size(193, 138);
            this.buttonSonic.TabIndex = 0;
            this.buttonSonic.TabStop = false;
            this.buttonSonic.UseVisualStyleBackColor = false;
            this.buttonSonic.Click += new System.EventHandler(this.buttonSonic_Click);
            this.buttonSonic.MouseEnter += new System.EventHandler(this.buttonSonic_MouseEnter);
            this.buttonSonic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonSonic_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.buttonSonic);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sonic";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSonic;
    }
}

