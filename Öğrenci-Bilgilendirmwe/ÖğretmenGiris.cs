using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Öğrenci_Bilgilendirmwe
{
    public partial class ÖğretmenGiris : Form
    {
        public ÖğretmenGiris()
        {
            InitializeComponent();
        }

        SqlConnection bağlanti = new SqlConnection("Data Source=DESKTOP-2CB3H73;Initial Catalog=Okul;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ÖğretmenGiris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bağlanti.Open();
            SqlCommand giris = new SqlCommand("Select * From ÖğretmenGiris Where ÖğretmenKullanıcıAdı=@ö1 and ÖğretmenSifre=@ö2", bağlanti);
            giris.Parameters.AddWithValue("@ö1", textBox1.Text);
            giris.Parameters.AddWithValue("@ö2", textBox2.Text);
            SqlDataReader reader = giris.ExecuteReader();
            if (reader.Read())
            {
                Öğretmen ö2 = new Öğretmen();
                ö2.Show();
                this.Hide();
            }
            bağlanti.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
