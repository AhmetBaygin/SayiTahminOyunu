using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahminOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi = 0;
        int tahmin_sayisi = 0;
        int puan = 1000;

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //basla butonu
            button2.Enabled = false;
            button1.Enabled = true;
            Random r = new Random();
            sayi = r.Next(100);
            label8.Text = sayi.ToString();
            label5.Text = "";
            label6.Text = "0";
            label7.Text = "1000";
            tahmin_sayisi = 0;
            puan = 1000;
            //label8.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tahmin;
            tahmin_sayisi++;
            if (tahmin_sayisi <= 10)
            {
                tahmin = Convert.ToInt32(textBox1.Text);
                label6.Text = tahmin_sayisi.ToString();
                if (sayi < tahmin)
                {
                    label5.Text = "tahmininizi azaltın";
                    puan = puan - 100;
                    label7.Text = puan.ToString();

                }
                else if (sayi > tahmin)
                {
                    label5.Text = "tahmininizi arttırın";
                    puan = puan - 100;
                    label7.Text = puan.ToString();
                }
                else
                {


                    label5.Text = "tebrikler " + tahmin_sayisi + "defada bildiniz" +
                        "puanınız " + puan;
                    button2.Enabled = true;
                    button1.Enabled = false;
                    textBox1.Clear();
                }
            }
            else
            {
                textBox1.Enabled = false;
                MessageBox.Show("tahmin hakkınız kalmadı oyun kapatılacak!!");
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
