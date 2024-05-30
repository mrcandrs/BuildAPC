using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Net.Http.Headers;


namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) // Username
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) // Password
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) // Employee ID
        {

        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char digit = e.KeyChar;

            if (!char.IsDigit(digit) && digit != 8)
            {
                e.Handled = true;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;

            }

            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {
            Form4 form_signUp = new Form4();
            form_signUp.Show();

            this.Hide();

        }
        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5A8FMDF;Initial Catalog=userregistrations;Integrated Security=True;TrustServerCertificate=True");
            string query = "SELECT * FROM registration WHERE name = @name AND employee_id = @employee_id AND password = @password";

            SqlCommand cmd = new SqlCommand(query, conn);
            {
                cmd.Parameters.AddWithValue("@name", txtUsername.Text);
                cmd.Parameters.AddWithValue("@employee_id", txtEmpID.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                try
                {
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        Form3 form3 = new Form3();
                       
                        form3.userName = "Welcome Back, " + txtUsername.Text;
                        form3.EmpID = "ID #: " + txtEmpID.Text;
                        form3.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login details", "Error");
                        txtUsername.Clear();
                        txtEmpID.Clear();
                        txtPassword.Clear();
                        txtUsername.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
