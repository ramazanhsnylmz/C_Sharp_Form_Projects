using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tab_Order_Ayarlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            switch (comboBox1.SelectedIndex)
            {
                case 0: labelSonuc.Text = " " + (a + b).ToString(); break;
                case 1: labelSonuc.Text = " " + (a - b).ToString(); break;
                case 2: labelSonuc.Text = " " + (a * b).ToString(); break;
                case 3: labelSonuc.Text = " " + (a / b).ToString(); break;
            }
        }

        private void buttonAktar_Click(object sender, EventArgs e)
        {
            if (listBoxTabOrder.FindString(listBoxKomponentler.SelectedItem.ToString()) == -1)
            {
                listBoxTabOrder.Items.Add(listBoxKomponentler.SelectedItem);
            }
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            listBoxTabOrder.Items.Clear();
        }

        private void buttonTabAyarla_Click(object sender, EventArgs e)
        {
            if (listBoxKomponentler.Items.Count == listBoxTabOrder.Items.Count) 
            {
                textBox1.TabIndex = listBoxTabOrder.FindString("1.Sayı textBox");
                textBox2.TabIndex = listBoxTabOrder.FindString("2.Sayı textBox");
                comboBox1.TabIndex = listBoxTabOrder.FindString("İşlem comboBox");
                listBoxKomponentler.TabIndex = listBoxTabOrder.FindString("Komponentler listBox");
                listBoxTabOrder.TabIndex = listBoxTabOrder.FindString("Tab Sırası listBox");
                buttonAktar.TabIndex = listBoxTabOrder.FindString("Aktar button");
                buttonTemizle.TabIndex = listBoxTabOrder.FindString("Temizle button");
                buttonTabAyarla.TabIndex = listBoxTabOrder.FindString("Tab Ayarla button");
            }
            else
            {
                MessageBox.Show("Lütfen tüm komponenetleri tab order listesine aktarınız.");
            }
        }
    }
}
