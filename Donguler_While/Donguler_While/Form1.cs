using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRastgeleSayiBul_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rastgeleSayi = rnd.Next(1, 101);
            lblRastgeleSayi.Text = rastgeleSayi.ToString();
        }

        private void tmrWhile_Tick(object sender, EventArgs e)
        {
            if (lblRastgeleSayi.Text == "")
                return;

            int deger = Convert.ToInt32(lblRastgeleSayi.Text);
            // eğer rastgele sayi 40 ile 60 arasındaysa
            int donguSayaci = 0;
            while (deger < 60 && deger > 40)
            {
                lblMessage.Text = "Rastgele deger 40 ile 60 arasında.";
                
                donguSayaci++;
                if (donguSayaci > 10)
                    break;
            }

            if (!(deger < 60 && deger > 40))
                lblMessage.Text = "";
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            lbListe.Items.Clear();
            int i = 1;
            do
            {
                lbListe.Items.Add(i.ToString());

                i++;
            } while (i <= 100);
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            lbListe.Items.Clear();
            for (int i = 1; i <= 100; i++)
            {
                lbListe.Items.Add(i.ToString());
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            lbListe.Items.Clear();

            int i = 1;
            while (i <= 100)
            {
                lbListe.Items.Add(i.ToString());

                i++;
            }
        }
    }
}
