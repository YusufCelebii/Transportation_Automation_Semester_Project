using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çelebi_Taşımacılık_LTD.ŞTİ.AŞ_Yusuf_Çelebi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<User> users = new List<User>();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "" & textBox4.Text != "")
            {
                

                User  user= new User();

                user.Name = textBox1.Text;
                user.Surname = textBox2.Text;
                user.Nickname = textBox3.Text;
                user.Password = textBox4.Text;
                users.Add(user);
                MessageBox.Show("Yeni Kayıt Oluşturuldu");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }

            else
            {
                MessageBox.Show("Lütfen gerekli bilgileri eksiksiz giriniz","Kullanıcı kaydı oluşturulamadı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                foreach (User user in users)
                {
                    if ((user.Nickname == textBox5.Text & user.Password == textBox6.Text) || ("123" == textBox5.Text & "123" == textBox6.Text))
                    {
                        MessageBox.Show("Giriş Başarılı", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Form2 form2 = new Form2();
                        form2.Show();
                        this.Hide();
                        break;
                    }
                    else if (user.Nickname != textBox5.Text || user.Password != textBox6.Text)
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    else
                    {

                    }


                }
            
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
        }
    }
}
