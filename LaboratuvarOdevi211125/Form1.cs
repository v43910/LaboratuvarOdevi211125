using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace LaboratuvarOdevi211125
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int[] sayilar = new int[100];
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i]= rastgele.Next(500);
            }

            int buyukSayi = 0;
            int kucukSayi = 500;
            int ort = 0;
            foreach (int item in sayilar)
            {
                if (item>buyukSayi)
                {
                    buyukSayi = item;
                }

                if (item<kucukSayi)
                {
                    kucukSayi = item;
                }
                ort = ort + item;
            }
            ort = ort / 100;
            MessageBox.Show("Büyük Sayı : " + buyukSayi + "\nKüçük Sayı : " + kucukSayi + "\nOrtalama : " + ort);
        }

        ArrayList aList = new ArrayList();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            aList.Add(txtIsim.Text);
            _listboxGuncelle();
        }




        private void _listboxGuncelle() {
            listBox1.Items.Clear();
            foreach (string item in aList)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            aList.Remove(txtIsim.Text);
            _listboxGuncelle();
        }

        private void btnAZ_Click(object sender, EventArgs e)
        {
            aList.Sort();
            _listboxGuncelle();
        }

        private void btnZA_Click(object sender, EventArgs e)
        {
            aList.Sort();
            aList.Reverse();
            _listboxGuncelle();
        }
    }
}
