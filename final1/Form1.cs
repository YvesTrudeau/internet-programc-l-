using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace final1
{
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteribolumu mb = new Musteribolumu();
            mb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Poliçebölümü pb = new Poliçebölümü();
            pb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SigortaBölümü sb = new SigortaBölümü();
            sb.Show();
        }

        private void Giriş_Load(object sender, EventArgs e)
        {

        }
    }
}
