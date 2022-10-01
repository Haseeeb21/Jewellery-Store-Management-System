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

namespace Jewellery_Store
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=HASEEB;Initial Catalog=Shop;Integrated Security=True;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string username = usernametxt.Text;
            string password = passwordtxt.Text;
            SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE username = '" + usernametxt.Text + "' and password = '" + passwordtxt.Text + "'");
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Login Sucess. Welcome to Homepage!");
                this.Hide();
                Form2 frm2 = new Form2();
                frm2.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login, please check Username and Password");
            }
            con.Close();
        }
    }
}
