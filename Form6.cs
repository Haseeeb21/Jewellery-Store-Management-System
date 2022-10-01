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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form10 f10 = new Form10();
            f10.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 frm2 = new Form2();
            frm2.Show();
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
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 frm4 = new Form4();
            frm4.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            pid.Text = String.Empty;
            rno.Text = String.Empty;
            cname.Text = String.Empty;
            bp.Text = String.Empty;
            bq.Text = String.Empty;
        
            MessageBox.Show("Input fields Cleared.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=HASEEB;Initial Catalog=Shop;Integrated Security=True;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            if (rno.Text == "" || cname.Text == "" || pid.Text == "" || bp.Text == "" || bq.Text == "" || date.Text == "")
            {
                MessageBox.Show("Enter values in all fields!!");

            }
            else
            {
                try
                {
                    string query = "INSERT INTO Bill(rec_no, c_id, p_id, u_price, quantity, datee) VALUES('" + rno.Text + "', '" + cname.Text + "', '" + pid.Text + "', '" + bp.Text + "', '" + bq.Text + "', '" + date.Text + "');";
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=HASEEB;Initial Catalog=Shop;Integrated Security=True;";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string query = "DELETE FROM Bill where rec_no = '" + rno.Text + "';";
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

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
