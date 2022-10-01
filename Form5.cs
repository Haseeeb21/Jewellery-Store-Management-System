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
    public partial class Form5 : Form
    {
        //public void populate()
        //{
        //string connectionString = "Data Source=HASEEB;Initial Catalog=Shop;Integrated Security=True;";
        //SqlConnection con = new SqlConnection(connectionString);
        //con.Open();
        //string query = "SELECT * FROM Product;";
        //SqlDataAdapter da = new SqlDataAdapter(query, con);
        //SqlCommandBuilder builder = new SqlCommandBuilder(da);
        //var ds = new DataSet();
        //da.Fill(ds);
        //CostumerDataTable.DataSource = ds.Tables[0];
        //con.Close();
        //}
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=HASEEB;Initial Catalog=Shop;Integrated Security=True;";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string query = "DELETE FROM Product where p_id = '" + pid.Text + "';";
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

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=HASEEB;Initial Catalog=Shop;Integrated Security=True;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            if (pid.Text == "" || pcom.Text == "" || pcat.Text == "" || ptype.Text == "" || pprice.Text == "")
            {
                MessageBox.Show("Enter values in all fields!!");

            }
            else
            {
                try
                {
                    string query = "INSERT INTO Product(p_id, p_company, p_catagory, p_type, p_price) VALUES('" + pid.Text + "', '" + pcom.Text + "', '" + pcat.Text + "', '" + ptype.Text + "', '" + pprice.Text + "');";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product data entered Successfully!!");
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
            string query = "UPDATE Product SET p_company = '" + pcom.Text + "', p_catagory = '" + pcat.Text + "', p_type = '" + ptype.Text + "', p_price = '" + pprice.Text + "' where p_id = '" + pid.Text + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Record updated Successfully!!");
            con.Close();
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

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form9 f9 = new Form9();
            f9.Show();
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pid.Text = String.Empty;
            pcom.Text = String.Empty;
            pcat.Text = String.Empty;
            ptype.Text = String.Empty;
            pprice.Text = String.Empty;
            MessageBox.Show("Input fields Cleared.");
        }
    }
}
