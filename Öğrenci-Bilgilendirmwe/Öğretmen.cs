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

namespace Öğrenci_Bilgilendirmwe
{
    public partial class Öğretmen : Form
    {
        public Öğretmen()
        {
            InitializeComponent();
        }

        SqlConnection bağlanti = new SqlConnection("Data Source=DESKTOP-2CB3H73;Initial Catalog=Okul;Integrated Security=True");

        private void Öğretmen_Load(object sender, EventArgs e)
        {

        }

        public void clear()
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            maskedTextBox1.Text = " ";
            maskedTextBox2.Text = " ";
            maskedTextBox3.Text = " ";
            maskedTextBox4.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bağlanti.Open();
            SqlCommand update = new SqlCommand("Update ÖğrenciBilgilendirme set ÖğrenciAd=@a1, ÖğrenciSoyad=@a2, Sınav1=@a3, Sınav2=@a4, Final=@a5, ÖğrenciNumarası=@a6 Where ÖğrenciID=@a7",bağlanti);
            update.Parameters.AddWithValue("@a1", textBox2.Text);
            update.Parameters.AddWithValue("@a2", textBox3.Text);
            update.Parameters.AddWithValue("@a3", maskedTextBox1.Text);
            update.Parameters.AddWithValue("@a4", maskedTextBox2.Text);
            update.Parameters.AddWithValue("@a5", maskedTextBox3.Text);
            update.Parameters.AddWithValue("@a6", maskedTextBox4.Text);
            update.Parameters.AddWithValue("@a7", textBox1.Text);
            update.ExecuteNonQuery();
            bağlanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.öğrenciBilgilendirmeTableAdapter.Fill(this.okulDataSet.ÖğrenciBilgilendirme);
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bağlanti.Open();
            SqlCommand delete = new SqlCommand("Delete From ÖğrenciBilgilendirme Where ÖğrenciID=@b1", bağlanti);
            delete.Parameters.AddWithValue("@b1", textBox1.Text);
            delete.ExecuteNonQuery();
            bağlanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bağlanti.Open();
            SqlCommand insert = new SqlCommand("Insert into ÖğrenciBilgilendirme (ÖğrenciAd, ÖğrenciSoyad, Sınav1, Sınav2, Final, ÖğrenciNumarası) values (@a1, @a2, @a3, @a4, @a5, @a6)", bağlanti);
            insert.Parameters.AddWithValue("@a1", textBox2.Text);
            insert.Parameters.AddWithValue("@a2", textBox3.Text);
            insert.Parameters.AddWithValue("@a3", maskedTextBox1.Text);
            insert.Parameters.AddWithValue("@a4", maskedTextBox2.Text);
            insert.Parameters.AddWithValue("@a5", maskedTextBox3.Text);
            insert.Parameters.AddWithValue("@a6", maskedTextBox4.Text);
            insert.ExecuteNonQuery();
            bağlanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTextBox2.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            maskedTextBox3.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            maskedTextBox4.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
