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
    public partial class Musteribolumu : Form
    {
        public Musteribolumu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Müşteribölümü_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con = "Server=localhost;Database=proje;Uid=root;Pwd='';";
            private void button1_Click(object sender, EventArgs e)
            {
                try
                {
                    MySqlConnection baglan = new MySqlConnection(con);
                    string sorgu = "Insert into urunler values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                    baglan.Open();
                    cmd.ExecuteNonQuery();
                    baglan.Close();
                    MessageBox.Show("Kayıt Eklendi.");
                    Musteribolumu mb= new Musteribolumu();
                    
                    this.Close();
                }
                catch (Exception hata)
                {

                    MessageBox.Show(hata.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            private void ekle_FormClosing(object sender, FormClosingEventArgs e)
            {
                Musteribolumu mb= new Musteribolumu();
                
            }



        }


    }
}
