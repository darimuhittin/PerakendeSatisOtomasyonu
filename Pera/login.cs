using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pera
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

       
        private void textBox1_Click(object sender, EventArgs e)
        {
            username.Clear();
            panel1.BackColor = Color.FromArgb(0,0,0);

            panel2.BackColor = Color.White;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            password.Clear();
            panel2.BackColor = Color.FromArgb(0, 0, 0);

            panel1.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var username = this.username.Text;
            var password = this.password.Text;

            using (PerakendeContext ctx = new PerakendeContext())
            {
                var user = ctx.Logins.FirstOrDefault(u=>u.UserName==username);
                if (user.UserName =="admin")
                {
                    if (user.Password == password)
                    {
                        MessageBox.Show("Admin girişi yapıldı.\n" +"Tüm yetkiler verildi.");
                        AnaPanel panel = new AnaPanel();
                        panel.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                }
                else if (user.UserName == "personel")
                {
                    if (user.Password == password)
                    {
                        MessageBox.Show("Giriş Başarılı");
                        AnaPanel panel = new AnaPanel();
                        panel.contextMenuStripCalisanlar.Enabled = false;
                        panel.contextMenuStripUrunler.Enabled = false;
                        panel.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Hatalı Gİriş");
                }

                else
                    MessageBox.Show("Kullanıcı Bulunamadı");
            }
        }
    }
}
