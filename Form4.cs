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
    
    public partial class Form4 : Form
    {
        //public void populate()
        //{
            //string connectionString = "Data Source=HASEEB;Initial Catalog=Shop;Integrated Security=True;";
            //SqlConnection con = new SqlConnection(connectionString);
            //con.Open();
            //string query = "SELECT * FROM Customer;";
            //SqlDataAdapter da = new SqlDataAdapter(query, con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(da);
            //var ds = new DataSet();
            //da.Fill(ds);
            //CostumerDataTable.DataSource = ds.Tables[0];
            //con.Close();
        //}
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=HASEEB;Initial Catalog=Shop;Integrated Security=True;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            if (cid.Text == "" || cname.Text == "" || ccnic.Text == ""|| cph.Text == "" || caddress.Text == "")
            {
                MessageBox.Show("Enter values in all fields!!");

            }
            else
            {
                try
                {
                    string query = "INSERT INTO Customer(c_id, c_name, c_no, c_adress, c_cnic) VALUES('" + cid.Text + "', '" + cname.Text + "', '" + cph.Text + "', '" + caddress.Text + "', '" + ccnic.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer data entered Successfully!!");
                    //populate();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error!!");
                }
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=HASEEB;Initial Catalog=Shop;Integrated Security=True;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "UPDATE Customer SET c_name = '" + cname.Text + "', c_cnic = '" + ccnic.Text + "', c_no = '" + cph.Text + "', c_adress = '" + caddress.Text + "' where c_id = '" + cid.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Record updated Successfully!!");
            con.Close();
            //populate;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cid.Text = String.Empty;
            cname.Text = String.Empty;
            cph.Text = String.Empty;
            caddress.Text = String.Empty;
            ccnic.Text = String.Empty;
            MessageBox.Show("Input fields Cleared.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=HASEEB;Initial Catalog=Shop;Integrated Security=True;";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string query = "DELETE FROM Customer where c_id = '" + cid.Text + "';";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted Successfully!!");
                con.Close();
                //populate();
            }
            catch (Exception)
            {
                MessageBox.Show("Error!!");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form6 f6 = new Form6();
            f6.Show();
        }
    }
}
