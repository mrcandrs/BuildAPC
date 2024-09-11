using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace BuildAPC
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void buttonSubmit_Click_1(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address.", "Build-A-PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidGmailAddress(email))
            {
                MessageBox.Show("Please enter a valid Gmail address.", "Build-A-PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Validate email and send a reset token/link
            SendResetLink(email);
        }

        private void buttonSubmitToken_Click_1(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string token = textBoxToken.Text;

            if (string.IsNullOrEmpty(token))
            {
                MessageBox.Show("Please enter the token sent to your email.", "Build-A-PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsTokenValid(email, token))
            {
                ResetPasswordForm form = new ResetPasswordForm(token);
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Invalid token. Please try again.", "Build-A-PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidGmailAddress(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            return Regex.IsMatch(email, pattern);
        }

        private string GenerateToken()
        {
            return Guid.NewGuid().ToString();
        }

        private void SendResetLink(string email)
        {
            string token = GenerateToken();

            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5A8FMDF;Initial Catalog=buildapc;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                conn.Open();
                string query = "INSERT INTO PasswordResetTokens (Email, Token) VALUES (@Email, @Token)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Token", token);

                    cmd.ExecuteNonQuery();
                }
            }

            // Send email with the token
            SendEmail(email, token);
        }

        private bool IsTokenValid(string email, string token)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5A8FMDF;Initial Catalog=buildapc;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM PasswordResetTokens WHERE Email = @Email AND Token = @Token";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Token", token);
                    

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void SendEmail(string email, string token)
        {
            string fromEmail = "marcandres0923@gmail.com";
            string fromPassword = "hxsh nmjz vxlm rfqz";
            string resetLink = token;

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(fromEmail);
            mail.To.Add(email);
            mail.Subject = "Password Reset Request";
            mail.Body = $"Enter this token to reset your password: {resetLink}";

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new System.Net.NetworkCredential(fromEmail, fromPassword),
                EnableSsl = true,
            };

            try
            {
                smtpClient.Send(mail);
                MessageBox.Show("A password reset link has been sent to your email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}