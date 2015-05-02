using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTumListe_Click(object sender, EventArgs e)
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
                if (i % 2 == 1)
                    lbListe.Items.Add(i.ToString());
            }
        }

        private void btnCiftSayilar_Click(object sender, EventArgs e)
        {
            lbListe.Items.Clear();

            //int i = 1;
            //{
            //    if (i <= 100)
            //    {

            //    }
            //    i++;
            //}

            int i = 1;
            for (; i <= 100; i++)
            {
                if (i == 1)
                    continue;

                if (i % 2 == 0)
                    break;

                //continue; -- dongude bir sonraki tura gecer
                //return; -- methodu sonlandırır
                //break; -- donguyu sonlandırır
            }
            // 2 tur

            for (; i <= 100; i += 2)
            {
                lbListe.Items.Add(i.ToString());
            }
            // n / 2 = 50

            //for (int i = 1; i <= 100; i ++)
            //{
            //    if (i % 2 == 0)
            //        lbListe.Items.Add(i.ToString());
            //}
        }

        private void btnKompleks_Click(object sender, EventArgs e)
        {
            lbListe.Items.Clear();
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 && i % 3 != 0)
                    lbListe.Items.Add(i.ToString());
            }
        }
    }
}
