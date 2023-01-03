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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        public string ad;
        police a=new police();

        private void button1_Click(object sender, EventArgs e)
        {
            if (a.giris(textBox1.Text, textBox2.Text) == 1)
            {
                MessageBox.Show("giriş başarılı", "kullanıcı girişi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ad = textBox1.Text;
                Giriş F = new Giriş();
                F.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("giriş yapılamadı", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3  f= new Form3();
            f.Show();
            this.Hide();

        }
    }
}
