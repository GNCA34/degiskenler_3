using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adsoyad,meslek;
            adsoyad = "Eylül Yücedağ";
            meslek = "Öğretmen";
            label1.Text = adsoyad;
            label2.Text = meslek;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sehir;
            sehir = textBox1.Text;
            label3.Text = sehir;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ad1, soyad1,meslek,yaş;
            ad1 = textBox2.Text;
            soyad1 = textBox3.Text;
            meslek = textBox4.Text;
            yaş = maskedTextBox1.Text;
            listBox1.Items.Add(ad1+soyad1+meslek+yaş);
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
