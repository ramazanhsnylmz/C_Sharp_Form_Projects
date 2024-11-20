using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TC_Kimlik_Kontrolü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKontrol_Click(object sender, EventArgs e)
        {
            //Parametreler
            //1.11 rakam olacak +
            //2.her zaman çift rakam ile bitecek +
            //3.ilk 10 rakamının toplamının birler basamağı 11. rakama eşittir. +
            //4.ilk rakamı asla 0 olmaz. +
          double ID = Convert.ToDouble(textBoxID.Text);
          double r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11;
            bool c2 = false, c3 = false, c4 = false;
            long k;
            r1 = ID % 10;
            k = (long)ID / 10;
            r2 = k % 10;
            k = (long)ID / 100;
            r3 = k % 10;
            k = (long)ID / 1000;
            r4 = k % 10;
            k = (long)ID / 10000;
            r5 = k % 10;
            k = (long)ID / 100000;
            r6 = k % 10;
            k = (long)ID / 1000000;
            r7 = k % 10;
            k = (long)ID / 10000000;
            r8 = k % 10;
            k = (long)ID / 100000000;
            r9 = k % 10;
            k = (long)ID / 1000000000;
            r10 = k % 10;
            k = (long)ID / 10000000000;
            r11 = k % 10;
            double toplam;
            toplam = r2+r3+r4+r5+r6+r7+r8+r9+r10+r11;
            if(r1 % 2 == 0)
            {
                c2 = true;
            }
            if (toplam % 10 == r1)
            {
                c3 = true; 
            } 
            if (r11 != 0)
            {
                c4 = true;
            }
            if (c2 == true && c3 == true && c4 == true)
            {
                labelSonuc.Text =("Geçerli bir TC kimliktir.");
            }
            else
            {
                labelSonuc.Text =("Geçersiz bir TC kimliktir.");
            }
        }
    }
}
