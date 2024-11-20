using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;
namespace Buton_Sürükleyerek_Oluşturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point konum; 
        Point ilkkonum;
        private void buttonAdd_MouseDown(object sender, MouseEventArgs e)
        {
            konum = e.Location;
        }

        private void buttonAdd_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                buttonAdd.Left += e.X - (konum.X); //Burada aslında cursorın x deki yer değiştirmesini alıp ekliyo aynı şey y için de geçerli.
                buttonAdd.Top += e.Y - (konum.Y);
            }
        }
        int sayac = 1;
        private void buttonAdd_MouseUp(object sender, MouseEventArgs e)
        {
            if (buttonAdd.Left > 110)
            {
                Button a1 = new Button();
                a1.Text = "New Button " + sayac;
                a1.Name = "buttonNew";
                a1.Size = new Size(buttonAdd.Width, buttonAdd.Height);
                a1.Location = new Point(buttonAdd.Left, buttonAdd.Top);
                this.Controls.Add(a1);
                buttonAdd.Location = new Point(ilkkonum.X, ilkkonum.Y);
                sayac++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ilkkonum = new Point(buttonAdd.Left, buttonAdd.Top);
        }
    }
}
