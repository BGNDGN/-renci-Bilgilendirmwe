using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Öğrenci_Bilgilendirmwe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        SqlConnection bağlanti = new SqlConnection("Data Source=DESKTOP-2CB3H73;Initial Catalog=Okul;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1463")
            {
                Öğrenci öd = new Öğrenci();
                this.Hide();
                öd.numara = textBox1.Text;
                öd.Show();
 
            }

            if (textBox1.Text == "1414")
            {
                Öğrenci öd = new Öğrenci();
                this.Hide();
                öd.numara = textBox1.Text;
                öd.Show();
            }

            if (textBox1.Text == "192")
            {
                Öğrenci öd = new Öğrenci();
                this.Hide();
                öd.numara = textBox1.Text;
                öd.Show();
            }

            if (textBox1.Text == "1242")
            {
                Öğrenci öd = new Öğrenci();
                this.Hide();
                öd.numara = textBox1.Text;
                öd.Show();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            ÖğretmenGiris ög = new ÖğretmenGiris();
            ög.Show();
            this.Hide();
        }
    }
}
