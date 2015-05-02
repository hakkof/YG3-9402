using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrayler_SayisalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCekilisYap_Click(object sender, EventArgs e)
        {
            lblDeger1.Text = RasgeleSayiGetir();
            lblDeger2.Text = RasgeleSayiGetir();
            lblDeger3.Text = RasgeleSayiGetir();
            lblDeger4.Text = RasgeleSayiGetir();
            lblDeger5.Text = RasgeleSayiGetir();
            lblDeger6.Text = RasgeleSayiGetir();
        }

        private string RasgeleSayiGetir()
        {
            Random rnd = new Random();
            int sayi = rnd.Next(1, 49);

            return sayi.ToString();
        }
    }
}
