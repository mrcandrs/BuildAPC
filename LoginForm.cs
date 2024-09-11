using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using BuildAPC;


namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        private int failedLoginAttempt = 0;
        private const int maxFailedAttempts = 5;
        public LoginForm()
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


        private void Form2_Load(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e) // Username
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) // Password
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) // Employee ID
        {

        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e) //restricts the customer ID textbox input to only digit chars (0-9) and Backspace key on KeyPress
        {
            char digit = e.KeyChar;

            if (!char.IsDigit(digit) && digit != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a number.", "Build-A-PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            RegisterForm form_signUp = new RegisterForm();
            form_signUp.Show();

            this.Hide();

        }
        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5A8FMDF;Initial Catalog=buildapc;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            string query = "SELECT * FROM account WHERE Name = @Name AND CustomerID = @CustomerID AND Password = @Password COLLATE SQL_Latin1_General_CP1_CS_AS";

            SqlCommand cmd = new SqlCommand(query, conn);
            {
                cmd.Parameters.AddWithValue("@Name", txtUsername.Text);
                cmd.Parameters.AddWithValue("@CustomerID", txtEmpID.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                try
                {
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (txtUsername.Text == "")
                    {
                        MessageBox.Show("Please enter your username.", "Build-A-PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (txtPassword.Text == "")
                    {
                        MessageBox.Show("Please enter your Password.", "Build-A-PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (txtEmpID.Text == "")
                    {
                        MessageBox.Show("Please enter your Employee ID.", "Build-A-PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    if (dtable.Rows.Count > 0)
                    {
                        Dashboard dashboard = new Dashboard(txtUsername.Text, txtEmpID.Text);
                        dashboard.userName = txtUsername.Text.ToString(); //ililipat kay dashboard.userName ung value ng username dito
                        dashboard.cust_id = txtEmpID.Text.ToString(); //lilipat kay dashboard.cust.id ung value ng cust_id dito
                        dashboard.Show();
                        this.Hide();
                    }

                    else
                    {
                        failedLoginAttempt++;
                        if (failedLoginAttempt >= maxFailedAttempts)
                        {
                            StartCountdown();
                        }
                        else
                        {
                            MessageBox.Show("Invalid login details, please try again.\nCertain number of failed login attempts will result on a 10 second countdown.", "Build-A-PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUsername.Focus();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Exit the Application?", "Build-A-PC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
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

        private async void StartCountdown()
        {
            CustomMessageBox customMessageBox = new CustomMessageBox();
            customMessageBox.Show();

            int countdown = 10; // 10 seconds countdown

            while (countdown > 0)
            {
                customMessageBox.UpdateCountdownLabel(countdown);
                await Task.Delay(1000); // Wait for 1 second
                countdown--;
            }

            customMessageBox.Close();
            failedLoginAttempt = 0; // Reset failed attempts after countdown
        }

        private void labelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.Show();
            this.Hide();
        }
    }
}
