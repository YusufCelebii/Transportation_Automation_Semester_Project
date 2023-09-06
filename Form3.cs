using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Çelebi_Taşımacılık_LTD.ŞTİ.AŞ_Yusuf_Çelebi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void Form3_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            random.Next(1, 10);
            char[] alfabe = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string pnrcode="PNR Kodu:";
            for (int i = 0; i < 16; i++)
            {
                if (i < 3)
                {
                    pnrcode+= alfabe[random.Next(alfabe.Length)];
                }
                else
                {
                    pnrcode += random.Next(1, 10);
                }
            }

            label9.Text = pnrcode;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void label3_Click(object sender, EventArgs e)
        {

        }

        public void label5_Click(object sender, EventArgs e)
        {

        }

        public void label2_Click(object sender, EventArgs e)
        {

        }

        public void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string biletbilgileri,biletoutput;
            biletoutput = label1.Text + "-bilet.txt";
            biletbilgileri = label1.Text + " Bilet Bilgilendirme   " + label9.Text + Environment.NewLine + Environment.NewLine
               + "İsim Soyisim:" + label12.Text + " " + label13.Text + Environment.NewLine
               + "TC Kimlik No: " + label15.Text + Environment.NewLine
               + "Telefo No: " + label17.Text + Environment.NewLine + Environment.NewLine
               + "Seyahat rotası: " + label2.Text + Environment.NewLine
               + "Yolculuk Tarih-Saati: " + label3.Text + "  " + label4.Text + Environment.NewLine
               + "Koltuk Numarası: " + label6.Text + Environment.NewLine + Environment.NewLine
               + "Bilet tutarı: " + label5.Text + Environment.NewLine + Environment.NewLine
               + label1.Text + " İyi yolculuklar diler.";
            StreamWriter bilet = new StreamWriter(biletoutput);
            bilet.WriteLine(biletbilgileri);
            bilet.Close();

            biletoutput = "Bilet bilgileriniz " + biletoutput + "olarak çıkartılmıştır";
            MessageBox.Show(biletoutput);
         


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
