using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrayler_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Degişken Diziler

            int? degiskenIsmi;
            int[] arrayDegiskeni; // declare - tanımla
            int[] arrayDegiskeni2 = new int[3]; // 3 elamanlı dizi
            arrayDegiskeni2[0] = 12;
            arrayDegiskeni2[1] = 25;
            arrayDegiskeni2[2] = 13;

            int[] arrayDegiskeni3 = { 12, 25, 13 };
            int[] arrayDegiskeni4 = new int[3] { 12, 25, 13 };

            int[] aylar = new int[12];
            for (int i = 0; i < aylar.Length; i++)
                aylar[i] = i + 1;

            for (int i = 0; i < aylar.Length; i++)
            {
                int ay = aylar[i];
                //MessageBox.Show(ay.ToString());
            }

            foreach (int ay in aylar)
            {
                //MessageBox.Show(ay.ToString());
            }

            int[,] array2boyutluDegisken = new int[3, 4];
            array2boyutluDegisken[0, 0] = 5;
            array2boyutluDegisken[0, 1] = 4;
            array2boyutluDegisken[0, 2] = 4;
            array2boyutluDegisken[0, 3] = 4;

            array2boyutluDegisken[1, 0] = 5;
            array2boyutluDegisken[1, 1] = 4;
            array2boyutluDegisken[1, 2] = 4;
            array2boyutluDegisken[1, 3] = 4;

            Random rnd = new Random();
            for (int i = 0; i < array2boyutluDegisken.GetLength(0); i++)
            {
                for (int j = 0; j < array2boyutluDegisken.GetLength(1); j++)
                {
                    array2boyutluDegisken[i, j] = rnd.Next(1, 101);
                    lbListe.Items.Add(array2boyutluDegisken[i, j]);
                }
            }

            int[,] array2boyutluDegisken2 = { { 0, 5 }, { 5, 89 }, { 12, 86 } };
            int[,] array2boyutluDegisken3 = new int[3, 2] { { 0, 5 }, { 5, 89 }, { 12, 86 } };

            int[, ,] array3boyutluDegisken = new int[3, 4, 2];
            for (int i = 0; i < array3boyutluDegisken.GetLength(0); i++)
            {
                for (int j = 0; j < array3boyutluDegisken.GetLength(1); j++)
                {
                    for (int k = 0; k < array3boyutluDegisken.GetLength(2); k++)
                    {
                        array3boyutluDegisken[i, j, k] = rnd.Next(1, 101);
                    }
                }
            }
            array3boyutluDegisken[0, 0, 0] = 1;
            array3boyutluDegisken[0, 0, 1] = 1;
            array3boyutluDegisken[0, 1, 0] = 1;
            array3boyutluDegisken[0, 1, 1] = 1;
            array3boyutluDegisken[0, 2, 0] = 1;
            array3boyutluDegisken[0, 2, 1] = 1;
            array3boyutluDegisken[0, 3, 0] = 1;
            array3boyutluDegisken[0, 3, 1] = 1;
            array3boyutluDegisken[1, 0, 0] = 1;

            lbListe.Items.Clear();
            for (int i = 0; i < array2boyutluDegisken.GetLength(0); i++)
            {
                for (int j = 0; j < array2boyutluDegisken.GetLength(1); j++)
                {
                    lbListe.Items.Add(array2boyutluDegisken[i, j]);
                }
            }

            string[] gunler = new string[4];

            int index = 0;
            string gun = "Pazartesi";
            if (gunler.Length > index)
                gunler[index] = gun;
            else
            {
                Array.Resize(ref gunler, gunler.Length + 1);
                gunler[index] = gun;
            }

            index++;
            gun = "Sali";
            if (gunler.Length > index)
                gunler[index] = gun;
            else
            {
                Array.Resize(ref gunler, gunler.Length + 1);
                gunler[index] = gun;
            }

            index++;
            gun = "Çarsamba";
            if (gunler.Length > index)
                gunler[index] = gun;
            else
            {
                Array.Resize(ref gunler, gunler.Length + 1);
                gunler[index] = gun;
            }

            index++;
            gun = "Persembe";
            if (gunler.Length > index)
                gunler[index] = gun;
            else
            {
                Array.Resize(ref gunler, gunler.Length + 1);
                gunler[index] = gun;
            }

            index++;
            gun = "Cuma*";
            if (gunler.Length > index)
                gunler[index] = gun;
            else
            {
                Array.Resize(ref gunler, gunler.Length + 1);
                gunler[index] = gun;
            }

            index++;
            gun = "Cumartesi";
            if (gunler.Length > index)
                gunler[index] = gun;
            else
            {
                Array.Resize(ref gunler, gunler.Length + 1);
                gunler[index] = gun;
            }

            index++;
            gun = "Pazar";
            if (gunler.Length > index)
                gunler[index] = gun;
            else
            {
                Array.Resize(ref gunler, gunler.Length + 1);
                gunler[index] = gun;
            }

            index++;
            gun = "Pazar";
            if (gunler.Length > index)
                gunler[index] = gun;
            else
            {
                Array.Resize(ref gunler, gunler.Length + 1);
                gunler[index] = gun;
            }

            Array.Sort(gunler);
            Array.Reverse(gunler);

            #endregion

            #region Struct Class Yapılı Diziler

            List<string> listArray = new List<string>();
            listArray.Add("Pazartesi");

            if (!listArray.Contains("Salı"))
                listArray.Add("Salı");
            listArray.Add("Perşembe");
            listArray.Insert(2, "Çarşamba");
            listArray.Remove("Salı");

            foreach (string listItem in listArray)
            {
                MessageBox.Show(listItem);
            }

            Dictionary<int, string> dictionaryArray = new Dictionary<int, string>();
            dictionaryArray.Add(1, "Pazartesi");
                dictionaryArray.Add(2, "Salı");
            
            dictionaryArray.Add(3, "Çarşamba");
            dictionaryArray.Add(4, "Perşembe");

            foreach (KeyValuePair<int, string> dictionaryItem in dictionaryArray)
            {
                MessageBox.Show(dictionaryItem.Key + " - " + dictionaryItem.Value);
            }


            #endregion
        }
    }
}
