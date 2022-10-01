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
    public partial class Form3 : Form
    {
       private string g;

        //public void populate()
        //{
            //string connectionString = "Data Source=HASEEB;Initial Catalog=Shop;Integrated Security=True;";
            //SqlConnection con = new SqlConnection(connectionString);
            //con.Open();
            //string query = "SELECT * FROM Employee";
            //SqlDataAdapter da = new SqlDataAdapter(query, con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(da);
            //var ds = new DataSet();
            //da.Fill(ds);
            //EmpDataTable.DataSource = ds.Tables[0];
            //con.Close();
        //}
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //populate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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
            this.Close();
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String g = "";
            if (male.Checked == true) { g = "Male"; } else { g = "Female"; }
            string connectionString = "Data Source=HASEEB;Initial Catalog=Shop;Integrated Security=True;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            if (eid.Text == "" || ename.Text == "" || ecnic.Text == "" || g == "" || eph.Text == "" || eexp.Text == "" || epost.Text == "")
            {
                MessageBox.Show("Enter values in all fields!!");

            }
            else
            {

                try
                {
                    string query = "INSERT INTO Employee(emp_id, emp_name, emp_cnic, emp_gen, emp_no, emp_exp, emp_post) VALUES('" + eid.Text + "', '" + ename.Text + "', '" + ecnic.Text + "', '" + g + "', '" + eph.Text + "', '" + eexp.Text + "', '" + epost.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee data entered Successfully!!");
                    //populate();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error!!");
                }
            }
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //populate();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=HASEEB;Initial Catalog=Shop;Integrated Security=True;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "UPDATE Employee SET emp_name = '" + ename.Text + "', emp_cnic = '" + ecnic.Text + "', emp_no = '" + eph.Text + "', emp_exp = '" + eexp.Text + "', emp_post = '" + epost.Text + "' where emp_id = '" + eid.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Record updated Successfully!!");
            con.Close();
            //populate();
        }

        private void EmpDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            eid.Text = String.Empty;
            ename.Text = String.Empty;
            ecnic.Text = String.Empty;
            eph.Text = String.Empty;
            eexp.Text = String.Empty;
            epost.Text = String.Empty;
            male.Checked = false;
            female.Checked = false;
            MessageBox.Show("Input fields Cleared.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=HASEEB;Initial Catalog=Shop;Integrated Security=True;";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string query = "DELETE FROM Employee where emp_id = '" + eid.Text + "';";
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form11 f11 = new Form11();
            f11.Show();
        }
    }
}
