using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gundogdupansiyon
{
    public partial class frmAdminGiris : Form
    {
        public frmAdminGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text=="admin" && textBox2.Text == "12345")
            {
                frmAnaForm fr = new frmAnaForm();
                fr.Show();
                this.Hide();
                MessageBox.Show("Giriş Başarılı");

            }
            else
            {
                MessageBox.Show("Hatalı Şifre/Kullanıcı Adı");
            }
        }
    }
}
