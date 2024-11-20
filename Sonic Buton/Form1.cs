using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çılgın_Buton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSonic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Butona Tıkladın","Bildirim",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void buttonSonic_Move(object sender, EventArgs e)
        {

        }

        private void buttonSonic_MouseMove(object sender, MouseEventArgs e)
        {
            /*Random rnd = new Random();
            int yenix = rnd.Next(0,this.ClientSize.Width - buttonSonic.Width);
            int yeniy = rnd.Next(0,this.ClientSize.Height - buttonSonic.Height);
            buttonSonic.Location = new Point(yenix, yeniy);*/
        }

        private void buttonSonic_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int yenix = rnd.Next(0, this.ClientSize.Width - buttonSonic.Width);
            int yeniy = rnd.Next(0, this.ClientSize.Height - buttonSonic.Height);
            buttonSonic.Location = new Point(yenix, yeniy);
        }
    }
}
