using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;


namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) // Login account
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) // Clear text 
        {
            textBox1_Name.Text = string.Empty;
            textBox2_EmpID.Text = string.Empty;
            textBox3_Password.Text = string.Empty;
            textBox4_conPass.Text = string.Empty;

            label6_nameError.Text = string.Empty;
            label7_empID.Text = string.Empty;

        }
        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3_Password.UseSystemPasswordChar = false;
                textBox4_conPass.UseSystemPasswordChar = false;
            }
            else
            {
                textBox3_Password.UseSystemPasswordChar = true;
                textBox4_conPass.UseSystemPasswordChar = true;
            }
        }
        private void button1_Click(object sender, EventArgs e) // Signup account
        {
            string connectionString = "Data Source=DESKTOP-5A8FMDF;Initial Catalog=userregistrations;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                string query = "INSERT INTO [dbo].[registration] ([name], [employee_id], [password]) VALUES (@Name, @EmployeeID, @Password)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    //Use parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@Name", textBox1_Name.Text);
                    cmd.Parameters.AddWithValue("@EmployeeID", textBox2_EmpID.Text);
                    cmd.Parameters.AddWithValue("@Password", textBox3_Password.Text);
                    try
                    {
                        con.Open();

                        SqlCommand commandToCheckUsername, commandToCheckEmpID;

                        commandToCheckUsername = new SqlCommand("SELECT name FROM registration WHERE name= '" + textBox1_Name.Text + "'", con);
                        string sameUser = (string)commandToCheckUsername.ExecuteScalar();

                        commandToCheckEmpID = new SqlCommand("SELECT employee_id FROM registration WHERE employee_id= '" + textBox2_EmpID.Text + "'", con);
                        string sameEmpID = (string)commandToCheckEmpID.ExecuteScalar();

                        if (textBox1_Name.Text == "")
                        {
                            MessageBox.Show("Please enter a username.");
                        }

                        if (sameUser == (textBox1_Name.Text))
                        {
                            label6_nameError.Text = "Username already taken.";
                            return;
                            

                        }
                        else if (sameUser != textBox1_Name.Text)
                        {
                            label6_nameError.Text = "";
                        }

                        if (textBox2_EmpID.Text == "")
                        {
                            MessageBox.Show("Please enter your desired Employee ID.");
                            return;
                            
                        }


                        if (sameEmpID == (textBox2_EmpID.Text))
                            {

                            label7_empID.Text = "Employee ID was already registered in the system.";
                            return;
                          }

                        else if (sameEmpID != textBox2_EmpID.Text)
                        {
                            label7_empID.Text = "";
                        }

                        if (textBox3_Password.Text == "")
                        {
                            MessageBox.Show("Please enter your desired Password.");

                        }

                        else if (textBox3_Password.Text != textBox4_conPass.Text)
                            {
                                label4_ErrorPass.Text = "Password must match";
                            
                            }

                        else
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Register Successfully");
                            }
                        }


                    catch (SqlException ex)
                    {
                        //Log the error (not shown)
                        MessageBox.Show("An error occurred while registering: " + ex.Message);
                    }
                    finally
                    {
                    con.Close();

                    }
                }
            }
        }
    }
}
