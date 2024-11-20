using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Santranc_Tahtası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonOlustur_Click(object sender, EventArgs e)
        {
            int x = 200;
            int y = 10;
            int b = 0;
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    b++;
                    Button a1 = new Button();
                    a1.Text = b.ToString();
                    a1.Location = new Point(x, y);
                    a1.Size = new Size(30, 30);
                    if (i % 2 == 1)
                    {
                        if (j % 2 == 1)
                        {
                            a1.BackColor = Color.White;
                        }
                        if (j % 2 == 0)
                        {
                            a1.BackColor = Color.Black;
                            a1.ForeColor = Color.White;
                        }
                    }
                    if ((i % 2) == 0)
                    {
                        if (j % 2 == 0)
                        {
                            a1.BackColor = Color.White;
                        }
                        if (j % 2 == 1)
                        {
                            a1.BackColor = Color.Black;
                            a1.ForeColor = Color.White;
                        }
                    }
                    x += 30;
                    this.Controls.Add(a1);
                }
                y += 30;
                x = 200;
            }
        }
    }
}
