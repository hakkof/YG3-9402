using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler_Tarih
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbGun.Items.Clear();
            for (int i = 1; i <= 31; i++)
            {
                if (i < 10)
                {
                    cbGun.Items.Add("0" + i.ToString());
                }
                else
                {
                    cbGun.Items.Add(i.ToString());
                }
            }

            cbAy.Items.Clear();
            int ay = 1;
            while (ay <= 12)
            {
                cbAy.Items.Add(ay);
                ay++;
            }

            cbYil.Items.Clear();
            int yil = 2000;
            do
            {
                cbYil.Items.Add(yil);
                yil++;
            } while (yil <= 2015);
        }

        private void cbAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAy.SelectedItem.ToString() == 2.ToString())
            {
                cbGun.Items.Clear();
                for (int i = 1; i <= 28; i++)
                    cbGun.Items.Add(i.ToString());
            }
        }
    }
}
