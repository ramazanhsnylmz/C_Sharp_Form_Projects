using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listbox_Döndürme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            int sira = Convert.ToInt16(numericUpDown1.Value);
            if (sira > listBoxDeneme.Items.Count) 
            {
                sira = listBoxDeneme.Items.Count;
            }
             listBoxDeneme.Items.Insert(sira, textBoxEkle.Text);
        }

        private void buttonTümünüAktar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxDeneme.Items.Count; i++)
            {
                listBoxYan.Items.Add(listBoxDeneme.Items[i]);
            }
        }

        private void buttonTemizle_1_Click(object sender, EventArgs e)
        {
            listBoxDeneme.Items.Clear();
        }

        private void buttonTemizle_2_Click(object sender, EventArgs e)
        {
            listBoxYan.Items.Clear();
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            listBoxDeneme.SelectionMode = SelectionMode.One;
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            listBoxDeneme.SelectionMode = SelectionMode.MultiSimple;
        }

        private void buttonMultiS_Click(object sender, EventArgs e)
        {
            listBoxDeneme.SelectionMode = SelectionMode.MultiExtended;
        }

        private void buttonAktar_Click(object sender, EventArgs e)
        {
            listBoxYan.Items.Add(listBoxDeneme.SelectedItem);
        }

        private void buttonCokluAktar_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listBoxDeneme.SelectedIndices.Count; i++)
            {
                listBoxYan.Items.Add(listBoxDeneme.Items[listBoxDeneme.SelectedIndices[i]]);
            }
        }

        private void buttonSecilenKaldir_Click(object sender, EventArgs e)
        {
            listBoxDeneme.SelectedItems.Clear();
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            listBoxDeneme.SelectedIndex = -1;
            for (int i = 0; i < listBoxDeneme.Items.Count; i++) 
            {
                if (listBoxDeneme.Items[i].ToString() == textBoxAra.Text)
                {
                    listBoxDeneme.SelectedIndex = i;
                }
            }
            if(listBoxDeneme.SelectedIndex == -1)
            {
                MessageBox.Show("Bulunamadı.");
            }
        }
        
        private void buttonTekliAra_Click(object sender, EventArgs e)
        {
            listBoxDeneme.SelectedIndex = -1;
            for (int i = 0; i < listBoxDeneme.Items.Count; i++)
            {
                if (listBoxDeneme.Items[i].ToString() == textBoxAra.Text)
                {
                    listBoxDeneme.SelectedIndex = i;
                    i += listBoxDeneme.Items.Count + 8;
                }
            }
            if (listBoxDeneme.SelectedIndex == -1)
            {
                MessageBox.Show("Bulunamadı.");
            }
        }
        int sayac = 0;
        int ilkdeger = 0;
        int ilktur = 0;
        private void buttonSiradaki_Click(object sender, EventArgs e)
        {
            //!!!!!!
            int deger = listBoxDeneme.SelectedIndex;
            deger = listBoxDeneme.FindString(textBoxAra.Text, deger);
            listBoxDeneme.SelectedIndex = -1;
            listBoxDeneme.SelectedIndex = deger;
            if (sayac == 0)
            {
                ilkdeger = deger;
            }
            if (ilktur != 0 && ilkdeger == listBoxDeneme.SelectedIndex)
            {
                DialogResult = MessageBox.Show("Başa döndün tekrar turlamak istiyor musun?", "Uyarı", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(DialogResult == DialogResult.Yes)
                {
                    listBoxDeneme.SelectedIndex = -1;
                    int a = listBoxDeneme.SelectedIndex;
                    a = listBoxDeneme.FindString(textBoxAra.Text, a);
                    listBoxDeneme.SelectedIndex = -1;
                    listBoxDeneme.SelectedIndex = a;
                }
                if(DialogResult == DialogResult.No)
                {
                    MessageBox.Show("Turlama durduruldu.");
                    listBoxDeneme.SelectedIndex = -1;
                }
            }
            sayac++;
            ilktur++;
        }

        private void buttonSirala_1_Click(object sender, EventArgs e)
        {
            listBoxDeneme.Sorted = true;
        }

        private void buttonSirala_2_Click(object sender, EventArgs e)
        {
            listBoxYan.Sorted = true;
        }
    }
}
