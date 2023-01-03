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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        string con = "server=localhost:Database=proje;Uid=root;Pwd'':";
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                MySqlConnection baglan = new MySqlConnection();
                string sorgu = "Insert into kullanici values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                baglan.Open();
                cmd.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt Eklendi.");
                 Form3 f = new Form3();
                this.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
