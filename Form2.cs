using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çelebi_Taşımacılık_LTD.ŞTİ.AŞ_Yusuf_Çelebi
{

   
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            button40.Visible = false;
            textBox3.Text = "+(90) ";

        }

       

        private void button38_Click(object sender, EventArgs e)
        {
            int a, b;
            a = comboBox2.SelectedIndex;
            b = comboBox3.SelectedIndex;
            comboBox3.SelectedIndex = a;
            comboBox2.SelectedIndex = b;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
        }

        Bilet bilet = new Bilet();
        private void button39_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen seyahat etmek istediğiniz firmayı seçiniz");
            }

            else if (comboBox2.SelectedIndex == -1 && comboBox3.SelectedIndex != -1 && comboBox4.SelectedIndex != -1)
            {
                MessageBox.Show("Lütfen yolculuğa nereden başlayacağınızı seçiniz");
            }

            else if (comboBox2.SelectedIndex != -1 && comboBox3.SelectedIndex == -1 && comboBox4.SelectedIndex != -1)
            {
                MessageBox.Show("Lütfen nereye yolculuk yapacağınızı seçiniz");
            }

            else if (comboBox2.SelectedIndex != -1 && comboBox3.SelectedIndex != -1 && comboBox4.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen yolculuğun başlangıç saatini seçiniz");
            }

            else if (comboBox2.SelectedIndex == -1 && comboBox3.SelectedIndex == -1 && comboBox4.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen gerekli yerleri doldurunuz");
            }

            else if (comboBox2.SelectedIndex != -1 && comboBox3.SelectedIndex != -1 && comboBox4.SelectedIndex != -1 && comboBox1.SelectedIndex != -1)
            {
                int tekliKoltuk,ikiliKoltuk;
                label1.Text = comboBox1.Text;
                label2.Text = comboBox2.Text + " > " + comboBox3.Text;
                label3.Text = dateTimePicker1.Text;
                label4.Text = comboBox4.Text;
                Random random = new Random();
                tekliKoltuk = random.Next(100, 600);
                ikiliKoltuk = tekliKoltuk - 15;

                
                bilet.tekliKoltuk = tekliKoltuk;
                bilet.ikiliKoltuk = ikiliKoltuk;

                label5.Text = "Tek kişilik koltuk fiyatı: "+tekliKoltuk.ToString() +  "₺"+Environment.NewLine+ Environment.NewLine+"İkili koltuk fiyatı: " +ikiliKoltuk.ToString()+ "₺";

                groupBox1.Visible = true;
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
                button40.Visible = true;
                button40.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {
            #region
            button1.BackColor= Color.White;
            button2.BackColor= Color.White;
            button3.BackColor= Color.White;
            button4.BackColor= Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            button10.BackColor = Color.White;
            button11.BackColor = Color.White;
            button12.BackColor = Color.White;
            button13.BackColor = Color.White;
            button14.BackColor = Color.White;
            button15.BackColor = Color.White;
            button16.BackColor = Color.White;
            button17.BackColor = Color.White;
            button18.BackColor = Color.White;
            button19.BackColor = Color.White;
            button20.BackColor = Color.White;
            button21.BackColor = Color.White;
            button22.BackColor = Color.White;
            button23.BackColor = Color.White;
            button24.BackColor = Color.White;
            button25.BackColor = Color.White;
            button26.BackColor = Color.White;
            button27.BackColor = Color.White;
            button28.BackColor = Color.White;
            button29.BackColor = Color.White;
            button30.BackColor = Color.White;
            button31.BackColor = Color.White;
            button32.BackColor = Color.White;
            button33.BackColor = Color.White;
            button34.BackColor = Color.White;
            button35.BackColor = Color.White;
            button36.BackColor = Color.White;
            button37.BackColor = Color.White;
            #endregion //

            toplamfiyat = 0;
            bilet.ToplamFiyat = 0;
            label7.Text=bilet.ToplamFiyat.ToString();
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            button40.Enabled = false;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }









        #region

        
        int toplamfiyat=0;
         


        private void button1_Click(object sender, EventArgs e)
        {
            int fiyat=bilet.tekliKoltuk;
            

            if (button1.BackColor != Color.DarkTurquoise)
            {
                button1.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;

            }

            else if(button1.BackColor != Color.White)
            {
                button1.BackColor= Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.ikiliKoltuk;
           
            if (button2.BackColor != Color.DarkTurquoise)
            {
                button2.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button2.BackColor != Color.White)
            {
                button2.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.ikiliKoltuk;
            if (button3.BackColor != Color.DarkTurquoise)
            {
                button3.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button3.BackColor != Color.White)
            {
                button3.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int fiyat = bilet.tekliKoltuk;
            if (button4.BackColor != Color.DarkTurquoise)
            {
                button4.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button4.BackColor != Color.White)
            {
                button4.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.ikiliKoltuk;
            if (button5.BackColor != Color.DarkTurquoise)
            {
                button5.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

       else if (button5.BackColor != Color.White)
            {
                button5.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.ikiliKoltuk;
            if (button6.BackColor != Color.DarkTurquoise)
            {
                button6.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

       else if (button6.BackColor != Color.White)
            {
                button6.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.tekliKoltuk;
            if (button7.BackColor != Color.DarkTurquoise)
            {
                button7.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button7.BackColor != Color.White)
            {
                button7.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.ikiliKoltuk;
            if (button8.BackColor != Color.DarkTurquoise)
            {
                button8.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button8.BackColor != Color.White)
            {
                button8.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.ikiliKoltuk;
            if (button9.BackColor != Color.DarkTurquoise)
            {
                button9.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button9.BackColor != Color.White)
            {
                button9.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.tekliKoltuk;
            if (button10.BackColor != Color.DarkTurquoise)
            {
                button10.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button10.BackColor != Color.White)
            {
                button10.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.ikiliKoltuk;
            if (button11.BackColor != Color.DarkTurquoise)
            {
                button11.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button11.BackColor != Color.White)
            {
                button11.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.ikiliKoltuk;
            if (button12.BackColor != Color.DarkTurquoise)
            {
                button12.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button12.BackColor != Color.White)
            {
                button12.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.tekliKoltuk;
            if (button13.BackColor != Color.DarkTurquoise)
            {
                button13.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button13.BackColor != Color.White)
            {
                button13.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.ikiliKoltuk;
            if (button14.BackColor != Color.DarkTurquoise)
            {
                button14.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button14.BackColor != Color.White)
            {
                button14.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.ikiliKoltuk;
            if (button15.BackColor != Color.DarkTurquoise)
            {
                button15.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button15.BackColor != Color.White)
            {
                button15.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.tekliKoltuk;
            if (button16.BackColor != Color.DarkTurquoise)
            {
                button16.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button16.BackColor != Color.White)
            {
                button16.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.ikiliKoltuk;

            if (button17.BackColor != Color.DarkTurquoise)
            {
                button17.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button17.BackColor != Color.White)
            {
                button17.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.ikiliKoltuk;
            if (button18.BackColor != Color.DarkTurquoise)
            {
                button18.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button18.BackColor != Color.White)
            {
                button18.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.tekliKoltuk;
            if (button19.BackColor != Color.DarkTurquoise)
            {
                button19.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button19.BackColor != Color.White)
            {
                button19.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.ikiliKoltuk;
            if (button20.BackColor != Color.DarkTurquoise)
            {
                button20.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button20.BackColor != Color.White)
            {
                button20.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.ikiliKoltuk;
            if (button21.BackColor != Color.DarkTurquoise)
            {
                button21.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button21.BackColor != Color.White)
            {
                button21.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);

        }

        private void button22_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.tekliKoltuk;
            if (button22.BackColor != Color.DarkTurquoise)
            {
                button22.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button22.BackColor != Color.White)
            {
                button22.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.tekliKoltuk;
            if (button23.BackColor != Color.DarkTurquoise)
            {
                button23.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button23.BackColor != Color.White)
            {
                button23.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.ikiliKoltuk;
            if (button24.BackColor != Color.DarkTurquoise)
            {
                button24.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button24.BackColor != Color.White)
            {
                button24.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.ikiliKoltuk;
            if (button25.BackColor != Color.DarkTurquoise)
            {
                button25.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button25.BackColor != Color.White)
            {
                button25.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.tekliKoltuk;
            if (button26.BackColor != Color.DarkTurquoise)
            {
                button26.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button26.BackColor != Color.White)
            {
                button26.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.ikiliKoltuk;
            if (button27.BackColor != Color.DarkTurquoise)
            {
                button27.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button27.BackColor != Color.White)
            {
                button27.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.ikiliKoltuk;
            if (button28.BackColor != Color.DarkTurquoise)
            {
                button28.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }
            

            else if (button28.BackColor != Color.White)
            {
                button28.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.tekliKoltuk;
            if (button29.BackColor != Color.DarkTurquoise)
            {
                button29.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button29.BackColor != Color.White)
            {
                button29.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.ikiliKoltuk;
            if (button30.BackColor != Color.DarkTurquoise)
            {
                button30.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button30.BackColor != Color.White)
            {
                button30.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.ikiliKoltuk;
            if (button31.BackColor != Color.DarkTurquoise)
            {
                button31.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button31.BackColor != Color.White)
            {
                button31.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.tekliKoltuk;
            if (button32.BackColor != Color.DarkTurquoise)
            {
                button32.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button32.BackColor != Color.White)
            {
                button32.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.ikiliKoltuk;
            if (button33.BackColor != Color.DarkTurquoise)
            {
                button33.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button33.BackColor != Color.White)
            {
                button33.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.ikiliKoltuk;
            if (button34.BackColor != Color.DarkTurquoise)
            {
                button34.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button34.BackColor != Color.White)
            {
                button34.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.tekliKoltuk;
            if (button35.BackColor != Color.DarkTurquoise)
            {
                button35.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button35.BackColor != Color.White)
            {
                button35.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.ikiliKoltuk;
            if (button36.BackColor != Color.DarkTurquoise)
            {
                button36.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
            }

            else if (button36.BackColor != Color.White)
            {
                button36.BackColor = Color.White;
                toplamfiyat -= fiyat;
            }
            label7.Text = Convert.ToString(toplamfiyat);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            int fiyat = bilet.ikiliKoltuk;
            if (button37.BackColor != Color.DarkTurquoise)
            {
                button37.BackColor = Color.DarkTurquoise;
                toplamfiyat += fiyat;
                
            }

            else if (button37.BackColor != Color.White)
            {
                button37.BackColor = Color.White;
                toplamfiyat -= fiyat;
                
            }
            bilet.ToplamFiyat = toplamfiyat;
            label7.Text = Convert.ToString(bilet.ToplamFiyat);
        }

        #endregion


        private void button41_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Lütfen Kullanıcı Bilgilerini Doldurunuz", "Eksik Bilgi");
            }
            else
            {

                string name;
                string surname;
                string telno;
                string tckn;

                name = textBox1.Text;
                surname= textBox2.Text;
                telno = textBox3.Text;
                tckn = textBox4.Text;

                

                
                

                bilet.Nereden = comboBox2.Text;
                bilet.Nereye = comboBox3.Text;

                bilet.alınanKoltuklar = "";

                #region 

                if (button1.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button1.Text + "-";
                }
                if (button2.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button2.Text + "-";
                }
                if (button3.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button3.Text + "-";
                }
                if (button4.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button4.Text + "-";
                }
                if (button5.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button5.Text + "-";
                }
                if (button6.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button6.Text + "-";
                }
                if (button7.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button7.Text + "-";
                }
                if (button8.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button8.Text + "-";
                }
                if (button9.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button9.Text + "-";
                }
                if (button10.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button10.Text + "-";
                }
                if (button11.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button11.Text + "-";
                }
                if (button12.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button12.Text + "-";
                }
                if (button13.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button13.Text + "-";
                }
                if (button14.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button14.Text + "-";
                }
                if (button15.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button15.Text + "-";
                }
                if (button16.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button16.Text + "-";
                }
                if (button17.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button17.Text + "-";
                }
                if (button18.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button18.Text + "-";
                }
                if (button19.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button19.Text + "-";
                }
                if (button20.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button20.Text + "-";
                }
                if (button21.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button21.Text + "-";
                }
                if (button22.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button22.Text + "-";
                }
                if (button23.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button23.Text + "-";
                }
                if (button24.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button24.Text + "-";
                }
                if (button25.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button25.Text + "-";
                }
                if (button26.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button26.Text + "-";
                }
                if (button27.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button27.Text + "-";
                }
                if (button28.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button28.Text + "-";
                }
                if (button29.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button29.Text + "-";
                }
                if (button30.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button30.Text + "-";
                }
                if (button31.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button31.Text + "-";
                }
                if (button32.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button32.Text + "-";
                }
                if (button33.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button33.Text + "-";
                }
                if (button34.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button34.Text + "-";
                }
                if (button35.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button35.Text + "-";
                }
                if (button36.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button36.Text + "-";
                }
                if (button37.BackColor == Color.DarkTurquoise)
                {
                    bilet.alınanKoltuklar += button37.Text + "-";
                }
                #endregion


                if (bilet.alınanKoltuklar == "")
                {
                    MessageBox.Show("Lütfen koltuk seçiniz");
                }


                else if (bilet.alınanKoltuklar != "" & bilet.alınanKoltuklar.Substring(bilet.alınanKoltuklar.Length - 1) == "-")
                {
                    DialogResult dialog = new DialogResult();
                    dialog = MessageBox.Show("Satın almak istediğinize emin misiniz?", "Satın Alma", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        bilet.alınanKoltuklar = bilet.alınanKoltuklar.Remove(bilet.alınanKoltuklar.Length - 1, 1);
                        bilet.Tarih = dateTimePicker1.Text;
                        bilet.Saat = comboBox4.Text;
                        bilet.Firma = comboBox1.Text;
                        bilet.ToplamFiyat = toplamfiyat;

                        Form3 form3 = new Form3();
                        form3.label1.Text = bilet.Firma;
                        form3.label2.Text = bilet.Nereden + " > " + bilet.Nereye;
                        form3.label3.Text = bilet.Tarih;
                        form3.label4.Text = bilet.Saat;
                        form3.label5.Text = bilet.ToplamFiyat.ToString() + "₺";
                        form3.label6.Text = bilet.alınanKoltuklar;
                        form3.label12.Text = name;
                        form3.label13.Text = surname;
                        form3.label15.Text = tckn;
                        form3.label17.Text = telno;
                        form3.Show();
                        this.Hide();


                    }
                    else
                    {

                    }

                }


            }
        }
        
        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void button42_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(bilet.ToplamFiyat));
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }
    }
}
    

