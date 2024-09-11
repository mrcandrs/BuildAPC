using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        //dynamic form
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]

        private static extern bool ReleaseCapture();

        private void Form4_Load(object sender, EventArgs e)
        {
            //System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            //int radius = 30; //adjust the value to change the roundness of the corners

            //path.AddArc(0, 0, radius, radius, 180, 90); //top left corner
            //path.AddArc(this.Width - radius, 0, radius, radius, 270, 90); //top right corner
            //path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90); //bottom right corner
            //path.AddArc(0, this.Height - radius, radius, radius, 90, 90); //bottom left corner

            //creating region with the rounded rectangle path
            //this.Region = new Region(path);
        }

        private void button3_Click(object sender, EventArgs e) // Login account
        {
            LoginForm form2 = new LoginForm();
            this.Hide();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) // Clear text 
        {
            textBox1_Name.Text = string.Empty;
            textBox2_CustID.Text = string.Empty;
            textBox3_Password.Text = string.Empty;
            textBox4_conPass.Text = string.Empty;

            label6_nameError.Text = string.Empty;
            label7_empID.Text = string.Empty;
            label4_ErrorPass.Text = string.Empty;
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
        private void textBox2_CustID_KeyPress_1(object sender, KeyPressEventArgs e) //restricts the customer ID textbox input to only digit chars (0-9) and Backspace key on KeyPress
        {
            char digit = e.KeyChar;

            if (!char.IsDigit(digit) && digit != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a number.", "Build-A-PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e) // Signup account
        {
            string connectionString = "Data Source=DESKTOP-5A8FMDF;Initial Catalog=buildapc;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                string query = "INSERT INTO [dbo].[account] ([Name], [CustomerID], [Password]) VALUES (@Name, @CustomerID, @Password)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    //Use parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@Name", textBox1_Name.Text);
                    cmd.Parameters.AddWithValue("@CustomerID", textBox2_CustID.Text);
                    cmd.Parameters.AddWithValue("@Password", textBox3_Password.Text);
                    try
                    {
                        con.Open();

                        SqlCommand commandToCheckUsername, commandToCheckEmpID;

                        commandToCheckUsername = new SqlCommand("SELECT Name FROM account WHERE Name= '" + textBox1_Name.Text + "'", con);
                        string sameUser = (string)commandToCheckUsername.ExecuteScalar();

                        commandToCheckEmpID = new SqlCommand("SELECT CustomerID FROM account WHERE CustomerID = '" + textBox2_CustID.Text + "'", con);
                        string sameEmpID = (string)commandToCheckEmpID.ExecuteScalar();

                        if (textBox1_Name.Text == "")
                        {
                            MessageBox.Show("Please enter your desired username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (!IsValidUsername(textBox1_Name.Text))
                        {
                            label6_nameError.Text = "Username is invalid. (Does not accept special characters except -, . and _)";
                            return;
                        }

                        if (sameUser == textBox1_Name.Text)
                        {
                            label6_nameError.Text = "Username already taken.";
                            return;
                        }
                        else if (sameUser != textBox1_Name.Text)
                        {
                            label6_nameError.Text = "";
                        }

                        if (textBox2_CustID.Text == "")
                        {
                            MessageBox.Show("Please enter your desired Customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (sameEmpID == textBox2_CustID.Text)
                        {
                            label7_empID.Text = "Customer ID is already registered in the system.";
                            return;
                        }
                        else if (sameEmpID != textBox2_CustID.Text)
                        {
                            label7_empID.Text = "";
                        }

                        if (textBox3_Password.Text == "")
                        {
                            MessageBox.Show("Please enter your desired Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (!IsValidPassword(textBox3_Password.Text))
                        {
                            label4_ErrorPass.Text = "Password can only contain alphanumeric characters, dashes, dots, and underscores.";
                            return;
                        }

                        if (textBox3_Password.Text != textBox4_conPass.Text)
                        {
                            label4_ErrorPass.Text = "Passwords must match";
                            return;
                        }
                        else
                        {
                            cmd.ExecuteNonQuery();
                            label4_ErrorPass.Text = string.Empty;
                            MessageBox.Show("Successfully registered your account.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoginForm login = new LoginForm();
                            this.Hide();
                            login.Show();
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

        private bool IsValidUsername(string username)
        {
            string pattern = @"^[a-zA-Z0-9._-]+$";
            return Regex.IsMatch(username, pattern);
        }

        private bool IsValidPassword(string password)
        {
            string pattern = @"^[a-zA-Z0-9._-]+$";
            return Regex.IsMatch(password, pattern);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //check if the click was on the title bar
                if (e.Clicks == 1 && e.Y <= this.Height && e.Y >= 0)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }

        private void button_Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Exit the Application?", "Build-A-PC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}