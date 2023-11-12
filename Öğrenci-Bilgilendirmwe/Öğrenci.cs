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
    public partial class Öğrenci : Form
    {
        public Öğrenci()
        {
            InitializeComponent();
        }

        SqlConnection bağlanti = new SqlConnection("Data Source=DESKTOP-2CB3H73;Initial Catalog=Okul;Integrated Security=True");
        public string numara;
        private void Öğrenci_Load(object sender, EventArgs e)
        {
            bağlanti.Open();
            SqlCommand a = new SqlCommand("Select * From ÖğrenciBilgilendirme Where ÖğrenciNumarası=@z1", bağlanti);
            a.Parameters.AddWithValue("@z1", numara);
            // this.Text=numara.ToString();
            SqlDataAdapter da = new SqlDataAdapter(a);
            DataTable dt = new DataTable();            
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bağlanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
