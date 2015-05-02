using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            lbListe.Items.Clear();
            for (int i = 1; i <= 100; i++)
            {
                lbListe.Items.Add(i.ToString());
            }
        }

        private void btnTekSayilar_Click(object sender, EventArgs e)
        {
            lbListe.Items.Clear();
            for (int i = 1; i <= 100; i++)
            {
                //tek mi cift mi kontrolü yapılmalı
                if(i % 2 == 1)
                    lbListe.Items.Add(i.ToString());
            }
        }

        private void btnKompleks_Click(object sender, EventArgs e)
        {
            // 1 den 100 e kadar olan sayılardan 
            // 2 ye bölünenler 1. listeye
            lbListe.Items.Clear();
            for (int i = 1; i <= 100; i++)
            {
                // 2ye bölünenler
                if (i % 2 == 0)
                    lbListe.Items.Add(i.ToString());
            }
            // n kadar = 100

            // 3 e bölünenler 2. listeye
            lbListe2.Items.Clear();
            for (int i = 1; i <= 100; i++)
            {
                //3 e bölünenler
                if (i % 3 == 0)
                    lbListe2.Items.Add(i.ToString());
            }
            // n kadar

            // 2n

            // her ikisinede bölünenlerin sayısını mesaj kutusunda gösterelim
        }

        private void btnKompleks2_Click(object sender, EventArgs e)
        {
            // 1 den 100 e kadar olan sayılardan 
            
            // 2 ye bölünenler 1. listeye
            lbListe.Items.Clear();
            // 3 e bölünenler 2. listeye
            lbListe2.Items.Clear();

            // değişken tanımla
            int altiyaBolunenlerinSayisi = 0;

            for (int i = 1; i <= 100; i++)
            {
                // 2ye bölünenler
                if (i % 2 == 0)
                    lbListe.Items.Add(i.ToString());
                //3 e bölünenler
                if (i % 3 == 0)
                    lbListe2.Items.Add(i.ToString());

                // her ikisinede bölünenlerin sayısını 
                // mesaj kutusunda gösterelim

                // eğer hem 2ye hemde 3 e bölünüyorsa değişkeni arttır.
                if (i % 2 == 0 && i % 3 == 0)
                    altiyaBolunenlerinSayisi++;
                //altiyaBolunenlerinSayisi = altiyaBolunenlerinSayisi + 1;
            }
            // n kadar = 100

            // değişkeni mesajla göster
            MessageBox.Show(altiyaBolunenlerinSayisi.ToString());
        }
    }
}
