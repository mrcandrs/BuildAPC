using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace BuildAPC
{
    public partial class ResetPasswordForm : Form
    {
        private string token;
        public ResetPasswordForm(string token)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.token = token;
            Console.WriteLine("Token received: " + token); //Debugging line
        }

        private void buttonSubmit_Click_1(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string newPassword = textBoxNewPassword.Text;
            string confirmPassword = textBoxConfirmPassword.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter your username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please enter your new password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Check if the username exists
            if (!IsUsernameValid(username))
            {
                MessageBox.Show("Username does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Verify the token and update the password in the database
            ResetPassword(username, newPassword);
        }

        private bool IsUsernameValid(string username)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5A8FMDF;Initial Catalog=buildapc;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM account WHERE Name = @Name";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", username);
                    int userCount = (int)cmd.ExecuteScalar();
                    Console.WriteLine("Username valid: " + (userCount > 0)); //Debugging line
                    return userCount > 0;
                }
            }
        }

        private void ResetPassword(string username, string newPassword)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5A8FMDF;Initial Catalog=buildapc;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                try
                {
                    conn.Open();
                    //Ensure the token is valid
                    string tokenValidationQuery = "SELECT COUNT(*) FROM PasswordResetTokens WHERE Token = @Token";
                    using (SqlCommand tokenCmd = new SqlCommand(tokenValidationQuery, conn))
                    {
                        tokenCmd.Parameters.AddWithValue("@Token", token);
                        int tokenCount = (int)tokenCmd.ExecuteScalar();
                        if (tokenCount == 0)
                        {
                            MessageBox.Show("Invalid token.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        Console.WriteLine("Token is valid"); //Debugging line

                        //Update the password for the corresponding username
                        string updateQuery = @"
                            UPDATE account 
                            SET Password = @Password 
                            WHERE Name = @Name";

                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@Password", newPassword);
                            updateCmd.Parameters.AddWithValue("@Name", username);

                            int rowsAffected = updateCmd.ExecuteNonQuery();
                            Console.WriteLine("Rows affected: " + rowsAffected); //Debugging line

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Your password has been reset successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoginForm loginForm = new LoginForm();
                                loginForm.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Failed to reset password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkBoxShowPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            bool isChecked = checkBoxShowPassword.Checked;
            textBoxNewPassword.UseSystemPasswordChar = !isChecked;
            textBoxConfirmPassword.UseSystemPasswordChar = !isChecked;
        }
    }
}