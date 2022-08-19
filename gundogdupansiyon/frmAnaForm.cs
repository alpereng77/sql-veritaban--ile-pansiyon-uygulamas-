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
    public partial class frmAnaForm : Form
    {
        public frmAnaForm()
        {
            InitializeComponent();
        }

        private void frmAnaForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAdminGiris fr = new frmAdminGiris();
            fr.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            YeniMusteri fr = new YeniMusteri();
            fr.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Odalar fr = new Odalar();
            fr.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Musteriler fr = new Musteriler();
            fr.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Radyo fr = new Radyo();
            fr.Show();
        }
    }

    }

