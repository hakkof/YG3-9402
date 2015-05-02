using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrayler_ComboBoxDoldurma
{
    public partial class Form1 : Form
    {
        #region Local Değişkenler

        List<string> liste = new List<string>();
        string[] degiskenListesi = new string[0];

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string deger = txtDeger.Text;

            if (!liste.Contains(deger))
                liste.Add(deger);

            if (!ListedeVarmi(deger))
            {
                Array.Resize(ref degiskenListesi, degiskenListesi.Length + 1);
                degiskenListesi[degiskenListesi.Length - 1] = deger;
            }

            //ListedeYoksaEkle(deger);
        }



        private bool ListedeVarmi(string deger)
        {
            bool varmi = false;
            for (int i = 0; i < degiskenListesi.Length; i++)
            {
                string item = degiskenListesi[i];
                if (item == deger)
                {
                    varmi = true;
                    break;
                }
            }

            return varmi;
        }

        private bool ListedeVarmi2(string deger)
        {
            for (int i = 0; i < degiskenListesi.Length; i++)
            {
                string item = degiskenListesi[i];
                if (item == deger)
                {
                    return true;
                }
            }

            return false;
        }

        private void ListedeYoksaEkle(string deger)
        {
            bool varmi = false;
            for (int i = 0; i < degiskenListesi.Length; i++)
            {
                string item = degiskenListesi[i];
                if (item == deger)
                {
                    varmi = true;
                    break;
                }
            }

            if(!varmi)
            {
                Array.Resize(ref degiskenListesi, degiskenListesi.Length + 1);
                degiskenListesi[degiskenListesi.Length - 1] = deger;
            }
        }

        private void btnDoldur_Click(object sender, EventArgs e)
        {
            cbListe.Items.Clear();
            foreach (string item in liste)
            {
                cbListe.Items.Add(item);
            }
        }
    }
}
