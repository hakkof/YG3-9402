using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler_Faktoriyel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFaktoriyelHesapla_Click(object sender, EventArgs e)
        {
            if (txtDeger.Text == "")
            {
                MessageBox.Show("Lütfen bir değer girniz...");
            }
            else
            {
                int girilenDeger = Convert.ToInt32(txtDeger.Text);
                int sonuc = 1;
                for (int i = 1; i <= girilenDeger; i++)
                {
                    //sonuc *= i;
                    sonuc = sonuc * i;
                    // 1 = 1 * 1 => 1
                    // 1 = 1 * 2 => 2
                    // 2 = 2 * 3 => 6
                }

                MessageBox.Show(sonuc.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sonuc = 1;
            int girilenDeger = Convert.ToInt32(txtDeger.Text);
            int i = 1;
            while (true)
            {
                sonuc = sonuc * i;
                i++;

                if (i > girilenDeger)
                    break;
            }
            MessageBox.Show(sonuc.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sonuc = 1;
            int girilenDeger = Convert.ToInt32(txtDeger.Text);
            int i = 1;
            do
            {
                sonuc = sonuc * i;
                i++;
                
            } while (i <= girilenDeger);

            MessageBox.Show(sonuc.ToString());
        }
    }
}
