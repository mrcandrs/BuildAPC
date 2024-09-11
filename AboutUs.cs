using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AboutUs : Form
    {
        public string uName;
        public string customer_id;
        public AboutUs(string uName, string customer_id)
        {
            InitializeComponent();
            label5.Text = uName;
            label6.Text = customer_id;
        }

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]

        private static extern bool ReleaseCapture();
        private void button2_Click(object sender, EventArgs e)
        {
            OrderingForm order = new OrderingForm(label5.Text, label6.Text);
            this.Hide();
            order.Show();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Exit the Application?", "Build-A-PC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button_Home_Click(object sender, EventArgs e) //home button
        {
            Dashboard dashboard = new Dashboard(label5.Text, label6.Text);
            this.Hide();
            dashboard.Show();
        }

        private void button_Home_Paint(object sender, PaintEventArgs e)
        {

            ControlPaint.DrawBorder(e.Graphics, button_Home.ClientRectangle,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void button_Order_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button_Order.ClientRectangle,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void button_AboutUs_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button_AboutUs.ClientRectangle,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void button_Products_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button_Products.ClientRectangle,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
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

        private void button_Back_Click(object sender, EventArgs e)
        {
            OrderingForm order = new OrderingForm(label5.Text, label6.Text);
            this.Hide();
            order.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_Back_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button_Back.ClientRectangle,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void button_LogOut_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button_LogOut.ClientRectangle,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {

        }

        private void button_AboutUs_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs(label5.Text, label6.Text);
            this.Hide();
            aboutUs.Show();
        }

        private void button_Products_Click(object sender, EventArgs e)
        {
            Products products = new Products(label5.Text, label6.Text);
            this.Hide();
            products.Show();
        }

        private void button_LogOut_Click(object sender, EventArgs e)
        {
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Build-A-PC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    DialogResult dialog2 = MessageBox.Show("You have been logged out.", "Build-A-PC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    if (dialog2 == DialogResult.OK)
                    {
                        LoginForm login = new LoginForm();
                        this.Hide();
                        login.ShowDialog();
                    }
                }
            }
        }

        private void linkLabel_Facebook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=61561120252369&mibextid=ZbWKwL");
        }

        private void linklabel_IG_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/build_a.pc?igsh=MWtldHplYXZ1NzJyaw==");
        }

        private void linkLabel_Tiktok_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tiktok.com/@build_apc?_t=8n7zI6Bzyjp&_r=1");
        }
    }
}
